﻿namespace Pismire_TCC
{
    partial class TelaEventosCriados
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEventosCriados));
            this.lb_eventosCriados = new System.Windows.Forms.Label();
            this.p_barra = new System.Windows.Forms.Panel();
            this.pbVoltar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pLixeira = new System.Windows.Forms.Panel();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dt = new System.Windows.Forms.DataGridView();
            this.lblAviso = new System.Windows.Forms.Label();
            this.pCabecalho = new System.Windows.Forms.Panel();
            this.lblCabecalho5 = new System.Windows.Forms.Label();
            this.lblCabecalho4 = new System.Windows.Forms.Label();
            this.lblCabecalho3 = new System.Windows.Forms.Label();
            this.lblCabecalho2 = new System.Windows.Forms.Label();
            this.lblCabecalho1 = new System.Windows.Forms.Label();
            this.pnBarraDeCima = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbFechar = new System.Windows.Forms.PictureBox();
            this.pbInteressado = new System.Windows.Forms.PictureBox();
            this.pbEdicao = new System.Windows.Forms.PictureBox();
            this.pbLixeira = new System.Windows.Forms.PictureBox();
            this.p_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            this.pLixeira.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.pCabecalho.SuspendLayout();
            this.pnBarraDeCima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInteressado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixeira)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_eventosCriados
            // 
            this.lb_eventosCriados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_eventosCriados.AutoSize = true;
            this.lb_eventosCriados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.lb_eventosCriados.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_eventosCriados.ForeColor = System.Drawing.Color.White;
            this.lb_eventosCriados.Location = new System.Drawing.Point(582, 10);
            this.lb_eventosCriados.Name = "lb_eventosCriados";
            this.lb_eventosCriados.Size = new System.Drawing.Size(250, 56);
            this.lb_eventosCriados.TabIndex = 1;
            this.lb_eventosCriados.Text = "Eventos Criados";
            this.lb_eventosCriados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_eventosCriados.Resize += new System.EventHandler(this.lb_eventosCriados_Resize);
            // 
            // p_barra
            // 
            this.p_barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.p_barra.Controls.Add(this.pbVoltar);
            this.p_barra.Controls.Add(this.lb_eventosCriados);
            this.p_barra.Location = new System.Drawing.Point(0, 21);
            this.p_barra.Name = "p_barra";
            this.p_barra.Size = new System.Drawing.Size(1402, 65);
            this.p_barra.TabIndex = 3;
            this.p_barra.Paint += new System.Windows.Forms.PaintEventHandler(this.p_barra_Paint);
            this.p_barra.Resize += new System.EventHandler(this.p_barra_Resize);
            // 
            // pbVoltar
            // 
            this.pbVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.pbVoltar.Image = global::Pismire_TCC.Properties.Resources.voltar;
            this.pbVoltar.Location = new System.Drawing.Point(32, 18);
            this.pbVoltar.Name = "pbVoltar";
            this.pbVoltar.Size = new System.Drawing.Size(32, 29);
            this.pbVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltar.TabIndex = 2;
            this.pbVoltar.TabStop = false;
            this.pbVoltar.Click += new System.EventHandler(this.pb_voltar_Click);
            this.pbVoltar.MouseEnter += new System.EventHandler(this.pVoltar_MouseEnter);
            this.pbVoltar.MouseLeave += new System.EventHandler(this.pVoltar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pLixeira);
            this.panel2.Controls.Add(this.dt);
            this.panel2.Controls.Add(this.lblAviso);
            this.panel2.Location = new System.Drawing.Point(93, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 455);
            this.panel2.TabIndex = 5;
            // 
            // pLixeira
            // 
            this.pLixeira.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pLixeira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.pLixeira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLixeira.Controls.Add(this.btConfirmar);
            this.pLixeira.Controls.Add(this.btCancelar);
            this.pLixeira.Controls.Add(this.label6);
            this.pLixeira.Controls.Add(this.pictureBox3);
            this.pLixeira.Location = new System.Drawing.Point(410, 85);
            this.pLixeira.Name = "pLixeira";
            this.pLixeira.Size = new System.Drawing.Size(390, 217);
            this.pLixeira.TabIndex = 27;
            this.pLixeira.Visible = false;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.btConfirmar.FlatAppearance.BorderSize = 3;
            this.btConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(189)))), ((int)(((byte)(251)))));
            this.btConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(189)))), ((int)(((byte)(251)))));
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.White;
            this.btConfirmar.Location = new System.Drawing.Point(217, 151);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(100, 36);
            this.btConfirmar.TabIndex = 18;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            this.btConfirmar.MouseEnter += new System.EventHandler(this.btConfirmar_MouseEnter);
            this.btConfirmar.MouseLeave += new System.EventHandler(this.btConfirmar_MouseLeave);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.btCancelar.FlatAppearance.BorderSize = 3;
            this.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(189)))), ((int)(((byte)(251)))));
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(189)))), ((int)(((byte)(251)))));
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(65, 150);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 36);
            this.btCancelar.TabIndex = 17;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            this.btCancelar.MouseEnter += new System.EventHandler(this.btCancelar_MouseEnter);
            this.btCancelar.MouseLeave += new System.EventHandler(this.btCancelar_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "Deseja mesmo excluir este evento?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pismire_TCC.Properties.Resources.excluir;
            this.pictureBox3.Location = new System.Drawing.Point(172, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToResizeColumns = false;
            this.dt.AllowUserToResizeRows = false;
            this.dt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dt.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.ColumnHeadersVisible = false;
            this.dt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dt.EnableHeadersVisualStyles = false;
            this.dt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dt.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dt.Location = new System.Drawing.Point(0, 2);
            this.dt.MultiSelect = false;
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dt.RowHeadersVisible = false;
            this.dt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dt.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dt.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dt.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(15);
            this.dt.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dt.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dt.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.ShowCellErrors = false;
            this.dt.ShowCellToolTips = false;
            this.dt.ShowEditingIcon = false;
            this.dt.ShowRowErrors = false;
            this.dt.Size = new System.Drawing.Size(1232, 452);
            this.dt.TabIndex = 0;
            this.dt.TabStop = false;
            this.dt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellDoubleClick);
            this.dt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dt_KeyDown);
            // 
            // lblAviso
            // 
            this.lblAviso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.White;
            this.lblAviso.Location = new System.Drawing.Point(417, 175);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(383, 62);
            this.lblAviso.TabIndex = 7;
            this.lblAviso.Text = "Nenhum evento criado";
            this.lblAviso.Visible = false;
            // 
            // pCabecalho
            // 
            this.pCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCabecalho.BackColor = System.Drawing.Color.MediumPurple;
            this.pCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCabecalho.Controls.Add(this.lblCabecalho5);
            this.pCabecalho.Controls.Add(this.lblCabecalho4);
            this.pCabecalho.Controls.Add(this.lblCabecalho3);
            this.pCabecalho.Controls.Add(this.lblCabecalho2);
            this.pCabecalho.Controls.Add(this.lblCabecalho1);
            this.pCabecalho.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCabecalho.Location = new System.Drawing.Point(93, 120);
            this.pCabecalho.Name = "pCabecalho";
            this.pCabecalho.Size = new System.Drawing.Size(1232, 62);
            this.pCabecalho.TabIndex = 10;
            this.pCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.pCabecalho_Paint);
            this.pCabecalho.Resize += new System.EventHandler(this.pCabecalho_Resize);
            // 
            // lblCabecalho5
            // 
            this.lblCabecalho5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCabecalho5.Location = new System.Drawing.Point(972, 15);
            this.lblCabecalho5.Name = "lblCabecalho5";
            this.lblCabecalho5.Size = new System.Drawing.Size(256, 43);
            this.lblCabecalho5.TabIndex = 4;
            this.lblCabecalho5.Text = "Turno";
            this.lblCabecalho5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCabecalho4
            // 
            this.lblCabecalho4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCabecalho4.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho4.Location = new System.Drawing.Point(729, 15);
            this.lblCabecalho4.Name = "lblCabecalho4";
            this.lblCabecalho4.Size = new System.Drawing.Size(270, 43);
            this.lblCabecalho4.TabIndex = 3;
            this.lblCabecalho4.Text = "Salário";
            this.lblCabecalho4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCabecalho3
            // 
            this.lblCabecalho3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCabecalho3.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho3.Location = new System.Drawing.Point(486, 15);
            this.lblCabecalho3.Name = "lblCabecalho3";
            this.lblCabecalho3.Size = new System.Drawing.Size(270, 43);
            this.lblCabecalho3.TabIndex = 2;
            this.lblCabecalho3.Text = "Vaga";
            this.lblCabecalho3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCabecalho2
            // 
            this.lblCabecalho2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCabecalho2.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho2.Location = new System.Drawing.Point(243, 15);
            this.lblCabecalho2.Name = "lblCabecalho2";
            this.lblCabecalho2.Size = new System.Drawing.Size(270, 43);
            this.lblCabecalho2.TabIndex = 1;
            this.lblCabecalho2.Text = "Área";
            this.lblCabecalho2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCabecalho1
            // 
            this.lblCabecalho1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCabecalho1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho1.Location = new System.Drawing.Point(2, 15);
            this.lblCabecalho1.Name = "lblCabecalho1";
            this.lblCabecalho1.Size = new System.Drawing.Size(270, 43);
            this.lblCabecalho1.TabIndex = 0;
            this.lblCabecalho1.Text = "Expiração ";
            this.lblCabecalho1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnBarraDeCima
            // 
            this.pnBarraDeCima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBarraDeCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.pnBarraDeCima.Controls.Add(this.pbMinimizar);
            this.pnBarraDeCima.Controls.Add(this.pbMaximizar);
            this.pnBarraDeCima.Controls.Add(this.pbFechar);
            this.pnBarraDeCima.Location = new System.Drawing.Point(0, 0);
            this.pnBarraDeCima.Name = "pnBarraDeCima";
            this.pnBarraDeCima.Size = new System.Drawing.Size(1400, 21);
            this.pnBarraDeCima.TabIndex = 32;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Image = global::Pismire_TCC.Properties.Resources.minimizar;
            this.pbMinimizar.Location = new System.Drawing.Point(1294, 2);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(33, 16);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            this.pbMinimizar.MouseEnter += new System.EventHandler(this.pbMinimizar_MouseEnter);
            this.pbMinimizar.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.Image = global::Pismire_TCC.Properties.Resources.maximizar2;
            this.pbMaximizar.Location = new System.Drawing.Point(1328, 2);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(33, 16);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizar.TabIndex = 1;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            this.pbMaximizar.MouseEnter += new System.EventHandler(this.pbMaximizar_MouseEnter);
            this.pbMaximizar.MouseLeave += new System.EventHandler(this.pbMaximizar_MouseLeave);
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFechar.Image = global::Pismire_TCC.Properties.Resources.fechar1;
            this.pbFechar.Location = new System.Drawing.Point(1362, 2);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(33, 16);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFechar.TabIndex = 0;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            this.pbFechar.MouseEnter += new System.EventHandler(this.pbFechar_MouseEnter);
            this.pbFechar.MouseLeave += new System.EventHandler(this.pbFechar_MouseLeave);
            // 
            // pbInteressado
            // 
            this.pbInteressado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInteressado.Image = global::Pismire_TCC.Properties.Resources.interessados;
            this.pbInteressado.Location = new System.Drawing.Point(1146, 674);
            this.pbInteressado.Name = "pbInteressado";
            this.pbInteressado.Size = new System.Drawing.Size(40, 43);
            this.pbInteressado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInteressado.TabIndex = 33;
            this.pbInteressado.TabStop = false;
            this.pbInteressado.Click += new System.EventHandler(this.pbInteressado_Click);
            this.pbInteressado.MouseEnter += new System.EventHandler(this.pbInteressado_MouseEnter);
            this.pbInteressado.MouseLeave += new System.EventHandler(this.pbInteressado_MouseLeave);
            this.pbInteressado.MouseHover += new System.EventHandler(this.pbInteressado_MouseHover);
            // 
            // pbEdicao
            // 
            this.pbEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEdicao.Image = global::Pismire_TCC.Properties.Resources.editar1;
            this.pbEdicao.Location = new System.Drawing.Point(1210, 674);
            this.pbEdicao.Name = "pbEdicao";
            this.pbEdicao.Size = new System.Drawing.Size(36, 43);
            this.pbEdicao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdicao.TabIndex = 7;
            this.pbEdicao.TabStop = false;
            this.pbEdicao.Click += new System.EventHandler(this.pbEdicao_Click);
            this.pbEdicao.MouseEnter += new System.EventHandler(this.pbEdicao_MouseEnter);
            this.pbEdicao.MouseLeave += new System.EventHandler(this.pbEdicao_MouseLeave);
            // 
            // pbLixeira
            // 
            this.pbLixeira.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLixeira.Image = global::Pismire_TCC.Properties.Resources.excluir;
            this.pbLixeira.Location = new System.Drawing.Point(1282, 671);
            this.pbLixeira.Name = "pbLixeira";
            this.pbLixeira.Size = new System.Drawing.Size(36, 46);
            this.pbLixeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLixeira.TabIndex = 6;
            this.pbLixeira.TabStop = false;
            this.pbLixeira.Click += new System.EventHandler(this.pb_apagar_Click);
            this.pbLixeira.MouseEnter += new System.EventHandler(this.pbLixeira_MouseEnter);
            this.pbLixeira.MouseLeave += new System.EventHandler(this.pbLixeira_MouseLeave);
            // 
            // TelaEventosCriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.pbInteressado);
            this.Controls.Add(this.pnBarraDeCima);
            this.Controls.Add(this.pCabecalho);
            this.Controls.Add(this.pbEdicao);
            this.Controls.Add(this.pbLixeira);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.p_barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaEventosCriados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pismire";
            this.p_barra.ResumeLayout(false);
            this.p_barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pLixeira.ResumeLayout(false);
            this.pLixeira.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.pCabecalho.ResumeLayout(false);
            this.pnBarraDeCima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInteressado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLixeira)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_eventosCriados;
        private System.Windows.Forms.PictureBox pbVoltar;
        private System.Windows.Forms.Panel p_barra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.PictureBox pbLixeira;
        private System.Windows.Forms.PictureBox pbEdicao;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel pLixeira;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pCabecalho;
        private System.Windows.Forms.Label lblCabecalho4;
        private System.Windows.Forms.Label lblCabecalho3;
        private System.Windows.Forms.Label lblCabecalho2;
        private System.Windows.Forms.Label lblCabecalho1;
        private System.Windows.Forms.Label lblCabecalho5;
        private System.Windows.Forms.Panel pnBarraDeCima;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbFechar;
        private System.Windows.Forms.PictureBox pbInteressado;
    }
}

