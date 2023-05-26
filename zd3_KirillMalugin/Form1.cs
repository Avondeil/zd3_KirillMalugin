using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_KirillMalugin
{
    public partial class Form1 :Form
    {
        Qp dp;
        public Form1 ()
        {
            InitializeComponent( );
            dp = new Qp(listBox1);
        }

        private void Form1_Load (object sender, EventArgs e)
        {
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try {
                dp.Name = textBox1.Text; dp.Basesalary = double.Parse(textBox2.Text); dp.Coefficient = double.Parse(textBox3.Text); dp.p = int.Parse(textBox4.Text);
                if ( dp.sc == true && textBox1.Text!="")
                {
                    dp.Add( );
                    MessageBox.Show("Данные добавлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBox1.Items.Clear( );
                    dp.GetAllList( );
                }
            }
            catch { MessageBox.Show("Некорректный ввод данных, возможно пустые значения или ввод букв в поля, где это не предусмотренно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void button2_Click (object sender, EventArgs e)
        {
            
        }

        private void label5_Click (object sender, EventArgs e)
        {

        }

        private void button3_Click (object sender, EventArgs e)
        {
            if ( textBox5.Text != "" )
            {
                dp.Remove(textBox5.Text);
                listBox1.Items.Clear( );
                dp.GetAllList( );
            }
            else
            {
                MessageBox.Show("Пуская строка имени для удаления, повторите ввод", "Сообщение", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
