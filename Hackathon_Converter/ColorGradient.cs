using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hackathon_Converter
{
    class ColorGradient : Panel
    {
        public Color ColorTopRight { get; set; }
        public Color ColorBottomLeft { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorBottomLeft, this.ColorTopRight, -29F );
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
