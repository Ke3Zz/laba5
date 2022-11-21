using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Яхты : Form
    {
        Дополнительный _дополнительный = new Дополнительный();
        AboutBox1 _aboutBox = new AboutBox1();
        ToolTip _toolTip = new ToolTip();
        public Яхты()
        {
            InitializeComponent();
            _toolTip.SetToolTip(button3, "Выход");
            _toolTip.SetToolTip(button2, "О программе");
            _toolTip.SetToolTip(button1, "Дополнительно");
            _toolTip.SetToolTip(textBox1, "Введите фио");
            _toolTip.SetToolTip(textBox2, "Введите название яхты");
            _toolTip.SetToolTip(textBox3, "Введите порт прибывания");
            _toolTip.SetToolTip(numericUpDown1, "Введите кол-во персонала");
            _toolTip.SetToolTip(comboBox1, "Выберите класс яхты");
            _toolTip.SetToolTip(numericUpDown2, "Введите стоимость");
            _toolTip.SetToolTip(numericUpDown3, "Введите водоизмещение");

        }

        private void buttonAdditionally_Click(object sender, EventArgs e)
        {
            _дополнительный.Show();
        }
        private void buttonAboutProgramm_Click(object sender, EventArgs e)
        {
            
            _aboutBox.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
