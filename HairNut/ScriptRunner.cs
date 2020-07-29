using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairNut
{
    class ScriptRunner
    {
        public ScriptRunner()
        {

        }

        public void runCmd(string cmd)
        {

        }

        public void runPythonScript(string pythonEnvPath, string scriptPath, string args)
        {
            Console.WriteLine(pythonEnvPath);
            Console.WriteLine(scriptPath);
            Console.WriteLine(args);
        }
    }
}
