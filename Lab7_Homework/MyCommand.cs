using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab7_Homework
{
    class MyCommand
    {
        public static RoutedCommand Help { get; set; }
        static MyCommand()
        {
            Help = new RoutedCommand();
        }
    }
}
