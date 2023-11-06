namespace G23W10WFCardDealer {
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
            if (disposing && (components != null)) {
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
            card1 = new PictureBox();
            btnDeal = new Button();
            ((System.ComponentModel.ISupportInitialize)card1).BeginInit();
            SuspendLayout();
            // 
            // card1
            // 
            card1.Image = Properties.Resources.king_of_spades2;
            card1.Location = new Point(12, 12);
            card1.Name = "card1";
            card1.Size = new Size(311, 454);
            card1.SizeMode = PictureBoxSizeMode.Zoom;
            card1.TabIndex = 0;
            card1.TabStop = false;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(12, 472);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(311, 52);
            btnDeal.TabIndex = 2;
            btnDeal.Text = "카드 분배";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += OnDeal;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 536);
            Controls.Add(btnDeal);
            Controls.Add(card1);
            Name = "Form1";
            Text = "카드 딜러";
            ((System.ComponentModel.ISupportInitialize)card1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox card1;
        private Button btnDeal;
    }
}