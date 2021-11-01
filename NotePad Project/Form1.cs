using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_Project
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void delityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Close the app for Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            /* 
                this.Close(); 
                Is Another Method how can uses for this perps
            */
            Application.Exit();
           
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                 saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                MainRichTextBox.SaveFile(saveFile1.FileName);
            }
        }

       

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Rights reserved by the author Nick" ,"Help",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //This function is for TextBox
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (MainRichTextBox.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                CutToolStripMenuItem5.Enabled = true;
                CopyToolStripMenuItem6.Enabled = true;
                SelectAllToolStripMenuItem.Enabled = true;
                BoldToolStripMenuItem.Enabled = true;
                italicToolStripMenuItem.Enabled = true;
                UnderlineToolStripMenuItem.Enabled = true;
                NormalToolStripMenuItem5.Enabled = true;
                StrikeThrowToolStripMenuItem.Enabled = true;

            }
            else
            {
                SelectAllToolStripMenuItem.Enabled = false;
                CutToolStripMenuItem5.Enabled = false;
                CopyToolStripMenuItem6.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                undoToolStripMenuItem.Enabled = false;
                BoldToolStripMenuItem.Enabled = false;
                italicToolStripMenuItem.Enabled = false;
                UnderlineToolStripMenuItem.Enabled = false;
                NormalToolStripMenuItem5.Enabled = false;
                StrikeThrowToolStripMenuItem.Enabled = false;
            }

            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //This function  is for New 

        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /* 
               MainRichTextBox.Clear();
               Is Another Method how can uses for this perps
           */
            MainRichTextBox.Text = "";
        }

        private void  PrintPriviewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void PrintToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
             printDocument1.Print();

            

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void strikeThrowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            openFileDialog1.ShowDialog();

        }
        
        
        // This is Function for the undo
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;

        }

        // This is Function for the redo
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }
        // This is Function for the Cut
        private void CutToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Cut();
        }
        // This is Function for the Copy
        private void CopyToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
        }
        // This is Function for the Paste
        private void PasteToolStripMenuIteam_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }
        // This is Function for the Delete
        private void DeleteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectedText="";
        }
        // This is Function for the Select All
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }
        // This is Function for the Time and Date
        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Text = MainRichTextBox.Text + DateTime.Now;

        }

        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font,FontStyle.Bold);
        }

        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, FontStyle.Italic);
        }

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, FontStyle.Underline);
        }

        private void NormalToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, FontStyle.Regular);

        }

        private void TextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainRichTextBox.ForeColor = MainRichTextBox.SelectionColor;
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = MainRichTextBox.SelectionColor;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               colorDialog1.Color != MainRichTextBox.SelectionColor)
            {
                // Change the selection color to the user specified color.
                MainRichTextBox.SelectionColor = colorDialog1.Color;
            }

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                 saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                MainRichTextBox.SaveFile(saveFile1.FileName);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(MainMenuStrip.Text, new Font("Times New Roman",14,FontStyle.Regular),Brushes.Black, new Point(100,100));
        }
    }
}
