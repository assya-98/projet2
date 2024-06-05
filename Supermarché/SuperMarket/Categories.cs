using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Categories : Form
    {
        Functions Con;
        public Categories()
        {
            InitializeComponent();
            Con = new Functions();
            ListerCatgories();
        }

        private void ListerCatgories()
        {
            string Req = "Select * from CategorieTbl";
            CategoriesListe.DataSource = Con.RecupererDonnees(Req);
        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || RemTb.Text == "")
                {
                    MessageBox.Show("Completer Le Formulaire Svp !!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Rem = RemTb.Text;
                    string Req = "insert into CategorieTbl values ('{0}', '{1}')";
                    Req = String.Format(Req, Nom, Rem);
                    Con.EnvoyerDonnes(Req);
                    ListerCatgories();
                    MessageBox.Show("Categorie Ajoutée !!");
                    NomTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void CategoriesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = CategoriesListe.SelectedRows[0].Cells[1].Value.ToString();
            RemTb.Text = CategoriesListe.SelectedRows[0].Cells[2].Value.ToString();
            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriesListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || RemTb.Text == "")
                {
                    MessageBox.Show("Completer Le Formulaire Svp !!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Rem = RemTb.Text;
                    string Req = "update CategorieTbl set CatNom = '{0}', CatRem = '{1}' where CatCode = {2}";
                    Req = String.Format(Req, Nom, Rem, Key);
                    Con.EnvoyerDonnes(Req);
                    ListerCatgories();
                    MessageBox.Show("Categorie Modifiée !!");
                    NomTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || RemTb.Text == "")
                {
                    MessageBox.Show("Completer Le Formulaire Svp !!!");
                }
                else
                {
                    string Req = "delete from CategorieTbl where CatCode = {0}";
                    Req = String.Format(Req, Key);
                    Con.EnvoyerDonnes(Req);
                    ListerCatgories();
                    MessageBox.Show("Categorie Supprimée !!");
                    NomTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

       
    }
}
