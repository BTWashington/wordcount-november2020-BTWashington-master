using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using WordCount;

namespace WordCount
{
    //public class FileIO
    //{
    //    private string _fileName;
    //    private Stream _FileStream { get; set; }
    //    public Stream fileStream {
    //        get {
    //            return _FileStream;
    //        }
    //        set
    //        {
    //            _FileStream = value;
    //        } 
    //    }
        

    //    public void ReadFile()
    //    {
    //        try
    //        {
    //            using (FileStream fileToCount = File.Open(_fileName, FileMode.Open, FileAccess.Read))
    //            {
    //                ulong count = 0;
    //                WordCounter Counter = new WordCounter();
    //                Counter._fileName = fileToCount;

    //                Stopwatch sw = Stopwatch.StartNew();

    //                while (Counter.CountWordsInFilie())
    //                {
    //                    count++;
    //                }

    //                // also count the last word
    //                count++;

    //                sw.Stop();
    //                Console.WriteLine("Counted {0} words in {1}", count, sw.Elapsed);
    //            }
    //        }
    //        catch (FileNotFoundException)
    //        {
    //            Console.WriteLine("File not found: " + _FileStream);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("Unexpected error:");
    //            Console.WriteLine(e.StackTrace);
    //        }

    //    }
    //}
}
