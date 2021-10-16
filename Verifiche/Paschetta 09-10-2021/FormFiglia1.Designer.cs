
namespace Paschetta
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
            this.btnBlitz1 = new System.Windows.Forms.Button();
            this.btnBlitz2 = new System.Windows.Forms.Button();
            this.btnBlitz3 = new System.Windows.Forms.Button();
            this.btnRapid1 = new System.Windows.Forms.Button();
            this.btnRapid2 = new System.Windows.Forms.Button();
            this.btnRapid3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlitz1
            // 
            this.btnBlitz1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlitz1.Location = new System.Drawing.Point(12, 12);
            this.btnBlitz1.Name = "btnBlitz1";
            this.btnBlitz1.Size = new System.Drawing.Size(75, 59);
            this.btnBlitz1.TabIndex = 0;
            this.btnBlitz1.Text = "3 + 2";
            this.btnBlitz1.UseVisualStyleBackColor = false;
            this.btnBlitz1.Click += new System.EventHandler(this.btnBlitz1_Click);
            // 
            // btnBlitz2
            // 
            this.btnBlitz2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlitz2.Location = new System.Drawing.Point(120, 12);
            this.btnBlitz2.Name = "btnBlitz2";
            this.btnBlitz2.Size = new System.Drawing.Size(75, 59);
            this.btnBlitz2.TabIndex = 1;
            this.btnBlitz2.Text = "5 + 0";
            this.btnBlitz2.UseVisualStyleBackColor = false;
            this.btnBlitz2.Click += new System.EventHandler(this.btnBlitz2_Click);
            // 
            // btnBlitz3
            // 
            this.btnBlitz3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlitz3.Location = new System.Drawing.Point(12, 77);
            this.btnBlitz3.Name = "btnBlitz3";
            this.btnBlitz3.Size = new System.Drawing.Size(75, 59);
            this.btnBlitz3.TabIndex = 2;
            this.btnBlitz3.Text = "5 + 3";
            this.btnBlitz3.UseVisualStyleBackColor = false;
            this.btnBlitz3.Click += new System.EventHandler(this.btnBlitz3_Click);
            // 
            // btnRapid1
            // 
            this.btnRapid1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRapid1.Location = new System.Drawing.Point(120, 77);
            this.btnRapid1.Name = "btnRapid1";
            this.btnRapid1.Size = new System.Drawing.Size(75, 59);
            this.btnRapid1.TabIndex = 3;
            this.btnRapid1.Text = "10 + 0";
            this.btnRapid1.UseVisualStyleBackColor = false;
            this.btnRapid1.Click += new System.EventHandler(this.btnRapid1_Click);
            // 
            // btnRapid2
            // 
            this.btnRapid2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRapid2.Location = new System.Drawing.Point(12, 142);
            this.btnRapid2.Name = "btnRapid2";
            this.btnRapid2.Size = new System.Drawing.Size(75, 59);
            this.btnRapid2.TabIndex = 4;
            this.btnRapid2.Text = "10 + 5";
            this.btnRapid2.UseVisualStyleBackColor = false;
            this.btnRapid2.Click += new System.EventHandler(this.btnRapid2_Click);
            // 
            // btnRapid3
            // 
            this.btnRapid3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRapid3.Location = new System.Drawing.Point(120, 142);
            this.btnRapid3.Name = "btnRapid3";
            this.btnRapid3.Size = new System.Drawing.Size(75, 59);
            this.btnRapid3.TabIndex = 5;
            this.btnRapid3.Text = "15 + 10";
            this.btnRapid3.UseVisualStyleBackColor = false;
            this.btnRapid3.Click += new System.EventHandler(this.btnRapid3_Click);
            // 
            // FormFiglia1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 213);
            this.Controls.Add(this.btnRapid3);
            this.Controls.Add(this.btnRapid2);
            this.Controls.Add(this.btnRapid1);
            this.Controls.Add(this.btnBlitz3);
            this.Controls.Add(this.btnBlitz2);
            this.Controls.Add(this.btnBlitz1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormFiglia1";
            this.Text = "FormFiglia1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFiglia1_FormClosing);
            this.Load += new System.EventHandler(this.FormFiglia1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlitz1;
        private System.Windows.Forms.Button btnBlitz2;
        private System.Windows.Forms.Button btnBlitz3;
        private System.Windows.Forms.Button btnRapid1;
        private System.Windows.Forms.Button btnRapid2;
        private System.Windows.Forms.Button btnRapid3;
    }
}