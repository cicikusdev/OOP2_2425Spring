using System;
using System.Windows.Forms;
using System.Drawing;

namespace OOP2_2425Spring_Grp13
{
    partial class FormSalaryCalculator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            this.cmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(33, 88);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(134, 21);
            this.cmbCity.TabIndex = 0;
            //
            // labelCity
            //
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelCity.ForeColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(31, 65);
            this.labelCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(40, 21);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City";
            //
            // labelCalculatedSalary
            //
            this.labelCalculatedSalary.AutoSize = true;
            this.labelCalculatedSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelCalculatedSalary.ForeColor = System.Drawing.Color.White;
            this.labelCalculatedSalary.Location = new System.Drawing.Point(225, 23);
            this.labelCalculatedSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCalculatedSalary.Name = "labelCalculatedSalary";
            this.labelCalculatedSalary.Size = new System.Drawing.Size(91, 21);
            this.labelCalculatedSalary.TabIndex = 6;
            this.labelCalculatedSalary.Text = "Salary (TL)";
            //
            // numericExperience
            //
            this.numericExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.numericExperience.Location = new System.Drawing.Point(33, 134);
            this.numericExperience.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericExperience.Name = "numericExperience";
            this.numericExperience.Size = new System.Drawing.Size(133, 20);
            this.numericExperience.TabIndex = 7;
            //
            // labelExperience
            //
            this.labelExperience.AutoSize = true;
            this.labelExperience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelExperience.ForeColor = System.Drawing.Color.White;
            this.labelExperience.Location = new System.Drawing.Point(31, 111);
            this.labelExperience.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(94, 21);
            this.labelExperience.TabIndex = 8;
            this.labelExperience.Text = "Experience";
            //
            // cmbPosition
            //
            this.cmbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(33, 179);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(134, 21);
            this.cmbPosition.TabIndex = 9;
            //
            // labelPosition
            //
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelPosition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPosition.Location = new System.Drawing.Point(31, 156);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(73, 21);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Position";
            //
            // grpFamily
            //
            this.grpFamily.Controls.Add(this.label1);
            this.grpFamily.Controls.Add(this.cbWife);
            this.grpFamily.Controls.Add(this.numericChildren);
            this.grpFamily.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpFamily.ForeColor = System.Drawing.Color.White;
            this.grpFamily.Location = new System.Drawing.Point(253, 270);
            this.grpFamily.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFamily.Name = "grpFamily";
            this.grpFamily.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFamily.Size = new System.Drawing.Size(252, 118);
            this.grpFamily.TabIndex = 11;
            this.grpFamily.TabStop = false;
            this.grpFamily.Text = "Family Info";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Child Count";
            //
            // cbWife
            //
            this.cbWife.AutoSize = true;
            this.cbWife.ForeColor = System.Drawing.Color.White;
            this.cbWife.Location = new System.Drawing.Point(4, 24);
            this.cbWife.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbWife.Name = "cbWife";
            this.cbWife.Size = new System.Drawing.Size(245, 23);
            this.cbWife.TabIndex = 0;
            this.cbWife.Text = "Married and Wife is not working";
            this.cbWife.UseVisualStyleBackColor = true;
            //
            // numericChildren
            //
            this.numericChildren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.numericChildren.Location = new System.Drawing.Point(5, 86);
            this.numericChildren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericChildren.Name = "numericChildren";
            this.numericChildren.Size = new System.Drawing.Size(90, 25);
            this.numericChildren.TabIndex = 12;
            //
            // grpLanguage
            //
            this.grpLanguage.Controls.Add(this.rbEnglishGraduate);
            this.grpLanguage.Controls.Add(this.rbCertifiedEnglish);
            this.grpLanguage.Controls.Add(this.rbNoEnglish);
            this.grpLanguage.Controls.Add(this.labelOtherLanguage);
            this.grpLanguage.Controls.Add(this.numericOtherLanguage);
            this.grpLanguage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpLanguage.ForeColor = System.Drawing.Color.White;
            this.grpLanguage.Location = new System.Drawing.Point(33, 216);
            this.grpLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLanguage.Size = new System.Drawing.Size(206, 172);
            this.grpLanguage.TabIndex = 14;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "Language Info";
            //
            // rbEnglishGraduate
            //
            this.rbEnglishGraduate.AutoSize = true;
            this.rbEnglishGraduate.Location = new System.Drawing.Point(4, 77);
            this.rbEnglishGraduate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEnglishGraduate.Name = "rbEnglishGraduate";
            this.rbEnglishGraduate.Size = new System.Drawing.Size(196, 23);
            this.rbEnglishGraduate.TabIndex = 16;
            this.rbEnglishGraduate.TabStop = true;
            this.rbEnglishGraduate.Text = "English Institute Graduate";
            this.rbEnglishGraduate.UseVisualStyleBackColor = true;
            //
            // rbCertifiedEnglish
            //
            this.rbCertifiedEnglish.AutoSize = true;
            this.rbCertifiedEnglish.Location = new System.Drawing.Point(4, 50);
            this.rbCertifiedEnglish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCertifiedEnglish.Name = "rbCertifiedEnglish";
            this.rbCertifiedEnglish.Size = new System.Drawing.Size(135, 23);
            this.rbCertifiedEnglish.TabIndex = 15;
            this.rbCertifiedEnglish.TabStop = true;
            this.rbCertifiedEnglish.Text = "Certified English";
            this.rbCertifiedEnglish.UseVisualStyleBackColor = true;
            //
            // rbNoEnglish
            //
            this.rbNoEnglish.AutoSize = true;
            this.rbNoEnglish.Location = new System.Drawing.Point(4, 24);
            this.rbNoEnglish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNoEnglish.Name = "rbNoEnglish";
            this.rbNoEnglish.Size = new System.Drawing.Size(171, 23);
            this.rbNoEnglish.TabIndex = 14;
            this.rbNoEnglish.TabStop = true;
            this.rbNoEnglish.Text = "No Foreign Language";
            this.rbNoEnglish.UseVisualStyleBackColor = true;
            //
            // labelOtherLanguage
            //
            this.labelOtherLanguage.AutoSize = true;
            this.labelOtherLanguage.Location = new System.Drawing.Point(4, 120);
            this.labelOtherLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtherLanguage.Name = "labelOtherLanguage";
            this.labelOtherLanguage.Size = new System.Drawing.Size(178, 19);
            this.labelOtherLanguage.TabIndex = 13;
            this.labelOtherLanguage.Text = "Other Certified Language";
            //
            // numericOtherLanguage
            //
            this.numericOtherLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.numericOtherLanguage.Location = new System.Drawing.Point(4, 141);
            this.numericOtherLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericOtherLanguage.Name = "numericOtherLanguage";
            this.numericOtherLanguage.Size = new System.Drawing.Size(90, 25);
            this.numericOtherLanguage.TabIndex = 12;
            //
            // clbEducation
            //
            this.clbEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.clbEducation.FormattingEnabled = true;
            this.clbEducation.Location = new System.Drawing.Point(253, 86);
            this.clbEducation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbEducation.Name = "clbEducation";
            this.clbEducation.Size = new System.Drawing.Size(252, 124);
            this.clbEducation.TabIndex = 15;
            //
            // labelEducation
            //
            this.labelEducation.AutoSize = true;
            this.labelEducation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelEducation.ForeColor = System.Drawing.Color.White;
            this.labelEducation.Location = new System.Drawing.Point(249, 62);
            this.labelEducation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(87, 21);
            this.labelEducation.TabIndex = 16;
            this.labelEducation.Text = "Education";
            //
            // btnCalculate
            //
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(544, 226);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 37);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            //
            // FormSalaryCalculator
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(660, 406);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSalaryCalculator";
            this.Text = "Salary Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSalaryCalculator_FormClosing);
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