using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exameen
{
    public partial class Form1 : Form
    {
        string[] rows = {"Inversion", "Ingreso", "Egreso", "Depreciacion","UAI",
                           "IR", "UDI", "Depreciacion","V.S", "FNE" };

        public Form1()
        {
            InitializeComponent();
        }
                      
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal Ingresos = decimal.Parse(txtIngresos.Text);
            decimal Egresos = decimal.Parse(txtEgresos.Text);
            decimal Inversion = decimal.Parse(txtInversion.Text);
            int Plazo = int.Parse(txtPlazo.Text);
            double Taza = Double.Parse(txtTaza.Text);
            decimal Inflacion = decimal.Parse(txtInflacion.Text);
            decimal vs = decimal.Parse(txtVS.Text);
            double IR = 0.3;
            decimal VPN = 0;
            double Interes = 0;

            dgvDatos.Columns.Add("", "Anios");
            for (int i = 0; i <= Plazo; i++)
            {
                dgvDatos.Columns.Add("", i.ToString());
            }

            //Filas
            for (int i = 0; i < rows.Length; i++)
            {
                dgvDatos.Rows.Add(rows[i]);
            }

            dgvDatos.Rows[0].Cells[1].Value = Inversion;

            for (int i = 2; i < dgvDatos.ColumnCount; i++)
            {
                if (i == 2)
                {
                    dgvDatos.Rows[1].Cells[i].Value = Ingresos;
                }
                else
                {
                    Ingresos = Ingresos + (Ingresos * (decimal)Taza);
                    dgvDatos.Rows[1].Cells[i].Value = Ingresos;
                }
            }

            for (int i = 2; i < dgvDatos.ColumnCount; i++)
            {
                if (i == 2)
                {
                    dgvDatos.Rows[2].Cells[i].Value = Egresos;
                }
                else
                {
                    Egresos = Egresos + (Egresos * (decimal)Inflacion);
                    dgvDatos.Rows[2].Cells[i].Value = Egresos;
                }
            }
            dgvDatos.Rows[8].Cells[Plazo + 1].Value = vs;

            calculoDepreciacion(Inversion, Plazo, vs);
            calculoUAI(dgvDatos);
            CalcularIR(IR, dgvDatos);
            CalcularUDI(dgvDatos);
            CalculoDepreciacion(Inversion, Plazo, vs);
            CalculoFNE(dgvDatos, Inversion);
            CalcularVPN(dgvDatos, VPN, Interes);
        }

        private void calculoDepreciacion(decimal Inversion, int Plazo, decimal vs)
        {
            for (int i = 2; i < dgvDatos.ColumnCount; i++)
            {
                dgvDatos.Rows[3].Cells[i].Value = (Inversion - vs) / Plazo;
            }
        }

        private void calculoUAI(DataGridView dgv)
        {
            for (int i = 2; i < dgvDatos.ColumnCount; i++)
            {
                float ingresos = float.Parse(dgvDatos.Rows[1].Cells[i].Value.ToString());
                float depreciacion = float.Parse(dgvDatos.Rows[3].Cells[i].Value.ToString());
                float egreso = float.Parse(dgvDatos.Rows[2].Cells[i].Value.ToString());
                dgv.Rows[4].Cells[i].Value = ingresos - egreso - depreciacion;
            }
        }

        private void CalcularIR(double IR, DataGridView dgv)
        {
            for (int i = 2; i < dgvDatos.ColumnCount; i++)
            {
                decimal n = decimal.Parse(dgv.Rows[4].Cells[i].Value.ToString());
                dgv.Rows[5].Cells[i].Value = n * (decimal)IR;
            }
        }

        private void CalcularUDI(DataGridView dgv)
        {
            for (int i = 2; i < dgvDatos.ColumnCount; i++)
            {
                decimal n = decimal.Parse(dgv.Rows[4].Cells[i].Value.ToString());
                decimal m = decimal.Parse(dgv.Rows[5].Cells[i].Value.ToString());

                dgv.Rows[6].Cells[i].Value = n - m;
            }
        }

        private void CalculoDepreciacion(decimal Inversion, int Plazo, decimal vs)
        {
            for (int i = 2; i < dgvDatos.ColumnCount; i++)
            {
                dgvDatos.Rows[7].Cells[i].Value = (Inversion - vs) / Plazo;
            }
        }

        private void CalculoFNE(DataGridView dgv, decimal Inversion)
        {
            dgv.Rows[9].Cells[1].Value = Inversion * -1;
            for (int i = 2; i < dgvDatos.ColumnCount - 1; i++)
            {
                decimal n = decimal.Parse(dgv.Rows[6].Cells[i].Value.ToString());
                decimal m = decimal.Parse(dgv.Rows[7].Cells[i].Value.ToString());

                dgv.Rows[9].Cells[i].Value = n + m;
            }

            decimal q = decimal.Parse(dgv.Rows[6].Cells[Int32.Parse(txtPlazo.Text) + 1].Value.ToString());
            decimal w = decimal.Parse(dgv.Rows[7].Cells[Int32.Parse(txtPlazo.Text) + 1].Value.ToString());
            decimal e = decimal.Parse(dgv.Rows[8].Cells[Int32.Parse(txtPlazo.Text) + 1].Value.ToString());

            dgv.Rows[9].Cells[Int32.Parse(txtPlazo.Text) + 1].Value = q + w + e;
        }

        private void CalcularVPN(DataGridView dgv, decimal VPN, double Interes)
        {
            Interes = 1 + double.Parse(txtTaza.Text);
            for (int i = 2; i < dgvDatos.ColumnCount; i++)
            {
                for (int j = 1; j < (Int32.Parse(txtPlazo.Text) + 1); j++)
                {
                    VPN += decimal.Parse(dgv.Rows[9].Cells[i].Value.ToString()) * (decimal)Math.Pow(Interes, j);
                }
            }

            VPN += decimal.Parse(dgv.Rows[9].Cells[1].Value.ToString());
            txtVPN.Text = VPN.ToString();
        }
        

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0 || dgvDatos.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Tabla sin datos o fila no seleccionada");
                return;
            }
            
        }

        public void LoadInfo(Product p)
        {
            txtIngresos.Text = p.Ingresos;
            txtEgresos.Text = p.Egresos;
            txtInversion.Text = p.Inversion;
            txtPlazo.Text = p.Plazo;
            txtTaza.Text = p.Taza;
            txtInflacion.Text = p.Inflacion;
            txtVS.Text = p.VS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

