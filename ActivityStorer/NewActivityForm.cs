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
    public partial class NewActivityForm : Form
    {
        public NewActivityForm()
        {
            InitializeComponent();
            CenterToParent();
            Text = "Activity Storer " + ActivityStorerLauncher.GetVersionAsString() + " - Register new acvitity";
            fileStateResult.Text = "Not saved";
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
            var date = dateInput.Value;
            var table = new TTable();
            table.AddColumn("Activity start", "Activity end", "Description", "Co-workers", "Ticket", "Branch", "Commit");
            table.AddData("Activity start", activityStartInput.Value.ToString("HH:mm"));
            table.AddData("Activity end", activityEndInput.Value.ToString("HH:mm"));
            table.AddData("Description", descriptionInput.Text.Replace(Environment.NewLine, "§NEW_LINE_BREAK§"));
            table.AddData("Co-workers", string.Join("|", coworkerInput.CheckedItems.OfType<string>().ToList()));
            table.AddData("Ticket", ticketInput.Text.Remove("Ticket", "ticket", "_"));
            table.AddData("Branch", branchInput.Text);
            table.AddData("Commit", commitInput.Text);

            var path = Path.Combine(Program.ActivityStorage, $"{date:yyyy\\\\MM}");
            var fullFileName = Path.Combine(path, $"{date:yyyy-MM-dd}.csv");

            DirectoryHelper.Exist(fullFileName, true);

            var csvContent = table.TableToCsv();

            if (File.Exists(fullFileName))
            {
                csvContent = table.TableToCsv(false);
                File.AppendAllLines(fullFileName, csvContent);
            }
            else
            {
                File.Create(fullFileName).Close();
                File.AppendAllLines(fullFileName, csvContent);
            }

            descriptionInput.Text = string.Empty;
            ticketInput.Text = string.Empty;
            branchInput.Text = string.Empty;
            commitInput.Text = string.Empty;
            for (int i = 0; i < coworkerInput.Items.Count; i++)
            {
                coworkerInput.SetItemChecked(i, false);
            }
            fileStateResult.ForeColor = Color.Green;
            fileStateResult.Text = "File saved!";
        }
    }
}
