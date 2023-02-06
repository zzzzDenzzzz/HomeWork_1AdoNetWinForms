namespace HomeWork_1AdoNetWinForms
{
    partial class Form1
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
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.btnAllInformation = new System.Windows.Forms.Button();
            this.btnAllName = new System.Windows.Forms.Button();
            this.btnAllColor = new System.Windows.Forms.Button();
            this.BtnMaxCalories = new System.Windows.Forms.Button();
            this.BtnMinCalories = new System.Windows.Forms.Button();
            this.BtnAvgCalories = new System.Windows.Forms.Button();
            this.BtnQuantityVegetables = new System.Windows.Forms.Button();
            this.BtnQuantityFruits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(12, 12);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 23;
            this.mainGrid.Size = new System.Drawing.Size(683, 426);
            this.mainGrid.TabIndex = 0;
            // 
            // btnAllInformation
            // 
            this.btnAllInformation.AutoSize = true;
            this.btnAllInformation.Location = new System.Drawing.Point(701, 12);
            this.btnAllInformation.Name = "btnAllInformation";
            this.btnAllInformation.Size = new System.Drawing.Size(87, 23);
            this.btnAllInformation.TabIndex = 1;
            this.btnAllInformation.Text = "All Information";
            this.btnAllInformation.UseVisualStyleBackColor = true;
            this.btnAllInformation.Click += new System.EventHandler(this.BtnAllInformation_Click);
            // 
            // btnAllName
            // 
            this.btnAllName.AutoSize = true;
            this.btnAllName.Location = new System.Drawing.Point(701, 41);
            this.btnAllName.Name = "btnAllName";
            this.btnAllName.Size = new System.Drawing.Size(87, 23);
            this.btnAllName.TabIndex = 2;
            this.btnAllName.Text = "All Name";
            this.btnAllName.UseVisualStyleBackColor = true;
            this.btnAllName.Click += new System.EventHandler(this.BtnAllName_Click);
            // 
            // btnAllColor
            // 
            this.btnAllColor.AutoSize = true;
            this.btnAllColor.Location = new System.Drawing.Point(701, 70);
            this.btnAllColor.Name = "btnAllColor";
            this.btnAllColor.Size = new System.Drawing.Size(87, 23);
            this.btnAllColor.TabIndex = 3;
            this.btnAllColor.Text = "All Color";
            this.btnAllColor.UseVisualStyleBackColor = true;
            this.btnAllColor.Click += new System.EventHandler(this.BtnAllColor_Click);
            // 
            // BtnMaxCalories
            // 
            this.BtnMaxCalories.AutoSize = true;
            this.BtnMaxCalories.Location = new System.Drawing.Point(701, 99);
            this.BtnMaxCalories.Name = "BtnMaxCalories";
            this.BtnMaxCalories.Size = new System.Drawing.Size(87, 23);
            this.BtnMaxCalories.TabIndex = 4;
            this.BtnMaxCalories.Text = "Max Calories";
            this.BtnMaxCalories.UseVisualStyleBackColor = true;
            this.BtnMaxCalories.Click += new System.EventHandler(this.BtnMaxCalories_Click);
            // 
            // BtnMinCalories
            // 
            this.BtnMinCalories.AutoSize = true;
            this.BtnMinCalories.Location = new System.Drawing.Point(701, 128);
            this.BtnMinCalories.Name = "BtnMinCalories";
            this.BtnMinCalories.Size = new System.Drawing.Size(87, 23);
            this.BtnMinCalories.TabIndex = 5;
            this.BtnMinCalories.Text = "Min Calories";
            this.BtnMinCalories.UseVisualStyleBackColor = true;
            this.BtnMinCalories.Click += new System.EventHandler(this.BtnMinCalories_Click);
            // 
            // BtnAvgCalories
            // 
            this.BtnAvgCalories.AutoSize = true;
            this.BtnAvgCalories.Location = new System.Drawing.Point(701, 157);
            this.BtnAvgCalories.Name = "BtnAvgCalories";
            this.BtnAvgCalories.Size = new System.Drawing.Size(87, 23);
            this.BtnAvgCalories.TabIndex = 6;
            this.BtnAvgCalories.Text = "Avg Calories";
            this.BtnAvgCalories.UseVisualStyleBackColor = true;
            this.BtnAvgCalories.Click += new System.EventHandler(this.BtnAvgCalories_Click);
            // 
            // BtnQuantityVegetables
            // 
            this.BtnQuantityVegetables.AutoSize = true;
            this.BtnQuantityVegetables.Location = new System.Drawing.Point(794, 12);
            this.BtnQuantityVegetables.Name = "BtnQuantityVegetables";
            this.BtnQuantityVegetables.Size = new System.Drawing.Size(115, 23);
            this.BtnQuantityVegetables.TabIndex = 7;
            this.BtnQuantityVegetables.Text = "Quantity Vegetables";
            this.BtnQuantityVegetables.UseVisualStyleBackColor = true;
            this.BtnQuantityVegetables.Click += new System.EventHandler(this.BtnQuantityVegetables_Click);
            // 
            // BtnQuantityFruits
            // 
            this.BtnQuantityFruits.AutoSize = true;
            this.BtnQuantityFruits.Location = new System.Drawing.Point(794, 41);
            this.BtnQuantityFruits.Name = "BtnQuantityFruits";
            this.BtnQuantityFruits.Size = new System.Drawing.Size(115, 23);
            this.BtnQuantityFruits.TabIndex = 8;
            this.BtnQuantityFruits.Text = "Quantity Fruits";
            this.BtnQuantityFruits.UseVisualStyleBackColor = true;
            this.BtnQuantityFruits.Click += new System.EventHandler(this.BtnQuantityFruits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.BtnQuantityFruits);
            this.Controls.Add(this.BtnQuantityVegetables);
            this.Controls.Add(this.BtnAvgCalories);
            this.Controls.Add(this.BtnMinCalories);
            this.Controls.Add(this.BtnMaxCalories);
            this.Controls.Add(this.btnAllColor);
            this.Controls.Add(this.btnAllName);
            this.Controls.Add(this.btnAllInformation);
            this.Controls.Add(this.mainGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView mainGrid;
        private Button btnAllInformation;
        private Button btnAllName;
        private Button btnAllColor;
        private Button BtnMaxCalories;
        private Button BtnMinCalories;
        private Button BtnAvgCalories;
        private Button BtnQuantityVegetables;
        private Button BtnQuantityFruits;
    }
}