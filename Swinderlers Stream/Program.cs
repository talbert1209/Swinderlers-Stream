using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swinderlers_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            StreamReader reader = new StreamReader($@"{folder}\Test Streams\secret_plan.txt");
            StreamWriter writer = new StreamWriter($@"{folder}\Test Streams\Email_To_Captain_Amazing.txt");
            
            writer.WriteLine(@"To: Captain Amazing!Objectville.net");
            writer.WriteLine(@"From: Commissioner@Onjectville.net");
            writer.WriteLine(@"Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine(@"We've discovered The Swindler's plan:");
            while (!reader.EndOfStream)
            {
                var planLine = reader.ReadLine();
                writer.WriteLine($"The Plan -> {planLine}");
            }
            writer.WriteLine();
            writer.WriteLine(@"Can you help us?");

            writer.Close();
            reader.Close();
        }
    }
}
