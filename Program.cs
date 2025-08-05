using System.Text;

namespace Assignment_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    s += arg + " ";
                }
            }
            else
            {
                s = " Hello World ";
            }
            Console.WriteLine($"{s}: {LastWordLength(s)}");
        }

        static int LastWordLength(string sentence)
        {
            int count = 0;
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                if (sentence[i] == ' ')
                {
                    if (count == 0)
                        continue;
                    break;
                }
                count++;
            }
            return count;
        }
    }
}
