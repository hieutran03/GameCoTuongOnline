namespace CoTuongLAN
{
    partial class CuongTuongLAN
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.btnGui = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.timerRemainingTime = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.lblOpponentRemainingTime = new System.Windows.Forms.Label();
            this.lblOpponentName = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSurrender = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.ptbBanCo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOpponentScore = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanCo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lsvMessage);
            this.panel2.Controls.Add(this.btnGui);
            this.panel2.Controls.Add(this.txtChat);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(649, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 291);
            this.panel2.TabIndex = 5;
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(6, 5);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(277, 250);
            this.lsvMessage.TabIndex = 7;
            this.lsvMessage.TileSize = new System.Drawing.Size(250, 15);
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.Tile;
            // 
            // btnGui
            // 
            this.btnGui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGui.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGui.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGui.Location = new System.Drawing.Point(222, 259);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(61, 25);
            this.btnGui.TabIndex = 2;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = false;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtChat
            // 
            this.txtChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChat.Location = new System.Drawing.Point(6, 260);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(211, 23);
            this.txtChat.TabIndex = 1;
            // 
            // timerRemainingTime
            // 
            this.timerRemainingTime.Interval = 1000;
            this.timerRemainingTime.Tick += new System.EventHandler(this.timerRemainingTime_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txbIP);
            this.panel3.Location = new System.Drawing.Point(649, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 47);
            this.panel3.TabIndex = 12;
            // 
            // btnLAN
            // 
            this.btnLAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLAN.BackColor = System.Drawing.Color.LightGray;
            this.btnLAN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLAN.Location = new System.Drawing.Point(201, 10);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(80, 25);
            this.btnLAN.TabIndex = 6;
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txbIP
            // 
            this.txbIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIP.Location = new System.Drawing.Point(6, 11);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(191, 23);
            this.txbIP.TabIndex = 5;
            this.txbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOpponentRemainingTime
            // 
            this.lblOpponentRemainingTime.AutoSize = true;
            this.lblOpponentRemainingTime.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOpponentRemainingTime.Location = new System.Drawing.Point(625, 45);
            this.lblOpponentRemainingTime.Name = "lblOpponentRemainingTime";
            this.lblOpponentRemainingTime.Size = new System.Drawing.Size(72, 35);
            this.lblOpponentRemainingTime.TabIndex = 13;
            this.lblOpponentRemainingTime.Text = "00:00";
            // 
            // lblOpponentName
            // 
            this.lblOpponentName.AutoSize = true;
            this.lblOpponentName.Location = new System.Drawing.Point(628, 32);
            this.lblOpponentName.Name = "lblOpponentName";
            this.lblOpponentName.Size = new System.Drawing.Size(46, 13);
            this.lblOpponentName.TabIndex = 12;
            this.lblOpponentName.Text = "Đối thủ";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRemainingTime.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTime.ForeColor = System.Drawing.Color.Black;
            this.lblRemainingTime.Location = new System.Drawing.Point(624, 657);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(84, 37);
            this.lblRemainingTime.TabIndex = 15;
            this.lblRemainingTime.Text = "00:00";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(628, 638);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Bạn";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewGame.BackColor = System.Drawing.Color.LightGray;
            this.btnNewGame.Enabled = false;
            this.btnNewGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNewGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGame.Location = new System.Drawing.Point(163, 69);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(90, 27);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Cầu hòa";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUndo.BackColor = System.Drawing.Color.LightGray;
            this.btnUndo.Enabled = false;
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.Location = new System.Drawing.Point(163, 17);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(90, 27);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Xin đi lại";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSurrender
            // 
            this.btnSurrender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSurrender.BackColor = System.Drawing.Color.LightGray;
            this.btnSurrender.Enabled = false;
            this.btnSurrender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSurrender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSurrender.Location = new System.Drawing.Point(34, 17);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Size = new System.Drawing.Size(90, 27);
            this.btnSurrender.TabIndex = 8;
            this.btnSurrender.Text = "Đầu hàng";
            this.btnSurrender.UseVisualStyleBackColor = true;
            this.btnSurrender.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(30, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 27);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Ván mới";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(679, 625);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 30);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "0";
            // 
            // ptbBanCo
            // 
            this.ptbBanCo.BackColor = System.Drawing.Color.Transparent;
            this.ptbBanCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbBanCo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbBanCo.Image = global::CoTuongLAN.Properties.Resources.BanCoTuong;
            this.ptbBanCo.InitialImage = null;
            this.ptbBanCo.Location = new System.Drawing.Point(12, 32);
            this.ptbBanCo.Name = "ptbBanCo";
            this.ptbBanCo.Size = new System.Drawing.Size(607, 662);
            this.ptbBanCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBanCo.TabIndex = 14;
            this.ptbBanCo.TabStop = false;
            this.ptbBanCo.Click += new System.EventHandler(this.ptbBanCo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnSurrender);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(649, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 111);
            this.panel1.TabIndex = 13;
            // 
            // lblOpponentScore
            // 
            this.lblOpponentScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOpponentScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOpponentScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOpponentScore.Location = new System.Drawing.Point(703, 32);
            this.lblOpponentScore.Name = "lblOpponentScore";
            this.lblOpponentScore.Size = new System.Drawing.Size(21, 31);
            this.lblOpponentScore.TabIndex = 16;
            this.lblOpponentScore.Text = "0";
            // 
            // CuongTuongLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(942, 726);
            this.Controls.Add(this.lblOpponentScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ptbBanCo);
            this.Controls.Add(this.lblOpponentRemainingTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOpponentName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CuongTuongLAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Co Tuong (Online)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanCo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Timer timerRemainingTime;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Label lblOpponentRemainingTime;
        private System.Windows.Forms.Label lblOpponentName;
        private System.Windows.Forms.PictureBox ptbBanCo;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSurrender;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOpponentScore;
    }
}

