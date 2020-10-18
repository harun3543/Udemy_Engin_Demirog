namespace EntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastNameUpdate = new System.Windows.Forms.TextBox();
            this.txtNumberUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Panel();
            this.brnAdd = new System.Windows.Forms.Button();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnGetById = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.btnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(53, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 25);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIdUpdate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtNameUpdate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLastNameUpdate);
            this.panel2.Controls.Add(this.txtNumberUpdate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(392, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 112);
            this.panel2.TabIndex = 13;
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(72, 81);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(151, 20);
            this.txtIdUpdate.TabIndex = 11;
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
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(72, 3);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(151, 20);
            this.txtNameUpdate.TabIndex = 8;
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
            // txtLastNameUpdate
            // 
            this.txtLastNameUpdate.Location = new System.Drawing.Point(72, 29);
            this.txtLastNameUpdate.Name = "txtLastNameUpdate";
            this.txtLastNameUpdate.Size = new System.Drawing.Size(151, 20);
            this.txtLastNameUpdate.TabIndex = 10;
            // 
            // txtNumberUpdate
            // 
            this.txtNumberUpdate.Location = new System.Drawing.Point(72, 55);
            this.txtNumberUpdate.Name = "txtNumberUpdate";
            this.txtNumberUpdate.Size = new System.Drawing.Size(151, 20);
            this.txtNumberUpdate.TabIndex = 9;
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
            // btnAdd
            // 
            this.btnAdd.Controls.Add(this.brnAdd);
            this.btnAdd.Controls.Add(this.txtNameAdd);
            this.btnAdd.Controls.Add(this.label3);
            this.btnAdd.Controls.Add(this.txtNumberAdd);
            this.btnAdd.Controls.Add(this.label2);
            this.btnAdd.Controls.Add(this.txtLastNameAdd);
            this.btnAdd.Controls.Add(this.label1);
            this.btnAdd.Location = new System.Drawing.Point(53, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 112);
            this.btnAdd.TabIndex = 12;
            // 
            // brnAdd
            // 
            this.brnAdd.Location = new System.Drawing.Point(229, 3);
            this.brnAdd.Name = "brnAdd";
            this.brnAdd.Size = new System.Drawing.Size(96, 28);
            this.brnAdd.TabIndex = 7;
            this.brnAdd.Text = "Add";
            this.brnAdd.UseVisualStyleBackColor = true;
            this.brnAdd.Click += new System.EventHandler(this.BrnAdd_Click);
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(72, 3);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(151, 20);
            this.txtNameAdd.TabIndex = 1;
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
            // txtNumberAdd
            // 
            this.txtNumberAdd.Location = new System.Drawing.Point(72, 55);
            this.txtNumberAdd.Name = "txtNumberAdd";
            this.txtNumberAdd.Size = new System.Drawing.Size(151, 20);
            this.txtNumberAdd.TabIndex = 2;
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
            // txtLastNameAdd
            // 
            this.txtLastNameAdd.Location = new System.Drawing.Point(72, 29);
            this.txtLastNameAdd.Name = "txtLastNameAdd";
            this.txtLastNameAdd.Size = new System.Drawing.Size(151, 20);
            this.txtLastNameAdd.TabIndex = 3;
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
            // dgwCustomer
            // 
            this.dgwCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(53, 79);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.RowHeadersVisible = false;
            this.dgwCustomer.Size = new System.Drawing.Size(672, 144);
            this.dgwCustomer.TabIndex = 10;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwCustomer_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(50, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Entity Framework";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(510, 60);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(563, 53);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(162, 20);
            this.tbxSearch.TabIndex = 17;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(155, 48);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(96, 25);
            this.btnGetById.TabIndex = 18;
            this.btnGetById.Text = "GetById";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 369);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgwCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.btnAdd.ResumeLayout(false);
            this.btnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastNameUpdate;
        private System.Windows.Forms.TextBox txtNumberUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel btnAdd;
        private System.Windows.Forms.Button brnAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnGetById;
    }
}

