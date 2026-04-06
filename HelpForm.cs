using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExtractorGui;

public class HelpForm : Form
{
    private readonly TextBox tbHelp;

    public HelpForm(Dictionary<string, string> text)
    {
        Text = text["HelpTitle"];
        ClientSize = new Size(640, 420);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent;

        tbHelp = new TextBox
        {
            Multiline = true,
            ReadOnly = true,
            ScrollBars = ScrollBars.Vertical,
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 10),
            Text = text["UsageText"],
        };

        Controls.Add(tbHelp);
    }
}
