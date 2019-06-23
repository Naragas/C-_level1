namespace HW7_1
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbpDoubler = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpGame = new System.Windows.Forms.TabPage();
            this.lblNumberToFind = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelLastTurn = new System.Windows.Forms.Button();
            this.lblGameCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGameNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGameMulti = new System.Windows.Forms.Button();
            this.btnGamePlus = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tbpGame2 = new System.Windows.Forms.TabPage();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblHint1 = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblGame2Count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGame2Start = new System.Windows.Forms.Button();
            this.lblUserAnswer = new System.Windows.Forms.Label();
            this.tbUserAnswer = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGame1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGame2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCancelTurns = new System.Windows.Forms.Label();
            this.tbControl.SuspendLayout();
            this.tbpDoubler.SuspendLayout();
            this.tbpGame.SuspendLayout();
            this.tbpGame2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbpDoubler);
            this.tbControl.Controls.Add(this.tbpGame);
            this.tbControl.Controls.Add(this.tbpGame2);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(0, 24);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(384, 337);
            this.tbControl.TabIndex = 0;
            // 
            // tbpDoubler
            // 
            this.tbpDoubler.Controls.Add(this.btnReset);
            this.tbpDoubler.Controls.Add(this.btnMulti);
            this.tbpDoubler.Controls.Add(this.btnPlus);
            this.tbpDoubler.Controls.Add(this.lblCount);
            this.tbpDoubler.Controls.Add(this.label3);
            this.tbpDoubler.Controls.Add(this.lblNumber);
            this.tbpDoubler.Controls.Add(this.label1);
            this.tbpDoubler.Location = new System.Drawing.Point(4, 22);
            this.tbpDoubler.Name = "tbpDoubler";
            this.tbpDoubler.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDoubler.Size = new System.Drawing.Size(376, 311);
            this.tbpDoubler.TabIndex = 0;
            this.tbpDoubler.Text = "Удвоитель";
            this.tbpDoubler.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(246, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(246, 54);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "x2";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(246, 24);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(51, 165);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ходы";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(53, 35);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbpGame
            // 
            this.tbpGame.Controls.Add(this.lblCancelTurns);
            this.tbpGame.Controls.Add(this.lblNumberToFind);
            this.tbpGame.Controls.Add(this.label2);
            this.tbpGame.Controls.Add(this.btnCancelLastTurn);
            this.tbpGame.Controls.Add(this.lblGameCount);
            this.tbpGame.Controls.Add(this.label4);
            this.tbpGame.Controls.Add(this.lblGameNumber);
            this.tbpGame.Controls.Add(this.label6);
            this.tbpGame.Controls.Add(this.btnGameMulti);
            this.tbpGame.Controls.Add(this.btnGamePlus);
            this.tbpGame.Controls.Add(this.btnStartGame);
            this.tbpGame.Location = new System.Drawing.Point(4, 22);
            this.tbpGame.Name = "tbpGame";
            this.tbpGame.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGame.Size = new System.Drawing.Size(376, 311);
            this.tbpGame.TabIndex = 1;
            this.tbpGame.Text = "Игра 1";
            this.tbpGame.UseVisualStyleBackColor = true;
            this.tbpGame.Click += new System.EventHandler(this.tbpGame_Click);
            // 
            // lblNumberToFind
            // 
            this.lblNumberToFind.AutoSize = true;
            this.lblNumberToFind.Location = new System.Drawing.Point(106, 142);
            this.lblNumberToFind.Name = "lblNumberToFind";
            this.lblNumberToFind.Size = new System.Drawing.Size(0, 13);
            this.lblNumberToFind.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Нужно получить";
            // 
            // btnCancelLastTurn
            // 
            this.btnCancelLastTurn.Location = new System.Drawing.Point(243, 142);
            this.btnCancelLastTurn.Name = "btnCancelLastTurn";
            this.btnCancelLastTurn.Size = new System.Drawing.Size(75, 40);
            this.btnCancelLastTurn.TabIndex = 8;
            this.btnCancelLastTurn.Text = "Отменить ход";
            this.btnCancelLastTurn.UseVisualStyleBackColor = true;
            this.btnCancelLastTurn.Click += new System.EventHandler(this.btnCancelLastTurn_Click);
            // 
            // lblGameCount
            // 
            this.lblGameCount.AutoSize = true;
            this.lblGameCount.Location = new System.Drawing.Point(46, 293);
            this.lblGameCount.Name = "lblGameCount";
            this.lblGameCount.Size = new System.Drawing.Size(13, 13);
            this.lblGameCount.TabIndex = 7;
            this.lblGameCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ходы";
            // 
            // lblGameNumber
            // 
            this.lblGameNumber.AutoSize = true;
            this.lblGameNumber.Location = new System.Drawing.Point(86, 39);
            this.lblGameNumber.Name = "lblGameNumber";
            this.lblGameNumber.Size = new System.Drawing.Size(13, 13);
            this.lblGameNumber.TabIndex = 5;
            this.lblGameNumber.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ваше число";
            // 
            // btnGameMulti
            // 
            this.btnGameMulti.Location = new System.Drawing.Point(243, 112);
            this.btnGameMulti.Name = "btnGameMulti";
            this.btnGameMulti.Size = new System.Drawing.Size(75, 23);
            this.btnGameMulti.TabIndex = 2;
            this.btnGameMulti.Text = "x2";
            this.btnGameMulti.UseVisualStyleBackColor = true;
            this.btnGameMulti.Click += new System.EventHandler(this.btnGameMulti_Click);
            // 
            // btnGamePlus
            // 
            this.btnGamePlus.Location = new System.Drawing.Point(243, 82);
            this.btnGamePlus.Name = "btnGamePlus";
            this.btnGamePlus.Size = new System.Drawing.Size(75, 23);
            this.btnGamePlus.TabIndex = 1;
            this.btnGamePlus.Text = "+1";
            this.btnGamePlus.UseVisualStyleBackColor = true;
            this.btnGamePlus.Click += new System.EventHandler(this.btnGamePlus_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(243, 39);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 36);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Начать заново";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // tbpGame2
            // 
            this.tbpGame2.Controls.Add(this.lblFinish);
            this.tbpGame2.Controls.Add(this.lblRules);
            this.tbpGame2.Controls.Add(this.lblHint1);
            this.tbpGame2.Controls.Add(this.lblHint);
            this.tbpGame2.Controls.Add(this.lblGame2Count);
            this.tbpGame2.Controls.Add(this.label7);
            this.tbpGame2.Controls.Add(this.btnGame2Start);
            this.tbpGame2.Controls.Add(this.lblUserAnswer);
            this.tbpGame2.Controls.Add(this.tbUserAnswer);
            this.tbpGame2.Location = new System.Drawing.Point(4, 22);
            this.tbpGame2.Name = "tbpGame2";
            this.tbpGame2.Size = new System.Drawing.Size(376, 311);
            this.tbpGame2.TabIndex = 2;
            this.tbpGame2.Text = "Игра 2";
            this.tbpGame2.UseVisualStyleBackColor = true;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(12, 121);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(0, 13);
            this.lblFinish.TabIndex = 13;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(9, 20);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(173, 13);
            this.lblRules.TabIndex = 12;
            this.lblRules.Text = "Нужно угадать число от 0 до 100";
            this.lblRules.Visible = false;
            // 
            // lblHint1
            // 
            this.lblHint1.AutoSize = true;
            this.lblHint1.Location = new System.Drawing.Point(85, 171);
            this.lblHint1.Name = "lblHint1";
            this.lblHint1.Size = new System.Drawing.Size(0, 13);
            this.lblHint1.TabIndex = 11;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(12, 171);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(66, 13);
            this.lblHint.TabIndex = 10;
            this.lblHint.Text = "Подсказка:";
            this.lblHint.Visible = false;
            this.lblHint.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblGame2Count
            // 
            this.lblGame2Count.AutoSize = true;
            this.lblGame2Count.Location = new System.Drawing.Point(49, 293);
            this.lblGame2Count.Name = "lblGame2Count";
            this.lblGame2Count.Size = new System.Drawing.Size(13, 13);
            this.lblGame2Count.TabIndex = 9;
            this.lblGame2Count.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ходы";
            // 
            // btnGame2Start
            // 
            this.btnGame2Start.Location = new System.Drawing.Point(293, 20);
            this.btnGame2Start.Name = "btnGame2Start";
            this.btnGame2Start.Size = new System.Drawing.Size(75, 34);
            this.btnGame2Start.TabIndex = 2;
            this.btnGame2Start.Text = "Начать Игру";
            this.btnGame2Start.UseVisualStyleBackColor = true;
            this.btnGame2Start.Click += new System.EventHandler(this.btnGame2Start_Click);
            // 
            // lblUserAnswer
            // 
            this.lblUserAnswer.AutoSize = true;
            this.lblUserAnswer.Location = new System.Drawing.Point(9, 90);
            this.lblUserAnswer.Name = "lblUserAnswer";
            this.lblUserAnswer.Size = new System.Drawing.Size(59, 13);
            this.lblUserAnswer.TabIndex = 1;
            this.lblUserAnswer.Text = "Ваш ответ";
            this.lblUserAnswer.Visible = false;
            // 
            // tbUserAnswer
            // 
            this.tbUserAnswer.Location = new System.Drawing.Point(74, 83);
            this.tbUserAnswer.MaxLength = 3;
            this.tbUserAnswer.Name = "tbUserAnswer";
            this.tbUserAnswer.Size = new System.Drawing.Size(100, 20);
            this.tbUserAnswer.TabIndex = 0;
            this.tbUserAnswer.Visible = false;
            this.tbUserAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbUserAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUserAnswer_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmiExit,
            this.tsmiGame1,
            this.tsmiGame2});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // stmiExit
            // 
            this.stmiExit.Name = "stmiExit";
            this.stmiExit.Size = new System.Drawing.Size(182, 22);
            this.stmiExit.Text = "Выход";
            this.stmiExit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tsmiGame1
            // 
            this.tsmiGame1.Name = "tsmiGame1";
            this.tsmiGame1.Size = new System.Drawing.Size(182, 22);
            this.tsmiGame1.Text = "Игра получи число";
            this.tsmiGame1.Click += new System.EventHandler(this.играToolStripMenuItem_Click);
            // 
            // tsmiGame2
            // 
            this.tsmiGame2.Name = "tsmiGame2";
            this.tsmiGame2.Size = new System.Drawing.Size(182, 22);
            this.tsmiGame2.Text = "Игра угадай число";
            this.tsmiGame2.Click += new System.EventHandler(this.tsmiGame2_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(68, 20);
            this.tsmiHelp.Text = "Помощь";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(149, 22);
            this.tsmiAbout.Text = "О программе";
            // 
            // lblCancelTurns
            // 
            this.lblCancelTurns.AutoSize = true;
            this.lblCancelTurns.Location = new System.Drawing.Point(177, 199);
            this.lblCancelTurns.Name = "lblCancelTurns";
            this.lblCancelTurns.Size = new System.Drawing.Size(100, 13);
            this.lblCancelTurns.TabIndex = 11;
            this.lblCancelTurns.Text = "Ходы для отмены:";
            this.lblCancelTurns.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.tbControl.ResumeLayout(false);
            this.tbpDoubler.ResumeLayout(false);
            this.tbpDoubler.PerformLayout();
            this.tbpGame.ResumeLayout(false);
            this.tbpGame.PerformLayout();
            this.tbpGame2.ResumeLayout(false);
            this.tbpGame2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbpDoubler;
        private System.Windows.Forms.TabPage tbpGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem stmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.ToolStripMenuItem tsmiGame1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblGameCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGameNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGameMulti;
        private System.Windows.Forms.Button btnGamePlus;
        private System.Windows.Forms.Button btnCancelLastTurn;
        private System.Windows.Forms.Label lblNumberToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpGame2;
        private System.Windows.Forms.Label lblUserAnswer;
        private System.Windows.Forms.TextBox tbUserAnswer;
        private System.Windows.Forms.Button btnGame2Start;
        private System.Windows.Forms.ToolStripMenuItem tsmiGame2;
        private System.Windows.Forms.Label lblGame2Count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblHint1;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblCancelTurns;
    }
}

