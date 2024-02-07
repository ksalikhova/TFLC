using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Compiler : Form
    {        
        public Compiler()
        {
            InitializeComponent();
            //UpdateLineNumbers();
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
                "Вы действительно хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(result == DialogResult.Yes )
                this.Close();
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
        private void UpdateLineNumbers()
        {
            inputField.SelectionStart = 0;
            inputField.SelectionLength = inputField.Text.Length;
            inputField.SelectionBackColor = inputField.BackColor;

            int selectionStart = inputField.SelectionStart;
            int selectionLength = inputField.Text.Length;

            int firstIndex = inputField.GetCharIndexFromPosition(new Point(0, 0));
            int firstLine = inputField.GetLineFromCharIndex(firstIndex);
            int firstLineY = inputField.GetPositionFromCharIndex(firstIndex).Y;

            inputField.SelectionStart = 0;
            inputField.SelectionLength = inputField.Text.Length;

            int i = 0;
            Point newPoint = new Point(0, firstLineY);
            while (newPoint.Y < inputField.Height)
            {
                i++;
                inputField.SelectionBackColor = Color.LightGray;
                inputField.SelectedText = i.ToString() + Environment.NewLine;
                newPoint = inputField.GetPositionFromCharIndex(inputField.GetFirstCharIndexFromLine(i));
            }

            inputField.SelectionStart = selectionStart;
            inputField.SelectionLength = selectionLength;
        }
    }
}
