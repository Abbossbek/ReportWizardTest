
namespace ReportWizardTest
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
            this.resourcesComboBoxControl1 = new DevExpress.XtraEditors.ButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesComboBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // resourcesComboBoxControl1
            // 
            this.resourcesComboBoxControl1.EditValue = "Choose JSON file";
            this.resourcesComboBoxControl1.Location = new System.Drawing.Point(73, 132);
            this.resourcesComboBoxControl1.Name = "resourcesComboBoxControl1";
            this.resourcesComboBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.resourcesComboBoxControl1.Size = new System.Drawing.Size(461, 22);
            this.resourcesComboBoxControl1.TabIndex = 0;
            this.resourcesComboBoxControl1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.resourcesComboBoxControl1_ButtonClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(224, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(141, 49);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Meke PRNX";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.EditValue = "Choose REPX file";
            this.buttonEdit1.Location = new System.Drawing.Point(73, 71);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(461, 22);
            this.buttonEdit1.TabIndex = 2;
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 293);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.resourcesComboBoxControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRNX maker";
            ((System.ComponentModel.ISupportInitialize)(this.resourcesComboBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit resourcesComboBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
    }
}

