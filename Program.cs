// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectToUploadOnGit
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Your Phone is an Iphone");

            Phone phone = new Phone();
            phone.phoneType();
        }
         
    }
}

