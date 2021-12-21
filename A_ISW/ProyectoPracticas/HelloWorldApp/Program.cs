using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        private static List<string> nacionalities;
        private static void InitList()
        {
            nacionalities = new List<string>()
            {
            "Australian",
            "Mongolian",
            "Russian",
            "Austrian",
            "Brazilian"
             };
        }

        static void Main(string[] args)
        {
            InitList();
            nacionalities.Sort(); 
            Console.Write("Hola, bon dia, Marc ací\n"); //Write és equivalent a un print. WriteLine és equivalent a Println
            Console.Write("Açi Hary Potter, ¿tot be?\n");
            Console.Write("Soc un Dusklover\n");
            Console.Write("Hola, jo soc Andreu 2 2 2 2 2 \n");
            Console.ReadLine();
            Console.Clear();
            String entrada = Console.ReadLine();
            Console.Write(entrada + "\n");
            Console.ReadLine();
        }
    }
}
