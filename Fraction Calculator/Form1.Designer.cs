
namespace Fraction_Calculator
{
    partial class frmFractionCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumerator1 = new System.Windows.Forms.TextBox();
            this.txtDenominator1 = new System.Windows.Forms.TextBox();
            this.cmbOperators = new System.Windows.Forms.ComboBox();
            this.txtNumerator2 = new System.Windows.Forms.TextBox();
            this.txtDenominator2 = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblDividerLine1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tlsLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslMainOutput = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFraction1Divider = new System.Windows.Forms.Label();
            this.lblFraction2Divider = new System.Windows.Forms.Label();
            this.lblEqualSign = new System.Windows.Forms.Label();
            this.stsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumerator1
            // 
            this.txtNumerator1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumerator1.Location = new System.Drawing.Point(33, 32);
            this.txtNumerator1.Name = "txtNumerator1";
            this.txtNumerator1.Size = new System.Drawing.Size(64, 43);
            this.txtNumerator1.TabIndex = 0;
            this.txtNumerator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumerator1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerator1_KeyPress);
            // 
            // txtDenominator1
            // 
            this.txtDenominator1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDenominator1.Location = new System.Drawing.Point(35, 108);
            this.txtDenominator1.Name = "txtDenominator1";
            this.txtDenominator1.Size = new System.Drawing.Size(64, 43);
            this.txtDenominator1.TabIndex = 1;
            this.txtDenominator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDenominator1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDenominator1_KeyPress);
            // 
            // cmbOperators
            // 
            this.cmbOperators.DisplayMember = "+";
            this.cmbOperators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperators.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbOperators.FormattingEnabled = true;
            this.cmbOperators.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperators.Location = new System.Drawing.Point(123, 63);
            this.cmbOperators.Name = "cmbOperators";
            this.cmbOperators.Size = new System.Drawing.Size(71, 45);
            this.cmbOperators.TabIndex = 2;
            // 
            // txtNumerator2
            // 
            this.txtNumerator2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumerator2.Location = new System.Drawing.Point(210, 32);
            this.txtNumerator2.Name = "txtNumerator2";
            this.txtNumerator2.Size = new System.Drawing.Size(64, 43);
            this.txtNumerator2.TabIndex = 3;
            this.txtNumerator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumerator2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerator2_KeyPress);
            // 
            // txtDenominator2
            // 
            this.txtDenominator2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDenominator2.Location = new System.Drawing.Point(210, 108);
            this.txtDenominator2.Name = "txtDenominator2";
            this.txtDenominator2.Size = new System.Drawing.Size(64, 43);
            this.txtDenominator2.TabIndex = 4;
            this.txtDenominator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDenominator2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDenominator2_KeyPress);
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResults.Location = new System.Drawing.Point(362, 32);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(306, 119);
            this.lblResults.TabIndex = 5;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDividerLine1
            // 
            this.lblDividerLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDividerLine1.Location = new System.Drawing.Point(34, 179);
            this.lblDividerLine1.Name = "lblDividerLine1";
            this.lblDividerLine1.Size = new System.Drawing.Size(635, 2);
            this.lblDividerLine1.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(355, 204);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 70);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(525, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 70);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsLabelMain,
            this.tslMainOutput});
            this.stsMain.Location = new System.Drawing.Point(0, 289);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(684, 22);
            this.stsMain.SizingGrip = false;
            this.stsMain.TabIndex = 9;
            // 
            // tlsLabelMain
            // 
            this.tlsLabelMain.Name = "tlsLabelMain";
            this.tlsLabelMain.Size = new System.Drawing.Size(0, 17);
            // 
            // tslMainOutput
            // 
            this.tslMainOutput.Name = "tslMainOutput";
            this.tslMainOutput.Size = new System.Drawing.Size(26, 17);
            this.tslMainOutput.Text = "test";
            this.tslMainOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFraction1Divider
            // 
            this.lblFraction1Divider.BackColor = System.Drawing.Color.Black;
            this.lblFraction1Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFraction1Divider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFraction1Divider.Location = new System.Drawing.Point(33, 92);
            this.lblFraction1Divider.Name = "lblFraction1Divider";
            this.lblFraction1Divider.Size = new System.Drawing.Size(64, 2);
            this.lblFraction1Divider.TabIndex = 10;
            this.lblFraction1Divider.Text = "label1";
            // 
            // lblFraction2Divider
            // 
            this.lblFraction2Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFraction2Divider.Location = new System.Drawing.Point(209, 91);
            this.lblFraction2Divider.Name = "lblFraction2Divider";
            this.lblFraction2Divider.Size = new System.Drawing.Size(64, 2);
            this.lblFraction2Divider.TabIndex = 11;
            // 
            // lblEqualSign
            // 
            this.lblEqualSign.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEqualSign.Location = new System.Drawing.Point(298, 44);
            this.lblEqualSign.Name = "lblEqualSign";
            this.lblEqualSign.Size = new System.Drawing.Size(58, 66);
            this.lblEqualSign.TabIndex = 12;
            this.lblEqualSign.Text = "=";
            // 
            // frmFractionCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.lblEqualSign);
            this.Controls.Add(this.lblFraction2Divider);
            this.Controls.Add(this.lblFraction1Divider);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDividerLine1);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtDenominator2);
            this.Controls.Add(this.txtNumerator2);
            this.Controls.Add(this.cmbOperators);
            this.Controls.Add(this.txtDenominator1);
            this.Controls.Add(this.txtNumerator1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmFractionCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraction Calculator";
            this.Load += new System.EventHandler(this.frmFractionCalculator_Load);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumerator1;
        private System.Windows.Forms.TextBox txtDenominator1;
        private System.Windows.Forms.ComboBox cmbOperators;
        private System.Windows.Forms.TextBox txtNumerator2;
        private System.Windows.Forms.TextBox txtDenominator2;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblDividerLine1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.Label lblFraction1Divider;
        private System.Windows.Forms.Label lblFraction2Divider;
        private System.Windows.Forms.Label lblEqualSign;
        private System.Windows.Forms.ToolStripStatusLabel tlsLabelMain;
        private System.Windows.Forms.ToolStripStatusLabel tslMainOutput;
    }
}

