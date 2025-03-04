using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public static class Constants
    {
        public static Theme CLASSIC_THEME = new Theme(System.Drawing.Color.FromArgb(255, 100, 20), System.Drawing.Color.FromArgb(40, 142, 62), System.Drawing.Color.FromArgb(255, 255, 247), Color.White, Color.Black,new FontFamily("Microsoft Sans Serif"),12, System.Drawing.Color.FromArgb(235,85,20));
        public static Theme GRAY_THEME =new Theme(Color.DarkGray,Color.DimGray, System.Drawing.Color.FromArgb(255, 255, 247),Color.White,Color.Black, new FontFamily("Arial"),12,Color.Gray);
        public static Theme BLACK_AND_WHITE=new Theme(Color.Black,Color.Black, System.Drawing.Color.FromArgb(255, 255, 247),Color.White,Color.Black,new FontFamily("Times New Roman"),12, System.Drawing.Color.FromArgb(65, 65, 65));

        public static Color SELECTED = System.Drawing.Color.FromArgb(235, 85, 20);
        public static Color NONSELECTED = System.Drawing.Color.FromArgb(255, 100, 20);

    }
}
