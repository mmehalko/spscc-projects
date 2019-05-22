namespace ChangeCalculator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of change due (1-100):";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(178, 24);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(50, 20);
            this.txtChange.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quarters:";
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(178, 61);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.ReadOnly = true;
            this.txtQuarters.Size = new System.Drawing.Size(50, 20);
            this.txtQuarters.TabIndex = 3;
            this.txtQuarters.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dimes:";
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(178, 87);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.ReadOnly = true;
            this.txtDimes.Size = new System.Drawing.Size(50, 20);
            this.txtDimes.TabIndex = 5;
            this.txtDimes.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nickels:";
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(178, 114);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.ReadOnly = true;
            this.txtNickels.Size = new System.Drawing.Size(50, 20);
            this.txtNickels.TabIndex = 7;
            this.txtNickels.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pennies:";
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(178, 141);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.ReadOnly = true;
            this.txtPennies.Size = new System.Drawing.Size(50, 20);
            this.txtPennies.TabIndex = 9;
            this.txtPennies.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(61, 180);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(152, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(251, 218);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

