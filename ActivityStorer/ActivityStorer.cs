namespace ActivityStorer
{
    public partial class ActivityStorer : Form
    {
        public ActivityStorer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newActivity = new NewActivityForm();
            newActivity.Show();
        }
    }
}