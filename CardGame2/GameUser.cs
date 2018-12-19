using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2
{
    public partial class GameUser : MaterialForm
    {
        // 사용자 명을 입력 받는 창.
        public GameUser()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue50, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                this.Visible = false;
                GameLevel frm4 = new GameLevel(textBox1.Text);
                frm4.Show();
            }
            else
            {
                MessageBox.Show("사용자 명을 입력해주세요.", "에러메세지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
