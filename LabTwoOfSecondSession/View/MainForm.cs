using LabTwoOfSecondSession.Model.Enums;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabTwoOfSecondSession
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;

            seasonComboBox.DataSource = Enum.GetValues(typeof(Season)); // выводит значани€ Season в comboBox



        }
        /// <summary>
        /// выводит все наши перечислени€ в EnumsListBox
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.DisplayMember = "Name"; // выводит только имена перечислений вместо значений
            EnumsListBox.Items.Add(typeof(Colorix)); // вывод перечислени€ в EnumsListBox
            EnumsListBox.Items.Add(typeof(Weekday));
            EnumsListBox.Items.Add(typeof(EducationForm));
            EnumsListBox.Items.Add(typeof(Manufacture));
            EnumsListBox.Items.Add(typeof(Genre));
            EnumsListBox.Items.Add(typeof(Season));
        }

        /// <summary>
        /// вывод значений из пречислений во второй список ValuesListBox
        /// </summary>
        private void EnumsListBox_Changed(object sender, EventArgs e)
        {
            Type selectedEnum = EnumsListBox.SelectedItem as Type; // выбор из списака EnumsListBox

            if (selectedEnum != null) // проверка на выбор
            {
                Array enumValues = Enum.GetValues(selectedEnum); // создание списка дл€ сохранени€ значений перечислений
                ValuesListBox.Items.Clear(); // очистка списка значений
                foreach (var value in enumValues)
                {
                    ValuesListBox.Items.Add(value); // вывод значений в ValuesListBox
                }
            }
        }
        /// <summary>
        /// вывод числового значени€ соответсвующего значени€
        /// </summary>
        private void ValueListBox_Changed(object sender, EventArgs e)
        {
            var selectedValue = ValuesListBox.SelectedItem;
            if (selectedValue != null)
            {
                int numericValue = (int)selectedValue; // €вное преобразование
                intValueReturn.Text = numericValue.ToString();
            }
        }

        //private void buttonParse_Click(object sender, MouseEventArgs e)
        //{
        //    string userText = textBoxForWeek.Text;

        //    Weekday parseDay;

        //    bool parseSuccsesful = Enum.TryParse<Weekday>(userText, ignoreCase: true, out parseDay);

        //    if (parseSuccsesful)
        //    {
        //        int numberOfDay = (int)parseDay;

        //        replaceToInt.Text = $"Ёто день недели ({textBoxForWeek.Text} = {numberOfDay})";
        //    }

        //    else
        //    {
        //        replaceToInt.Text = "Ќет такого дн€ недели";
        //    }
        //}

        private void buttonParse_Click(object sender, MouseEventArgs e)
        {
            string userText = textBoxForWeek.Text;

            Weekday parseDay;


            bool parseSuccsesful = Enum.TryParse<Weekday>(userText, ignoreCase: true, out parseDay);

            if (parseSuccsesful)
            {

                bool isNumber = true;
                foreach (char c in userText)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                if (isNumber)
                {
                    replaceToInt.Text = "Ќет такого дн€ недели";
                }
                else
                {
                    int numberOfDay = (int)parseDay;
                    replaceToInt.Text = $"Ёто день недели ({parseDay} = {numberOfDay})";
                }
            }
            else
            {
                replaceToInt.Text = "Ќет такого дн€ недели";
            }
        }

        private void goButton_click(object sender, EventArgs e)
        {
            Season selectedSeason = (Season)seasonComboBox.SelectedItem;

            switch (selectedSeason)
            {
                case Season.winter: 
                    this.BackColor = Color.FromArgb(80, 152, 215);
                    MessageBox.Show("Ѕррр! ’олодно!", "¬рем€ года", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case Season.spring:
                    this.BackColor = Color.FromArgb(85, 156, 69); 
                    break;
                case Season.summer:
                    this.BackColor = Color.FromArgb(236, 228, 61);
                    MessageBox.Show("”ра!  аникулы!", "¬рем€ года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                
                case Season.autumn:                      
                    this.BackColor = Color.FromArgb(226,156, 59);
                    MessageBox.Show("ѕора батрачить в универе", "¬рем€ года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("„то-то пошло не так");
                    break;
            }
        }
    }
}
