namespace Course_work_3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Registration = new System.Windows.Forms.TabPage();
            this.Budget = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_action = new System.Windows.Forms.Button();
            this.Calcel = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Type_of_accident = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Discard = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Object = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Settlement = new System.Windows.Forms.ComboBox();
            this.Region = new System.Windows.Forms.ComboBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Report = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Registration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Registration);
            this.tabControl1.Controls.Add(this.Report);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.Budget);
            this.Registration.Controls.Add(this.groupBox1);
            this.Registration.Controls.Add(this.Type_of_accident);
            this.Registration.Controls.Add(this.Submit);
            this.Registration.Controls.Add(this.Discard);
            this.Registration.Controls.Add(this.richTextBox1);
            this.Registration.Controls.Add(this.Object);
            this.Registration.Controls.Add(this.Date);
            this.Registration.Controls.Add(this.Settlement);
            this.Registration.Controls.Add(this.Region);
            this.Registration.Controls.Add(this.Country);
            this.Registration.Location = new System.Drawing.Point(4, 22);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Registration.Size = new System.Drawing.Size(903, 341);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = true;
            // 
            // Budget
            // 
            this.Budget.Location = new System.Drawing.Point(7, 259);
            this.Budget.Name = "Budget";
            this.Budget.Size = new System.Drawing.Size(167, 20);
            this.Budget.TabIndex = 12;
            this.Budget.Text = "Budget";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_action);
            this.groupBox1.Controls.Add(this.Calcel);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(499, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 257);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executed Actions";
            // 
            // Add_action
            // 
            this.Add_action.Location = new System.Drawing.Point(203, 228);
            this.Add_action.Name = "Add_action";
            this.Add_action.Size = new System.Drawing.Size(75, 23);
            this.Add_action.TabIndex = 13;
            this.Add_action.Text = "Add Action";
            this.Add_action.UseVisualStyleBackColor = true;
            // 
            // Calcel
            // 
            this.Calcel.Location = new System.Drawing.Point(113, 228);
            this.Calcel.Name = "Calcel";
            this.Calcel.Size = new System.Drawing.Size(75, 23);
            this.Calcel.TabIndex = 12;
            this.Calcel.Text = "Cancel";
            this.Calcel.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 45);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(386, 177);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "Description of the action";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Type_of_accident
            // 
            this.Type_of_accident.FormattingEnabled = true;
            this.Type_of_accident.Location = new System.Drawing.Point(7, 214);
            this.Type_of_accident.Name = "Type_of_accident";
            this.Type_of_accident.Size = new System.Drawing.Size(167, 21);
            this.Type_of_accident.TabIndex = 8;
            this.Type_of_accident.Text = "Type of accident";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(499, 287);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(117, 34);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // Discard
            // 
            this.Discard.Location = new System.Drawing.Point(287, 287);
            this.Discard.Name = "Discard";
            this.Discard.Size = new System.Drawing.Size(117, 34);
            this.Discard.TabIndex = 6;
            this.Discard.Text = "Discard";
            this.Discard.UseVisualStyleBackColor = true;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(180, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 253);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Description of the accident";
            // 
            // Object
            // 
            this.Object.FormattingEnabled = true;
            this.Object.Location = new System.Drawing.Point(7, 165);
            this.Object.Name = "Object";
            this.Object.Size = new System.Drawing.Size(167, 21);
            this.Object.TabIndex = 4;
            this.Object.Text = "Object";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(6, 301);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(168, 20);
            this.Date.TabIndex = 3;
            // 
            // Settlement
            // 
            this.Settlement.FormattingEnabled = true;
            this.Settlement.Location = new System.Drawing.Point(7, 116);
            this.Settlement.Name = "Settlement";
            this.Settlement.Size = new System.Drawing.Size(167, 21);
            this.Settlement.TabIndex = 2;
            this.Settlement.Text = "Settlement";
            // 
            // Region
            // 
            this.Region.FormattingEnabled = true;
            this.Region.Location = new System.Drawing.Point(7, 61);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(167, 21);
            this.Region.TabIndex = 1;
            this.Region.Text = "Region";
            // 
            // Country
            // 
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(7, 10);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(167, 21);
            this.Country.TabIndex = 0;
            this.Country.Text = "Country";
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(4, 22);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3);
            this.Report.Size = new System.Drawing.Size(903, 341);
            this.Report.TabIndex = 1;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Putin huilo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.ComboBox Object;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox Settlement;
        private System.Windows.Forms.ComboBox Region;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Discard;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox Type_of_accident;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_action;
        private System.Windows.Forms.Button Calcel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Budget;

    }
}

