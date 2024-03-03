using GUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GUI
{
    public partial class Compiler : Form
    {        
        public Compiler()
        {
            InitializeComponent();

            MouseEventArgs fakeMouseArgs = new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileWorker fileWorker = new FileWorker();

            try
            {
                inputField.Text = fileWorker.OpenFile();
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileWorker fileWorker = new FileWorker();

            try
            {
                fileWorker.CreateFile();
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Сохранить изменения?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                FileWorker fileWorker = new FileWorker();
                fileWorker.SaveFile(inputField.Text);
                this.Close();
            }
            else
            {
                this.Close();
            }                         
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileWorker fileWorker= new FileWorker();

            try
            {
                fileWorker.SaveAs(inputField.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void createToolStripButton_Click(object sender, EventArgs e)
        {
            FileWorker fileWorker = new FileWorker();

            try
            {
                fileWorker.CreateFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            FileWorker fileWorker = new FileWorker();

            try
            {
                inputField.Text = fileWorker.OpenFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cancelChangeToolStripButton_Click(object sender, EventArgs e)
        {
            if (inputField.CanUndo == true)
            {
                inputField.Undo();
            }
        }

        private void retrieveChangeToolStripButton_Click(object sender, EventArgs e)
        {
            inputField.Redo();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            inputField.Copy();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            inputField.Cut();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            inputField.Paste();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputField.CanUndo == true)
            {
                inputField.Undo();
            }
        }

        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputField.Redo();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputField.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputField.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputField.Paste();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputField.Text = inputField.Text.Remove(inputField.SelectionStart, inputField.SelectionLength);
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputField.SelectAll();
        }

        private void plusSizeoolStripButton_Click(object sender, EventArgs e)
        {
            float fontSize = inputField.SelectionFont.Size;
            inputField.Font = inputField.Font = new Font(inputField.Font.FontFamily, fontSize + 1.0f);          
        }

        private void minusSizeoolStripButton_Click(object sender, EventArgs e)
        {
            float fontSize = inputField.SelectionFont.Size;
            inputField.Font = inputField.Font = new Font(inputField.Font.FontFamily, fontSize - 1.0f);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileWorker fileWorker = new FileWorker();

            try
            {
                fileWorker.SaveFile(inputField.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Внимание",
                    MessageBoxButtons.OK);
            }
        }
              
        private void вызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramInformation info = new ProgramInformation();

            try
            {
                info.CallInformation();
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Внимание",
                    MessageBoxButtons.OK);
            }
        }

        private void referenceToolStripButton_Click(object sender, EventArgs e)
        {
            ProgramInformation info = new ProgramInformation();

            try
            {
                info.CallInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Внимание",
                    MessageBoxButtons.OK);
            }
        }

        private void Compiler_FormClosing(object sender, FormClosingEventArgs e)
        {
          
                if (MessageBox.Show("Вы уверены, что хотите закрыть программу?\n" +
                    "Текущие изменения не сохранятся!", "Подтвердите закрытие", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramInfo info = new ProgramInfo();

            this.Hide();
            info.Show();
        }

        private void пускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LexemeAnalyzer analyzer = new LexemeAnalyzer();

            analyzer.Analyze(inputField.Text);
            UpdateDataGrid();           
        }

        private void UpdateDataGrid()
        {
            LexemeAnalyzer analyzer = new LexemeAnalyzer();

            List<Lexemes> lexemesList = analyzer.Analyze(inputField.Text);
            int index = 0;

            dataGridView1.Rows.Clear();

            foreach(Lexemes lexeme in lexemesList)
            {

                dataGridView1.Rows.Add(index, lexeme.IdLexeme,lexeme.LexemeName, lexeme.Value,lexeme.Position);
                index++; 
            }
        }

        private void startToolStripButton_Click(object sender, EventArgs e)
        {
            LexemeAnalyzer analyzer = new LexemeAnalyzer();

            analyzer.Analyze(inputField.Text);
            UpdateDataGrid();
        }
    }           
}
