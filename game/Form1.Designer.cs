namespace game
{
    partial class frmSolitaire
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.picDeck = new System.Windows.Forms.PictureBox();
            this.picWaste = new System.Windows.Forms.PictureBox();
            this.picFinish1 = new System.Windows.Forms.PictureBox();
            this.picFinish2 = new System.Windows.Forms.PictureBox();
            this.picFinish3 = new System.Windows.Forms.PictureBox();
            this.picFinish4 = new System.Windows.Forms.PictureBox();
            this.pnlCol1 = new System.Windows.Forms.Panel();
            this.pnlCol3 = new System.Windows.Forms.Panel();
            this.pnlCol2 = new System.Windows.Forms.Panel();
            this.pnlCol4 = new System.Windows.Forms.Panel();
            this.pnlCol5 = new System.Windows.Forms.Panel();
            this.pnlCol6 = new System.Windows.Forms.Panel();
            this.pnlCol7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(20, 20);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(110, 49);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "新遊戲";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDraw.Location = new System.Drawing.Point(136, 20);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 49);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "抽牌";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestart.Location = new System.Drawing.Point(242, 20);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(92, 49);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "重新開始";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(400, 28);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(79, 29);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // picDeck
            // 
            this.picDeck.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDeck.Image = global::game.Properties.Resources.back;
            this.picDeck.Location = new System.Drawing.Point(40, 90);
            this.picDeck.Name = "picDeck";
            this.picDeck.Size = new System.Drawing.Size(90, 130);
            this.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeck.TabIndex = 4;
            this.picDeck.TabStop = false;
            // 
            // picWaste
            // 
            this.picWaste.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picWaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWaste.Location = new System.Drawing.Point(150, 90);
            this.picWaste.Name = "picWaste";
            this.picWaste.Size = new System.Drawing.Size(90, 130);
            this.picWaste.TabIndex = 5;
            this.picWaste.TabStop = false;
            // 
            // picFinish1
            // 
            this.picFinish1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picFinish1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFinish1.Location = new System.Drawing.Point(560, 90);
            this.picFinish1.Name = "picFinish1";
            this.picFinish1.Size = new System.Drawing.Size(90, 130);
            this.picFinish1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFinish1.TabIndex = 6;
            this.picFinish1.TabStop = false;
            // 
            // picFinish2
            // 
            this.picFinish2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picFinish2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFinish2.Location = new System.Drawing.Point(670, 90);
            this.picFinish2.Name = "picFinish2";
            this.picFinish2.Size = new System.Drawing.Size(90, 130);
            this.picFinish2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFinish2.TabIndex = 7;
            this.picFinish2.TabStop = false;
            // 
            // picFinish3
            // 
            this.picFinish3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picFinish3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFinish3.Location = new System.Drawing.Point(780, 90);
            this.picFinish3.Name = "picFinish3";
            this.picFinish3.Size = new System.Drawing.Size(90, 130);
            this.picFinish3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFinish3.TabIndex = 8;
            this.picFinish3.TabStop = false;
            // 
            // picFinish4
            // 
            this.picFinish4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picFinish4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFinish4.Location = new System.Drawing.Point(890, 90);
            this.picFinish4.Name = "picFinish4";
            this.picFinish4.Size = new System.Drawing.Size(90, 130);
            this.picFinish4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFinish4.TabIndex = 9;
            this.picFinish4.TabStop = false;
            // 
            // pnlCol1
            // 
            this.pnlCol1.AllowDrop = true;
            this.pnlCol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCol1.BackColor = System.Drawing.Color.Green;
            this.pnlCol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCol1.Location = new System.Drawing.Point(40, 260);
            this.pnlCol1.Name = "pnlCol1";
            this.pnlCol1.Size = new System.Drawing.Size(110, 400);
            this.pnlCol1.TabIndex = 10;
            // 
            // pnlCol3
            // 
            this.pnlCol3.AllowDrop = true;
            this.pnlCol3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCol3.BackColor = System.Drawing.Color.Green;
            this.pnlCol3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCol3.Location = new System.Drawing.Point(320, 260);
            this.pnlCol3.Name = "pnlCol3";
            this.pnlCol3.Size = new System.Drawing.Size(110, 400);
            this.pnlCol3.TabIndex = 11;
            // 
            // pnlCol2
            // 
            this.pnlCol2.AllowDrop = true;
            this.pnlCol2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCol2.BackColor = System.Drawing.Color.Green;
            this.pnlCol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCol2.Location = new System.Drawing.Point(180, 260);
            this.pnlCol2.Name = "pnlCol2";
            this.pnlCol2.Size = new System.Drawing.Size(110, 400);
            this.pnlCol2.TabIndex = 12;
            // 
            // pnlCol4
            // 
            this.pnlCol4.AllowDrop = true;
            this.pnlCol4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCol4.BackColor = System.Drawing.Color.Green;
            this.pnlCol4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCol4.Location = new System.Drawing.Point(460, 260);
            this.pnlCol4.Name = "pnlCol4";
            this.pnlCol4.Size = new System.Drawing.Size(110, 400);
            this.pnlCol4.TabIndex = 13;
            // 
            // pnlCol5
            // 
            this.pnlCol5.AllowDrop = true;
            this.pnlCol5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCol5.BackColor = System.Drawing.Color.Green;
            this.pnlCol5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCol5.Location = new System.Drawing.Point(600, 260);
            this.pnlCol5.Name = "pnlCol5";
            this.pnlCol5.Size = new System.Drawing.Size(110, 400);
            this.pnlCol5.TabIndex = 14;
            // 
            // pnlCol6
            // 
            this.pnlCol6.AllowDrop = true;
            this.pnlCol6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCol6.BackColor = System.Drawing.Color.Green;
            this.pnlCol6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCol6.Location = new System.Drawing.Point(740, 260);
            this.pnlCol6.Name = "pnlCol6";
            this.pnlCol6.Size = new System.Drawing.Size(110, 400);
            this.pnlCol6.TabIndex = 15;
            // 
            // pnlCol7
            // 
            this.pnlCol7.AllowDrop = true;
            this.pnlCol7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCol7.BackColor = System.Drawing.Color.Green;
            this.pnlCol7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCol7.Location = new System.Drawing.Point(880, 260);
            this.pnlCol7.Name = "pnlCol7";
            this.pnlCol7.Size = new System.Drawing.Size(110, 400);
            this.pnlCol7.TabIndex = 16;
            // 
            // frmSolitaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.pnlCol7);
            this.Controls.Add(this.pnlCol6);
            this.Controls.Add(this.pnlCol5);
            this.Controls.Add(this.pnlCol4);
            this.Controls.Add(this.pnlCol2);
            this.Controls.Add(this.pnlCol3);
            this.Controls.Add(this.pnlCol1);
            this.Controls.Add(this.picFinish4);
            this.Controls.Add(this.picFinish3);
            this.Controls.Add(this.picFinish2);
            this.Controls.Add(this.picFinish1);
            this.Controls.Add(this.picWaste);
            this.Controls.Add(this.picDeck);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnNewGame);
            this.Name = "frmSolitaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "接龍 Solitaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinish4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picDeck;
        private System.Windows.Forms.PictureBox picWaste;
        private System.Windows.Forms.PictureBox picFinish1;
        private System.Windows.Forms.PictureBox picFinish2;
        private System.Windows.Forms.PictureBox picFinish3;
        private System.Windows.Forms.PictureBox picFinish4;
        private System.Windows.Forms.Panel pnlCol1;
        private System.Windows.Forms.Panel pnlCol3;
        private System.Windows.Forms.Panel pnlCol2;
        private System.Windows.Forms.Panel pnlCol4;
        private System.Windows.Forms.Panel pnlCol5;
        private System.Windows.Forms.Panel pnlCol6;
        private System.Windows.Forms.Panel pnlCol7;
    }
}

