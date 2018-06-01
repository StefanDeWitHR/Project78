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
            var engine = Python.CreateEngine();

            var paths = engine.GetSearchPaths();
        
            paths.Add(@"C:\users\super\appdata\local\programs\python\python36-32\lib\site-packages\sklearn\");
            engine.SetSearchPaths(paths);
            dynamic py = engine.ExecuteFile(@"C:\Users\super\OneDrive\Documenten\GitHub\Project78\TamTamSuggestions\TamTamTracker\PythonApplication\PythonApplication.py");
            string test = "";
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