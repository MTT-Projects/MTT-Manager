using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTT_Manager
{
    public partial class InfoBox : Form
    {
        public InfoBox()
        {
            InitializeComponent();
        }

        public static InfoBox ShowMessage(string message = "Default Message", string title = "Default", MessageBoxIcon icon = MessageBoxIcon.None)
        {
            var mainForm = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.Visible);
            mainForm.Enabled = false; // Deshabilitar el formulario principal

            var form = new InfoBox
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterScreen,
                Text = title,
                AutoSize = true
            };

            var panel = new TableLayoutPanel
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            var iconPictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Image = GetIconImage(icon),
                Margin = new Padding(0, 0, 20, 0)
            };

            var messageLabel = new Label
            {
                Text = message,
                AutoSize = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panel.Controls.Add(iconPictureBox, 0, 0);
            panel.Controls.Add(messageLabel, 1, 0);

            form.Controls.Add(panel);

            form.FormClosed += (sender, e) =>
            {
                mainForm.Enabled = true; // Habilitar el formulario principal cuando se cierre el cuadro de mensaje
            };

            form.UpdateBounds();
            form.Show();

            return form;
        }


        private static Image GetIconImage(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error:
                    return SystemIcons.Error.ToBitmap();
                case MessageBoxIcon.Warning:
                    return SystemIcons.Warning.ToBitmap();
                case MessageBoxIcon.Information:
                    return SystemIcons.Information.ToBitmap();
                case MessageBoxIcon.Question:
                    return SystemIcons.Question.ToBitmap();
                default:
                    return null;
            }
        }
    }
}
