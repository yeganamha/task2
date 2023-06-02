using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Pashabank :Card
    {
        public Pashabank(string fullname, string code, int cvv, decimal balance) :base(fullname, code, cvv, balance)
        {
            
        }
        public override string Fullname { get; set; }
        public override  string Code { get; set; }
        public override int Cvv { get; set; }
        public override decimal Balance { get; set; }

        public override decimal Medaxil(decimal money)
        {
            return
                Balance = Balance + (money - money * 0.6m / 100);
            

        }
        public override decimal Mexaric(decimal money)
        {
            return
                Balance = Balance - (money + money * 1.1m / 100);
        }

    }
    
}
