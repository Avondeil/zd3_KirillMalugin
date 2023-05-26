using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_KirillMalugin
{
    class Qp:Department
    {
        private List<string> depart=new List<string>();
        private int P;
        private ListBox listBox;


        public Qp(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public int p
        {
            get 
            {
                return P;
            }
            set 
            {
                if ( value > 0 && value <= 3 )
                {
                    P = value;
                    sc = true;
                }
                else
                {
                    MessageBox.Show("Значение вредности должно быть в промежутке от 0 до 3 включительно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sc = false;
                }
            }
        }


        public void Remove (string name)
        {
            //Параметры для проверки
            int countBefore = depart.Count; 
            depart.RemoveAll(depart => depart.Contains($"Название отдела:{name}"));
            int countAfter = depart.Count;
            if (countAfter < countBefore)
            {
                MessageBox.Show($"Отдел {name} удален");
            }
            else
            {
                MessageBox.Show("Отдел не найден");
            }
        }
        public double Qpres()
        {
            return q() + (q() / p);
        }
        public void Add ()
        {
            depart.Add($"Название отдела:{Name}, базовый оклад: {Basesalary}, кэф: {Coefficient}, P={p}. Q={q( )}, Qp={Qpres()}");
        }

        public void GetAllList ()
        {
            foreach ( var contact in depart )
            {
                listBox.Items.Add(contact);
            }
        }

    }
}
