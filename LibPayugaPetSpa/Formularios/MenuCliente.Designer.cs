namespace LibPayugaPetSpa.Formularios
{
    partial class MenuCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTelefoneCad = new System.Windows.Forms.TextBox();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblCadastro2 = new System.Windows.Forms.Label();
            this.lblCadastro1 = new System.Windows.Forms.Label();
            this.grbEditarApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtTelefoneEdit = new System.Windows.Forms.TextBox();
            this.txtNomeEdit = new System.Windows.Forms.TextBox();
            this.lblEditar2 = new System.Windows.Forms.Label();
            this.lblEditar1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grbCliente.SuspendLayout();
            this.grbEditarApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(50, 47);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(341, 496);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.btnCadastrar);
            this.grbCliente.Controls.Add(this.txtTelefoneCad);
            this.grbCliente.Controls.Add(this.txtNomeCad);
            this.grbCliente.Controls.Add(this.lblCadastro2);
            this.grbCliente.Controls.Add(this.lblCadastro1);
            this.grbCliente.Location = new System.Drawing.Point(486, 68);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(396, 141);
            this.grbCliente.TabIndex = 1;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(277, 102);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTelefoneCad
            // 
            this.txtTelefoneCad.Location = new System.Drawing.Point(171, 68);
            this.txtTelefoneCad.Name = "txtTelefoneCad";
            this.txtTelefoneCad.Size = new System.Drawing.Size(200, 20);
            this.txtTelefoneCad.TabIndex = 3;
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Location = new System.Drawing.Point(171, 29);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(200, 20);
            this.txtNomeCad.TabIndex = 2;
            // 
            // lblCadastro2
            // 
            this.lblCadastro2.AutoSize = true;
            this.lblCadastro2.Location = new System.Drawing.Point(19, 71);
            this.lblCadastro2.Name = "lblCadastro2";
            this.lblCadastro2.Size = new System.Drawing.Size(99, 13);
            this.lblCadastro2.TabIndex = 1;
            this.lblCadastro2.Text = "Telefone do Cliente";
            // 
            // lblCadastro1
            // 
            this.lblCadastro1.AutoSize = true;
            this.lblCadastro1.Location = new System.Drawing.Point(19, 32);
            this.lblCadastro1.Name = "lblCadastro1";
            this.lblCadastro1.Size = new System.Drawing.Size(85, 13);
            this.lblCadastro1.TabIndex = 0;
            this.lblCadastro1.Text = "Nome do Cliente";
            // 
            // grbEditarApagar
            // 
            this.grbEditarApagar.Controls.Add(this.btnApagar);
            this.grbEditarApagar.Controls.Add(this.btnEditar);
            this.grbEditarApagar.Controls.Add(this.txtTelefoneEdit);
            this.grbEditarApagar.Controls.Add(this.txtNomeEdit);
            this.grbEditarApagar.Controls.Add(this.lblEditar2);
            this.grbEditarApagar.Controls.Add(this.lblEditar1);
            this.grbEditarApagar.Enabled = false;
            this.grbEditarApagar.Location = new System.Drawing.Point(486, 243);
            this.grbEditarApagar.Name = "grbEditarApagar";
            this.grbEditarApagar.Size = new System.Drawing.Size(396, 141);
            this.grbEditarApagar.TabIndex = 5;
            this.grbEditarApagar.TabStop = false;
            this.grbEditarApagar.Text = "Editar / Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(171, 103);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(100, 23);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar Cliente";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(277, 103);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar Cliente";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtTelefoneEdit
            // 
            this.txtTelefoneEdit.Location = new System.Drawing.Point(171, 68);
            this.txtTelefoneEdit.Name = "txtTelefoneEdit";
            this.txtTelefoneEdit.Size = new System.Drawing.Size(200, 20);
            this.txtTelefoneEdit.TabIndex = 3;
            // 
            // txtNomeEdit
            // 
            this.txtNomeEdit.Location = new System.Drawing.Point(171, 29);
            this.txtNomeEdit.Name = "txtNomeEdit";
            this.txtNomeEdit.Size = new System.Drawing.Size(200, 20);
            this.txtNomeEdit.TabIndex = 2;
            // 
            // lblEditar2
            // 
            this.lblEditar2.AutoSize = true;
            this.lblEditar2.Location = new System.Drawing.Point(19, 68);
            this.lblEditar2.Name = "lblEditar2";
            this.lblEditar2.Size = new System.Drawing.Size(99, 13);
            this.lblEditar2.TabIndex = 1;
            this.lblEditar2.Text = "Telefone do Cliente";
            // 
            // lblEditar1
            // 
            this.lblEditar1.AutoSize = true;
            this.lblEditar1.Location = new System.Drawing.Point(19, 32);
            this.lblEditar1.Name = "lblEditar1";
            this.lblEditar1.Size = new System.Drawing.Size(85, 13);
            this.lblEditar1.TabIndex = 0;
            this.lblEditar1.Text = "Nome do Cliente";
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 587);
            this.Controls.Add(this.grbEditarApagar);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.dgvClientes);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbEditarApagar.ResumeLayout(false);
            this.grbEditarApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtTelefoneCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblCadastro2;
        private System.Windows.Forms.Label lblCadastro1;
        private System.Windows.Forms.GroupBox grbEditarApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtTelefoneEdit;
        private System.Windows.Forms.TextBox txtNomeEdit;
        private System.Windows.Forms.Label lblEditar2;
        private System.Windows.Forms.Label lblEditar1;
        private System.Windows.Forms.Button btnApagar;
    }
}