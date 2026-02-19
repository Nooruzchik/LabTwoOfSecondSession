using System.Windows.Forms;
using LabTwoOfSecondSession.Model.Enums;

namespace LabTwoOfSecondSession
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.Add(typeof(Colorix).Name);
            EnumsListBox.Items.Add(typeof(Weekday).Name);
            EnumsListBox.Items.Add(typeof(EducationForm).Name);
            EnumsListBox.Items.Add(typeof(Manufacture).Name);
            EnumsListBox.Items.Add(typeof(Genre).Name);
            EnumsListBox.Items.Add(typeof(Season).Name);
        }
    }
}
