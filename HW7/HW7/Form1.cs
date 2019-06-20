using System;
using System.Windows.Forms;


namespace HW7
{

    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "1";
            countlbl.Text = "0";
            gamelbl.Text = "1";
            gameCountlbl.Text = "0";
            this.Text = "Игры";
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            countlbl.Text = (int.Parse(countlbl.Text) + 1).ToString();
        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            countlbl.Text = (int.Parse(countlbl.Text) + 1).ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            countlbl.Text = "0";
        }

        private void gamebtn1_Click(object sender, EventArgs e)
        {
            gamelbl.Text = (int.Parse(gamelbl.Text) + 1).ToString();
            gameCountlbl.Text = (int.Parse(gameCountlbl.Text) + 1).ToString();
        }
        private void gamebtn2_Click(object sender, EventArgs e)
        {
            gamelbl.Text = (int.Parse(gamelbl.Text) * 2).ToString();
            gameCountlbl.Text = (int.Parse(gameCountlbl.Text) + 1).ToString();
        }

        private void bamebtn3_Click(object sender, EventArgs e)
        {
            gamelbl.Text = "1";
            gameCountlbl.Text = "0";
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.countlbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удвоительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doubler = new System.Windows.Forms.GroupBox();
            this.game = new System.Windows.Forms.GroupBox();
            this.gamebtn1 = new System.Windows.Forms.Button();
            this.gamebtn2 = new System.Windows.Forms.Button();
            this.gameCountlbl = new System.Windows.Forms.Label();
            this.bamebtn3 = new System.Windows.Forms.Button();
            this.gamelbl = new System.Windows.Forms.Label();
            this.gameStartbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.doubler.SuspendLayout();
            this.game.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(172, 19);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(172, 48);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(172, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 29);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
            // 
            // countlbl
            // 
            this.countlbl.AccessibleDescription = "Ходы";
            this.countlbl.AutoSize = true;
            this.countlbl.Location = new System.Drawing.Point(7, 150);
            this.countlbl.Name = "countlbl";
            this.countlbl.Size = new System.Drawing.Size(34, 13);
            this.countlbl.TabIndex = 4;
            this.countlbl.Text = "Ходы";
            this.countlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удвоительToolStripMenuItem,
            this.игратьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // удвоительToolStripMenuItem
            // 
            this.удвоительToolStripMenuItem.Name = "удвоительToolStripMenuItem";
            this.удвоительToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.удвоительToolStripMenuItem.Text = "Удвоитель";
            this.удвоительToolStripMenuItem.Click += new System.EventHandler(this.удвоительToolStripMenuItem_Click);
            // 
            // игратьToolStripMenuItem
            // 
            this.игратьToolStripMenuItem.Name = "игратьToolStripMenuItem";
            this.игратьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.игратьToolStripMenuItem.Text = "Играть";
            this.игратьToolStripMenuItem.Click += new System.EventHandler(this.игратьToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // doubler
            // 
            this.doubler.Controls.Add(this.btnCommand1);
            this.doubler.Controls.Add(this.btnCommand2);
            this.doubler.Controls.Add(this.countlbl);
            this.doubler.Controls.Add(this.btnReset);
            this.doubler.Controls.Add(this.lblNumber);
            this.doubler.Location = new System.Drawing.Point(12, 27);
            this.doubler.Name = "doubler";
            this.doubler.Size = new System.Drawing.Size(260, 179);
            this.doubler.TabIndex = 6;
            this.doubler.TabStop = false;
            this.doubler.Text = "Удвоитель";
            this.doubler.Visible = false;
            this.doubler.Enter += new System.EventHandler(this.doubler_Enter);
            // 
            // game
            // 
            this.game.Controls.Add(this.gameStartbtn);
            this.game.Controls.Add(this.gamebtn1);
            this.game.Controls.Add(this.gamebtn2);
            this.game.Controls.Add(this.gameCountlbl);
            this.game.Controls.Add(this.bamebtn3);
            this.game.Controls.Add(this.gamelbl);
            this.game.Location = new System.Drawing.Point(288, 27);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(260, 179);
            this.game.TabIndex = 7;
            this.game.TabStop = false;
            this.game.Text = "Игра";
            this.game.Visible = false;
            // 
            // gamebtn1
            // 
            this.gamebtn1.Location = new System.Drawing.Point(176, 17);
            this.gamebtn1.Name = "gamebtn1";
            this.gamebtn1.Size = new System.Drawing.Size(75, 23);
            this.gamebtn1.TabIndex = 5;
            this.gamebtn1.Text = "+1";
            this.gamebtn1.UseVisualStyleBackColor = true;
            this.gamebtn1.Click += new System.EventHandler(this.gamebtn1_Click);
            // 
            // gamebtn2
            // 
            this.gamebtn2.Location = new System.Drawing.Point(176, 46);
            this.gamebtn2.Name = "gamebtn2";
            this.gamebtn2.Size = new System.Drawing.Size(75, 23);
            this.gamebtn2.TabIndex = 6;
            this.gamebtn2.Text = "x2";
            this.gamebtn2.UseVisualStyleBackColor = true;
            this.gamebtn2.Click += new System.EventHandler(this.gamebtn2_Click);
            // 
            // gameCountlbl
            // 
            this.gameCountlbl.AccessibleDescription = "Ходы";
            this.gameCountlbl.AutoSize = true;
            this.gameCountlbl.Location = new System.Drawing.Point(11, 148);
            this.gameCountlbl.Name = "gameCountlbl";
            this.gameCountlbl.Size = new System.Drawing.Size(40, 13);
            this.gameCountlbl.TabIndex = 9;
            this.gameCountlbl.Text = "Ходы: ";
            // 
            // bamebtn3
            // 
            this.bamebtn3.Location = new System.Drawing.Point(176, 75);
            this.bamebtn3.Name = "bamebtn3";
            this.bamebtn3.Size = new System.Drawing.Size(75, 23);
            this.bamebtn3.TabIndex = 7;
            this.bamebtn3.Text = "Reset";
            this.bamebtn3.UseVisualStyleBackColor = true;
            this.bamebtn3.Click += new System.EventHandler(this.bamebtn3_Click);
            // 
            // gamelbl
            // 
            this.gamelbl.AutoSize = true;
            this.gamelbl.Location = new System.Drawing.Point(10, 27);
            this.gamelbl.Name = "gamelbl";
            this.gamelbl.Size = new System.Drawing.Size(35, 13);
            this.gamelbl.TabIndex = 8;
            this.gamelbl.Text = "label1";
            // 
            // gameStartbtn
            // 
            this.gameStartbtn.Location = new System.Drawing.Point(95, 75);
            this.gameStartbtn.Name = "gameStartbtn";
            this.gameStartbtn.Size = new System.Drawing.Size(75, 23);
            this.gameStartbtn.TabIndex = 10;
            this.gameStartbtn.Text = "Start";
            this.gameStartbtn.UseVisualStyleBackColor = true;
            this.gameStartbtn.Click += new System.EventHandler(this.gameStartbtn_Click);
            // 
            // FormStart
            // 
            this.ClientSize = new System.Drawing.Size(982, 763);
            this.Controls.Add(this.game);
            this.Controls.Add(this.doubler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStart";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.doubler.ResumeLayout(false);
            this.doubler.PerformLayout();
            this.game.ResumeLayout(false);
            this.game.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler.Visible = false;
            game.Visible = true;
            lblNumber.Text = "1";
            countlbl.Text = "0";
        }

        private void удвоительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler.Visible = true;
            game.Visible = false;
            gamelbl.Text = "1";
            gameCountlbl.Text = "0";
        }

        private void doubler_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gameStartbtn_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Нужно получить число -\nЗа минимальное число нажатий.");

        }

    }
}

