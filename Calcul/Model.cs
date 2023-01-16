using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calcul
{
    internal class Model
    {
        static int count = 0;
        public static List<string> operation = new List<string> { "Сложение", "Вычитание", "Умножение","Деление" };
        public static List<string> opertor = new List<string> { "+", "-", "*", "/" };
        // блок для обращения к текстовым полям
        public static TextBox firstOperand;
        public static TextBox secondOperand;
        public static TextBox tbResult;
        public static TextBox tbResult;

        public static int Combo  
        {
            set
            {
                tbResult.Text = operation[value];
            }
        }

    }
}
