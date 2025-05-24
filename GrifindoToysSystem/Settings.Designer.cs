namespace GrifindoToysSystem
{
    partial class Settings
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
            this.txtdaterange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudleavesperyear = new System.Windows.Forms.NumericUpDown();
            this.btnsaveupdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtcycleend = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtcyclestartdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudleavesperyear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdaterange);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudleavesperyear);
            this.groupBox1.Controls.Add(this.btnsaveupdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtcycleend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtcyclestartdate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtdaterange
            // 
            this.txtdaterange.Location = new System.Drawing.Point(508, 68);
            this.txtdaterange.Multiline = true;
            this.txtdaterange.Name = "txtdaterange";
            this.txtdaterange.Size = new System.Drawing.Size(119, 24);
            this.txtdaterange.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cycle Date Range";
            // 
            // nudleavesperyear
            // 
            this.nudleavesperyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudleavesperyear.Location = new System.Drawing.Point(508, 37);
            this.nudleavesperyear.Name = "nudleavesperyear";
            this.nudleavesperyear.Size = new System.Drawing.Size(76, 24);
            this.nudleavesperyear.TabIndex = 35;
            this.nudleavesperyear.ValueChanged += new System.EventHandler(this.nudleavesperyear_ValueChanged);
            // 
            // btnsaveupdate
            // 
            this.btnsaveupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveupdate.Location = new System.Drawing.Point(307, 106);
            this.btnsaveupdate.Name = "btnsaveupdate";
            this.btnsaveupdate.Size = new System.Drawing.Size(113, 27);
            this.btnsaveupdate.TabIndex = 32;
            this.btnsaveupdate.Text = "Save Update";
            this.btnsaveupdate.UseVisualStyleBackColor = true;
            this.btnsaveupdate.Click += new System.EventHandler(this.btnsaveupdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Leaves per year";
            // 
            // dtcycleend
            // 
            this.dtcycleend.Location = new System.Drawing.Point(111, 65);
            this.dtcycleend.Name = "dtcycleend";
            this.dtcycleend.Size = new System.Drawing.Size(231, 20);
            this.dtcycleend.TabIndex = 25;
            this.dtcycleend.ValueChanged += new System.EventHandler(this.dtcycleend_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "End Date";
            // 
            // dtcyclestartdate
            // 
            this.dtcyclestartdate.Location = new System.Drawing.Point(111, 37);
            this.dtcyclestartdate.Name = "dtcyclestartdate";
            this.dtcyclestartdate.Size = new System.Drawing.Size(231, 20);
            this.dtcyclestartdate.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Start Date";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(292, 197);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 27);
            this.btnback.TabIndex = 40;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 276);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudleavesperyear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtcycleend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtcyclestartdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudleavesperyear;
        private System.Windows.Forms.Button btnsaveupdate;
        private System.Windows.Forms.TextBox txtdaterange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnback;
    }
}