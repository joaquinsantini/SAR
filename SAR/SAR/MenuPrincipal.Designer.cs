namespace SAR
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRequerimientoMI = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrilla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarMI = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.prioridadCB = new System.Windows.Forms.ComboBox();
            this.estadoCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaHastaDP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaDesdeDP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.psAltaCB = new System.Windows.Forms.ComboBox();
            this.grillaReq = new System.Windows.Forms.DataGridView();
            this.actualizarEstadoMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarHorasMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.menuGrilla.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaReq)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRequerimientoMI,
            this.estadisticasMI,
            this.salirMI});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoRequerimientoMI
            // 
            this.nuevoRequerimientoMI.Name = "nuevoRequerimientoMI";
            this.nuevoRequerimientoMI.Size = new System.Drawing.Size(199, 22);
            this.nuevoRequerimientoMI.Text = "Nuevo Requerimiento...";
            this.nuevoRequerimientoMI.Click += new System.EventHandler(this.nuevoRequerimientoMI_Click);
            // 
            // estadisticasMI
            // 
            this.estadisticasMI.Name = "estadisticasMI";
            this.estadisticasMI.Size = new System.Drawing.Size(199, 22);
            this.estadisticasMI.Text = "Estadísticas";
            // 
            // salirMI
            // 
            this.salirMI.Name = "salirMI";
            this.salirMI.Size = new System.Drawing.Size(199, 22);
            this.salirMI.Text = "Salir";
            this.salirMI.Click += new System.EventHandler(this.salirMI_Click);
            // 
            // menuGrilla
            // 
            this.menuGrilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarMI,
            this.eliminarMI,
            this.actualizarEstadoMI,
            this.cargarHorasMI});
            this.menuGrilla.Name = "menuGrilla";
            this.menuGrilla.Size = new System.Drawing.Size(165, 114);
            // 
            // modificarMI
            // 
            this.modificarMI.Name = "modificarMI";
            this.modificarMI.Size = new System.Drawing.Size(164, 22);
            this.modificarMI.Text = "Modificar";
            // 
            // eliminarMI
            // 
            this.eliminarMI.Name = "eliminarMI";
            this.eliminarMI.Size = new System.Drawing.Size(164, 22);
            this.eliminarMI.Text = "Eliminar";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 522);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.prioridadCB);
            this.tabPage1.Controls.Add(this.estadoCB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.fechaHastaDP);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.fechaDesdeDP);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.psAltaCB);
            this.tabPage1.Controls.Add(this.grillaReq);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Requerimientos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mis Horas";
            // 
            // prioridadCB
            // 
            this.prioridadCB.FormattingEnabled = true;
            this.prioridadCB.Items.AddRange(new object[] {
            "Todas",
            "Baja",
            "Media",
            "Alta"});
            this.prioridadCB.Location = new System.Drawing.Point(314, 57);
            this.prioridadCB.Name = "prioridadCB";
            this.prioridadCB.Size = new System.Drawing.Size(133, 21);
            this.prioridadCB.TabIndex = 33;
            // 
            // estadoCB
            // 
            this.estadoCB.FormattingEnabled = true;
            this.estadoCB.Items.AddRange(new object[] {
            "Todos",
            "En Aprobacion",
            "Activo",
            "Terminado",
            "Eliminado"});
            this.estadoCB.Location = new System.Drawing.Point(63, 57);
            this.estadoCB.Name = "estadoCB";
            this.estadoCB.Size = new System.Drawing.Size(156, 21);
            this.estadoCB.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Prioridad:";
            // 
            // fechaHastaDP
            // 
            this.fechaHastaDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHastaDP.Location = new System.Drawing.Point(577, 22);
            this.fechaHastaDP.Name = "fechaHastaDP";
            this.fechaHastaDP.Size = new System.Drawing.Size(100, 20);
            this.fechaHastaDP.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fec. Alta Hasta:";
            // 
            // fechaDesdeDP
            // 
            this.fechaDesdeDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesdeDP.Location = new System.Drawing.Point(349, 21);
            this.fechaDesdeDP.Name = "fechaDesdeDP";
            this.fechaDesdeDP.Size = new System.Drawing.Size(98, 20);
            this.fechaDesdeDP.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fec. Alta Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "PS Alta:";
            // 
            // psAltaCB
            // 
            this.psAltaCB.FormattingEnabled = true;
            this.psAltaCB.Items.AddRange(new object[] {
            "Todos",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110"});
            this.psAltaCB.Location = new System.Drawing.Point(65, 21);
            this.psAltaCB.Name = "psAltaCB";
            this.psAltaCB.Size = new System.Drawing.Size(154, 21);
            this.psAltaCB.TabIndex = 24;
            // 
            // grillaReq
            // 
            this.grillaReq.AllowUserToAddRows = false;
            this.grillaReq.AllowUserToDeleteRows = false;
            this.grillaReq.AllowUserToResizeRows = false;
            this.grillaReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grillaReq.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grillaReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grillaReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaReq.GridColor = System.Drawing.SystemColors.Control;
            this.grillaReq.Location = new System.Drawing.Point(13, 98);
            this.grillaReq.MultiSelect = false;
            this.grillaReq.Name = "grillaReq";
            this.grillaReq.ReadOnly = true;
            this.grillaReq.RowHeadersVisible = false;
            this.grillaReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaReq.Size = new System.Drawing.Size(733, 381);
            this.grillaReq.TabIndex = 23;
            this.grillaReq.MouseDown += new System.Windows.Forms.MouseEventHandler(this.seleccionarFila);
            // 
            // actualizarEstadoMI
            // 
            this.actualizarEstadoMI.Name = "actualizarEstadoMI";
            this.actualizarEstadoMI.Size = new System.Drawing.Size(164, 22);
            this.actualizarEstadoMI.Text = "Actualizar Estado";
            // 
            // cargarHorasMI
            // 
            this.cargarHorasMI.Name = "cargarHorasMI";
            this.cargarHorasMI.Size = new System.Drawing.Size(164, 22);
            this.cargarHorasMI.Text = "Cargar Horas";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.Text = "SAR";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.menuGrilla.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRequerimientoMI;
        private System.Windows.Forms.ToolStripMenuItem estadisticasMI;
        private System.Windows.Forms.ToolStripMenuItem salirMI;
        private System.Windows.Forms.ContextMenuStrip menuGrilla;
        private System.Windows.Forms.ToolStripMenuItem modificarMI;
        private System.Windows.Forms.ToolStripMenuItem eliminarMI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox prioridadCB;
        private System.Windows.Forms.ComboBox estadoCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaHastaDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaDesdeDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox psAltaCB;
        private System.Windows.Forms.DataGridView grillaReq;
        private System.Windows.Forms.ToolStripMenuItem actualizarEstadoMI;
        private System.Windows.Forms.ToolStripMenuItem cargarHorasMI;
    }
}

