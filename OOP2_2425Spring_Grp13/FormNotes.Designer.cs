using System;
using System.Windows.Forms;
using System.Drawing;

namespace OOP2_2425Spring_Grp13
{
    partial class FormNotes
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbNotes = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbNoteDetailed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbNote
            // 
            this.tbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNote.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNote.Location = new System.Drawing.Point(12, 35);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(250, 160);
            this.tbNote.TabIndex = 2;
            this.tbNote.Enter += new System.EventHandler(this.TxtField_Enter);
            this.tbNote.Leave += new System.EventHandler(this.TxtField_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Note";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(142, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // lbNotes
            // 
            this.lbNotes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbNotes.FormattingEnabled = true;
            this.lbNotes.ItemHeight = 30;
            this.lbNotes.Location = new System.Drawing.Point(277, 35);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(240, 214);
            this.lbNotes.TabIndex = 7;
            this.lbNotes.SelectedIndexChanged += new System.EventHandler(this.lbNotes_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(397, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // tbNoteDetailed
            // 
            this.tbNoteDetailed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tbNoteDetailed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNoteDetailed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbNoteDetailed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNoteDetailed.Location = new System.Drawing.Point(532, 35);
            this.tbNoteDetailed.Multiline = true;
            this.tbNoteDetailed.Name = "tbNoteDetailed";
            this.tbNoteDetailed.ReadOnly = true;
            this.tbNoteDetailed.Size = new System.Drawing.Size(224, 238);
            this.tbNoteDetailed.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(529, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Note Details";
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNoteDetailed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNote);
            this.Name = "FormNotes";
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lbNotes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbNoteDetailed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

        // Animasyon ve hover efektleri
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = btn.Name == "btnDelete" ? Color.FromArgb(255, 82, 82) : Color.FromArgb(0, 102, 204);
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = btn.Name == "btnDelete" ? Color.FromArgb(220, 53, 69) : Color.FromArgb(0, 123, 255);
        }

        // TextBox için fokus etkisi
        private void TxtField_Enter(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void TxtField_Leave(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.BackColor = Color.FromArgb(248, 249, 250);
        }
    }
}
