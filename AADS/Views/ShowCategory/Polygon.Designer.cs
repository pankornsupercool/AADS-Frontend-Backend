
namespace AADS.Views.ShowCategory
{
    partial class Polygon
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
            this.btnShowRestrictedArea = new System.Windows.Forms.Button();
            this.btnShowRD = new System.Windows.Forms.Button();
            this.btnShowGeographic = new System.Windows.Forms.Button();
            this.panelShowDetail = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnShowRestrictedArea
            // 
            this.btnShowRestrictedArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRestrictedArea.Location = new System.Drawing.Point(101, 3);
            this.btnShowRestrictedArea.Name = "btnShowRestrictedArea";
            this.btnShowRestrictedArea.Size = new System.Drawing.Size(91, 61);
            this.btnShowRestrictedArea.TabIndex = 5;
            this.btnShowRestrictedArea.Text = "RestrictedArea";
            this.btnShowRestrictedArea.UseVisualStyleBackColor = true;
            this.btnShowRestrictedArea.Click += new System.EventHandler(this.btnShowRestrictedArea_Click);
            // 
            // btnShowRD
            // 
            this.btnShowRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRD.Location = new System.Drawing.Point(197, 3);
            this.btnShowRD.Name = "btnShowRD";
            this.btnShowRD.Size = new System.Drawing.Size(91, 61);
            this.btnShowRD.TabIndex = 4;
            this.btnShowRD.Text = "Resource Distribution";
            this.btnShowRD.UseVisualStyleBackColor = true;
            this.btnShowRD.Click += new System.EventHandler(this.btnShowRD_Click);
            // 
            // btnShowGeographic
            // 
            this.btnShowGeographic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGeographic.Location = new System.Drawing.Point(5, 3);
            this.btnShowGeographic.Name = "btnShowGeographic";
            this.btnShowGeographic.Size = new System.Drawing.Size(91, 61);
            this.btnShowGeographic.TabIndex = 3;
            this.btnShowGeographic.Text = "Geographic";
            this.btnShowGeographic.UseVisualStyleBackColor = true;
            this.btnShowGeographic.Click += new System.EventHandler(this.btnShowGeographic_Click);
            // 
            // panelShowDetail
            // 
            this.panelShowDetail.BackColor = System.Drawing.Color.Transparent;
            this.panelShowDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowDetail.Location = new System.Drawing.Point(0, 81);
            this.panelShowDetail.Name = "panelShowDetail";
            this.panelShowDetail.Size = new System.Drawing.Size(366, 684);
            this.panelShowDetail.TabIndex = 6;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(366, 81);
            this.panelTop.TabIndex = 7;
            // 
            // Polygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShowDetail);
            this.Controls.Add(this.btnShowRestrictedArea);
            this.Controls.Add(this.btnShowRD);
            this.Controls.Add(this.btnShowGeographic);
            this.Controls.Add(this.panelTop);
            this.Name = "Polygon";
            this.Size = new System.Drawing.Size(366, 765);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowRestrictedArea;
        private System.Windows.Forms.Button btnShowRD;
        private System.Windows.Forms.Button btnShowGeographic;
        private System.Windows.Forms.Panel panelShowDetail;
        private System.Windows.Forms.Panel panelTop;
    }
}
