using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
namespace Simulacion_U3
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }
        int A;
        int B;
        int N;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(txtN.Text);
            A = Convert.ToInt32(TxtA.Text);
            B = Convert.ToInt32(TxtB.Text);
            if (B<A)
            {
                errorProvider1.SetError(TxtB, "B tiene que ser mayor que A");
            }
            else
            {
                errorProvider1.SetError(TxtB, null);
               tablaUniforme.Rows.Clear();
                tablaUniforme.Rows.Add(N);
                for (int i = 0; i < N; i++)
                {
                    tablaUniforme[0, i].Value = i + 1;
                    tablaUniforme[1, i].Value = 0;
                    tablaUniforme[2, i].Value = 0;
                }

            }
        }

        private void tablaUniforme_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void tablaUniforme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {             
        }

        private void tablaUniforme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaUniforme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < (N); i++)
                {
                    double Ri = Convert.ToDouble(tablaUniforme[1, i].Value);
                    tablaUniforme[2, i].Value = (A + (B - A) * Ri);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtN.Text))
            {
                e.Cancel = true;            
                errorProvider1.SetError(txtN, "Ingresa un numero Entero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtN, null);
            }
        }

        private void TxtA_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtA.Text))
            {
                e.Cancel = true;              
                errorProvider1.SetError(TxtA, "Ingresa un numero Entero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtA, null);
            }
        }

        private void TxtB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtB, "Ingresa un numero Entero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtB, null);
            }
        }
    }
}
