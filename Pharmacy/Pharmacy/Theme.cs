using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pharmacy
{
   public class Theme
    {
        public Color menuColor;
        public Color headerFooterColor;
        public Color backColor;
        public Color foreColorMain;
        public Color foreColorText;
        public FontFamily font;
        public Color selectedButtonColor;
        public float fontSize;

        public Theme()
        {

        }
        public Theme(Color menuColor, Color headerFooterColor, Color backColor, Color foreColorMain, Color foreColorText,FontFamily font,float fontSize,Color selectedButtonColor)
        {
            this.menuColor = menuColor;
            this.headerFooterColor = headerFooterColor;
            this.backColor = backColor;
            this.foreColorMain = foreColorMain;
            this.foreColorText = foreColorText;
            this.font = font;
            this.fontSize = fontSize;
            this.selectedButtonColor = selectedButtonColor;
        }

        
        public override bool Equals(object obj)
        {
            return obj is Theme theme &&
                   EqualityComparer<Color>.Default.Equals(menuColor, theme.menuColor) &&
                   EqualityComparer<Color>.Default.Equals(headerFooterColor, theme.headerFooterColor) &&
                   EqualityComparer<Color>.Default.Equals(backColor, theme.backColor) &&
                   EqualityComparer<Color>.Default.Equals(foreColorMain, theme.foreColorMain) &&
                   EqualityComparer<Color>.Default.Equals(foreColorText, theme.foreColorText) &&
                   EqualityComparer<FontFamily>.Default.Equals(font, theme.font) &&
                   EqualityComparer<float>.Default.Equals(fontSize, theme.fontSize) &&
                   EqualityComparer<Color>.Default.Equals(selectedButtonColor, theme.selectedButtonColor);
        }
    }
}
