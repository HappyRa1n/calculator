using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Form3 : Form
    {        
        Form1 frm;
        public Form3()
        {
            InitializeComponent();
            
        }
        public Form3(Form1 f)
        {
            InitializeComponent();
            frm = f;//связь с первой формой


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e )
        {
            
            string st;
            st = textBox1.Text;
            int t = Convert.ToInt32(st);

            if (t >= 1)
            {
                if (!frm.flag)
                {
                    frm.EnterText(textBox1.Text);//вводим дату в основную форму
                    frm.EnableTypeOfDate(false);
                    frm.ClickEntDate(false);
                    frm.ClickMinus(true);
                    frm.ClickPlus(true);
                    frm.ClickEnterDays(false);
                    frm.ClickEnterMonth(false);
                }
                else
                {
                    frm.ClickEntDate(false);
                    frm.EnterText(textBox1.Text);
                    frm.ClickEnterDays(false);
                    frm.ClickEnterMonth(false);
                    frm.ClickResDays(true);
                    frm.ClickResHours(true);
                    frm.ClickResMinutes(true);
                    frm.ClickResMonth(true);
                    frm.ClickResWeeks(true);
                    frm.ClickResSecond(true);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка! Введен неверный формат даты!" );//вызываем окно ошибки
            }
        }

        
    }
}
