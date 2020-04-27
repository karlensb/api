using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManagerErrors
{
    public class LogErrror
    {
        public  void Log(string e)

       {
            string path = AppDomain.CurrentDomain.BaseDirectory + "LoError.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("ERROR " + e.ToString());
            }

        }
    }
}
