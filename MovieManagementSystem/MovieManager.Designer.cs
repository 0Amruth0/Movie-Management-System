using System;
using System.Linq;
using System.Windows.Forms;
using MovieManagementSystem.DataAccess;

namespace MovieManagementSystem
{
    partial class MovieManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(216, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addMovie);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(447, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.updateMovie);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(76, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteMovie);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(715, 590);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "View All Movies";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.viewAllMovies);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movie ID";
            this.label1.Click += new System.EventHandler(this.label_movieID);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textbox_movieID);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 279);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textbox_movieTitle);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Movie Title";
            this.label2.Click += new System.EventHandler(this.label_movieTitle);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Movie Genre";
            this.label3.Click += new System.EventHandler(this.label_movieGenre);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = new MovieManagementSystem.DataAccess.MovieGenre[] {
        MovieManagementSystem.DataAccess.MovieGenre.Romance,
        MovieManagementSystem.DataAccess.MovieGenre.Adventure,
        MovieManagementSystem.DataAccess.MovieGenre.Horror,
        MovieManagementSystem.DataAccess.MovieGenre.Drama,
        MovieManagementSystem.DataAccess.MovieGenre.Fantasy,
        MovieManagementSystem.DataAccess.MovieGenre.Documentary,
        MovieManagementSystem.DataAccess.MovieGenre.Thriller,
        MovieManagementSystem.DataAccess.MovieGenre.ScienceFiction,
        MovieManagementSystem.DataAccess.MovieGenre.Comedy};
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(356, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.combobox_movieGenre);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Movie Release Year";
            this.label4.Click += new System.EventHandler(this.label_movieReleaseYear);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 353);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.picker_movieReleaseYear);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(502, 49);
            this.label5.TabIndex = 13;
            this.label5.Text = "Movie Management System";
            this.label5.Click += new System.EventHandler(this.textbox_Heading);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(644, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 446);
            this.listBox1.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 356);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textbox_movieDirector);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Movie Director";
            this.label6.Click += new System.EventHandler(this.label_movieDirector);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(967, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 46);
            this.button5.TabIndex = 17;
            this.button5.Text = "First";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.first);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(644, 529);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 46);
            this.button6.TabIndex = 18;
            this.button6.Text = "Previous";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.previous);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(809, 529);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 46);
            this.button7.TabIndex = 19;
            this.button7.Text = "Next";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.next);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(967, 375);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 46);
            this.button8.TabIndex = 20;
            this.button8.Text = "Last";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.last);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(967, 226);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 46);
            this.button9.TabIndex = 22;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.load);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(967, 152);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 46);
            this.button10.TabIndex = 21;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.save);
            // 
            // MovieManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1115, 675);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MovieManager";
            this.Text = "Movie Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Label label5;
        private ListBox listBox1;
        private TextBox textBox3;
        private Label label6;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}

