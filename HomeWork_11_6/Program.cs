
using System;
using System.IO;

namespace HomeWork_11_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Repository consultant = new Consultant();
            
            Repository manager = new Manager();

            consultant.Add("Иванов", "Иван", "Иванович", 89009919017, "44 12 876678");
            manager.Add("Иванов", "Иван", "Иванович", 89009919017, "44 12 876678");
           
            consultant.InstallBase();    
            consultant.SaveBD("D:\\temp\\bd.json");
            manager.SaveBD("D:\\temp\\bd.json");


            consultant.PrintBD();
            consultant.SetTelephon(89781052626260, 0);
            Console.WriteLine(consultant.GetChange(0));
            

            manager.LoadBD("D:\\temp\\bd.json");
            manager.PrintBD();

            




        }
    }
}
