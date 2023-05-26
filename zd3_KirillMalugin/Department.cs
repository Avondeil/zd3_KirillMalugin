using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_KirillMalugin
{
    public class Department
    {
        private string name;
        private double basesalary;
        private double coefficient;
        private bool scan = true;

        public Department (string name, double bases, double cef)
        {
            name = name; basesalary = bases; coefficient = cef;
        }
        public Department ()
        {
            
        }
        public bool sc 
        {
            get 
            {
                return scan;
            }
            set 
            {
                scan = value; 
            }
        }
        public double q()
        {
            return basesalary * (100 + coefficient);
        }

        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                if ( value != "" )
                {
                    name = value;
                    scan = true;
                }
                else 
                {
                    scan = false;
                    MessageBox.Show("Значение имени не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public double Basesalary
        {
            get
            {
                return basesalary;
            }
            set
            {
                if (value>0)
                {
                    basesalary = value;
                    scan = true;
                }
                else
                {
                    scan = false;
                    MessageBox.Show("Значение базового оклада не может быть отрицательным числом");
                }
            }
        }

        public double Coefficient
        {
            get
            {
                return coefficient;
            }
            set
            {
                if ( value > 0 )
                {
                    coefficient = value;
                    scan = true;
                }
                else
                {
                    scan = false;
                    MessageBox.Show("Значение коэффициента не может быть отрицательным числом");
                }
            }
        }
    }
}
