
namespace NotePad_Project
{
    partial class NotePad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuIteam = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NormalToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.BoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnderlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StrikeThrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem4,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::NotePad_Project.Properties.Resources.New;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(297, 34);
            this.toolStripMenuItem1.Text = "New";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.NewToolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Open;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.newToolStripMenuItem.Text = "Open";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OpenNewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Save;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.openToolStripMenuItem.Text = "Save";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Save_As;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::NotePad_Project.Properties.Resources.Print_Preview;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(297, 34);
            this.toolStripMenuItem2.Text = "Print P&review";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.PrintPriviewToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::NotePad_Project.Properties.Resources.Print;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(297, 34);
            this.toolStripMenuItem3.Text = "Print";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.PrintToolStripMenuItem3_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.CutToolStripMenuItem5,
            this.CopyToolStripMenuItem6,
            this.PasteToolStripMenuIteam,
            this.DeleteToolStripMenuItem5,
            this.SelectAllToolStripMenuItem,
            this.DateTimeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // CutToolStripMenuItem5
            // 
            this.CutToolStripMenuItem5.Name = "CutToolStripMenuItem5";
            this.CutToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem5.Size = new System.Drawing.Size(248, 34);
            this.CutToolStripMenuItem5.Text = "Cut";
            this.CutToolStripMenuItem5.Click += new System.EventHandler(this.CutToolStripMenuItem5_Click);
            // 
            // CopyToolStripMenuItem6
            // 
            this.CopyToolStripMenuItem6.Name = "CopyToolStripMenuItem6";
            this.CopyToolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem6.Size = new System.Drawing.Size(248, 34);
            this.CopyToolStripMenuItem6.Text = "Copy";
            this.CopyToolStripMenuItem6.Click += new System.EventHandler(this.CopyToolStripMenuItem6_Click);
            // 
            // PasteToolStripMenuIteam
            // 
            this.PasteToolStripMenuIteam.Name = "PasteToolStripMenuIteam";
            this.PasteToolStripMenuIteam.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuIteam.Size = new System.Drawing.Size(248, 34);
            this.PasteToolStripMenuIteam.Text = "Paste";
            this.PasteToolStripMenuIteam.Click += new System.EventHandler(this.PasteToolStripMenuIteam_Click);
            // 
            // DeleteToolStripMenuItem5
            // 
            this.DeleteToolStripMenuItem5.Name = "DeleteToolStripMenuItem5";
            this.DeleteToolStripMenuItem5.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem5.Size = new System.Drawing.Size(248, 34);
            this.DeleteToolStripMenuItem5.Text = "Delete";
            this.DeleteToolStripMenuItem5.Click += new System.EventHandler(this.DeleteToolStripMenuItem5_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Enabled = false;
            this.SelectAllToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.SelectAll;
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.SelectAllToolStripMenuItem.Text = "Select All";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // DateTimeToolStripMenuItem
            // 
            this.DateTimeToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.DateTime;
            this.DateTimeToolStripMenuItem.Name = "DateTimeToolStripMenuItem";
            this.DateTimeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.DateTimeToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.DateTimeToolStripMenuItem.Text = "Date/Time";
            this.DateTimeToolStripMenuItem.Click += new System.EventHandler(this.DateTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.NormalToolStripMenuItem5,
            this.BoldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.UnderlineToolStripMenuItem,
            this.StrikeThrowToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(64, 29);
            this.toolStripMenuItem4.Text = "Font";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Font;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // NormalToolStripMenuItem5
            // 
            this.NormalToolStripMenuItem5.Image = global::NotePad_Project.Properties.Resources.Normal;
            this.NormalToolStripMenuItem5.Name = "NormalToolStripMenuItem5";
            this.NormalToolStripMenuItem5.Size = new System.Drawing.Size(270, 34);
            this.NormalToolStripMenuItem5.Text = "Normal";
            this.NormalToolStripMenuItem5.Click += new System.EventHandler(this.NormalToolStripMenuItem5_Click);
            // 
            // BoldToolStripMenuItem
            // 
            this.BoldToolStripMenuItem.Enabled = false;
            this.BoldToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Bold;
            this.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem";
            this.BoldToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.BoldToolStripMenuItem.Text = "Bold";
            this.BoldToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Enabled = false;
            this.italicToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italicToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Italic;
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItem_Click);
            // 
            // UnderlineToolStripMenuItem
            // 
            this.UnderlineToolStripMenuItem.Enabled = false;
            this.UnderlineToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.UnderLine;
            this.UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem";
            this.UnderlineToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.UnderlineToolStripMenuItem.Text = "Underline";
            this.UnderlineToolStripMenuItem.Click += new System.EventHandler(this.UnderlineToolStripMenuItem_Click);
            // 
            // StrikeThrowToolStripMenuItem
            // 
            this.StrikeThrowToolStripMenuItem.Enabled = false;
            this.StrikeThrowToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Strikethrough;
            this.StrikeThrowToolStripMenuItem.Name = "StrikeThrowToolStripMenuItem";
            this.StrikeThrowToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.StrikeThrowToolStripMenuItem.Text = "Strike Through";
            this.StrikeThrowToolStripMenuItem.Click += new System.EventHandler(this.strikeThrowToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Image = global::NotePad_Project.Properties.Resources.Text_Color;
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.textColorToolStripMenuItem.Text = "Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.TextColorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRichTextBox.Location = new System.Drawing.Point(0, 33);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(730, 549);
            this.MainRichTextBox.TabIndex = 1;
            this.MainRichTextBox.Text = "";
            this.MainRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 582);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotePad";
            this.RightToLeftLayout = true;
            this.Text = "NotePad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DateTimeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox MainRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnderlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StrikeThrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuIteam;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NormalToolStripMenuItem5;
    }
}

