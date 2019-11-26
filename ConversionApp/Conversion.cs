using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        const string emptyStringMessage = "Error : la zone de texte ets vide";
        const string nonNumberMessage = "Error : vous avez entré des caractères qui ne sont pas numériques !";


        private void Conversion_Load(object sender, EventArgs e)
        {
            BillsPicture.Load("image.jpg");
        }

        private void FrancsToEuros_btn_Click(object sender, EventArgs e)
        {
            var deviseEuro = EuroText.Text.Replace(",", ".");
            if (string.IsNullOrEmpty(deviseEuro))
            {
                MessageBox.Show(emptyStringMessage, "", MessageBoxButtons.OK);
            }
            else 
            {
                if (!float.TryParse(deviseEuro, out var number))
                {
                    MessageBox.Show(nonNumberMessage, "", MessageBoxButtons.OK);
                }
                else 
                {
                    var deviseFranc = float.Parse(deviseEuro);                   
                    FrancText.Text = Math.Round(deviseFranc * 6.559, 2).ToString().Replace(".", ",");
                    ConversionHistory.Items.Add($"Conversion de Euros->Francs:");
                    ConversionHistory.Items.Add($"{deviseEuro} € -> {FrancText.Text} Fr");
                    ConversionHistory.Items.Add("\n");
                }                
            }
        }

        private void Effacer_btn_Click(object sender, EventArgs e)
        {
            ConversionHistory.Items.Clear();
        }

        private void EurosToFrancs_btn_Click(object sender, EventArgs e)
        {
            var deviseFranc = FrancText.Text.Replace(",", ".");
            if (string.IsNullOrEmpty(deviseFranc))
            {
                MessageBox.Show(emptyStringMessage, "", MessageBoxButtons.OK);
            }
            else
            {
                if (!float.TryParse(deviseFranc, out var number))
                {
                    MessageBox.Show(nonNumberMessage, "", MessageBoxButtons.OK);
                }
                else
                {
                    var deviseEuro = float.Parse(deviseFranc);
                    EuroText.Text = Math.Round(deviseEuro / 6.559, 2).ToString().Replace(".", ",");
                    ConversionHistory.Items.Add($"Conversion de Francs->Euros:");
                    ConversionHistory.Items.Add($"{deviseFranc} Fr -> {EuroText.Text} €");
                    ConversionHistory.Items.Add("\n");
                }
            }
        }
    }
}
