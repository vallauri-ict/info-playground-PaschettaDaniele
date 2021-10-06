
namespace ES_03___Preparazione_Verifica_MultiForm
{
    partial class FormEsci
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
            this.BtnAnulla = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SICURO DI CHIUDERE IL PROGRAMMA?";
            // 
            // BtnAnulla
            // 
            this.BtnAnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAnulla.Location = new System.Drawing.Point(3, 43);
            this.BtnAnulla.Name = "BtnAnulla";
            this.BtnAnulla.Size = new System.Drawing.Size(111, 23);
            this.BtnAnulla.TabIndex = 1;
            this.BtnAnulla.Text = "ANNULLA";
            this.BtnAnulla.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(120, 43);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(111, 23);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "SI";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // FormEsci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 73);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnAnulla);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEsci";
            this.Text = "FormEsci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAnulla;
        private System.Windows.Forms.Button BtnOk;
    }
}