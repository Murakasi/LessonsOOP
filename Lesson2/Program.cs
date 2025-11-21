namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 12, 00);
            TimeSpan t2 = new TimeSpan(0, 10, 30);

            TimeSpan result = t1 - t2;

            Console.WriteLine(result);
            string text = "";
            string fileName = "text.txt";
            if (File.Exists(fileName))
            {
                text = File.ReadAllText(fileName);
            }


            string[] words = text.Trim().Split(" ");
            Console.WriteLine(words.Length);
            string t = "\nHello Ruslan";

            File.AppendAllText(fileName, t);


        }
    }
}
