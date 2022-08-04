namespace LibPayugaPetSpa.Formularios
{
    partial class MenuTipo
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
            this.dgvTipo = new System.Windows.Forms.DataGridView();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.grbEditarApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNomeEdit = new System.Windows.Forms.TextBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            this.grbTipo.SuspendLayout();
            this.grbEditarApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTipo
            // 
            this.dgvTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipo.Location = new System.Drawing.Point(56, 27);
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.Size = new System.Drawing.Size(289, 199);
            this.dgvTipo.TabIndex = 0;
            this.dgvTipo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipo_CellClick);
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.btnCadastrar);
            this.grbTipo.Controls.Add(this.txtNomeCad);
            this.grbTipo.Controls.Add(this.lblTitulo1);
            this.grbTipo.Location = new System.Drawing.Point(56, 244);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(289, 67);
            this.grbTipo.TabIndex = 1;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(205, 27);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Location = new System.Drawing.Point(63, 28);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(134, 20);
            this.txtNomeCad.TabIndex = 2;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Location = new System.Drawing.Point(19, 31);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(31, 13);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "Tipo:";
            // 
            // grbEditarApagar
            // 
            this.grbEditarApagar.Controls.Add(this.btnApagar);
            this.grbEditarApagar.Controls.Add(this.btnEditar);
            this.grbEditarApagar.Controls.Add(this.txtNomeEdit);
            this.grbEditarApagar.Controls.Add(this.lblTitulo2);
            this.grbEditarApagar.Enabled = false;
            this.grbEditarApagar.Location = new System.Drawing.Point(56, 326);
            this.grbEditarApagar.Name = "grbEditarApagar";
            this.grbEditarApagar.Size = new System.Drawing.Size(289, 67);
            this.grbEditarApagar.TabIndex = 2;
            this.grbEditarApagar.TabStop = false;
            this.grbEditarApagar.Text = "Editar / Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(204, 38);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(204, 11);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNomeEdit
            // 
            this.txtNomeEdit.Location = new System.Drawing.Point(63, 28);
            this.txtNomeEdit.Name = "txtNomeEdit";
            this.txtNomeEdit.Size = new System.Drawing.Size(134, 20);
            this.txtNomeEdit.TabIndex = 3;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Location = new System.Drawing.Point(19, 31);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(31, 13);
            this.lblTitulo2.TabIndex = 0;
            this.lblTitulo2.Text = "Tipo:";
            // 
            // MenuTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 422);
            this.Controls.Add(this.grbEditarApagar);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.dgvTipo);
            this.Name = "MenuTipo";
            this.Text = "MenuTipo";
            this.Load += new System.EventHandler(this.MenuTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.grbEditarApagar.ResumeLayout(false);
            this.grbEditarApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipo;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.GroupBox grbEditarApagar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNomeEdit;
        private System.Windows.Forms.Label lblTitulo2;
    }
}