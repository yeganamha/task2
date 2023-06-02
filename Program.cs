

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Unibank unibank = new Unibank("Yegana", "548982415454", 548, 400);
            unibank.Mexaric(150);
            Console.WriteLine( $"Name: {unibank.Fullname}, Card code: {unibank.Code}, CVV: {unibank.Cvv}, Unibank Balance: {unibank.Balance}");
          
            AccessBank accessbank = new AccessBank("elovset", "4695956565", 458, 700);

            accessbank.Medaxil(100);
            accessbank.Mexaric(50);
            Console.WriteLine("AccessCard balance:  " + accessbank.Balance);

            Pashabank pashabank = new Pashabank("Lara", "5493148787545", 895, 1080);
            pashabank.Medaxil(50);
            pashabank.Mexaric(500);
            Console.WriteLine(  "Pashabank balance: " + pashabank.Balance);

            Leobank leobank = new Leobank("Nana", "545599744", 325, 500);
            leobank.Medaxil(50);
            leobank.Mexaric(250);
            
            Console.WriteLine("Leobank Balance: " + leobank.Balance);
        }
    }
}