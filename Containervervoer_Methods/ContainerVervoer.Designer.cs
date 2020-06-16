namespace Containervervoer_Methods
{
    partial class ContainerVervoer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaxWeight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MinWeight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.containerCountLabel = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.ContainersLb = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ValuableRb = new System.Windows.Forms.RadioButton();
            this.CooledRb = new System.Windows.Forms.RadioButton();
            this.NormalRb = new System.Windows.Forms.RadioButton();
            this.AddToStackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ContainerWeightNud = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalWeightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Stackbtn = new System.Windows.Forms.Button();
            this.StackLb = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ShipInfoLabel = new System.Windows.Forms.Label();
            this.ShipInfoLb = new System.Windows.Forms.ListBox();
            this.maximumShipWeightLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WidthNud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LengthNud = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerWeightNud)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNud)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaxWeight);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MinWeight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Weightlabel);
            this.groupBox1.Controls.Add(this.containerCountLabel);
            this.groupBox1.Controls.Add(this.RemoveBtn);
            this.groupBox1.Controls.Add(this.SortBtn);
            this.groupBox1.Controls.Add(this.ContainersLb);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.AddToStackBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ContainerWeightNud);
            this.groupBox1.Location = new System.Drawing.Point(412, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Container Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MaxWeight
            // 
            this.MaxWeight.AutoSize = true;
            this.MaxWeight.Location = new System.Drawing.Point(332, 289);
            this.MaxWeight.Name = "MaxWeight";
            this.MaxWeight.Size = new System.Drawing.Size(0, 13);
            this.MaxWeight.TabIndex = 9;
            this.MaxWeight.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Maximaal:";
            // 
            // MinWeight
            // 
            this.MinWeight.AutoSize = true;
            this.MinWeight.Location = new System.Drawing.Point(332, 260);
            this.MinWeight.Name = "MinWeight";
            this.MinWeight.Size = new System.Drawing.Size(0, 13);
            this.MinWeight.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Minimaal:";
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Location = new System.Drawing.Point(296, 241);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(0, 13);
            this.Weightlabel.TabIndex = 5;
            // 
            // containerCountLabel
            // 
            this.containerCountLabel.AutoSize = true;
            this.containerCountLabel.Location = new System.Drawing.Point(15, 241);
            this.containerCountLabel.Name = "containerCountLabel";
            this.containerCountLabel.Size = new System.Drawing.Size(0, 13);
            this.containerCountLabel.TabIndex = 4;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(192, 241);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(69, 241);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 23);
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // ContainersLb
            // 
            this.ContainersLb.FormattingEnabled = true;
            this.ContainersLb.Location = new System.Drawing.Point(18, 140);
            this.ContainersLb.Name = "ContainersLb";
            this.ContainersLb.Size = new System.Drawing.Size(339, 95);
            this.ContainersLb.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ValuableRb);
            this.groupBox3.Controls.Add(this.CooledRb);
            this.groupBox3.Controls.Add(this.NormalRb);
            this.groupBox3.Location = new System.Drawing.Point(157, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // ValuableRb
            // 
            this.ValuableRb.AutoSize = true;
            this.ValuableRb.Location = new System.Drawing.Point(16, 70);
            this.ValuableRb.Name = "ValuableRb";
            this.ValuableRb.Size = new System.Drawing.Size(58, 17);
            this.ValuableRb.TabIndex = 4;
            this.ValuableRb.TabStop = true;
            this.ValuableRb.Text = "Cooled";
            this.ValuableRb.UseVisualStyleBackColor = true;
            // 
            // CooledRb
            // 
            this.CooledRb.AutoSize = true;
            this.CooledRb.Location = new System.Drawing.Point(16, 47);
            this.CooledRb.Name = "CooledRb";
            this.CooledRb.Size = new System.Drawing.Size(66, 17);
            this.CooledRb.TabIndex = 3;
            this.CooledRb.TabStop = true;
            this.CooledRb.Text = "Valuable";
            this.CooledRb.UseVisualStyleBackColor = true;
            this.CooledRb.CheckedChanged += new System.EventHandler(this.CooledRb_CheckedChanged);
            // 
            // NormalRb
            // 
            this.NormalRb.AutoSize = true;
            this.NormalRb.Location = new System.Drawing.Point(16, 19);
            this.NormalRb.Name = "NormalRb";
            this.NormalRb.Size = new System.Drawing.Size(58, 17);
            this.NormalRb.TabIndex = 2;
            this.NormalRb.TabStop = true;
            this.NormalRb.Text = "Normal";
            this.NormalRb.UseVisualStyleBackColor = true;
            // 
            // AddToStackBtn
            // 
            this.AddToStackBtn.Location = new System.Drawing.Point(6, 89);
            this.AddToStackBtn.Name = "AddToStackBtn";
            this.AddToStackBtn.Size = new System.Drawing.Size(101, 23);
            this.AddToStackBtn.TabIndex = 1;
            this.AddToStackBtn.Text = "Create";
            this.AddToStackBtn.UseVisualStyleBackColor = true;
            this.AddToStackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Container Weight:";
            // 
            // ContainerWeightNud
            // 
            this.ContainerWeightNud.Location = new System.Drawing.Point(6, 53);
            this.ContainerWeightNud.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.ContainerWeightNud.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ContainerWeightNud.Name = "ContainerWeightNud";
            this.ContainerWeightNud.Size = new System.Drawing.Size(120, 20);
            this.ContainerWeightNud.TabIndex = 1;
            this.ContainerWeightNud.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalWeightLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Stackbtn);
            this.groupBox2.Controls.Add(this.StackLb);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stack Information";
            // 
            // TotalWeightLabel
            // 
            this.TotalWeightLabel.AutoSize = true;
            this.TotalWeightLabel.Location = new System.Drawing.Point(44, 140);
            this.TotalWeightLabel.Name = "TotalWeightLabel";
            this.TotalWeightLabel.Size = new System.Drawing.Size(10, 13);
            this.TotalWeightLabel.TabIndex = 3;
            this.TotalWeightLabel.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Weight:";
            // 
            // Stackbtn
            // 
            this.Stackbtn.Location = new System.Drawing.Point(142, 120);
            this.Stackbtn.Name = "Stackbtn";
            this.Stackbtn.Size = new System.Drawing.Size(102, 23);
            this.Stackbtn.TabIndex = 1;
            this.Stackbtn.Text = "Debug Stack";
            this.Stackbtn.UseVisualStyleBackColor = true;
            this.Stackbtn.Click += new System.EventHandler(this.Stackbtn_Click);
            // 
            // StackLb
            // 
            this.StackLb.FormattingEnabled = true;
            this.StackLb.Location = new System.Drawing.Point(6, 19);
            this.StackLb.Name = "StackLb";
            this.StackLb.Size = new System.Drawing.Size(364, 95);
            this.StackLb.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ShipInfoLabel);
            this.groupBox4.Controls.Add(this.ShipInfoLb);
            this.groupBox4.Controls.Add(this.maximumShipWeightLabel);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.WidthNud);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.LengthNud);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 240);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ship Settings";
            // 
            // ShipInfoLabel
            // 
            this.ShipInfoLabel.AutoSize = true;
            this.ShipInfoLabel.Location = new System.Drawing.Point(127, 123);
            this.ShipInfoLabel.Name = "ShipInfoLabel";
            this.ShipInfoLabel.Size = new System.Drawing.Size(86, 13);
            this.ShipInfoLabel.TabIndex = 9;
            this.ShipInfoLabel.Text = "Ship Information:";
            // 
            // ShipInfoLb
            // 
            this.ShipInfoLb.FormattingEnabled = true;
            this.ShipInfoLb.Location = new System.Drawing.Point(130, 139);
            this.ShipInfoLb.Name = "ShipInfoLb";
            this.ShipInfoLb.Size = new System.Drawing.Size(217, 95);
            this.ShipInfoLb.TabIndex = 8;
            this.ShipInfoLb.SelectedIndexChanged += new System.EventHandler(this.ShipInfoLb_SelectedIndexChanged);
            // 
            // maximumShipWeightLabel
            // 
            this.maximumShipWeightLabel.AutoSize = true;
            this.maximumShipWeightLabel.Location = new System.Drawing.Point(127, 99);
            this.maximumShipWeightLabel.Name = "maximumShipWeightLabel";
            this.maximumShipWeightLabel.Size = new System.Drawing.Size(0, 13);
            this.maximumShipWeightLabel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Ship";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WidthNud
            // 
            this.WidthNud.Location = new System.Drawing.Point(153, 60);
            this.WidthNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNud.Name = "WidthNud";
            this.WidthNud.Size = new System.Drawing.Size(120, 20);
            this.WidthNud.TabIndex = 3;
            this.WidthNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Breedte in Containers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lengte in Containers:";
            // 
            // LengthNud
            // 
            this.LengthNud.Location = new System.Drawing.Point(9, 60);
            this.LengthNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthNud.Name = "LengthNud";
            this.LengthNud.Size = new System.Drawing.Size(120, 20);
            this.LengthNud.TabIndex = 3;
            this.LengthNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ContainerVervoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ContainerVervoer";
            this.Text = "Container Vervoer";
            this.Load += new System.EventHandler(this.ContainerVervoer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerWeightNud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddToStackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ContainerWeightNud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Stackbtn;
        private System.Windows.Forms.ListBox StackLb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ValuableRb;
        private System.Windows.Forms.RadioButton CooledRb;
        private System.Windows.Forms.RadioButton NormalRb;
        private System.Windows.Forms.ListBox ContainersLb;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Label TotalWeightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown WidthNud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown LengthNud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label containerCountLabel;
        private System.Windows.Forms.Label maximumShipWeightLabel;
        private System.Windows.Forms.Label ShipInfoLabel;
        private System.Windows.Forms.ListBox ShipInfoLb;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.Label MinWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MaxWeight;
        private System.Windows.Forms.Label label6;
    }
}

