namespace LibPayugaPetSpa.Formularios
{
    partial class MenuPet
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
            this.grbEditarApagar = new System.Windows.Forms.GroupBox();
            this.cmbDonoEdit = new System.Windows.Forms.ComboBox();
            this.cmbPetEdit = new System.Windows.Forms.ComboBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNomeEdit = new System.Windows.Forms.TextBox();
            this.lblEditar2 = new System.Windows.Forms.Label();
            this.lblEditar1 = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.cmbDonoCad = new System.Windows.Forms.ComboBox();
            this.cmbPetCad = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblCadastro2 = new System.Windows.Forms.Label();
            this.lblCadastro1 = new System.Windows.Forms.Label();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.grbEditarApagar.SuspendLayout();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEditarApagar
            // 
            this.grbEditarApagar.Controls.Add(this.cmbDonoEdit);
            this.grbEditarApagar.Controls.Add(this.cmbPetEdit);
            this.grbEditarApagar.Controls.Add(this.btnApagar);
            this.grbEditarApagar.Controls.Add(this.btnEditar);
            this.grbEditarApagar.Controls.Add(this.txtNomeEdit);
            this.grbEditarApagar.Controls.Add(this.lblEditar2);
            this.grbEditarApagar.Controls.Add(this.lblEditar1);
            this.grbEditarApagar.Enabled = false;
            this.grbEditarApagar.Location = new System.Drawing.Point(487, 305);
            this.grbEditarApagar.Name = "grbEditarApagar";
            this.grbEditarApagar.Size = new System.Drawing.Size(396, 179);
            this.grbEditarApagar.TabIndex = 10;
            this.grbEditarApagar.TabStop = false;
            this.grbEditarApagar.Text = "Editar / Apagar";
            // 
            // cmbDonoEdit
            // 
            this.cmbDonoEdit.FormattingEnabled = true;
            this.cmbDonoEdit.Location = new System.Drawing.Point(171, 102);
            this.cmbDonoEdit.Name = "cmbDonoEdit";
            this.cmbDonoEdit.Size = new System.Drawing.Size(200, 21);
            this.cmbDonoEdit.TabIndex = 14;
            // 
            // cmbPetEdit
            // 
            this.cmbPetEdit.FormattingEnabled = true;
            this.cmbPetEdit.Location = new System.Drawing.Point(171, 65);
            this.cmbPetEdit.Name = "cmbPetEdit";
            this.cmbPetEdit.Size = new System.Drawing.Size(200, 21);
            this.cmbPetEdit.TabIndex = 11;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(171, 136);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(100, 23);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar Pet";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(277, 136);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar Pet";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.lblEditar2.Size = new System.Drawing.Size(62, 13);
            this.lblEditar2.TabIndex = 1;
            this.lblEditar2.Text = "Tipo do Pet";
            // 
            // lblEditar1
            // 
            this.lblEditar1.AutoSize = true;
            this.lblEditar1.Location = new System.Drawing.Point(19, 32);
            this.lblEditar1.Name = "lblEditar1";
            this.lblEditar1.Size = new System.Drawing.Size(69, 13);
            this.lblEditar1.TabIndex = 0;
            this.lblEditar1.Text = "Nome do Pet";
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.cmbDonoCad);
            this.grbCliente.Controls.Add(this.cmbPetCad);
            this.grbCliente.Controls.Add(this.btnCadastrar);
            this.grbCliente.Controls.Add(this.txtNomeCad);
            this.grbCliente.Controls.Add(this.lblCadastro2);
            this.grbCliente.Controls.Add(this.lblCadastro1);
            this.grbCliente.Location = new System.Drawing.Point(487, 66);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(396, 179);
            this.grbCliente.TabIndex = 9;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cadastrar";
            // 
            // cmbDonoCad
            // 
            this.cmbDonoCad.FormattingEnabled = true;
            this.cmbDonoCad.Location = new System.Drawing.Point(171, 107);
            this.cmbDonoCad.Name = "cmbDonoCad";
            this.cmbDonoCad.Size = new System.Drawing.Size(200, 21);
            this.cmbDonoCad.TabIndex = 13;
            // 
            // cmbPetCad
            // 
            this.cmbPetCad.FormattingEnabled = true;
            this.cmbPetCad.Location = new System.Drawing.Point(171, 68);
            this.cmbPetCad.Name = "cmbPetCad";
            this.cmbPetCad.Size = new System.Drawing.Size(200, 21);
            this.cmbPetCad.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(277, 141);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.lblCadastro2.Size = new System.Drawing.Size(62, 13);
            this.lblCadastro2.TabIndex = 1;
            this.lblCadastro2.Text = "Tipo do Pet";
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
            // dgvPet
            // 
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Location = new System.Drawing.Point(55, 44);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.Size = new System.Drawing.Size(386, 496);
            this.dgvPet.TabIndex = 8;
            this.dgvPet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPet_CellClick);
            // 
            // MenuPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 587);
            this.Controls.Add(this.grbEditarApagar);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.dgvPet);
            this.Name = "MenuPet";
            this.Text = "MenuPet";
            this.grbEditarApagar.ResumeLayout(false);
            this.grbEditarApagar.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEditarApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNomeEdit;
        private System.Windows.Forms.Label lblEditar2;
        private System.Windows.Forms.Label lblEditar1;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblCadastro2;
        private System.Windows.Forms.Label lblCadastro1;
        private System.Windows.Forms.DataGridView dgvPet;
        private System.Windows.Forms.ComboBox cmbPetEdit;
        private System.Windows.Forms.ComboBox cmbPetCad;
        private System.Windows.Forms.ComboBox cmbDonoCad;
        private System.Windows.Forms.ComboBox cmbDonoEdit;
    }
}