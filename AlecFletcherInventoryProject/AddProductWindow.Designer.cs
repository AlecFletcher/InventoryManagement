namespace AlecFletcherInventoryProject
{
    partial class AddProductWindow
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
            this.addProductLabel = new System.Windows.Forms.Label();
            this.IDTextLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.candidatePartsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.candidatePartsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchTextBox = new System.Windows.Forms.TextBox();
            this.addCandidatePartButton = new System.Windows.Forms.Button();
            this.associatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductLabel.Location = new System.Drawing.Point(12, 9);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(105, 21);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add Product";
            // 
            // IDTextLabel
            // 
            this.IDTextLabel.AutoSize = true;
            this.IDTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDTextLabel.Location = new System.Drawing.Point(24, 200);
            this.IDTextLabel.Name = "IDTextLabel";
            this.IDTextLabel.Size = new System.Drawing.Size(25, 21);
            this.IDTextLabel.TabIndex = 3;
            this.IDTextLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(119, 200);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(205, 23);
            this.IDTextBox.TabIndex = 4;
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextLabel.Location = new System.Drawing.Point(24, 257);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(52, 21);
            this.nameTextLabel.TabIndex = 5;
            this.nameTextLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nameTextBox.Location = new System.Drawing.Point(119, 259);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(205, 23);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // inventoryTextLabel
            // 
            this.inventoryTextLabel.AutoSize = true;
            this.inventoryTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryTextLabel.Location = new System.Drawing.Point(24, 318);
            this.inventoryTextLabel.Name = "inventoryTextLabel";
            this.inventoryTextLabel.Size = new System.Drawing.Size(76, 21);
            this.inventoryTextLabel.TabIndex = 7;
            this.inventoryTextLabel.Text = "Inventory";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inventoryTextBox.Location = new System.Drawing.Point(119, 320);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(205, 23);
            this.inventoryTextBox.TabIndex = 8;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.priceTextBox.Location = new System.Drawing.Point(119, 381);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(205, 23);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(24, 379);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(89, 21);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price / Cost";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minLabel.Location = new System.Drawing.Point(24, 439);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(37, 21);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Min";
            // 
            // minTextBox
            // 
            this.minTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.minTextBox.Location = new System.Drawing.Point(81, 439);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(88, 23);
            this.minTextBox.TabIndex = 12;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxLabel.Location = new System.Drawing.Point(229, 439);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(39, 21);
            this.maxLabel.TabIndex = 13;
            this.maxLabel.Text = "Max";
            // 
            // maxTextBox
            // 
            this.maxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.maxTextBox.Location = new System.Drawing.Point(291, 439);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(92, 23);
            this.maxTextBox.TabIndex = 14;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(775, 611);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 40);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(848, 611);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(65, 40);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(919, 611);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(68, 40);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // candidatePartsGrid
            // 
            this.candidatePartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsGrid.Location = new System.Drawing.Point(418, 66);
            this.candidatePartsGrid.MultiSelect = false;
            this.candidatePartsGrid.Name = "candidatePartsGrid";
            this.candidatePartsGrid.ReadOnly = true;
            this.candidatePartsGrid.RowHeadersVisible = false;
            this.candidatePartsGrid.RowTemplate.Height = 25;
            this.candidatePartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatePartsGrid.Size = new System.Drawing.Size(569, 216);
            this.candidatePartsGrid.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "All Candidate Parts";
            // 
            // candidatePartsSearchButton
            // 
            this.candidatePartsSearchButton.Location = new System.Drawing.Point(747, 27);
            this.candidatePartsSearchButton.Name = "candidatePartsSearchButton";
            this.candidatePartsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.candidatePartsSearchButton.TabIndex = 22;
            this.candidatePartsSearchButton.Text = "Search";
            this.candidatePartsSearchButton.UseVisualStyleBackColor = true;
            this.candidatePartsSearchButton.Click += new System.EventHandler(this.candidatePartsSearchButton_Click);
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Location = new System.Drawing.Point(828, 27);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(159, 23);
            this.partsSearchTextBox.TabIndex = 23;
            // 
            // addCandidatePartButton
            // 
            this.addCandidatePartButton.Location = new System.Drawing.Point(929, 288);
            this.addCandidatePartButton.Name = "addCandidatePartButton";
            this.addCandidatePartButton.Size = new System.Drawing.Size(58, 40);
            this.addCandidatePartButton.TabIndex = 24;
            this.addCandidatePartButton.Text = "Add";
            this.addCandidatePartButton.UseVisualStyleBackColor = true;
            this.addCandidatePartButton.Click += new System.EventHandler(this.addCandidatePartButton_Click);
            // 
            // associatedPartsGrid
            // 
            this.associatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGrid.Location = new System.Drawing.Point(418, 381);
            this.associatedPartsGrid.MultiSelect = false;
            this.associatedPartsGrid.Name = "associatedPartsGrid";
            this.associatedPartsGrid.ReadOnly = true;
            this.associatedPartsGrid.RowHeadersVisible = false;
            this.associatedPartsGrid.RowTemplate.Height = 25;
            this.associatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGrid.Size = new System.Drawing.Size(569, 224);
            this.associatedPartsGrid.TabIndex = 25;
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.associatedPartsLabel.Location = new System.Drawing.Point(418, 357);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(243, 21);
            this.associatedPartsLabel.TabIndex = 26;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // AddProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 690);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.associatedPartsGrid);
            this.Controls.Add(this.addCandidatePartButton);
            this.Controls.Add(this.partsSearchTextBox);
            this.Controls.Add(this.candidatePartsSearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.candidatePartsGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryTextLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameTextLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDTextLabel);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProductWindow";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label addProductLabel;
        private Label IDTextLabel;
        private TextBox IDTextBox;
        private Label nameTextLabel;
        private TextBox nameTextBox;
        private Label inventoryTextLabel;
        private TextBox inventoryTextBox;
        private TextBox priceTextBox;
        private Label priceLabel;
        private Label minLabel;
        private TextBox minTextBox;
        private Label maxLabel;
        private TextBox maxTextBox;
        private Button saveButton;
        private Button cancelButton;
        private Button deleteButton;
        private DataGridView candidatePartsGrid;
        private Label label1;
        private Button candidatePartsSearchButton;
        private TextBox partsSearchTextBox;
        private Button addCandidatePartButton;
        private DataGridView associatedPartsGrid;
        private Label associatedPartsLabel;
    }
}