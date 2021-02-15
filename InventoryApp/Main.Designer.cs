namespace InventoryApp
{
    partial class Main
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
            this.buttonPartAdd = new System.Windows.Forms.Button();
            this.buttonPartModify = new System.Windows.Forms.Button();
            this.buttonPartDelete = new System.Windows.Forms.Button();
            this.buttonProductAdd = new System.Windows.Forms.Button();
            this.buttonProductModify = new System.Windows.Forms.Button();
            this.buttonProductDelete = new System.Windows.Forms.Button();
            this.textBoxPartsSearch = new System.Windows.Forms.TextBox();
            this.buttonPartsSearch = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonProductsSearch = new System.Windows.Forms.Button();
            this.textBoxProductsSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPartAdd
            // 
            this.buttonPartAdd.Location = new System.Drawing.Point(228, 306);
            this.buttonPartAdd.Name = "buttonPartAdd";
            this.buttonPartAdd.Size = new System.Drawing.Size(95, 40);
            this.buttonPartAdd.TabIndex = 0;
            this.buttonPartAdd.Text = "Add";
            this.buttonPartAdd.UseVisualStyleBackColor = true;
            this.buttonPartAdd.Click += new System.EventHandler(this.buttonPartAdd_Click);
            // 
            // buttonPartModify
            // 
            this.buttonPartModify.Location = new System.Drawing.Point(344, 306);
            this.buttonPartModify.Name = "buttonPartModify";
            this.buttonPartModify.Size = new System.Drawing.Size(90, 40);
            this.buttonPartModify.TabIndex = 1;
            this.buttonPartModify.Text = "Modify";
            this.buttonPartModify.UseVisualStyleBackColor = true;
            this.buttonPartModify.Click += new System.EventHandler(this.buttonPartModify_Click);
            // 
            // buttonPartDelete
            // 
            this.buttonPartDelete.Location = new System.Drawing.Point(459, 306);
            this.buttonPartDelete.Name = "buttonPartDelete";
            this.buttonPartDelete.Size = new System.Drawing.Size(90, 40);
            this.buttonPartDelete.TabIndex = 2;
            this.buttonPartDelete.Text = "Delete";
            this.buttonPartDelete.UseVisualStyleBackColor = true;
            this.buttonPartDelete.Click += new System.EventHandler(this.buttonPartDelete_Click);
            // 
            // buttonProductAdd
            // 
            this.buttonProductAdd.Location = new System.Drawing.Point(863, 306);
            this.buttonProductAdd.Name = "buttonProductAdd";
            this.buttonProductAdd.Size = new System.Drawing.Size(90, 40);
            this.buttonProductAdd.TabIndex = 3;
            this.buttonProductAdd.Text = "Add";
            this.buttonProductAdd.UseVisualStyleBackColor = true;
            this.buttonProductAdd.Click += new System.EventHandler(this.buttonProductAdd_Click);
            // 
            // buttonProductModify
            // 
            this.buttonProductModify.Location = new System.Drawing.Point(976, 306);
            this.buttonProductModify.Name = "buttonProductModify";
            this.buttonProductModify.Size = new System.Drawing.Size(90, 40);
            this.buttonProductModify.TabIndex = 4;
            this.buttonProductModify.Text = "Modify";
            this.buttonProductModify.UseVisualStyleBackColor = true;
            this.buttonProductModify.Click += new System.EventHandler(this.buttonProductModify_Click);
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.Location = new System.Drawing.Point(1083, 306);
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.Size = new System.Drawing.Size(90, 40);
            this.buttonProductDelete.TabIndex = 5;
            this.buttonProductDelete.Text = "Delete";
            this.buttonProductDelete.UseVisualStyleBackColor = true;
            this.buttonProductDelete.Click += new System.EventHandler(this.buttonProductDelete_Click);
            // 
            // textBoxPartsSearch
            // 
            this.textBoxPartsSearch.Location = new System.Drawing.Point(349, 66);
            this.textBoxPartsSearch.Name = "textBoxPartsSearch";
            this.textBoxPartsSearch.Size = new System.Drawing.Size(200, 22);
            this.textBoxPartsSearch.TabIndex = 9;
            this.textBoxPartsSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartsSearch_KeyPress);
            // 
            // buttonPartsSearch
            // 
            this.buttonPartsSearch.Location = new System.Drawing.Point(268, 65);
            this.buttonPartsSearch.Name = "buttonPartsSearch";
            this.buttonPartsSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonPartsSearch.TabIndex = 10;
            this.buttonPartsSearch.Text = "Search";
            this.buttonPartsSearch.UseVisualStyleBackColor = true;
            this.buttonPartsSearch.Click += new System.EventHandler(this.buttonPartsSearch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1083, 444);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 40);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Products";
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(30, 108);
            this.dataGridViewParts.MultiSelect = false;
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.RowHeadersWidth = 51;
            this.dataGridViewParts.RowTemplate.Height = 24;
            this.dataGridViewParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParts.Size = new System.Drawing.Size(519, 192);
            this.dataGridViewParts.TabIndex = 16;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(644, 108);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(529, 192);
            this.dataGridViewProducts.TabIndex = 17;
            // 
            // buttonProductsSearch
            // 
            this.buttonProductsSearch.Location = new System.Drawing.Point(892, 65);
            this.buttonProductsSearch.Name = "buttonProductsSearch";
            this.buttonProductsSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonProductsSearch.TabIndex = 18;
            this.buttonProductsSearch.Text = "Search";
            this.buttonProductsSearch.UseVisualStyleBackColor = true;
            this.buttonProductsSearch.Click += new System.EventHandler(this.buttonProductsSearch_Click);
            // 
            // textBoxProductsSearch
            // 
            this.textBoxProductsSearch.Location = new System.Drawing.Point(973, 66);
            this.textBoxProductsSearch.Name = "textBoxProductsSearch";
            this.textBoxProductsSearch.Size = new System.Drawing.Size(200, 22);
            this.textBoxProductsSearch.TabIndex = 19;
            this.textBoxProductsSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductsSearch_KeyPress);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1194, 518);
            this.Controls.Add(this.textBoxProductsSearch);
            this.Controls.Add(this.buttonProductsSearch);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.dataGridViewParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPartsSearch);
            this.Controls.Add(this.textBoxPartsSearch);
            this.Controls.Add(this.buttonProductDelete);
            this.Controls.Add(this.buttonProductModify);
            this.Controls.Add(this.buttonProductAdd);
            this.Controls.Add(this.buttonPartDelete);
            this.Controls.Add(this.buttonPartModify);
            this.Controls.Add(this.buttonPartAdd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Main";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPartAdd;
        private System.Windows.Forms.Button buttonPartModify;
        private System.Windows.Forms.Button buttonPartDelete;
        private System.Windows.Forms.Button buttonProductAdd;
        private System.Windows.Forms.Button buttonProductModify;
        private System.Windows.Forms.Button buttonProductDelete;
        private System.Windows.Forms.TextBox textBoxPartsSearch;
        private System.Windows.Forms.Button buttonPartsSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonProductsSearch;
        private System.Windows.Forms.TextBox textBoxProductsSearch;
    }
}

