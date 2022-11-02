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
    public partial class WorkerListForm : Form
    {
        private bool isModifying;
        public WorkerListForm()
        {
            InitializeComponent();
            CenterToParent();
            Text = $"Activity Storer {ActivityStorerLauncher.GetVersionAsString()} - Workers List";
            workerTextBox.PlaceholderText = $"Worker1Name Worker1Surname{Environment.NewLine}Worker2Name Worker2Surname{Environment.NewLine}";
            saveButton.Enabled = false;
            workerCheckedBox.Enabled = false;
            LoadWorkers();
            Program.launcher.Hide();
        }

        public void LoadWorkers()
        {
            var fullFilePath = Path.Combine(Program.SettingsStorage, "workerList.csv");

            var workerTable = new TTable();
            workerTable.CsvToTable(fullFilePath);

            workerCheckedBox.Items.Clear();

            foreach (var row in workerTable.GetColumns()[0].ColumnData)
            {
                workerCheckedBox.Items.Add(row.ToString().Remove(Environment.NewLine));
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var fullFilePath = Path.Combine(Program.SettingsStorage, "workerList.csv");
            var table = new TTable();
            table.AddColumn("Worker");

            foreach (var worker in workerTextBox.Text.Split(Environment.NewLine))
            {
                if (worker.IsNotEmpty())
                {
                    table.AddData("Worker", worker);
                }
            }

            var tableContent = table.TableToCsv();
            File.WriteAllLines(fullFilePath, tableContent);
            //LoadWorkers();
            modifyButton_Click(modifyButton, new EventArgs());
            workerTextBox.Text = string.Empty;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            isModifying = !isModifying;
            workerTextBox.Text = string.Empty;

            foreach (var worker in workerCheckedBox.Items)
            {
                workerTextBox.Text += worker + Environment.NewLine;
            }

            if (isModifying)
            {
                saveButton.Enabled = true;
                workerCheckedBox.Items.Clear();
            }
            else
            {
                saveButton.Enabled = false;
                LoadWorkers();
            }
        }
    }
}
