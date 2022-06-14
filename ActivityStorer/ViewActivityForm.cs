using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TsadriuUtilities;

namespace ActivityStorer
{
    public partial class ViewActivityForm : Form
    {
        private List<string> fileList;
        private List<string> currentFileContent;
        private DateTime currentSelectedDate;

        public ViewActivityForm()
        {
            fileList = new List<string>();
            currentFileContent = new List<string>();
            currentSelectedDate = DateTime.Today;
            InitializeComponent();
            CenterToParent();
            GetUserFiles();
            SetupDateInput();
            dateInput_DateChanged(this, new DateRangeEventArgs(DateTime.Today, DateTime.Today));
            Text = $"Activity Storer {ActivityStorer.GetVersionAsString()} - View past activities";
            ActivityStorer.Instance.Hide();
        }

        private void dateInput_DateChanged(object sender, DateRangeEventArgs e)
        {
            currentSelectedDate = dateInput.SelectionRange.Start;
            rowInput.Enabled = false;

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var selectedDate = dateInput.SelectionRange.Start;
            var fullFileName = Path.Combine(path, "Activity " + ActivityStorer.GetVersionAsString(), selectedDate.ToString("yyyy"), selectedDate.ToString("MM"));

            if (!Directory.Exists(fullFileName))
            {
                modifyButton.Enabled = false;
                return;
            }

            fullFileName = Path.Combine(fullFileName, selectedDate.ToString("yyyy-MM-dd") + ".csv");

            if (!File.Exists(fullFileName))
            {
                modifyButton.Enabled = false;
                return;
            }

            modifyButton.Enabled = true;
            rowInput.Enabled = true;
            var table = new TTable();
            table.CsvToTable(fullFileName);

            currentFileContent = table.TableToCsv();

            DisplayInfo(1);
        }

        private void rowInput_ValueChanged(object sender, EventArgs e)
        {
            rowInput.Value = rowInput.Value.ClampValue(1, currentFileContent.Count - 1); // -1 for index
            DisplayInfo((int)rowInput.Value);
        }

        private void GetUserFiles()
        {
            var fullFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Activity " + ActivityStorer.GetVersionAsString());

            if (!Directory.Exists(fullFileName))
            {
                return;
            }

            var yearFolders = Directory.GetDirectories(fullFileName);
            var temporaryFileList = new List<string>();

            foreach (var year in yearFolders)
            {
                var monthFolders = Directory.GetDirectories(year);

                foreach (var month in monthFolders)
                {
                    var files = Directory.GetFiles(month);

                    foreach (var file in files)
                    {
                        temporaryFileList.Add(file);
                    }
                }
            }

            fileList.AddRange(temporaryFileList);
        }

        /// <summary>
        /// Sets up the bold dates where there is a saved file. Example: If there's a file of the 2022-05-04, that number on the date will be bold.
        /// </summary>
        private void SetupDateInput()
        {
            var dates = new List<DateTime>();
            foreach (var file in fileList)
            {
                var date = Path.GetFileNameWithoutExtension(file).ToDateTime("yyyy-MM-dd");
                dates.Add(date);
            }

            dateInput.BoldedDates = dates.ToArray();
        }

        /// <summary>
        /// Displays the info to the user based on what date is selected and which row is selected.
        /// </summary>
        /// <param name="row">Row to display.</param>
        private void DisplayInfo(int row)
        {
            for (int i = 0; i < coworkerInput.Items.Count; i++)
            {
                coworkerInput.SetItemChecked(i, false);
            }

            var currentLine = currentFileContent[row].Split(";");
            activityStartInput.Value = currentLine[0].ToDateTime("HH:mm");
            activityEndInput.Value = currentLine[1].ToDateTime("HH:mm");
            descriptionInput.Text = currentLine[2].Replace("<newLine>", Environment.NewLine);
            var coworkersInFile = currentLine[3].Split("|");

            for (int i = 0; i < coworkerInput.Items.Count; i++)
            {
                foreach (var coworker in coworkersInFile)
                {
                    if (coworkerInput.Items[i].Equals(coworker))
                    {
                        coworkerInput.SetItemChecked(i, true);
                    }
                }
            }
            ticketInput.Text = currentLine[4];
            branchInput.Text = currentLine[5];
            commitInput.Text = currentLine[6];
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            dateInput.Enabled = !dateInput.Enabled;
            activityStartInput.Enabled = !activityStartInput.Enabled;
            activityEndInput.Enabled = !activityEndInput.Enabled;
            descriptionInput.ReadOnly = !descriptionInput.ReadOnly;
            coworkerInput.Enabled = !coworkerInput.Enabled;
            ticketInput.ReadOnly = !ticketInput.ReadOnly;
            branchInput.ReadOnly = !branchInput.ReadOnly;
            commitInput.ReadOnly = !commitInput.ReadOnly;
            modifyButton.Text = activityStartInput.Enabled ? "Cancel" : "Modify";
            saveButton.Enabled = activityStartInput.Enabled;

            if (!activityStartInput.Enabled)
            {
                DisplayInfo((int)rowInput.Value);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (descriptionInput.Text.IsEmpty() || coworkerInput.CheckedItems.Count == 0)
            {
                fileStateResult.ForeColor = Color.Red;
                fileStateResult.Text = descriptionInput.Text.IsEmpty() ? "Description\nrequired." : "Req. at least\n1 co-worker.";
                fileStateResult.Show();
                return;
            }
            var userStart = activityStartInput.Value.ToString("HH:mm");
            var userEnd = activityEndInput.Value.ToString("HH:mm");
            var userDescription = descriptionInput.Text.Replace(Environment.NewLine, "<newLine>");
            var userCoworkers = string.Join("|", coworkerInput.CheckedItems.OfType<string>().ToList());
            var userTicket = ticketInput.Text;
            var userBranch = branchInput.Text;
            var userCommit = commitInput.Text;
            var content = string.Join(";", userStart, userEnd, userDescription, userCoworkers, userTicket, userBranch, userCommit);

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var fullFileName = Path.Combine(path, "Activity " + ActivityStorer.GetVersionAsString(), dateInput.SelectionRange.Start.ToString("yyyy"), dateInput.SelectionRange.Start.ToString("MM"), dateInput.SelectionRange.Start.ToString("yyyy-MM-dd") + ".csv");
            currentFileContent[(int)rowInput.Value] = content;

            File.WriteAllLines(fullFileName, currentFileContent);

            fileStateResult.ForeColor = Color.Green;
            fileStateResult.Text = "Saved";
            fileStateResult.Show();
            modifyButton_Click(this, new EventArgs());
        }
    }
}
