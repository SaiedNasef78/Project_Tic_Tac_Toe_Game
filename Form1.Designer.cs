namespace Project_Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabTic_Tac_Toe = new System.Windows.Forms.Label();
            this.Turn = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.LabWinner = new System.Windows.Forms.Label();
            this.LblWinner = new System.Windows.Forms.Label();
            this.BT_Restart_Game = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabTic_Tac_Toe
            // 
            this.LabTic_Tac_Toe.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTic_Tac_Toe.ForeColor = System.Drawing.Color.White;
            this.LabTic_Tac_Toe.Location = new System.Drawing.Point(523, 9);
            this.LabTic_Tac_Toe.Name = "LabTic_Tac_Toe";
            this.LabTic_Tac_Toe.Size = new System.Drawing.Size(666, 77);
            this.LabTic_Tac_Toe.TabIndex = 9;
            this.LabTic_Tac_Toe.Text = "Tic-Tac-Toe Game";
            // 
            // Turn
            // 
            this.Turn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn.ForeColor = System.Drawing.Color.Yellow;
            this.Turn.Location = new System.Drawing.Point(110, 136);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(219, 77);
            this.Turn.TabIndex = 10;
            this.Turn.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(95, 213);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(398, 77);
            this.lblTurn.TabIndex = 11;
            this.lblTurn.Text = "Player 1";
            this.lblTurn.Click += new System.EventHandler(this.LabGameOver_Click);
            // 
            // LabWinner
            // 
            this.LabWinner.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWinner.ForeColor = System.Drawing.Color.Yellow;
            this.LabWinner.Location = new System.Drawing.Point(97, 316);
            this.LabWinner.Name = "LabWinner";
            this.LabWinner.Size = new System.Drawing.Size(221, 77);
            this.LabWinner.TabIndex = 12;
            this.LabWinner.Text = "Winner";
            // 
            // LblWinner
            // 
            this.LblWinner.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblWinner.Location = new System.Drawing.Point(95, 380);
            this.LblWinner.Name = "LblWinner";
            this.LblWinner.Size = new System.Drawing.Size(302, 77);
            this.LblWinner.TabIndex = 13;
            this.LblWinner.Text = "In Progress";
            this.LblWinner.Click += new System.EventHandler(this.LabDraw_Click);
            // 
            // BT_Restart_Game
            // 
            this.BT_Restart_Game.BackColor = System.Drawing.Color.Black;
            this.BT_Restart_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Restart_Game.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Restart_Game.ForeColor = System.Drawing.Color.White;
            this.BT_Restart_Game.Location = new System.Drawing.Point(38, 536);
            this.BT_Restart_Game.Name = "BT_Restart_Game";
            this.BT_Restart_Game.Size = new System.Drawing.Size(331, 68);
            this.BT_Restart_Game.TabIndex = 14;
            this.BT_Restart_Game.Text = "Restart Game";
            this.BT_Restart_Game.UseVisualStyleBackColor = false;
            this.BT_Restart_Game.Click += new System.EventHandler(this.BT_Restart_Game_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1000, 520);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 149);
            this.button9.TabIndex = 8;
            this.button9.TabStop = false;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(709, 520);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 149);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(436, 518);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 149);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1000, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 149);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(709, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 149);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::Project_Tic_Tac_Toe.Properties.Resources.Question2;
            this.button4.Location = new System.Drawing.Point(438, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 149);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1000, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 149);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(719, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 149);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Project_Tic_Tac_Toe.Properties.Resources.Question2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(438, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 149);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1292, 729);
            this.Controls.Add(this.BT_Restart_Game);
            this.Controls.Add(this.LblWinner);
            this.Controls.Add(this.LabWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.LabTic_Tac_Toe);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label LabTic_Tac_Toe;
        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label LabWinner;
        private System.Windows.Forms.Label LblWinner;
        private System.Windows.Forms.Button BT_Restart_Game;
    }
}

