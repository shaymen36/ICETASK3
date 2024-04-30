namespace CafeApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnDisplayReceipt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity: ";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(199, 18);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItems.TabIndex = 2;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(199, 76);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 3;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(55, 191);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(94, 23);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // btnDisplayReceipt
            // 
            this.btnDisplayReceipt.Location = new System.Drawing.Point(55, 257);
            this.btnDisplayReceipt.Name = "btnDisplayReceipt";
            this.btnDisplayReceipt.Size = new System.Drawing.Size(94, 23);
            this.btnDisplayReceipt.TabIndex = 5;
            this.btnDisplayReceipt.Text = "Display Receipt";
            this.btnDisplayReceipt.UseVisualStyleBackColor = true;
            this.btnDisplayReceipt.Click += new System.EventHandler(this.btnDisplayReceipt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayReceipt);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CafeApp";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnDisplayReceipt;
    }
}

