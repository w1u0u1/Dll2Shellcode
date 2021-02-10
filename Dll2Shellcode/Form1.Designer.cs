namespace Dll2Shellcode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDll = new System.Windows.Forms.TextBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArgument = new System.Windows.Forms.TextBox();
            this.btnBowser = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dll:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Funtion:";
            // 
            // txtDll
            // 
            this.txtDll.Location = new System.Drawing.Point(60, 26);
            this.txtDll.Name = "txtDll";
            this.txtDll.Size = new System.Drawing.Size(385, 20);
            this.txtDll.TabIndex = 0;
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(60, 59);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(240, 20);
            this.txtFunction.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Argument:";
            // 
            // txtArgument
            // 
            this.txtArgument.Location = new System.Drawing.Point(60, 99);
            this.txtArgument.Multiline = true;
            this.txtArgument.Name = "txtArgument";
            this.txtArgument.Size = new System.Drawing.Size(429, 220);
            this.txtArgument.TabIndex = 3;
            // 
            // btnBowser
            // 
            this.btnBowser.Location = new System.Drawing.Point(449, 25);
            this.btnBowser.Name = "btnBowser";
            this.btnBowser.Size = new System.Drawing.Size(40, 23);
            this.btnBowser.TabIndex = 1;
            this.btnBowser.Text = "...";
            this.btnBowser.UseVisualStyleBackColor = true;
            this.btnBowser.Click += new System.EventHandler(this.BtnBowser_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(284, 333);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBuild;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 370);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnBowser);
            this.Controls.Add(this.txtArgument);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dll2Shellcode 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDll;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArgument;
        private System.Windows.Forms.Button btnBowser;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnCancel;
    }
}

