using System;
using System.Net;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            String strHostName = new String("");
            if (args.Length == 0)
            {
                // Getting Ip address of local machine...

                // First get the host name of local machine.

                strHostName = Dns.GetHostName();
                Console.WriteLine("Local Machine's Host Name: " + strHostName);
            }
            else
            {
                strHostName = args[0];
            }

            // Then using host name, get the IP address list..

            IPHostEntry ipEntry = Dns.GetHostByName(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            Console.Write("Введите свое имя: \n");
            string? name = Console.ReadLine();
            Console.Write("Привет," + name + ", Ваши IP-адресса: \n");


            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
            }



        }
    }
}