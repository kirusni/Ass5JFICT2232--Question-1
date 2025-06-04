namespace AreaCalculator
{
    partial class Form1
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.Radius = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.btnCalcukate = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadius.Location = new System.Drawing.Point(220, 109);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(148, 41);
            this.txtRadius.TabIndex = 13;
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radius.Location = new System.Drawing.Point(118, 114);
            this.Radius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(104, 36);
            this.Radius.TabIndex = 11;
            this.Radius.Text = "Side A";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(237, 360);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 36);
            this.lblResult.TabIndex = 8;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(118, 360);
            this.Area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(104, 36);
            this.Area.TabIndex = 9;
            this.Area.Text = "Side C";
            // 
            // btnCalcukate
            // 
            this.btnCalcukate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcukate.Location = new System.Drawing.Point(220, 240);
            this.btnCalcukate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcukate.Name = "btnCalcukate";
            this.btnCalcukate.Size = new System.Drawing.Size(200, 68);
            this.btnCalcukate.TabIndex = 7;
            this.btnCalcukate.Text = "Calculate";
            this.btnCalcukate.UseVisualStyleBackColor = true;
            this.btnCalcukate.Click += new System.EventHandler(this.btnCalcukate_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 20;
            this.lstHistory.Location = new System.Drawing.Point(511, 350);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(391, 244);
            this.lstHistory.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 39);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(104, 506);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(84, 40);
            this.btnHistory.TabIndex = 16;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 654);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.btnCalcukate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button btnCalcukate;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHistory;
    }
}

