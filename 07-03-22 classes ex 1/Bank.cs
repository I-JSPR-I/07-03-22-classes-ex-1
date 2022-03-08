using System;
using System.Collections.Generic;
using System.Text;

namespace _07_03_22_classes_ex_1
{
    class Bank
    {
        public int Stand;
        public int Limit;
        public int Verichtingen;

        public Bank()
        {
            Stand = 0;
            Limit = -1000;
            Verichtingen = 0;
        }
        public Bank(int GestortGeld)
        {
            Stand = Stand + GestortGeld;
        }
    }
}
