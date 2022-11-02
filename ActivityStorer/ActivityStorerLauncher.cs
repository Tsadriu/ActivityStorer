using ActivityStorer.Enums;
using TsadriuUtilities;

namespace ActivityStorer
{
    public partial class ActivityStorerLauncher : Form
    {
        public static ActivityStorerLauncher Instance;

        public ActivityStorerLauncher()
        {
            Instance = this;
            InitializeComponent();
            Text = $"Activity Storer {GetVersionAsString()}";
        }

        public static string GetVersionAsString()
        {
            return Program.GetVersionAsString().Remove("Version ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newActivity = new NewActivityForm();
            newActivity.Show();
        }

        private void viewActivityButton_Click(object sender, EventArgs e)
        {
            var viewActivity = new ViewActivityForm();
            viewActivity.Show();
        }

        private void workersButton_Click(object sender, EventArgs e)
        {
            var workerList = new WorkerListForm();
            workerList.Show();
        }
    }
}