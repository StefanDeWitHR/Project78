using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Cmd_Python
    {

        public static void run_cmd(/*string cmd, string args */)
        {
            string path = "C:/Users/super/OneDrive/Documenten/GitHub/Project78/TamTamSuggestions/TamTamTracker/WebAPI/PythonScripts/machine_learning.py";

            string suggestion = "";
           
                ProcessStartInfo start = new ProcessStartInfo();

                start.FileName = @"C:\Users\env\Scripts\python.exe"; //full path to python.exe
             
                start.Arguments = @"C/Users/super/OneDrive/Documenten/GitHub/Project78/TamTamSuggestions/TamTamTracker/WebAPI/PythonScripts/machine_learning.py";

                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                
                using (Process process = Process.Start(start))
                using (StreamReader reader = process.StandardOutput)
                {
                     suggestion  = reader.ReadToEnd();
                    
                }
               
            
           
            //return suggestion;

            //ScriptEngine engine = Python.CreateEngine();
            //ScriptScope scope = engine.CreateScope();
            //var paths = engine.GetSearchPaths();
            //paths.Add("C:/Program Files (x86)/Microsoft Visual Studio/Shared/Python36_64/Lib/site-packages");
            //paths.Add(@"C:\Users\super\OneDrive\Documenten\GitHub\Project78\TamTamSuggestions\TamTamTracker\packages\IronPython.2.7.8.1\lib");
            //paths.Add(@"C:\Users\super\OneDrive\Documenten\GitHub\Project78\TamTamSuggestions\TamTamTracker\packages\DynamicLanguageRuntime.1.2.1");
            //paths.Add(@"C:\Users\super\AppData\Local\Programs\Python\Python36-32\libs");
            //paths.Add(@"C:\Users\super\AppData\Local\Programs\Python\Python36-32\Scripts");
            //paths.Add(@"C:\Users\super\AppData\Local\Programs\Python\Python36-32\Lib");
            //engine.SetSearchPaths(paths);
            //ScriptSource source = engine.CreateScriptSourceFromFile(path);

        }
    }
}