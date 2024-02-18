using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ProgramInformation
    {
        public void CallInformation()
        {
            string filePath = @"C:\Users\User\source\repos\GUI\GUI\Program Information.html";


            if (System.IO.File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                throw new Exception("HTML файл не найден по указанному пути.");
            }
        }
    }
}
