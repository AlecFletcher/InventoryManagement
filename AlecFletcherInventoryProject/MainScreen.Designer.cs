namespace AlecFletcherInventoryProject;

partial class MainScreen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.partsTextLabel = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchTextBox = new System.Windows.Forms.TextBox();
            this.productsTextLabel = new System.Windows.Forms.Label();
            this.productsSearchTextBox = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.partDeleteButton = new System.Windows.Forms.Button();
            this.modfyPartsButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // partsTextLabel
            // 
            this.partsTextLabel.AutoSize = true;
            this.partsTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partsTextLabel.Location = new System.Drawing.Point(12, 89);
            this.partsTextLabel.Name = "partsTextLabel";
            this.partsTextLabel.Size = new System.Drawing.Size(48, 21);
            this.partsTextLabel.TabIndex = 1;
            this.partsTextLabel.Text = "Parts";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsSearchButton.Location = new System.Drawing.Point(399, 85);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partsSearchButton.TabIndex = 2;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Location = new System.Drawing.Point(480, 85);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(178, 23);
            this.partsSearchTextBox.TabIndex = 3;
            // 
            // productsTextLabel
            // 
            this.productsTextLabel.AutoSize = true;
            this.productsTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productsTextLabel.Location = new System.Drawing.Point(680, 89);
            this.productsTextLabel.Name = "productsTextLabel";
            this.productsTextLabel.Size = new System.Drawing.Size(77, 21);
            this.productsTextLabel.TabIndex = 5;
            this.productsTextLabel.Text = "Products";
            // 
            // productsSearchTextBox
            // 
            this.productsSearchTextBox.Location = new System.Drawing.Point(1148, 84);
            this.productsSearchTextBox.Name = "productsSearchTextBox";
            this.productsSearchTextBox.Size = new System.Drawing.Size(178, 23);
            this.productsSearchTextBox.TabIndex = 7;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsSearchButton.Location = new System.Drawing.Point(1067, 84);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 6;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.productsSearchButton_Click);
            // 
            // productsTable
            // 
            this.productsTable.AllowUserToAddRows = false;
            this.productsTable.AllowUserToDeleteRows = false;
            this.productsTable.AllowUserToResizeColumns = false;
            this.productsTable.AllowUserToResizeRows = false;
            this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Location = new System.Drawing.Point(680, 113);
            this.productsTable.MultiSelect = false;
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.RowHeadersVisible = false;
            this.productsTable.RowTemplate.Height = 25;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.ShowCellErrors = false;
            this.productsTable.Size = new System.Drawing.Size(646, 392);
            this.productsTable.TabIndex = 8;
            // 
            // partDeleteButton
            // 
            this.partDeleteButton.Location = new System.Drawing.Point(594, 511);
            this.partDeleteButton.Name = "partDeleteButton";
            this.partDeleteButton.Size = new System.Drawing.Size(64, 37);
            this.partDeleteButton.TabIndex = 10;
            this.partDeleteButton.Text = "Delete";
            this.partDeleteButton.UseVisualStyleBackColor = true;
            this.partDeleteButton.Click += new System.EventHandler(this.partDeleteButton_Click);
            // 
            // modfyPartsButton
            // 
            this.modfyPartsButton.Location = new System.Drawing.Point(524, 511);
            this.modfyPartsButton.Name = "modfyPartsButton";
            this.modfyPartsButton.Size = new System.Drawing.Size(64, 37);
            this.modfyPartsButton.TabIndex = 11;
            this.modfyPartsButton.Text = "Modify";
            this.modfyPartsButton.UseVisualStyleBackColor = true;
            this.modfyPartsButton.Click += new System.EventHandler(this.modifyPartsButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(454, 511);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(64, 37);
            this.addPartButton.TabIndex = 12;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(1122, 511);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(64, 37);
            this.addProductButton.TabIndex = 15;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(1192, 511);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(64, 37);
            this.modifyProductButton.TabIndex = 14;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Location = new System.Drawing.Point(1262, 511);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(64, 37);
            this.productDeleteButton.TabIndex = 13;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1231, 623);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 57);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // partsTable
            // 
            this.partsTable.AllowUserToAddRows = false;
            this.partsTable.AllowUserToDeleteRows = false;
            this.partsTable.AllowUserToResizeColumns = false;
            this.partsTable.AllowUserToResizeRows = false;
            this.partsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.Location = new System.Drawing.Point(12, 114);
            this.partsTable.MultiSelect = false;
            this.partsTable.Name = "partsTable";
            this.partsTable.ReadOnly = true;
            this.partsTable.RowHeadersVisible = false;
            this.partsTable.RowTemplate.Height = 25;
            this.partsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsTable.ShowCellErrors = false;
            this.partsTable.Size = new System.Drawing.Size(646, 392);
            this.partsTable.TabIndex = 17;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 692);
            this.Controls.Add(this.partsTable);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.productDeleteButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.modfyPartsButton);
            this.Controls.Add(this.partDeleteButton);
            this.Controls.Add(this.productsTable);
            this.Controls.Add(this.productsSearchTextBox);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.productsTextLabel);
            this.Controls.Add(this.partsSearchTextBox);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.partsTextLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label partsTextLabel;
    private Button partsSearchButton;
    private TextBox partsSearchTextBox;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel tableLayoutPanel3;
    private Label productsTextLabel;
    private TextBox productsSearchTextBox;
    private Button productsSearchButton;
    private TableLayoutPanel tableLayoutPanel5;
    private TableLayoutPanel tableLayoutPanel6;
    private TableLayoutPanel tableLayoutPanel4;
    private DataGridView productsTable;
    private Button partDeleteButton;
    private Button modfyPartsButton;
    private Button addPartButton;
    private Button addProductButton;
    private Button modifyProductButton;
    private Button productDeleteButton;
    private Button exitButton;
    private DataGridView partsTable;
}
