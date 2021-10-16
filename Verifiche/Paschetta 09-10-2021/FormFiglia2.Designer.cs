
namespace Paschetta
{
    partial class FormFiglia2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCasuale = new System.Windows.Forms.RadioButton();
            this.rbBianco = new System.Windows.Forms.RadioButton();
            this.rbNero = new System.Windows.Forms.RadioButton();
            this.btnInizia = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCasuale);
            this.groupBox1.Controls.Add(this.rbBianco);
            this.groupBox1.Controls.Add(this.rbNero);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scelta colore: ";
            // 
            // rbCasuale
            // 
            this.rbCasuale.AutoSize = true;
            this.rbCasuale.Location = new System.Drawing.Point(13, 79);
            this.rbCasuale.Name = "rbCasuale";
            this.rbCasuale.Size = new System.Drawing.Size(63, 17);
            this.rbCasuale.TabIndex = 2;
            this.rbCasuale.TabStop = true;
            this.rbCasuale.Text = "Casuale";
            this.rbCasuale.UseVisualStyleBackColor = true;
            this.rbCasuale.Click += new System.EventHandler(this.rbCasuale_Click);
            // 
            // rbBianco
            // 
            this.rbBianco.AutoSize = true;
            this.rbBianco.Location = new System.Drawing.Point(13, 56);
            this.rbBianco.Name = "rbBianco";
            this.rbBianco.Size = new System.Drawing.Size(58, 17);
            this.rbBianco.TabIndex = 1;
            this.rbBianco.TabStop = true;
            this.rbBianco.Text = "Bianco";
            this.rbBianco.UseVisualStyleBackColor = true;
            this.rbBianco.Click += new System.EventHandler(this.rbBianco_Click);
            // 
            // rbNero
            // 
            this.rbNero.AutoSize = true;
            this.rbNero.Location = new System.Drawing.Point(13, 33);
            this.rbNero.Name = "rbNero";
            this.rbNero.Size = new System.Drawing.Size(48, 17);
            this.rbNero.TabIndex = 0;
            this.rbNero.TabStop = true;
            this.rbNero.Text = "Nero";
            this.rbNero.UseVisualStyleBackColor = true;
            this.rbNero.Click += new System.EventHandler(this.rbNero_Click);
            // 
            // btnInizia
            // 
            this.btnInizia.Location = new System.Drawing.Point(110, 143);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(81, 43);
            this.btnInizia.TabIndex = 1;
            this.btnInizia.Text = "INIZIA";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(12, 143);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(81, 43);
            this.btnAnnulla.TabIndex = 2;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // FormFiglia2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 189);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnInizia);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormFiglia2";
            this.Text = "FormFiglia2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFiglia2_FormClosing);
            this.Load += new System.EventHandler(this.FormFiglia2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCasuale;
        private System.Windows.Forms.RadioButton rbBianco;
        private System.Windows.Forms.RadioButton rbNero;
        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.Button btnAnnulla;
    }
}