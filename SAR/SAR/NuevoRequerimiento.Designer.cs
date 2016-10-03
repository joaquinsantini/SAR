namespace SAR
{
    partial class NuevoRequerimiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.tituloTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.detalleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.solicitanteCB = new System.Windows.Forms.ComboBox();
            this.prioridadCB = new System.Windows.Forms.ComboBox();
            this.prioridadL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fEntEstimadaDP = new System.Windows.Forms.DateTimePicker();
            this.aceptarB = new System.Windows.Forms.Button();
            this.cancelarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // tituloTB
            // 
            this.tituloTB.Location = new System.Drawing.Point(79, 17);
            this.tituloTB.Name = "tituloTB";
            this.tituloTB.Size = new System.Drawing.Size(246, 20);
            this.tituloTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalle:";
            // 
            // detalleTB
            // 
            this.detalleTB.Location = new System.Drawing.Point(79, 56);
            this.detalleTB.Name = "detalleTB";
            this.detalleTB.Size = new System.Drawing.Size(582, 20);
            this.detalleTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Solicitante:";
            // 
            // solicitanteCB
            // 
            this.solicitanteCB.FormattingEnabled = true;
            this.solicitanteCB.Location = new System.Drawing.Point(79, 94);
            this.solicitanteCB.Name = "solicitanteCB";
            this.solicitanteCB.Size = new System.Drawing.Size(190, 21);
            this.solicitanteCB.TabIndex = 3;
            // 
            // prioridadCB
            // 
            this.prioridadCB.FormattingEnabled = true;
            this.prioridadCB.Location = new System.Drawing.Point(540, 94);
            this.prioridadCB.Name = "prioridadCB";
            this.prioridadCB.Size = new System.Drawing.Size(121, 21);
            this.prioridadCB.TabIndex = 5;
            // 
            // prioridadL
            // 
            this.prioridadL.AutoSize = true;
            this.prioridadL.Location = new System.Drawing.Point(481, 97);
            this.prioridadL.Name = "prioridadL";
            this.prioridadL.Size = new System.Drawing.Size(51, 13);
            this.prioridadL.TabIndex = 7;
            this.prioridadL.Text = "Prioridad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "F. Ent. Estimada:";
            // 
            // fEntEstimadaDP
            // 
            this.fEntEstimadaDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fEntEstimadaDP.Location = new System.Drawing.Point(374, 94);
            this.fEntEstimadaDP.Name = "fEntEstimadaDP";
            this.fEntEstimadaDP.Size = new System.Drawing.Size(98, 20);
            this.fEntEstimadaDP.TabIndex = 4;
            // 
            // aceptarB
            // 
            this.aceptarB.Location = new System.Drawing.Point(505, 168);
            this.aceptarB.Name = "aceptarB";
            this.aceptarB.Size = new System.Drawing.Size(75, 23);
            this.aceptarB.TabIndex = 6;
            this.aceptarB.Text = "Aceptar";
            this.aceptarB.UseVisualStyleBackColor = true;
            this.aceptarB.Click += new System.EventHandler(this.aceptarB_Click);
            // 
            // cancelarB
            // 
            this.cancelarB.Location = new System.Drawing.Point(586, 168);
            this.cancelarB.Name = "cancelarB";
            this.cancelarB.Size = new System.Drawing.Size(75, 23);
            this.cancelarB.TabIndex = 7;
            this.cancelarB.Text = "Cancelar";
            this.cancelarB.UseVisualStyleBackColor = true;
            this.cancelarB.Click += new System.EventHandler(this.cancelarB_Click);
            // 
            // NuevoRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 208);
            this.ControlBox = false;
            this.Controls.Add(this.cancelarB);
            this.Controls.Add(this.aceptarB);
            this.Controls.Add(this.fEntEstimadaDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prioridadL);
            this.Controls.Add(this.prioridadCB);
            this.Controls.Add(this.solicitanteCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detalleTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tituloTB);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(696, 247);
            this.MinimumSize = new System.Drawing.Size(696, 247);
            this.Name = "NuevoRequerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Requerimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tituloTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detalleTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox solicitanteCB;
        private System.Windows.Forms.ComboBox prioridadCB;
        private System.Windows.Forms.Label prioridadL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fEntEstimadaDP;
        private System.Windows.Forms.Button aceptarB;
        private System.Windows.Forms.Button cancelarB;
    }
}