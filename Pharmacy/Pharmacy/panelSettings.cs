using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class panelSettings : UserControl
    {
        private static bool serbian;
        private static bool english;
        private static bool classic;
        private static bool dark;
        private static bool blackAndWhite;

        public panelSettings()
        {
            InitializeComponent();
            classic = true;
            serbian = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            new LogInForm().Show();
        }

        public void setHomepageTitleColor(Color color)
        {
            lblSettingsHeader.ForeColor = color;
        }
        private void rbSerbian_CheckedChanged(object sender, EventArgs e)
        {
            serbian = true;
            english = false;
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            english = true;
            serbian = false;
        }

        private void rbTheme1_CheckedChanged(object sender, EventArgs e)
        {
            classic = true;
            dark = false;
            blackAndWhite = false;
        }

        private void rbTheme2_CheckedChanged(object sender, EventArgs e)
        {
            dark = true;
            classic = false;
            blackAndWhite = false;
        }

        private void rbTheme3_CheckedChanged(object sender, EventArgs e)
        {
            blackAndWhite = true;
            classic = false;
            blackAndWhite = false;
        }

        public static bool isClassic()
        {
            return classic;
        }

        public static bool isDark()
        {
            return dark;
        }

        public static bool isBlackAndWhite()
        {
            return blackAndWhite;
        }

        public static bool isSerbian()
        {
            return serbian;
        }

        public static bool isEnglish()
        {
            return english;
        }


    }
}
