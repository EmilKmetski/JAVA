namespace PriceCheckerSoapClient
{
    partial class itemVireForm
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
            this.btCheckBarcode = new System.Windows.Forms.Button();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbMeasure = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.pixBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btCheckBarcode
            // 
            this.btCheckBarcode.Location = new System.Drawing.Point(228, 3);
            this.btCheckBarcode.Name = "btCheckBarcode";
            this.btCheckBarcode.Size = new System.Drawing.Size(75, 23);
            this.btCheckBarcode.TabIndex = 0;
            this.btCheckBarcode.Text = "Проверка";
            this.btCheckBarcode.UseVisualStyleBackColor = true;
            this.btCheckBarcode.Click += new System.EventHandler(this.btCheckBarcode_Click);
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(62, 6);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(160, 20);
            this.tbBarcode.TabIndex = 1;
            this.tbBarcode.Text = "20000011";
            this.tbBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarcode_KeyPress);
            this.tbBarcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbBarcode_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Баркод";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.lbMeasure);
            this.groupBox1.Controls.Add(this.lbItemName);
            this.groupBox1.Controls.Add(this.pixBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 498);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Снимка:";
            // 
            // lbPrice
            // 
            this.lbPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbPrice.Location = new System.Drawing.Point(277, 29);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(107, 45);
            this.lbPrice.TabIndex = 8;
            // 
            // lbMeasure
            // 
            this.lbMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMeasure.Location = new System.Drawing.Point(184, 29);
            this.lbMeasure.Name = "lbMeasure";
            this.lbMeasure.Size = new System.Drawing.Size(82, 45);
            this.lbMeasure.TabIndex = 7;
            // 
            // lbItemName
            // 
            this.lbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbItemName.Location = new System.Drawing.Point(9, 29);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(169, 50);
            this.lbItemName.TabIndex = 6;
            // 
            // pixBox
            // 
            this.pixBox.Location = new System.Drawing.Point(6, 117);
            this.pixBox.Name = "pixBox";
            this.pixBox.Size = new System.Drawing.Size(375, 375);
            this.pixBox.TabIndex = 3;
            this.pixBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Мярка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(309, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Изход";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 542);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.btCheckBarcode);
            this.Name = "Form1";
            this.Text = "Items price check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCheckBarcode;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pixBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbMeasure;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label label5;
    }
}

