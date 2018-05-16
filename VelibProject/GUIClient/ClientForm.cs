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
            List<City> cities = new List<City>(client.GetCitiesName());
            foreach(City c in cities)
            {
                cityComboBox.Items.Add(c.Name);
            }
        }

        private void Send_request(object sender, EventArgs e)
        {
            Station res = client.GetStation(cityComboBox.Text, stationComboBox.Text);
            bikes_nb_text_box.Text = "Bikes available : " + res.Available_bikes;
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stationComboBox.Items.Clear();
            List<Station> stations = new List<Station>(client.GetStations(cityComboBox.Text));
            foreach (Station s in stations)
            {
                stationComboBox.Items.Add(s.Name);
            }
        }
    }
}
