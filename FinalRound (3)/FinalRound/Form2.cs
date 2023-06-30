using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalRound
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                Globals.Variable = n;
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
            else if (String.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "Введите значение";
                label1.BackColor = Color.Yellow;
            }
            else /*if (!(n > 0) &&  !(n <= 20))
            {
                label1.Text = $"Количество заявок должно быть в диапозоне от 0 до 20.";
                label1.BackColor = Color.Yellow;
            }*/
            {
                label1.Text = $"Поле \"{label2.Text}\" должно содержать только целые положительные числа\r\n" +
                    $"не более 2147483647.";
                label1.BackColor = Color.Yellow;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FinalRound
{
    public static class Globals
    {
        public static string Variable;
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n))
            {

            }
            else
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

        }
    }
}

*/