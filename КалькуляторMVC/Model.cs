using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Калькулятор
{
    static class Model
    {
        public static List<string> SignList = new List<string>() { "Сложение", "Вычитание", "Умножение", "Деление"};

        public static TextBox firstNumber, secondNumber;
        public static TextBlock rav, sign;

        static int SignNumber, RavNumber, IsFirst = 0;
        public static int SignChange
        {
            get 
            {       
                return SignNumber;
            }
            set 
            {
                SignNumber = value;
                switch (SignNumber)
                {
                    case 0://+
                        sign.Text = "+";
                        break;
                    case 1://-
                        sign.Text = "-";
                        break;
                    case 2://*
                        sign.Text = "*";
                        break;
                    case 3://\
                        sign.Text = "/";
                        break;
                }
            }
        }

        public static int firstN
        {
            get 
            {
                return Convert.ToInt32(firstNumber.Text);
            }
        }

        public static int secondN
        {
            get
            {
                return Convert.ToInt32(secondNumber.Text);
            }
        }

        public static int RAV
        {
            get
            {
                int opa = RavNumber;
                RavNumber = 0;
                return opa;                
            }
            set
            {
                if (IsFirst == 0)
                {
                    RavNumber = value;
                    IsFirst = 1;
                }
                else
                {
                    switch (SignNumber)
                    {
                        case 0://+
                            RavNumber += value;
                            break;
                        case 1://-
                            RavNumber -= value;
                            break;
                        case 2://*
                            RavNumber *= value;
                            break;
                        case 3://\
                            RavNumber /= value;
                            break;
                    }
                    IsFirst = 0;
                }
            }
        }
    }
}
