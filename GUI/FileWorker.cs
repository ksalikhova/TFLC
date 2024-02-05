using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class FileWorker
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
     
        public void CreateFile() 
        { 
            saveFileDialog.Filter = "All Files|*.doc;*.xls;*.ppt;*.doc;.xls;*.ppt;*.txt;";
            saveFileDialog.FileName = "Новый документ";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, "");
            }

            throw new Exception("Невозможно создать файл!");
        }
        public string OpenFile()
        {
            //OpenFileDialog был тут

            openFileDialog.Filter = "All Files|*.doc;*.xls;*.ppt;*.doc;.xls;*.ppt;*.txt;"; //"*.html | *.htm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {              
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string text = reader.ReadToEnd();
                    return text;
                }
            }
            throw new Exception("Невозможно открыть файл!");//спросить у Артёма нормально ли написано
        }
        private void SaveFile() { }
        private void SaveAs() { }       
    }
}
