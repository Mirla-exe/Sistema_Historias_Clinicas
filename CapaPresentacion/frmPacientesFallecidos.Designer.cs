﻿namespace CapaPresentacion
{
    partial class frmPacientesFallecidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar_fallecidos = new System.Windows.Forms.Button();
            this.btnBorrar_fallecido = new System.Windows.Forms.Button();
            this.btnRestaurar_fallecido = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_all_dead = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cblBusqueda_fallecidos = new System.Windows.Forms.ComboBox();
            this.txtBuscar_fallecidos = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Evolución_fallecido = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Historia_fallecido = new System.Windows.Forms.DataGridView();
            this.txtCausaMuerte = new System.Windows.Forms.TextBox();
            this.dtp_Death_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Paciente_fallecido = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_dead)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Evolución_fallecido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historia_fallecido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Paciente_fallecido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1809, 100);
            this.panel3.TabIndex = 209;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(551, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "†  Pacientes Fallecidos ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar_fallecidos
            // 
            this.btnBuscar_fallecidos.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar_fallecidos.FlatAppearance.BorderSize = 0;
            this.btnBuscar_fallecidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscar_fallecidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar_fallecidos.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnBuscar_fallecidos.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar_fallecidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar_fallecidos.Location = new System.Drawing.Point(1237, 15);
            this.btnBuscar_fallecidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar_fallecidos.Name = "btnBuscar_fallecidos";
            this.btnBuscar_fallecidos.Size = new System.Drawing.Size(113, 43);
            this.btnBuscar_fallecidos.TabIndex = 210;
            this.btnBuscar_fallecidos.Text = "Buscar";
            this.btnBuscar_fallecidos.UseVisualStyleBackColor = false;
            this.btnBuscar_fallecidos.Click += new System.EventHandler(this.btnBuscar_fallecidos_Click);
            // 
            // btnBorrar_fallecido
            // 
            this.btnBorrar_fallecido.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrar_fallecido.FlatAppearance.BorderSize = 0;
            this.btnBorrar_fallecido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBorrar_fallecido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar_fallecido.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnBorrar_fallecido.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBorrar_fallecido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar_fallecido.Location = new System.Drawing.Point(1237, 172);
            this.btnBorrar_fallecido.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar_fallecido.Name = "btnBorrar_fallecido";
            this.btnBorrar_fallecido.Size = new System.Drawing.Size(165, 55);
            this.btnBorrar_fallecido.TabIndex = 208;
            this.btnBorrar_fallecido.Text = "Borrar";
            this.btnBorrar_fallecido.UseVisualStyleBackColor = false;
            this.btnBorrar_fallecido.Click += new System.EventHandler(this.btnBorrar_fallecido_Click);
            // 
            // btnRestaurar_fallecido
            // 
            this.btnRestaurar_fallecido.BackColor = System.Drawing.SystemColors.Control;
            this.btnRestaurar_fallecido.FlatAppearance.BorderSize = 0;
            this.btnRestaurar_fallecido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRestaurar_fallecido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar_fallecido.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnRestaurar_fallecido.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnRestaurar_fallecido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurar_fallecido.Location = new System.Drawing.Point(1237, 97);
            this.btnRestaurar_fallecido.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar_fallecido.Name = "btnRestaurar_fallecido";
            this.btnRestaurar_fallecido.Size = new System.Drawing.Size(165, 55);
            this.btnRestaurar_fallecido.TabIndex = 207;
            this.btnRestaurar_fallecido.Text = "Restaurar";
            this.btnRestaurar_fallecido.UseVisualStyleBackColor = false;
            this.btnRestaurar_fallecido.Click += new System.EventHandler(this.btnRestaurar_fallecido_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 139);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1436, 798);
            this.tabControl1.TabIndex = 206;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.dgv_all_dead);
            this.tabPage1.Controls.Add(this.btnBuscar_fallecidos);
            this.tabPage1.Controls.Add(this.cblBusqueda_fallecidos);
            this.tabPage1.Controls.Add(this.txtBuscar_fallecidos);
            this.tabPage1.Controls.Add(this.btnRestaurar_fallecido);
            this.tabPage1.Controls.Add(this.btnBorrar_fallecido);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1428, 763);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado total";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTotal.Location = new System.Drawing.Point(18, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(312, 32);
            this.lblTotal.TabIndex = 214;
            this.lblTotal.Text = "Todos los pacientes fallecidos ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label16.ForeColor = System.Drawing.Color.DarkCyan;
            this.label16.Location = new System.Drawing.Point(718, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 32);
            this.label16.TabIndex = 213;
            this.label16.Text = "Buscar según:";
            // 
            // dgv_all_dead
            // 
            this.dgv_all_dead.AllowUserToAddRows = false;
            this.dgv_all_dead.AllowUserToDeleteRows = false;
            this.dgv_all_dead.AllowUserToOrderColumns = true;
            this.dgv_all_dead.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_all_dead.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_all_dead.ColumnHeadersHeight = 50;
            this.dgv_all_dead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_all_dead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_all_dead.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_all_dead.GridColor = System.Drawing.Color.DarkCyan;
            this.dgv_all_dead.Location = new System.Drawing.Point(3, 75);
            this.dgv_all_dead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_all_dead.MultiSelect = false;
            this.dgv_all_dead.Name = "dgv_all_dead";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_all_dead.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_all_dead.RowHeadersWidth = 51;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_all_dead.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_all_dead.RowTemplate.Height = 24;
            this.dgv_all_dead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_all_dead.Size = new System.Drawing.Size(1206, 683);
            this.dgv_all_dead.TabIndex = 16;
            this.dgv_all_dead.DoubleClick += new System.EventHandler(this.dgv_all_dead_DoubleClick);
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccion";
            this.Seleccion.MinimumWidth = 6;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Width = 125;
            // 
            // cblBusqueda_fallecidos
            // 
            this.cblBusqueda_fallecidos.BackColor = System.Drawing.SystemColors.Control;
            this.cblBusqueda_fallecidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblBusqueda_fallecidos.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cblBusqueda_fallecidos.ForeColor = System.Drawing.Color.DarkCyan;
            this.cblBusqueda_fallecidos.FormattingEnabled = true;
            this.cblBusqueda_fallecidos.Items.AddRange(new object[] {
            "Nombre",
            "Cedula"});
            this.cblBusqueda_fallecidos.Location = new System.Drawing.Point(883, 18);
            this.cblBusqueda_fallecidos.Margin = new System.Windows.Forms.Padding(4);
            this.cblBusqueda_fallecidos.Name = "cblBusqueda_fallecidos";
            this.cblBusqueda_fallecidos.Size = new System.Drawing.Size(160, 40);
            this.cblBusqueda_fallecidos.TabIndex = 212;
            // 
            // txtBuscar_fallecidos
            // 
            this.txtBuscar_fallecidos.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar_fallecidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_fallecidos.Location = new System.Drawing.Point(1050, 26);
            this.txtBuscar_fallecidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar_fallecidos.Name = "txtBuscar_fallecidos";
            this.txtBuscar_fallecidos.Size = new System.Drawing.Size(176, 27);
            this.txtBuscar_fallecidos.TabIndex = 211;
            this.txtBuscar_fallecidos.TextChanged += new System.EventHandler(this.txtBuscar_fallecidos_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lbl_id);
            this.tabPage2.Controls.Add(this.lbl_cedula);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgv_Evolución_fallecido);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgv_Historia_fallecido);
            this.tabPage2.Controls.Add(this.txtCausaMuerte);
            this.tabPage2.Controls.Add(this.dtp_Death_Date);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgv_Paciente_fallecido);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1428, 763);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ficha del Paciente Fallecido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(993, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 32);
            this.label9.TabIndex = 227;
            this.label9.Text = "Cedula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(962, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 32);
            this.label8.TabIndex = 226;
            this.label8.Text = "ID del pac:";
            this.label8.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lbl_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_id.Location = new System.Drawing.Point(1089, 38);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(66, 32);
            this.lbl_id.TabIndex = 225;
            this.lbl_id.Text = "lbl_id";
            this.lbl_id.Visible = false;
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lbl_cedula.ForeColor = System.Drawing.Color.Black;
            this.lbl_cedula.Location = new System.Drawing.Point(1089, 94);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(64, 32);
            this.lbl_cedula.TabIndex = 224;
            this.lbl_cedula.Text = "lbl_ci";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 679);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 32);
            this.label6.TabIndex = 223;
            this.label6.Text = "Evolución:";
            // 
            // dgv_Evolución_fallecido
            // 
            this.dgv_Evolución_fallecido.AllowUserToAddRows = false;
            this.dgv_Evolución_fallecido.AllowUserToDeleteRows = false;
            this.dgv_Evolución_fallecido.AllowUserToOrderColumns = true;
            this.dgv_Evolución_fallecido.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Evolución_fallecido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Evolución_fallecido.ColumnHeadersHeight = 50;
            this.dgv_Evolución_fallecido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Evolución_fallecido.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_Evolución_fallecido.GridColor = System.Drawing.Color.DarkCyan;
            this.dgv_Evolución_fallecido.Location = new System.Drawing.Point(27, 713);
            this.dgv_Evolución_fallecido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Evolución_fallecido.MultiSelect = false;
            this.dgv_Evolución_fallecido.Name = "dgv_Evolución_fallecido";
            this.dgv_Evolución_fallecido.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Evolución_fallecido.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_Evolución_fallecido.RowHeadersWidth = 51;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Evolución_fallecido.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_Evolución_fallecido.RowTemplate.Height = 24;
            this.dgv_Evolución_fallecido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Evolución_fallecido.Size = new System.Drawing.Size(1364, 186);
            this.dgv_Evolución_fallecido.TabIndex = 222;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 221;
            this.label5.Text = "Historia:";
            // 
            // dgv_Historia_fallecido
            // 
            this.dgv_Historia_fallecido.AllowUserToAddRows = false;
            this.dgv_Historia_fallecido.AllowUserToDeleteRows = false;
            this.dgv_Historia_fallecido.AllowUserToOrderColumns = true;
            this.dgv_Historia_fallecido.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Historia_fallecido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_Historia_fallecido.ColumnHeadersHeight = 50;
            this.dgv_Historia_fallecido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Historia_fallecido.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_Historia_fallecido.GridColor = System.Drawing.Color.DarkCyan;
            this.dgv_Historia_fallecido.Location = new System.Drawing.Point(27, 456);
            this.dgv_Historia_fallecido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Historia_fallecido.MultiSelect = false;
            this.dgv_Historia_fallecido.Name = "dgv_Historia_fallecido";
            this.dgv_Historia_fallecido.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Historia_fallecido.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_Historia_fallecido.RowHeadersWidth = 51;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Historia_fallecido.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_Historia_fallecido.RowTemplate.Height = 24;
            this.dgv_Historia_fallecido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Historia_fallecido.Size = new System.Drawing.Size(1364, 186);
            this.dgv_Historia_fallecido.TabIndex = 220;
            // 
            // txtCausaMuerte
            // 
            this.txtCausaMuerte.BackColor = System.Drawing.SystemColors.Control;
            this.txtCausaMuerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausaMuerte.Location = new System.Drawing.Point(343, 94);
            this.txtCausaMuerte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCausaMuerte.Name = "txtCausaMuerte";
            this.txtCausaMuerte.Size = new System.Drawing.Size(549, 27);
            this.txtCausaMuerte.TabIndex = 214;
            // 
            // dtp_Death_Date
            // 
            this.dtp_Death_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Death_Date.Location = new System.Drawing.Point(27, 90);
            this.dtp_Death_Date.Name = "dtp_Death_Date";
            this.dtp_Death_Date.Size = new System.Drawing.Size(250, 28);
            this.dtp_Death_Date.TabIndex = 219;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(337, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 218;
            this.label4.Text = "Causa de Muerte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 217;
            this.label3.Text = "Fecha de Muerte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 216;
            this.label2.Text = "Paciente:";
            // 
            // dgv_Paciente_fallecido
            // 
            this.dgv_Paciente_fallecido.AllowUserToAddRows = false;
            this.dgv_Paciente_fallecido.AllowUserToDeleteRows = false;
            this.dgv_Paciente_fallecido.AllowUserToOrderColumns = true;
            this.dgv_Paciente_fallecido.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Paciente_fallecido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_Paciente_fallecido.ColumnHeadersHeight = 50;
            this.dgv_Paciente_fallecido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Paciente_fallecido.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_Paciente_fallecido.GridColor = System.Drawing.Color.DarkCyan;
            this.dgv_Paciente_fallecido.Location = new System.Drawing.Point(27, 200);
            this.dgv_Paciente_fallecido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Paciente_fallecido.MultiSelect = false;
            this.dgv_Paciente_fallecido.Name = "dgv_Paciente_fallecido";
            this.dgv_Paciente_fallecido.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Paciente_fallecido.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_Paciente_fallecido.RowHeadersWidth = 51;
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Paciente_fallecido.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_Paciente_fallecido.RowTemplate.Height = 24;
            this.dgv_Paciente_fallecido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Paciente_fallecido.Size = new System.Drawing.Size(1364, 186);
            this.dgv_Paciente_fallecido.TabIndex = 215;
            // 
            // frmPacientesFallecidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 949);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientesFallecidos";
            this.Text = "frmPacientesFallecidos";
            this.Load += new System.EventHandler(this.frmPacientesFallecidos_Load);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_dead)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Evolución_fallecido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historia_fallecido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Paciente_fallecido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar_fallecidos;
        private System.Windows.Forms.Button btnBorrar_fallecido;
        private System.Windows.Forms.Button btnRestaurar_fallecido;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtp_Death_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Paciente_fallecido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Evolución_fallecido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Historia_fallecido;
        private System.Windows.Forms.TextBox txtCausaMuerte;
        private System.Windows.Forms.DataGridView dgv_all_dead;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cblBusqueda_fallecidos;
        private System.Windows.Forms.TextBox txtBuscar_fallecidos;
    }
}