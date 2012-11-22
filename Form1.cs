using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Haspaid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;

            WebClient client = new WebClient();
            string answer = client.DownloadString("https://minecraft.net/haspaid.jsp?user=" + username);

            if (answer == "true")
            {
                lansw.Text = username + " is a paid user";
            }
            else
            {
                lansw.Text = username + " is not a paid user";
            }
        }
    }
}
