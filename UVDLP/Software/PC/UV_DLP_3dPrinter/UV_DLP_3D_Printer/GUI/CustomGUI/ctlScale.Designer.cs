﻿namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlScale
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
            this.manipObject = new System.Windows.Forms.FlowLayoutPanel();
            this.labelManipType = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.textScaleAll = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.ctlImageButton1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textScaleX = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.ctlImageButton3 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textScaleY = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.ctlImageButton5 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.textScaleZ = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.ctlImageButton7 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.manipObject.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // manipObject
            // 
            this.manipObject.BackColor = System.Drawing.Color.Navy;
            this.manipObject.Controls.Add(this.labelManipType);
            this.manipObject.Controls.Add(this.flowLayoutPanel4);
            this.manipObject.Controls.Add(this.flowLayoutPanel1);
            this.manipObject.Controls.Add(this.flowLayoutPanel3);
            this.manipObject.Controls.Add(this.flowLayoutPanel5);
            this.manipObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manipObject.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.manipObject.Location = new System.Drawing.Point(0, 0);
            this.manipObject.Name = "manipObject";
            this.manipObject.Size = new System.Drawing.Size(171, 199);
            this.manipObject.TabIndex = 21;
            // 
            // labelManipType
            // 
            this.labelManipType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelManipType.ForeColor = System.Drawing.Color.White;
            this.labelManipType.Location = new System.Drawing.Point(3, 0);
            this.labelManipType.Name = "labelManipType";
            this.labelManipType.Size = new System.Drawing.Size(161, 31);
            this.labelManipType.TabIndex = 0;
            this.labelManipType.Text = "Scale (%)";
            this.labelManipType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel4.Controls.Add(this.label12);
            this.flowLayoutPanel4.Controls.Add(this.textScaleAll);
            this.flowLayoutPanel4.Controls.Add(this.ctlImageButton1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 34);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(164, 38);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "All";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textScaleAll
            // 
            this.textScaleAll.BackColor = System.Drawing.Color.Navy;
            this.textScaleAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScaleAll.FloatVal = 100F;
            this.textScaleAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textScaleAll.ForeColor = System.Drawing.Color.White;
            this.textScaleAll.IntVal = 100;
            this.textScaleAll.Location = new System.Drawing.Point(56, 5);
            this.textScaleAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textScaleAll.MaxFloat = 1000F;
            this.textScaleAll.MaxInt = 1000;
            this.textScaleAll.MinFloat = 1F;
            this.textScaleAll.MinInt = 1;
            this.textScaleAll.Name = "textScaleAll";
            this.textScaleAll.Size = new System.Drawing.Size(68, 28);
            this.textScaleAll.TabIndex = 4;
            this.textScaleAll.Text = "100";
            this.textScaleAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textScaleAll.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // ctlImageButton1
            // 
            this.ctlImageButton1.BackColor = System.Drawing.Color.Navy;
            this.ctlImageButton1.Gapx = 5;
            this.ctlImageButton1.Gapy = 5;
            this.ctlImageButton1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlImageButton1.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttV;
            this.ctlImageButton1.Location = new System.Drawing.Point(130, 5);
            this.ctlImageButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ctlImageButton1.Name = "ctlImageButton1";
            this.ctlImageButton1.Size = new System.Drawing.Size(28, 28);
            this.ctlImageButton1.TabIndex = 3;
            this.ctlImageButton1.Text = "ctlImageButton7";
            this.ctlImageButton1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textScaleX);
            this.flowLayoutPanel1.Controls.Add(this.ctlImageButton3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 75);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 38);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textScaleX
            // 
            this.textScaleX.BackColor = System.Drawing.Color.Navy;
            this.textScaleX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScaleX.FloatVal = 100F;
            this.textScaleX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textScaleX.ForeColor = System.Drawing.Color.White;
            this.textScaleX.IntVal = 100;
            this.textScaleX.Location = new System.Drawing.Point(56, 5);
            this.textScaleX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textScaleX.MaxFloat = 1000F;
            this.textScaleX.MaxInt = 1000;
            this.textScaleX.MinFloat = 1F;
            this.textScaleX.MinInt = 1;
            this.textScaleX.Name = "textScaleX";
            this.textScaleX.Size = new System.Drawing.Size(68, 28);
            this.textScaleX.TabIndex = 4;
            this.textScaleX.Text = "100";
            this.textScaleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textScaleX.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // ctlImageButton3
            // 
            this.ctlImageButton3.BackColor = System.Drawing.Color.Navy;
            this.ctlImageButton3.Gapx = 5;
            this.ctlImageButton3.Gapy = 5;
            this.ctlImageButton3.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlImageButton3.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttV;
            this.ctlImageButton3.Location = new System.Drawing.Point(130, 5);
            this.ctlImageButton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ctlImageButton3.Name = "ctlImageButton3";
            this.ctlImageButton3.Size = new System.Drawing.Size(28, 28);
            this.ctlImageButton3.TabIndex = 3;
            this.ctlImageButton3.Text = "ctlImageButton3";
            this.ctlImageButton3.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.textScaleY);
            this.flowLayoutPanel3.Controls.Add(this.ctlImageButton5);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 116);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(164, 38);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textScaleY
            // 
            this.textScaleY.BackColor = System.Drawing.Color.Navy;
            this.textScaleY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScaleY.FloatVal = 100F;
            this.textScaleY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textScaleY.ForeColor = System.Drawing.Color.White;
            this.textScaleY.IntVal = 100;
            this.textScaleY.Location = new System.Drawing.Point(56, 5);
            this.textScaleY.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textScaleY.MaxFloat = 1000F;
            this.textScaleY.MaxInt = 1000;
            this.textScaleY.MinFloat = 1F;
            this.textScaleY.MinInt = 1;
            this.textScaleY.Name = "textScaleY";
            this.textScaleY.Size = new System.Drawing.Size(68, 28);
            this.textScaleY.TabIndex = 4;
            this.textScaleY.Text = "100";
            this.textScaleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textScaleY.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // ctlImageButton5
            // 
            this.ctlImageButton5.BackColor = System.Drawing.Color.Navy;
            this.ctlImageButton5.Gapx = 5;
            this.ctlImageButton5.Gapy = 5;
            this.ctlImageButton5.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlImageButton5.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttV;
            this.ctlImageButton5.Location = new System.Drawing.Point(130, 5);
            this.ctlImageButton5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ctlImageButton5.Name = "ctlImageButton5";
            this.ctlImageButton5.Size = new System.Drawing.Size(28, 28);
            this.ctlImageButton5.TabIndex = 3;
            this.ctlImageButton5.Text = "ctlImageButton5";
            this.ctlImageButton5.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel5.Controls.Add(this.label7);
            this.flowLayoutPanel5.Controls.Add(this.textScaleZ);
            this.flowLayoutPanel5.Controls.Add(this.ctlImageButton7);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 157);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(164, 38);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Z";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textScaleZ
            // 
            this.textScaleZ.BackColor = System.Drawing.Color.Navy;
            this.textScaleZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textScaleZ.FloatVal = 100F;
            this.textScaleZ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textScaleZ.ForeColor = System.Drawing.Color.White;
            this.textScaleZ.IntVal = 100;
            this.textScaleZ.Location = new System.Drawing.Point(56, 5);
            this.textScaleZ.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textScaleZ.MaxFloat = 1000F;
            this.textScaleZ.MaxInt = 1000;
            this.textScaleZ.MinFloat = 1F;
            this.textScaleZ.MinInt = 1;
            this.textScaleZ.Name = "textScaleZ";
            this.textScaleZ.Size = new System.Drawing.Size(68, 28);
            this.textScaleZ.TabIndex = 4;
            this.textScaleZ.Text = "100";
            this.textScaleZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textScaleZ.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // ctlImageButton7
            // 
            this.ctlImageButton7.BackColor = System.Drawing.Color.Navy;
            this.ctlImageButton7.Gapx = 5;
            this.ctlImageButton7.Gapy = 5;
            this.ctlImageButton7.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlImageButton7.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttV;
            this.ctlImageButton7.Location = new System.Drawing.Point(130, 5);
            this.ctlImageButton7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ctlImageButton7.Name = "ctlImageButton7";
            this.ctlImageButton7.Size = new System.Drawing.Size(28, 28);
            this.ctlImageButton7.TabIndex = 3;
            this.ctlImageButton7.Text = "ctlImageButton7";
            this.ctlImageButton7.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // ctlScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manipObject);
            this.Name = "ctlScale";
            this.Size = new System.Drawing.Size(171, 199);
            this.manipObject.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel manipObject;
        private System.Windows.Forms.Label labelManipType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label12;
        private ctlTextBox textScaleAll;
        private ctlImageButton ctlImageButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private ctlImageButton ctlImageButton3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private ctlImageButton ctlImageButton5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private ctlTextBox textScaleZ;
        private ctlImageButton ctlImageButton7;
        private ctlTextBox textScaleX;
        private ctlTextBox textScaleY;

    }
}
