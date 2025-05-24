namespace GrifindoToysSystem
{
    partial class MainMenu
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
            this.btnemployee = new System.Windows.Forms.Button();
            this.btnsalary = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnemployee
            // 
            this.btnemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.Location = new System.Drawing.Point(42, 101);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(144, 46);
            this.btnemployee.TabIndex = 23;
            this.btnemployee.Text = "EMPLOYEE";
            this.btnemployee.UseVisualStyleBackColor = true;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btnsalary
            // 
            this.btnsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalary.Location = new System.Drawing.Point(212, 101);
            this.btnsalary.Name = "btnsalary";
            this.btnsalary.Size = new System.Drawing.Size(144, 46);
            this.btnsalary.TabIndex = 24;
            this.btnsalary.Text = "SALARY";
            this.btnsalary.UseVisualStyleBackColor = true;
            this.btnsalary.Click += new System.EventHandler(this.btnsalary_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.Location = new System.Drawing.Point(383, 101);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(144, 46);
            this.btnsettings.TabIndex = 25;
            this.btnsettings.Text = "SETTINGS";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 246);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.btnsalary);
            this.Controls.Add(this.btnemployee);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Button btnsalary;
        private System.Windows.Forms.Button btnsettings;
    }
}