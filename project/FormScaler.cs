using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{

    public class FormScaler
    {
        private readonly Form form;

        private Size originalFormSize; //width1200 , height 700

        private class ControlData //controling primary Data
        {
            public Rectangle Bounds;
            public float FontSize;
        }

        private readonly Dictionary<Control, ControlData> controls = new();//For each Control Saves Data

        public FormScaler(Form form)
        {
            this.form = form;

            form.Load += Form_Load;
            form.Resize += Form_Resize;
        }

        private void Form_Load(object? sender, EventArgs e)
        {
            originalFormSize = form.ClientSize; //Saves base Form Size

            SaveControls(form); //Saves All Controls
        }

        private void SaveControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                controls[c] = new ControlData()
                {
                    Bounds = c.Bounds,
                    FontSize = c.Font.Size
                };

                if (c.Controls.Count > 0)//if the control has itself other controls
                    SaveControls(c);
            }
        }

        private void Form_Resize(object? sender, EventArgs e)
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float scaleX = (float)form.ClientSize.Width / originalFormSize.Width;
            float scaleY = (float)form.ClientSize.Height / originalFormSize.Height;

            ResizeControls(form, scaleX, scaleY);
        }

        private void ResizeControls(Control parent, float scaleX, float scaleY)
        {
            foreach (Control c in parent.Controls)
            {
                ControlData data = controls[c];

                c.Left = (int)(data.Bounds.Left * scaleX);
                c.Top = (int)(data.Bounds.Top * scaleY);

                c.Width = (int)(data.Bounds.Width * scaleX);
                c.Height = (int)(data.Bounds.Height * scaleY);

                c.Font = new Font(
                    c.Font.FontFamily,
                    data.FontSize * Math.Min(scaleX, scaleY),
                    c.Font.Style);

                if (c.Controls.Count > 0)
                    ResizeControls(c, scaleX, scaleY);
            }
        }
    }
}