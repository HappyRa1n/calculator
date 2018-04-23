﻿using System;
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
            try
            {
                int t = Convert.ToInt32(st);
                if (t >= 1)
                {
                        frm.EnterText(textBox1.Text+"м");//вводим месяц в основную форму
                        frm.ClickResDate(true);
                        frm.ClickEntDate(false);
                        frm.ClickEnterDays(false);
                        frm.ClickEnterMonth(false);
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка!Введено некорректное или слишком большое число месяцев!");//вызываем окно ошибки
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Ошибка! Вы ввели слишком большое число!");//вызываем окно ошибки
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ошибка! Вы ввели не число!");
            } 
        }   
    }
}
