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
            else
                throw new Exception("Файл не был создан!");
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
            else
                throw new Exception("Невозможно открыть файл!");//спросить у Артёма нормально ли написано
        }

        public void SaveFile() { }

        public void SaveAs(string str)
        {
            saveFileDialog.Filter = "All Files|*.doc;*.xls;*.ppt;*.doc;.xls;*.ppt;*.txt;";
            saveFileDialog.FileName = "Новый документ";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, str);
            }
            else
                throw new Exception("Файл не сохранён!");
        }       
    }
}
