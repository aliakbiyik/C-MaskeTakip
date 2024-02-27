using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           SelamVer();
            

            while (true)
            {
                Console.WriteLine("-----Menü-----\n");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:\n1)Maske verilip verilmediğini sorgula.\n2)İşlemi bitir.");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 1)
                {
                    Person person1 = new Person();
                    Console.Write("Ad:");
                    person1.FirstName = Console.ReadLine();
                    Console.Write("Soyad:");
                    person1.LastName = Console.ReadLine();
                    Console.Write("Doğum Yılı:");
                    person1.DateOfBirthYear = Convert.ToInt16(Console.ReadLine());
                    Console.Write("TC No:");
                    person1.NationalIdentity = Convert.ToInt64(Console.ReadLine());

                    PttManager pttManager = new PttManager(new PersonManager());
                    pttManager.GiveMask(person1);
                    
                }
                else if (islem == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız lütfen tekrar deneyiniz\n\n");
                }

            }

            Console.ReadLine();


        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
    }
}