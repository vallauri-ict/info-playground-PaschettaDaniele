namespace Esercizio_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeggiValore = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnF2ApriFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SONO LA FORM 2";
            // 
            // btnLeggiValore
            // 
            this.btnLeggiValore.Location = new System.Drawing.Point(45, 70);
            this.btnLeggiValore.Name = "btnLeggiValore";
            this.btnLeggiValore.Size = new System.Drawing.Size(96, 41);
            this.btnLeggiValore.TabIndex = 1;
            this.btnLeggiValore.Text = "Leggi valore del txt";
            this.btnLeggiValore.UseVisualStyleBackColor = true;
            this.btnLeggiValore.Click += new System.EventHandler(this.btnLeggiValore_Click);
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(45, 135);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(100, 20);
            this.txtF2.TabIndex = 2;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(162, 131);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(87, 27);
            this.btnInvia.TabIndex = 3;
            this.btnInvia.Text = "Invia a Form1";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // btnF2ApriFiglia
            // 
            this.btnF2ApriFiglia.Location = new System.Drawing.Point(45, 187);
            this.btnF2ApriFiglia.Name = "btnF2ApriFiglia";
            this.btnF2ApriFiglia.Size = new System.Drawing.Size(94, 33);
            this.btnF2ApriFiglia.TabIndex = 4;
            this.btnF2ApriFiglia.Text = "Apri form figlia";
            this.btnF2ApriFiglia.UseVisualStyleBackColor = true;
            this.btnF2ApriFiglia.Click += new System.EventHandler(this.btnF2ApriFiglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 248);
            this.Controls.Add(this.btnF2ApriFiglia);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.btnLeggiValore);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeggiValore;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnF2ApriFiglia;
    }
}