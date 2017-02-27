namespace distanceCalculator
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
            this.TotalTaxTb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TotalCostTb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SpendLabel = new DevComponents.DotNetBar.LabelX();
            this.TotalTaxLabel = new DevComponents.DotNetBar.LabelX();
            this.TotalCostLabel = new DevComponents.DotNetBar.LabelX();
            this.ClearBtn = new DevComponents.DotNetBar.ButtonX();
            this.CalculBtn = new DevComponents.DotNetBar.ButtonX();
            this.TaxLabel = new DevComponents.DotNetBar.LabelX();
            this.Curr1Label = new DevComponents.DotNetBar.LabelX();
            this.PerLabel = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SpendTb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PerTb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // TotalTaxTb
            // 
            // 
            // 
            // 
            this.TotalTaxTb.Border.Class = "TextBoxBorder";
            this.TotalTaxTb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TotalTaxTb.ButtonCustom.Tooltip = "";
            this.TotalTaxTb.ButtonCustom2.Tooltip = "";
            this.TotalTaxTb.Enabled = false;
            this.TotalTaxTb.Location = new System.Drawing.Point(311, 48);
            this.TotalTaxTb.Name = "TotalTaxTb";
            this.TotalTaxTb.PreventEnterBeep = true;
            this.TotalTaxTb.Size = new System.Drawing.Size(100, 20);
            this.TotalTaxTb.TabIndex = 1;
            // 
            // TotalCostTb
            // 
            // 
            // 
            // 
            this.TotalCostTb.Border.Class = "TextBoxBorder";
            this.TotalCostTb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TotalCostTb.ButtonCustom.Tooltip = "";
            this.TotalCostTb.ButtonCustom2.Tooltip = "";
            this.TotalCostTb.Enabled = false;
            this.TotalCostTb.Location = new System.Drawing.Point(311, 102);
            this.TotalCostTb.Name = "TotalCostTb";
            this.TotalCostTb.PreventEnterBeep = true;
            this.TotalCostTb.Size = new System.Drawing.Size(100, 20);
            this.TotalCostTb.TabIndex = 2;
            // 
            // SpendLabel
            // 
            // 
            // 
            // 
            this.SpendLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SpendLabel.Location = new System.Drawing.Point(18, 45);
            this.SpendLabel.Name = "SpendLabel";
            this.SpendLabel.Size = new System.Drawing.Size(60, 23);
            this.SpendLabel.TabIndex = 8;
            this.SpendLabel.Text = "Spending:";
            // 
            // TotalTaxLabel
            // 
            // 
            // 
            // 
            this.TotalTaxLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TotalTaxLabel.Location = new System.Drawing.Point(236, 45);
            this.TotalTaxLabel.Name = "TotalTaxLabel";
            this.TotalTaxLabel.Size = new System.Drawing.Size(60, 23);
            this.TotalTaxLabel.TabIndex = 9;
            this.TotalTaxLabel.Text = "Total Tax:";
            // 
            // TotalCostLabel
            // 
            // 
            // 
            // 
            this.TotalCostLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TotalCostLabel.Location = new System.Drawing.Point(236, 99);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(60, 23);
            this.TotalCostLabel.TabIndex = 10;
            this.TotalCostLabel.Text = "Total Cost:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ClearBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ClearBtn.Location = new System.Drawing.Point(63, 177);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ClearBtn.TabIndex = 13;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CalculBtn
            // 
            this.CalculBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CalculBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CalculBtn.Location = new System.Drawing.Point(281, 177);
            this.CalculBtn.Name = "CalculBtn";
            this.CalculBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CalculBtn.TabIndex = 0;
            this.CalculBtn.Text = "Calculate";
            this.CalculBtn.Click += new System.EventHandler(this.CalculBtn_Click);
            // 
            // TaxLabel
            // 
            // 
            // 
            // 
            this.TaxLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TaxLabel.Location = new System.Drawing.Point(33, 99);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(60, 23);
            this.TaxLabel.TabIndex = 14;
            this.TaxLabel.Text = "State Tax:";
            // 
            // Curr1Label
            // 
            // 
            // 
            // 
            this.Curr1Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Curr1Label.Location = new System.Drawing.Point(79, 45);
            this.Curr1Label.Name = "Curr1Label";
            this.Curr1Label.Size = new System.Drawing.Size(18, 23);
            this.Curr1Label.TabIndex = 17;
            this.Curr1Label.Text = "$";
            this.Curr1Label.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // PerLabel
            // 
            // 
            // 
            // 
            this.PerLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PerLabel.Location = new System.Drawing.Point(144, 101);
            this.PerLabel.Name = "PerLabel";
            this.PerLabel.Size = new System.Drawing.Size(27, 23);
            this.PerLabel.TabIndex = 18;
            this.PerLabel.Text = "%";
            this.PerLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(293, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(18, 23);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "$";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(293, 99);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(18, 23);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "$";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // SpendTb
            // 
            // 
            // 
            // 
            this.SpendTb.Border.Class = "TextBoxBorder";
            this.SpendTb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SpendTb.ButtonCustom.Tooltip = "";
            this.SpendTb.ButtonCustom2.Tooltip = "";
            this.SpendTb.Location = new System.Drawing.Point(100, 48);
            this.SpendTb.MaxLength = 15;
            this.SpendTb.Name = "SpendTb";
            this.SpendTb.PreventEnterBeep = true;
            this.SpendTb.Size = new System.Drawing.Size(100, 20);
            this.SpendTb.TabIndex = 21;
            // 
            // PerTb
            // 
            // 
            // 
            // 
            this.PerTb.Border.Class = "TextBoxBorder";
            this.PerTb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PerTb.ButtonCustom.Tooltip = "";
            this.PerTb.ButtonCustom2.Tooltip = "";
            this.PerTb.Location = new System.Drawing.Point(89, 102);
            this.PerTb.MaxLength = 10;
            this.PerTb.Name = "PerTb";
            this.PerTb.PreventEnterBeep = true;
            this.PerTb.Size = new System.Drawing.Size(61, 20);
            this.PerTb.TabIndex = 22;
            this.PerTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.PerTb);
            this.Controls.Add(this.SpendTb);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.PerLabel);
            this.Controls.Add(this.Curr1Label);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.CalculBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.TotalTaxLabel);
            this.Controls.Add(this.SpendLabel);
            this.Controls.Add(this.TotalCostTb);
            this.Controls.Add(this.TotalTaxTb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 280);
            this.Name = "MainForm";
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX TotalTaxTb;
        private DevComponents.DotNetBar.Controls.TextBoxX TotalCostTb;
        private DevComponents.DotNetBar.LabelX SpendLabel;
        private DevComponents.DotNetBar.LabelX TotalTaxLabel;
        private DevComponents.DotNetBar.LabelX TotalCostLabel;
        private DevComponents.DotNetBar.ButtonX ClearBtn;
        private DevComponents.DotNetBar.ButtonX CalculBtn;
        private DevComponents.DotNetBar.LabelX TaxLabel;
        private DevComponents.DotNetBar.LabelX Curr1Label;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX PerLabel;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX SpendTb;
        private DevComponents.DotNetBar.Controls.TextBoxX PerTb;
    }
}

