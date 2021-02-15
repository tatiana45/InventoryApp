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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PopulateFakeData();
            BindingDataToGrid();
        }

        private void PopulateFakeData()
        {
            Inventory.AddPart(new InHouse(0, "Hard Disk", 200.11m, 15, 5, 25, 10));
            Inventory.AddPart(new InHouse(1, "Graphic card", 200.52m, 11, 5, 25, 278));
            Inventory.AddPart(new Outsourced(2, "Processor", 540.21m, 12, 5, 25, "Intel"));
            Inventory.AddPart(new Outsourced(3, "Basic Motherboard", 330.96m, 8, 2, 10, "ASRock"));
            Inventory.AddPart(new Outsourced(4, "Gaming Motherboard", 630.55m, 8, 2, 10, "ASUS"));
            Inventory.AddPart(new Outsourced(5, "Gaming graphic card", 500.52m, 3, 1, 5, "NVIDIA"));
            Inventory.AddProduct(new Product(0, "Basic CPU", 1020.88m, 2, 1, 25));
            Inventory.AddProduct(new Product(1, "Office CPU", 1320.47m, 2, 1, 25));
            Inventory.AddProduct(new Product(2, "Gaming CPU", 1620.99m, 2, 1, 25));

            //Lookup for parts
            var hardDisk = Inventory.LookupPart(0);
            var graphicCard = Inventory.LookupPart(1);
            var processor = Inventory.LookupPart(2);
            var basicMotherboard = Inventory.LookupPart(3);
            var gamingMotherboard = Inventory.LookupPart(4);
            var gamingGraphicCard = Inventory.LookupPart(5);

            //Add parts associates with product
            var basicCPU = Inventory.LookupProduct(0);
            basicCPU.AddAssociatedPart(hardDisk);
            basicCPU.AddAssociatedPart(processor);
            basicCPU.AddAssociatedPart(basicMotherboard);

            var officeCPU = Inventory.LookupProduct(1);
            officeCPU.AddAssociatedPart(hardDisk);
            officeCPU.AddAssociatedPart(processor);
            officeCPU.AddAssociatedPart(graphicCard);
            officeCPU.AddAssociatedPart(basicMotherboard);

            var gamingCPU = Inventory.LookupProduct(2);
            gamingCPU.AddAssociatedPart(hardDisk);
            gamingCPU.AddAssociatedPart(processor);
            gamingCPU.AddAssociatedPart(gamingGraphicCard);
            gamingCPU.AddAssociatedPart(gamingMotherboard);
        }

        public void BindingDataToGrid()
        {
            var bindingSourceParts = new BindingSource(Inventory.Parts, null);
            var bindingSourceProducts = new BindingSource(Inventory.Products, null);

            dataGridViewParts.DataSource = bindingSourceParts;
            dataGridViewProducts.DataSource = bindingSourceProducts;
            dataGridViewParts.Columns["PartID"].HeaderText = "Part ID";
            dataGridViewParts.Columns["InStock"].HeaderText = "Inventory";
            dataGridViewProducts.Columns["ProductID"].HeaderText = "Product ID";
            dataGridViewProducts.Columns["InStock"].HeaderText = "Inventory";
        }

        private void buttonPartAdd_Click(object sender, EventArgs e)
        {
            new PartsView().ShowDialog();
        }

        private void buttonPartModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to be modify");
                return;
            }
            var selectedPartID = (int)dataGridViewParts.SelectedRows[0].Cells["PartID"].Value;
            var selectedPart = Inventory.LookupPart(selectedPartID);
            if (dataGridViewParts.SelectedRows[0].DataBoundItem.GetType() == typeof(InHouse))
            {
                new PartsView((InHouse)selectedPart).ShowDialog();
            } else
            {
                new PartsView((Outsourced)selectedPart).ShowDialog();
            }
            
        }

        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            new ProductsView().ShowDialog();
        }

        private void buttonProductModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to be modify");
                return;
            }
            var selectedProductID = (int)dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value;
            var selectedProduct = Inventory.LookupProduct(selectedProductID);
            new ProductsView(selectedProduct).ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPartDelete_Click(object sender, EventArgs e)
        {
            var selectedPartID = (int)dataGridViewParts.SelectedRows[0].Cells["PartID"].Value;
            var part = Inventory.LookupPart(selectedPartID);
            Inventory.DeletePart(part);
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            var selectedProductID = (int)dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value;
            var product = Inventory.LookupProduct(selectedProductID);
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("This product has associated parts assigned to it.\nPlease removed the associated parts.");
                return;
            }
            var deleteConfirmation = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (deleteConfirmation == DialogResult.Yes)
            {
                Inventory.RemoveProduct(selectedProductID);
            }
        }

        private void buttonPartsSearch_Click(object sender, EventArgs e)
        {
            var searchText = textBoxPartsSearch.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            }
            dataGridViewParts.ClearSelection();
            foreach(DataGridViewRow row in dataGridViewParts.Rows)
            {
                var currentRowId = row.Cells["PartID"].Value.ToString();
                if (currentRowId == searchText)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void buttonProductsSearch_Click(object sender, EventArgs e)
        {
            var searchText = textBoxProductsSearch.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            }
            dataGridViewProducts.ClearSelection();
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                var currentRowId = row.Cells["ProductID"].Value.ToString();
                if (currentRowId == searchText)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void textBoxPartsSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validateNumeric(sender, e);
        }

        private void textBoxProductsSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.validateNumeric(sender, e);
        }
    }
}
