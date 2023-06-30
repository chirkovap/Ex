using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FinalRound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Theater theater = new Theater();
        int f1, f2 = 0;
        int n = Globals.Variable;
        public bool UpdateInfo(int n)
        {
            label7.Text = $"Осталось заявок: {n}";
            if (n == 0)
            {
                return false;
            }
            else return true;
        }

        public Dictionary<string, List<string>> ShowsAndSchools = new Dictionary<string, List<string>>();

        public bool IsContainPairs(string show, string school)
        {
            if (!ShowsAndSchools.ContainsKey(show)) return false;
            if (ShowsAndSchools.ContainsKey(show) && ShowsAndSchools[show].Contains(school)) return true;
            else return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "Добро пожаловать!";
            textBox4.ScrollBars = ScrollBars.Vertical;
            UpdateInfo(n);
            button3.Enabled = false;
            textBox3.Enabled = false;
            button4.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            MessageBox.Show("1. Нельзя оставлять поля пустыми. \r\n" +
                "2. В поле покупки билетов нельзя вводить буквы.\r\n" +
                "3. В поля нельзя вводить спецсимволы.\r\n" +
                "4. Не ломайте, пожалуйста ничего.\r\n", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textFieldValue = textBox1.Text.Trim();
            string searchItem = textBox1.Text.TrimStart().TrimEnd();
            bool itemExists = false;

            foreach (var item in comboBox1.Items)
            {
                if (string.Equals(item.ToString(), searchItem, StringComparison.OrdinalIgnoreCase))
                {
                    itemExists = true;
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(textFieldValue))
            {
                label6.Text = $"Название спектакля не может быть пустым";
                label6.BackColor = Color.Yellow;
                //textBox1.Text = "";
            }
            else if (Regex.IsMatch(textFieldValue, @"^\d+$"))
            {
                label6.Text = $"Название не может состоять только из цифр";
                label6.BackColor = Color.Yellow;
                //textBox1.Text = "";
            }
            else if (Regex.IsMatch(textFieldValue, @"[~`!@#$%^&*()\-_=+\[\]{}\\|;:'"",<.>/?]"))
            {
                label6.Text = $"Название не может содержать спец. символы";
                label6.BackColor = Color.Yellow;
                //textBox2.Text = "";
            }
            else if (textBox1.Text.All(Char.IsPunctuation))
            {
                label6.Text = $"Название не может быть знаком препинания";
                label6.BackColor = Color.Yellow;
            }
            else if (!itemExists)
            {
                if (UpdateInfo(n))
                {
                    string str = textBox1.Text.TrimStart().TrimEnd();
                    theater.CreateShow(str);
                    comboBox1.Items.Add(textBox1.Text.TrimStart().TrimEnd());
                    label6.Text = $"Спектакль \"{textBox1.Text.TrimStart().TrimEnd()}\" добавлен.";
                    label6.BackColor = Color.LightGreen;
                    f1 = 1;
                    comboBox1.Enabled = true;
                    if (f1 + f2 == 2)
                    {
                        button3.Enabled = true;
                        textBox3.Enabled = true;
                        button4.Enabled = true;
                    }
                    textBox1.Text = "";
                }
                else
                {
                    label6.Text = $"У вас закончились заявки.";
                    label6.BackColor = Color.Yellow;
                }
            }
            else
            {
                label6.Text = $"Такой спектакль уже существует.";
                label6.BackColor = Color.Yellow;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textFieldValue = textBox2.Text.Trim();
            string searchItem = textBox2.Text.TrimStart().TrimEnd();
            bool itemExists = false;

            foreach (var item in comboBox2.Items)
            {
                if (string.Equals(item.ToString(), searchItem, StringComparison.OrdinalIgnoreCase))
                {
                    itemExists = true;
                    break;
                }
            }
            if (string.IsNullOrWhiteSpace(textFieldValue))
            {
                label6.Text = $"Название школы не может быть пустым";
                label6.BackColor = Color.Yellow;
                //textBox2.Text = "";
            }
            else if (Regex.IsMatch(textFieldValue, @"^\d+$"))
            {
                label6.Text = $"Название не может состоять только из цифр";
                label6.BackColor = Color.Yellow;
                //textBox2.Text = "";
            }
            else if (Regex.IsMatch(textFieldValue, @"[~`!@#$%^&*()\-_=+\[\]{}\\|;:'"",<.>/?]"))
            {
                label6.Text = $"Название не может содержать спец. символы";
                label6.BackColor = Color.Yellow;
                //textBox2.Text = "";
            }
            else if (textBox2.Text.All(Char.IsPunctuation))
            {
                label6.Text = $"Название не может быть знаком препинания";
                label6.BackColor = Color.Yellow;
            }
            else if (!itemExists)
            {
                if (UpdateInfo(n))
                {
                    comboBox2.Items.Add(textBox2.Text.TrimStart().TrimEnd());
                    label6.Text = $"Школа \"{textBox2.Text.TrimStart().TrimEnd()}\" добавлена.";
                    label6.BackColor = Color.LightGreen;
                    f2 = 1;
                    comboBox2.Enabled = true;
                    if (f1 + f2 == 2)
                    {
                        button3.Enabled = true;
                        textBox3.Enabled = true;
                        button4.Enabled = true;
                    }
                    textBox2.Text = "";
                }
                else
                {
                    label6.Text = $"У вас закончились заявки.";
                    label6.BackColor = Color.Yellow;
                }

            }
            else
            {
                label6.Text = $"Такая школа уже есть.";
                label6.BackColor = Color.Yellow;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (UpdateInfo(n))
            {
                if (int.TryParse(textBox3.Text, out int tickets))
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "")
                    {
                        if (tickets > 0 && tickets <= 1000)
                        {
                            if (!IsContainPairs(comboBox1.Text, comboBox2.Text))
                            {
                                theater.AddSchoolAndTickets(comboBox1.Text, comboBox2.Text, tickets);
                                textBox4.Text = theater.DisplayCurrentShow(comboBox1.Text);
                                n -= 1;
                                UpdateInfo(n);
                                if (!ShowsAndSchools.ContainsKey(comboBox1.Text))
                                {
                                    ShowsAndSchools[comboBox1.Text] = new List<string>();
                                }
                                ShowsAndSchools[comboBox1.Text].Add(comboBox2.Text);
                                textBox3.Text = "";
                                label6.Text = "";
                            }
                            else
                            {
                                label6.Text = $"Такая пара Спектакль - Школа уже существует.";
                                label6.BackColor = Color.Yellow;
                            }

                        }
                        else
                        {
                            label6.Text = $"Количество билетов должно быть в диапозоне от 1 до 1000.";
                            label6.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        label6.Text = $"Заполните все поля.";
                        label6.BackColor = Color.Yellow;
                    }


                }
                else
                {
                    label6.Text = $"Поле \"{label5.Text}\" должно содержать только целые числа не более 1000.";
                    label6.BackColor = Color.Yellow;
                }
            }
            else
            {
                label6.Text = $"У вас закончились заявки.";
                label6.BackColor = Color.Yellow;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!UpdateInfo(n))
            {
                MessageBox.Show(theater.DisplayShows(), "Отсортировано!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label6.Text = "";
            }
            else
            {
                label6.Text = $"У еще остались заявки.";
                label6.BackColor = Color.Yellow;
            }

            //MessageBox.Show(theater.DisplayShows(), "Отсортировано!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //label6.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = theater.DisplayCurrentShow(comboBox1.Text);
            label6.Text = "";
        }
    }
}