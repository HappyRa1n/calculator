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
    public partial class Form1 : Form
    {
        public bool flag=false;//флаг для проверки наличия операции + или -
        public bool TypeData = true;//флаг переключения форматов даты (true-российский формат)
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormatData_SelectedIndexChanged(object sender, EventArgs e)//нажатие переключателя форматы даты
        {
            TypeData = !TypeData;//Меняем флаг переключателя форматов даты.
        }

        private void Delete_Click(object sender, EventArgs e)//нажатие клавиши delete
        {
            string t = EnterT.Text;
            if (t != "")//проверяем наличие текста
            {
                string tmp;
                if (t[t.Length - 1] == '+' || t[t.Length - 1] == '-')
                {
                    ClickMinus(true);
                    ClickPlus(true);
                    ClickEnterMonth(false);
                    ClickEnterDays(false);
                    ClickEntDate(false);
                    tmp = t.Substring(0, t.Length - 1);//удаляем поселдний знак
                }
                else
                {
                    tmp = t.Substring(0, t.Length - 10);//удаляем дату
                }
                EnterT.Text = tmp;
            }
            t = EnterT.Text;
            if (t == "")
                EnableTypeOfDate(true);
        }
        private void EnterData_Click(object sender, EventArgs e)//форма ввода даты
        {
            Form2 newForm = new Form2(this);
            newForm.ShowDialog();//подключаем форму ввода даты
            if (flag == true)
            {

            }
        }
        public void ClickResDate(bool b1)
        {
            ResDate.Enabled=b1;
        }
        public void ClickEnterMonth(bool b1)//включаем отключаем ввод месяцев
        {
            EnterMonth.Enabled = b1;
        }
        public void ClickEnterDays(bool b1)//включаем отключаем ввод дней
        {
            EnterDays.Enabled = b1;
        }
        public void ClickResHours(bool b1)//=Часы включение выключение
        {
            ResHours.Enabled = b1;
        }
        public void ClickResDays(bool b1)//=Дни включение выключение кнопки
        {
            ResDays.Enabled = b1;
        }
        public void ClickResWeeks(bool b1)//=Недели включение отключение кнопки
        {
            ResWeeks.Enabled = b1;
        }
        public void ClickResMonth(bool b1)//=Month включение отключение
        {
            ResMonth.Enabled = b1;
        }
        public void ClickResMinutes(bool b1)//=Minutes включение отключение
        {
            ResMinutes.Enabled = b1;
        }
        public void ClickResSecond (bool b1)//включаем выключаем секунды
        {
            ResSeconds.Enabled = b1;
        }
        public void ClickPlus(bool b1)//включаем выключаем кнопку плюса
        {
            plus.Enabled = b1;
        }
        public void ClickMinus(bool b1)//включаем выключаем кнопку минуса
        {
            minus.Enabled = b1;
        }
        public void ClickEntDate(bool b1)//включаем выключаем кнопку ввода даты
        {
            EnterData.Enabled = b1;
        }
        public void EnableTypeOfDate(bool b1)//включаем выключаем смену формата даты
        {
            FormatData.Enabled = b1;
        }
        public void EnterText(string str)//изменяем строку ввода
        {
            EnterT.Text = EnterT.Text + str;
        }

        private void minus_Click(object sender, EventArgs e)//нажатие на кнопку минуса
        {
            flag =true;
            EnterText("-");
            ClickMinus(false);//отклчили кнопку
            ClickPlus(false);//отклчили кнопку
            ClickEntDate(true);
            ClickEnterDays(true);
            ClickEnterMonth(true);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            flag = true;
            EnterText("+");
            ClickMinus(false);//отклчили кнопку
            ClickPlus(false);//отклчили кнопку
            ClickEnterDays(true);
            ClickEnterMonth(true);
        }
    }
}
