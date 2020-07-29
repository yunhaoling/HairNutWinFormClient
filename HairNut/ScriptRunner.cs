using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HairNut
{
    class ScriptRunner
    {
        public ScriptRunner()
        {

        }

        public void runPythonScript(string pythonEnvPath, string scriptPath, string args)
        {
            var curWorkDir = Directory.GetCurrentDirectory();
            scriptPath = curWorkDir + '\\' + scriptPath;
            ProcessStartInfo pythonProgram = new ProcessStartInfo(pythonEnvPath)
            {
                Arguments = string.Format("{0} {1}", scriptPath, args),
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            };
            Process process = Process.Start(pythonProgram);
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine("Output from python script {0}", output);
            process.WaitForExit();
        }
    }
}
