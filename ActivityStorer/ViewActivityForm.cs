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
using TsadriuUtilities.Csv.CsvObjects;
using TsadriuUtilities.Csv.CsvObjects.Enums;

namespace ActivityStorer
{
    public partial class ViewActivityForm : Form
    {
        private List<string> fileList;
        private List<string> currentFileContent;
        private bool _isOrderingActivityTime;

        public ViewActivityForm()
        {
            fileList = new List<string>();
            currentFileContent = new List<string>();
            InitializeComponent();
            CenterToParent();
            GetUserFiles();
            SetupDateInput();
            dateInput_DateChanged(this, new DateRangeEventArgs(DateTime.Today, DateTime.Today));
            Text = $"Activity Storer {ActivityStorerLauncher.GetVersionAsString()} - View past activities";
            ActivityStorerLauncher.Instance.Hide();
        }

        private void dateInput_DateChanged(object sender, DateRangeEventArgs e)
        {
            currentFileContent.Clear();
            DateTime selectedDate = dateInput.SelectionRange.Start;
            string fullFileName = Path.Combine(Program.ActivityStorage, $"{selectedDate:yyyy\\\\MM}", $"{selectedDate:yyyy-MM-dd}.csv");

            if (!File.Exists(fullFileName))
            {
                ResetParameters();
                rowInput.Enabled = false;
                rowInput.Value = 0;
                modifyButton.Enabled = false;
                return;
            }

            modifyButton.Enabled = true;
            rowInput.Enabled = true;
            var table = new TTable();
            table.CsvToTable(fullFileName);

            currentFileContent = table.TableToCsv();
            rowInput.Value = 1;
            DisplayInfo(1);
        }

        private void rowInput_ValueChanged(object sender, EventArgs e)
        {
            var max = currentFileContent.Count != 0 ? currentFileContent.Count - 1 : 0;
            var min = max == 0 ? 0 : 1;
            rowInput.Value = rowInput.Value.ClampValue(min, max);
            DisplayInfo((int)rowInput.Value);
        }

