namespace CardGame2
{
    partial class GameMode
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
            this.btnTogether = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAlone = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(49, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "게임모드를 설정해주세요!";
            // 
            // btnTogether
            // 
            this.btnTogether.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTogether.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTogether.Depth = 0;
            this.btnTogether.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTogether.Icon = null;
            this.btnTogether.Location = new System.Drawing.Point(137, 102);
            this.btnTogether.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTogether.Name = "btnTogether";
            this.btnTogether.Primary = true;
            this.btnTogether.Size = new System.Drawing.Size(81, 36);
            this.btnTogether.TabIndex = 5;
            this.btnTogether.Text = "같이하기";
            this.btnTogether.UseVisualStyleBackColor = true;
            this.btnTogether.Click += new System.EventHandler(this.btnTogether_Click_1);
            // 
            // btnAlone
            // 
            this.btnAlone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAlone.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlone.Depth = 0;
            this.btnAlone.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAlone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnAlone.ForeColor = System.Drawing.Color.White;
            this.btnAlone.Icon = null;
            this.btnAlone.Location = new System.Drawing.Point(35, 102);
            this.btnAlone.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlone.Name = "btnAlone";
            this.btnAlone.Primary = true;
            this.btnAlone.Size = new System.Drawing.Size(81, 36);
            this.btnAlone.TabIndex = 6;
            this.btnAlone.Text = "혼자하기";
            this.btnAlone.UseVisualStyleBackColor = false;
            this.btnAlone.Click += new System.EventHandler(this.btnAlone_Click_1);
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 150);
            this.Controls.Add(this.btnAlone);
            this.Controls.Add(this.btnTogether);
            this.Controls.Add(this.label1);
            this.Name = "GameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMode Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnTogether;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlone;
    }
}