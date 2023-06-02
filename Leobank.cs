using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Leobank : Card
    {
        public Leobank(string fullname, string code, int cvv, decimal balance):base(fullname, code, cvv, balance)
        {
            
        }
        public override string Fullname { get; set; }
        public override string Code { get; set; }
        public override int Cvv { get; set; }
        public override decimal Balance { get; set; }

        public override decimal Medaxil(decimal money)
        {
            return
                Balance += money;
        }
        public override decimal Mexaric(decimal money)
        {
            return
                Balance -= money;
        }
    }
}
