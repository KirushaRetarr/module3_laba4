using System.Windows.Forms;

namespace module3_laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() ==
            System.Windows.Forms.DialogResult.OK
             && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,
                RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|Allfiles(*.*) | *.* ";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {

                            richTextBox1.LoadFile(openFileDialog1.FileName,
                             RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk: "
                   + ex.Message);
                }
            }

        }
    }
}
