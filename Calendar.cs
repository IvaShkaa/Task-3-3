using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Задание_3_2.Interfaces;

namespace Задание_3_2
{
    public class Calendar : IPrint
    {
        public void Print()
        {
            DateTime date = DateTime.Now.ToLocalTime();
            Console.WriteLine("Cейчас " + date.ToString("dddd", new CultureInfo("ru-RU")));
        }
    }
}
