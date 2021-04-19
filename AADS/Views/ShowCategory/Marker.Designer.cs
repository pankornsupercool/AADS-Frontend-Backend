
namespace AADS.Views.ShowCategory
{
    partial class Marker
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
            this.btnShowAiport = new System.Windows.Forms.Button();
            this.btnShowCity = new System.Windows.Forms.Button();
            this.btnShowFixedPoint = new System.Windows.Forms.Button();
            this.panelShowDetail = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnShowWeaponBattery = new System.Windows.Forms.Button();
            this.btnShowVitalAsset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnShowFireUnit = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAiport
            // 
            this.btnShowAiport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowAiport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAiport.Location = new System.Drawing.Point(52, 0);
            this.btnShowAiport.Name = "btnShowAiport";
            this.btnShowAiport.Size = new System.Drawing.Size(52, 66);
            this.btnShowAiport.TabIndex = 0;
            this.btnShowAiport.Text = "Airport";
            this.btnShowAiport.UseVisualStyleBackColor = true;
            this.btnShowAiport.Click += new System.EventHandler(this.btnShowAiport_Click);
            // 
            // btnShowCity
            // 
            this.btnShowCity.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCity.Location = new System.Drawing.Point(0, 0);
            this.btnShowCity.Name = "btnShowCity";
            this.btnShowCity.Size = new System.Drawing.Size(52, 66);
            this.btnShowCity.TabIndex = 1;
            this.btnShowCity.Text = "City";
            this.btnShowCity.UseVisualStyleBackColor = true;
            this.btnShowCity.Click += new System.EventHandler(this.btnShowCity_Click);
            // 
            // btnShowFixedPoint
            // 
            this.btnShowFixedPoint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowFixedPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFixedPoint.Location = new System.Drawing.Point(104, 0);
            this.btnShowFixedPoint.Name = "btnShowFixedPoint";
            this.btnShowFixedPoint.Size = new System.Drawing.Size(52, 66);
            this.btnShowFixedPoint.TabIndex = 2;
            this.btnShowFixedPoint.Text = "Fixed Point";
            this.btnShowFixedPoint.UseVisualStyleBackColor = true;
            this.btnShowFixedPoint.Click += new System.EventHandler(this.btnShowFixedPoint_Click);
            // 
            // panelShowDetail
            // 
            this.panelShowDetail.BackColor = System.Drawing.Color.Transparent;
            this.panelShowDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowDetail.Location = new System.Drawing.Point(0, 66);
            this.panelShowDetail.Name = "panelShowDetail";
            this.panelShowDetail.Size = new System.Drawing.Size(366, 699);
            this.panelShowDetail.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnShowWeaponBattery);
            this.panelTop.Controls.Add(this.btnShowVitalAsset);
            this.panelTop.Controls.Add(this.button3);
            this.panelTop.Controls.Add(this.btnShowFireUnit);
            this.panelTop.Controls.Add(this.btnShowFixedPoint);
            this.panelTop.Controls.Add(this.btnShowAiport);
            this.panelTop.Controls.Add(this.btnShowCity);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(366, 66);
            this.panelTop.TabIndex = 4;
            // 
            // btnShowWeaponBattery
            // 
            this.btnShowWeaponBattery.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowWeaponBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowWeaponBattery.Location = new System.Drawing.Point(312, 0);
            this.btnShowWeaponBattery.Name = "btnShowWeaponBattery";
            this.btnShowWeaponBattery.Size = new System.Drawing.Size(52, 66);
            this.btnShowWeaponBattery.TabIndex = 6;
            this.btnShowWeaponBattery.Text = "Weapon Battery";
            this.btnShowWeaponBattery.UseVisualStyleBackColor = true;
            this.btnShowWeaponBattery.Click += new System.EventHandler(this.btnShowWeaponBattery_Click);
            // 
            // btnShowVitalAsset
            // 
            this.btnShowVitalAsset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowVitalAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowVitalAsset.Location = new System.Drawing.Point(260, 0);
            this.btnShowVitalAsset.Name = "btnShowVitalAsset";
            this.btnShowVitalAsset.Size = new System.Drawing.Size(52, 66);
            this.btnShowVitalAsset.TabIndex = 5;
            this.btnShowVitalAsset.Text = "Vital Asset";
            this.btnShowVitalAsset.UseVisualStyleBackColor = true;
            this.btnShowVitalAsset.Click += new System.EventHandler(this.btnShowVitalAsset_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(208, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "Landmark";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnShowFireUnit
            // 
            this.btnShowFireUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowFireUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFireUnit.Location = new System.Drawing.Point(156, 0);
            this.btnShowFireUnit.Name = "btnShowFireUnit";
            this.btnShowFireUnit.Size = new System.Drawing.Size(52, 66);
            this.btnShowFireUnit.TabIndex = 3;
            this.btnShowFireUnit.Text = "Fire Unit";
            this.btnShowFireUnit.UseVisualStyleBackColor = true;
            this.btnShowFireUnit.Click += new System.EventHandler(this.btnShowFireUnit_Click);
            // 
            // Marker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShowDetail);
            this.Controls.Add(this.panelTop);
            this.Name = "Marker";
            this.Size = new System.Drawing.Size(366, 765);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAiport;
        private System.Windows.Forms.Button btnShowCity;
        private System.Windows.Forms.Button btnShowFixedPoint;
        private System.Windows.Forms.Panel panelShowDetail;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnShowVitalAsset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnShowFireUnit;
        private System.Windows.Forms.Button btnShowWeaponBattery;
    }
}
