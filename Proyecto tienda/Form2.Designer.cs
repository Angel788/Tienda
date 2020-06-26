namespace Proyecto_tienda
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tienda_button = new System.Windows.Forms.Button();
            this.tienda_provedor = new System.Windows.Forms.Button();
            this.bt_Almacen = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Panel();
            this.mini = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.menu_index = new System.Windows.Forms.PictureBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Controls.Add(this.tienda_button);
            this.menu.Controls.Add(this.tienda_provedor);
            this.menu.Controls.Add(this.bt_Almacen);
            this.menu.Controls.Add(this.button5);
            this.menu.Controls.Add(this.button4);
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(263, 650);
            this.menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Proyecto_tienda.Properties.Resources.ventas;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tienda_button
            // 
            this.tienda_button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tienda_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tienda_button.FlatAppearance.BorderSize = 0;
            this.tienda_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.tienda_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.tienda_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tienda_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tienda_button.Location = new System.Drawing.Point(3, 133);
            this.tienda_button.Name = "tienda_button";
            this.tienda_button.Size = new System.Drawing.Size(260, 46);
            this.tienda_button.TabIndex = 2;
            this.tienda_button.Text = "TIEDNA";
            this.tienda_button.UseVisualStyleBackColor = false;
            this.tienda_button.Click += new System.EventHandler(this.tienda_button_Click);
            // 
            // tienda_provedor
            // 
            this.tienda_provedor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tienda_provedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tienda_provedor.FlatAppearance.BorderSize = 0;
            this.tienda_provedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.tienda_provedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.tienda_provedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tienda_provedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tienda_provedor.Location = new System.Drawing.Point(3, 185);
            this.tienda_provedor.Name = "tienda_provedor";
            this.tienda_provedor.Size = new System.Drawing.Size(260, 46);
            this.tienda_provedor.TabIndex = 7;
            this.tienda_provedor.Text = "PROVEDOR";
            this.tienda_provedor.UseVisualStyleBackColor = false;
            this.tienda_provedor.Click += new System.EventHandler(this.button6_Click);
            // 
            // bt_Almacen
            // 
            this.bt_Almacen.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bt_Almacen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Almacen.FlatAppearance.BorderSize = 0;
            this.bt_Almacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.bt_Almacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.bt_Almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Almacen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Almacen.Location = new System.Drawing.Point(3, 237);
            this.bt_Almacen.Name = "bt_Almacen";
            this.bt_Almacen.Size = new System.Drawing.Size(260, 46);
            this.bt_Almacen.TabIndex = 8;
            this.bt_Almacen.Text = "ALMACEN";
            this.bt_Almacen.UseVisualStyleBackColor = false;
            this.bt_Almacen.Click += new System.EventHandler(this.bt_Almacen_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(3, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "ENVIO";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(3, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "CATALOGO";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(3, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "CLIENTE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(3, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "CARRITO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.titulo.Controls.Add(this.mini);
            this.titulo.Controls.Add(this.cerrar);
            this.titulo.Controls.Add(this.menu_index);
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Location = new System.Drawing.Point(263, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1037, 104);
            this.titulo.TabIndex = 1;
            this.titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseDown);
            this.titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseMove);
            this.titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titulo_MouseUp);
            // 
            // mini
            // 
            this.mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mini.Image = global::Proyecto_tienda.Properties.Resources.minimazar;
            this.mini.Location = new System.Drawing.Point(917, 14);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(50, 14);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini.TabIndex = 7;
            this.mini.TabStop = false;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.Image = global::Proyecto_tienda.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(982, 13);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(31, 15);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 5;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // menu_index
            // 
            this.menu_index.Image = global::Proyecto_tienda.Properties.Resources.Mobile_Menu_Icon;
            this.menu_index.Location = new System.Drawing.Point(16, 25);
            this.menu_index.Name = "menu_index";
            this.menu_index.Size = new System.Drawing.Size(59, 50);
            this.menu_index.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_index.TabIndex = 0;
            this.menu_index.TabStop = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(263, 104);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(1037, 546);
            this.axShockwaveFlash1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_tienda.Properties.Resources.descarga__2_;
            this.pictureBox2.Location = new System.Drawing.Point(295, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(981, 489);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titulo;
        private System.Windows.Forms.PictureBox menu_index;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.Button tienda_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button tienda_provedor;
        private System.Windows.Forms.Button bt_Almacen;
        public System.Windows.Forms.FlowLayoutPanel menu;
        private System.Diagnostics.EventLog eventLog1;
        private System.Diagnostics.EventLog eventLog2;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}