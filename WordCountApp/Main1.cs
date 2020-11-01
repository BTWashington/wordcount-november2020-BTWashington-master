using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using WordCount;

public class Main1
{
    static void Main()
    {
        string filename = "mobydick.txt";
        //string filename = System.IO.File.ReadAllText(@"C:\Users\Brandon T Washington\Desktop\Full Sail\Software Engineering\wordcount-november2020-BTWashington-master\WordCountApp\mobydick.txt");
        Stopwatch sw = Stopwatch.StartNew();
        
        WordCounter Counter = new WordCounter(filename);
        Counter.TotalCount = Counter.CountAllWords();
        sw.Stop();

        Console.WriteLine("Counted {0} words in {1}", Counter.TotalCount, sw.Elapsed);

        Console.ReadKey();
    }
}
