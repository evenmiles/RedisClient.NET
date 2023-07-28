namespace RedisClient.NET
{
    public partial class FormNewEntry : Form
    {
        public FormNewEntry()
        {
            InitializeComponent();
        }

        private void FormNewEntry_Load(object sender, EventArgs e)
        {
            textBoxKey.Text = string.Empty;
            textBoxContent.Text = string.Empty;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
