using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace WordCount
{
    class WordCounter
    {
        private string _fileName = " ";
        private ulong _totalCount;
        private string _timeElapsed;

        public string FileToCount { get { return _fileName; } set { _fileName = value; } }
        //public ulong _count { get { return count; } set { count = value; } }
        public string TimeElapsed { get { return _timeElapsed; } set { _timeElapsed = value; } }
        public ulong TotalCount { get { return _totalCount; } set { _totalCount = value; } }
        



        public WordCounter() {
        }

        public WordCounter(string filename) {
            FileToCount = filename;
            TotalCount = 0;
            TimeElapsed = " ";
        }
        
        public ulong CountAllWords()
        {
            ulong count = 0;
            try
            {
                byte[] Array = new byte[64];
                
                //byte[] Array = new byte[64];
                Span<byte> Byte = new Span<byte>(Array);

                using (FileStream StreamedFile = File.Open(FileToCount, FileMode.Open, FileAccess.Read))
                {
                    while (StreamedFile.Read(Byte) > 0)
                    {
                        if (Encoding.Default.GetString(Byte.ToArray()) == " " || Encoding.Default.GetString(Byte.ToArray()) == "\n")
                        {
                            //Increase Count if it is reading an empty space or new line;
                            count++;
                        }
                    }
                    // also count the last word
                    count++;
                    StreamedFile.Close();
                }                   
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found: " + FileToCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error:");
                Console.WriteLine(e.StackTrace);
            }
            
            return count;
        }

        //private ulong WordCountTotal(WordCounter wordCounter)
        //{
        //    {
        //        while (wordCounter.CountWord())
        //        {
        //            count++;
        //        }

        //        // also count the last word
        //        count++;
        //        return count;
                
        //    }

           
        //}
        #region Attempt
        //private void ReadWordFile()
        //{
        //    try
        //    {
        //        using (FileStream fileToCount = File.Open(_fileName, FileMode.Open, FileAccess.Read))
        //        {
        //            ulong WordCount = CountAllWords();
                    
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine("File not found: " + _FileStream);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Unexpected error:");
        //        Console.WriteLine(e.StackTrace);
        //    }

        //}
        #endregion

        #region Original Code
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        using (FileStream fileToCount = File.Open(args[0], FileMode.Open, FileAccess.Read))
        //        {
        //            ulong count = 0;
        //            WordCounter Counter = new WordCounter();
        //            Counter.fileStream = fileToCount;

        //            Stopwatch sw = Stopwatch.StartNew();

        //            while (Counter.CountWord())
        //            {
        //                count++;
        //            }

        //            // also count the last word
        //            count++;

        //            sw.Stop();
        //            Console.WriteLine("Counted {0} words in {1}", count, sw.Elapsed);
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine("File not found: " + args[0]);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Unexpected error:");
        //        Console.WriteLine(e.StackTrace);
        //    }
        #endregion
    }
}  

