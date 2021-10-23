﻿using MaterialSkin.Controls;
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
    }
}
