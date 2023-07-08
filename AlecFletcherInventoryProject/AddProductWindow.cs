using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlecFletcherInventoryProject
{
    public partial class AddProductWindow : Form
    {
        bool isNameProper = false;
        bool isOutsourcedOrInHouse = false;
        bool isInventoryProper = false;
        bool isPriceProper = false;
        bool isMinProper = false;
        bool isMaxProper = false;
        bool isMinSmallerThanMax = false;
        int prodMin;
        int prodMax;
        public bool isBeingModified = false;

        decimal prodPrice;

        public Product currentProduct = new Product();
        public AddProductWindow()
        {
            InitializeComponent();
        }


        private void AddProductWindow_Load(object sender, EventArgs e)
        {
            candidatePartsGrid.DataSource = Inventory.AllParts;
            associatedPartsGrid.DataSource = currentProduct.AssociatedParts;
            IDTextBox.Text = Inventory.Products.Count.ToString();

            //Sets column header text
            candidatePartsGrid.Columns[0].HeaderText = "Product ID";
            candidatePartsGrid.Columns[1].HeaderText = "Name";
            candidatePartsGrid.Columns[2].HeaderText = "Inventory";
            candidatePartsGrid.Columns[3].HeaderText = "Price";
            candidatePartsGrid.Columns[4].HeaderText = "Min";
            candidatePartsGrid.Columns[5].HeaderText = "Max";
            associatedPartsGrid.Columns[0].HeaderText = "Product ID";
            associatedPartsGrid.Columns[1].HeaderText = "Name";
            associatedPartsGrid.Columns[2].HeaderText = "Inventory";
            associatedPartsGrid.Columns[3].HeaderText = "Price";
            associatedPartsGrid.Columns[4].HeaderText = "Min";
            associatedPartsGrid.Columns[5].HeaderText = "Max";

            if (isBeingModified)
            {
                IDTextBox.Text = currentProduct.ProductID.ToString();
                nameTextBox.Text = currentProduct.Name.ToString();
                inventoryTextBox.Text = currentProduct.InStock.ToString();
                priceTextBox.Text = currentProduct.Price.ToString();
                minTextBox.Text = currentProduct.Min.ToString();
                maxTextBox.Text = currentProduct.Max.ToString();
                addProductLabel.Text = "Modify Product";
            }
        }

        //Adds candidate part to associated parts
        private void addCandidatePartButton_Click(object sender, EventArgs e)
        {
            try { 
            Part addedPart = (Part)candidatePartsGrid.SelectedRows[0].DataBoundItem;
            currentProduct.addAssociatedPart(addedPart);
            }
            catch { Exception n; }
        }

        //Helper function to make sure inventory is between min and max
        private bool isInvBetween()
        {
            try
            {
                int inv = Convert.ToInt32(inventoryTextBox.Text.ToString());
                return (inv <= prodMax && inv >= prodMin);
            }
            catch { Exception n; return false; }

        }

        //Helper function to ensure input is a number
        private bool isNumber(string input)
        {
            return int.TryParse(input, out int InputValue);
        }

        //Verifies that part name is not blank
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0)
            {
                isNameProper = true;
                nameTextBox.BackColor = Color.White;
            }
            else
            {
                nameTextBox.BackColor = Color.FromArgb(255, 192, 192);
                isNameProper = false;
            }
        }
        
        //Verifies that inventory is a num
        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(inventoryTextBox.Text))
            {
                isInventoryProper = true;
                inventoryTextBox.BackColor = Color.White;
            }
            else
            {
                isInventoryProper = false;
                inventoryTextBox.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        //Verifies that price is a decimal
        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(priceTextBox.Text, out decimal input))
            {
                isPriceProper = true;
                priceTextBox.BackColor = Color.White;
                prodPrice = input;
            }
            else
            {
                isPriceProper = false;
                priceTextBox.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        // Verifies that min is a num and runs a check on whether min is smaller than max
        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(minTextBox.Text))
            {
                prodMin = Convert.ToInt32(minTextBox.Text);
                minTextBox.BackColor = Color.White;
                isMinProper = true;
            }
            else
            {
                minTextBox.BackColor = Color.FromArgb(255, 192, 192);
                isMinProper = false;
            }
            checkMinSmallerThanMax();
        }

        //Verifies that max is a num and runs a check on whether min is smaller than max
        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(maxTextBox.Text))
            {
                prodMax = Convert.ToInt32(maxTextBox.Text);
                maxTextBox.BackColor = Color.White;
                isMaxProper = true;
            }
            else
            {
                maxTextBox.BackColor = Color.FromArgb(255, 192, 192);
                isMaxProper = false;
            }
            checkMinSmallerThanMax();
        }

        //Helper function to ensure min is smaller than max
        private bool checkMinSmallerThanMax()
        {
            if (prodMin < prodMax)
            {
                isMinSmallerThanMax = true;
                return true;
            }
            else
            {
                isMinSmallerThanMax = false;
                return false;
            }
        }

        //Cancel button to close dialog
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Check all cases and provide proper message boxes for missing / wrong values
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!isNameProper)
            {
                MessageBox.Show("You must provide a product name.");
                return;
            }
            else if (!isInventoryProper)
            {
                if (inventoryTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please provide an inventory amount.");
                    return;
                }
                else
                {
                    MessageBox.Show("You must provide a proper number for inventory.");
                    return;
                }
            }
            else if (!isPriceProper)
            {
                if (priceTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please provide a price.");
                    return;
                }
                else
                {
                    MessageBox.Show("You must provide a proper price.");
                    return;
                }
            }
            else if (!isMinProper)
            {
                MessageBox.Show("Please provide a proper minimum value.");
                return;
            }
            else if (!isMaxProper)
            {
                MessageBox.Show("Please provide a proper maximum value.");
                return;
            }
            else if (!isMinSmallerThanMax)
            {
                MessageBox.Show("Minimum must be smaller than maximum.");
                return;
            }
            else if (!isInvBetween())
            {
                MessageBox.Show("Inventory stock must be between minimum and maximum.");
                return;
            }
            try {
                currentProduct.ProductID = Convert.ToInt32(IDTextBox.Text.ToString());
                currentProduct.Name = nameTextBox.Text;
                currentProduct.Price = Convert.ToDecimal(priceTextBox.Text);
                currentProduct.InStock = Convert.ToInt32(inventoryTextBox.Text);
                currentProduct.Min = Convert.ToInt32(minTextBox.Text);
                currentProduct.Max = Convert.ToInt32(maxTextBox.Text);

                if (isBeingModified)
                {
                    Inventory.updateProduct(currentProduct.ProductID, currentProduct);
                    Close();
                }
                else if (!isBeingModified)
                {
                    Inventory.addProduct(currentProduct);
                    Close();
                
                }
            }
            catch { Exception n; }

        }

        //Passes selected id to removeAssociatedPart
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try {
                int id = Convert.ToInt32(associatedPartsGrid.SelectedRows[0].Cells[0].Value);
                    
                string deleteMessage = "Are you sure you want to remove this part from this product?";
                var messageBox = MessageBox.Show(deleteMessage, "Remove Part", MessageBoxButtons.YesNo);
                    if (messageBox == DialogResult.Yes)
                    {
                    currentProduct.removeAssociatedPart(id);
                    }


                    }
            catch { Exception n; }

        }

        //Changes the selected row to the first row that contains the search phrase / id
        private void candidatePartsSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchedVal = partsSearchTextBox.Text.ToString();
                for (int i = 0; i < Inventory.AllParts.Count(); i++)
                {
                    string idVal = candidatePartsGrid.Rows[i].Cells[0].Value.ToString();
                    string nameVal = candidatePartsGrid.Rows[i].Cells[1].Value.ToString();

                    if (idVal.Contains(searchedVal) || nameVal.Contains(searchedVal))
                    {
                        candidatePartsGrid.Rows[i].Selected = true;
                        return;
                    }
                }
                MessageBox.Show("Part could not be found.");
            }
            catch
            {
                Exception n;

            }
        }

    }
}
