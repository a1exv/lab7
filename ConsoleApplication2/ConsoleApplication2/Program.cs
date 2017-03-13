using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice=1;
            do
            {
      
                Console.Clear();
                Console.WriteLine("Day17 program. Hello!");
                Console.WriteLine("***********************");
                Console.WriteLine("Your choice?");
                Console.WriteLine("1.-Create file Day17.txt");
                Console.WriteLine("2.-Delete file Day17.txt");
                Console.WriteLine("3.-Is file Day17.txt exist?");
                Console.WriteLine("4.-fill Day17.txt");
                Console.WriteLine("5.-Read Day17.txt");
                Console.WriteLine("0.-quit");
                try
                {
                    
                    choice = Convert.ToInt32(Console.ReadLine());
                    string path = "E:/Day17.txt";
                    Console.Clear();
                    switch(choice){
                        case 1:
                            if(File.Exists(path)){
                                Console.WriteLine("File already exists");}
                            else{
                                File.Create(path);
                                Console.WriteLine("File created");}
                            Console.WriteLine("press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            if(File.Exists(path)){
                                File.Delete(path);
                                Console.WriteLine("file day17.txt has been deleted!");
                            }
                            else{
                                Console.WriteLine("file does not exist");}
                            Console.WriteLine("press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            if(File.Exists(path)) Console.WriteLine("yes");
                            else Console.WriteLine("no");
                            Console.WriteLine("press any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            int [,] iarr = new int[2,2]{{1,2},{3,4}};
                            double [,] darr = new double[2,2]{{2.5, 5.6},{4.6, 7.9}};
                            using(StreamWriter sw=new StreamWriter(path, false)){
                                sw.WriteLine("Ivanov Ivan Ivanovich, {0}", new DateTime(1950, 10, 10));
                                sw.WriteLine("{0}, {1}", darr.GetLength(0), darr.GetLength(1));
                                for (int i = 0; i < darr.GetLength(0); i++)
                                {
                                    for (int j = 0; j < darr.GetLength(1); j++)
                                    {
                                        sw.Write(darr[i, j]);
                                    }
                                    sw.WriteLine();
                                }
                                sw.WriteLine("{0}, {1}", iarr.GetLength(0), iarr.GetLength(1));
                                for (int i = 0; i < iarr.GetLength(0); i++)
                                {
                                    for (int j = 0; j < iarr.GetLength(1); j++)
                                    {
                                        sw.Write(iarr[i, j]);
                                    }
                                }
                                sw.WriteLine();
                                sw.WriteLine(DateTime.Today);
                                sw.Close();
                            }
                            Console.WriteLine("data has been filled!");
                            Console.WriteLine("press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 5:
                            if (File.Exists(path))
                            {
                                string text;
                                using (StreamReader sr = new StreamReader(path))
                                {
                                    text = sr.ReadToEnd();
                                    sr.Close();
                                }
                                Console.WriteLine(text);

                            }
                            else Console.WriteLine("file does not exist");
                            Console.WriteLine("press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 0:
                            break;
                        default: Console.WriteLine("try again");
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("something goes wrong");
                    Console.WriteLine("try again! press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (choice != 0);
            Console.Clear();
            Console.WriteLine("Bye!");
        }
    }
}
