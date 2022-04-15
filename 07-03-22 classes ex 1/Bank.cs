using System;
using System.Collections.Generic;
using System.Text;

namespace _07_03_22_classes_ex_1
{
    class Bank
    {
        private int stand;
        private int limit;
        private int verichtingen;

        public int Stand   // property
        {
            get { return stand; }   // get method
            set { stand = value; }  // set method
        }
        public int Limit   // property
        {
            get { return limit; }   // get method
            set { limit = value; }  // set method
        }
        public int Verichtingen   // property
        {
            get { return verichtingen; }   // get method
            set { verichtingen = value; }  // set method
        }
        public Bank()
        {
            stand = 0;
            limit = -1000;
            verichtingen = 0;
        }
        public Bank(int GestortGeld)
        {
            stand = stand + GestortGeld;
        }
    }
}
