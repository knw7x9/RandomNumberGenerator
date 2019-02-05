namespace RandomNumberGenerator {
    partial class frmRandomNumberDistribution {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbArray = new System.Windows.Forms.ListBox();
            this.lbHowManyNumbers = new System.Windows.Forms.ListBox();
            this.lblSeed = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.lblArraySize = new System.Windows.Forms.Label();
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.lblGenerateNumbersBetween = new System.Windows.Forms.Label();
            this.txtGenerateNumbersBetween = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.trValueAtIndex = new System.Windows.Forms.TrackBar();
            this.lblValueAtIndex = new System.Windows.Forms.Label();
            this.lblOutputValue = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblOutputMinimum = new System.Windows.Forms.Label();
            this.lblOutputMaximum = new System.Windows.Forms.Label();
            this.lblOutputRange = new System.Windows.Forms.Label();
            this.lblOutputSum = new System.Windows.Forms.Label();
            this.lblOutputMean = new System.Windows.Forms.Label();
            this.chkMinimum = new System.Windows.Forms.CheckBox();
            this.chkMaximum = new System.Windows.Forms.CheckBox();
            this.chkRange = new System.Windows.Forms.CheckBox();
            this.chkSum = new System.Windows.Forms.CheckBox();
            this.chkMean = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trValueAtIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // lbArray
            // 
            this.lbArray.FormattingEnabled = true;
            this.lbArray.Location = new System.Drawing.Point(12, 12);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(101, 602);
            this.lbArray.TabIndex = 0;
            // 
            // lbHowManyNumbers
            // 
            this.lbHowManyNumbers.FormattingEnabled = true;
            this.lbHowManyNumbers.Location = new System.Drawing.Point(119, 311);
            this.lbHowManyNumbers.Name = "lbHowManyNumbers";
            this.lbHowManyNumbers.Size = new System.Drawing.Size(407, 303);
            this.lbHowManyNumbers.TabIndex = 1;
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(134, 16);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(165, 13);
            this.lblSeed.TabIndex = 2;
            this.lblSeed.Text = "Random Number Generator Seed";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(120, 32);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(200, 20);
            this.txtSeed.TabIndex = 3;
            this.txtSeed.TextChanged += new System.EventHandler(this.txtSeed_TextChanged);
            // 
            // lblArraySize
            // 
            this.lblArraySize.AutoSize = true;
            this.lblArraySize.Location = new System.Drawing.Point(396, 16);
            this.lblArraySize.Name = "lblArraySize";
            this.lblArraySize.Size = new System.Drawing.Size(54, 13);
            this.lblArraySize.TabIndex = 4;
            this.lblArraySize.Text = "Array Size";
            // 
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(326, 32);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(200, 20);
            this.txtArraySize.TabIndex = 5;
            this.txtArraySize.TextChanged += new System.EventHandler(this.txtArraySize_TextChanged);
            // 
            // lblGenerateNumbersBetween
            // 
            this.lblGenerateNumbersBetween.AutoSize = true;
            this.lblGenerateNumbersBetween.Location = new System.Drawing.Point(188, 58);
            this.lblGenerateNumbersBetween.Name = "lblGenerateNumbersBetween";
            this.lblGenerateNumbersBetween.Size = new System.Drawing.Size(168, 13);
            this.lblGenerateNumbersBetween.TabIndex = 6;
            this.lblGenerateNumbersBetween.Text = "Generate numbers between 1 and";
            // 
            // txtGenerateNumbersBetween
            // 
            this.txtGenerateNumbersBetween.Location = new System.Drawing.Point(362, 55);
            this.txtGenerateNumbersBetween.Name = "txtGenerateNumbersBetween";
            this.txtGenerateNumbersBetween.Size = new System.Drawing.Size(75, 20);
            this.txtGenerateNumbersBetween.TabIndex = 7;
            this.txtGenerateNumbersBetween.TextChanged += new System.EventHandler(this.txtGenerateNumbersBetween_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(251, 117);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 20);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(120, 117);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 20);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(382, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 20);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // trValueAtIndex
            // 
            this.trValueAtIndex.Location = new System.Drawing.Point(120, 151);
            this.trValueAtIndex.Name = "trValueAtIndex";
            this.trValueAtIndex.Size = new System.Drawing.Size(387, 45);
            this.trValueAtIndex.TabIndex = 11;
            this.trValueAtIndex.Visible = false;
            this.trValueAtIndex.Scroll += new System.EventHandler(this.trValueAtIndex_Scroll);
            // 
            // lblValueAtIndex
            // 
            this.lblValueAtIndex.AutoSize = true;
            this.lblValueAtIndex.Location = new System.Drawing.Point(264, 204);
            this.lblValueAtIndex.Name = "lblValueAtIndex";
            this.lblValueAtIndex.Size = new System.Drawing.Size(87, 13);
            this.lblValueAtIndex.TabIndex = 12;
            this.lblValueAtIndex.Text = "Value at Index 0:";
            this.lblValueAtIndex.Visible = false;
            // 
            // lblOutputValue
            // 
            this.lblOutputValue.AutoSize = true;
            this.lblOutputValue.Location = new System.Drawing.Point(302, 230);
            this.lblOutputValue.Name = "lblOutputValue";
            this.lblOutputValue.Size = new System.Drawing.Size(0, 13);
            this.lblOutputValue.TabIndex = 13;
            this.lblOutputValue.Visible = false;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(123, 257);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(51, 13);
            this.lblMinimum.TabIndex = 14;
            this.lblMinimum.Text = "Minimum:";
            this.lblMinimum.Visible = false;
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(205, 257);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(54, 13);
            this.lblMaximum.TabIndex = 15;
            this.lblMaximum.Text = "Maximum:";
            this.lblMaximum.Visible = false;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(293, 257);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(42, 13);
            this.lblRange.TabIndex = 16;
            this.lblRange.Text = "Range:";
            this.lblRange.Visible = false;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(382, 257);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(31, 13);
            this.lblSum.TabIndex = 17;
            this.lblSum.Text = "Sum:";
            this.lblSum.Visible = false;
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(463, 257);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(37, 13);
            this.lblMean.TabIndex = 18;
            this.lblMean.Text = "Mean:";
            this.lblMean.Visible = false;
            // 
            // lblOutputMinimum
            // 
            this.lblOutputMinimum.AutoSize = true;
            this.lblOutputMinimum.Location = new System.Drawing.Point(141, 284);
            this.lblOutputMinimum.Name = "lblOutputMinimum";
            this.lblOutputMinimum.Size = new System.Drawing.Size(0, 13);
            this.lblOutputMinimum.TabIndex = 19;
            this.lblOutputMinimum.Visible = false;
            // 
            // lblOutputMaximum
            // 
            this.lblOutputMaximum.AutoSize = true;
            this.lblOutputMaximum.Location = new System.Drawing.Point(224, 284);
            this.lblOutputMaximum.Name = "lblOutputMaximum";
            this.lblOutputMaximum.Size = new System.Drawing.Size(0, 13);
            this.lblOutputMaximum.TabIndex = 20;
            this.lblOutputMaximum.Visible = false;
            // 
            // lblOutputRange
            // 
            this.lblOutputRange.AutoSize = true;
            this.lblOutputRange.Location = new System.Drawing.Point(302, 284);
            this.lblOutputRange.Name = "lblOutputRange";
            this.lblOutputRange.Size = new System.Drawing.Size(0, 13);
            this.lblOutputRange.TabIndex = 21;
            this.lblOutputRange.Visible = false;
            // 
            // lblOutputSum
            // 
            this.lblOutputSum.AutoSize = true;
            this.lblOutputSum.Location = new System.Drawing.Point(388, 284);
            this.lblOutputSum.Name = "lblOutputSum";
            this.lblOutputSum.Size = new System.Drawing.Size(0, 13);
            this.lblOutputSum.TabIndex = 22;
            this.lblOutputSum.Visible = false;
            // 
            // lblOutputMean
            // 
            this.lblOutputMean.AutoSize = true;
            this.lblOutputMean.Location = new System.Drawing.Point(474, 284);
            this.lblOutputMean.Name = "lblOutputMean";
            this.lblOutputMean.Size = new System.Drawing.Size(0, 13);
            this.lblOutputMean.TabIndex = 23;
            this.lblOutputMean.Visible = false;
            // 
            // chkMinimum
            // 
            this.chkMinimum.AutoSize = true;
            this.chkMinimum.Location = new System.Drawing.Point(165, 86);
            this.chkMinimum.Name = "chkMinimum";
            this.chkMinimum.Size = new System.Drawing.Size(67, 17);
            this.chkMinimum.TabIndex = 24;
            this.chkMinimum.Text = "Minimum";
            this.chkMinimum.UseVisualStyleBackColor = true;
            // 
            // chkMaximum
            // 
            this.chkMaximum.AutoSize = true;
            this.chkMaximum.Location = new System.Drawing.Point(238, 85);
            this.chkMaximum.Name = "chkMaximum";
            this.chkMaximum.Size = new System.Drawing.Size(70, 17);
            this.chkMaximum.TabIndex = 25;
            this.chkMaximum.Text = "Maximum";
            this.chkMaximum.UseVisualStyleBackColor = true;
            // 
            // chkRange
            // 
            this.chkRange.AutoSize = true;
            this.chkRange.Location = new System.Drawing.Point(314, 86);
            this.chkRange.Name = "chkRange";
            this.chkRange.Size = new System.Drawing.Size(58, 17);
            this.chkRange.TabIndex = 26;
            this.chkRange.Text = "Range";
            this.chkRange.UseVisualStyleBackColor = true;
            // 
            // chkSum
            // 
            this.chkSum.AutoSize = true;
            this.chkSum.Location = new System.Drawing.Point(378, 86);
            this.chkSum.Name = "chkSum";
            this.chkSum.Size = new System.Drawing.Size(47, 17);
            this.chkSum.TabIndex = 27;
            this.chkSum.Text = "Sum";
            this.chkSum.UseVisualStyleBackColor = true;
            // 
            // chkMean
            // 
            this.chkMean.AutoSize = true;
            this.chkMean.Location = new System.Drawing.Point(431, 86);
            this.chkMean.Name = "chkMean";
            this.chkMean.Size = new System.Drawing.Size(53, 17);
            this.chkMean.TabIndex = 28;
            this.chkMean.Text = "Mean";
            this.chkMean.UseVisualStyleBackColor = true;
            // 
            // frmRandomNumberDistribution
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 627);
            this.Controls.Add(this.chkMean);
            this.Controls.Add(this.chkSum);
            this.Controls.Add(this.chkRange);
            this.Controls.Add(this.chkMaximum);
            this.Controls.Add(this.chkMinimum);
            this.Controls.Add(this.lblOutputMean);
            this.Controls.Add(this.lblOutputSum);
            this.Controls.Add(this.lblOutputRange);
            this.Controls.Add(this.lblOutputMaximum);
            this.Controls.Add(this.lblOutputMinimum);
            this.Controls.Add(this.lblMean);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblOutputValue);
            this.Controls.Add(this.lblValueAtIndex);
            this.Controls.Add(this.trValueAtIndex);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtGenerateNumbersBetween);
            this.Controls.Add(this.lblGenerateNumbersBetween);
            this.Controls.Add(this.txtArraySize);
            this.Controls.Add(this.lblArraySize);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.lblSeed);
            this.Controls.Add(this.lbHowManyNumbers);
            this.Controls.Add(this.lbArray);
            this.Name = "frmRandomNumberDistribution";
            this.Text = "Random Number Distribution";
            ((System.ComponentModel.ISupportInitialize)(this.trValueAtIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbArray;
        private System.Windows.Forms.ListBox lbHowManyNumbers;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label lblArraySize;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.Label lblGenerateNumbersBetween;
        private System.Windows.Forms.TextBox txtGenerateNumbersBetween;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TrackBar trValueAtIndex;
        private System.Windows.Forms.Label lblValueAtIndex;
        private System.Windows.Forms.Label lblOutputValue;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lblOutputMinimum;
        private System.Windows.Forms.Label lblOutputMaximum;
        private System.Windows.Forms.Label lblOutputRange;
        private System.Windows.Forms.Label lblOutputSum;
        private System.Windows.Forms.Label lblOutputMean;
        private System.Windows.Forms.CheckBox chkMinimum;
        private System.Windows.Forms.CheckBox chkMaximum;
        private System.Windows.Forms.CheckBox chkRange;
        private System.Windows.Forms.CheckBox chkSum;
        private System.Windows.Forms.CheckBox chkMean;
    }
}

