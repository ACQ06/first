namespace WindowsFormsApp1
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
            this.lvwRecord = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dtpBdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lvwRecord
            // 
            this.lvwRecord.HideSelection = false;
            this.lvwRecord.Location = new System.Drawing.Point(12, 26);
            this.lvwRecord.Name = "lvwRecord";
            this.lvwRecord.Size = new System.Drawing.Size(506, 257);
            this.lvwRecord.TabIndex = 0;
            this.lvwRecord.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birthdate";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 303);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(433, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(12, 378);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(506, 27);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "ADD Record";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 411);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(506, 27);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "DELETE Record";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dtpBdate
            // 
            this.dtpBdate.Location = new System.Drawing.Point(85, 339);
            this.dtpBdate.Name = "dtpBdate";
            this.dtpBdate.Size = new System.Drawing.Size(433, 20);
            this.dtpBdate.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.dtpBdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DateTimePicker dtpBdate;
    }
}

