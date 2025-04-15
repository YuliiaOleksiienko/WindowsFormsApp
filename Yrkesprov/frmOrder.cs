using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yrkesprov
{
    public partial class frmOrder : Form
    {

        public static double kassa;
        private string matNamn;
        private string pris;
       






        public frmOrder(string matNamn, string pris)
        {
            InitializeComponent();
            this.matNamn = matNamn;
            this.pris = pris;
            lblMatNamn.Text = matNamn;
            txtPris.Text = pris;

        }

        private void frmOrder_Activated(object sender, EventArgs e)
        {
            lblMatNamn.Text = frmMeny.matNamn;



            string antal = cmbAntal.Text;
           

        }


        private void btnMeny_Click(object sender, EventArgs e)
        {
            frmMeny frmMeny = new frmMeny();
            frmMeny.ShowDialog();
        }

        private void cmbAntal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPris.Text, out double pris) && int.TryParse(cmbAntal.Text, out int antal))
            {

                double summa = pris * antal;
                txtSumma.Text = summa.ToString("F2");
                kassa += summa;
                kassa = Math.Round(kassa, 1);


            }
        }

        private void btnKopa_Click(object sender, EventArgs e)
        {
            txtHelaBeloppet.Text = kassa.ToString("F2");

            if (!string.IsNullOrEmpty(matNamn) && double.TryParse(txtPris.Text, out double pris) &&int.TryParse(cmbAntal.Text, out int antal) &&double.TryParse(txtSumma.Text, out double summa))
            {
                using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=db_yrkesprov;Integrated Security=True"))
                {
                    sqlcon.Open();

                    SqlCommand sqLinsert = new SqlCommand("INSERT INTO valet (mat, antal, pris, summa, total) VALUES (@mat, @antal, @pris, @summa, @kassa)", sqlcon);

                    sqLinsert.Parameters.Add("@mat", SqlDbType.NVarChar).Value = matNamn;
                    sqLinsert.Parameters.Add("@antal", SqlDbType.Float).Value = antal;
                    sqLinsert.Parameters.Add("@pris", SqlDbType.Float).Value = pris;
                    sqLinsert.Parameters.Add("@summa", SqlDbType.Float).Value = summa;
                    sqLinsert.Parameters.Add("@kassa", SqlDbType.Float).Value = kassa;
                    sqLinsert.ExecuteNonQuery();


                }

                
                
            }
            
        }

        private void btnBestalla_Click(object sender, EventArgs e)
        {
            frmOrderCompletion frmOrderCompletion = new frmOrderCompletion();
            frmOrderCompletion.ShowDialog();
        }

        
    }
}



       
