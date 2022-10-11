using ActivityStorer.Enums;
using TsadriuUtilities;

namespace ActivityStorer
{
    public partial class ActivityStorerLauncher : Form
    {
        public static ActivityStorerLauncher Instance;
        private static VersionEnum currentVersion = VersionEnum.V1_0_0;
        private static string fileDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public ActivityStorerLauncher()
        {
            Instance = this;
            InitializeComponent();
            Text = $"Activity Storer {GetVersionAsString()}";
        }

        public static string GetVersionAsString()
        {
            return currentVersion.ToString().Remove("V").Replace("_", ".");
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
    }
}