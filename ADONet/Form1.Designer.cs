namespace ADONet
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
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddNum = new System.Windows.Forms.TextBox();
            this.txtAddLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUpId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpLast = new System.Windows.Forms.TextBox();
            this.txtUpNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.btnAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.RowHeadersVisible = false;
            this.dgwCustomer.Size = new System.Drawing.Size(672, 144);
            this.dgwCustomer.TabIndex = 0;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(72, 3);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(151, 20);
            this.txtAddName.TabIndex = 1;
            // 
            // txtAddNum
            // 
            this.txtAddNum.Location = new System.Drawing.Point(72, 55);
            this.txtAddNum.Name = "txtAddNum";
            this.txtAddNum.Size = new System.Drawing.Size(151, 20);
            this.txtAddNum.TabIndex = 2;
            // 
            // txtAddLast
            // 
            this.txtAddLast.Location = new System.Drawing.Point(72, 29);
            this.txtAddLast.Name = "txtAddLast";
            this.txtAddLast.Size = new System.Drawing.Size(151, 20);
            this.txtAddLast.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnAdd
            // 
            this.btnAdd.Controls.Add(this.button1);
            this.btnAdd.Controls.Add(this.txtAddName);
            this.btnAdd.Controls.Add(this.label3);
            this.btnAdd.Controls.Add(this.txtAddNum);
            this.btnAdd.Controls.Add(this.label2);
            this.btnAdd.Controls.Add(this.txtAddLast);
            this.btnAdd.Controls.Add(this.label1);
            this.btnAdd.Location = new System.Drawing.Point(12, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 112);
            this.btnAdd.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUpId);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtUpName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtUpLast);
            this.panel2.Controls.Add(this.txtUpNum);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(351, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 112);
            this.panel2.TabIndex = 9;
            // 
            // txtUpId
            // 
            this.txtUpId.Location = new System.Drawing.Point(72, 81);
            this.txtUpId.Name = "txtUpId";
            this.txtUpId.Size = new System.Drawing.Size(151, 20);
            this.txtUpId.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(229, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 28);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpName
            // 
            this.txtUpName.Location = new System.Drawing.Point(72, 3);
            this.txtUpName.Name = "txtUpName";
            this.txtUpName.Size = new System.Drawing.Size(151, 20);
            this.txtUpName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number";
            // 
            // txtUpLast
            // 
            this.txtUpLast.Location = new System.Drawing.Point(72, 29);
            this.txtUpLast.Name = "txtUpLast";
            this.txtUpLast.Size = new System.Drawing.Size(151, 20);
            this.txtUpLast.TabIndex = 10;
            // 
            // txtUpNum
            // 
            this.txtUpNum.Location = new System.Drawing.Point(72, 55);
            this.txtUpNum.Name = "txtUpNum";
            this.txtUpNum.Size = new System.Drawing.Size(151, 20);
            this.txtUpNum.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "LastName";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(298, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 25);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 348);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgwCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.btnAdd.ResumeLayout(false);
            this.btnAdd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddNum;
        private System.Windows.Forms.TextBox txtAddLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpLast;
        private System.Windows.Forms.TextBox txtUpNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
    }
}

