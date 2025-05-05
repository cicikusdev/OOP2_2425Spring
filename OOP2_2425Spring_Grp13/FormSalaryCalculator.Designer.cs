namespace OOP2_2425Spring_Grp13
{
    partial class FormSalaryCalculator
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
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCalculatedSalary = new System.Windows.Forms.Label();
            this.numericExperience = new System.Windows.Forms.NumericUpDown();
            this.labelExperience = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.grpFamily = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWife = new System.Windows.Forms.CheckBox();
            this.numericChildren = new System.Windows.Forms.NumericUpDown();
            this.grpLanguage = new System.Windows.Forms.GroupBox();
            this.rbEnglishGraduate = new System.Windows.Forms.RadioButton();
            this.rbCertifiedEnglish = new System.Windows.Forms.RadioButton();
            this.rbNoEnglish = new System.Windows.Forms.RadioButton();
            this.labelOtherLanguage = new System.Windows.Forms.Label();
            this.numericOtherLanguage = new System.Windows.Forms.NumericUpDown();
            this.clbEducation = new System.Windows.Forms.CheckedListBox();
            this.labelEducation = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericExperience)).BeginInit();
            this.grpFamily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildren)).BeginInit();
            this.grpLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOtherLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(88, 81);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(178, 24);
            this.cmbCity.TabIndex = 0;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(85, 62);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(29, 16);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City";
            // 
            // labelCalculatedSalary
            // 
            this.labelCalculatedSalary.AutoSize = true;
            this.labelCalculatedSalary.Location = new System.Drawing.Point(270, 20);
            this.labelCalculatedSalary.Name = "labelCalculatedSalary";
            this.labelCalculatedSalary.Size = new System.Drawing.Size(63, 16);
            this.labelCalculatedSalary.TabIndex = 6;
            this.labelCalculatedSalary.Text = "salary TL";
            // 
            // numericExperience
            // 
            this.numericExperience.Location = new System.Drawing.Point(88, 138);
            this.numericExperience.Name = "numericExperience";
            this.numericExperience.Size = new System.Drawing.Size(177, 22);
            this.numericExperience.TabIndex = 7;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(85, 119);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(75, 16);
            this.labelExperience.TabIndex = 8;
            this.labelExperience.Text = "Experience";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(88, 197);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(178, 24);
            this.cmbPosition.TabIndex = 9;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(85, 178);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(55, 16);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Position";
            // 
            // grpFamily
            // 
            this.grpFamily.Controls.Add(this.label1);
            this.grpFamily.Controls.Add(this.cbWife);
            this.grpFamily.Controls.Add(this.numericChildren);
            this.grpFamily.Location = new System.Drawing.Point(399, 62);
            this.grpFamily.Name = "grpFamily";
            this.grpFamily.Size = new System.Drawing.Size(230, 176);
            this.grpFamily.TabIndex = 11;
            this.grpFamily.TabStop = false;
            this.grpFamily.Text = "Family Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Child Count";
            // 
            // cbWife
            // 
            this.cbWife.AutoSize = true;
            this.cbWife.Location = new System.Drawing.Point(6, 39);
            this.cbWife.Name = "cbWife";
            this.cbWife.Size = new System.Drawing.Size(214, 20);
            this.cbWife.TabIndex = 0;
            this.cbWife.Text = "Married and Wife is not working";
            this.cbWife.UseVisualStyleBackColor = true;
            // 
            // numericChildren
            // 
            this.numericChildren.Location = new System.Drawing.Point(6, 95);
            this.numericChildren.Name = "numericChildren";
            this.numericChildren.Size = new System.Drawing.Size(120, 22);
            this.numericChildren.TabIndex = 12;
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.rbEnglishGraduate);
            this.grpLanguage.Controls.Add(this.rbCertifiedEnglish);
            this.grpLanguage.Controls.Add(this.rbNoEnglish);
            this.grpLanguage.Controls.Add(this.labelOtherLanguage);
            this.grpLanguage.Controls.Add(this.numericOtherLanguage);
            this.grpLanguage.Location = new System.Drawing.Point(85, 248);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Size = new System.Drawing.Size(230, 176);
            this.grpLanguage.TabIndex = 14;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "Language Info";
            // 
            // rbEnglishGraduate
            // 
            this.rbEnglishGraduate.AutoSize = true;
            this.rbEnglishGraduate.Location = new System.Drawing.Point(0, 95);
            this.rbEnglishGraduate.Name = "rbEnglishGraduate";
            this.rbEnglishGraduate.Size = new System.Drawing.Size(178, 20);
            this.rbEnglishGraduate.TabIndex = 16;
            this.rbEnglishGraduate.TabStop = true;
            this.rbEnglishGraduate.Text = "English Institute Graduate";
            this.rbEnglishGraduate.UseVisualStyleBackColor = true;
            // 
            // rbCertifiedEnglish
            // 
            this.rbCertifiedEnglish.AutoSize = true;
            this.rbCertifiedEnglish.Location = new System.Drawing.Point(0, 62);
            this.rbCertifiedEnglish.Name = "rbCertifiedEnglish";
            this.rbCertifiedEnglish.Size = new System.Drawing.Size(124, 20);
            this.rbCertifiedEnglish.TabIndex = 15;
            this.rbCertifiedEnglish.TabStop = true;
            this.rbCertifiedEnglish.Text = "Certified English";
            this.rbCertifiedEnglish.UseVisualStyleBackColor = true;
            // 
            // rbNoEnglish
            // 
            this.rbNoEnglish.AutoSize = true;
            this.rbNoEnglish.Location = new System.Drawing.Point(0, 30);
            this.rbNoEnglish.Name = "rbNoEnglish";
            this.rbNoEnglish.Size = new System.Drawing.Size(159, 20);
            this.rbNoEnglish.TabIndex = 14;
            this.rbNoEnglish.TabStop = true;
            this.rbNoEnglish.Text = "No Foreign Language";
            this.rbNoEnglish.UseVisualStyleBackColor = true;
            // 
            // labelOtherLanguage
            // 
            this.labelOtherLanguage.AutoSize = true;
            this.labelOtherLanguage.Location = new System.Drawing.Point(0, 121);
            this.labelOtherLanguage.Name = "labelOtherLanguage";
            this.labelOtherLanguage.Size = new System.Drawing.Size(155, 16);
            this.labelOtherLanguage.TabIndex = 13;
            this.labelOtherLanguage.Text = "Other Certified Language";
            // 
            // numericOtherLanguage
            // 
            this.numericOtherLanguage.Location = new System.Drawing.Point(3, 140);
            this.numericOtherLanguage.Name = "numericOtherLanguage";
            this.numericOtherLanguage.Size = new System.Drawing.Size(120, 22);
            this.numericOtherLanguage.TabIndex = 12;
            // 
            // clbEducation
            // 
            this.clbEducation.FormattingEnabled = true;
            this.clbEducation.Location = new System.Drawing.Point(399, 267);
            this.clbEducation.Name = "clbEducation";
            this.clbEducation.Size = new System.Drawing.Size(230, 157);
            this.clbEducation.TabIndex = 15;
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(405, 248);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(67, 16);
            this.labelEducation.TabIndex = 16;
            this.labelEducation.Text = "Education";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(666, 62);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 362);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FormSalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.clbEducation);
            this.Controls.Add(this.grpLanguage);
            this.Controls.Add(this.grpFamily);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.numericExperience);
            this.Controls.Add(this.labelCalculatedSalary);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.cmbCity);
            this.Name = "FormSalaryCalculator";
            this.Text = "FormSalaryCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericExperience)).EndInit();
            this.grpFamily.ResumeLayout(false);
            this.grpFamily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildren)).EndInit();
            this.grpLanguage.ResumeLayout(false);
            this.grpLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOtherLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelCalculatedSalary;
        private System.Windows.Forms.NumericUpDown numericExperience;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.GroupBox grpFamily;
        private System.Windows.Forms.CheckBox cbWife;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericChildren;
        private System.Windows.Forms.GroupBox grpLanguage;
        private System.Windows.Forms.Label labelOtherLanguage;
        private System.Windows.Forms.NumericUpDown numericOtherLanguage;
        private System.Windows.Forms.RadioButton rbEnglishGraduate;
        private System.Windows.Forms.RadioButton rbCertifiedEnglish;
        private System.Windows.Forms.RadioButton rbNoEnglish;
        private System.Windows.Forms.CheckedListBox clbEducation;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.Button btnCalculate;
    }
}