using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Articles : Form
    {
        Functions Con;
        public Articles()
        {
            InitializeComponent();
            Con = new Functions();
            ListerArticles();
            RemplirCategories();
        }

        private void ListerArticles()
        {
            string Req = "Select * from ArticlesTbl";
            ArticlesListe.DataSource = Con.RecupererDonnees(Req);
        }

        private void Filtrage()
        {
            string Req = "select * from ArticlesTbl where ArtCat = {0}";
            int Cat = Convert.ToInt32(FiltrerCb.SelectedValue.ToString());
            Req = String.Format(Req, Cat);
            ArticlesListe.DataSource = Con.RecupererDonnees(Req);

        }

        private void RemplirCategories() { 
            CatCb.DisplayMember = Con.RecupererDonnees(Req).Columns["CatNom"].ToString();
            CatCb.ValueMember = Con.RecupererDonnees(Req).Columns["Catcode"].ToString();
            CatCb.DataSource = Con.RecupererDonnees(Req);
            FiltrerCb.DisplayMember = Con.RecupererDonnees(Req).Columns["CatNom"].ToString();
            FiltrerCb.ValueMember = Con.RecupererDonnees(Req).Columns["Catcode"].ToString();
            FiltrerCb.DataSource = Con.RecupererDonnees(Req);
        }
        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PrixTb.Text == ""|| CatCb.SelectedIndex == -1 || StockTb.Text == "")
                {
                    MessageBox.Show("Completer Le Formulaire Svp !!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);
                    int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());

                    int Stock = Convert.ToInt32(StockTb.Text);
                    string ExpDate = ExpTb.Value.Date.ToString(); 
                    string Req = "insert into ArticlesTbl values ('{0}', '{1},{2},{3},'{4}'')";
                    Req = String.Format(Req, Nom, Prix, Categorie, Stock, ExpDate);
                    Con.EnvoyerDonnes(Req);
                    ListerArticles();
                    MessageBox.Show("Article Ajoutée !!");
                    NomTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";
                    CatCb.SelectedIndex = -1;


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void ArticlesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = ArticlesListe.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = ArticlesListe.SelectedRows[0].Cells[2].Value.ToString();
            CatCb.Text = ArticlesListe.SelectedRows[0].Cells[3].Value.ToString();
            StockTb.Text = ArticlesListe.SelectedRows[0].Cells[4].Value.ToString();
            //tockTb.Text = ArticlesListe.SelectedRows[0].Cells[4].Value.ToString();
            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ArticlesListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (Key == 0)
                    {
                        MessageBox.Show("Selectuonnez un article Svp !!!");
                    }
                    else
                    {
                        string Nom = NomTb.Text;
                        int Prix = Convert.ToInt32(PrixTb.Text);
                        int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());

                        int Stock = Convert.ToInt32(StockTb.Text);
                        string ExpDate = ExpTb.Value.Date.ToString();
                        string Req = "Update ArticlesTbl set ArtNom = '{0}',ArtPrix = {1}, ArtCat = {2}, ArtStock ={3}, ArtExpDate = '{4}' where ArtCode = {5}";
                        Req = String.Format(Req, Nom, Prix, Categorie, Stock, ExpDate, Key);
                        Con.EnvoyerDonnes(Req);
                        ListerArticles();
                        MessageBox.Show("Article Modifié !!");
                        NomTb.Text = "";
                        PrixTb.Text = "";
                        StockTb.Text = "";
                        CatCb.SelectedIndex = -1;


                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void SuprimerBtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (Key == 0)
                    {
                        MessageBox.Show("Selectuonnez un article Svp !!!");
                    }
                    else
                    {
                        string Nom = NomTb.Text;
                        int Prix = Convert.ToInt32(PrixTb.Text);
                        int Categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());

                        int Stock = Convert.ToInt32(StockTb.Text);
                        string ExpDate = ExpTb.Value.Date.ToString();
                        string Req = "delete from ArticlesTbl where ArtCode = {0}";
                        Req = String.Format(Req, Key);
                        Con.EnvoyerDonnes(Req);
                        ListerArticles();
                        MessageBox.Show("Article Supprimé !!");
                        NomTb.Text = "";
                        PrixTb.Text = "";
                        StockTb.Text = "";
                        CatCb.SelectedIndex = -1;


                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void FiltrerCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrage();
        }

        private void ActualiserBtn_Click(object sender, EventArgs e)
        {
            ListerArticles();
        }

        private void Articles_Load(object sender, EventArgs e)
        {

        }
    }
}
