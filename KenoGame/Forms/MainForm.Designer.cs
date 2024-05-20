using System.Drawing;
using System.Windows.Forms;
using System;
using System.Drawing.Drawing2D;

namespace KenoGame
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.spot1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.spot2 = new System.Windows.Forms.Button();
            this.spot3 = new System.Windows.Forms.Button();
            this.spot4 = new System.Windows.Forms.Button();
            this.spot5 = new System.Windows.Forms.Button();
            this.spot6 = new System.Windows.Forms.Button();
            this.spot7 = new System.Windows.Forms.Button();
            this.spot8 = new System.Windows.Forms.Button();
            this.spot9 = new System.Windows.Forms.Button();
            this.spot10 = new System.Windows.Forms.Button();
            this.spot11 = new System.Windows.Forms.Button();
            this.spot12 = new System.Windows.Forms.Button();
            this.spot13 = new System.Windows.Forms.Button();
            this.spot14 = new System.Windows.Forms.Button();
            this.spot15 = new System.Windows.Forms.Button();
            this.spot16 = new System.Windows.Forms.Button();
            this.spot17 = new System.Windows.Forms.Button();
            this.spot18 = new System.Windows.Forms.Button();
            this.spot19 = new System.Windows.Forms.Button();
            this.spot20 = new System.Windows.Forms.Button();
            this.spot21 = new System.Windows.Forms.Button();
            this.spot22 = new System.Windows.Forms.Button();
            this.spot23 = new System.Windows.Forms.Button();
            this.spot24 = new System.Windows.Forms.Button();
            this.spot25 = new System.Windows.Forms.Button();
            this.spot26 = new System.Windows.Forms.Button();
            this.spot27 = new System.Windows.Forms.Button();
            this.spot28 = new System.Windows.Forms.Button();
            this.spot29 = new System.Windows.Forms.Button();
            this.spot30 = new System.Windows.Forms.Button();
            this.spot31 = new System.Windows.Forms.Button();
            this.spot32 = new System.Windows.Forms.Button();
            this.spot33 = new System.Windows.Forms.Button();
            this.spot34 = new System.Windows.Forms.Button();
            this.spot35 = new System.Windows.Forms.Button();
            this.spot36 = new System.Windows.Forms.Button();
            this.spot37 = new System.Windows.Forms.Button();
            this.spot38 = new System.Windows.Forms.Button();
            this.spot39 = new System.Windows.Forms.Button();
            this.spot40 = new System.Windows.Forms.Button();
            this.spot41 = new System.Windows.Forms.Button();
            this.spot42 = new System.Windows.Forms.Button();
            this.spot43 = new System.Windows.Forms.Button();
            this.spot44 = new System.Windows.Forms.Button();
            this.spot45 = new System.Windows.Forms.Button();
            this.spot46 = new System.Windows.Forms.Button();
            this.spot47 = new System.Windows.Forms.Button();
            this.spot48 = new System.Windows.Forms.Button();
            this.spot49 = new System.Windows.Forms.Button();
            this.spot50 = new System.Windows.Forms.Button();
            this.spot51 = new System.Windows.Forms.Button();
            this.spot52 = new System.Windows.Forms.Button();
            this.spot53 = new System.Windows.Forms.Button();
            this.spot54 = new System.Windows.Forms.Button();
            this.spot55 = new System.Windows.Forms.Button();
            this.spot56 = new System.Windows.Forms.Button();
            this.spot57 = new System.Windows.Forms.Button();
            this.spot58 = new System.Windows.Forms.Button();
            this.spot59 = new System.Windows.Forms.Button();
            this.spot60 = new System.Windows.Forms.Button();
            this.spot61 = new System.Windows.Forms.Button();
            this.spot62 = new System.Windows.Forms.Button();
            this.spot63 = new System.Windows.Forms.Button();
            this.spot64 = new System.Windows.Forms.Button();
            this.spot65 = new System.Windows.Forms.Button();
            this.spot66 = new System.Windows.Forms.Button();
            this.spot67 = new System.Windows.Forms.Button();
            this.spot68 = new System.Windows.Forms.Button();
            this.spot69 = new System.Windows.Forms.Button();
            this.spot70 = new System.Windows.Forms.Button();
            this.spot71 = new System.Windows.Forms.Button();
            this.spot72 = new System.Windows.Forms.Button();
            this.spot73 = new System.Windows.Forms.Button();
            this.spot74 = new System.Windows.Forms.Button();
            this.spot75 = new System.Windows.Forms.Button();
            this.spot76 = new System.Windows.Forms.Button();
            this.spot77 = new System.Windows.Forms.Button();
            this.spot78 = new System.Windows.Forms.Button();
            this.spot79 = new System.Windows.Forms.Button();
            this.spot80 = new System.Windows.Forms.Button();
            this.gameStartBtn = new System.Windows.Forms.Button();
            this.betNumeric = new System.Windows.Forms.NumericUpDown();
            this.betLabel = new System.Windows.Forms.Label();
            this.attemptLabel = new System.Windows.Forms.Label();
            this.attemptNumeric = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.playerBank = new System.Windows.Forms.Label();
            this.playerBankLabel = new System.Windows.Forms.Label();
            this.winningLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // spot1
            // 
            this.spot1.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot1.Location = new System.Drawing.Point(3, 3);
            this.spot1.Name = "spot1";
            this.spot1.Size = new System.Drawing.Size(55, 53);
            this.spot1.TabIndex = 0;
            this.spot1.Text = "1";
            this.spot1.UseVisualStyleBackColor = true;
            this.spot1.Click += new System.EventHandler(this.Spot_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.spot1);
            this.flowLayoutPanel.Controls.Add(this.spot2);
            this.flowLayoutPanel.Controls.Add(this.spot3);
            this.flowLayoutPanel.Controls.Add(this.spot4);
            this.flowLayoutPanel.Controls.Add(this.spot5);
            this.flowLayoutPanel.Controls.Add(this.spot6);
            this.flowLayoutPanel.Controls.Add(this.spot7);
            this.flowLayoutPanel.Controls.Add(this.spot8);
            this.flowLayoutPanel.Controls.Add(this.spot9);
            this.flowLayoutPanel.Controls.Add(this.spot10);
            this.flowLayoutPanel.Controls.Add(this.spot11);
            this.flowLayoutPanel.Controls.Add(this.spot12);
            this.flowLayoutPanel.Controls.Add(this.spot13);
            this.flowLayoutPanel.Controls.Add(this.spot14);
            this.flowLayoutPanel.Controls.Add(this.spot15);
            this.flowLayoutPanel.Controls.Add(this.spot16);
            this.flowLayoutPanel.Controls.Add(this.spot17);
            this.flowLayoutPanel.Controls.Add(this.spot18);
            this.flowLayoutPanel.Controls.Add(this.spot19);
            this.flowLayoutPanel.Controls.Add(this.spot20);
            this.flowLayoutPanel.Controls.Add(this.spot21);
            this.flowLayoutPanel.Controls.Add(this.spot22);
            this.flowLayoutPanel.Controls.Add(this.spot23);
            this.flowLayoutPanel.Controls.Add(this.spot24);
            this.flowLayoutPanel.Controls.Add(this.spot25);
            this.flowLayoutPanel.Controls.Add(this.spot26);
            this.flowLayoutPanel.Controls.Add(this.spot27);
            this.flowLayoutPanel.Controls.Add(this.spot28);
            this.flowLayoutPanel.Controls.Add(this.spot29);
            this.flowLayoutPanel.Controls.Add(this.spot30);
            this.flowLayoutPanel.Controls.Add(this.spot31);
            this.flowLayoutPanel.Controls.Add(this.spot32);
            this.flowLayoutPanel.Controls.Add(this.spot33);
            this.flowLayoutPanel.Controls.Add(this.spot34);
            this.flowLayoutPanel.Controls.Add(this.spot35);
            this.flowLayoutPanel.Controls.Add(this.spot36);
            this.flowLayoutPanel.Controls.Add(this.spot37);
            this.flowLayoutPanel.Controls.Add(this.spot38);
            this.flowLayoutPanel.Controls.Add(this.spot39);
            this.flowLayoutPanel.Controls.Add(this.spot40);
            this.flowLayoutPanel.Controls.Add(this.spot41);
            this.flowLayoutPanel.Controls.Add(this.spot42);
            this.flowLayoutPanel.Controls.Add(this.spot43);
            this.flowLayoutPanel.Controls.Add(this.spot44);
            this.flowLayoutPanel.Controls.Add(this.spot45);
            this.flowLayoutPanel.Controls.Add(this.spot46);
            this.flowLayoutPanel.Controls.Add(this.spot47);
            this.flowLayoutPanel.Controls.Add(this.spot48);
            this.flowLayoutPanel.Controls.Add(this.spot49);
            this.flowLayoutPanel.Controls.Add(this.spot50);
            this.flowLayoutPanel.Controls.Add(this.spot51);
            this.flowLayoutPanel.Controls.Add(this.spot52);
            this.flowLayoutPanel.Controls.Add(this.spot53);
            this.flowLayoutPanel.Controls.Add(this.spot54);
            this.flowLayoutPanel.Controls.Add(this.spot55);
            this.flowLayoutPanel.Controls.Add(this.spot56);
            this.flowLayoutPanel.Controls.Add(this.spot57);
            this.flowLayoutPanel.Controls.Add(this.spot58);
            this.flowLayoutPanel.Controls.Add(this.spot59);
            this.flowLayoutPanel.Controls.Add(this.spot60);
            this.flowLayoutPanel.Controls.Add(this.spot61);
            this.flowLayoutPanel.Controls.Add(this.spot62);
            this.flowLayoutPanel.Controls.Add(this.spot63);
            this.flowLayoutPanel.Controls.Add(this.spot64);
            this.flowLayoutPanel.Controls.Add(this.spot65);
            this.flowLayoutPanel.Controls.Add(this.spot66);
            this.flowLayoutPanel.Controls.Add(this.spot67);
            this.flowLayoutPanel.Controls.Add(this.spot68);
            this.flowLayoutPanel.Controls.Add(this.spot69);
            this.flowLayoutPanel.Controls.Add(this.spot70);
            this.flowLayoutPanel.Controls.Add(this.spot71);
            this.flowLayoutPanel.Controls.Add(this.spot72);
            this.flowLayoutPanel.Controls.Add(this.spot73);
            this.flowLayoutPanel.Controls.Add(this.spot74);
            this.flowLayoutPanel.Controls.Add(this.spot75);
            this.flowLayoutPanel.Controls.Add(this.spot76);
            this.flowLayoutPanel.Controls.Add(this.spot77);
            this.flowLayoutPanel.Controls.Add(this.spot78);
            this.flowLayoutPanel.Controls.Add(this.spot79);
            this.flowLayoutPanel.Controls.Add(this.spot80);
            this.flowLayoutPanel.Location = new System.Drawing.Point(230, 36);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(613, 474);
            this.flowLayoutPanel.TabIndex = 1;
            this.flowLayoutPanel.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot2
            // 
            this.spot2.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot2.Location = new System.Drawing.Point(64, 3);
            this.spot2.Name = "spot2";
            this.spot2.Size = new System.Drawing.Size(55, 53);
            this.spot2.TabIndex = 1;
            this.spot2.Text = "2";
            this.spot2.UseVisualStyleBackColor = true;
            this.spot2.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot3
            // 
            this.spot3.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot3.Location = new System.Drawing.Point(125, 3);
            this.spot3.Name = "spot3";
            this.spot3.Size = new System.Drawing.Size(55, 53);
            this.spot3.TabIndex = 2;
            this.spot3.Text = "3";
            this.spot3.UseVisualStyleBackColor = true;
            this.spot3.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot4
            // 
            this.spot4.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot4.Location = new System.Drawing.Point(186, 3);
            this.spot4.Name = "spot4";
            this.spot4.Size = new System.Drawing.Size(55, 53);
            this.spot4.TabIndex = 3;
            this.spot4.Text = "4";
            this.spot4.UseVisualStyleBackColor = true;
            this.spot4.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot5
            // 
            this.spot5.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot5.Location = new System.Drawing.Point(247, 3);
            this.spot5.Name = "spot5";
            this.spot5.Size = new System.Drawing.Size(55, 53);
            this.spot5.TabIndex = 4;
            this.spot5.Text = "5";
            this.spot5.UseVisualStyleBackColor = true;
            this.spot5.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot6
            // 
            this.spot6.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot6.Location = new System.Drawing.Point(308, 3);
            this.spot6.Name = "spot6";
            this.spot6.Size = new System.Drawing.Size(55, 53);
            this.spot6.TabIndex = 5;
            this.spot6.Text = "6";
            this.spot6.UseVisualStyleBackColor = true;
            this.spot6.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot7
            // 
            this.spot7.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot7.Location = new System.Drawing.Point(369, 3);
            this.spot7.Name = "spot7";
            this.spot7.Size = new System.Drawing.Size(55, 53);
            this.spot7.TabIndex = 6;
            this.spot7.Text = "7";
            this.spot7.UseVisualStyleBackColor = true;
            this.spot7.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot8
            // 
            this.spot8.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot8.Location = new System.Drawing.Point(430, 3);
            this.spot8.Name = "spot8";
            this.spot8.Size = new System.Drawing.Size(55, 53);
            this.spot8.TabIndex = 7;
            this.spot8.Text = "8";
            this.spot8.UseVisualStyleBackColor = true;
            this.spot8.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot9
            // 
            this.spot9.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot9.Location = new System.Drawing.Point(491, 3);
            this.spot9.Name = "spot9";
            this.spot9.Size = new System.Drawing.Size(55, 53);
            this.spot9.TabIndex = 8;
            this.spot9.Text = "9";
            this.spot9.UseVisualStyleBackColor = true;
            this.spot9.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot10
            // 
            this.spot10.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot10.Location = new System.Drawing.Point(552, 3);
            this.spot10.Name = "spot10";
            this.spot10.Size = new System.Drawing.Size(55, 53);
            this.spot10.TabIndex = 9;
            this.spot10.Text = "10";
            this.spot10.UseVisualStyleBackColor = true;
            this.spot10.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot11
            // 
            this.spot11.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot11.Location = new System.Drawing.Point(3, 62);
            this.spot11.Name = "spot11";
            this.spot11.Size = new System.Drawing.Size(55, 53);
            this.spot11.TabIndex = 10;
            this.spot11.Text = "11";
            this.spot11.UseVisualStyleBackColor = true;
            this.spot11.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot12
            // 
            this.spot12.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot12.Location = new System.Drawing.Point(64, 62);
            this.spot12.Name = "spot12";
            this.spot12.Size = new System.Drawing.Size(55, 53);
            this.spot12.TabIndex = 11;
            this.spot12.Text = "12";
            this.spot12.UseVisualStyleBackColor = true;
            this.spot12.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot13
            // 
            this.spot13.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot13.Location = new System.Drawing.Point(125, 62);
            this.spot13.Name = "spot13";
            this.spot13.Size = new System.Drawing.Size(55, 53);
            this.spot13.TabIndex = 12;
            this.spot13.Text = "13";
            this.spot13.UseVisualStyleBackColor = true;
            this.spot13.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot14
            // 
            this.spot14.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot14.Location = new System.Drawing.Point(186, 62);
            this.spot14.Name = "spot14";
            this.spot14.Size = new System.Drawing.Size(55, 53);
            this.spot14.TabIndex = 13;
            this.spot14.Text = "14";
            this.spot14.UseVisualStyleBackColor = true;
            this.spot14.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot15
            // 
            this.spot15.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot15.Location = new System.Drawing.Point(247, 62);
            this.spot15.Name = "spot15";
            this.spot15.Size = new System.Drawing.Size(55, 53);
            this.spot15.TabIndex = 14;
            this.spot15.Text = "15";
            this.spot15.UseVisualStyleBackColor = true;
            this.spot15.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot16
            // 
            this.spot16.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot16.Location = new System.Drawing.Point(308, 62);
            this.spot16.Name = "spot16";
            this.spot16.Size = new System.Drawing.Size(55, 53);
            this.spot16.TabIndex = 15;
            this.spot16.Text = "16";
            this.spot16.UseVisualStyleBackColor = true;
            this.spot16.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot17
            // 
            this.spot17.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot17.Location = new System.Drawing.Point(369, 62);
            this.spot17.Name = "spot17";
            this.spot17.Size = new System.Drawing.Size(55, 53);
            this.spot17.TabIndex = 16;
            this.spot17.Text = "17";
            this.spot17.UseVisualStyleBackColor = true;
            this.spot17.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot18
            // 
            this.spot18.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot18.Location = new System.Drawing.Point(430, 62);
            this.spot18.Name = "spot18";
            this.spot18.Size = new System.Drawing.Size(55, 53);
            this.spot18.TabIndex = 17;
            this.spot18.Text = "18";
            this.spot18.UseVisualStyleBackColor = true;
            this.spot18.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot19
            // 
            this.spot19.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot19.Location = new System.Drawing.Point(491, 62);
            this.spot19.Name = "spot19";
            this.spot19.Size = new System.Drawing.Size(55, 53);
            this.spot19.TabIndex = 18;
            this.spot19.Text = "19";
            this.spot19.UseVisualStyleBackColor = true;
            this.spot19.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot20
            // 
            this.spot20.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot20.Location = new System.Drawing.Point(552, 62);
            this.spot20.Name = "spot20";
            this.spot20.Size = new System.Drawing.Size(55, 53);
            this.spot20.TabIndex = 19;
            this.spot20.Text = "20";
            this.spot20.UseVisualStyleBackColor = true;
            this.spot20.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot21
            // 
            this.spot21.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot21.Location = new System.Drawing.Point(3, 121);
            this.spot21.Name = "spot21";
            this.spot21.Size = new System.Drawing.Size(55, 53);
            this.spot21.TabIndex = 20;
            this.spot21.Text = "21";
            this.spot21.UseVisualStyleBackColor = true;
            this.spot21.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot22
            // 
            this.spot22.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot22.Location = new System.Drawing.Point(64, 121);
            this.spot22.Name = "spot22";
            this.spot22.Size = new System.Drawing.Size(55, 53);
            this.spot22.TabIndex = 21;
            this.spot22.Text = "22";
            this.spot22.UseVisualStyleBackColor = true;
            this.spot22.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot23
            // 
            this.spot23.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot23.Location = new System.Drawing.Point(125, 121);
            this.spot23.Name = "spot23";
            this.spot23.Size = new System.Drawing.Size(55, 53);
            this.spot23.TabIndex = 22;
            this.spot23.Text = "23";
            this.spot23.UseVisualStyleBackColor = true;
            this.spot23.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot24
            // 
            this.spot24.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot24.Location = new System.Drawing.Point(186, 121);
            this.spot24.Name = "spot24";
            this.spot24.Size = new System.Drawing.Size(55, 53);
            this.spot24.TabIndex = 23;
            this.spot24.Text = "24";
            this.spot24.UseVisualStyleBackColor = true;
            this.spot24.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot25
            // 
            this.spot25.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot25.Location = new System.Drawing.Point(247, 121);
            this.spot25.Name = "spot25";
            this.spot25.Size = new System.Drawing.Size(55, 53);
            this.spot25.TabIndex = 24;
            this.spot25.Text = "25";
            this.spot25.UseVisualStyleBackColor = true;
            this.spot25.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot26
            // 
            this.spot26.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot26.Location = new System.Drawing.Point(308, 121);
            this.spot26.Name = "spot26";
            this.spot26.Size = new System.Drawing.Size(55, 53);
            this.spot26.TabIndex = 25;
            this.spot26.Text = "26";
            this.spot26.UseVisualStyleBackColor = true;
            this.spot26.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot27
            // 
            this.spot27.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot27.Location = new System.Drawing.Point(369, 121);
            this.spot27.Name = "spot27";
            this.spot27.Size = new System.Drawing.Size(55, 53);
            this.spot27.TabIndex = 26;
            this.spot27.Text = "27";
            this.spot27.UseVisualStyleBackColor = true;
            this.spot27.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot28
            // 
            this.spot28.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot28.Location = new System.Drawing.Point(430, 121);
            this.spot28.Name = "spot28";
            this.spot28.Size = new System.Drawing.Size(55, 53);
            this.spot28.TabIndex = 27;
            this.spot28.Text = "28";
            this.spot28.UseVisualStyleBackColor = true;
            this.spot28.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot29
            // 
            this.spot29.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot29.Location = new System.Drawing.Point(491, 121);
            this.spot29.Name = "spot29";
            this.spot29.Size = new System.Drawing.Size(55, 53);
            this.spot29.TabIndex = 28;
            this.spot29.Text = "29";
            this.spot29.UseVisualStyleBackColor = true;
            this.spot29.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot30
            // 
            this.spot30.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot30.Location = new System.Drawing.Point(552, 121);
            this.spot30.Name = "spot30";
            this.spot30.Size = new System.Drawing.Size(55, 53);
            this.spot30.TabIndex = 29;
            this.spot30.Text = "30";
            this.spot30.UseVisualStyleBackColor = true;
            this.spot30.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot31
            // 
            this.spot31.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot31.Location = new System.Drawing.Point(3, 180);
            this.spot31.Name = "spot31";
            this.spot31.Size = new System.Drawing.Size(55, 53);
            this.spot31.TabIndex = 30;
            this.spot31.Text = "31";
            this.spot31.UseVisualStyleBackColor = true;
            this.spot31.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot32
            // 
            this.spot32.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot32.Location = new System.Drawing.Point(64, 180);
            this.spot32.Name = "spot32";
            this.spot32.Size = new System.Drawing.Size(55, 53);
            this.spot32.TabIndex = 31;
            this.spot32.Text = "32";
            this.spot32.UseVisualStyleBackColor = true;
            this.spot32.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot33
            // 
            this.spot33.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot33.Location = new System.Drawing.Point(125, 180);
            this.spot33.Name = "spot33";
            this.spot33.Size = new System.Drawing.Size(55, 53);
            this.spot33.TabIndex = 32;
            this.spot33.Text = "33";
            this.spot33.UseVisualStyleBackColor = true;
            this.spot33.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot34
            // 
            this.spot34.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot34.Location = new System.Drawing.Point(186, 180);
            this.spot34.Name = "spot34";
            this.spot34.Size = new System.Drawing.Size(55, 53);
            this.spot34.TabIndex = 33;
            this.spot34.Text = "34";
            this.spot34.UseVisualStyleBackColor = true;
            this.spot34.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot35
            // 
            this.spot35.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot35.Location = new System.Drawing.Point(247, 180);
            this.spot35.Name = "spot35";
            this.spot35.Size = new System.Drawing.Size(55, 53);
            this.spot35.TabIndex = 34;
            this.spot35.Text = "35";
            this.spot35.UseVisualStyleBackColor = true;
            this.spot35.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot36
            // 
            this.spot36.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot36.Location = new System.Drawing.Point(308, 180);
            this.spot36.Name = "spot36";
            this.spot36.Size = new System.Drawing.Size(55, 53);
            this.spot36.TabIndex = 35;
            this.spot36.Text = "36";
            this.spot36.UseVisualStyleBackColor = true;
            this.spot36.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot37
            // 
            this.spot37.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot37.Location = new System.Drawing.Point(369, 180);
            this.spot37.Name = "spot37";
            this.spot37.Size = new System.Drawing.Size(55, 53);
            this.spot37.TabIndex = 36;
            this.spot37.Text = "37";
            this.spot37.UseVisualStyleBackColor = true;
            this.spot37.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot38
            // 
            this.spot38.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot38.Location = new System.Drawing.Point(430, 180);
            this.spot38.Name = "spot38";
            this.spot38.Size = new System.Drawing.Size(55, 53);
            this.spot38.TabIndex = 37;
            this.spot38.Text = "38";
            this.spot38.UseVisualStyleBackColor = true;
            this.spot38.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot39
            // 
            this.spot39.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot39.Location = new System.Drawing.Point(491, 180);
            this.spot39.Name = "spot39";
            this.spot39.Size = new System.Drawing.Size(55, 53);
            this.spot39.TabIndex = 38;
            this.spot39.Text = "39";
            this.spot39.UseVisualStyleBackColor = true;
            this.spot39.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot40
            // 
            this.spot40.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot40.Location = new System.Drawing.Point(552, 180);
            this.spot40.Name = "spot40";
            this.spot40.Size = new System.Drawing.Size(55, 53);
            this.spot40.TabIndex = 39;
            this.spot40.Text = "40";
            this.spot40.UseVisualStyleBackColor = true;
            this.spot40.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot41
            // 
            this.spot41.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot41.Location = new System.Drawing.Point(3, 239);
            this.spot41.Name = "spot41";
            this.spot41.Size = new System.Drawing.Size(55, 53);
            this.spot41.TabIndex = 40;
            this.spot41.Text = "41";
            this.spot41.UseVisualStyleBackColor = true;
            this.spot41.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot42
            // 
            this.spot42.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot42.Location = new System.Drawing.Point(64, 239);
            this.spot42.Name = "spot42";
            this.spot42.Size = new System.Drawing.Size(55, 53);
            this.spot42.TabIndex = 41;
            this.spot42.Text = "42";
            this.spot42.UseVisualStyleBackColor = true;
            this.spot42.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot43
            // 
            this.spot43.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot43.Location = new System.Drawing.Point(125, 239);
            this.spot43.Name = "spot43";
            this.spot43.Size = new System.Drawing.Size(55, 53);
            this.spot43.TabIndex = 42;
            this.spot43.Text = "43";
            this.spot43.UseVisualStyleBackColor = true;
            this.spot43.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot44
            // 
            this.spot44.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot44.Location = new System.Drawing.Point(186, 239);
            this.spot44.Name = "spot44";
            this.spot44.Size = new System.Drawing.Size(55, 53);
            this.spot44.TabIndex = 43;
            this.spot44.Text = "44";
            this.spot44.UseVisualStyleBackColor = true;
            this.spot44.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot45
            // 
            this.spot45.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot45.Location = new System.Drawing.Point(247, 239);
            this.spot45.Name = "spot45";
            this.spot45.Size = new System.Drawing.Size(55, 53);
            this.spot45.TabIndex = 44;
            this.spot45.Text = "45";
            this.spot45.UseVisualStyleBackColor = true;
            this.spot45.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot46
            // 
            this.spot46.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot46.Location = new System.Drawing.Point(308, 239);
            this.spot46.Name = "spot46";
            this.spot46.Size = new System.Drawing.Size(55, 53);
            this.spot46.TabIndex = 45;
            this.spot46.Text = "46";
            this.spot46.UseVisualStyleBackColor = true;
            this.spot46.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot47
            // 
            this.spot47.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot47.Location = new System.Drawing.Point(369, 239);
            this.spot47.Name = "spot47";
            this.spot47.Size = new System.Drawing.Size(55, 53);
            this.spot47.TabIndex = 46;
            this.spot47.Text = "47";
            this.spot47.UseVisualStyleBackColor = true;
            this.spot47.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot48
            // 
            this.spot48.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot48.Location = new System.Drawing.Point(430, 239);
            this.spot48.Name = "spot48";
            this.spot48.Size = new System.Drawing.Size(55, 53);
            this.spot48.TabIndex = 47;
            this.spot48.Text = "48";
            this.spot48.UseVisualStyleBackColor = true;
            this.spot48.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot49
            // 
            this.spot49.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot49.Location = new System.Drawing.Point(491, 239);
            this.spot49.Name = "spot49";
            this.spot49.Size = new System.Drawing.Size(55, 53);
            this.spot49.TabIndex = 48;
            this.spot49.Text = "49";
            this.spot49.UseVisualStyleBackColor = true;
            this.spot49.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot50
            // 
            this.spot50.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot50.Location = new System.Drawing.Point(552, 239);
            this.spot50.Name = "spot50";
            this.spot50.Size = new System.Drawing.Size(55, 53);
            this.spot50.TabIndex = 49;
            this.spot50.Text = "50";
            this.spot50.UseVisualStyleBackColor = true;
            this.spot50.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot51
            // 
            this.spot51.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot51.Location = new System.Drawing.Point(3, 298);
            this.spot51.Name = "spot51";
            this.spot51.Size = new System.Drawing.Size(55, 53);
            this.spot51.TabIndex = 50;
            this.spot51.Text = "51";
            this.spot51.UseVisualStyleBackColor = true;
            this.spot51.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot52
            // 
            this.spot52.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot52.Location = new System.Drawing.Point(64, 298);
            this.spot52.Name = "spot52";
            this.spot52.Size = new System.Drawing.Size(55, 53);
            this.spot52.TabIndex = 51;
            this.spot52.Text = "52";
            this.spot52.UseVisualStyleBackColor = true;
            this.spot52.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot53
            // 
            this.spot53.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot53.Location = new System.Drawing.Point(125, 298);
            this.spot53.Name = "spot53";
            this.spot53.Size = new System.Drawing.Size(55, 53);
            this.spot53.TabIndex = 52;
            this.spot53.Text = "53";
            this.spot53.UseVisualStyleBackColor = true;
            this.spot53.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot54
            // 
            this.spot54.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot54.Location = new System.Drawing.Point(186, 298);
            this.spot54.Name = "spot54";
            this.spot54.Size = new System.Drawing.Size(55, 53);
            this.spot54.TabIndex = 53;
            this.spot54.Text = "54";
            this.spot54.UseVisualStyleBackColor = true;
            this.spot54.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot55
            // 
            this.spot55.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot55.Location = new System.Drawing.Point(247, 298);
            this.spot55.Name = "spot55";
            this.spot55.Size = new System.Drawing.Size(55, 53);
            this.spot55.TabIndex = 54;
            this.spot55.Text = "55";
            this.spot55.UseVisualStyleBackColor = true;
            this.spot55.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot56
            // 
            this.spot56.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot56.Location = new System.Drawing.Point(308, 298);
            this.spot56.Name = "spot56";
            this.spot56.Size = new System.Drawing.Size(55, 53);
            this.spot56.TabIndex = 55;
            this.spot56.Text = "56";
            this.spot56.UseVisualStyleBackColor = true;
            this.spot56.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot57
            // 
            this.spot57.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot57.Location = new System.Drawing.Point(369, 298);
            this.spot57.Name = "spot57";
            this.spot57.Size = new System.Drawing.Size(55, 53);
            this.spot57.TabIndex = 56;
            this.spot57.Text = "57";
            this.spot57.UseVisualStyleBackColor = true;
            this.spot57.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot58
            // 
            this.spot58.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot58.Location = new System.Drawing.Point(430, 298);
            this.spot58.Name = "spot58";
            this.spot58.Size = new System.Drawing.Size(55, 53);
            this.spot58.TabIndex = 57;
            this.spot58.Text = "58";
            this.spot58.UseVisualStyleBackColor = true;
            this.spot58.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot59
            // 
            this.spot59.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot59.Location = new System.Drawing.Point(491, 298);
            this.spot59.Name = "spot59";
            this.spot59.Size = new System.Drawing.Size(55, 53);
            this.spot59.TabIndex = 58;
            this.spot59.Text = "59";
            this.spot59.UseVisualStyleBackColor = true;
            this.spot59.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot60
            // 
            this.spot60.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot60.Location = new System.Drawing.Point(552, 298);
            this.spot60.Name = "spot60";
            this.spot60.Size = new System.Drawing.Size(55, 53);
            this.spot60.TabIndex = 59;
            this.spot60.Text = "60";
            this.spot60.UseVisualStyleBackColor = true;
            this.spot60.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot61
            // 
            this.spot61.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot61.Location = new System.Drawing.Point(3, 357);
            this.spot61.Name = "spot61";
            this.spot61.Size = new System.Drawing.Size(55, 53);
            this.spot61.TabIndex = 60;
            this.spot61.Text = "61";
            this.spot61.UseVisualStyleBackColor = true;
            this.spot61.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot62
            // 
            this.spot62.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot62.Location = new System.Drawing.Point(64, 357);
            this.spot62.Name = "spot62";
            this.spot62.Size = new System.Drawing.Size(55, 53);
            this.spot62.TabIndex = 61;
            this.spot62.Text = "62";
            this.spot62.UseVisualStyleBackColor = true;
            this.spot62.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot63
            // 
            this.spot63.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot63.Location = new System.Drawing.Point(125, 357);
            this.spot63.Name = "spot63";
            this.spot63.Size = new System.Drawing.Size(55, 53);
            this.spot63.TabIndex = 62;
            this.spot63.Text = "63";
            this.spot63.UseVisualStyleBackColor = true;
            this.spot63.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot64
            // 
            this.spot64.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot64.Location = new System.Drawing.Point(186, 357);
            this.spot64.Name = "spot64";
            this.spot64.Size = new System.Drawing.Size(55, 53);
            this.spot64.TabIndex = 63;
            this.spot64.Text = "64";
            this.spot64.UseVisualStyleBackColor = true;
            this.spot64.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot65
            // 
            this.spot65.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot65.Location = new System.Drawing.Point(247, 357);
            this.spot65.Name = "spot65";
            this.spot65.Size = new System.Drawing.Size(55, 53);
            this.spot65.TabIndex = 64;
            this.spot65.Text = "65";
            this.spot65.UseVisualStyleBackColor = true;
            this.spot65.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot66
            // 
            this.spot66.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot66.Location = new System.Drawing.Point(308, 357);
            this.spot66.Name = "spot66";
            this.spot66.Size = new System.Drawing.Size(55, 53);
            this.spot66.TabIndex = 65;
            this.spot66.Text = "66";
            this.spot66.UseVisualStyleBackColor = true;
            this.spot66.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot67
            // 
            this.spot67.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot67.Location = new System.Drawing.Point(369, 357);
            this.spot67.Name = "spot67";
            this.spot67.Size = new System.Drawing.Size(55, 53);
            this.spot67.TabIndex = 66;
            this.spot67.Text = "67";
            this.spot67.UseVisualStyleBackColor = true;
            this.spot67.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot68
            // 
            this.spot68.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot68.Location = new System.Drawing.Point(430, 357);
            this.spot68.Name = "spot68";
            this.spot68.Size = new System.Drawing.Size(55, 53);
            this.spot68.TabIndex = 67;
            this.spot68.Text = "68";
            this.spot68.UseVisualStyleBackColor = true;
            this.spot68.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot69
            // 
            this.spot69.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot69.Location = new System.Drawing.Point(491, 357);
            this.spot69.Name = "spot69";
            this.spot69.Size = new System.Drawing.Size(55, 53);
            this.spot69.TabIndex = 68;
            this.spot69.Text = "69";
            this.spot69.UseVisualStyleBackColor = true;
            this.spot69.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot70
            // 
            this.spot70.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot70.Location = new System.Drawing.Point(552, 357);
            this.spot70.Name = "spot70";
            this.spot70.Size = new System.Drawing.Size(55, 53);
            this.spot70.TabIndex = 69;
            this.spot70.Text = "70";
            this.spot70.UseVisualStyleBackColor = true;
            this.spot70.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot71
            // 
            this.spot71.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot71.Location = new System.Drawing.Point(3, 416);
            this.spot71.Name = "spot71";
            this.spot71.Size = new System.Drawing.Size(55, 53);
            this.spot71.TabIndex = 70;
            this.spot71.Text = "71";
            this.spot71.UseVisualStyleBackColor = true;
            this.spot71.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot72
            // 
            this.spot72.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot72.Location = new System.Drawing.Point(64, 416);
            this.spot72.Name = "spot72";
            this.spot72.Size = new System.Drawing.Size(55, 53);
            this.spot72.TabIndex = 71;
            this.spot72.Text = "72";
            this.spot72.UseVisualStyleBackColor = true;
            this.spot72.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot73
            // 
            this.spot73.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot73.Location = new System.Drawing.Point(125, 416);
            this.spot73.Name = "spot73";
            this.spot73.Size = new System.Drawing.Size(55, 53);
            this.spot73.TabIndex = 72;
            this.spot73.Text = "73";
            this.spot73.UseVisualStyleBackColor = true;
            this.spot73.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot74
            // 
            this.spot74.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot74.Location = new System.Drawing.Point(186, 416);
            this.spot74.Name = "spot74";
            this.spot74.Size = new System.Drawing.Size(55, 53);
            this.spot74.TabIndex = 73;
            this.spot74.Text = "74";
            this.spot74.UseVisualStyleBackColor = true;
            this.spot74.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot75
            // 
            this.spot75.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot75.Location = new System.Drawing.Point(247, 416);
            this.spot75.Name = "spot75";
            this.spot75.Size = new System.Drawing.Size(55, 53);
            this.spot75.TabIndex = 74;
            this.spot75.Text = "75";
            this.spot75.UseVisualStyleBackColor = true;
            this.spot75.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot76
            // 
            this.spot76.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot76.Location = new System.Drawing.Point(308, 416);
            this.spot76.Name = "spot76";
            this.spot76.Size = new System.Drawing.Size(55, 53);
            this.spot76.TabIndex = 75;
            this.spot76.Text = "76";
            this.spot76.UseVisualStyleBackColor = true;
            this.spot76.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot77
            // 
            this.spot77.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot77.Location = new System.Drawing.Point(369, 416);
            this.spot77.Name = "spot77";
            this.spot77.Size = new System.Drawing.Size(55, 53);
            this.spot77.TabIndex = 76;
            this.spot77.Text = "77";
            this.spot77.UseVisualStyleBackColor = true;
            this.spot77.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot78
            // 
            this.spot78.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot78.Location = new System.Drawing.Point(430, 416);
            this.spot78.Name = "spot78";
            this.spot78.Size = new System.Drawing.Size(55, 53);
            this.spot78.TabIndex = 77;
            this.spot78.Text = "78";
            this.spot78.UseVisualStyleBackColor = true;
            this.spot78.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot79
            // 
            this.spot79.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot79.Location = new System.Drawing.Point(491, 416);
            this.spot79.Name = "spot79";
            this.spot79.Size = new System.Drawing.Size(55, 53);
            this.spot79.TabIndex = 78;
            this.spot79.Text = "79";
            this.spot79.UseVisualStyleBackColor = true;
            this.spot79.Click += new System.EventHandler(this.Spot_Click);
            // 
            // spot80
            // 
            this.spot80.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spot80.Location = new System.Drawing.Point(552, 416);
            this.spot80.Name = "spot80";
            this.spot80.Size = new System.Drawing.Size(55, 53);
            this.spot80.TabIndex = 79;
            this.spot80.Text = "80";
            this.spot80.UseVisualStyleBackColor = true;
            this.spot80.Click += new System.EventHandler(this.Spot_Click);
            // 
            // gameStartBtn
            // 
            this.gameStartBtn.Font = new System.Drawing.Font("Montserrat Thin SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameStartBtn.Location = new System.Drawing.Point(820, 555);
            this.gameStartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.gameStartBtn.Name = "gameStartBtn";
            this.gameStartBtn.Size = new System.Drawing.Size(154, 34);
            this.gameStartBtn.TabIndex = 2;
            this.gameStartBtn.Text = "Начать игру";
            this.gameStartBtn.UseVisualStyleBackColor = true;
            this.gameStartBtn.Click += new System.EventHandler(this.gameStartBtn_Click);
            // 
            // betNumeric
            // 
            this.betNumeric.DecimalPlaces = 1;
            this.betNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.betNumeric.Location = new System.Drawing.Point(34, 569);
            this.betNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.betNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(143, 20);
            this.betNumeric.TabIndex = 4;
            this.betNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.betNumeric.ValueChanged += new System.EventHandler(this.SetBet_ValueChange);
            this.betNumeric.Leave += new System.EventHandler(this.SetBet_ValueChange);
            // 
            // betLabel
            // 
            this.betLabel.BackColor = System.Drawing.Color.Transparent;
            this.betLabel.Font = new System.Drawing.Font("Montserrat Thin Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betLabel.ForeColor = System.Drawing.Color.White;
            this.betLabel.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414;
            this.betLabel.Location = new System.Drawing.Point(32, 540);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(121, 28);
            this.betLabel.TabIndex = 0;
            this.betLabel.Text = "Ставка";
            // 
            // attemptLabel
            // 
            this.attemptLabel.BackColor = System.Drawing.Color.Transparent;
            this.attemptLabel.Font = new System.Drawing.Font("Montserrat Thin SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attemptLabel.ForeColor = System.Drawing.Color.White;
            this.attemptLabel.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414;
            this.attemptLabel.Location = new System.Drawing.Point(230, 544);
            this.attemptLabel.Name = "attemptLabel";
            this.attemptLabel.Size = new System.Drawing.Size(144, 19);
            this.attemptLabel.TabIndex = 5;
            this.attemptLabel.Text = "Кол-во попыток";
            // 
            // attemptNumeric
            // 
            this.attemptNumeric.Location = new System.Drawing.Point(229, 569);
            this.attemptNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.attemptNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attemptNumeric.Name = "attemptNumeric";
            this.attemptNumeric.Size = new System.Drawing.Size(145, 20);
            this.attemptNumeric.TabIndex = 6;
            this.attemptNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attemptNumeric.ValueChanged += new System.EventHandler(this.SetAttemptsCount_ValueChange);
            this.attemptNumeric.Leave += new System.EventHandler(this.SetAttemptsCount_ValueChange);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Montserrat Thin SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(638, 555);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(161, 34);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Очистить поле";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Clear_Click);
            // 
            // playerBank
            // 
            this.playerBank.AutoSize = true;
            this.playerBank.BackColor = System.Drawing.Color.Transparent;
            this.playerBank.Font = new System.Drawing.Font("Montserrat Thin", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerBank.ForeColor = System.Drawing.Color.White;
            this.playerBank.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414;
            this.playerBank.Location = new System.Drawing.Point(69, 90);
            this.playerBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerBank.Name = "playerBank";
            this.playerBank.Size = new System.Drawing.Size(98, 44);
            this.playerBank.TabIndex = 8;
            this.playerBank.Text = "1000";
            // 
            // playerBankLabel
            // 
            this.playerBankLabel.AutoSize = true;
            this.playerBankLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerBankLabel.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerBankLabel.ForeColor = System.Drawing.Color.White;
            this.playerBankLabel.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414;
            this.playerBankLabel.Location = new System.Drawing.Point(37, 51);
            this.playerBankLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerBankLabel.Name = "playerBankLabel";
            this.playerBankLabel.Size = new System.Drawing.Size(156, 29);
            this.playerBankLabel.TabIndex = 9;
            this.playerBankLabel.Text = "Банк игрока";
            // 
            // winningLabel
            // 
            this.winningLabel.AutoSize = true;
            this.winningLabel.BackColor = System.Drawing.Color.Transparent;
            this.winningLabel.Font = new System.Drawing.Font("Montserrat Thin Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winningLabel.ForeColor = System.Drawing.Color.White;
            this.winningLabel.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414;
            this.winningLabel.Location = new System.Drawing.Point(71, 189);
            this.winningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winningLabel.Name = "winningLabel";
            this.winningLabel.Size = new System.Drawing.Size(0, 20);
            this.winningLabel.TabIndex = 10;
            this.winningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414__1_;
            this.pictureBox2.Location = new System.Drawing.Point(17, 531);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414__1_;
            this.pictureBox3.Location = new System.Drawing.Point(211, 531);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::KenoGame.Properties.Resources.realistic_golden_frame_design_23_2149247414__1_;
            this.pictureBox4.Location = new System.Drawing.Point(12, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(203, 339);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::KenoGame.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 617);
            this.Controls.Add(this.winningLabel);
            this.Controls.Add(this.playerBankLabel);
            this.Controls.Add(this.playerBank);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.attemptLabel);
            this.Controls.Add(this.attemptNumeric);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.betNumeric);
            this.Controls.Add(this.gameStartBtn);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keno";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spot1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button spot2;
        private System.Windows.Forms.Button spot3;
        private System.Windows.Forms.Button spot4;
        private System.Windows.Forms.Button spot5;
        private System.Windows.Forms.Button spot6;
        private System.Windows.Forms.Button spot7;
        private System.Windows.Forms.Button spot8;
        private System.Windows.Forms.Button spot9;
        private System.Windows.Forms.Button spot10;
        private System.Windows.Forms.Button spot11;
        private System.Windows.Forms.Button spot12;
        private System.Windows.Forms.Button spot13;
        private System.Windows.Forms.Button spot14;
        private System.Windows.Forms.Button spot15;
        private System.Windows.Forms.Button spot16;
        private System.Windows.Forms.Button spot17;
        private System.Windows.Forms.Button spot18;
        private System.Windows.Forms.Button spot19;
        private System.Windows.Forms.Button spot20;
        private System.Windows.Forms.Button spot21;
        private System.Windows.Forms.Button spot22;
        private System.Windows.Forms.Button spot23;
        private System.Windows.Forms.Button spot24;
        private System.Windows.Forms.Button spot25;
        private System.Windows.Forms.Button spot26;
        private System.Windows.Forms.Button spot27;
        private System.Windows.Forms.Button spot28;
        private System.Windows.Forms.Button spot29;
        private System.Windows.Forms.Button spot30;
        private System.Windows.Forms.Button spot31;
        private System.Windows.Forms.Button spot32;
        private System.Windows.Forms.Button spot33;
        private System.Windows.Forms.Button spot34;
        private System.Windows.Forms.Button spot35;
        private System.Windows.Forms.Button spot36;
        private System.Windows.Forms.Button spot37;
        private System.Windows.Forms.Button spot38;
        private System.Windows.Forms.Button spot39;
        private System.Windows.Forms.Button spot40;
        private System.Windows.Forms.Button spot41;
        private System.Windows.Forms.Button spot42;
        private System.Windows.Forms.Button spot43;
        private System.Windows.Forms.Button spot44;
        private System.Windows.Forms.Button spot45;
        private System.Windows.Forms.Button spot46;
        private System.Windows.Forms.Button spot47;
        private System.Windows.Forms.Button spot48;
        private System.Windows.Forms.Button spot49;
        private System.Windows.Forms.Button spot50;
        private System.Windows.Forms.Button spot51;
        private System.Windows.Forms.Button spot52;
        private System.Windows.Forms.Button spot53;
        private System.Windows.Forms.Button spot54;
        private System.Windows.Forms.Button spot55;
        private System.Windows.Forms.Button spot56;
        private System.Windows.Forms.Button spot57;
        private System.Windows.Forms.Button spot58;
        private System.Windows.Forms.Button spot59;
        private System.Windows.Forms.Button spot60;
        private System.Windows.Forms.Button spot61;
        private System.Windows.Forms.Button spot62;
        private System.Windows.Forms.Button spot63;
        private System.Windows.Forms.Button spot64;
        private System.Windows.Forms.Button spot65;
        private System.Windows.Forms.Button spot66;
        private System.Windows.Forms.Button spot67;
        private System.Windows.Forms.Button spot68;
        private System.Windows.Forms.Button spot69;
        private System.Windows.Forms.Button spot70;
        private System.Windows.Forms.Button spot71;
        private System.Windows.Forms.Button spot72;
        private System.Windows.Forms.Button spot73;
        private System.Windows.Forms.Button spot74;
        private System.Windows.Forms.Button spot75;
        private System.Windows.Forms.Button spot76;
        private System.Windows.Forms.Button spot77;
        private System.Windows.Forms.Button spot78;
        private System.Windows.Forms.Button spot79;
        private System.Windows.Forms.Button spot80;
        private System.Windows.Forms.Button gameStartBtn;
        private System.Windows.Forms.NumericUpDown betNumeric;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label attemptLabel;
        private System.Windows.Forms.NumericUpDown attemptNumeric;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label playerBank;
        private System.Windows.Forms.Label playerBankLabel;
        private Label winningLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}

