using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DSummative
{
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen1 gs1 = new GameScreen1();
            f.Controls.Add(gs1);
            gs1.Location = new Point((f.Width - gs1.Width) / 2, (f.Height - gs1.Height) / 2);
            gs1.Focus();

        }
    }
}
