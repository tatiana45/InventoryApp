using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class ProductsView : Form
    {
        private BindingList<Part> tempPartsList = new BindingList<Part>();
        public BindingSource bindingSourceAssociateParts = new BindingSource();
        public Product currentProduct;
        private bool isNewProduct;

        public ProductsView()
        {
            InitializeComponent();
            currentProduct = new Product();
            isNewProduct = true;
            labelProduct.Text = "Add Product";
            textBoxID.Text = currentProduct.ProductID.ToString();
            BindingDataToGrid();
        }

        public ProductsView(Product product)
        {
            InitializeComponent();
            currentProduct = (Product) product.Clone();
            isNewProduct = false;
            setupModiyingProducts(product);
            BindingDataToGrid();
        }

        private void setupModiyingProducts(Product product)
        {
            labelProduct.Text = "Modify Part";
            textBoxID.Text = product.ProductID.ToString();
            textBoxName.Text = product.Name;
            textBoxInventory.Text = product.InStock.ToString();
            textBoxPrice.Text = product.Price.ToString();
            textBoxMax.Text = product.Max.ToString();
            textBoxMin.Text = product.Min.ToString();
        }

        public void BindingDataToGrid()
        {
            BindingSource bindingSourceParts = new BindingSource(Inventory.Parts, null);
            foreach(var part in currentProduct.AssociatedParts)
            {
                tempPartsList.Add(part);
            }
            bindingSourceAssociateParts.DataSource = tempPartsList;

            dataGridViewParts.DataSource = bindingSourceParts;
            dataGridViewAssociatedParts.DataSource = bindingSourceAssociateParts;
            dataGridViewParts.Columns["PartID"].HeaderText = "Part ID";
            dataGridViewParts.Columns["InStock"].HeaderText = "Inventory";
            dataGridViewAssociatedParts.Columns["PartID"].HeaderText = "Part ID";
            dataGridViewAssociatedParts.Columns["InStock"].HeaderText = "Inventory";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedPartID = (int)dataGridViewParts.SelectedRows[0].Cells["PartID"].Value;
            var part = Inventory.LookupPart(selectedPartID);
            tempPartsList.Add(part);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedAssociatedPartID = (int)dataGridViewAssociatedParts.SelectedRows[0].Cells["PartID"].Value;
            var currentPart = Inventory.LookupPart(selectedAssociatedPartID);
            tempPartsList.Remove(currentPart);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchText = textBoxSearch.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            }
            dataGridViewParts.ClearSelection();
            foreach (DataGridViewRow row in dataGridViewParts.Rows)
            {
                var currentRowId = row.Cells["PartID"].Value.ToString();
                if (currentRowId == searchText)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Int32.Parse(textBoxID.Text);
                currentProduct.ProductID = id;
                currentProduct.Name = textBoxName.Text;
                currentProduct.InStock = Int32.Parse(textBoxInventory.Text);
                currentProduct.Price = Decimal.Parse(textBoxPrice.Text) + 0.00M;
                currentProduct.Max = Int32.Parse(textBoxMax.Text);
                currentProduct.Min = Int32.Parse(textBoxMin.Text);
                currentProduct.AssociatedParts = tempPartsList;
                if (!util.isValidSave(currentProduct.InStock, currentProduct.Min, currentProduct.Max))
                {
                    return;
                }
                if (isNewProduct)
                {
                    Inventory.AddProduct(currentProduct);
                }
                else
                {
                    Inventory.UpdateProduct(id, currentProduct);
                }
                this.Close();
            } catch (Exception)
            {
                MessageBox.Show("Please fill in all the fields");
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validateNumeric(sender, e);
        }

        private void textBoxInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validateNumeric(sender, e);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validateDecimal(sender, e);
        }

        private void textBoxMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validateNumeric(sender, e);
        }

        private void textBoxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validateNumeric(sender, e);
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validateNumeric(sender, e);
        }
    }
}
