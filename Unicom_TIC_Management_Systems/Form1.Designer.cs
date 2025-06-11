namespace Unicom_TIC_Management_Systems
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
            this.course_update_button = new System.Windows.Forms.Button();
            this.course_table_view = new System.Windows.Forms.DataGridView();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.coursename_textbox = new System.Windows.Forms.TextBox();
            this.cousrse_id_textbox = new System.Windows.Forms.TextBox();
            this.CourseIDLabel = new System.Windows.Forms.Label();
            this.course_add_button = new System.Windows.Forms.Button();
            this.course_delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.course_table_view)).BeginInit();
            this.SuspendLayout();
            // 
            // course_update_button
            // 
            this.course_update_button.BackColor = System.Drawing.Color.Black;
            this.course_update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_update_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.course_update_button.Location = new System.Drawing.Point(57, 172);
            this.course_update_button.Name = "course_update_button";
            this.course_update_button.Size = new System.Drawing.Size(75, 23);
            this.course_update_button.TabIndex = 2;
            this.course_update_button.Text = "UPDATE";
            this.course_update_button.UseVisualStyleBackColor = false;
            this.course_update_button.Click += new System.EventHandler(this.course_update_button_Click);
            // 
            // course_table_view
            // 
            this.course_table_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.course_table_view.Location = new System.Drawing.Point(59, 237);
            this.course_table_view.Name = "course_table_view";
            this.course_table_view.Size = new System.Drawing.Size(305, 217);
            this.course_table_view.TabIndex = 3;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.BackColor = System.Drawing.Color.Silver;
            this.CourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CourseLabel.Location = new System.Drawing.Point(57, 70);
            this.CourseLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(103, 18);
            this.CourseLabel.TabIndex = 4;
            this.CourseLabel.Text = "Course Name";
            // 
            // coursename_textbox
            // 
            this.coursename_textbox.Location = new System.Drawing.Point(199, 68);
            this.coursename_textbox.Name = "coursename_textbox";
            this.coursename_textbox.Size = new System.Drawing.Size(165, 20);
            this.coursename_textbox.TabIndex = 5;
            this.coursename_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cousrse_id_textbox
            // 
            this.cousrse_id_textbox.Location = new System.Drawing.Point(199, 123);
            this.cousrse_id_textbox.Name = "cousrse_id_textbox";
            this.cousrse_id_textbox.Size = new System.Drawing.Size(165, 20);
            this.cousrse_id_textbox.TabIndex = 7;
            this.cousrse_id_textbox.TextChanged += new System.EventHandler(this.cousrse_id_textbox_TextChanged);
            // 
            // CourseIDLabel
            // 
            this.CourseIDLabel.AutoSize = true;
            this.CourseIDLabel.BackColor = System.Drawing.Color.Silver;
            this.CourseIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseIDLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CourseIDLabel.Location = new System.Drawing.Point(57, 123);
            this.CourseIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CourseIDLabel.Name = "CourseIDLabel";
            this.CourseIDLabel.Size = new System.Drawing.Size(77, 18);
            this.CourseIDLabel.TabIndex = 8;
            this.CourseIDLabel.Text = "Course ID";
            // 
            // course_add_button
            // 
            this.course_add_button.BackColor = System.Drawing.Color.Black;
            this.course_add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_add_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.course_add_button.Location = new System.Drawing.Point(289, 172);
            this.course_add_button.Name = "course_add_button";
            this.course_add_button.Size = new System.Drawing.Size(75, 23);
            this.course_add_button.TabIndex = 9;
            this.course_add_button.Text = "ADD";
            this.course_add_button.UseVisualStyleBackColor = false;
            // 
            // course_delete_button
            // 
            this.course_delete_button.BackColor = System.Drawing.Color.Black;
            this.course_delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_delete_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.course_delete_button.Location = new System.Drawing.Point(172, 172);
            this.course_delete_button.Name = "course_delete_button";
            this.course_delete_button.Size = new System.Drawing.Size(75, 23);
            this.course_delete_button.TabIndex = 10;
            this.course_delete_button.Text = "DELETE";
            this.course_delete_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(795, 479);
            this.Controls.Add(this.course_delete_button);
            this.Controls.Add(this.course_add_button);
            this.Controls.Add(this.CourseIDLabel);
            this.Controls.Add(this.cousrse_id_textbox);
            this.Controls.Add(this.coursename_textbox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.course_table_view);
            this.Controls.Add(this.course_update_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.course_table_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button course_update_button;
        private System.Windows.Forms.DataGridView course_table_view;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.TextBox coursename_textbox;
        private System.Windows.Forms.TextBox cousrse_id_textbox;
        private System.Windows.Forms.Label CourseIDLabel;
        private System.Windows.Forms.Button course_add_button;
        private System.Windows.Forms.Button course_delete_button;
    }
}