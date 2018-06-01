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
        public void run_cmd()
        {

            string fileName = @"C:\Users\super\OneDrive\Documenten\GitHub\Project78\TamTamSuggestions\TamTamTracker\PythonApplication\PythonApplication.py";

            Boolean Exist_filename = File.Exists(fileName);
            //Boolean ExistPython = File.Exists("C:/Users/env/Scripts/python.exe");
            Boolean ExistPython = File.Exists(@"C:\Python\Python36-32\python.exe");
            // 
            Process p = new Process();
            //p.StartInfo = new ProcessStartInfo(@"C:\Users\env\Scripts\python.exe", fileName)
            p.StartInfo = new ProcessStartInfo(@"C:\Python\Python36-32\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();
        }

        }
    }