using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace lab_5_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // открытие файла текстового
            StreamReader sr;

            try
            {
                 sr = new StreamReader("D:\\numbers.txt");
            }

            catch
            { 
                sr = new StreamReader("C:\\numbers.txt"); // у меня нету диска Д, поэтому сделал тру,катч блоки
            
            }


            string line;
            //тут делаем  коллекции, где негатив это гласные, а позив согласные
            Queue negativ_n = new Queue();
            //
            Queue positiv_n = new Queue();

            int k = 0;


            do //это цыкл, где мы смотрим на строки. И если там гласнаые, то вставляем их в негатив и наоборот
            {
                
                line = sr.ReadLine();
                string gg = line;
                //тут мы смо
                if (line[0] == 'а' || line[0] == 'у' || line[0] == 'е' || line[0] == 'ы' || line[0] == 'о' || line[0] == 'э' || line[0] == 'я' || line[0] == 'ю' || line[0] == 'и' || line[0] == 'ё')
              
                 {
                    negativ_n.Enqueue(line);
                }
                else 
                {
                    positiv_n.Enqueue(line);
                }
                k++;
               
            } while (line != null) ;

            sr.Close(); //закрываем файл

            //           Console.WriteLine(positiv_n.Count.ToString());
            //     Console.ReadLine();
            for (int i = 0; i<k-1; i++)
            {
                //тут ввыводим наш результат
                if (negativ_n.Count != 0)
                {
                    positiv_n.Enqueue(negativ_n.Dequeue());
                }
                Console.WriteLine(positiv_n.Dequeue().ToString());
            }
            Console.ReadLine();


        }
    }
}
