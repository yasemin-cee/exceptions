using System;
using System.Collections.Generic;

namespace Exceptions
{
    // HATA YÖNETİMİ !! 
    class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleException(() =>
                {
                    Find();
                }


                );


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke(); // find metodunu merkezi try'da çalıştırma
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ayşe", "Seda", "Yasemin" };
            if (!students.Contains("Kaan"))
            {
                throw new RecordNotFoundException("Record not found"); // yeni oluşturulan sınıfta ctor yaptığımız için bu ekrana yazılır
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Ayşe", "Seda", "Yasemin" };

                students[3] = "Kaan";
            }
            catch (IndexOutOfRangeException exception) // Eğer alınan hatanın türü indexofrangeexception ise bu blok çalışır
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception!"); // try kısımdaki kod hatalı olduğu için bu blok çalıştı
                Console.WriteLine(exception
                    .Message); // hatanın ne olduğunu ekrana yazdırır kullanıcıya göstermek uygun değildir. 
            }
        }
    }
}
