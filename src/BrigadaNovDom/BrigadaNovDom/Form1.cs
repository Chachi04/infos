using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrigadaNovDom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double price=0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FloorType.SelectedIndex)
            {
                case 0:
                    Kartina.Image = Properties.Resources.African_oak_ExquisitTrend_523_813;
                    this.price = 196;
                    break;
                case 1:
                    Kartina.Image = Properties.Resources.African_oak_Tundra_524_446;
                    this.price = 196;
                    break;
                case 2:
                    Kartina.Image = Properties.Resources.Merbau_525_190;
                    this.price = 170;
                    break;
                case 3:
                    Kartina.Image = Properties.Resources.Buche_gedaempft_Universal_Interieur_534_590_1;
                    this.price = 122;
                    break;
                case 4:
                    Kartina.Image = Properties.Resources.ASH_Trend_524_642;
                    this.price = 158;
                    break;
                default:
                    break;
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double p = double.Parse(Loss.Text) / 100;
            double x = double.Parse(X.Text);
            double y = double.Parse(Y.Text);
            FinalPrice.Text = $"Крайна цена: {x * y * (1 + p) * this.price}";
        }
    }
}
