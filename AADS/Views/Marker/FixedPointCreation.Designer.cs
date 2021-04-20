
namespace AADS.Views.Marker
{
    partial class FixedPointCreation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbSpecial = new System.Windows.Forms.RadioButton();
            this.rdbOBSPost = new System.Windows.Forms.RadioButton();
            this.rdbFRadar = new System.Windows.Forms.RadioButton();
            this.rdbMRadar = new System.Windows.Forms.RadioButton();
            this.rdbTactical = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddMarker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbSpecial
            // 
            this.rdbSpecial.AutoSize = true;
            this.rdbSpecial.Location = new System.Drawing.Point(110, 229);
            this.rdbSpecial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbSpecial.Name = "rdbSpecial";
            this.rdbSpecial.Size = new System.Drawing.Size(60, 17);
            this.rdbSpecial.TabIndex = 79;
            this.rdbSpecial.TabStop = true;
            this.rdbSpecial.Text = "Special";
            this.rdbSpecial.UseVisualStyleBackColor = true;
            // 
            // rdbOBSPost
            // 
            this.rdbOBSPost.AutoSize = true;
            this.rdbOBSPost.Location = new System.Drawing.Point(219, 206);
            this.rdbOBSPost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbOBSPost.Name = "rdbOBSPost";
            this.rdbOBSPost.Size = new System.Drawing.Size(71, 17);
            this.rdbOBSPost.TabIndex = 78;
            this.rdbOBSPost.TabStop = true;
            this.rdbOBSPost.Text = "OBS Post";
            this.rdbOBSPost.UseVisualStyleBackColor = true;
            // 
            // rdbFRadar
            // 
            this.rdbFRadar.AutoSize = true;
            this.rdbFRadar.Location = new System.Drawing.Point(110, 206);
            this.rdbFRadar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbFRadar.Name = "rdbFRadar";
            this.rdbFRadar.Size = new System.Drawing.Size(63, 17);
            this.rdbFRadar.TabIndex = 77;
            this.rdbFRadar.TabStop = true;
            this.rdbFRadar.Text = "F-Radar";
            this.rdbFRadar.UseVisualStyleBackColor = true;
            // 
            // rdbMRadar
            // 
            this.rdbMRadar.AutoSize = true;
            this.rdbMRadar.Location = new System.Drawing.Point(219, 185);
            this.rdbMRadar.Name = "rdbMRadar";
            this.rdbMRadar.Size = new System.Drawing.Size(66, 17);
            this.rdbMRadar.TabIndex = 76;
            this.rdbMRadar.TabStop = true;
            this.rdbMRadar.Text = "M-Radar";
            this.rdbMRadar.UseVisualStyleBackColor = true;
            // 
            // rdbTactical
            // 
            this.rdbTactical.AutoSize = true;
            this.rdbTactical.Location = new System.Drawing.Point(110, 183);
            this.rdbTactical.Name = "rdbTactical";
            this.rdbTactical.Size = new System.Drawing.Size(63, 17);
            this.rdbTactical.TabIndex = 75;
            this.rdbTactical.TabStop = true;
            this.rdbTactical.Text = "Tactical";
            this.rdbTactical.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(219, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 69;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Decimal Degree",
            "Degree Decimal Minutes",
            "Degree Minute Seconds",
            "UTM",
            "MGRS",
            "GEOREF"});
            this.cmbPosition.Location = new System.Drawing.Point(241, 128);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(98, 24);
            this.cmbPosition.TabIndex = 115;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(87, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 22);
            this.txtName.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "หมาบเลข";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 119;
            this.label2.Text = "สัญลักษณ์";
            // 
            // txtLabel
            // 
            this.txtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLabel.Location = new System.Drawing.Point(87, 78);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(252, 22);
            this.txtLabel.TabIndex = 118;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPosition.Location = new System.Drawing.Point(87, 128);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(148, 22);
            this.txtPosition.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 121;
            this.label3.Text = "ตำแหน่ง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 123;
            this.label4.Text = "หมายเหตุ";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRemark.Location = new System.Drawing.Point(87, 271);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(252, 63);
            this.txtRemark.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 124;
            this.label5.Text = "ประเภท";
            // 
            // btnAddMarker
            // 
            this.btnAddMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMarker.Location = new System.Drawing.Point(163, 366);
            this.btnAddMarker.Name = "btnAddMarker";
            this.btnAddMarker.Size = new System.Drawing.Size(72, 47);
            this.btnAddMarker.TabIndex = 125;
            this.btnAddMarker.Text = "สร้าง";
            this.btnAddMarker.UseVisualStyleBackColor = true;
            // 
            // FixedPointCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddMarker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.rdbSpecial);
            this.Controls.Add(this.rdbOBSPost);
            this.Controls.Add(this.rdbFRadar);
            this.Controls.Add(this.rdbMRadar);
            this.Controls.Add(this.rdbTactical);
            this.Controls.Add(this.checkBox1);
            this.Name = "FixedPointCreation";
            this.Size = new System.Drawing.Size(366, 617);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbSpecial;
        private System.Windows.Forms.RadioButton rdbOBSPost;
        private System.Windows.Forms.RadioButton rdbFRadar;
        private System.Windows.Forms.RadioButton rdbMRadar;
        private System.Windows.Forms.RadioButton rdbTactical;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddMarker;
    }
}
