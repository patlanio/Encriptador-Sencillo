namespace Encriptador_XP
{
    partial class frmEncriptador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncriptador));
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblMensajeAccion = new System.Windows.Forms.Label();
            this.pnlElementosMoviles = new System.Windows.Forms.Panel();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.pnlElementosMoviles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(127, 36);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(246, 371);
            this.txtMensaje.TabIndex = 1;
            // 
            // lblMensajeAccion
            // 
            this.lblMensajeAccion.AutoSize = true;
            this.lblMensajeAccion.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblMensajeAccion.ForeColor = System.Drawing.Color.White;
            this.lblMensajeAccion.Location = new System.Drawing.Point(121, 0);
            this.lblMensajeAccion.Name = "lblMensajeAccion";
            this.lblMensajeAccion.Size = new System.Drawing.Size(198, 33);
            this.lblMensajeAccion.TabIndex = 9;
            this.lblMensajeAccion.Text = "Introduce texto";
            // 
            // pnlElementosMoviles
            // 
            this.pnlElementosMoviles.Controls.Add(this.btnDesencriptar);
            this.pnlElementosMoviles.Controls.Add(this.btnVolver);
            this.pnlElementosMoviles.Controls.Add(this.btnAbrir);
            this.pnlElementosMoviles.Controls.Add(this.btnRestablecer);
            this.pnlElementosMoviles.Controls.Add(this.btnEncriptar);
            this.pnlElementosMoviles.Controls.Add(this.btnGuardar);
            this.pnlElementosMoviles.Controls.Add(this.txtMensaje);
            this.pnlElementosMoviles.Controls.Add(this.lblMensajeAccion);
            this.pnlElementosMoviles.Font = new System.Drawing.Font("Tahoma", 11F);
            this.pnlElementosMoviles.Location = new System.Drawing.Point(10, 110);
            this.pnlElementosMoviles.Name = "pnlElementosMoviles";
            this.pnlElementosMoviles.Size = new System.Drawing.Size(500, 407);
            this.pnlElementosMoviles.TabIndex = 9;
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDesencriptar.BackgroundImage = global::Encriptador_XP.Properties.Resources.padlock_openw;
            this.btnDesencriptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDesencriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesencriptar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDesencriptar.ForeColor = System.Drawing.Color.White;
            this.btnDesencriptar.Location = new System.Drawing.Point(1, 162);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(120, 120);
            this.btnDesencriptar.TabIndex = 3;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDesencriptar.UseVisualStyleBackColor = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVolver.BackgroundImage = global::Encriptador_XP.Properties.Resources.backward;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(379, 288);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 120);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbrir.BackgroundImage = global::Encriptador_XP.Properties.Resources.file_import;
            this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(1, 284);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(120, 120);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir archivo";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRestablecer.BackgroundImage = global::Encriptador_XP.Properties.Resources.window_close_1_;
            this.btnRestablecer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnRestablecer.ForeColor = System.Drawing.Color.White;
            this.btnRestablecer.Location = new System.Drawing.Point(379, 162);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(120, 120);
            this.btnRestablecer.TabIndex = 6;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEncriptar.BackgroundImage = global::Encriptador_XP.Properties.Resources.padlock_closedw;
            this.btnEncriptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEncriptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncriptar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnEncriptar.ForeColor = System.Drawing.Color.White;
            this.btnEncriptar.Location = new System.Drawing.Point(1, 36);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(120, 120);
            this.btnEncriptar.TabIndex = 2;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.BackgroundImage = global::Encriptador_XP.Properties.Resources.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(379, 36);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 120);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblPath.ForeColor = System.Drawing.Color.White;
            this.lblPath.Location = new System.Drawing.Point(10, 530);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 18);
            this.lblPath.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 42F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 68);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Encriptador";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(53, 69);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(78, 33);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(137, 80);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(246, 20);
            this.txtClave.TabIndex = 0;
            // 
            // frmEncriptador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(389, 561);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.pnlElementosMoviles);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEncriptador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encriptador";
            this.pnlElementosMoviles.ResumeLayout(false);
            this.pnlElementosMoviles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblMensajeAccion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlElementosMoviles;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
    }
}

