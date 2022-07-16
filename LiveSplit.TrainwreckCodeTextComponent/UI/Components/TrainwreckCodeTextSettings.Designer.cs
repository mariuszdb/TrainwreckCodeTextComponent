
using LiveSplit.UI;
using System.Xml;

namespace LiveSplit.TrainwreckCodeTextComponent.UI.Components
{
    partial class TrainwreckCodeTextSettings
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
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveFileLocationTextBox = new System.Windows.Forms.TextBox();
            this.topTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.AutoScroll = true;
            this.topTableLayoutPanel.ColumnCount = 1;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.Controls.Add(this.saveFileLocationTextBox, 0, 0);
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.topTableLayoutPanel.TabIndex = 0;
            this.topTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topTableLayoutPanel_Paint);
            // 
            // saveFileLocationTextBox
            // 
            this.saveFileLocationTextBox.Location = new System.Drawing.Point(3, 3);
            this.saveFileLocationTextBox.Name = "saveFileLocationTextBox";
            this.saveFileLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.saveFileLocationTextBox.TabIndex = 0;
            this.saveFileLocationTextBox.TextChanged += new System.EventHandler(this.saveFileLocationTextBox_TextChanged);
            // 
            // TrainwreckCodeTextSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.topTableLayoutPanel);
            this.Size = new System.Drawing.Size(203, 150);
            this.Load += new System.EventHandler(this.TrainwreckCodeTextSettings_Load);
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.TextBox saveFileLocationTextBox;
    }
}
