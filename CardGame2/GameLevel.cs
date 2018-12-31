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
    /// <summary>
    /// 난이도를 설정하는 창.
    /// </summary>
    public partial class GameLevel : MaterialForm
    {
        private string _levelName = "";

        public string LevelName { get { return _levelName; } set { _levelName = value; } }

        public GameLevel()
        {
            InitializeComponent();

            MaterialDesignForm();
        }

        private void btnLevel0_Click(object sender, EventArgs e)
        {
            LevelName = "초급";
            this.Visible = false;
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            LevelName = "중급";
            this.Visible = false;
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            LevelName = "고급";
            this.Visible = false;
        }
        public void MaterialDesignForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue50, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
