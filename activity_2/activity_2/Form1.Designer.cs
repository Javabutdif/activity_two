namespace activity_2
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
       
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.wishList = new System.Windows.Forms.ListBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectionBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "WishList";
            // 
            // wishList
            // 
            this.wishList.FormattingEnabled = true;
            this.wishList.ItemHeight = 15;
            this.wishList.Location = new System.Drawing.Point(18, 51);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(125, 94);
            this.wishList.TabIndex = 1;
            this.wishList.SelectedIndexChanged += new System.EventHandler(this.wishList_SelectedIndexChanged);
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(160, 51);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(160, 80);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Filter";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(160, 109);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(160, 138);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 5;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(160, 167);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Count";
            // 
            // selectionBox
            // 
            this.selectionBox.Location = new System.Drawing.Point(73, 203);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(162, 23);
            this.selectionBox.TabIndex = 9;
            this.selectionBox.TextChanged += new System.EventHandler(this.selectionBox_TextChanged);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(73, 234);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(41, 23);
            this.countBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 277);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.selectionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.wishList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox wishList;
        private Button fillButton;
        private Button sortButton;
        private Button clearButton;
        private Button countButton;
        private Button closeButton;
        private Label label2;
        private Label label3;
        private TextBox selectionBox;
        private TextBox countBox;
    }
}