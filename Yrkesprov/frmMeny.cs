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
    public partial class frmMeny : Form
    {

        public static string matNamn; 
       
        public frmMeny()
        {
            InitializeComponent();
        }

        private void frmMeny_Activated(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=db_yrkesprov;Integrated Security=True"))
            {
                sqlcon.Open();
                SqlDataAdapter selectsda = new SqlDataAdapter("SELECT * FROM kostnad", sqlcon);
                DataTable resulttable = new DataTable();
                selectsda.Fill(resulttable);
                int lastrow = resulttable.Rows.Count - 1;
                DataRow dr = resulttable.Rows[lastrow];
                txtBurger.Text = dr["prisburger"].ToString();
                txtTaco.Text = dr["pristaco"].ToString();
                txtBurrito.Text = dr["prisburitto"].ToString();
                txtPotatis.Text = dr["prispotatis"].ToString();
                txtPizza.Text = dr["prispizza"].ToString();
                txtPaj.Text = dr["prispaj"].ToString();
                txtLask.Text = dr["prisläsk"].ToString();
                txtKaffe.Text = dr["priskaffe"].ToString();
                txtGlass.Text = dr["prisglass"].ToString();

            }
        }

        private void pbBurger_Click(object sender, EventArgs e)
        {
            matNamn = "Burger";
            string prisBurger = txtBurger.Text;

            frmOrder frmOrder = new frmOrder(matNamn, prisBurger);
            frmOrder.ShowDialog();

        }

        private void pbTaco_Click(object sender, EventArgs e)
        {
            matNamn = "Taco";
            string prisTaco = txtTaco.Text;
            frmOrder frmOrder = new frmOrder(matNamn, prisTaco);
            frmOrder.ShowDialog();
        }

        private void pbBurrito_Click(object sender, EventArgs e)
        {
            matNamn = "Burrito";
            string prisBurrito = txtBurrito.Text;
            frmOrder frmOrder = new frmOrder(matNamn, prisBurrito);
            frmOrder.ShowDialog();
        }

        private void pbPotatis_Click(object sender, EventArgs e)
        {
            matNamn = "Potatis";
            string prisPotatis = txtPotatis.Text;
            frmOrder frmOrder = new frmOrder(matNamn, prisPotatis);
            frmOrder.ShowDialog();
        }

        private void pbPizza_Click(object sender, EventArgs e)
        {
            matNamn = "Pizza";
            string prisPizza = txtPizza.Text;
            frmOrder frmOrder = new frmOrder(matNamn, prisPizza);
            frmOrder.ShowDialog();
        }

        private void pbPaj_Click(object sender, EventArgs e)
        {
            matNamn = "Paj";
            string prisPaj = txtPaj.Text;
            frmOrder frmOrder = new frmOrder(matNamn, prisPaj);
            frmOrder.ShowDialog();
        }

        private void pbLask_Click(object sender, EventArgs e)
        {
            matNamn = "Läsk";
            string prisLask = txtLask.Text;
            frmOrder frmOrder = new frmOrder(matNamn, prisLask);
            frmOrder.ShowDialog();
        }

        private void pbKaffe_Click(object sender, EventArgs e)
        {
            matNamn = "Kaffe";
            string prisKaffe = txtKaffe.Text;
            frmOrder frmOrder = new frmOrder(matNamn, prisKaffe);
            frmOrder.ShowDialog();
        }

        private void pbGlass_Click(object sender, EventArgs e)
        {
            matNamn = "Glass";
            string prisGlass = txtGlass.Text;
            frmOrder frmOrder = new frmOrder(matNamn, prisGlass);
            frmOrder.ShowDialog();
        }

       
    }
}
