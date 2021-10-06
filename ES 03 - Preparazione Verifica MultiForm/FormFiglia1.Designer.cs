
namespace ES_03___Preparazione_Verifica_MultiForm
{
    partial class FormFiglia1
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
            this.ChbSediliPelle = new System.Windows.Forms.CheckBox();
            this.ChbSediliStoffa = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChbSediliPelle
            // 
            this.ChbSediliPelle.AutoSize = true;
            this.ChbSediliPelle.Location = new System.Drawing.Point(13, 13);
            this.ChbSediliPelle.Name = "ChbSediliPelle";
            this.ChbSediliPelle.Size = new System.Drawing.Size(88, 17);
            this.ChbSediliPelle.TabIndex = 0;
            this.ChbSediliPelle.Text = "Sedili di Pelle";
            this.ChbSediliPelle.UseVisualStyleBackColor = true;
            this.ChbSediliPelle.CheckedChanged += new System.EventHandler(this.ChbSediliPelle_CheckedChanged);
            // 
            // ChbSediliStoffa
            // 
            this.ChbSediliStoffa.AutoSize = true;
            this.ChbSediliStoffa.Location = new System.Drawing.Point(13, 37);
            this.ChbSediliStoffa.Name = "ChbSediliStoffa";
            this.ChbSediliStoffa.Size = new System.Drawing.Size(93, 17);
            this.ChbSediliStoffa.TabIndex = 1;
            this.ChbSediliStoffa.Text = "Sedili di Stoffa";
            this.ChbSediliStoffa.UseVisualStyleBackColor = true;
            this.ChbSediliStoffa.CheckedChanged += new System.EventHandler(this.ChbSediliStoffa_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BMW",
            "FIAT",
            "SEAT",
            "OPEL"});
            this.comboBox1.Location = new System.Drawing.Point(12, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(12, 143);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(96, 23);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FormFiglia1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 178);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ChbSediliStoffa);
            this.Controls.Add(this.ChbSediliPelle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFiglia1";
            this.Text = "FormFiglia1";
            this.Load += new System.EventHandler(this.FormFiglia1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChbSediliPelle;
        private System.Windows.Forms.CheckBox ChbSediliStoffa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnOk;
    }
}