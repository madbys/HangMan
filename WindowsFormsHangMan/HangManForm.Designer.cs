namespace WindowsFormsHangMan
{
    partial class HangManForm
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
            this.groupBoxHangman = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxWord = new System.Windows.Forms.GroupBox();
            this.labelMissedLetters = new System.Windows.Forms.Label();
            this.labelWorldLength = new System.Windows.Forms.Label();
            this.groupBoxGuess = new System.Windows.Forms.GroupBox();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.buttonSubmitWord = new System.Windows.Forms.Button();
            this.buttonSubmitLetter = new System.Windows.Forms.Button();
            this.groupBoxHangman.SuspendLayout();
            this.groupBoxWord.SuspendLayout();
            this.groupBoxGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHangman
            // 
            this.groupBoxHangman.Controls.Add(this.panel1);
            this.groupBoxHangman.Location = new System.Drawing.Point(316, 12);
            this.groupBoxHangman.Name = "groupBoxHangman";
            this.groupBoxHangman.Size = new System.Drawing.Size(180, 260);
            this.groupBoxHangman.TabIndex = 0;
            this.groupBoxHangman.TabStop = false;
            this.groupBoxHangman.Text = "Hangman";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 241);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxWord
            // 
            this.groupBoxWord.Controls.Add(this.labelMissedLetters);
            this.groupBoxWord.Controls.Add(this.labelWorldLength);
            this.groupBoxWord.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWord.Name = "groupBoxWord";
            this.groupBoxWord.Size = new System.Drawing.Size(298, 201);
            this.groupBoxWord.TabIndex = 1;
            this.groupBoxWord.TabStop = false;
            this.groupBoxWord.Text = "Word";
            // 
            // labelMissedLetters
            // 
            this.labelMissedLetters.AutoSize = true;
            this.labelMissedLetters.Location = new System.Drawing.Point(6, 185);
            this.labelMissedLetters.Name = "labelMissedLetters";
            this.labelMissedLetters.Size = new System.Drawing.Size(72, 13);
            this.labelMissedLetters.TabIndex = 1;
            this.labelMissedLetters.Text = "MissedLetters";
            // 
            // labelWorldLength
            // 
            this.labelWorldLength.AutoSize = true;
            this.labelWorldLength.Location = new System.Drawing.Point(188, 185);
            this.labelWorldLength.Name = "labelWorldLength";
            this.labelWorldLength.Size = new System.Drawing.Size(68, 13);
            this.labelWorldLength.TabIndex = 0;
            this.labelWorldLength.Text = "Word length:";
            // 
            // groupBoxGuess
            // 
            this.groupBoxGuess.Controls.Add(this.textBoxWord);
            this.groupBoxGuess.Controls.Add(this.textBoxLetter);
            this.groupBoxGuess.Controls.Add(this.buttonSubmitWord);
            this.groupBoxGuess.Controls.Add(this.buttonSubmitLetter);
            this.groupBoxGuess.Location = new System.Drawing.Point(12, 219);
            this.groupBoxGuess.Name = "groupBoxGuess";
            this.groupBoxGuess.Size = new System.Drawing.Size(298, 52);
            this.groupBoxGuess.TabIndex = 2;
            this.groupBoxGuess.TabStop = false;
            this.groupBoxGuess.Text = "Guess";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(138, 22);
            this.textBoxWord.MaxLength = 20;
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(76, 20);
            this.textBoxWord.TabIndex = 3;
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Location = new System.Drawing.Point(6, 22);
            this.textBoxLetter.MaxLength = 1;
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(27, 20);
            this.textBoxLetter.TabIndex = 2;
            // 
            // buttonSubmitWord
            // 
            this.buttonSubmitWord.Location = new System.Drawing.Point(217, 20);
            this.buttonSubmitWord.Name = "buttonSubmitWord";
            this.buttonSubmitWord.Size = new System.Drawing.Size(80, 23);
            this.buttonSubmitWord.TabIndex = 1;
            this.buttonSubmitWord.Text = "Submit word";
            this.buttonSubmitWord.UseVisualStyleBackColor = true;
            this.buttonSubmitWord.Click += new System.EventHandler(this.buttonSubmitWord_Click);
            // 
            // buttonSubmitLetter
            // 
            this.buttonSubmitLetter.Location = new System.Drawing.Point(37, 20);
            this.buttonSubmitLetter.Name = "buttonSubmitLetter";
            this.buttonSubmitLetter.Size = new System.Drawing.Size(83, 23);
            this.buttonSubmitLetter.TabIndex = 0;
            this.buttonSubmitLetter.Text = "Submit letter";
            this.buttonSubmitLetter.UseVisualStyleBackColor = true;
            this.buttonSubmitLetter.Click += new System.EventHandler(this.buttonSubmitLetter_Click);
            // 
            // HangManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 283);
            this.Controls.Add(this.groupBoxGuess);
            this.Controls.Add(this.groupBoxWord);
            this.Controls.Add(this.groupBoxHangman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HangManForm";
            this.Text = "Hangman by Madde";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBoxHangman.ResumeLayout(false);
            this.groupBoxWord.ResumeLayout(false);
            this.groupBoxWord.PerformLayout();
            this.groupBoxGuess.ResumeLayout(false);
            this.groupBoxGuess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHangman;
        private System.Windows.Forms.GroupBox groupBoxWord;
        private System.Windows.Forms.GroupBox groupBoxGuess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSubmitLetter;
        private System.Windows.Forms.Button buttonSubmitWord;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label labelWorldLength;
        private System.Windows.Forms.Label labelMissedLetters;
    }
}

