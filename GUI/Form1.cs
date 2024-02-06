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
    }
}
