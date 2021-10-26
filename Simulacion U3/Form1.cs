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
using MathNet.Numerics;

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
        //Variables Publicas
        int A;
        int B;
        int N;
        double Lamda;// λ
        private void materialButton1_Click(object sender, EventArgs e)//boton de Va Uniforme
        {
            N = Convert.ToInt32(txtN.Text);
            A = Convert.ToInt32(TxtA.Text);
            B = Convert.ToInt32(TxtB.Text);
            if (B<A|txtN.Text==""|TxtA.Text==""|TxtB.Text=="")
            {
                if (B < A)
                {
                    errorProvider1.SetError(TxtB, "B tiene que ser mayor que A!");
                }
                if (txtN.Text == "")
                {
                    errorProvider1.SetError(txtN, "Este campo esta vacio!");
                }
                if (TxtA.Text=="")
                {
                    errorProvider1.SetError(TxtA, "Este Campo esta Vacio!");
                }
                if (TxtB.Text=="")
                {
                    errorProvider1.SetError(TxtB, "Este Campo esta Vacio!");
                }
            }
            else
            {
                InfoProvider.SetError(btnUniformeOk, "Llene las Celdas de Ri para Obtener Resultados");
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
        private void tablaUniforme_CellClick(object sender, DataGridViewCellEventArgs e)//Evento de seleccionar y calcula las celdas de Va Uniforme
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
        }//Valida TxtN de va Uniforme
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
        }//Valida txtA de Va Uniforme
        private void TxtB_Validating(object sender, CancelEventArgs e)//Valida txtB de Va Uniforme
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
        private void btnOk_Click(object sender, EventArgs e)//Boton Ok de Va Exponencial
        {
            if (txtExp1.Text=="" | txtExpN.Text=="")
            {
                if (txtExp1.Text == "")
                {
                    errorProvider1.SetError(txtExp1, "Este Campo Esta Vacio");
                }
                if (txtExpN.Text == "")
                {
                    errorProvider1.SetError(txtExpN, "Este Campo Esta Vacio");
                }
            }
            else
            {


                InfoProvider.SetError(btnOk, "LLene las celda Ri para obtener su resultado!");
                N = Convert.ToInt32(txtExpN.Text);
                Lamda = Convert.ToDouble(txtExp1.Text);

                TbExponencial.Rows.Clear();//Limpia Rows de tabla
                TbExponencial.Rows.Add(N); //crear Rows de tabla
                for (int i = 0; i < N; i++)//llena rows de tabla
                {
                    TbExponencial[0, i].Value = i + 1;
                    TbExponencial[1, i].Value = 0;
                    TbExponencial[2, i].Value = 0;
                }
            }
        }

        private void TbExponencial_CellClick(object sender, DataGridViewCellEventArgs e)//evento de seleccionar y calcular Ri de Va Exponencial
        {
            double formula;
            double MediaExp=0;
            try
            {
                
                for (int i = 0; i < (N); i++)
                {
                    double Ri = Convert.ToDouble(TbExponencial[1, i].Value);
                    formula = -Lamda * Math.Log(1 - Ri);
                    TbExponencial[2, i].Value = formula;
                    MediaExp += Convert.ToDouble( TbExponencial[2, i].Value);
                }
                MediaExp = MediaExp / N;
                TxtExpMedia.Text = MediaExp.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtExpN_Validating(object sender, CancelEventArgs e)//validacion de TxtN de Va Exponencial
        {
            if (string.IsNullOrEmpty(txtExpN.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtExpN, "Ingresa un numero Entero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtExpN, null);
            }
        }

        private void txtExp1_Validating(object sender, CancelEventArgs e)//validacion de txtExp1 (1-λ)
        {
            if (string.IsNullOrEmpty(txtExp1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtExp1, "Ingresa un numero Entero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtExp1, null);
            }
        }

        private void txtExpN_KeyPress(object sender, KeyPressEventArgs e)//valida que solo se ingrese digitos
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as MaterialTextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void TbExponencial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void TbExponencial_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)//valida que se escriba solo numeros y llama al metodo column1 de tabla Exponencial
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (TbExponencial.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)//checa que la tabla solo acepte NUmeros y 1 punto
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tablaUniforme_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)//valida que se escriba solo numeros y llama al metodo column1 de tabla uniforme
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (tablaUniforme.CurrentCell.ColumnIndex == 1) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dat;
            int tiradas;


            dat = Convert.ToDouble(tx1.Text);
            tiradas = Convert.ToInt32(tx2.Text);

            String not = "X         RI  " + "\n";
            


            for (int i = 0; i < tiradas; i++)
            {
                not += i + "         " + binomial(dat, tiradas) + "\n";
            }

            richTextBox1.AppendText(not);
        }


        //BINOMIAL
        public static int binomial(double dat , int tiradas)
        {
            int exitos = 0;
            for (int i = 0; i < tiradas; i++)
            {
                if (bernou(tiradas)==1)
                {
                    exitos++;
                }
            }

            return (exitos);
        }


        public static int  bernou(double p)
        {

            Random r = new Random();
            double ri = r.Next();

            if (ri<=p)
            {
                return (1);
            }
            else
            {
                return (0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dat2;
            int tiradas2;


            dat2 = Convert.ToDouble(bernoutxt.Text);
            tiradas2 = Convert.ToInt32(canttx1.Text);

            String not = "X         RI  " + "\n";
            


            for (int i = 0; i < tiradas2; i++)
            {
                not += i + "         " + bernou(dat2) + "\n";
            }

            panel2.AppendText(not);
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            if (!TB1.Text.Equals("") & ((Convert.ToDouble(TB1.Text)) < 1) & !TB2.Text.Equals(""))
            {
                double n1 = Convert.ToDouble(TB1.Text);
                double resi = 1 - n1;
                int n = Convert.ToInt32(TB2.Text);
                LBL1.Text = "(1-P) =                   " + resi;
                int cell = 0;
                int cell2 = 1;
                int resul;
                String resul2;
                double pon = (Math.Pow(n1, cell) * Math.Pow(resi, (1 - cell)));
                double pon2 = (Math.Pow(n1, cell2) * Math.Pow(resi, 1 - cell2)); ;
                double pon3 = pon + pon2;
                Tab1.Rows.Clear();
                Tab1.Rows.Add(2);
                Tab1[0, 0].Value = cell;
                Tab1[0, 1].Value = cell2;
                Tab1[1, 0].Value = pon;
                Tab1[1, 1].Value = pon2;
                Tab1[2, 0].Value = pon;
                Tab1[2, 1].Value = pon3;
                Tab2.Rows.Clear();
                Tab2.Rows.Add(n);
                int val2 = 0;
                Random rand1 = new Random();
                int[] num1 = new int[n];
                for (int i = 0; i < n; i++)
                {
                    num1[i] = rand1.Next(1, 99);
                }
                for (int i = 0; i < n; i++)
                {

                    if (0 < (num1[i]) & num1[i] < (pon * 100))
                    {
                        resul = 0;
                        resul2 = "NO FALLA";
                    }
                    else
                    {
                        resul = 1;
                        resul2 = "FALLA";
                    }


                    Tab2[0, i].Value = i + 1;
                    Tab2[1, i].Value = "0." + num1[i];
                    Tab2[2, i].Value = resul;
                    Tab2[3, i].Value = resul2;
                }
            }
            else
            {
                
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (!TXB1.Text.Equals("") & ((Convert.ToDouble(TXB1.Text)) < 1) & !TXB2.Text.Equals(""))
            {
                double n1 = Convert.ToDouble(TXB1.Text);
                double resi = 1 - n1;
                int cc = Convert.ToInt32(TXB2.Text);
                int nu = 10;
                LBL1.Text = "(1-P) =                   " + resi;
                int cell = 0;
                int cell2 = 1;
                int [][]resul = new int [cc][];
                String resul2;
                double pon = (Math.Pow(n1, cell) * Math.Pow(resi, (1 - cell)));
                double pon2 = (Math.Pow(n1, cell2) * Math.Pow(resi, 1 - cell2)); ;
                double pon3 = pon + pon2;
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(2);
                dataGridView1[0, 0].Value = cell;
                dataGridView1[0, 1].Value = cell2;
                dataGridView1[1, 0].Value = pon;
                dataGridView1[1, 1].Value = pon2;
                dataGridView1[2, 0].Value = pon;
                dataGridView1[2, 1].Value = pon3;
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                int val2 = 0;
                Random rand1 = new Random();
                int[][] num1 = new int [cc][] ;
                for (int i = 0; i < cc; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        num1[i][j] = rand1.Next(1, 99);
                    }
                }
                for (int i = 0; i < cc; i++)
                {
                    for (int j = 0; j < nu; j++)
                    {
                        if (0 < (num1[i][j]) & num1[i][j] < (pon * 100))
                        {
                            resul[i][j] = 0;
                        }
                        else
                        {
                            resul[i][j] = 1;
                        }
                    }
                }

            }
        }

        private void btnPoissonOk_Click(object sender, EventArgs e)//btnPoissonOk
        {
            int PoissonLam = Convert.ToInt32(txtPoissonLam.Text);
            int Numeros = Convert.ToInt32(txtPoissonN.Text);
            double PoissonE = Convert.ToDouble(txtPoissonE.Text);
            double formulaPoisson;
            int horas = Convert.ToInt32(txtPoissonHoras.Text);

            if (Numeros < horas)
            {
                errorProvider1.SetError(txtPoissonHoras, "Horas debe ser Menor a Numeros");
                errorProvider1.SetError(txtPoissonN, "Numeros debe ser Mayor a Horas");
            }
            else
            {

                //tabla y formato de tabla
                TbPoisson.Rows.Clear();
                TbPoisson.Columns[1].DefaultCellStyle.Format = "#0.0000";
                TbPoisson.Columns[2].DefaultCellStyle.Format = "#0.00";
                TbPoisson.Columns[3].DefaultCellStyle.Format = "#0.00";
                TbPoisson.Columns[4].DefaultCellStyle.Format = "#0.00";
                TbPoisson.Columns[6].DefaultCellStyle.Format = "#0.00";
                TbPoisson.Rows.Add(Numeros + 1);
                formulaPoisson = ((Math.Pow(PoissonLam, 0) * (Math.Pow(PoissonE, -PoissonLam))));
                formulaPoisson = formulaPoisson / SpecialFunctions.Factorial(0);
                TbPoisson[2, 0].Value = formulaPoisson;
                TbPoisson[3, 0].Value = 0;
                TbPoisson[4, 0].Value = formulaPoisson;
                //for
                for (int i = 0; i < (Numeros + 1); i++)
                {

                    //llenado de columna 0
                    TbPoisson[0, i].Value = i;
                    //llenado de columna 1
                    formulaPoisson = ((Math.Pow(PoissonLam, i) * (Math.Pow(PoissonE, -PoissonLam))));
                    formulaPoisson = formulaPoisson / SpecialFunctions.Factorial(i);
                    TbPoisson[1, i].Value = formulaPoisson;
                    //llenado de columna 2
                    if (i > 0)
                    {
                        TbPoisson[2, i].Value = Convert.ToDouble(TbPoisson[2, (i - 1)].Value) + Convert.ToDouble(TbPoisson[1, i].Value);
                        //llenado de columna 3
                        TbPoisson[3, i].Value = TbPoisson[2, i - 1].Value;
                        //llenado de columna 4
                        TbPoisson[4, i].Value = TbPoisson[2, i].Value;
                    }
                }//Fin For
                 //for Horas
                Random r1 = new Random();
                try
                {

                    for (int i = 0; i < horas; i++)
                    {

                        //llenado de columna 5
                        double RiPoisson = 0;
                        TbPoisson[5, i].Value = i + 1;

                        //6

                        RiPoisson = r1.NextDouble();

                        TbPoisson[6, i].Value = RiPoisson;
                        for (int j = 0; j < Numeros; j++)
                        {
                            double DePoisson = Convert.ToDouble(TbPoisson[3, j].Value);
                            double APoisson = Convert.ToDouble(TbPoisson[4, j].Value);
                            if ((Convert.ToDouble(TbPoisson[6, i].Value) >= DePoisson) & (Convert.ToDouble(TbPoisson[6, i].Value) < APoisson))
                            {
                                TbPoisson[7, i].Value = TbPoisson[0, j].Value;
                                Console.WriteLine("entro al if");
                            }
                        }





                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void materialCard9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPoissonLam_Validating(object sender, CancelEventArgs e)//Validacion de txtPoissonLam
        {
            if (string.IsNullOrEmpty(txtPoissonLam.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPoissonLam, "Ingresa un numero Entero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPoissonLam, null);
            }
        }

        private void txtPoissonN_Validating(object sender, CancelEventArgs e)//Validacion de txtPoissonN
        {
            if (string.IsNullOrEmpty(txtPoissonN.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPoissonN, "Ingresa un numero Entero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPoissonN, null);
            }
        }

        private void txtPoissonHoras_Validating(object sender, CancelEventArgs e)//Validacion de txtPoissonHoras
        {
            if (string.IsNullOrEmpty(txtPoissonHoras.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPoissonHoras, "Ingresa un numero Entero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPoissonHoras, null);
            }
        }
    }
}
