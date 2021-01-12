using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace NoteAppUI
{
    public class RoundPictureBox : PictureBox
    {
        /// <summary>
        /// Создание круглого PictureBox.
        /// </summary>
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grpath);
            base.OnPaint(pe);
        }
    }
}
