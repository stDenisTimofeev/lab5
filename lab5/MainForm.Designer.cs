
namespace lab5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbFindString = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstbRegex = new System.Windows.Forms.ListBox();
            this.rtbFileText = new System.Windows.Forms.RichTextBox();
            this.rtbSearchResult = new System.Windows.Forms.RichTextBox();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofOrClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstWordInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подсчётПервыхСимволовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.individualTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.функцииToolStripMenuItem,
            this.подсчётПервыхСимволовToolStripMenuItem,
            this.individualTaskToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(702, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // txtbFindString
            // 
            this.txtbFindString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFindString.Location = new System.Drawing.Point(12, 38);
            this.txtbFindString.Name = "txtbFindString";
            this.txtbFindString.Size = new System.Drawing.Size(460, 20);
            this.txtbFindString.TabIndex = 1;
            this.txtbFindString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownAnyKeys);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(496, 34);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.Find);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(598, 35);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Ещё";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextMatch);
            // 
            // lstbRegex
            // 
            this.lstbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstbRegex.FormattingEnabled = true;
            this.lstbRegex.Location = new System.Drawing.Point(12, 75);
            this.lstbRegex.Name = "lstbRegex";
            this.lstbRegex.Size = new System.Drawing.Size(208, 394);
            this.lstbRegex.TabIndex = 4;
            // 
            // rtbFileText
            // 
            this.rtbFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileText.Location = new System.Drawing.Point(226, 75);
            this.rtbFileText.Name = "rtbFileText";
            this.rtbFileText.ReadOnly = true;
            this.rtbFileText.Size = new System.Drawing.Size(464, 288);
            this.rtbFileText.TabIndex = 5;
            this.rtbFileText.Text = "";
            // 
            // rtbSearchResult
            // 
            this.rtbSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSearchResult.Location = new System.Drawing.Point(226, 370);
            this.rtbSearchResult.Name = "rtbSearchResult";
            this.rtbSearchResult.ReadOnly = true;
            this.rtbSearchResult.Size = new System.Drawing.Size(464, 99);
            this.rtbSearchResult.TabIndex = 6;
            this.rtbSearchResult.Text = "";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ofOrClickToolStripMenuItem,
            this.firstWordInToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // ofOrClickToolStripMenuItem
            // 
            this.ofOrClickToolStripMenuItem.Name = "ofOrClickToolStripMenuItem";
            this.ofOrClickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ofOrClickToolStripMenuItem.Text = "OfOrClick";
            this.ofOrClickToolStripMenuItem.Click += new System.EventHandler(this.ofOrClickToolStripMenuItem_Click);
            // 
            // firstWordInToolStripMenuItem
            // 
            this.firstWordInToolStripMenuItem.Name = "firstWordInToolStripMenuItem";
            this.firstWordInToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.firstWordInToolStripMenuItem.Text = "FirstWordInInterrogativeSentences";
            this.firstWordInToolStripMenuItem.Click += new System.EventHandler(this.firstWordInToolStripMenuItem_Click);
            // 
            // подсчётПервыхСимволовToolStripMenuItem
            // 
            this.подсчётПервыхСимволовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1});
            this.подсчётПервыхСимволовToolStripMenuItem.Name = "подсчётПервыхСимволовToolStripMenuItem";
            this.подсчётПервыхСимволовToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.подсчётПервыхСимволовToolStripMenuItem.Text = "Подсчёт первых символов";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // individualTaskToolStripMenuItem
            // 
            this.individualTaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem2});
            this.individualTaskToolStripMenuItem.Name = "individualTaskToolStripMenuItem";
            this.individualTaskToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.individualTaskToolStripMenuItem.Text = "Доп. Задание";
            // 
            // открытьToolStripMenuItem2
            // 
            this.открытьToolStripMenuItem2.Name = "открытьToolStripMenuItem2";
            this.открытьToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem2.Text = "Открыть";
            this.открытьToolStripMenuItem2.Click += new System.EventHandler(this.OpenIndividualTask);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 490);
            this.Controls.Add(this.rtbSearchResult);
            this.Controls.Add(this.rtbFileText);
            this.Controls.Add(this.lstbRegex);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtbFindString);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Поиск в текстовом файле";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Load += new System.EventHandler(this.LoadSettings);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox txtbFindString;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lstbRegex;
        private System.Windows.Forms.RichTextBox rtbFileText;
        private System.Windows.Forms.RichTextBox rtbSearchResult;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofOrClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstWordInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подсчётПервыхСимволовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem individualTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem2;
    }
}

