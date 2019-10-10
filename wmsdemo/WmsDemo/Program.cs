using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WmsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            Console.WriteLine(i.ToString("00"));

            Console.ReadLine();
        }

    }

    public class HGZ
    {
        public int Id { get; set; }

        public byte[] Info { get; set; }
    }
}
