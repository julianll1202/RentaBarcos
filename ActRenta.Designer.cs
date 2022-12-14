namespace ProyectoRentaDeBarcos
{
    partial class ActRenta
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
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.fecha_in = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_barco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fecha_fin
            // 
            this.fecha_fin.CustomFormat = "YYYY-MM-DD";
            this.fecha_fin.Location = new System.Drawing.Point(165, 78);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(153, 20);
            this.fecha_fin.TabIndex = 111;
            // 
            // fecha_in
            // 
            this.fecha_in.CustomFormat = "YYYY-MM-DD";
            this.fecha_in.Location = new System.Drawing.Point(165, 53);
            this.fecha_in.Name = "fecha_in";
            this.fecha_in.Size = new System.Drawing.Size(153, 20);
            this.fecha_in.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(220, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 109;
            this.label9.Text = "Actualizar renta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "No. de cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "No. de barco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Fecha de finalizacion de viaje";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(120, 13);
            this.label.TabIndex = 102;
            this.label.Text = "Fecha de Inicio de viaje";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(438, 122);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 101;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // agregar_btn
            // 
            this.agregar_btn.Location = new System.Drawing.Point(348, 122);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(75, 23);
            this.agregar_btn.TabIndex = 100;
            this.agregar_btn.Text = "Actualizar";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(414, 53);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(100, 20);
            this.tb_cliente.TabIndex = 115;
            // 
            // tb_barco
            // 
            this.tb_barco.Location = new System.Drawing.Point(414, 80);
            this.tb_barco.Name = "tb_barco";
            this.tb_barco.Size = new System.Drawing.Size(100, 20);
            this.tb_barco.TabIndex = 116;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(402, 13);
            this.label13.TabIndex = 117;
            this.label13.Text = "Llene los campos con la información correspondiente a la renta que desea modifica" +
    "r";
            // 
            // ActRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 160);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_barco);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.fecha_in);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.agregar_btn);
            this.Name = "ActRenta";
            this.Text = "Actualizar renta";
            this.Load += new System.EventHandler(this.ActRenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.DateTimePicker fecha_in;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_barco;
        private System.Windows.Forms.Label label13;
    }
}