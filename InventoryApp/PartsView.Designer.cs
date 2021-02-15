namespace InventoryApp
{
    partial class PartsView
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
            this.labelPart = new System.Windows.Forms.Label();
            this.radioButtonInHouse = new System.Windows.Forms.RadioButton();
            this.radioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPriceCost = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelPartDestination = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxPartDestination = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPart
            // 
            this.labelPart.AutoSize = true;
            this.labelPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPart.Location = new System.Drawing.Point(13, 13);
            this.labelPart.Name = "labelPart";
            this.labelPart.Size = new System.Drawing.Size(82, 24);
            this.labelPart.TabIndex = 0;
            this.labelPart.Text = "Add Part";
            // 
            // radioButtonInHouse
            // 
            this.radioButtonInHouse.AutoSize = true;
            this.radioButtonInHouse.Checked = true;
            this.radioButtonInHouse.Location = new System.Drawing.Point(193, 12);
            this.radioButtonInHouse.Name = "radioButtonInHouse";
            this.radioButtonInHouse.Size = new System.Drawing.Size(86, 21);
            this.radioButtonInHouse.TabIndex = 1;
            this.radioButtonInHouse.TabStop = true;
            this.radioButtonInHouse.Text = "In-House";
            this.radioButtonInHouse.UseVisualStyleBackColor = true;
            this.radioButtonInHouse.CheckedChanged += new System.EventHandler(this.radioButtonInHouse_CheckedChanged);
            // 
            // radioButtonOutsourced
            // 
            this.radioButtonOutsourced.AutoSize = true;
            this.radioButtonOutsourced.Location = new System.Drawing.Point(391, 13);
            this.radioButtonOutsourced.Name = "radioButtonOutsourced";
            this.radioButtonOutsourced.Size = new System.Drawing.Size(103, 21);
            this.radioButtonOutsourced.TabIndex = 2;
            this.radioButtonOutsourced.Text = "Outsourced";
            this.radioButtonOutsourced.UseVisualStyleBackColor = true;
            this.radioButtonOutsourced.CheckedChanged += new System.EventHandler(this.radioButtonOutsourced_CheckedChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(95, 76);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(95, 122);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(94, 169);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(66, 17);
            this.labelInventory.TabIndex = 5;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Location = new System.Drawing.Point(94, 218);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(80, 17);
            this.labelPriceCost.TabIndex = 6;
            this.labelPriceCost.Text = "Price / Cost";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(95, 264);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 17);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(308, 264);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(30, 17);
            this.labelMin.TabIndex = 8;
            this.labelMin.Text = "Min";
            // 
            // labelPartDestination
            // 
            this.labelPartDestination.AutoSize = true;
            this.labelPartDestination.Location = new System.Drawing.Point(95, 315);
            this.labelPartDestination.Name = "labelPartDestination";
            this.labelPartDestination.Size = new System.Drawing.Size(78, 17);
            this.labelPartDestination.TabIndex = 9;
            this.labelPartDestination.Text = "Machine ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(207, 73);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(156, 22);
            this.textBoxID.TabIndex = 10;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(207, 119);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Location = new System.Drawing.Point(207, 164);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(156, 22);
            this.textBoxInventory.TabIndex = 12;
            this.textBoxInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInventory_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(207, 215);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(156, 22);
            this.textBoxPrice.TabIndex = 13;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(151, 261);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(134, 22);
            this.textBoxMax.TabIndex = 14;
            this.textBoxMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMax_KeyPress);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(357, 261);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(135, 22);
            this.textBoxMin.TabIndex = 15;
            this.textBoxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMin_KeyPress);
            // 
            // textBoxPartDestination
            // 
            this.textBoxPartDestination.Location = new System.Drawing.Point(207, 315);
            this.textBoxPartDestination.Name = "textBoxPartDestination";
            this.textBoxPartDestination.Size = new System.Drawing.Size(156, 22);
            this.textBoxPartDestination.TabIndex = 16;
            this.textBoxPartDestination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPartDestination_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(303, 387);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 40);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(423, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 40);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PartsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 484);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPartDestination);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPartDestination);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPriceCost);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.radioButtonOutsourced);
            this.Controls.Add(this.radioButtonInHouse);
            this.Controls.Add(this.labelPart);
            this.Name = "PartsView";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPart;
        private System.Windows.Forms.RadioButton radioButtonInHouse;
        private System.Windows.Forms.RadioButton radioButtonOutsourced;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPriceCost;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelPartDestination;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxPartDestination;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}