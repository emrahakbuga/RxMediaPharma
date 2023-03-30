
using System;

namespace RxMediaPharma.WinForms
{
    partial class MainForm
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
            this.productListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportData = new System.Windows.Forms.Button();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.btnKUB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBarkodCopy = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.activeIngredientListView = new System.Windows.Forms.ListView();
            this.label28 = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productListBox
            // 
            this.productListBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 18;
            this.productListBox.Location = new System.Drawing.Point(35, 96);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(277, 634);
            this.productListBox.TabIndex = 0;
            this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportData
            // 
            this.btnImportData.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportData.Location = new System.Drawing.Point(35, 18);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(277, 44);
            this.btnImportData.TabIndex = 1;
            this.btnImportData.Text = "Import Data (SQLite DB)";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // productSearchBox
            // 
            this.productSearchBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.productSearchBox.Location = new System.Drawing.Point(35, 68);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(277, 26);
            this.productSearchBox.TabIndex = 2;
            this.productSearchBox.TextChanged += new System.EventHandler(this.productSearchBox_TextChanged);
            // 
            // btnKUB
            // 
            this.btnKUB.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.btnKUB.Location = new System.Drawing.Point(700, 18);
            this.btnKUB.Name = "btnKUB";
            this.btnKUB.Size = new System.Drawing.Size(84, 73);
            this.btnKUB.TabIndex = 6;
            this.btnKUB.Text = "KÜB";
            this.btnKUB.UseVisualStyleBackColor = true;
            this.btnKUB.Click += new System.EventHandler(this.btnKUB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(912, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.Location = new System.Drawing.Point(354, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnBarkodCopy);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lblBarkod);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(358, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 557);
            this.panel1.TabIndex = 9;
            // 
            // btnBarkodCopy
            // 
            this.btnBarkodCopy.Location = new System.Drawing.Point(377, 14);
            this.btnBarkodCopy.Name = "btnBarkodCopy";
            this.btnBarkodCopy.Size = new System.Drawing.Size(47, 29);
            this.btnBarkodCopy.TabIndex = 37;
            this.btnBarkodCopy.Text = "C";
            this.btnBarkodCopy.UseVisualStyleBackColor = true;
            this.btnBarkodCopy.Click += new System.EventHandler(this.btnBarkodCopy_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(230, 219);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(0, 19);
            this.label30.TabIndex = 36;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label29.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label29.Location = new System.Drawing.Point(230, 128);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 19);
            this.label29.TabIndex = 35;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label26.Location = new System.Drawing.Point(230, 516);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 19);
            this.label26.TabIndex = 34;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label25.Location = new System.Drawing.Point(230, 467);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 19);
            this.label25.TabIndex = 33;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label24.Location = new System.Drawing.Point(230, 424);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 19);
            this.label24.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label23.Location = new System.Drawing.Point(230, 379);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 19);
            this.label23.TabIndex = 31;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label22.Location = new System.Drawing.Point(230, 339);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 19);
            this.label22.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label21.Location = new System.Drawing.Point(230, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 19);
            this.label21.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label20.Location = new System.Drawing.Point(230, 256);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 19);
            this.label20.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label19.Location = new System.Drawing.Point(230, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 19);
            this.label19.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label18.Location = new System.Drawing.Point(230, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 19);
            this.label18.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label17.Location = new System.Drawing.Point(230, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 19);
            this.label17.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label16.Location = new System.Drawing.Point(230, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 19);
            this.label16.TabIndex = 24;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.lblBarkod.Location = new System.Drawing.Point(230, 24);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(0, 19);
            this.lblBarkod.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label14.Location = new System.Drawing.Point(14, 516);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "REÇETE :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label13.Location = new System.Drawing.Point(14, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "ATC KODU:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label12.Location = new System.Drawing.Point(14, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "SGK KODU:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label11.Location = new System.Drawing.Point(14, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "J/O ORIJIN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label10.Location = new System.Drawing.Point(14, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "KDV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label9.Location = new System.Drawing.Point(14, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "IMALATCI FİYATI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label8.Location = new System.Drawing.Point(14, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "DEPOCU FİYATI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label7.Location = new System.Drawing.Point(14, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "KAMU ÖDENEN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label6.Location = new System.Drawing.Point(14, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "KAMU FİYATI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label5.Location = new System.Drawing.Point(14, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "FİYAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label4.Location = new System.Drawing.Point(14, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "FİRMA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "BARKOD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label2.Location = new System.Drawing.Point(360, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label27.Location = new System.Drawing.Point(958, 373);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 19);
            this.label27.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.activeIngredientListView);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Location = new System.Drawing.Point(867, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 184);
            this.panel3.TabIndex = 14;
            // 
            // activeIngredientListView
            // 
            this.activeIngredientListView.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.activeIngredientListView.HideSelection = false;
            this.activeIngredientListView.Location = new System.Drawing.Point(6, 41);
            this.activeIngredientListView.Name = "activeIngredientListView";
            this.activeIngredientListView.Size = new System.Drawing.Size(323, 136);
            this.activeIngredientListView.TabIndex = 13;
            this.activeIngredientListView.UseCompatibleStateImageBehavior = false;
            this.activeIngredientListView.View = System.Windows.Forms.View.Details;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label28.Location = new System.Drawing.Point(90, 12);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(136, 19);
            this.label28.TabIndex = 12;
            this.label28.Text = "ETKİN MADDELER";
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.lblFavorite.ForeColor = System.Drawing.Color.Red;
            this.lblFavorite.Location = new System.Drawing.Point(694, 148);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(108, 19);
            this.lblFavorite.TabIndex = 15;
            this.lblFavorite.Text = "FAVORİ ÜRÜN";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RxMediaPharma.WinForms.Properties.Resources.Barkod;
            this.panel2.Location = new System.Drawing.Point(912, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 56);
            this.panel2.TabIndex = 12;
            // 
            // productPictureBox
            // 
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productPictureBox.Location = new System.Drawing.Point(875, 96);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(313, 188);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 11;
            this.productPictureBox.TabStop = false;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Image = global::RxMediaPharma.WinForms.Properties.Resources.favorite;
            this.btnFavorite.Location = new System.Drawing.Point(594, 18);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(82, 73);
            this.btnFavorite.TabIndex = 5;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::RxMediaPharma.WinForms.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(478, 18);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 72);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = global::RxMediaPharma.WinForms.Properties.Resources.prev;
            this.btnPrev.Location = new System.Drawing.Point(357, 18);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(96, 73);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1253, 751);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKUB);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.productListBox);
            this.Name = "MainForm";
            this.Text = "RxMediaPharma";
            this.Load += new System.EventHandler(this.RxMediaPharma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnKUB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ListView activeIngredientListView;
        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.Button btnBarkodCopy;
    }
}

