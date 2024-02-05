using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    MessageBoxButtons.AbortRetryIgnore,
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
                    MessageBoxButtons.AbortRetryIgnore,
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
    }
}
