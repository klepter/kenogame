using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KenoGame.Controls
{
    public static class ButtonDraw
    {

        public static void DrawCircle(Button button)
        {
            button.Paint += Button_DrawCircle;
            button.Invalidate();
        }

        public static void EraseCircle(Button button)
        {
            button.Paint -= Button_DrawCircle;
            button.Invalidate();
        }

        public static void DrawOutline(Button button)
        {
            button.Tag = "outline";
            button.Paint += Button_DrawOutline;
            button.Invalidate();
        }

        public static void EraseOutline(Button button)
        {
            if (button.Tag != null && button.Tag.ToString() == "outline")
            {
                button.Tag = null;
                button.Paint -= Button_DrawOutline;
            }
            button.Invalidate();
        }

        private static void Button_DrawCircle(object sender, PaintEventArgs e)
        {
            var button = sender as Button;
            int diameter = Math.Min(button.Width, button.Height) / 2 + 5;
            int x = (button.Width - diameter) / 2;
            int y = (button.Height - diameter) / 2;

            using (SolidBrush brush = new SolidBrush(Color.Aqua))
            {
                e.Graphics.FillEllipse(brush, x, y, diameter, diameter);
            }
        }

        private static void Button_DrawOutline(object sender, PaintEventArgs e)
        {
            var button = sender as Button;
            int borderWidth = 3;
            int cornerRadius = 10;

            int x = borderWidth / 2;
            int y = borderWidth / 2;
            int width = button.Width - borderWidth;
            int height = button.Height - borderWidth;

            using (GraphicsPath path = RoundedRectangle(x, y, width, height, cornerRadius))
            using (Pen pen = new Pen(Color.Blue, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private static GraphicsPath RoundedRectangle(int x, int y, int width, int height, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(x, y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddLine(x + cornerRadius, y, x + width - cornerRadius * 2, y);
            path.AddArc(x + width - cornerRadius * 2, y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddLine(x + width, y + cornerRadius * 2, x + width, y + height - cornerRadius * 2);
            path.AddArc(x + width - cornerRadius * 2, y + height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddLine(x + width - cornerRadius * 2, y + height, x + cornerRadius * 2, y + height);
            path.AddArc(x, y + height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.AddLine(x, y + height - cornerRadius * 2, x, y + cornerRadius * 2);
            path.CloseFigure();

            return path;
        }
    }
}
