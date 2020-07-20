namespace WindowsFormsApp1
{
    partial class ArticlesForm2
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
            this.Author = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.View_articles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(107, 28);
            this.Author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(216, 20);
            this.Author.TabIndex = 1;
            this.Author.TextChanged += new System.EventHandler(this.Author_TextChanged);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(107, 68);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(216, 20);
            this.Title.TabIndex = 2;
            this.Title.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(107, 113);
            this.Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(216, 20);
            this.Description.TabIndex = 3;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(22, 28);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(42, 15);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author";
            this.AuthorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(22, 74);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 15);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 115);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(69, 15);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // View_articles
            // 
            this.View_articles.Location = new System.Drawing.Point(145, 167);
            this.View_articles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.View_articles.Name = "View_articles";
            this.View_articles.Size = new System.Drawing.Size(93, 39);
            this.View_articles.TabIndex = 7;
            this.View_articles.Text = "View Articles";
            this.View_articles.UseVisualStyleBackColor = true;
            this.View_articles.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ArticlesForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 367);
            this.Controls.Add(this.View_articles);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArticlesForm2";
            this.Text = "legen- wait for it-dary news";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button View_articles;
    }
}

