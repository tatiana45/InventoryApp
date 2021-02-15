namespace InventoryApp
{
    partial class ProductsView
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
            System.Windows.Forms.Button buttonSearch;
            System.Windows.Forms.Button buttonDelete;
            System.Windows.Forms.Button buttonSave;
            System.Windows.Forms.Button buttonCancel;
            System.Windows.Forms.Button buttonAdd;
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelPartsCandidate = new System.Windows.Forms.Label();
            this.labelPartsAssociated = new System.Windows.Forms.Label();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewAssociatedParts = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            buttonSearch = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new System.Drawing.Point(583, 66);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(75, 23);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(802, 551);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(95, 40);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(672, 612);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(95, 40);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(802, 612);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(95, 40);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(802, 287);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(95, 40);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(13, 13);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(115, 24);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Add Product";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 130);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 181);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(12, 232);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(66, 17);
            this.labelInventory.TabIndex = 3;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 287);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(14, 344);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 17);
            this.labelMax.TabIndex = 5;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(170, 344);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(30, 17);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "Min";
            // 
            // labelPartsCandidate
            // 
            this.labelPartsCandidate.AutoSize = true;
            this.labelPartsCandidate.Location = new System.Drawing.Point(319, 88);
            this.labelPartsCandidate.Name = "labelPartsCandidate";
            this.labelPartsCandidate.Size = new System.Drawing.Size(126, 17);
            this.labelPartsCandidate.TabIndex = 7;
            this.labelPartsCandidate.Text = "All candidate Parts";
            // 
            // labelPartsAssociated
            // 
            this.labelPartsAssociated.AutoSize = true;
            this.labelPartsAssociated.Location = new System.Drawing.Point(319, 339);
            this.labelPartsAssociated.Name = "labelPartsAssociated";
            this.labelPartsAssociated.Size = new System.Drawing.Size(219, 17);
            this.labelPartsAssociated.TabIndex = 8;
            this.labelPartsAssociated.Text = "Parts Associated with the Product";
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(322, 121);
            this.dataGridViewParts.MultiSelect = false;
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.RowHeadersWidth = 51;
            this.dataGridViewParts.RowTemplate.Height = 24;
            this.dataGridViewParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParts.Size = new System.Drawing.Size(593, 150);
            this.dataGridViewParts.TabIndex = 9;
            // 
            // dataGridViewAssociatedParts
            // 
            this.dataGridViewAssociatedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssociatedParts.Location = new System.Drawing.Point(322, 371);
            this.dataGridViewAssociatedParts.MultiSelect = false;
            this.dataGridViewAssociatedParts.Name = "dataGridViewAssociatedParts";
            this.dataGridViewAssociatedParts.RowHeadersWidth = 51;
            this.dataGridViewAssociatedParts.RowTemplate.Height = 24;
            this.dataGridViewAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAssociatedParts.Size = new System.Drawing.Size(593, 150);
            this.dataGridViewAssociatedParts.TabIndex = 10;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(680, 66);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(235, 22);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(90, 130);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 17;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(90, 181);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 18;
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Location = new System.Drawing.Point(90, 232);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(100, 22);
            this.textBoxInventory.TabIndex = 19;
            this.textBoxInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInventory_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(90, 287);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 20;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(53, 341);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxMax.TabIndex = 21;
            this.textBoxMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMax_KeyPress);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(206, 341);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxMin.TabIndex = 22;
            this.textBoxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMin_KeyPress);
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 676);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(buttonAdd);
            this.Controls.Add(buttonCancel);
            this.Controls.Add(buttonSave);
            this.Controls.Add(buttonDelete);
            this.Controls.Add(buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewAssociatedParts);
            this.Controls.Add(this.dataGridViewParts);
            this.Controls.Add(this.labelPartsAssociated);
            this.Controls.Add(this.labelPartsCandidate);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelProduct);
            this.Name = "ProductsView";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelPartsCandidate;
        private System.Windows.Forms.Label labelPartsAssociated;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridView dataGridViewAssociatedParts;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
    }
}