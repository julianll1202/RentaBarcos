﻿namespace ProyectoRentaDeBarcos
{
    partial class NuevaTrip
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
            this.lb_empleados = new System.Windows.Forms.ListBox();
            this.lb_rentas = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.tb_tarifa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_empleados
            // 
            this.lb_empleados.FormattingEnabled = true;
            this.lb_empleados.ItemHeight = 16;
            this.lb_empleados.Location = new System.Drawing.Point(134, 101);
            this.lb_empleados.Margin = new System.Windows.Forms.Padding(4);
            this.lb_empleados.Name = "lb_empleados";
            this.lb_empleados.Size = new System.Drawing.Size(159, 20);
            this.lb_empleados.TabIndex = 102;
            // 
            // lb_rentas
            // 
            this.lb_rentas.FormattingEnabled = true;
            this.lb_rentas.ItemHeight = 16;
            this.lb_rentas.Location = new System.Drawing.Point(134, 67);
            this.lb_rentas.Margin = new System.Windows.Forms.Padding(4);
            this.lb_rentas.Name = "lb_rentas";
            this.lb_rentas.Size = new System.Drawing.Size(159, 20);
            this.lb_rentas.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 100;
            this.label6.Text = "No. de renta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 99;
            this.label5.Text = "No. de empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 24);
            this.label9.TabIndex = 104;
            this.label9.Text = "Nueva tripulación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Llene los campos con la información correspondiente a la nueva tripulación";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(389, 143);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 28);
            this.cancel_btn.TabIndex = 106;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // agregar_btn
            // 
            this.agregar_btn.Location = new System.Drawing.Point(269, 143);
            this.agregar_btn.Margin = new System.Windows.Forms.Padding(4);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(100, 28);
            this.agregar_btn.TabIndex = 105;
            this.agregar_btn.Text = "Agregar";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Tarifa";
            // 
            // tb_cargo
            // 
            this.tb_cargo.Location = new System.Drawing.Point(389, 67);
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.Size = new System.Drawing.Size(100, 22);
            this.tb_cargo.TabIndex = 109;
            // 
            // tb_tarifa
            // 
            this.tb_tarifa.Location = new System.Drawing.Point(389, 101);
            this.tb_tarifa.Name = "tb_tarifa";
            this.tb_tarifa.Size = new System.Drawing.Size(100, 22);
            this.tb_tarifa.TabIndex = 110;
            // 
            // NuevaTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 185);
            this.Controls.Add(this.tb_tarifa);
            this.Controls.Add(this.tb_cargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_empleados);
            this.Controls.Add(this.lb_rentas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "NuevaTrip";
            this.Text = "NuevaTrip";
            this.Load += new System.EventHandler(this.NuevaTrip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_empleados;
        private System.Windows.Forms.ListBox lb_rentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.TextBox tb_tarifa;
    }
}