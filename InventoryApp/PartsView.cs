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
    public partial class PartsView : Form
    {
        private bool isNewPart;

        public PartsView()
        {
            InitializeComponent();
            isNewPart = true;
            labelPart.Text = "Add Part";
            textBoxID.Text = util.GetUniqueId().ToString();
        }

        public PartsView(InHouse inHouse)
        {
            InitializeComponent();
            isNewPart = false;
            setupModiyingParts(inHouse);
            textBoxPartDestination.Text = inHouse.MachineID.ToString();
            radioButtonInHouse.Checked = true;
        }

        public PartsView(Outsourced outsourced)
        {
            InitializeComponent();
            isNewPart = false;
            setupModiyingParts(outsourced);
            textBoxPartDestination.Text = outsourced.CompanyName;
            radioButtonOutsourced.Checked = true;
        }

        private void setupModiyingParts(Part part)
        {
            labelPart.Text = "Modify Part";
            textBoxID.Text = part.PartID.ToString();
            textBoxName.Text = part.Name;
            textBoxInventory.Text = part.InStock.ToString();
            textBoxPrice.Text = part.Price.ToString();
            textBoxMax.Text = part.Max.ToString();
            textBoxMin.Text = part.Min.ToString();
        }

        private void radioButtonInHouse_CheckedChanged(object sender, EventArgs e)
        {
            labelPartDestination.Text = "Machine ID";
        }

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            labelPartDestination.Text = "Company Name";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Int32.Parse(textBoxID.Text);
                var name = textBoxName.Text;
                var inventory = Int32.Parse(textBoxInventory.Text);
                var price = Decimal.Parse(textBoxPrice.Text) + 0.00M;
                var max = Int32.Parse(textBoxMax.Text);
                var min = Int32.Parse(textBoxMin.Text);

                if (!util.isValidSave(inventory, min, max))
                {
                    return;
                }

                if (isNewPart)
                {
                    if (radioButtonInHouse.Checked)
                    {
                        var machineId = Int32.Parse(textBoxPartDestination.Text);
                        Inventory.AddPart(new InHouse(id, name, price, inventory, min, max, machineId));
                    }
                    else
                    {
                        var companyName = textBoxPartDestination.Text;
                        Inventory.AddPart(new Outsourced(id, name, price, inventory, min, max, companyName));
                    }
                }
                else
                {
                    if (radioButtonInHouse.Checked)
                    {
                        var machineId = Int32.Parse(textBoxPartDestination.Text);
                        Inventory.UpdatePart(id, new InHouse(id, name, price, inventory, min, max, machineId));
                    }
                    else
                    {
                        var companyName = textBoxPartDestination.Text;
                        Inventory.UpdatePart(id, new Outsourced(id, name, price, inventory, min, max, companyName));
                    }
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

        private void textBoxPartDestination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonInHouse.Checked)
            {
                util.validateNumeric(sender, e);
            }
        }
    }
}
