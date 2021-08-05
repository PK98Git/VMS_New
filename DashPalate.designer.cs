
namespace VMS.Forms
{
    partial class DashPalate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashPalate));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.VcNextBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is dashplate";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // VcNextBTN
            // 
            this.VcNextBTN.AllowToggling = false;
            this.VcNextBTN.AnimationSpeed = 200;
            this.VcNextBTN.AutoGenerateColors = false;
            this.VcNextBTN.BackColor = System.Drawing.Color.Transparent;
            this.VcNextBTN.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.VcNextBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VcNextBTN.BackgroundImage")));
            this.VcNextBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.VcNextBTN.ButtonText = "Vaccinate Next";
            this.VcNextBTN.ButtonTextMarginLeft = 0;
            this.VcNextBTN.ColorContrastOnClick = 45;
            this.VcNextBTN.ColorContrastOnHover = 45;
            this.VcNextBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.VcNextBTN.CustomizableEdges = borderEdges1;
            this.VcNextBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.VcNextBTN.DisabledBorderColor = System.Drawing.Color.Empty;
            this.VcNextBTN.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.VcNextBTN.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.VcNextBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.VcNextBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.VcNextBTN.ForeColor = System.Drawing.Color.White;
            this.VcNextBTN.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.VcNextBTN.IconMarginLeft = 11;
            this.VcNextBTN.IconPadding = 10;
            this.VcNextBTN.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.VcNextBTN.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.VcNextBTN.IdleBorderRadius = 3;
            this.VcNextBTN.IdleBorderThickness = 1;
            this.VcNextBTN.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.VcNextBTN.IdleIconLeftImage = null;
            this.VcNextBTN.IdleIconRightImage = null;
            this.VcNextBTN.IndicateFocus = false;
            this.VcNextBTN.Location = new System.Drawing.Point(884, 39);
            this.VcNextBTN.Name = "VcNextBTN";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.VcNextBTN.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.VcNextBTN.OnPressedState = stateProperties2;
            this.VcNextBTN.Size = new System.Drawing.Size(120, 37);
            this.VcNextBTN.TabIndex = 2;
            this.VcNextBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VcNextBTN.TextMarginLeft = 0;
            this.VcNextBTN.UseDefaultRadiusAndThickness = true;
            this.VcNextBTN.Click += new System.EventHandler(this.VcNextBTN_Click);
            // 
            // DashPalate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 640);
            this.Controls.Add(this.VcNextBTN);
            this.Controls.Add(this.label1);
            this.Name = "DashPalate";
            this.Text = "DashPalate";
            this.Load += new System.EventHandler(this.DashPalate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton VcNextBTN;
    }
}