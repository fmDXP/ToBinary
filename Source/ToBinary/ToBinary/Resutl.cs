using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToBinary
{
    public partial class Resutl : Form
    {
        public Resutl()
        {
            InitializeComponent();
        }

        public void UpdateLabels(string binary, string hex)
        {
            label1.Text = $"Binary: {binary}";
            label2.Text = $"Hex: 0x{hex}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText($"{label1.Text}\n{label2.Text}");
        }
    }
}
