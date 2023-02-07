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
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.grpInputColor = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnQuantityVegAndFrGivenColor = new System.Windows.Forms.Button();
            this.BtnVegAndFrColorRedOrYellow = new System.Windows.Forms.Button();
            this.btnQuantityVegAndFrEachColor = new System.Windows.Forms.Button();
            this.grpCalories = new System.Windows.Forms.GroupBox();
            this.grpInputCalories = new System.Windows.Forms.GroupBox();
            this.BtnCalorieContentHigher = new System.Windows.Forms.Button();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.BtnCalorieContentBelow = new System.Windows.Forms.Button();
            this.nmrcDiapason1 = new System.Windows.Forms.NumericUpDown();
            this.grpDiapason = new System.Windows.Forms.GroupBox();
            this.nmrcDiapason2 = new System.Windows.Forms.NumericUpDown();
            this.BtnCalorieContentDiapason = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.grpColor.SuspendLayout();
            this.grpInputColor.SuspendLayout();
            this.grpCalories.SuspendLayout();
            this.grpInputCalories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcDiapason1)).BeginInit();
            this.grpDiapason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcDiapason2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(12, 12);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 23;
            this.mainGrid.Size = new System.Drawing.Size(539, 473);
            this.mainGrid.TabIndex = 0;
            // 
            // btnAllInformation
            // 
            this.btnAllInformation.AutoSize = true;
            this.btnAllInformation.Location = new System.Drawing.Point(557, 12);
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
            this.btnAllName.Location = new System.Drawing.Point(557, 41);
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
            this.btnAllColor.Location = new System.Drawing.Point(557, 70);
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
            this.BtnMaxCalories.Location = new System.Drawing.Point(650, 12);
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
            this.BtnMinCalories.Location = new System.Drawing.Point(650, 41);
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
            this.BtnAvgCalories.Location = new System.Drawing.Point(650, 70);
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
            this.BtnQuantityVegetables.Location = new System.Drawing.Point(743, 12);
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
            this.BtnQuantityFruits.Location = new System.Drawing.Point(743, 41);
            this.BtnQuantityFruits.Name = "BtnQuantityFruits";
            this.BtnQuantityFruits.Size = new System.Drawing.Size(115, 23);
            this.BtnQuantityFruits.TabIndex = 8;
            this.BtnQuantityFruits.Text = "Quantity Fruits";
            this.BtnQuantityFruits.UseVisualStyleBackColor = true;
            this.BtnQuantityFruits.Click += new System.EventHandler(this.BtnQuantityFruits_Click);
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.grpInputColor);
            this.grpColor.Controls.Add(this.BtnVegAndFrColorRedOrYellow);
            this.grpColor.Controls.Add(this.btnQuantityVegAndFrEachColor);
            this.grpColor.Location = new System.Drawing.Point(557, 99);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(301, 163);
            this.grpColor.TabIndex = 9;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // grpInputColor
            // 
            this.grpInputColor.Controls.Add(this.txtColor);
            this.grpInputColor.Controls.Add(this.btnQuantityVegAndFrGivenColor);
            this.grpInputColor.Location = new System.Drawing.Point(6, 20);
            this.grpInputColor.Name = "grpInputColor";
            this.grpInputColor.Size = new System.Drawing.Size(284, 81);
            this.grpInputColor.TabIndex = 10;
            this.grpInputColor.TabStop = false;
            this.grpInputColor.Text = "Input Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(6, 20);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(272, 21);
            this.txtColor.TabIndex = 0;
            // 
            // btnQuantityVegAndFrGivenColor
            // 
            this.btnQuantityVegAndFrGivenColor.AutoSize = true;
            this.btnQuantityVegAndFrGivenColor.Location = new System.Drawing.Point(6, 47);
            this.btnQuantityVegAndFrGivenColor.Name = "btnQuantityVegAndFrGivenColor";
            this.btnQuantityVegAndFrGivenColor.Size = new System.Drawing.Size(272, 23);
            this.btnQuantityVegAndFrGivenColor.TabIndex = 10;
            this.btnQuantityVegAndFrGivenColor.Text = "Quantity Veg And Fr Given Color";
            this.btnQuantityVegAndFrGivenColor.UseVisualStyleBackColor = true;
            this.btnQuantityVegAndFrGivenColor.Click += new System.EventHandler(this.BtnQuantityVegAndFrGivenColor_Click);
            // 
            // BtnVegAndFrColorRedOrYellow
            // 
            this.BtnVegAndFrColorRedOrYellow.AutoSize = true;
            this.BtnVegAndFrColorRedOrYellow.Location = new System.Drawing.Point(6, 134);
            this.BtnVegAndFrColorRedOrYellow.Name = "BtnVegAndFrColorRedOrYellow";
            this.BtnVegAndFrColorRedOrYellow.Size = new System.Drawing.Size(284, 23);
            this.BtnVegAndFrColorRedOrYellow.TabIndex = 12;
            this.BtnVegAndFrColorRedOrYellow.Text = "Veg And Fr Color Red Or Yellow";
            this.BtnVegAndFrColorRedOrYellow.UseVisualStyleBackColor = true;
            this.BtnVegAndFrColorRedOrYellow.Click += new System.EventHandler(this.BtnVegAndFrColorRedOrYellow_Click);
            // 
            // btnQuantityVegAndFrEachColor
            // 
            this.btnQuantityVegAndFrEachColor.AutoSize = true;
            this.btnQuantityVegAndFrEachColor.Location = new System.Drawing.Point(6, 105);
            this.btnQuantityVegAndFrEachColor.Name = "btnQuantityVegAndFrEachColor";
            this.btnQuantityVegAndFrEachColor.Size = new System.Drawing.Size(284, 23);
            this.btnQuantityVegAndFrEachColor.TabIndex = 11;
            this.btnQuantityVegAndFrEachColor.Text = "Quantity Veg And Fr Each Color";
            this.btnQuantityVegAndFrEachColor.UseVisualStyleBackColor = true;
            this.btnQuantityVegAndFrEachColor.Click += new System.EventHandler(this.BtnQuantityVegAndFrEachColor_Click);
            // 
            // grpCalories
            // 
            this.grpCalories.Controls.Add(this.grpDiapason);
            this.grpCalories.Controls.Add(this.grpInputCalories);
            this.grpCalories.Location = new System.Drawing.Point(557, 268);
            this.grpCalories.Name = "grpCalories";
            this.grpCalories.Size = new System.Drawing.Size(301, 217);
            this.grpCalories.TabIndex = 10;
            this.grpCalories.TabStop = false;
            this.grpCalories.Text = "Calories";
            // 
            // grpInputCalories
            // 
            this.grpInputCalories.Controls.Add(this.BtnCalorieContentHigher);
            this.grpInputCalories.Controls.Add(this.txtCalories);
            this.grpInputCalories.Controls.Add(this.BtnCalorieContentBelow);
            this.grpInputCalories.Location = new System.Drawing.Point(6, 20);
            this.grpInputCalories.Name = "grpInputCalories";
            this.grpInputCalories.Size = new System.Drawing.Size(284, 106);
            this.grpInputCalories.TabIndex = 11;
            this.grpInputCalories.TabStop = false;
            this.grpInputCalories.Text = "Input Calories";
            // 
            // BtnCalorieContentHigher
            // 
            this.BtnCalorieContentHigher.AutoSize = true;
            this.BtnCalorieContentHigher.Location = new System.Drawing.Point(6, 76);
            this.BtnCalorieContentHigher.Name = "BtnCalorieContentHigher";
            this.BtnCalorieContentHigher.Size = new System.Drawing.Size(272, 23);
            this.BtnCalorieContentHigher.TabIndex = 11;
            this.BtnCalorieContentHigher.Text = "Veg And Fr Calorie Content Higher";
            this.BtnCalorieContentHigher.UseVisualStyleBackColor = true;
            this.BtnCalorieContentHigher.Click += new System.EventHandler(this.BtnCalorieContentHigher_Click);
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(6, 20);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(272, 21);
            this.txtCalories.TabIndex = 0;
            // 
            // BtnCalorieContentBelow
            // 
            this.BtnCalorieContentBelow.AutoSize = true;
            this.BtnCalorieContentBelow.Location = new System.Drawing.Point(6, 47);
            this.BtnCalorieContentBelow.Name = "BtnCalorieContentBelow";
            this.BtnCalorieContentBelow.Size = new System.Drawing.Size(272, 23);
            this.BtnCalorieContentBelow.TabIndex = 10;
            this.BtnCalorieContentBelow.Text = "Veg And Fr Calorie Content Below";
            this.BtnCalorieContentBelow.UseVisualStyleBackColor = true;
            this.BtnCalorieContentBelow.Click += new System.EventHandler(this.BtnCalorieContentBelow_Click);
            // 
            // nmrcDiapason1
            // 
            this.nmrcDiapason1.Location = new System.Drawing.Point(6, 20);
            this.nmrcDiapason1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcDiapason1.Name = "nmrcDiapason1";
            this.nmrcDiapason1.Size = new System.Drawing.Size(129, 21);
            this.nmrcDiapason1.TabIndex = 12;
            // 
            // grpDiapason
            // 
            this.grpDiapason.Controls.Add(this.BtnCalorieContentDiapason);
            this.grpDiapason.Controls.Add(this.nmrcDiapason2);
            this.grpDiapason.Controls.Add(this.nmrcDiapason1);
            this.grpDiapason.Location = new System.Drawing.Point(6, 132);
            this.grpDiapason.Name = "grpDiapason";
            this.grpDiapason.Size = new System.Drawing.Size(284, 79);
            this.grpDiapason.TabIndex = 12;
            this.grpDiapason.TabStop = false;
            this.grpDiapason.Text = "Diapason";
            // 
            // nmrcDiapason2
            // 
            this.nmrcDiapason2.Location = new System.Drawing.Point(151, 20);
            this.nmrcDiapason2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcDiapason2.Name = "nmrcDiapason2";
            this.nmrcDiapason2.Size = new System.Drawing.Size(127, 21);
            this.nmrcDiapason2.TabIndex = 13;
            // 
            // BtnCalorieContentDiapason
            // 
            this.BtnCalorieContentDiapason.AutoSize = true;
            this.BtnCalorieContentDiapason.Location = new System.Drawing.Point(6, 47);
            this.BtnCalorieContentDiapason.Name = "BtnCalorieContentDiapason";
            this.BtnCalorieContentDiapason.Size = new System.Drawing.Size(272, 23);
            this.BtnCalorieContentDiapason.TabIndex = 12;
            this.BtnCalorieContentDiapason.Text = "Veg And Fr Calorie Content Diapason";
            this.BtnCalorieContentDiapason.UseVisualStyleBackColor = true;
            this.BtnCalorieContentDiapason.Click += new System.EventHandler(this.BtnCalorieContentDiapason_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 487);
            this.Controls.Add(this.grpCalories);
            this.Controls.Add(this.grpColor);
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
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpInputColor.ResumeLayout(false);
            this.grpInputColor.PerformLayout();
            this.grpCalories.ResumeLayout(false);
            this.grpInputCalories.ResumeLayout(false);
            this.grpInputCalories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcDiapason1)).EndInit();
            this.grpDiapason.ResumeLayout(false);
            this.grpDiapason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcDiapason2)).EndInit();
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
        private GroupBox grpColor;
        private Button btnQuantityVegAndFrGivenColor;
        private TextBox txtColor;
        private Button btnQuantityVegAndFrEachColor;
        private Button BtnVegAndFrColorRedOrYellow;
        private GroupBox grpInputColor;
        private GroupBox grpCalories;
        private GroupBox grpInputCalories;
        private TextBox txtCalories;
        private Button BtnCalorieContentBelow;
        private Button BtnCalorieContentHigher;
        private GroupBox grpDiapason;
        private Button BtnCalorieContentDiapason;
        private NumericUpDown nmrcDiapason2;
        private NumericUpDown nmrcDiapason1;
    }
}