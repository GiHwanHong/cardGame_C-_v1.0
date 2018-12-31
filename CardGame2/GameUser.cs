using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2
{
    /// <summary>
    // 게임 사용자 이름을 입력 받는 form
    /// </summary>

    public partial class GameUser : MaterialForm
    {
        private string _userName = "";
        public string UserName { get { return _userName; } set { _userName = value; } }

        public GameUser()
        {
            InitializeComponent();

            MaterialDesignForm();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrEmpty(txtUserName.Text)
             && Regex.IsMatch(txtUserName.Text, "^[a-zA-Z ]"))
            {
                UserName = txtUserName.Text;
                this.Visible = false;
            }
            else
                MessageBox.Show("을 확인해주세요.", "알림메시지 창");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료메시지", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        public void MaterialDesignForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue50, Accent.LightBlue200, TextShade.WHITE);
        }

        private void GameUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();

        }
    }
}