namespace MenuPaint
{
    partial class Form1
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
            this.barraHerramientas1 = new MenuPaint.BarraHerramientas();
            this.SuspendLayout();
            // 
            // barraHerramientas1
            // 
            this.barraHerramientas1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.barraHerramientas1.Location = new System.Drawing.Point(67, 84);
            this.barraHerramientas1.Margin = new System.Windows.Forms.Padding(2);
            this.barraHerramientas1.Name = "barraHerramientas1";
            this.barraHerramientas1.Size = new System.Drawing.Size(877, 141);
            this.barraHerramientas1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.barraHerramientas1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BarraHerramientas barraHerramientas1;
    }
}