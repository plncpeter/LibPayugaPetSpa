namespace LibPayugaPetSpa
{
    partial class Form1
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
            this.lblTituloCaixa = new System.Windows.Forms.Label();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.lblTituloServicos = new System.Windows.Forms.Label();
            this.lblTituloBemvindo = new System.Windows.Forms.Label();
            this.lblTituloEscrita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnMenuTipo = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.btnPetsCad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCaixa
            // 
            this.lblTituloCaixa.AutoSize = true;
            this.lblTituloCaixa.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 11.75F);
            this.lblTituloCaixa.Location = new System.Drawing.Point(708, 461);
            this.lblTituloCaixa.Name = "lblTituloCaixa";
            this.lblTituloCaixa.Size = new System.Drawing.Size(46, 20);
            this.lblTituloCaixa.TabIndex = 3;
            this.lblTituloCaixa.Text = "Caixa";
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 11.75F);
            this.lblTituloClientes.Location = new System.Drawing.Point(439, 277);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(68, 20);
            this.lblTituloClientes.TabIndex = 4;
            this.lblTituloClientes.Text = "Clientes ";
            // 
            // lblTituloServicos
            // 
            this.lblTituloServicos.AutoSize = true;
            this.lblTituloServicos.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 11.75F);
            this.lblTituloServicos.Location = new System.Drawing.Point(197, 277);
            this.lblTituloServicos.Name = "lblTituloServicos";
            this.lblTituloServicos.Size = new System.Drawing.Size(66, 20);
            this.lblTituloServicos.TabIndex = 5;
            this.lblTituloServicos.Text = "Serviços";
            // 
            // lblTituloBemvindo
            // 
            this.lblTituloBemvindo.AutoSize = true;
            this.lblTituloBemvindo.Font = new System.Drawing.Font("Humnst777 Lt BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBemvindo.Location = new System.Drawing.Point(155, 50);
            this.lblTituloBemvindo.Name = "lblTituloBemvindo";
            this.lblTituloBemvindo.Size = new System.Drawing.Size(208, 39);
            this.lblTituloBemvindo.TabIndex = 6;
            this.lblTituloBemvindo.Text = "Olá, PetLover!";
            // 
            // lblTituloEscrita
            // 
            this.lblTituloEscrita.AutoSize = true;
            this.lblTituloEscrita.Font = new System.Drawing.Font("Humnst777 Lt BT", 14F);
            this.lblTituloEscrita.Location = new System.Drawing.Point(158, 101);
            this.lblTituloEscrita.Name = "lblTituloEscrita";
            this.lblTituloEscrita.Size = new System.Drawing.Size(211, 22);
            this.lblTituloEscrita.TabIndex = 7;
            this.lblTituloEscrita.Text = "O que iremos fazer hoje?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 11.75F);
            this.label1.Location = new System.Drawing.Point(707, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pets";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 11.75F);
            this.lblComanda.Location = new System.Drawing.Point(433, 461);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(81, 20);
            this.lblComanda.TabIndex = 13;
            this.lblComanda.Text = "Comandas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 11.75F);
            this.lblTipo.Location = new System.Drawing.Point(185, 461);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(88, 20);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Tipo do Pet";
            // 
            // btnMenuTipo
            // 
            this.btnMenuTipo.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.pet_hotel;
            this.btnMenuTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTipo.Location = new System.Drawing.Point(162, 331);
            this.btnMenuTipo.Name = "btnMenuTipo";
            this.btnMenuTipo.Size = new System.Drawing.Size(135, 127);
            this.btnMenuTipo.TabIndex = 11;
            this.btnMenuTipo.UseVisualStyleBackColor = true;
            this.btnMenuTipo.Click += new System.EventHandler(this.btnMenuTipo_Click);
            // 
            // btnComanda
            // 
            this.btnComanda.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.pet_shop;
            this.btnComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComanda.Location = new System.Drawing.Point(405, 331);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(135, 127);
            this.btnComanda.TabIndex = 10;
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnPetsCad
            // 
            this.btnPetsCad.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.pets;
            this.btnPetsCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPetsCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetsCad.Location = new System.Drawing.Point(661, 147);
            this.btnPetsCad.Name = "btnPetsCad";
            this.btnPetsCad.Size = new System.Drawing.Size(135, 127);
            this.btnPetsCad.TabIndex = 9;
            this.btnPetsCad.UseVisualStyleBackColor = true;
            this.btnPetsCad.Click += new System.EventHandler(this.btnPetsCad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.sloth;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(727, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 68);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources._4090440;
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Location = new System.Drawing.Point(661, 331);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(135, 127);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.adoption;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(405, 147);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(135, 127);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.BackgroundImage = global::LibPayugaPetSpa.Properties.Resources.online_shop;
            this.btnServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Location = new System.Drawing.Point(162, 147);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(135, 127);
            this.btnServicos.TabIndex = 0;
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnMenuTipo);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.btnPetsCad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTituloEscrita);
            this.Controls.Add(this.lblTituloBemvindo);
            this.Controls.Add(this.lblTituloServicos);
            this.Controls.Add(this.lblTituloClientes);
            this.Controls.Add(this.lblTituloCaixa);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnServicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Label lblTituloCaixa;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Label lblTituloServicos;
        private System.Windows.Forms.Label lblTituloBemvindo;
        private System.Windows.Forms.Label lblTituloEscrita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnMenuTipo;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Button btnPetsCad;
    }
}

