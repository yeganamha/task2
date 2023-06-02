using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal abstract class Card
    {
        public Card(string fullname, string code, int cvv, decimal balance)

        {
            this.Fullname = fullname;
            this.Code = code;
            this.Cvv = cvv;
            this.Balance = balance;

        }
        public abstract string Fullname { get; set; }
        public abstract string Code { get; set; }
        public abstract int Cvv { get; set; }
        public abstract decimal Balance { get; set; }
        public virtual decimal Medaxil(decimal money)
        {
            return
                Balance += money;
        }
        public virtual decimal Mexaric(decimal money)
        {
            return
                Balance -= money;
        }

    }

}
