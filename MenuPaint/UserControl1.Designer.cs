namespace MenuPaint
{
    partial class BarraHerramientas
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarraHerramientas));
            this.Colores = new System.Windows.Forms.Button();
            this.Cubeta = new System.Windows.Forms.Button();
            this.Lapiz = new System.Windows.Forms.Button();
            this.Borrador = new System.Windows.Forms.Button();
            this.Linea = new System.Windows.Forms.Button();
            this.Rect = new System.Windows.Forms.Button();
            this.Circulo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Colores
            // 
            this.Colores.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Colores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Colores.BackgroundImage")));
            this.Colores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Colores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Colores.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Colores.Location = new System.Drawing.Point(15, 18);
            this.Colores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Colores.Name = "Colores";
            this.Colores.Size = new System.Drawing.Size(75, 81);
            this.Colores.TabIndex = 0;
            this.Colores.UseVisualStyleBackColor = false;
            // 
            // Cubeta
            // 
            this.Cubeta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cubeta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cubeta.BackgroundImage")));
            this.Cubeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cubeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cubeta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cubeta.Location = new System.Drawing.Point(102, 18);
            this.Cubeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cubeta.Name = "Cubeta";
            this.Cubeta.Size = new System.Drawing.Size(75, 81);
            this.Cubeta.TabIndex = 1;
            this.Cubeta.UseVisualStyleBackColor = false;
            this.Cubeta.Click += new System.EventHandler(this.Cubeta_Click);
            // 
            // Lapiz
            // 
            this.Lapiz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lapiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lapiz.BackgroundImage")));
            this.Lapiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lapiz.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lapiz.Location = new System.Drawing.Point(191, 18);
            this.Lapiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lapiz.Name = "Lapiz";
            this.Lapiz.Size = new System.Drawing.Size(75, 81);
            this.Lapiz.TabIndex = 2;
            this.Lapiz.UseVisualStyleBackColor = false;
            this.Lapiz.Click += new System.EventHandler(this.Lapiz_Click);
            this.Lapiz.Paint += new System.Windows.Forms.PaintEventHandler(this.LapizPaint);
            this.Lapiz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lapiz_ClickDown);
            this.Lapiz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lapiz_ClickMove);
            this.Lapiz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lapiz_ClickUp);
            // 
            // Borrador
            // 
            this.Borrador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Borrador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Borrador.BackgroundImage")));
            this.Borrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Borrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrador.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Borrador.Location = new System.Drawing.Point(281, 18);
            this.Borrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Borrador.Name = "Borrador";
            this.Borrador.Size = new System.Drawing.Size(75, 81);
            this.Borrador.TabIndex = 3;
            this.Borrador.UseVisualStyleBackColor = false;
            this.Borrador.Click += new System.EventHandler(this.Borrador_Click);
            // 
            // Linea
            // 
            this.Linea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Linea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Linea.BackgroundImage")));
            this.Linea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Linea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Linea.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Linea.Location = new System.Drawing.Point(373, 18);
            this.Linea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(75, 81);
            this.Linea.TabIndex = 4;
            this.Linea.UseVisualStyleBackColor = false;
            this.Linea.Click += new System.EventHandler(this.Linea_Click);
            // 
            // Rect
            // 
            this.Rect.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rect.BackgroundImage")));
            this.Rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Rect.Location = new System.Drawing.Point(465, 18);
            this.Rect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rect.Name = "Rect";
            this.Rect.Size = new System.Drawing.Size(75, 81);
            this.Rect.TabIndex = 5;
            this.Rect.UseVisualStyleBackColor = false;
            this.Rect.Click += new System.EventHandler(this.Rect_Click);
            // 
            // Circulo
            // 
            this.Circulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Circulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Circulo.BackgroundImage")));
            this.Circulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Circulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Circulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Circulo.Location = new System.Drawing.Point(559, 18);
            this.Circulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Circulo.Name = "Circulo";
            this.Circulo.Size = new System.Drawing.Size(75, 81);
            this.Circulo.TabIndex = 6;
            this.Circulo.UseVisualStyleBackColor = false;
            this.Circulo.Click += new System.EventHandler(this.Circulo_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardar.Location = new System.Drawing.Point(692, 18);
            this.Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(87, 40);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "GUARDAR";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.button8_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nuevo.Location = new System.Drawing.Point(692, 63);
            this.Nuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(87, 40);
            this.Nuevo.TabIndex = 8;
            this.Nuevo.Text = "NUEVO";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // BarraHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Circulo);
            this.Controls.Add(this.Rect);
            this.Controls.Add(this.Linea);
            this.Controls.Add(this.Borrador);
            this.Controls.Add(this.Lapiz);
            this.Controls.Add(this.Cubeta);
            this.Controls.Add(this.Colores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BarraHerramientas";
            this.Size = new System.Drawing.Size(817, 122);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Colores;
        private System.Windows.Forms.Button Cubeta;
        private System.Windows.Forms.Button Lapiz;
        private System.Windows.Forms.Button Borrador;
        private System.Windows.Forms.Button Linea;
        private System.Windows.Forms.Button Rect;
        private System.Windows.Forms.Button Circulo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Nuevo;
    }
}
