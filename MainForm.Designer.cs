namespace Jones_CourseProject_part2_updated
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.PrintPaychecksButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(30, 37);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(145, 50);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.HorizontalScrollbar = true;
            this.EmployeesListBox.ItemHeight = 20;
            this.EmployeesListBox.Location = new System.Drawing.Point(43, 114);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(707, 324);
            this.EmployeesListBox.TabIndex = 4;
            this.EmployeesListBox.DoubleClick += new System.EventHandler(this.EmployeesListBox_DoubleClick);
            // 
            // PrintPaychecksButton
            // 
            this.PrintPaychecksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPaychecksButton.Location = new System.Drawing.Point(549, 37);
            this.PrintPaychecksButton.Name = "PrintPaychecksButton";
            this.PrintPaychecksButton.Size = new System.Drawing.Size(153, 50);
            this.PrintPaychecksButton.TabIndex = 6;
            this.PrintPaychecksButton.Text = "Print Paychecks";
            this.PrintPaychecksButton.UseVisualStyleBackColor = true;
            this.PrintPaychecksButton.Click += new System.EventHandler(this.PrintPaychecksButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(376, 37);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(145, 50);
            this.DisplayButton.TabIndex = 7;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(203, 37);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(145, 50);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.PrintPaychecksButton);
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.AddButton);
            this.Name = "MainForm";
            this.Text = "Payroll System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.Button PrintPaychecksButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}

