namespace Unicom_TIC_Management_Systems.view
{
    partial class Courseform
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
            this.add_course_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.course_view = new System.Windows.Forms.DataGridView();
            this.course_delete_button = new System.Windows.Forms.Button();
            this.course_update_button = new System.Windows.Forms.Button();
            this.course_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.course_view)).BeginInit();
            this.SuspendLayout();
            // 
            // add_course_button
            // 
            this.add_course_button.Location = new System.Drawing.Point(85, 183);
            this.add_course_button.Name = "add_course_button";
            this.add_course_button.Size = new System.Drawing.Size(75, 23);
            this.add_course_button.TabIndex = 1;
            this.add_course_button.Text = "ADD";
            this.add_course_button.UseVisualStyleBackColor = true;
            this.add_course_button.Click += new System.EventHandler(this.add_course_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Details";
            // 
            // course_view
            // 
            this.course_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.course_view.Location = new System.Drawing.Point(85, 251);
            this.course_view.Name = "course_view";
            this.course_view.Size = new System.Drawing.Size(258, 150);
            this.course_view.TabIndex = 4;
            this.course_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.course_view_CellContentClick);
            // 
            // course_delete_button
            // 
            this.course_delete_button.Location = new System.Drawing.Point(268, 183);
            this.course_delete_button.Name = "course_delete_button";
            this.course_delete_button.Size = new System.Drawing.Size(75, 23);
            this.course_delete_button.TabIndex = 6;
            this.course_delete_button.Text = "DELETE";
            this.course_delete_button.UseVisualStyleBackColor = true;
            // 
            // course_update_button
            // 
            this.course_update_button.Location = new System.Drawing.Point(183, 183);
            this.course_update_button.Name = "course_update_button";
            this.course_update_button.Size = new System.Drawing.Size(75, 23);
            this.course_update_button.TabIndex = 7;
            this.course_update_button.Text = "UPDATE";
            this.course_update_button.UseVisualStyleBackColor = true;
            // 
            // course_name
            // 
            this.course_name.Location = new System.Drawing.Point(183, 86);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(160, 20);
            this.course_name.TabIndex = 8;
            this.course_name.TextChanged += new System.EventHandler(this.course_name_TextChanged);
            // 
            // Courseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.course_update_button);
            this.Controls.Add(this.course_delete_button);
            this.Controls.Add(this.course_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_course_button);
            this.Name = "Courseform";
            this.Text = "Courseform";
            this.Load += new System.EventHandler(this.Courseform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.course_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_course_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView course_view;
        private System.Windows.Forms.Button course_delete_button;
        private System.Windows.Forms.Button course_update_button;
        private System.Windows.Forms.TextBox course_name;
    }
}