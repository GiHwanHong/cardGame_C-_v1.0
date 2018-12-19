namespace CardGame2
{
    partial class GameBoard
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CardsHolder = new System.Windows.Forms.Panel();
            this.card16 = new System.Windows.Forms.PictureBox();
            this.card15 = new System.Windows.Forms.PictureBox();
            this.card14 = new System.Windows.Forms.PictureBox();
            this.card13 = new System.Windows.Forms.PictureBox();
            this.card12 = new System.Windows.Forms.PictureBox();
            this.card11 = new System.Windows.Forms.PictureBox();
            this.card10 = new System.Windows.Forms.PictureBox();
            this.card9 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.gameTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlayAgain = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CardsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardsHolder
            // 
            this.CardsHolder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CardsHolder.Controls.Add(this.card16);
            this.CardsHolder.Controls.Add(this.card15);
            this.CardsHolder.Controls.Add(this.card14);
            this.CardsHolder.Controls.Add(this.card13);
            this.CardsHolder.Controls.Add(this.card12);
            this.CardsHolder.Controls.Add(this.card11);
            this.CardsHolder.Controls.Add(this.card10);
            this.CardsHolder.Controls.Add(this.card9);
            this.CardsHolder.Controls.Add(this.card8);
            this.CardsHolder.Controls.Add(this.card7);
            this.CardsHolder.Controls.Add(this.card6);
            this.CardsHolder.Controls.Add(this.card5);
            this.CardsHolder.Controls.Add(this.card4);
            this.CardsHolder.Controls.Add(this.card3);
            this.CardsHolder.Controls.Add(this.card2);
            this.CardsHolder.Controls.Add(this.card1);
            this.CardsHolder.Location = new System.Drawing.Point(12, 76);
            this.CardsHolder.Name = "CardsHolder";
            this.CardsHolder.Size = new System.Drawing.Size(607, 608);
            this.CardsHolder.TabIndex = 0;
            // 
            // card16
            // 
            this.card16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card16.Location = new System.Drawing.Point(454, 456);
            this.card16.Name = "card16";
            this.card16.Size = new System.Drawing.Size(150, 150);
            this.card16.TabIndex = 15;
            this.card16.TabStop = false;
            this.card16.Tag = "";
            this.card16.Click += new System.EventHandler(this.card1_Click);
            // 
            // card15
            // 
            this.card15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card15.Location = new System.Drawing.Point(303, 456);
            this.card15.Name = "card15";
            this.card15.Size = new System.Drawing.Size(150, 150);
            this.card15.TabIndex = 14;
            this.card15.TabStop = false;
            this.card15.Tag = "";
            this.card15.Click += new System.EventHandler(this.card1_Click);
            // 
            // card14
            // 
            this.card14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card14.Location = new System.Drawing.Point(152, 456);
            this.card14.Name = "card14";
            this.card14.Size = new System.Drawing.Size(150, 150);
            this.card14.TabIndex = 13;
            this.card14.TabStop = false;
            this.card14.Tag = "";
            this.card14.Click += new System.EventHandler(this.card1_Click);
            // 
            // card13
            // 
            this.card13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card13.Location = new System.Drawing.Point(1, 456);
            this.card13.Name = "card13";
            this.card13.Size = new System.Drawing.Size(150, 150);
            this.card13.TabIndex = 12;
            this.card13.TabStop = false;
            this.card13.Tag = "";
            this.card13.Click += new System.EventHandler(this.card1_Click);
            // 
            // card12
            // 
            this.card12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card12.Location = new System.Drawing.Point(454, 304);
            this.card12.Name = "card12";
            this.card12.Size = new System.Drawing.Size(150, 150);
            this.card12.TabIndex = 11;
            this.card12.TabStop = false;
            this.card12.Tag = "";
            this.card12.Click += new System.EventHandler(this.card1_Click);
            // 
            // card11
            // 
            this.card11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card11.Location = new System.Drawing.Point(303, 304);
            this.card11.Name = "card11";
            this.card11.Size = new System.Drawing.Size(150, 150);
            this.card11.TabIndex = 10;
            this.card11.TabStop = false;
            this.card11.Tag = "";
            this.card11.Click += new System.EventHandler(this.card1_Click);
            // 
            // card10
            // 
            this.card10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card10.Location = new System.Drawing.Point(152, 304);
            this.card10.Name = "card10";
            this.card10.Size = new System.Drawing.Size(150, 150);
            this.card10.TabIndex = 9;
            this.card10.TabStop = false;
            this.card10.Tag = "";
            this.card10.Click += new System.EventHandler(this.card1_Click);
            // 
            // card9
            // 
            this.card9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card9.Location = new System.Drawing.Point(1, 304);
            this.card9.Name = "card9";
            this.card9.Size = new System.Drawing.Size(150, 150);
            this.card9.TabIndex = 8;
            this.card9.TabStop = false;
            this.card9.Tag = "";
            this.card9.Click += new System.EventHandler(this.card1_Click);
            // 
            // card8
            // 
            this.card8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card8.Location = new System.Drawing.Point(454, 152);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(150, 150);
            this.card8.TabIndex = 7;
            this.card8.TabStop = false;
            this.card8.Tag = "";
            this.card8.Click += new System.EventHandler(this.card1_Click);
            // 
            // card7
            // 
            this.card7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card7.Location = new System.Drawing.Point(303, 152);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(150, 150);
            this.card7.TabIndex = 6;
            this.card7.TabStop = false;
            this.card7.Tag = "";
            this.card7.Click += new System.EventHandler(this.card1_Click);
            // 
            // card6
            // 
            this.card6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card6.Location = new System.Drawing.Point(152, 152);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(150, 150);
            this.card6.TabIndex = 5;
            this.card6.TabStop = false;
            this.card6.Tag = "";
            this.card6.Click += new System.EventHandler(this.card1_Click);
            // 
            // card5
            // 
            this.card5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card5.Location = new System.Drawing.Point(1, 152);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(150, 150);
            this.card5.TabIndex = 4;
            this.card5.TabStop = false;
            this.card5.Tag = "";
            this.card5.Click += new System.EventHandler(this.card1_Click);
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card4.Location = new System.Drawing.Point(454, 1);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(150, 150);
            this.card4.TabIndex = 3;
            this.card4.TabStop = false;
            this.card4.Tag = "";
            this.card4.Click += new System.EventHandler(this.card1_Click);
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card3.Location = new System.Drawing.Point(303, 1);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(150, 150);
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            this.card3.Tag = "";
            this.card3.Click += new System.EventHandler(this.card1_Click);
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card2.Location = new System.Drawing.Point(152, 1);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(150, 150);
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            this.card2.Tag = "";
            this.card2.Click += new System.EventHandler(this.card1_Click);
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.card1.Location = new System.Drawing.Point(1, 1);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(150, 150);
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            this.card1.Tag = "";
            this.card1.Click += new System.EventHandler(this.card1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(667, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "점수 : ";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreLabel.Location = new System.Drawing.Point(736, 285);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(17, 16);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 300;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 300;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // gameTime
            // 
            this.gameTime.AutoSize = true;
            this.gameTime.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gameTime.Location = new System.Drawing.Point(733, 243);
            this.gameTime.Name = "gameTime";
            this.gameTime.Size = new System.Drawing.Size(89, 19);
            this.gameTime.TabIndex = 5;
            this.gameTime.Text = "00:00:00";
            this.gameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(633, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "게임시간 : ";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.AutoSize = true;
            this.btnPlayAgain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlayAgain.Depth = 0;
            this.btnPlayAgain.Icon = null;
            this.btnPlayAgain.Location = new System.Drawing.Point(652, 91);
            this.btnPlayAgain.MaximumSize = new System.Drawing.Size(153, 100);
            this.btnPlayAgain.MinimumSize = new System.Drawing.Size(153, 100);
            this.btnPlayAgain.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Primary = true;
            this.btnPlayAgain.Size = new System.Drawing.Size(153, 100);
            this.btnPlayAgain.TabIndex = 7;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(859, 690);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameTime);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardsHolder);
            this.MaximizeBox = false;
            this.Name = "GameBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SameCardGame   /   UserName : ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CardsHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.card16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CardsHolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card16;
        private System.Windows.Forms.PictureBox card15;
        private System.Windows.Forms.PictureBox card14;
        private System.Windows.Forms.PictureBox card13;
        private System.Windows.Forms.PictureBox card12;
        private System.Windows.Forms.PictureBox card11;
        private System.Windows.Forms.PictureBox card10;
        private System.Windows.Forms.PictureBox card9;
        private System.Windows.Forms.PictureBox card8;
        private System.Windows.Forms.PictureBox card7;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label gameTime;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btnPlayAgain;
    }
}

