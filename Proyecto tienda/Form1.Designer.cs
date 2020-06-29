namespace Proyecto_tienda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu_vertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.mini = new System.Windows.Forms.PictureBox();
            this.maxi = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pasword = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_bd = new System.Windows.Forms.TextBox();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_vertical
            // 
            this.menu_vertical.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_vertical.Controls.Add(this.pictureBox1);
            this.menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_vertical.Location = new System.Drawing.Point(0, 0);
            this.menu_vertical.Name = "menu_vertical";
            this.menu_vertical.Size = new System.Drawing.Size(200, 585);
            this.menu_vertical.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.titulo.Controls.Add(this.restaurar);
            this.titulo.Controls.Add(this.mini);
            this.titulo.Controls.Add(this.maxi);
            this.titulo.Controls.Add(this.cerrar);
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Location = new System.Drawing.Point(200, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1100, 62);
            this.titulo.TabIndex = 1;
            this.titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.titulo_Paint);
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Image = global::Proyecto_tienda.Properties.Resources.maxi;
            this.restaurar.Location = new System.Drawing.Point(934, 13);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(39, 16);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restaurar.TabIndex = 4;
            this.restaurar.TabStop = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // mini
            // 
            this.mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mini.Image = global::Proyecto_tienda.Properties.Resources.minimazar;
            this.mini.Location = new System.Drawing.Point(878, 12);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(50, 15);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 3;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.mini_Click_1);
            // 
            // maxi
            // 
            this.maxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxi.Image = global::Proyecto_tienda.Properties.Resources.maxi;
            this.maxi.Location = new System.Drawing.Point(988, 13);
            this.maxi.Name = "maxi";
            this.maxi.Size = new System.Drawing.Size(39, 16);
            this.maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maxi.TabIndex = 2;
            this.maxi.TabStop = false;
            this.maxi.Click += new System.EventHandler(this.maxi_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Image = global::Proyecto_tienda.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(1045, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(43, 17);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_pasword);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.txt_bd);
            this.panel1.Controls.Add(this.txt_host);
            this.panel1.Location = new System.Drawing.Point(258, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 435);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(585, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 66);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cerrar Conexion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(239, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Iniciar Conexion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "PASWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "BD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOST";
            // 
            // txt_pasword
            // 
            this.txt_pasword.BackColor = System.Drawing.Color.Turquoise;
            this.txt_pasword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pasword.Location = new System.Drawing.Point(321, 199);
            this.txt_pasword.Name = "txt_pasword";
            this.txt_pasword.Size = new System.Drawing.Size(536, 20);
            this.txt_pasword.TabIndex = 3;
            this.txt_pasword.Text = "INTRODUZCA EL PASWORD";
            this.txt_pasword.Enter += new System.EventHandler(this.txt_pasword_Enter);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Turquoise;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(321, 146);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(536, 20);
            this.txt_user.TabIndex = 2;
            this.txt_user.Text = "INTRODUZCA EL USUARIO";
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            // 
            // txt_bd
            // 
            this.txt_bd.BackColor = System.Drawing.Color.Turquoise;
            this.txt_bd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bd.Location = new System.Drawing.Point(321, 97);
            this.txt_bd.Name = "txt_bd";
            this.txt_bd.Size = new System.Drawing.Size(536, 20);
            this.txt_bd.TabIndex = 1;
            this.txt_bd.Text = "INTRODUZCA EL NOMBRE DE LA BASE DE DATOS";
            this.txt_bd.Enter += new System.EventHandler(this.txt_bd_Enter);
            // 
            // txt_host
            // 
            this.txt_host.BackColor = System.Drawing.Color.Turquoise;
            this.txt_host.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_host.Location = new System.Drawing.Point(321, 43);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(536, 20);
            this.txt_host.TabIndex = 0;
            this.txt_host.Text = "INTRODUZCA EL HOST";
            this.txt_host.Enter += new System.EventHandler(this.txt_host_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.menu_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_vertical;
        private System.Windows.Forms.Panel titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox maxi;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.PictureBox restaurar;
        public System.Windows.Forms.TextBox txt_pasword;
        public System.Windows.Forms.TextBox txt_user;
        public System.Windows.Forms.TextBox txt_bd;
        public System.Windows.Forms.TextBox txt_host;
    }
}

