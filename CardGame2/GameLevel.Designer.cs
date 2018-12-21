namespace CardGame2
{
    partial class GameLevel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLevel0 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLevel1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLevel2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "난이도를 선택해주세요";
            // 
            // btnLevel0
            // 
            this.btnLevel0.AutoSize = true;
            this.btnLevel0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLevel0.Depth = 0;
            this.btnLevel0.Icon = null;
            this.btnLevel0.Location = new System.Drawing.Point(24, 99);
            this.btnLevel0.MaximumSize = new System.Drawing.Size(65, 40);
            this.btnLevel0.MinimumSize = new System.Drawing.Size(65, 40);
            this.btnLevel0.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLevel0.Name = "btnLevel0";
            this.btnLevel0.Primary = true;
            this.btnLevel0.Size = new System.Drawing.Size(65, 40);
            this.btnLevel0.TabIndex = 4;
            this.btnLevel0.Text = "초급";
            this.btnLevel0.UseVisualStyleBackColor = true;
            this.btnLevel0.Click += new System.EventHandler(this.btnLevel0_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.AutoSize = true;
            this.btnLevel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLevel1.Depth = 0;
            this.btnLevel1.Icon = null;
            this.btnLevel1.Location = new System.Drawing.Point(101, 99);
            this.btnLevel1.MaximumSize = new System.Drawing.Size(65, 40);
            this.btnLevel1.MinimumSize = new System.Drawing.Size(65, 40);
            this.btnLevel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Primary = true;
            this.btnLevel1.Size = new System.Drawing.Size(65, 40);
            this.btnLevel1.TabIndex = 5;
            this.btnLevel1.Text = "중급";
            this.btnLevel1.UseVisualStyleBackColor = true;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.AutoSize = true;
            this.btnLevel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLevel2.Depth = 0;
            this.btnLevel2.Icon = null;
            this.btnLevel2.Location = new System.Drawing.Point(183, 99);
            this.btnLevel2.MaximumSize = new System.Drawing.Size(65, 40);
            this.btnLevel2.MinimumSize = new System.Drawing.Size(65, 40);
            this.btnLevel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Primary = true;
            this.btnLevel2.Size = new System.Drawing.Size(65, 40);
            this.btnLevel2.TabIndex = 6;
            this.btnLevel2.Text = "고급";
            this.btnLevel2.UseVisualStyleBackColor = true;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // GameLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 150);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.btnLevel0);
            this.Controls.Add(this.label1);
            this.Name = "GameLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "난이도 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnLevel0;
        private MaterialSkin.Controls.MaterialRaisedButton btnLevel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnLevel2;
    }
}