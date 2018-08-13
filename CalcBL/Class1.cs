using System;
using System.Threading;
using Timer = System.Timers.Timer;

namespace CalcBL
{
    public class Class1
    {

       System.Timers. Timer t = new  Timer();
        
        public Class1()
        {
            Console.WriteLine("calc is running");

            WriteLogFile();

            SetTimer();

        }

        private void SetTimer()
        {
            t.Interval = 2000;
            t.Enabled = true;
            t.Elapsed += Tick;
        }

        private void Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            WriteLogFile();
        }

        private void WriteLogFile()
        {
            string path = @"d:\temp\logs\log.txt";

            string text = "new - " + DateTime.Now.ToLongTimeString();

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path,true))
            {
                file.WriteLine(text);
            }
        }
    }
 
} 