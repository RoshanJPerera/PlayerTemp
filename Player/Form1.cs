using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing(); 
        }

        private void customizeDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistsSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistsSubmenu.Visible == true)
                panelPlaylistsSubmenu.Visible = false;
            if (panelToolsSubmenu.Visible == true)
                panelToolsSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false; 
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }
        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
#endregion


        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistsSubmenu);
        }
        #region PlaylistsSubMenu
        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
#endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }


        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubmenu);
        }
        #region ToolsSubMenu
        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChiledForm(Form chiledForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = chiledForm;
            chiledForm.TopLevel = false;
            chiledForm.FormBorderStyle = FormBorderStyle.None;
            chiledForm.Dock = DockStyle.Fill;

        }

    } 

}
