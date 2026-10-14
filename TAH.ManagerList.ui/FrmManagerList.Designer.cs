namespace TAH.ManagerList.ui
{
    partial class FrmManagerList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDepartment = new TextBox();
            lblResult = new Label();
            lblDepartment = new Label();
            lblManager = new Label();
            btnFind = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtDepartment
            // 
            txtDepartment.AcceptsTab = true;
            txtDepartment.Font = new Font("Segoe UI", 11F);
            txtDepartment.Location = new Point(54, 80);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(254, 27);
            txtDepartment.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.Popup;
            lblResult.Font = new Font("Segoe UI", 11F);
            lblResult.Location = new Point(54, 208);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(254, 44);
            lblResult.TabIndex = 1;
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 11F);
            lblDepartment.Location = new Point(54, 50);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(92, 20);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department:";
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new Font("Segoe UI", 11F);
            lblManager.Location = new Point(54, 179);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(71, 20);
            lblManager.TabIndex = 3;
            lblManager.Text = "Manager:";
            // 
            // btnFind
            // 
            btnFind.FlatStyle = FlatStyle.System;
            btnFind.Font = new Font("Segoe UI", 16F);
            btnFind.Location = new Point(44, 339);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(117, 55);
            btnFind.TabIndex = 4;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.System;
            btnExit.Font = new Font("Segoe UI", 16F);
            btnExit.Location = new Point(201, 339);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 55);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FrmManagerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 450);
            Controls.Add(btnExit);
            Controls.Add(btnFind);
            Controls.Add(lblManager);
            Controls.Add(lblDepartment);
            Controls.Add(lblResult);
            Controls.Add(txtDepartment);
            Name = "FrmManagerList";
            Text = "Manager Finder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDepartment;
        private Label lblResult;
        private Label lblDepartment;
        private Label lblManager;
        private Button btnFind;
        private Button btnExit;
    }
}
