
namespace Assignment5._3
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnBiSirl = new System.Windows.Forms.Button();
            this.btnBiDeSirl = new System.Windows.Forms.Button();
            this.btnXMLSirl = new System.Windows.Forms.Button();
            this.btnXMLDeSirl = new System.Windows.Forms.Button();
            this.btnJSONSirl = new System.Windows.Forms.Button();
            this.btnJSONDeSirl = new System.Windows.Forms.Button();
            this.gpbxDeSirlRslt = new System.Windows.Forms.GroupBox();
            this.txbxOutput = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txbxID = new System.Windows.Forms.TextBox();
            this.txbxName = new System.Windows.Forms.TextBox();
            this.txbxAddress = new System.Windows.Forms.TextBox();
            this.gpbxDeSirlRslt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(597, 25);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Assignment 5.3 (De-)Serialization in Binary, XML, and JSON";
            // 
            // btnBiSirl
            // 
            this.btnBiSirl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiSirl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBiSirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBiSirl.Location = new System.Drawing.Point(23, 167);
            this.btnBiSirl.Name = "btnBiSirl";
            this.btnBiSirl.Size = new System.Drawing.Size(154, 40);
            this.btnBiSirl.TabIndex = 4;
            this.btnBiSirl.Text = "Binary Serialization";
            this.btnBiSirl.UseVisualStyleBackColor = true;
            this.btnBiSirl.Click += new System.EventHandler(this.btnBiSirl_Click);
            // 
            // btnBiDeSirl
            // 
            this.btnBiDeSirl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiDeSirl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBiDeSirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBiDeSirl.Location = new System.Drawing.Point(207, 167);
            this.btnBiDeSirl.Name = "btnBiDeSirl";
            this.btnBiDeSirl.Size = new System.Drawing.Size(154, 40);
            this.btnBiDeSirl.TabIndex = 5;
            this.btnBiDeSirl.Text = "Binary Deserialization";
            this.btnBiDeSirl.UseVisualStyleBackColor = true;
            this.btnBiDeSirl.Click += new System.EventHandler(this.btnBiDeSirl_Click);
            // 
            // btnXMLSirl
            // 
            this.btnXMLSirl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXMLSirl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnXMLSirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXMLSirl.Location = new System.Drawing.Point(23, 230);
            this.btnXMLSirl.Name = "btnXMLSirl";
            this.btnXMLSirl.Size = new System.Drawing.Size(154, 40);
            this.btnXMLSirl.TabIndex = 6;
            this.btnXMLSirl.Text = "XML Serialization";
            this.btnXMLSirl.UseVisualStyleBackColor = true;
            this.btnXMLSirl.Click += new System.EventHandler(this.btnXMLSirl_Click);
            // 
            // btnXMLDeSirl
            // 
            this.btnXMLDeSirl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXMLDeSirl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnXMLDeSirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXMLDeSirl.Location = new System.Drawing.Point(207, 230);
            this.btnXMLDeSirl.Name = "btnXMLDeSirl";
            this.btnXMLDeSirl.Size = new System.Drawing.Size(154, 40);
            this.btnXMLDeSirl.TabIndex = 7;
            this.btnXMLDeSirl.Text = "XML Deserialization";
            this.btnXMLDeSirl.UseVisualStyleBackColor = true;
            this.btnXMLDeSirl.Click += new System.EventHandler(this.btnXMLDeSirl_Click);
            // 
            // btnJSONSirl
            // 
            this.btnJSONSirl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJSONSirl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJSONSirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJSONSirl.Location = new System.Drawing.Point(23, 297);
            this.btnJSONSirl.Name = "btnJSONSirl";
            this.btnJSONSirl.Size = new System.Drawing.Size(154, 40);
            this.btnJSONSirl.TabIndex = 8;
            this.btnJSONSirl.Text = "JSON Serialization";
            this.btnJSONSirl.UseVisualStyleBackColor = true;
            this.btnJSONSirl.Click += new System.EventHandler(this.btnJSONSirl_Click);
            // 
            // btnJSONDeSirl
            // 
            this.btnJSONDeSirl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJSONDeSirl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJSONDeSirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJSONDeSirl.Location = new System.Drawing.Point(207, 297);
            this.btnJSONDeSirl.Name = "btnJSONDeSirl";
            this.btnJSONDeSirl.Size = new System.Drawing.Size(154, 40);
            this.btnJSONDeSirl.TabIndex = 9;
            this.btnJSONDeSirl.Text = "JSON Deserialization";
            this.btnJSONDeSirl.UseVisualStyleBackColor = true;
            this.btnJSONDeSirl.Click += new System.EventHandler(this.btnJSONDeSirl_Click);
            // 
            // gpbxDeSirlRslt
            // 
            this.gpbxDeSirlRslt.Controls.Add(this.txbxOutput);
            this.gpbxDeSirlRslt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpbxDeSirlRslt.Location = new System.Drawing.Point(399, 68);
            this.gpbxDeSirlRslt.Name = "gpbxDeSirlRslt";
            this.gpbxDeSirlRslt.Size = new System.Drawing.Size(271, 275);
            this.gpbxDeSirlRslt.TabIndex = 11;
            this.gpbxDeSirlRslt.TabStop = false;
            this.gpbxDeSirlRslt.Text = "Deserialization Output";
            // 
            // txbxOutput
            // 
            this.txbxOutput.AcceptsReturn = true;
            this.txbxOutput.BackColor = System.Drawing.SystemColors.WindowText;
            this.txbxOutput.ForeColor = System.Drawing.Color.White;
            this.txbxOutput.Location = new System.Drawing.Point(7, 19);
            this.txbxOutput.Multiline = true;
            this.txbxOutput.Name = "txbxOutput";
            this.txbxOutput.Size = new System.Drawing.Size(258, 250);
            this.txbxOutput.TabIndex = 10;
            this.txbxOutput.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblID.Location = new System.Drawing.Point(27, 58);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 17);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Employee ID #:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(27, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Employee Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.Location = new System.Drawing.Point(27, 124);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(130, 17);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Employee Address:";
            // 
            // txbxID
            // 
            this.txbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbxID.Location = new System.Drawing.Point(159, 55);
            this.txbxID.Name = "txbxID";
            this.txbxID.Size = new System.Drawing.Size(202, 23);
            this.txbxID.TabIndex = 0;
            // 
            // txbxName
            // 
            this.txbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbxName.Location = new System.Drawing.Point(159, 89);
            this.txbxName.Name = "txbxName";
            this.txbxName.Size = new System.Drawing.Size(202, 23);
            this.txbxName.TabIndex = 1;
            this.txbxName.Validated += new System.EventHandler(this.Form1_Load);
            // 
            // txbxAddress
            // 
            this.txbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbxAddress.Location = new System.Drawing.Point(159, 121);
            this.txbxAddress.Name = "txbxAddress";
            this.txbxAddress.Size = new System.Drawing.Size(202, 23);
            this.txbxAddress.TabIndex = 2;
            this.txbxAddress.Validated += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 377);
            this.Controls.Add(this.txbxAddress);
            this.Controls.Add(this.txbxName);
            this.Controls.Add(this.txbxID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gpbxDeSirlRslt);
            this.Controls.Add(this.btnJSONDeSirl);
            this.Controls.Add(this.btnJSONSirl);
            this.Controls.Add(this.btnXMLDeSirl);
            this.Controls.Add(this.btnXMLSirl);
            this.Controls.Add(this.btnBiDeSirl);
            this.Controls.Add(this.btnBiSirl);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbxDeSirlRslt.ResumeLayout(false);
            this.gpbxDeSirlRslt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnBiSirl;
        private System.Windows.Forms.Button btnBiDeSirl;
        private System.Windows.Forms.Button btnXMLSirl;
        private System.Windows.Forms.Button btnXMLDeSirl;
        private System.Windows.Forms.Button btnJSONSirl;
        private System.Windows.Forms.Button btnJSONDeSirl;
        private System.Windows.Forms.GroupBox gpbxDeSirlRslt;
        private System.Windows.Forms.TextBox txbxOutput;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txbxID;
        private System.Windows.Forms.TextBox txbxName;
        private System.Windows.Forms.TextBox txbxAddress;
    }
}