        private void GetUserFiles()
        {
            var fullFileName = Path.Combine(Program.ActivityStorage);

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
            if (currentFileContent.Count != 0)
            {
                workerInput.Items.Clear();

                var currentLine = currentFileContent[row].Split(";");
                activityStartInput.Value = currentLine[0].ToDateTime("HH:mm");
                activityEndInput.Value = currentLine[1].ToDateTime("HH:mm");
                activityDurationTextBox.Text = GetTotalTimePerTask(activityStartInput.Value, activityEndInput.Value).ToString();
                totalTimeSpentTextBox.Text = GetTotalTimePerDay().ToString();
                descriptionInput.Text = currentLine[2].Replace(Program.LineBreak, Environment.NewLine);
                List<string> workersInFile;

                if (currentLine[3].IsEmpty())
                {
                    workersInFile = new List<string>();
                }
                else
                {
                    workersInFile = currentLine[3].Split("|").ToList();
                }

                for (int i = 0; i < workersInFile.Count; i++)
                {
                    string? worker = workersInFile[i];
                    workerInput.Items.Add(worker);
                    workerInput.SetItemChecked(i, true);
                }

                ticketInput.Text = currentLine[4];
                branchInput.Text = currentLine[5];
                commitInput.Text = currentLine[6];
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            dateInput.Enabled = !dateInput.Enabled;
            activityStartInput.Enabled = !activityStartInput.Enabled;
            activityEndInput.Enabled = !activityEndInput.Enabled;
            descriptionInput.ReadOnly = !descriptionInput.ReadOnly;
            workerInput.Enabled = !workerInput.Enabled;
            ticketInput.ReadOnly = !ticketInput.ReadOnly;
            branchInput.ReadOnly = !branchInput.ReadOnly;
            commitInput.ReadOnly = !commitInput.ReadOnly;
            modifyButton.Text = activityStartInput.Enabled ? "Cancel" : "Modify";
            saveButton.Enabled = activityStartInput.Enabled;
            workerToAddLabel.Visible = !workerToAddLabel.Visible;
            workerToAddBox.Visible = !workerToAddBox.Visible;
            orderByTimeButton.Enabled = !orderByTimeButton.Enabled;

            if (activityStartInput.Enabled)
            {
                activityDurationTextBox.Text = string.Empty;
                totalTimeSpentTextBox.Text = string.Empty;
            }
            else
            {
                if (_isOrderingActivityTime)
                {
                    int selectedRow = (int)rowInput.Value;
                    _isOrderingActivityTime = false;
                    dateInput_DateChanged(new object(), null);
                    rowInput.Value = selectedRow;
                    rowInput_ValueChanged(new object(), EventArgs.Empty);
                    DisplayInfo(selectedRow);
                    return;
                }

                DisplayInfo((int)rowInput.Value);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (descriptionInput.Text.IsEmpty() || (workerInput.CheckedItems.Count == 0 && workerToAddBox.Text.Split(Environment.NewLine).Length == 0))
            {
                fileStateResult.ForeColor = Color.Red;
                fileStateResult.Text = descriptionInput.Text.IsEmpty() ? "The description is required." : "Req. at least 1 co-worker.";
                fileStateResult.Show();
                return;
            }
            string userStart = activityStartInput.Value.ToString("HH:mm");
            string userEnd = activityEndInput.Value.ToString("HH:mm");
            string userDescription = descriptionInput.Text.Replace(Environment.NewLine, Program.LineBreak);
            List<string> listOfWorkers = workerInput.CheckedItems.OfType<string>().ToList();
            List<string> listOfWorkersToAdd = workerToAddBox.Text.IsNotEmpty() ? workerToAddBox.Text.Split(Environment.NewLine).ToList() : new List<string>();

            foreach (var workerToAdd in listOfWorkersToAdd)
            {
                if (!listOfWorkers.Contains(workerToAdd))
                {
                    listOfWorkers.Add(workerToAdd);
                }
            }

            string userWorkers = string.Join("|", listOfWorkers);
            string userTicket = ticketInput.Text;
            string userBranch = branchInput.Text;
            string userCommit = commitInput.Text;
            string content = string.Join(";", userStart, userEnd, userDescription, userWorkers, userTicket, userBranch, userCommit);

            string fullFileName = Path.Combine(Program.ActivityStorage, $"{dateInput.SelectionRange.Start:yyyy\\\\MM}", $"{dateInput.SelectionRange.Start:yyyy-MM-dd}.csv");

            currentFileContent[(int)rowInput.Value] = content;

            File.WriteAllLines(fullFileName, currentFileContent);

            fileStateResult.ForeColor = Color.Green;
            fileStateResult.Text = "Saved";
            fileStateResult.Show();
            modifyButton_Click(this, new EventArgs());
        }

        private void ResetParameters()
        {
            rowInput.Value = 0;
            activityStartInput.Value = DateTime.Today;
            activityEndInput.Value = DateTime.Today;
            descriptionInput.Text = string.Empty;
            workerInput.Items.Clear();
            ticketInput.Text = string.Empty;
            branchInput.Text = string.Empty;
            commitInput.Text = string.Empty;
            modifyButton.Text = "Modify";
            saveButton.Enabled = false;
            activityDurationTextBox.Text = string.Empty;
            totalTimeSpentTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Calculates the time spent on a task (Only increments every 15 minutes).
        /// </summary>
        /// <param name="activityStart">The start of the activity.</param>
        /// <param name="activityEnd">The end of the activity.</param>
        /// <returns>The total time spent on a task.</returns>
        private double GetTotalTimePerTask(DateTime activityStart, DateTime activityEnd)
        {
            TimeSpan difference = activityEnd - activityStart;

            var tickerHours = difference.Hours;
            var ticketMinutes = 0;

            if (difference.Minutes < 7)
            {
                ticketMinutes = 0;
            }
            else if (difference.Minutes >= 7 && difference.Minutes < 22)
            {
                ticketMinutes = 15;
            }
            else if (difference.Minutes >= 22 && difference.Minutes < 37)
            {
                ticketMinutes = 30;
            }
            else if (difference.Minutes >= 37 && difference.Minutes < 52)
            {
                ticketMinutes = 45;
            }
            else if (difference.Minutes >= 52)
            {
                ticketMinutes = 0;
                tickerHours++;
            }

            return tickerHours + (ticketMinutes / 60d);
        }

        private double GetTotalTimePerDay()
        {
            if (currentFileContent.Count != 0)
            {
                double totalTime = 0.0d;

                foreach (var currentRow in currentFileContent)
                {
                    var rowContent = currentRow.Split(";");

                    totalTime += GetTotalTimePerTask(rowContent[0].ToDateTime("HH:mm"), rowContent[1].ToDateTime("HH:mm"));
                }

                return totalTime;
            }

            return 0.0d;
        }

        private void orderByTimeButton_Click(object sender, EventArgs e)
        {
            if (currentFileContent == null || currentFileContent.Count == 0)
            {
                return;
            }

            ICsvTable table = new CsvTable(currentFileContent, ";");
            table.OrderTable("Activity start", CsvSearchType.Equal);
            currentFileContent = table.ToList();

            rowInput_ValueChanged(new object(), EventArgs.Empty);
            modifyButton_Click(new object(), EventArgs.Empty);
            _isOrderingActivityTime = true;
        }
    }
}
