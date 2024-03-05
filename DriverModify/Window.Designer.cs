using System.Management;

namespace DriverModify
{
    partial class Window
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.DeviceID = new System.Windows.Forms.TextBox();
            this.Device = new System.Windows.Forms.ComboBox();
            this.VideoAdapterConfig = new System.Windows.Forms.ComboBox();
            this.FileConfig = new System.Windows.Forms.OpenFileDialog();
            this.DiveceID_Label = new System.Windows.Forms.Label();
            this.VideoAdapter_Label = new System.Windows.Forms.Label();
            this.VideoAdapterConfig_Label = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeviceID
            // 
            this.DeviceID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceID.Location = new System.Drawing.Point(12, 25);
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.ReadOnly = true;
            this.DeviceID.Size = new System.Drawing.Size(310, 20);
            this.DeviceID.TabIndex = 0;
            // 
            // Device
            // 
            this.Device.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Device.BackColor = System.Drawing.SystemColors.Window;
            this.Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Device.FormattingEnabled = true;
            this.Device.Location = new System.Drawing.Point(12, 74);
            this.Device.Name = "Device";
            this.Device.Size = new System.Drawing.Size(310, 21);
            this.Device.TabIndex = 2;
            this.Device.SelectedValueChanged += new System.EventHandler(this.Device_SelectedValueChanged);
            // 
            // VideoAdapterConfig
            // 
            this.VideoAdapterConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoAdapterConfig.BackColor = System.Drawing.SystemColors.Window;
            this.VideoAdapterConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VideoAdapterConfig.FormattingEnabled = true;
            this.VideoAdapterConfig.Location = new System.Drawing.Point(12, 126);
            this.VideoAdapterConfig.Name = "VideoAdapterConfig";
            this.VideoAdapterConfig.Size = new System.Drawing.Size(310, 21);
            this.VideoAdapterConfig.TabIndex = 7;
            // 
            // FileConfig
            // 
            this.FileConfig.FileName = "nvdmig.inf";
            // 
            // DiveceID_Label
            // 
            this.DiveceID_Label.AutoSize = true;
            this.DiveceID_Label.Location = new System.Drawing.Point(12, 9);
            this.DiveceID_Label.Name = "DiveceID_Label";
            this.DiveceID_Label.Size = new System.Drawing.Size(58, 13);
            this.DiveceID_Label.TabIndex = 3;
            this.DiveceID_Label.Text = "Device ID:";
            // 
            // VideoAdapter_Label
            // 
            this.VideoAdapter_Label.AutoSize = true;
            this.VideoAdapter_Label.Location = new System.Drawing.Point(9, 58);
            this.VideoAdapter_Label.Name = "VideoAdapter_Label";
            this.VideoAdapter_Label.Size = new System.Drawing.Size(128, 13);
            this.VideoAdapter_Label.TabIndex = 4;
            this.VideoAdapter_Label.Text = "Select your videoadapter:";
            // 
            // VideoAdapterConfig_Label
            // 
            this.VideoAdapterConfig_Label.AutoSize = true;
            this.VideoAdapterConfig_Label.Location = new System.Drawing.Point(9, 110);
            this.VideoAdapterConfig_Label.Name = "VideoAdapterConfig_Label";
            this.VideoAdapterConfig_Label.Size = new System.Drawing.Size(135, 13);
            this.VideoAdapterConfig_Label.TabIndex = 9;
            this.VideoAdapterConfig_Label.Text = "Select videocard to modify:";
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button.Location = new System.Drawing.Point(101, 175);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(138, 36);
            this.Button.TabIndex = 10;
            this.Button.Text = "Modify";
            this.Button.UseMnemonic = false;
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(334, 226);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.VideoAdapterConfig_Label);
            this.Controls.Add(this.VideoAdapterConfig);
            this.Controls.Add(this.VideoAdapter_Label);
            this.Controls.Add(this.DiveceID_Label);
            this.Controls.Add(this.Device);
            this.Controls.Add(this.DeviceID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverModify";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.TextBox DeviceID;
        private System.Windows.Forms.ComboBox Device;
        private System.Windows.Forms.ComboBox VideoAdapterConfig;
        private System.Windows.Forms.OpenFileDialog FileConfig;

        private System.Windows.Forms.Label DiveceID_Label;
        private System.Windows.Forms.Label VideoAdapter_Label;
        private System.Windows.Forms.Label VideoAdapterConfig_Label;
        private System.Windows.Forms.Button Button;
    }
}

