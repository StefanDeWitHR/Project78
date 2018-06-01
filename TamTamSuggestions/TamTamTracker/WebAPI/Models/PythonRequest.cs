using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class PythonRequest
    {
        public string run_cmd()
        {
            // Python file
            string fileName = @"C:\Users\super\OneDrive\Documenten\GitHub\Project78\TamTamSuggestions\TamTamTracker\PythonApplication\PythonApplication.py";
           
            // Start process
            Process p = new Process();
            string suggestion = "";
                p.StartInfo = new ProcessStartInfo(@"C:\Users\super\Anaconda3\python.exe", fileName)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                p.Start();

                suggestion = p.StandardOutput.ReadToEnd();
                // Example : "[1]\r\n"
                var chars_remove = new string [] { "[", "\r" , "]" , "\n" };
                foreach (var c in chars_remove)
                {
                    suggestion = suggestion.Replace(c, string.Empty);
                }
                
                p.WaitForExit();

            return suggestion;


        }


    }
    }