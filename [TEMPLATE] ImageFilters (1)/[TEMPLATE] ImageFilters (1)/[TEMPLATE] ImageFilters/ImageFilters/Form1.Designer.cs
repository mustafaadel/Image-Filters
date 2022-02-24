namespace ImageFilters
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filtredPicture = new System.Windows.Forms.PictureBox();
            this.notFilteredPicture = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sortTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.btnZGraphAdaptive = new System.Windows.Forms.Button();
            this.btnZGraphAlpha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tvalue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtredPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notFilteredPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filtredPicture);
            this.groupBox1.Controls.Add(this.notFilteredPicture);
            this.groupBox1.Location = new System.Drawing.Point(26, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1832, 680);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1696, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 35);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1696, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // filtredPicture
            // 
            this.filtredPicture.Location = new System.Drawing.Point(855, 28);
            this.filtredPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filtredPicture.Name = "filtredPicture";
            this.filtredPicture.Size = new System.Drawing.Size(810, 625);
            this.filtredPicture.TabIndex = 1;
            this.filtredPicture.TabStop = false;
            // 
            // notFilteredPicture
            // 
            this.notFilteredPicture.Location = new System.Drawing.Point(33, 28);
            this.notFilteredPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notFilteredPicture.Name = "notFilteredPicture";
            this.notFilteredPicture.Size = new System.Drawing.Size(810, 625);
            this.notFilteredPicture.TabIndex = 0;
            this.notFilteredPicture.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(38, 28);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(180, 77);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Size";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(1266, 34);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(148, 48);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sortTypeComboBox
            // 
            this.sortTypeComboBox.FormattingEnabled = true;
            this.sortTypeComboBox.Items.AddRange(new object[] {
            "1) Quick Sort",
            "2) Counting Sort",
            "3) Select K value"});
            this.sortTypeComboBox.Location = new System.Drawing.Point(974, 29);
            this.sortTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortTypeComboBox.Name = "sortTypeComboBox";
            this.sortTypeComboBox.Size = new System.Drawing.Size(266, 28);
            this.sortTypeComboBox.TabIndex = 6;
            this.sortTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filterationTypeComboBox
            // 
            this.filterationTypeComboBox.FormattingEnabled = true;
            this.filterationTypeComboBox.Items.AddRange(new object[] {
            "1) Alpha-trim filter",
            "2) Adaptive median filter"});
            this.filterationTypeComboBox.Location = new System.Drawing.Point(974, 71);
            this.filterationTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterationTypeComboBox.Name = "filterationTypeComboBox";
            this.filterationTypeComboBox.Size = new System.Drawing.Size(266, 28);
            this.filterationTypeComboBox.TabIndex = 7;
            this.filterationTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnZGraphAdaptive
            // 
            this.btnZGraphAdaptive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZGraphAdaptive.Location = new System.Drawing.Point(1424, 34);
            this.btnZGraphAdaptive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZGraphAdaptive.Name = "btnZGraphAdaptive";
            this.btnZGraphAdaptive.Size = new System.Drawing.Size(158, 48);
            this.btnZGraphAdaptive.TabIndex = 3;
            this.btnZGraphAdaptive.Text = "Adaptive";
            this.btnZGraphAdaptive.UseVisualStyleBackColor = true;
            this.btnZGraphAdaptive.Click += new System.EventHandler(this.btnZGraphAdaptive_Click);
            // 
            // btnZGraphAlpha
            // 
            this.btnZGraphAlpha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZGraphAlpha.Location = new System.Drawing.Point(1590, 34);
            this.btnZGraphAlpha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZGraphAlpha.Name = "btnZGraphAlpha";
            this.btnZGraphAlpha.Size = new System.Drawing.Size(158, 48);
            this.btnZGraphAlpha.TabIndex = 3;
            this.btnZGraphAlpha.Text = "Alpha";
            this.btnZGraphAlpha.UseVisualStyleBackColor = true;
            this.btnZGraphAlpha.Click += new System.EventHandler(this.btnZGraphAlpha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trim Value";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tvalue
            // 
            this.Tvalue.Location = new System.Drawing.Point(681, 51);
            this.Tvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tvalue.Name = "Tvalue";
            this.Tvalue.Size = new System.Drawing.Size(122, 26);
            this.Tvalue.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tvalue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnZGraphAdaptive);
            this.groupBox2.Controls.Add(this.btnZGraphAlpha);
            this.groupBox2.Controls.Add(this.filterationTypeComboBox);
            this.groupBox2.Controls.Add(this.sortTypeComboBox);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(26, 703);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1832, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 837);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Image Filters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtredPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notFilteredPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox filtredPicture;
        private System.Windows.Forms.PictureBox notFilteredPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox sortTypeComboBox;
        private System.Windows.Forms.ComboBox filterationTypeComboBox;
        private System.Windows.Forms.Button btnZGraphAdaptive;
        private System.Windows.Forms.Button btnZGraphAlpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tvalue;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

