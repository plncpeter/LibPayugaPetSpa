namespace LibPayugaPetSpa.Formularios
{
    partial class MenuCaixa
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
            this.chbPagamentos = new System.Windows.Forms.CheckBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtPet = new System.Windows.Forms.TextBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.pcb111 = new System.Windows.Forms.PictureBox();
            this.lblAAA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb111)).BeginInit();
            this.SuspendLayout();
            // 
            // chbPagamentos
            // 
            this.chbPagamentos.AutoSize = true;
            this.chbPagamentos.BackColor = System.Drawing.Color.Transparent;
            this.chbPagamentos.Font = new System.Drawing.Font("Humnst777 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentos.Location = new System.Drawing.Point(566, 357);
            this.chbPagamentos.Name = "chbPagamentos";
            this.chbPagamentos.Size = new System.Drawing.Size(168, 23);
            this.chbPagamentos.TabIndex = 12;
            this.chbPagamentos.Text = "Pagamento recebido";
            this.chbPagamentos.UseVisualStyleBackColor = false;
            this.chbPagamentos.CheckedChanged += new System.EventHandler(this.chbPagamentos_CheckedChanged_1);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Humnst777 Lt BT", 17.25F);
            this.lblValor.Location = new System.Drawing.Point(560, 331);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 27);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "R$";
            // 
            // dgvComanda
            // 
            this.dgvComanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.ColumnHeadersVisible = false;
            this.dgvComanda.Location = new System.Drawing.Point(55, 68);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.Size = new System.Drawing.Size(691, 248);
            this.dgvComanda.TabIndex = 10;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Humnst777 BT", 10.25F);
            this.btnListar.Location = new System.Drawing.Point(649, 22);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(97, 35);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtPet
            // 
            this.txtPet.Font = new System.Drawing.Font("Humnst777 Lt BT", 17.25F);
            this.txtPet.Location = new System.Drawing.Point(500, 22);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(143, 35);
            this.txtPet.TabIndex = 8;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.BackColor = System.Drawing.Color.Transparent;
            this.lblComanda.Font = new System.Drawing.Font("Humnst777 Lt BT", 17.25F);
            this.lblComanda.Location = new System.Drawing.Point(424, 25);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(74, 27);
            this.lblComanda.TabIndex = 7;
            this.lblComanda.Text = "Nº Pet";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.cash;
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Font = new System.Drawing.Font("Humnst777 BT", 11.25F);
            this.btnEncerrar.Location = new System.Drawing.Point(566, 386);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(168, 42);
            this.btnEncerrar.TabIndex = 13;
            this.btnEncerrar.Text = "Finalizar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click_1);
            // 
            // pcb111
            // 
            this.pcb111.BackColor = System.Drawing.Color.Transparent;
            this.pcb111.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.cash;
            this.pcb111.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb111.Location = new System.Drawing.Point(55, 7);
            this.pcb111.Name = "pcb111";
            this.pcb111.Size = new System.Drawing.Size(63, 58);
            this.pcb111.TabIndex = 14;
            this.pcb111.TabStop = false;
            // 
            // lblAAA
            // 
            this.lblAAA.AutoSize = true;
            this.lblAAA.BackColor = System.Drawing.Color.Transparent;
            this.lblAAA.Font = new System.Drawing.Font("Humnst777 Lt BT", 17.25F);
            this.lblAAA.Location = new System.Drawing.Point(124, 23);
            this.lblAAA.Name = "lblAAA";
            this.lblAAA.Size = new System.Drawing.Size(125, 27);
            this.lblAAA.TabIndex = 15;
            this.lblAAA.Text = "Menu Caixa";
            // 
            // MenuCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.Verde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAAA);
            this.Controls.Add(this.pcb111);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbPagamentos);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtPet);
            this.Controls.Add(this.lblComanda);
            this.Name = "MenuCaixa";
            this.Text = "MenuCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb111)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.CheckBox chbPagamentos;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtPet;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.PictureBox pcb111;
        private System.Windows.Forms.Label lblAAA;
    }
}