using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Yrkesprov
{
    public partial class frmOrderCompletion : Form
    {

        int id = 0;


        public frmOrderCompletion()
        {
            InitializeComponent();
            prdKvittto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prdKvittto_PrintPage);

        }


        private void updatedata()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=db_yrkesprov;Integrated Security=True"))
                {
                    SqlDataAdapter sdaSelect = new SqlDataAdapter("SELECT nummer, mat, antal, pris, summa FROM valet", sqlcon);
                    DataTable dtBestallning = new DataTable();
                    sdaSelect.Fill(dtBestallning);
                    dgvBestallning.DataSource = dtBestallning;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade vid uppdatering av data: {ex.Message}");
            }

            CalculateTotal();

        }

        private void CalculateTotal()
        {
            double totalAmount = 0;

            foreach (DataGridViewRow row in dgvBestallning.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    totalAmount += Convert.ToDouble(row.Cells[4].Value);
                }
            }

            txtTotal.Text = totalAmount.ToString("C", CultureInfo.CreateSpecificCulture("fi-FI"));
        }


        private void frmOrderCompletion_Activated(object sender, EventArgs e)
        {
           
            updatedata();
        }

        

        private void frmOrderCompletion_Load(object sender, EventArgs e)
        {
            updatedata();
        }

        private void dgvBestallning_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgvBestallning.Rows[e.RowIndex].Cells[0].Value);

            string matNamn = dgvBestallning.Rows[e.RowIndex].Cells[1].Value.ToString();
            string antal = dgvBestallning.Rows[e.RowIndex].Cells[2].Value.ToString();
            string pris = dgvBestallning.Rows[e.RowIndex].Cells[3].Value.ToString();
            string summa = dgvBestallning.Rows[e.RowIndex].Cells[4].Value.ToString();
            

        }

        private void btnRadera_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=db_yrkesprov;Integrated Security=True"))
                {
                    sqlcon.Open();
                    SqlCommand sqldelete = new SqlCommand("DELETE FROM valet WHERE nummer=@num", sqlcon);
                    sqldelete.Parameters.AddWithValue("num", id);
                    sqldelete.ExecuteNonQuery();

                    updatedata();

                    SqlCommand updateTotalCmd = new SqlCommand("UPDATE valet SET total = (SELECT SUM(summa) FROM valet)", sqlcon);
                    updateTotalCmd.ExecuteNonQuery();
                }
                
            }
            else
            {
                MessageBox.Show("Vänligen välj måltid som ska raderas!");
            }
            updatedata();
         
        }

        

        private bool bekraftaBestallning = false;

        private void btnBekrafta_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBestallning.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string matNamn = row.Cells[1].Value.ToString();
                    int antal = Convert.ToInt32(row.Cells[2].Value);
                    double pris = Convert.ToDouble(row.Cells[3].Value);
                    double summa = Convert.ToDouble(row.Cells[4].Value);
                    

                    using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=db_yrkesprov;Integrated Security=True"))
                    {
                        sqlcon.Open();
                        string insertQuery = "INSERT INTO sold (mat, antal, pris, summa) VALUES (@mat, @antal, @pris, @summa)";
                        SqlCommand cmd = new SqlCommand(insertQuery, sqlcon);

                        cmd.Parameters.AddWithValue("@mat", matNamn);
                        cmd.Parameters.AddWithValue("@antal", antal);
                        cmd.Parameters.AddWithValue("@pris", pris);
                        cmd.Parameters.AddWithValue("@summa", summa);
                        

                        
                        cmd.ExecuteNonQuery();

                    }
                    
                }

            }

            if (!bekraftaBestallning)
            {
                MessageBox.Show("Tack för din beställning!");
                bekraftaBestallning = true;
                
            }
            updatedata();

        }
    
        

        private void prdKvittto_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPosition = 20;
            int lineHeight = 30;
            Font fontHeader = new Font("Arial", 20, FontStyle.Bold);
            Font fontDetails = new Font("Arial", 16, FontStyle.Regular);
            Brush brush = Brushes.Black;

            
            e.Graphics.DrawString("Kvitto", fontHeader, Brushes.Blue, 20, yPosition);
            yPosition += lineHeight + 10;

            double totalAmount = 0;

            foreach (DataGridViewRow row in dgvBestallning.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string matNamn = row.Cells[1].Value.ToString();
                    int antal = Convert.ToInt32(row.Cells[2].Value);
                    double pris = Convert.ToDouble(row.Cells[3].Value);
                    double summa = Convert.ToDouble(row.Cells[4].Value);

                    totalAmount += summa;
                    

                    string line = $"{matNamn} - {antal} x {pris.ToString("C", CultureInfo.CreateSpecificCulture("fi-FI"))} = {summa.ToString("C", CultureInfo.CreateSpecificCulture("fi-FI"))}";
                    e.Graphics.DrawString(line, fontDetails, brush, 20, yPosition);
                    yPosition += lineHeight;
                }
            }

          

            yPosition += 10;
            e.Graphics.DrawString($"Total: {totalAmount.ToString("C", CultureInfo.CreateSpecificCulture("fi-FI"))}", fontDetails, brush, 20, yPosition);
            yPosition += lineHeight;

           
            e.Graphics.DrawString(DateTime.Now.ToString("d.M.yyyy HH:mm:ss"), fontDetails, brush, 20, yPosition);
         
        }


        private void btnKvitto_Click(object sender, EventArgs e)
        {
            DataTable dtForReceipt = new DataTable();
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=db_yrkesprov;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter sdaSelect = new SqlDataAdapter("SELECT * FROM valet", sqlcon);
                sdaSelect.Fill(dtForReceipt);
               

                if (dgvBestallning.Rows.Count > 0)
                {
                    prdKvittto.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Kvitto", 400, 600);
                    ppdKvittto.Document = prdKvittto;
                    
                    



                    if (ppdKvittto.ShowDialog() == DialogResult.OK)
                     {


                         DeleteDataFromValet();
                     }
                }
                else
                {
                    MessageBox.Show("Ingen information för kvitto", "Misstag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
       

        private void DeleteDataFromValet()
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=db_yrkesprov;Integrated Security=True"))
            {
                sqlcon.Open();
                string deleteQuery = "DELETE FROM valet";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlcon);
                deleteCmd.ExecuteNonQuery();
            }

            updatedata();

        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Din beställning har behandlats!");
            DeleteDataFromValet();
            Application.Exit();
        }

      
    }
} 


        

