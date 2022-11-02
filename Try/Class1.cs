using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
     class Creditcard
    {
        private int num_card;
        private string fio;
        private string date;
        private int cvc;
        public Creditcard(int num_card, string fio, string date, int cvc)
        {
            this.num_card = num_card;
            this.fio = fio;
            this.date = date;
            this.cvc = cvc;
        }
        public int Cvc()
        {
            return this.cvc;
        }
        public int Num_card()
        {
            return this.num_card;
        }
        public string Fio()
        {
            return this.fio;
        }
        public string Date()
        {
            return this.date;
        }
    }
}
