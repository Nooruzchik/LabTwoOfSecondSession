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

            seasonComboBox.DataSource = Enum.GetValues(typeof(Season)); // выводит значания Season в comboBox
        }
        /// <summary>
        /// выводит все наши перечисления в EnumsListBox
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.DisplayMember = "Name"; // выводит только имена перечислений вместо значений
            EnumsListBox.Items.Add(typeof(Colorix)); // вывод перечисления в EnumsListBox
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
                Array enumValues = Enum.GetValues(selectedEnum); // создание списка для сохранения значений перечислений
                ValuesListBox.Items.Clear(); // очистка списка значений
                foreach (var value in enumValues)
                {
                    ValuesListBox.Items.Add(value); // вывод значений в ValuesListBox
                }
            }
        }
        /// <summary>
        /// вывод числового значения соответсвующего значения
        /// </summary>
        private void ValueListBox_Changed(object sender, EventArgs e)
        {
            var selectedValue = ValuesListBox.SelectedItem;
            if (selectedValue != null)
            {
                int numericValue = (int)selectedValue; // явное преобразование
                intValueReturn.Text = numericValue.ToString();
            }
        }


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
                    replaceToInt.Text = "Нет такого дня недели";
                }
                else
                {
                    int numberOfDay = (int)parseDay;
                    replaceToInt.Text = $"Это день недели ({parseDay} = {numberOfDay})";
                }
            }
            else
            {
                replaceToInt.Text = "Нет такого дня недели";
            }
        }
        /// <summary>
        ///  функция для покраски формы
        /// </summary>
        private void goButton_click(object sender, EventArgs e)
        {
            Season selectedSeason = (Season)seasonComboBox.SelectedItem;

            switch (selectedSeason)
            {
                case Season.winter:
                    tabPage1.BackColor = Color.FromArgb(80, 152, 215);
                    MessageBox.Show("Бррр! Холодно!", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case Season.spring:
                    tabPage1.BackColor = Color.FromArgb(85, 156, 69);
                    break;
                case Season.summer:
                    tabPage1.BackColor = Color.FromArgb(236, 228, 61);
                    MessageBox.Show("Ура! Каникулы!", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case Season.autumn:
                    tabPage1.BackColor = Color.FromArgb(226, 156, 59);
                    MessageBox.Show("Пора батрачить в универе", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }

        private void ComboBox_change(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.White;
        }
    }
}
