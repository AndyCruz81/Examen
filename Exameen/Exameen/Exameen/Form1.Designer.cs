namespace Exameen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInversion = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtTaza = new System.Windows.Forms.TextBox();
            this.txtInflacion = new System.Windows.Forms.TextBox();
            this.txtVS = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVPN = new System.Windows.Forms.TextBox();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIngresos);
            this.groupBox1.Controls.Add(this.txtEgresos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtInversion);
            this.groupBox1.Controls.Add(this.txtPlazo);
            this.groupBox1.Controls.Add(this.txtTaza);
            this.groupBox1.Controls.Add(this.txtInflacion);
            this.groupBox1.Controls.Add(this.txtVS);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ingresos:";
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(17, 329);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtIngresos.TabIndex = 13;
            // 
            // txtEgresos
            // 
            this.txtEgresos.Location = new System.Drawing.Point(17, 388);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(100, 20);
            this.txtEgresos.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Egresos:";
            // 
            // txtInversion
            // 
            this.txtInversion.Location = new System.Drawing.Point(17, 68);
            this.txtInversion.Name = "txtInversion";
            this.txtInversion.Size = new System.Drawing.Size(100, 20);
            this.txtInversion.TabIndex = 10;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(17, 118);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(100, 20);
            this.txtPlazo.TabIndex = 9;
            // 
            // txtTaza
            // 
            this.txtTaza.Location = new System.Drawing.Point(17, 167);
            this.txtTaza.Name = "txtTaza";
            this.txtTaza.Size = new System.Drawing.Size(100, 20);
            this.txtTaza.TabIndex = 8;
            // 
            // txtInflacion
            // 
            this.txtInflacion.Location = new System.Drawing.Point(17, 220);
            this.txtInflacion.Name = "txtInflacion";
            this.txtInflacion.Size = new System.Drawing.Size(100, 20);
            this.txtInflacion.TabIndex = 7;
            // 
            // txtVS
            // 
            this.txtVS.Location = new System.Drawing.Point(17, 277);
            this.txtVS.Name = "txtVS";
            this.txtVS.Size = new System.Drawing.Size(100, 20);
            this.txtVS.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(42, 431);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "V.S:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inflacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plazo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversion:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(166, 21);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(660, 419);
            this.dgvDatos.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "VPN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "PR:";
            // 
            // txtVPN
            // 
            this.txtVPN.Location = new System.Drawing.Point(266, 450);
            this.txtVPN.Name = "txtVPN";
            this.txtVPN.Size = new System.Drawing.Size(100, 20);
            this.txtVPN.TabIndex = 4;
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(424, 453);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(100, 20);
            this.txtIR.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(733, 462);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(632, 462);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 510);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.txtVPN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FNE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInversion;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtTaza;
        private System.Windows.Forms.TextBox txtInflacion;
        private System.Windows.Forms.TextBox txtVS;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVPN;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

