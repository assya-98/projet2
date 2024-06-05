using System;
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
    public partial class Vendeurs : Form
    {

        Functions Con; 
        public Vendeurs()
        {
            InitializeComponent();
            Con = new Functions();
            ListerVendeurs();
        }

        // private Vendeurs_Load (object sender, EventArgs e)

        private void ListerVendeurs(object sender, EventArgs e)
        {
            
                string Req = "Select * from VendeursTbl";
                VendeursListe.DataSource = Con.RecupererDonnees(Req);
         

        }
