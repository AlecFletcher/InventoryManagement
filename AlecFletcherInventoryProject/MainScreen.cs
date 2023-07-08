using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml.Linq;



namespace AlecFletcherInventoryProject;

partial class MainScreen : Form
{
    Inhouse frame = new Inhouse(Inventory.AllParts.Count(), "Frame",  3, 56.99m, 1, 8, 6846);
    public MainScreen()
    {
        InitializeComponent();
    }
    private void MainScreen_Load(object sender, EventArgs e)
    {
        //Set Data Source to bindingLists for datagridview
        productsTable.DataSource = Inventory.Products;
        partsTable.DataSource = Inventory.AllParts;

        //Set Header Text for bot data grid tables
        productsTable.Columns[0].HeaderText = "Product ID";
        productsTable.Columns[1].HeaderText = "Name";
        productsTable.Columns[2].HeaderText = "Inventory";
        productsTable.Columns[3].HeaderText = "Price";
        productsTable.Columns[4].HeaderText = "Min";
        productsTable.Columns[5].HeaderText = "Max";
        partsTable.Columns[0].HeaderText = "Part ID";
        partsTable.Columns[1].HeaderText = "Name";
        partsTable.Columns[2].HeaderText = "Inventory";
        partsTable.Columns[3].HeaderText = "Price";
        partsTable.Columns[4].HeaderText = "Min";
        partsTable.Columns[5].HeaderText = "Max";

        //Set sample parts / products for testing
        Inhouse wheels = new Inhouse(Inventory.AllParts.Count(), "Wheels", 4,26.99m, 2, 8, 952458);
        Inventory.AllParts.Add(wheels);

        Outsourced chain = new Outsourced(Inventory.AllParts.Count(), "chain",  4, 10.86m, 2, 8, "google");
        Inventory.AllParts.Add(chain);

        Product bike = new Product(Inventory.Products.Count(), "Bike", 3, 129.35m, 1, 5);
        Inventory.Products.Add(bike);
        bike.AssociatedParts.Add(chain);
    }

    //Open add part window
    private void addPartButton_Click(object sender, EventArgs e)
    {
        AddPartWindow partsWindow = new AddPartWindow();
        partsWindow.ShowDialog();
    }

    //Open add product window
    private void addProductButton_Click(object sender, EventArgs e)
    {
        AddProductWindow productWindow = new AddProductWindow();
        productWindow.ShowDialog();
    }

    //Close dialog box
    private void exitButton_Click(object sender, EventArgs e)
    {
        Close();
    }


    // If modifying selected part, create the instance of partsWindow
    // Passes part to partsWindow instance
    private void modifyPartsButton_Click(object sender, EventArgs e)
    {
        AddPartWindow partsWindow = new AddPartWindow();
        partsWindow.isBeingModified = true;
        try {
            if (partsTable.SelectedRows[0].DataBoundItem.GetType() == typeof(Inhouse))
            {
                partsWindow.passedPart = (Inhouse)partsTable.SelectedRows[0].DataBoundItem;
            }
            else
            {
                partsWindow.passedPart = (Outsourced)partsTable.SelectedRows[0].DataBoundItem;
            }
            partsWindow.Text = "Modify Part";

            partsWindow.ShowDialog();
        }
        catch { Exception n; }


    }

    //Passes product instance to AddProductWindow and changes text from add to modify
    private void modifyProductButton_Click(object sender, EventArgs e)
    {
        try { 
        AddProductWindow productWindow = new AddProductWindow();
        productWindow.isBeingModified = true;
        productWindow.currentProduct = (Product)productsTable.SelectedRows[0].DataBoundItem;
        productWindow.Text = "Modify Product";
        productWindow.ShowDialog();
        }
        catch { Exception n; }
    }

    //Delete part function
    private void partDeleteButton_Click(object sender, EventArgs e)
    {
        string deleteMessage = "Are you sure you want to delete this part?";
        try
        {
            int id = Convert.ToInt32(partsTable.SelectedRows[0].Cells[0].Value);
                //Searches through AllParts and Products to see if any products have the part to-be-deleted, associated with them.
                for (int i = 0; i < Inventory.AllParts.Count(); i++)
                {
                    if (Inventory.AllParts[i].PartID == id)
                    {
                    Part toRemove = (Inventory.AllParts.ElementAt(i));
                        for(int j = 0; j < Inventory.Products.Count(); j++)
                    {
                            if (Inventory.Products[j].AssociatedParts.Contains(toRemove))
                            {
                            string errorProd = Inventory.Products[j].Name;
                            MessageBox.Show("Part exists in product: " + errorProd + ".");
                            return;
                            }
                    }
                    var messageBox = MessageBox.Show(deleteMessage, "Delete Part", MessageBoxButtons.YesNo);
                        if (messageBox == DialogResult.Yes)
                        {
                            Inventory.deletePart(toRemove);
                        }
                }
            }
        }
        catch { Exception n; }
        }

    //Finds the product based on the ID and removes it from Products
    private void productDeleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            Product prod = (Product)productsTable.SelectedRows[0].DataBoundItem;
            if(prod.AssociatedParts.Count() > 0)
            {
                MessageBox.Show("You cannot delete a product that has associated parts.");
                return;
            }

            int id = Convert.ToInt32(productsTable.SelectedRows[0].Cells[0].Value);

            string deleteMessage = "Are you sure you want to delete this product?";
            var messageBox = MessageBox.Show(deleteMessage, "Delete Product", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                Inventory.removeProduct(id);
            }
        }
        catch { Exception n; }
    }

    //Changes the selected row to the first row that contains the search phrase / id
    private void partsSearchButton_Click(object sender, EventArgs e)
    {
        try {
            string searchedVal = partsSearchTextBox.Text.ToString();
            for (int i = 0; i < Inventory.AllParts.Count(); i++)
            {
                string idVal = partsTable.Rows[i].Cells[0].Value.ToString();
                string nameVal = partsTable.Rows[i].Cells[1].Value.ToString();

                    if (idVal.Contains(searchedVal) || nameVal.Contains(searchedVal))
                    {
                        partsTable.Rows[i].Selected = true;
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

    //Changes the selected row to the first row that contains the search phrase / id
    private void productsSearchButton_Click(object sender, EventArgs e)
    {
        try
        {
            string searchedVal = productsSearchTextBox.Text.ToString();
            for (int i = 0; i < Inventory.Products.Count(); i++)
            {
                string idVal = productsTable.Rows[i].Cells[0].Value.ToString();
                string nameVal = productsTable.Rows[i].Cells[1].Value.ToString();

                if (idVal.Contains(searchedVal) || nameVal.Contains(searchedVal))
                {
                    productsTable.Rows[i].Selected = true;
                    return;
                }

            }
            MessageBox.Show("Product could not be found.");
        }
        catch 
        { 
            Exception n;
        }
    }
}







