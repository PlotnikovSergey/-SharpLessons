namespace CSharp7Lesson
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNameOfGame = new System.Windows.Forms.Label();
            this.labelGameDescription = new System.Windows.Forms.Label();
            this.labelInputNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.этаИграБылаРазработанаСергеемПлотниковымВРамках7УрокаCУровень1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTries = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelNumberOfTries = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelNameOfGame
            // 
            this.labelNameOfGame.AutoSize = true;
            this.labelNameOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfGame.ForeColor = System.Drawing.Color.Green;
            this.labelNameOfGame.Location = new System.Drawing.Point(209, 24);
            this.labelNameOfGame.Name = "labelNameOfGame";
            this.labelNameOfGame.Size = new System.Drawing.Size(269, 31);
            this.labelNameOfGame.TabIndex = 1;
            this.labelNameOfGame.Text = "Игра \"Угадай число\"";
            // 
            // labelGameDescription
            // 
            this.labelGameDescription.AutoSize = true;
            this.labelGameDescription.Location = new System.Drawing.Point(140, 75);
            this.labelGameDescription.Name = "labelGameDescription";
            this.labelGameDescription.Size = new System.Drawing.Size(441, 13);
            this.labelGameDescription.TabIndex = 2;
            this.labelGameDescription.Text = "Комьютер загадал число от 0 до 100. Задача игрока за 5 попыток угадать это число." +
    "";
            // 
            // labelInputNumber
            // 
            this.labelInputNumber.AutoSize = true;
            this.labelInputNumber.Location = new System.Drawing.Point(282, 160);
            this.labelInputNumber.Name = "labelInputNumber";
            this.labelInputNumber.Size = new System.Drawing.Size(81, 13);
            this.labelInputNumber.TabIndex = 3;
            this.labelInputNumber.Text = "Введите число";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.этаИграБылаРазработанаСергеемПлотниковымВРамках7УрокаCУровень1ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // этаИграБылаРазработанаСергеемПлотниковымВРамках7УрокаCУровень1ToolStripMenuItem
            // 
            this.этаИграБылаРазработанаСергеемПлотниковымВРамках7УрокаCУровень1ToolStripMenuItem.Name = "этаИграБылаРазработанаСергеемПлотниковымВРамках7УрокаCУровень1ToolStripMenuItem";
            this.этаИграБылаРазработанаСергеемПлотниковымВРамках7УрокаCУровень1ToolStripMenuItem.Size = new System.Drawing.Size(527, 22);
            this.этаИграБылаРазработанаСергеемПлотниковымВРамках7УрокаCУровень1ToolStripMenuItem.Text = "Эта игра была разработана Сергеем Плотниковым в рамках 7 урока C# Уровень 1";
            // 
            // labelTries
            // 
            this.labelTries.AutoSize = true;
            this.labelTries.Location = new System.Drawing.Point(283, 132);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(52, 13);
            this.labelTries.TabIndex = 5;
            this.labelTries.Text = "Попыток";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(276, 241);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 6;
            // 
            // labelNumberOfTries
            // 
            this.labelNumberOfTries.AutoSize = true;
            this.labelNumberOfTries.Location = new System.Drawing.Point(341, 132);
            this.labelNumberOfTries.Name = "labelNumberOfTries";
            this.labelNumberOfTries.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOfTries.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNumberOfTries);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelTries);
            this.Controls.Add(this.labelInputNumber);
            this.Controls.Add(this.labelGameDescription);
            this.Controls.Add(this.labelNameOfGame);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNameOfGame;
        private System.Windows.Forms.Label labelGameDescription;
        private System.Windows.Forms.Label labelInputNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelTries;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ToolStripMenuItem этаИграБылаРазработанаСергеемПлотниковымВРамках7УрокаCУровень1ToolStripMenuItem;
        private System.Windows.Forms.Label labelNumberOfTries;
        private System.Windows.Forms.Button button1;
    }
}

