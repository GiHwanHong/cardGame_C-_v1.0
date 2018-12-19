using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2
{
    public partial class GameMode : MaterialForm
    {
        public GameMode()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue50, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnAlone_Click(object sender, EventArgs e)
        {
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnTogether_Click(object sender, EventArgs e)
        {
            

        }

        private static void ThreadStart()
        {
            Application.Run(new GameUser());
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }


        private void btnAlone_Click_1(object sender, EventArgs e)
        {
            btnAlone.BackColor = Color.LightCyan;
            GameUser frmUser= new GameUser();
            frmUser.Show();
            this.Visible = false;
        }

        private void btnTogether_Click_1(object sender, EventArgs e)
        {
            ThreadStart th = new ThreadStart(ThreadStart);
            Thread thread = new Thread(th);

            thread.Start();
        }
    }
}
