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
    public partial class GameLevel : MaterialForm
    {
        // 난이도를 설정하는 창.
        private string _username = "";
        public GameLevel(string str)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue50, Accent.LightBlue200, TextShade.WHITE);
            _username = str;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
         
        }

        private void btnLevel0_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameBoard frm1 = new GameBoard(_username, "초급");
            frm1.Show();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameBoard frm1 = new GameBoard(_username, "중급");
            frm1.Show();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameBoard frm1 = new GameBoard(_username, "고급");
            frm1.Show();
        }
    }
}
