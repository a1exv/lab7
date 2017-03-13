using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        public static string replac(Match mc)
        {
            return mc.ToString().ToUpper();
        }
        public static string Revers(string str)
        {
           
            return new String(str.ToCharArray().Reverse().ToArray());
        }
        public static string replac1(Match mc)
        {

            return Revers(mc.ToString());
        }
        static void Main(string[] args)
        {
            string path = "C:/Users/AV/Source/Repos/lab4/ConsoleApplication1/ConsoleApplication1/Program1.cs";
            StreamReader sr = new StreamReader(path);
            //Console.WriteLine(sr.ReadToEnd());
            Regex reg = new Regex("public");
            string text = sr.ReadToEnd().ToString();
            sr.Dispose();
            text = reg.Replace(text, "private");
            StreamWriter sw = new StreamWriter(path, false);
            sw.WriteLine(text);

            sw.Close();
            Regex reg1 = new Regex(@"\s+");
            string text1 = reg1.Replace(text, " ");
            Console.WriteLine(text1);
            Regex reg2 = new Regex(@"\S{2,}");
            MatchCollection mc = reg2.Matches(text);
            MatchEvaluator me = new MatchEvaluator(replac);
            text = reg2.Replace(text, me);
            Console.WriteLine(text);
            
            Regex reg3 = new Regex(@".*\n");
            MatchEvaluator me1 = new MatchEvaluator(replac1);
           
            text = reg3.Replace(text, me1);
            StreamWriter sr2 = new StreamWriter("E:/reverse.txt", false);
            sr2.WriteLine(text);
            sr2.Close();
            Console.WriteLine(text);

            string txt=Revers("abcd");
            Console.WriteLine(txt);
          
          
        }


    }

}
