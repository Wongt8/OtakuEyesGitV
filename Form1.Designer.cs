
namespace OtakuEyes {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pn_TopWin = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.miniButton = new System.Windows.Forms.PictureBox();
            this.raph = new System.Windows.Forms.PictureBox();
            this.vanilla = new System.Windows.Forms.PictureBox();
            this.chocolat = new System.Windows.Forms.PictureBox();
            this.zeroTwo = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.PictureBox();
            this.messageError = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.ProgressBar();
            this.pn_TopWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocolat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeroTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_TopWin
            // 
            this.pn_TopWin.BackColor = System.Drawing.Color.Transparent;
            this.pn_TopWin.Controls.Add(this.closeButton);
            this.pn_TopWin.Controls.Add(this.logo);
            this.pn_TopWin.Controls.Add(this.miniButton);
            this.pn_TopWin.Location = new System.Drawing.Point(0, 0);
            this.pn_TopWin.Name = "pn_TopWin";
            this.pn_TopWin.Size = new System.Drawing.Size(550, 36);
            this.pn_TopWin.TabIndex = 0;
            this.pn_TopWin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_TopWin_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::OtakuEyes.Properties.Resources.closeWindow;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Location = new System.Drawing.Point(496, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(42, 36);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::OtakuEyes.Properties.Resources.logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(38, 36);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // miniButton
            // 
            this.miniButton.BackColor = System.Drawing.Color.Transparent;
            this.miniButton.BackgroundImage = global::OtakuEyes.Properties.Resources.littleWindow;
            this.miniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniButton.Location = new System.Drawing.Point(451, 0);
            this.miniButton.Name = "miniButton";
            this.miniButton.Size = new System.Drawing.Size(37, 36);
            this.miniButton.TabIndex = 1;
            this.miniButton.TabStop = false;
            this.miniButton.Click += new System.EventHandler(this.miniButton_Click);
            // 
            // raph
            // 
            this.raph.BackColor = System.Drawing.Color.Transparent;
            this.raph.Image = global::OtakuEyes.Properties.Resources.raph;
            this.raph.Location = new System.Drawing.Point(232, 637);
            this.raph.Name = "raph";
            this.raph.Size = new System.Drawing.Size(82, 87);
            this.raph.TabIndex = 1;
            this.raph.TabStop = false;
            this.raph.Visible = false;
            // 
            // vanilla
            // 
            this.vanilla.BackColor = System.Drawing.Color.Transparent;
            this.vanilla.Image = global::OtakuEyes.Properties.Resources.vanilla;
            this.vanilla.Location = new System.Drawing.Point(451, 634);
            this.vanilla.Name = "vanilla";
            this.vanilla.Size = new System.Drawing.Size(100, 90);
            this.vanilla.TabIndex = 2;
            this.vanilla.TabStop = false;
            this.vanilla.Visible = false;
            // 
            // chocolat
            // 
            this.chocolat.BackColor = System.Drawing.Color.Transparent;
            this.chocolat.Image = global::OtakuEyes.Properties.Resources.chocolat;
            this.chocolat.Location = new System.Drawing.Point(0, 634);
            this.chocolat.Name = "chocolat";
            this.chocolat.Size = new System.Drawing.Size(100, 90);
            this.chocolat.TabIndex = 3;
            this.chocolat.TabStop = false;
            this.chocolat.Visible = false;
            // 
            // zeroTwo
            // 
            this.zeroTwo.BackColor = System.Drawing.Color.Transparent;
            this.zeroTwo.Image = global::OtakuEyes.Properties.Resources.zeroTwo;
            this.zeroTwo.Location = new System.Drawing.Point(251, 125);
            this.zeroTwo.Name = "zeroTwo";
            this.zeroTwo.Size = new System.Drawing.Size(74, 71);
            this.zeroTwo.TabIndex = 4;
            this.zeroTwo.TabStop = false;
            this.zeroTwo.Visible = false;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(136, 194);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(272, 35);
            this.search.TabIndex = 0;
            this.search.Text = "Anime to search";
            this.search.Enter += new System.EventHandler(this.search_Enter);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = global::OtakuEyes.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(414, 184);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(55, 55);
            this.searchButton.TabIndex = 5;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // error
            // 
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.BackgroundImage = global::OtakuEyes.Properties.Resources.error;
            this.error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.error.Location = new System.Drawing.Point(118, 268);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(332, 347);
            this.error.TabIndex = 7;
            this.error.TabStop = false;
            this.error.Visible = false;
            // 
            // messageError
            // 
            this.messageError.AutoSize = true;
            this.messageError.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.messageError.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.messageError.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageError.ForeColor = System.Drawing.Color.Black;
            this.messageError.Location = new System.Drawing.Point(152, 520);
            this.messageError.Name = "messageError";
            this.messageError.Size = new System.Drawing.Size(0, 21);
            this.messageError.TabIndex = 8;
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(163, 249);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(225, 23);
            this.loading.TabIndex = 9;
            this.loading.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtakuEyes.Properties.Resources.backgroundScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 720);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.messageError);
            this.Controls.Add(this.error);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.zeroTwo);
            this.Controls.Add(this.chocolat);
            this.Controls.Add(this.vanilla);
            this.Controls.Add(this.raph);
            this.Controls.Add(this.pn_TopWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pn_TopWin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocolat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeroTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_TopWin;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox miniButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox raph;
        private System.Windows.Forms.PictureBox vanilla;
        private System.Windows.Forms.PictureBox chocolat;
        private System.Windows.Forms.PictureBox zeroTwo;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.PictureBox error;
        private System.Windows.Forms.Label messageError;
        private System.Windows.Forms.ProgressBar loading;
    }
}

