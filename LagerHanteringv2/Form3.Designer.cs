namespace LagerHanteringv2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.LCategoryName = new System.Windows.Forms.Label();
            this.TxtBoxAddCategory = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LCategoryName
            // 
            this.LCategoryName.AutoSize = true;
            this.LCategoryName.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoryName.Location = new System.Drawing.Point(60, 90);
            this.LCategoryName.Name = "LCategoryName";
            this.LCategoryName.Size = new System.Drawing.Size(188, 31);
            this.LCategoryName.TabIndex = 1;
            this.LCategoryName.Text = "Category Name:";
            // 
            // TxtBoxAddCategory
            // 
            this.TxtBoxAddCategory.Location = new System.Drawing.Point(254, 95);
            this.TxtBoxAddCategory.Name = "TxtBoxAddCategory";
            this.TxtBoxAddCategory.Size = new System.Drawing.Size(281, 26);
            this.TxtBoxAddCategory.TabIndex = 2;
            this.TxtBoxAddCategory.TextChanged += new System.EventHandler(this.TxtBoxAddCategory_TextChanged);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.White;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(574, 112);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(127, 47);
            this.Button2.TabIndex = 14;
            this.Button2.Text = "Cancel";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(574, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(707, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TxtBoxAddCategory);
            this.Controls.Add(this.LCategoryName);
            this.Name = "Form3";
            this.Text = "Add category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LCategoryName;
        public System.Windows.Forms.TextBox TxtBoxAddCategory;
        public System.Windows.Forms.Button Button2;
        public System.Windows.Forms.Button button1;
    }
}