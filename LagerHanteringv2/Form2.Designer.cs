namespace LagerHanteringv2
{
    partial class Form2
    {

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
            this.components = new System.ComponentModel.Container();
            this.LCategory = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.LDescription = new System.Windows.Forms.Label();
            this.LQuantity = new System.Windows.Forms.Label();
            this.LPrice = new System.Windows.Forms.Label();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BTClear = new System.Windows.Forms.Button();
            this.BTAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LCategory
            // 
            this.LCategory.AutoSize = true;
            this.LCategory.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategory.Location = new System.Drawing.Point(29, 58);
            this.LCategory.Name = "LCategory";
            this.LCategory.Size = new System.Drawing.Size(108, 29);
            this.LCategory.TabIndex = 0;
            this.LCategory.Text = "Category:";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.BackColor = System.Drawing.Color.Silver;
            this.LName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(61, 140);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(76, 29);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name:";
            // 
            // LDescription
            // 
            this.LDescription.AutoSize = true;
            this.LDescription.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescription.Location = new System.Drawing.Point(7, 267);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(130, 29);
            this.LDescription.TabIndex = 2;
            this.LDescription.Text = "Description:";
            // 
            // LQuantity
            // 
            this.LQuantity.AutoSize = true;
            this.LQuantity.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LQuantity.Location = new System.Drawing.Point(31, 180);
            this.LQuantity.Name = "LQuantity";
            this.LQuantity.Size = new System.Drawing.Size(106, 29);
            this.LQuantity.TabIndex = 3;
            this.LQuantity.Text = "Quantity:";
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrice.Location = new System.Drawing.Point(67, 221);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(70, 29);
            this.LPrice.TabIndex = 4;
            this.LPrice.Text = "Price:";
            // 
            // CBCategory
            // 
            this.CBCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(143, 62);
            this.CBCategory.MaximumSize = new System.Drawing.Size(180, 0);
            this.CBCategory.MinimumSize = new System.Drawing.Size(180, 0);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(180, 28);
            this.CBCategory.TabIndex = 5;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(143, 144);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(272, 26);
            this.TBName.TabIndex = 6;
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(143, 271);
            this.TBDescription.Multiline = true;
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(272, 124);
            this.TBDescription.TabIndex = 7;
            // 
            // TBQuantity
            // 
            this.TBQuantity.Location = new System.Drawing.Point(143, 184);
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(272, 26);
            this.TBQuantity.TabIndex = 8;
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(143, 225);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(272, 26);
            this.TBPrice.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(441, 62);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(966, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 639);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add product:";
            // 
            // BTClear
            // 
            this.BTClear.BackColor = System.Drawing.Color.White;
            this.BTClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTClear.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTClear.ForeColor = System.Drawing.Color.Black;
            this.BTClear.Location = new System.Drawing.Point(143, 413);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(127, 47);
            this.BTClear.TabIndex = 12;
            this.BTClear.Text = "Clear";
            this.BTClear.UseVisualStyleBackColor = false;
            this.BTClear.Click += new System.EventHandler(this.BTClear_Click);
            // 
            // BTAdd
            // 
            this.BTAdd.BackColor = System.Drawing.Color.White;
            this.BTAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTAdd.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAdd.ForeColor = System.Drawing.Color.Black;
            this.BTAdd.Location = new System.Drawing.Point(288, 413);
            this.BTAdd.Name = "BTAdd";
            this.BTAdd.Size = new System.Drawing.Size(127, 47);
            this.BTAdd.TabIndex = 13;
            this.BTAdd.Text = "Add";
            this.BTAdd.UseVisualStyleBackColor = false;
            this.BTAdd.Click += new System.EventHandler(this.BTAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(213, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 66);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(5, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 66);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.Color.White;
            this.AddCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategoryButton.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryButton.ForeColor = System.Drawing.Color.Black;
            this.AddCategoryButton.Location = new System.Drawing.Point(329, 62);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(106, 28);
            this.AddCategoryButton.TabIndex = 18;
            this.AddCategoryButton.Text = "Add category";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1415, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 26);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1120, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search for product using name:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1461, 728);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1295, 728);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date and time:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1700, 763);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTAdd);
            this.Controls.Add(this.BTClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.TBQuantity);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.LPrice);
            this.Controls.Add(this.LQuantity);
            this.Controls.Add(this.LDescription);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LCategory);
            this.MaximumSize = new System.Drawing.Size(1722, 819);
            this.MinimumSize = new System.Drawing.Size(1722, 819);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LCategory;
        public System.Windows.Forms.Label LName;
        public System.Windows.Forms.Label LDescription;
        public System.Windows.Forms.Label LQuantity;
        public System.Windows.Forms.Label LPrice;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TBName;
        public System.Windows.Forms.TextBox TBDescription;
        public System.Windows.Forms.TextBox TBQuantity;
        public System.Windows.Forms.TextBox TBPrice;
        public System.Windows.Forms.Button BTClear;
        public System.Windows.Forms.Button BTAdd;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button AddCategoryButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}