namespace _18_1_pasibandymai_su_gui
{
    partial class IvestiDuomenisForma
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
            this.textBoxVardas = new System.Windows.Forms.TextBox();
            this.buttonGerai = new System.Windows.Forms.Button();
            this.textBoxAmzius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAtsaukti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "vardas";
            // 
            // textBoxVardas
            // 
            this.textBoxVardas.Location = new System.Drawing.Point(94, 27);
            this.textBoxVardas.Name = "textBoxVardas";
            this.textBoxVardas.Size = new System.Drawing.Size(100, 20);
            this.textBoxVardas.TabIndex = 1;
            // 
            // buttonGerai
            // 
            this.buttonGerai.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGerai.Location = new System.Drawing.Point(32, 92);
            this.buttonGerai.Name = "buttonGerai";
            this.buttonGerai.Size = new System.Drawing.Size(75, 23);
            this.buttonGerai.TabIndex = 2;
            this.buttonGerai.Text = "Gerai";
            this.buttonGerai.UseVisualStyleBackColor = true;
            this.buttonGerai.Click += new System.EventHandler(this.buttonGerai_Click);
            // 
            // textBoxAmzius
            // 
            this.textBoxAmzius.Location = new System.Drawing.Point(94, 53);
            this.textBoxAmzius.Name = "textBoxAmzius";
            this.textBoxAmzius.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmzius.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "amzius";
            // 
            // buttonAtsaukti
            // 
            this.buttonAtsaukti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAtsaukti.Location = new System.Drawing.Point(113, 92);
            this.buttonAtsaukti.Name = "buttonAtsaukti";
            this.buttonAtsaukti.Size = new System.Drawing.Size(75, 23);
            this.buttonAtsaukti.TabIndex = 5;
            this.buttonAtsaukti.Text = "Atsaukti";
            this.buttonAtsaukti.UseVisualStyleBackColor = true;
            // 
            // IvestiDuomenisForma
            // 
            this.AcceptButton = this.buttonGerai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAtsaukti;
            this.ClientSize = new System.Drawing.Size(234, 143);
            this.Controls.Add(this.buttonAtsaukti);
            this.Controls.Add(this.textBoxAmzius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGerai);
            this.Controls.Add(this.textBoxVardas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IvestiDuomenisForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ivesti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVardas;
        private System.Windows.Forms.Button buttonGerai;
        private System.Windows.Forms.TextBox textBoxAmzius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAtsaukti;
    }
}