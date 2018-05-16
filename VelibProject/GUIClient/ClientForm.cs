using GUIClient.IWSReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIClient
{
    public partial class ClientForm : Form
    {
        static IWSReference.IWSClient client = new IWSReference.IWSClient();

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void Send_request(object sender, EventArgs e)
        {
            Station res = client.GetStation("Toulouse", "00189");
            bikes_nb_text_box.Text = "Bikes available : " + res.Available_bikes;
        }
    }
}
