﻿namespace ProductCatalog
{
    partial class AddProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameBox = new TextBox();
            DescriptionBox = new TextBox();
            ProducerBox = new TextBox();
            PriceBox = new TextBox();
            CountBox = new TextBox();
            AddButton = new Button();
            AddPicture = new Button();
            ImagePicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImagePicBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 21);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 57);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 1;
            label2.Text = "Описание товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 93);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Производитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 135);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Количество";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(146, 21);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(180, 27);
            NameBox.TabIndex = 5;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(146, 54);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(180, 27);
            DescriptionBox.TabIndex = 6;
            // 
            // ProducerBox
            // 
            ProducerBox.Location = new Point(146, 93);
            ProducerBox.Name = "ProducerBox";
            ProducerBox.Size = new Size(180, 27);
            ProducerBox.TabIndex = 7;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(146, 135);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(180, 27);
            PriceBox.TabIndex = 8;
            // 
            // CountBox
            // 
            CountBox.Location = new Point(215, 168);
            CountBox.Name = "CountBox";
            CountBox.Size = new Size(47, 27);
            CountBox.TabIndex = 9;
            CountBox.KeyPress += CheckCout;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(120, 386);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 10;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButtonClick;
            // 
            // AddPicture
            // 
            AddPicture.Location = new Point(191, 217);
            AddPicture.Name = "AddPicture";
            AddPicture.Size = new Size(143, 29);
            AddPicture.TabIndex = 11;
            AddPicture.Text = "Добавить фото";
            AddPicture.UseVisualStyleBackColor = true;
            AddPicture.Click += AddPicture_Click;
            // 
            // ImagePicBox
            // 
            ImagePicBox.Location = new Point(12, 217);
            ImagePicBox.Name = "ImagePicBox";
            ImagePicBox.Size = new Size(167, 143);
            ImagePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagePicBox.TabIndex = 12;
            ImagePicBox.TabStop = false;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(ImagePicBox);
            Controls.Add(AddPicture);
            Controls.Add(AddButton);
            Controls.Add(CountBox);
            Controls.Add(PriceBox);
            Controls.Add(ProducerBox);
            Controls.Add(DescriptionBox);
            Controls.Add(NameBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить товар";
            ((System.ComponentModel.ISupportInitialize)ImagePicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameBox;
        private TextBox DescriptionBox;
        private TextBox ProducerBox;
        private TextBox PriceBox;
        private TextBox CountBox;
        private Button AddButton;
        private Button AddPicture;
        private PictureBox ImagePicBox;
    }
}