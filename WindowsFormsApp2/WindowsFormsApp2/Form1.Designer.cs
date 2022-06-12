
namespace WindowsFormsApp2
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(142, 35);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(266, 22);
            this.txtusername.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtemailid
            // 
            this.txtemailid.Location = new System.Drawing.Point(142, 107);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(266, 22);
            this.txtemailid.TabIndex = 2;
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.Location = new System.Drawing.Point(142, 172);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerdob.TabIndex = 3;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(142, 260);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(133, 22);
            this.txtsalary.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "dob";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.dateTimePickerdob);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtusername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.DateTimePicker dateTimePickerdob;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

