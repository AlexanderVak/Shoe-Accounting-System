namespace Shoe_Accounting_System
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorDbx = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShoeTypeDbx = new System.Windows.Forms.ComboBox();
            this.MaterialDbx = new System.Windows.Forms.ComboBox();
            this.SizeTxbx = new System.Windows.Forms.TextBox();
            this.WeightTxtbx = new System.Windows.Forms.TextBox();
            this.SoleTypeDbx = new System.Windows.Forms.ComboBox();
            this.ShoesTypeLbl = new System.Windows.Forms.Label();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.MaterialLbl = new System.Windows.Forms.Label();
            this.SoleTypeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenderDbx = new System.Windows.Forms.ComboBox();
            this.AddShoesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorDbx
            // 
            this.ColorDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorDbx.FormattingEnabled = true;
            this.ColorDbx.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Grey",
            "Orange",
            "Pink",
            "Red",
            "White",
            "Yellow"});
            this.ColorDbx.Location = new System.Drawing.Point(335, 40);
            this.ColorDbx.Name = "ColorDbx";
            this.ColorDbx.Size = new System.Drawing.Size(63, 21);
            this.ColorDbx.TabIndex = 1;
            this.ColorDbx.TextChanged += new System.EventHandler(this.ShoeTypeDbx_TextChanged);
            this.ColorDbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShoeTypeDbx_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 193);
            this.dataGridView1.TabIndex = 2;
            // 
            // ShoeTypeDbx
            // 
            this.ShoeTypeDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShoeTypeDbx.FormattingEnabled = true;
            this.ShoeTypeDbx.Items.AddRange(new object[] {
            "Sport Shoes",
            "Model Shoes",
            "Slippers",
            "Broges",
            "Boots"});
            this.ShoeTypeDbx.Location = new System.Drawing.Point(47, 40);
            this.ShoeTypeDbx.Name = "ShoeTypeDbx";
            this.ShoeTypeDbx.Size = new System.Drawing.Size(88, 21);
            this.ShoeTypeDbx.TabIndex = 3;
            this.ShoeTypeDbx.TextChanged += new System.EventHandler(this.ShoeTypeDbx_TextChanged);
            this.ShoeTypeDbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShoeTypeDbx_KeyPress);
            // 
            // MaterialDbx
            // 
            this.MaterialDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialDbx.FormattingEnabled = true;
            this.MaterialDbx.Items.AddRange(new object[] {
            "Leather",
            "Textiles",
            "Synthetics",
            "Rubber"});
            this.MaterialDbx.Location = new System.Drawing.Point(420, 40);
            this.MaterialDbx.Name = "MaterialDbx";
            this.MaterialDbx.Size = new System.Drawing.Size(63, 21);
            this.MaterialDbx.TabIndex = 4;
            this.MaterialDbx.TextChanged += new System.EventHandler(this.ShoeTypeDbx_TextChanged);
            this.MaterialDbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShoeTypeDbx_KeyPress);
            // 
            // SizeTxbx
            // 
            this.SizeTxbx.Location = new System.Drawing.Point(159, 40);
            this.SizeTxbx.Name = "SizeTxbx";
            this.SizeTxbx.Size = new System.Drawing.Size(63, 20);
            this.SizeTxbx.TabIndex = 5;
            this.SizeTxbx.TextChanged += new System.EventHandler(this.ShoeTypeDbx_TextChanged);
            this.SizeTxbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeTxbx_KeyPress);
            // 
            // WeightTxtbx
            // 
            this.WeightTxtbx.Location = new System.Drawing.Point(244, 39);
            this.WeightTxtbx.Name = "WeightTxtbx";
            this.WeightTxtbx.Size = new System.Drawing.Size(63, 20);
            this.WeightTxtbx.TabIndex = 6;
            this.WeightTxtbx.TextChanged += new System.EventHandler(this.ShoeTypeDbx_TextChanged);
            this.WeightTxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTxbx_KeyPress);
            // 
            // SoleTypeDbx
            // 
            this.SoleTypeDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoleTypeDbx.FormattingEnabled = true;
            this.SoleTypeDbx.Items.AddRange(new object[] {
            "Heel",
            "Platform",
            "Wedge heel",
            "Stiletto heel"});
            this.SoleTypeDbx.Location = new System.Drawing.Point(585, 40);
            this.SoleTypeDbx.Name = "SoleTypeDbx";
            this.SoleTypeDbx.Size = new System.Drawing.Size(63, 21);
            this.SoleTypeDbx.TabIndex = 7;
            this.SoleTypeDbx.TextChanged += new System.EventHandler(this.ShoeTypeDbx_TextChanged);
            this.SoleTypeDbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShoeTypeDbx_KeyPress);
            // 
            // ShoesTypeLbl
            // 
            this.ShoesTypeLbl.AutoSize = true;
            this.ShoesTypeLbl.Location = new System.Drawing.Point(44, 24);
            this.ShoesTypeLbl.Name = "ShoesTypeLbl";
            this.ShoesTypeLbl.Size = new System.Drawing.Size(64, 13);
            this.ShoesTypeLbl.TabIndex = 10;
            this.ShoesTypeLbl.Text = "Shoes Type";
            // 
            // SizeLbl
            // 
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.Location = new System.Drawing.Point(156, 24);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(27, 13);
            this.SizeLbl.TabIndex = 11;
            this.SizeLbl.Text = "Size";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(241, 24);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(41, 13);
            this.WeightLbl.TabIndex = 12;
            this.WeightLbl.Text = "Weight";
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.Location = new System.Drawing.Point(332, 24);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(31, 13);
            this.ColorLbl.TabIndex = 13;
            this.ColorLbl.Text = "Color";
            // 
            // MaterialLbl
            // 
            this.MaterialLbl.AutoSize = true;
            this.MaterialLbl.Location = new System.Drawing.Point(417, 24);
            this.MaterialLbl.Name = "MaterialLbl";
            this.MaterialLbl.Size = new System.Drawing.Size(44, 13);
            this.MaterialLbl.TabIndex = 14;
            this.MaterialLbl.Text = "Material";
            // 
            // SoleTypeLbl
            // 
            this.SoleTypeLbl.AutoSize = true;
            this.SoleTypeLbl.Location = new System.Drawing.Point(582, 24);
            this.SoleTypeLbl.Name = "SoleTypeLbl";
            this.SoleTypeLbl.Size = new System.Drawing.Size(55, 13);
            this.SoleTypeLbl.TabIndex = 15;
            this.SoleTypeLbl.Text = "Sole Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gender";
            // 
            // GenderDbx
            // 
            this.GenderDbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderDbx.FormattingEnabled = true;
            this.GenderDbx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderDbx.Location = new System.Drawing.Point(502, 40);
            this.GenderDbx.Name = "GenderDbx";
            this.GenderDbx.Size = new System.Drawing.Size(63, 21);
            this.GenderDbx.TabIndex = 16;
            this.GenderDbx.TextChanged += new System.EventHandler(this.ShoeTypeDbx_TextChanged);
            this.GenderDbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShoeTypeDbx_KeyPress);
            // 
            // AddShoesButton
            // 
            this.AddShoesButton.Location = new System.Drawing.Point(301, 116);
            this.AddShoesButton.Name = "AddShoesButton";
            this.AddShoesButton.Size = new System.Drawing.Size(121, 41);
            this.AddShoesButton.TabIndex = 18;
            this.AddShoesButton.Text = "Add Shoes";
            this.AddShoesButton.UseVisualStyleBackColor = true;
            this.AddShoesButton.Click += new System.EventHandler(this.AddShoesButton_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.AddShoesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenderDbx);
            this.Controls.Add(this.SoleTypeLbl);
            this.Controls.Add(this.MaterialLbl);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.SizeLbl);
            this.Controls.Add(this.ShoesTypeLbl);
            this.Controls.Add(this.SoleTypeDbx);
            this.Controls.Add(this.WeightTxtbx);
            this.Controls.Add(this.SizeTxbx);
            this.Controls.Add(this.MaterialDbx);
            this.Controls.Add(this.ShoeTypeDbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ColorDbx);
            this.Name = "Main_Form";
            this.Text = "Shoe accounting system";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ShoeTypeDbx;
        private System.Windows.Forms.ComboBox MaterialDbx;
        private System.Windows.Forms.TextBox SizeTxbx;
        private System.Windows.Forms.ComboBox SoleTypeDbx;
        private System.Windows.Forms.Label ShoesTypeLbl;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label ColorLbl;
        private System.Windows.Forms.Label MaterialLbl;
        private System.Windows.Forms.Label SoleTypeLbl;
        public System.Windows.Forms.ComboBox ColorDbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GenderDbx;
        private System.Windows.Forms.TextBox WeightTxtbx;
        private System.Windows.Forms.Button AddShoesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

