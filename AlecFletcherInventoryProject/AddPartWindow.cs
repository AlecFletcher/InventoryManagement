using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlecFletcherInventoryProject
{
    public partial class AddPartWindow : Form
    {
        Inhouse inhousePart = new Inhouse();
        Outsourced outsourcedPart = new Outsourced();

        public Part passedPart;

        // properties passed from main screen when part is being modified
        public int partID { get; set; }
        public string partName { get; set; }
        public decimal partPrice { get; set; }
        public int partInStock { get; set; }
        public int partMin { get; set; }
        public int partMax { get; set; }
        public int partMachineID { get; set; }
        public string partCompanyName { get; set; }
        public bool isBeingModified = false;
        public bool wasInHouse = false;

        // properties to ensure save button should be enabled
        bool isNameProper = false;
        bool isInventoryProper = false;
        bool isPriceProper = false;
        bool isMinProper = false;
        bool isMaxProper = false;
        bool isMinSmallerThanMax = false;
        bool isMachineIDProper = false;
        int min;
        int max;


        public AddPartWindow()
        {
            InitializeComponent();
        }

        private bool isInvBetween()
        {
            try
            {
                int inv = Convert.ToInt32(inventoryTextBox.Text.ToString());
                return (inv <= max && inv >= min);
            }
            catch { Exception n; return false; }
        }

        //Set text values to passed part if part is being modified, then check
        //whether of not the part is inHouse and set radio button accordingly
        private void AddPartWindow_Load(object sender, EventArgs e)
        {
            
            inHouseRadioButton.Checked = true;
            int partID = Inventory.AllParts.Count();
            IDTextBox.Text = partID.ToString();
            

            //If sent by modify button, add all values
            if (isBeingModified) {
            addPartLabel.Text = "Modify Part";
                try {
                    IDTextBox.Text = passedPart.PartID.ToString();
                    nameTextBox.Text = passedPart.Name.ToString();
                    inventoryTextBox.Text = passedPart.InStock.ToString();
                    priceTextBox.Text = passedPart.Price.ToString();
                    minTextBox.Text = passedPart.Min.ToString();
                    maxTextBox.Text = passedPart.Max.ToString();
                }
                catch { Exception n; }

                if (passedPart.GetType() == typeof(Inhouse)) {
                        inhousePart = (Inhouse)passedPart;
                        wasInHouse= true;
                        machineIDTextBox.Text = inhousePart.MachineID.ToString();
                        inHouseRadioButton.Checked = true;
                        }
                        else{
                        outsourcedPart = (Outsourced)passedPart;
                        machineIDTextBox.Text = outsourcedPart.CompanyName;
                        outsourcedRadioButton.Checked = true;
                    }

            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Verifies that part name is not blank
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0 )
            {
                nameTextBox.BackColor = Color.White;
                isNameProper = true;
                partName = nameTextBox.Text;
            }
            else
            {
                nameTextBox.BackColor = (Color.FromArgb(255, 192, 192));
                isNameProper = false;
            }
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!isNumber(machineIDTextBox.Text))
            {
                machineIDTextBox.BackColor = Color.FromArgb(255, 192, 192);
                isMachineIDProper = false;
            }
            machineIDLabel.Text = "Machine ID";

        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(machineIDTextBox.Text.Length > 0)
            {
                machineIDTextBox.BackColor = Color.White;
                isMachineIDProper = true;
            }
            machineIDLabel.Text = "Company Name";
        }
        

        // checks that the inventory textbox is a number and if it is, assign the value to partInStock property
        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {

            if (isNumber(inventoryTextBox.Text))
            {
                partInStock = Convert.ToInt32(inventoryTextBox.Text);
                isInventoryProper = true;
                inventoryTextBox.BackColor = Color.White;
            }
                else
                {
                    isInventoryProper = false;
                    inventoryTextBox.BackColor = Color.FromArgb(255, 192, 192);
                }
        }

        // Checks that price is a number and sets property isPriceProper accordingly
        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(priceTextBox.Text, out decimal input))
            {
                isPriceProper = true;
                priceTextBox.BackColor = Color.White;
                partPrice = input;
            }
                else
                {
                    isPriceProper = false;
                    priceTextBox.BackColor = Color.FromArgb(255, 192, 192);
                }
        }

        // Checks that min is a number, then assigns it and checks if min is smaller than max
        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(minTextBox.Text))
            {
                min = Convert.ToInt32(minTextBox.Text);
                minTextBox.BackColor = Color.White;
                isMinProper = true;
                partMin = min;
            }
            else 
            {
                minTextBox.BackColor = Color.FromArgb(255, 192, 192);
                isMinProper = false; 
            }
        }

        //Checks that max is a number and if min is smaller than max
        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(maxTextBox.Text))
            {
                max = Convert.ToInt32(maxTextBox.Text);
                maxTextBox.BackColor= Color.White;
                isMaxProper = true;
                partMax = max;
            }
            else 
            { 
                maxTextBox.BackColor = Color.FromArgb(255, 192, 192);
                isMaxProper = false;
            }
        }

        //Helper function to check that min is smaller than max
        private bool checkMinSmallerThanMax()
        {
            if (min < max)
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

        //Checks that machine id is a number if inHouse radio button is selected
        //Otherwise checks that there is text if outSourced radio button is selected
        private void machineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inHouseRadioButton.Checked)
            {
                if (isNumber(machineIDTextBox.Text)){
                    machineIDTextBox.BackColor = Color.White;
                    isMachineIDProper = true;
                    partMachineID = Convert.ToInt32(machineIDTextBox.Text);
                }
                else
                {
                    machineIDTextBox.BackColor = Color.FromArgb(255, 192, 192); ;
                    isMachineIDProper = false;
                }
            }
            else
            {
                machineIDTextBox.BackColor = Color.FromArgb(255, 192, 192);
                isMachineIDProper = false;
            }

            if (outsourcedRadioButton.Checked)
            {
                if(machineIDTextBox.Text.Length > 0)
                {
                    machineIDTextBox.BackColor = Color.White;
                    isMachineIDProper = true;
                }
            }
        }

        //Checks that all input fields are correct and throws an error message for the user if not.
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
            else if (!checkMinSmallerThanMax())
            {
                MessageBox.Show("Minimum must be smaller than maximum.");
                return;
            }
            else if (!isInvBetween())
            {
                MessageBox.Show("Inventory stock must be between minimum and maximum.");
                return;
            }
            else if (!isMachineIDProper)
            {
                if (outsourcedRadioButton.Checked)
                {
                    MessageBox.Show("Please provide a proper company name.");
                    return;
                }
                else if (inHouseRadioButton.Checked)
                {
                    MessageBox.Show("Please provide a numerical machine ID.");
                    return;
                }
            }

            try
            {
                partID = Convert.ToInt32(IDTextBox.Text);
                partName = nameTextBox.Text;
                partPrice = Convert.ToDecimal(priceTextBox.Text);
                partInStock = Convert.ToInt32(inventoryTextBox.Text);
                partMin = Convert.ToInt32(minTextBox.Text);
                partMax = Convert.ToInt32(maxTextBox.Text);

                //If adding a new part
                if (!isBeingModified)
                {
                    //Add inHouse part if inHouse is checked
                    if (inHouseRadioButton.Checked)
                    {
                        Inhouse newPart = new Inhouse(partID, partName, partInStock, partPrice, partMin, partMax, partMachineID);
                        Inventory.addPart(newPart);
                        Close();
                    }
                    //Add outsourced part if outsourced is checked
                    else if (outsourcedRadioButton.Checked)
                    {
                        string companyName = machineIDTextBox.Text;
                        Outsourced newPart = new Outsourced(partID, partName, partInStock, partPrice, partMin, partMax, companyName);
                        Inventory.addPart(newPart);
                        Close();
                    }
                }
                // If being modified
                else
                {

                    //See if part was in house when passed
                    if (isBeingModified && wasInHouse)
                    {
                        if (outsourcedRadioButton.Checked)
                        {
                            Part part = Inventory.lookupPart(partID);
                            Inventory.deletePart(part);
                            string companyName = machineIDTextBox.Text;
                            Outsourced newPart = new Outsourced(partID, partName, partInStock, partPrice, partMin, partMax, companyName);
                            Inventory.addPart(newPart);
                            Close();
                        }
                        else if (inHouseRadioButton.Checked)
                        {
                            Part oldPart = Inventory.lookupPart(partID);
                            Inhouse newPart = new Inhouse(partID, partName, partInStock, partPrice, partMin, partMax, partMachineID);
                            Inventory.updatePart(oldPart.PartID, newPart);
                            Close();
                        }
                    }
                    else if (isBeingModified && !wasInHouse)
                    {
                        if (outsourcedRadioButton.Checked)
                        {
                            Part oldPart = Inventory.lookupPart(partID);
                            string companyName = machineIDTextBox.Text;
                            Outsourced newPart = new Outsourced(partID, partName, partInStock, partPrice, partMin, partMax, companyName);
                            Inventory.updatePart(oldPart.PartID, newPart);
                            Close();
                        }
                        else if (inHouseRadioButton.Checked)
                        {
                            Part part = Inventory.lookupPart(partID);
                            Inventory.deletePart(part);
                            Inhouse newPart = new Inhouse(partID, partName, partInStock, partPrice, partMin, partMax, partMachineID);
                            Inventory.addPart(newPart);
                            Close();
                        }
                    }
                }
            }
            catch{ Exception n; }
        }

        private bool isNumber(string input)
        {
            return int.TryParse(input, out int InputValue);

        }
    }
    }
