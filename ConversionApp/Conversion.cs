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
        // Message globale pour indiquer que l'on a rien saisi
        const string emptyStringMessage = "Error : la zone de texte ets vide";

        // Message globale pour indiquer que ce qu'on a saisi n'est pas bon
        const string nonNumberMessage = "Error : vous avez entré des caractères qui ne sont pas numériques !";

        public Conversion()
        {
            // Initialisation des différents composants de l'application
            InitializeComponent();
        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            // Chargement de l'image au demarage de l'application
            // L'image se trouve dans le dossier bin/debug (à ne pas supprimer)
            BillsPicture.Load("image.jpg");
        }

        private void FrancsToEuros_btn_Click(object sender, EventArgs e)
        {
            // Prise en charge de texte dans le textBox de champs euros, et remplacement des virgules en points, afin de pouvoir le convertir
            var deviseEuro = EuroText.Text.Replace(",", ".");

            // Si l'utilisateur commence la conversion sans mettre un montant dans le champs pour la devise euro on aura un message d'erreur 
            // Pour demander la saisie d'un mantant
            if (string.IsNullOrEmpty(deviseEuro))
            {
                MessageBox.Show(emptyStringMessage, "", MessageBoxButtons.OK);
            }
            else 
            {
                // Si l'utilisateur saisi un montant qui ne correspond pas à des chiffres (des lettres, caractères speciaux ...) on aura un message d'erreur 
                // Pour demander la saisie d'un mantant qui comporte que des chiffres et un virgule.
                if (!float.TryParse(deviseEuro, out var number))
                {
                    MessageBox.Show(nonNumberMessage, "", MessageBoxButtons.OK);
                }
                else 
                {
                    // Si l'utilisateur saisi un montant qui est bon 
                    // On converti le monatant en float pour pouvoir faire des opération arithmétiques.
                    var deviseFranc = float.Parse(deviseEuro);    

                    // On cherche le montant en francs de ce qu'on a saisi en euros (Taux : 6.559)
                    // on arrondi le resultat en 2 chiffres aprés la virgule en remplaçant le point en virgule pour que ça soit pluis cohérent.
                    FrancText.Text = Math.Round(deviseFranc * 6.559, 2).ToString().Replace(".", ",");

                    // Ajout de l'opération dans la listBox pour garder une trace de la conversion. 
                    ConversionHistory.Items.Add($"Conversion de Euros->Francs:");
                    ConversionHistory.Items.Add($"{deviseEuro} € -> {FrancText.Text} Fr");
                    ConversionHistory.Items.Add("\n");
                }                
            }
        }

        private void Effacer_btn_Click(object sender, EventArgs e)
        {
            // Reinitialisation de l'historique sur les traces des conversions. 
            ConversionHistory.Items.Clear();
        }

        private void EurosToFrancs_btn_Click(object sender, EventArgs e)
        {
            // Prise en charge de texte dans le textBox de champs francs, et remplacement des virgules en points, afin de pouvoir le convertir
            var deviseFranc = FrancText.Text.Replace(",", ".");


            // Si l'utilisateur commence la conversion sans mettre un montant dans le champs pour la devise francs on aura un message d'erreur 
            // Pour demander la saisie d'un mantant
            if (string.IsNullOrEmpty(deviseFranc))
            {
                MessageBox.Show(emptyStringMessage, "", MessageBoxButtons.OK);
            }
            else
            {
                // Si l'utilisateur saisi un montant qui ne correspond pas à des chiffres (des lettres, caractères speciaux ...) on aura un message d'erreur 
                // Pour demander la saisie d'un mantant qui comporte que des chiffres et un virgule.
                if (!float.TryParse(deviseFranc, out var number))
                {
                    MessageBox.Show(nonNumberMessage, "", MessageBoxButtons.OK);
                }
                else
                {
                    // Si l'utilisateur saisi un montant qui est bon 
                    // On converti le monatant en float pour pouvoir faire des opération arithmétiques.
                    var deviseEuro = float.Parse(deviseFranc);

                    // On cherche le montant en euro de ce qu'on a saisi en francs (Taux : 6.559)
                    // On arrondi le resultat en 2 chiffres aprés la virgule en remplaçant le point en virgule pour que ça soit pluis cohérent.
                    EuroText.Text = Math.Round(deviseEuro / 6.559, 2).ToString().Replace(".", ",");

                    // Ajout de l'opération dans la listBox pour garder une trace de la conversion.
                    ConversionHistory.Items.Add($"Conversion de Francs->Euros:");
                    ConversionHistory.Items.Add($"{deviseFranc} Fr -> {EuroText.Text} €");
                    ConversionHistory.Items.Add("\n");
                }
            }
        }
    }
}
