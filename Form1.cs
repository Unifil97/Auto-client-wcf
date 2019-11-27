using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Autoclient
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client registerHandler = new ServiceReference1.Service1Client();
        ServiceReference1.Auto nyky = new ServiceReference1.Auto();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbmerkki.ValueMember = "ID";
            cbmerkki.DisplayMember = "Merkkinimi";
            cbmerkki.DataSource = registerHandler.getAllAutoMakers();

        }
        private void LisaaMallit(object sender, EventArgs e)
        {
            try
            {
                if (cbmerkki.SelectedValue is int)
                {
                    int MerkkiId = (int)cbmerkki.SelectedValue;
                    var mallit = registerHandler.getAutoModels(MerkkiId);
                    cbmalli.DataSource = mallit;
                    cbmalli.ValueMember = "ID";
                    cbmalli.DisplayMember = "Mallinimi";

                    cbpolttoaine.DataSource = registerHandler.GetFuel();
                    cbpolttoaine.ValueMember = "Id";
                    cbpolttoaine.DisplayMember = "Polttoaineennimi";

                    cbvari.DataSource = registerHandler.GetColor();
                    cbvari.ValueMember = "Id";
                    cbvari.DisplayMember = "Varinnimi";


                }

            }
            catch
            {

            }
        }
    private void bttallenna_Click(object sender, EventArgs e)
        {
            ServiceReference1.Auto biili = new ServiceReference1.Auto();

            biili.AutonMerkkiID1 = (int)cbmerkki.SelectedValue;
            biili.AutonMalliID1 = (int)cbmalli.SelectedValue;
            biili.PolttoaineID1 = (int)cbpolttoaine.SelectedValue;
            biili.VaritID1 = (int)cbvari.SelectedValue;
            biili.Mittarilukema1 = int.Parse(tbmittarilukema.Text);
            biili.Moottorin_tilavuus1 = decimal.Parse(tbtilavuus.Text);
            biili.Hinta1 = decimal.Parse(tbhinta.Text);
            biili.Rekisteri_paivamaara1 = Dtp.Value;

            registerHandler.saveAuto(biili);
        }
        private void tulosta(ServiceReference1.Auto uusi)
        {
            cbmerkki.SelectedValue = uusi.AutonMerkkiID1;
            cbmalli.SelectedValue = uusi.AutonMalliID1;
            cbpolttoaine.SelectedValue = uusi.PolttoaineID1;
            cbvari.SelectedValue = uusi.VaritID1;
            tbmittarilukema.Text = uusi.Mittarilukema1.ToString();
            tbhinta.Text = uusi.Hinta1.ToString();
            Dtp.Text = uusi.Rekisteri_paivamaara1.ToString();
            tbtilavuus.Text = uusi.Moottorin_tilavuus1.ToString();
        }

        private void lbVari_Click(object sender, EventArgs e)
        {

        }

        private void lbPolttoaine_Click(object sender, EventArgs e)
        {

        }

        private void cbvari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbpolttoaine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btseuraava_Click(object sender, EventArgs e)
        {
            nyky = registerHandler.seurcar(nyky.ID1);
            tulosta(nyky);
        }

        private void btedellinen_Click(object sender, EventArgs e)
        {
            nyky = registerHandler.edellcar(nyky.ID1);
            tulosta(nyky);
        }

        private void btpoista_Click(object sender, EventArgs e)
        {

        }
        void ClearBoxes(Control control)
        {

            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }

                else
                {
                    ClearBoxes(c);
                }
            }

        }



        private void btuusitietue_Click(object sender, EventArgs e)
        {
            ClearBoxes(this);
        }

        private void cbmalli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbhinta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtilavuus_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbmittarilukema_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
