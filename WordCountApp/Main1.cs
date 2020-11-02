using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using WordCount;

public class Main1
{
    static void Main(string[] args)
    {
        string filename = "mobydick.txt";
       
        Stopwatch sw = Stopwatch.StartNew();

        WordCounter Counter = new WordCounter(filename);
        Counter.TotalCount = Counter.CountAllWords();

        //WordCounter Counter2 = new WordCounter(filename2);
        //Counter2.TotalCount = Counter2.CountAllWords();
        sw.Stop();

        Console.WriteLine("Counted {0} words in {1}", Counter.TotalCount, sw.Elapsed);

        Console.ReadKey();
    }
}
