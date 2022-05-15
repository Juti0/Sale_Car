
namespace Sale_Car
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameFirst = new System.Windows.Forms.TextBox();
            this.nameLast = new System.Windows.Forms.TextBox();
            this.phoneCus = new System.Windows.Forms.TextBox();
            this.adresCus = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.Cid = new System.Windows.Forms.Label();
            this.CusId = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAdrress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FName,
            this.LName,
            this.CPhone,
            this.CAdrress,
            this.CEdit,
            this.CUpdate,
            this.CDelete});
            this.dataGridView1.Location = new System.Drawing.Point(580, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(696, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameFirst
            // 
            this.nameFirst.Location = new System.Drawing.Point(259, 93);
            this.nameFirst.Name = "nameFirst";
            this.nameFirst.Size = new System.Drawing.Size(193, 22);
            this.nameFirst.TabIndex = 1;
            // 
            // nameLast
            // 
            this.nameLast.Location = new System.Drawing.Point(259, 137);
            this.nameLast.Name = "nameLast";
            this.nameLast.Size = new System.Drawing.Size(193, 22);
            this.nameLast.TabIndex = 2;
            // 
            // phoneCus
            // 
            this.phoneCus.Location = new System.Drawing.Point(259, 178);
            this.phoneCus.Name = "phoneCus";
            this.phoneCus.Size = new System.Drawing.Size(193, 22);
            this.phoneCus.TabIndex = 3;
            // 
            // adresCus
            // 
            this.adresCus.Location = new System.Drawing.Point(259, 220);
            this.adresCus.Multiline = true;
            this.adresCus.Name = "adresCus";
            this.adresCus.Size = new System.Drawing.Size(248, 80);
            this.adresCus.TabIndex = 4;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(108, 89);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(112, 25);
            this.firstName.TabIndex = 5;
            this.firstName.Text = "First Name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(108, 134);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(112, 25);
            this.lastName.TabIndex = 6;
            this.lastName.Text = "Last Name:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(109, 174);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(75, 25);
            this.phone.TabIndex = 7;
            this.phone.Text = "Phone:";
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adres.Location = new System.Drawing.Point(108, 216);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(91, 25);
            this.adres.TabIndex = 8;
            this.adres.Text = "Address:";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(12, 306);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 68);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(162, 306);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 69);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(308, 306);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(123, 69);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(454, 306);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(120, 69);
            this.refresh.TabIndex = 12;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Cid
            // 
            this.Cid.AutoSize = true;
            this.Cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cid.Location = new System.Drawing.Point(108, 51);
            this.Cid.Name = "Cid";
            this.Cid.Size = new System.Drawing.Size(34, 25);
            this.Cid.TabIndex = 13;
            this.Cid.Text = "Id:";
            // 
            // CusId
            // 
            this.CusId.Location = new System.Drawing.Point(259, 51);
            this.CusId.Name = "CusId";
            this.CusId.Size = new System.Drawing.Size(193, 22);
            this.CusId.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // FName
            // 
            this.FName.HeaderText = "First Name";
            this.FName.MinimumWidth = 6;
            this.FName.Name = "FName";
            this.FName.Width = 125;
            // 
            // LName
            // 
            this.LName.HeaderText = "Last Name";
            this.LName.MinimumWidth = 6;
            this.LName.Name = "LName";
            this.LName.Width = 125;
            // 
            // CPhone
            // 
            this.CPhone.HeaderText = "Phone";
            this.CPhone.MinimumWidth = 6;
            this.CPhone.Name = "CPhone";
            this.CPhone.Width = 125;
            // 
            // CAdrress
            // 
            this.CAdrress.HeaderText = "Address";
            this.CAdrress.MinimumWidth = 6;
            this.CAdrress.Name = "CAdrress";
            this.CAdrress.Width = 125;
            // 
            // CEdit
            // 
            this.CEdit.HeaderText = "Edit";
            this.CEdit.MinimumWidth = 6;
            this.CEdit.Name = "CEdit";
            this.CEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CEdit.Text = "Edit";
            this.CEdit.UseColumnTextForButtonValue = true;
            this.CEdit.Width = 125;
            // 
            // CUpdate
            // 
            this.CUpdate.HeaderText = "Update";
            this.CUpdate.MinimumWidth = 6;
            this.CUpdate.Name = "CUpdate";
            this.CUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CUpdate.Text = "Update";
            this.CUpdate.UseColumnTextForButtonValue = true;
            this.CUpdate.Width = 125;
            // 
            // CDelete
            // 
            this.CDelete.HeaderText = "Delete";
            this.CDelete.MinimumWidth = 6;
            this.CDelete.Name = "CDelete";
            this.CDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CDelete.Text = "Delete";
            this.CDelete.UseColumnTextForButtonValue = true;
            this.CDelete.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 442);
            this.Controls.Add(this.CusId);
            this.Controls.Add(this.Cid);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.adresCus);
            this.Controls.Add(this.phoneCus);
            this.Controls.Add(this.nameLast);
            this.Controls.Add(this.nameFirst);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Juti\'s Car";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nameFirst;
        private System.Windows.Forms.TextBox nameLast;
        private System.Windows.Forms.TextBox phoneCus;
        private System.Windows.Forms.TextBox adresCus;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label Cid;
        private System.Windows.Forms.TextBox CusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAdrress;
        private System.Windows.Forms.DataGridViewButtonColumn CEdit;
        private System.Windows.Forms.DataGridViewButtonColumn CUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn CDelete;
    }
}