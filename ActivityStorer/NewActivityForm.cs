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

namespace ActivityStorer
{
    public partial class NewActivityForm : Form
    {
        private List<string> _workerList;

        public NewActivityForm()
        {
            InitializeComponent();
            CenterToParent();
            Text = "Activity Storer " + ActivityStorerLauncher.GetVersionAsString() + " - Register new activity";
            fileStateResult.Text = "Not saved";
            activityStartInput.Value = DateTime.Now.AddHours(-1);
            activityEndInput.Value = DateTime.Now;
            dateInput.MaxDate = DateTime.Today;
            dateInput.Value = DateTime.Today;
            _workerList = Program.GetWorkers();
            LoadWorkers();
            Program.launcher.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (descriptionInput.Text.IsEmpty() || coworkerInput.CheckedItems.Count == 0)
            {
                fileStateResult.ForeColor = Color.Red;
                fileStateResult.Text = descriptionInput.Text.IsEmpty() ? "The description is required." : "At least 1 worker is required.";
                return;
            }

            ICsvTable table = new CsvTable("Activity start", "Activity end", "Description", "Co-workers", "Ticket", "Branch", "Commit");
            table["Activity start"].AddRow(activityStartInput.Value.ToString("HH:mm"));
            table["Activity end"].AddRow(activityEndInput.Value.ToString("HH:mm"));
            table["Description"].AddRow(descriptionInput.Text.Replace(Environment.NewLine, Program.LineBreak));
            table["Co-workers"].AddRow(string.Join("|", coworkerInput.CheckedItems.OfType<string>().ToList()));
            table["Ticket"].AddRow(ticketInput.Text.Remove("Ticket", "ticket", "_"));
            table["Branch"].AddRow(branchInput.Text);
            table["Commit"].AddRow(commitInput.Text);
            DateTime date = dateInput.Value;

            string filePath = Path.Combine(Program.ActivityStorage, $"{date:yyyy\\\\MM}");
            string fullFileName = Path.Combine(filePath, $"{date:yyyy-MM-dd}.csv");

            DirectoryHelper.Exist(fullFileName, true);

            bool fileExists = File.Exists(fullFileName);

            List<string> csvTable = table.ToList(!fileExists);

            if (fileExists)
            {
                File.AppendAllLines(fullFileName, csvTable);
                return;
            }

            File.Create(fullFileName).Close();
            File.AppendAllLines(fullFileName, csvTable);
            ResetInputs();
            
            fileStateResult.ForeColor = Color.Green;
            fileStateResult.Text = "File saved!";
        }

        private void ResetInputs()
        {
            descriptionInput.Text = string.Empty;
            ticketInput.Text = string.Empty;
            branchInput.Text = string.Empty;
            commitInput.Text = string.Empty;
            for (int i = 0; i < coworkerInput.Items.Count; i++)
            {
                coworkerInput.SetItemChecked(i, false);
            }
        }

        private void LoadWorkers()
        {
            coworkerInput.Items.Clear();

            foreach (var worker in _workerList)
            {
                coworkerInput.Items.Add(worker);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activityEndInput.Value = DateTime.Now;
        }
    }
}
