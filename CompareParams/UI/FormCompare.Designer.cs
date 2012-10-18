namespace CompareParams.UI
{
    partial class FormCompare
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboInstProp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboInst = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioGreat = new System.Windows.Forms.RadioButton();
            this.radioLess = new System.Windows.Forms.RadioButton();
            this.radioUneq = new System.Windows.Forms.RadioButton();
            this.radioEq = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboHostProp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboHost = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboInstProp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboInst);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Properties";
            // 
            // comboInstProp
            // 
            this.comboInstProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInstProp.FormattingEnabled = true;
            this.comboInstProp.Location = new System.Drawing.Point(26, 107);
            this.comboInstProp.Name = "comboInstProp";
            this.comboInstProp.Size = new System.Drawing.Size(240, 21);
            this.comboInstProp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Element";
            // 
            // comboInst
            // 
            this.comboInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInst.FormattingEnabled = true;
            this.comboInst.Location = new System.Drawing.Point(26, 46);
            this.comboInst.Name = "comboInst";
            this.comboInst.Size = new System.Drawing.Size(240, 21);
            this.comboInst.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(753, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(697, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(616, 518);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Location = new System.Drawing.Point(12, 518);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 32);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioGreat);
            this.groupBox3.Controls.Add(this.radioLess);
            this.groupBox3.Controls.Add(this.radioUneq);
            this.groupBox3.Controls.Add(this.radioEq);
            this.groupBox3.Location = new System.Drawing.Point(362, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(63, 149);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operator";
            // 
            // radioGreat
            // 
            this.radioGreat.AutoSize = true;
            this.radioGreat.Location = new System.Drawing.Point(17, 110);
            this.radioGreat.Name = "radioGreat";
            this.radioGreat.Size = new System.Drawing.Size(31, 17);
            this.radioGreat.TabIndex = 3;
            this.radioGreat.TabStop = true;
            this.radioGreat.Text = ">";
            this.radioGreat.UseVisualStyleBackColor = true;
            // 
            // radioLess
            // 
            this.radioLess.AutoSize = true;
            this.radioLess.Location = new System.Drawing.Point(17, 84);
            this.radioLess.Name = "radioLess";
            this.radioLess.Size = new System.Drawing.Size(31, 17);
            this.radioLess.TabIndex = 2;
            this.radioLess.TabStop = true;
            this.radioLess.Text = "<";
            this.radioLess.UseVisualStyleBackColor = true;
            // 
            // radioUneq
            // 
            this.radioUneq.AutoSize = true;
            this.radioUneq.Location = new System.Drawing.Point(17, 57);
            this.radioUneq.Name = "radioUneq";
            this.radioUneq.Size = new System.Drawing.Size(34, 17);
            this.radioUneq.TabIndex = 1;
            this.radioUneq.TabStop = true;
            this.radioUneq.Text = "!=";
            this.radioUneq.UseVisualStyleBackColor = true;
            // 
            // radioEq
            // 
            this.radioEq.AutoSize = true;
            this.radioEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEq.Location = new System.Drawing.Point(17, 29);
            this.radioEq.Name = "radioEq";
            this.radioEq.Size = new System.Drawing.Size(31, 17);
            this.radioEq.TabIndex = 0;
            this.radioEq.TabStop = true;
            this.radioEq.Text = "=";
            this.radioEq.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboHostProp);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboHost);
            this.groupBox4.Location = new System.Drawing.Point(474, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 150);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Properties";
            // 
            // comboHostProp
            // 
            this.comboHostProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHostProp.FormattingEnabled = true;
            this.comboHostProp.Location = new System.Drawing.Point(29, 107);
            this.comboHostProp.Name = "comboHostProp";
            this.comboHostProp.Size = new System.Drawing.Size(240, 21);
            this.comboHostProp.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Element";
            // 
            // comboHost
            // 
            this.comboHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHost.FormattingEnabled = true;
            this.comboHost.Location = new System.Drawing.Point(29, 46);
            this.comboHost.Name = "comboHost";
            this.comboHost.Size = new System.Drawing.Size(240, 21);
            this.comboHost.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(317, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(431, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "g";
            // 
            // FormCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCompare";
            this.Text = "Compare Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboInst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboInstProp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioGreat;
        private System.Windows.Forms.RadioButton radioLess;
        private System.Windows.Forms.RadioButton radioUneq;
        private System.Windows.Forms.RadioButton radioEq;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboHostProp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}