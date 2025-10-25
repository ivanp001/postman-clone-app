namespace PostmanCloneUI
{
    partial class Dashboard
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
            Label formHeader;
            apiLabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            resultsText = new TextBox();
            resultsLabel = new Label();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            formHeader = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(55, 18);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(152, 30);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(55, 69);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(36, 21);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiText
            // 
            apiText.BackColor = Color.White;
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(97, 66);
            apiText.Name = "apiText";
            apiText.Size = new Size(731, 29);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(845, 66);
            callApi.Name = "callApi";
            callApi.Size = new Size(45, 29);
            callApi.TabIndex = 3;
            callApi.Text = "GO";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Location = new Point(55, 142);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(835, 307);
            resultsText.TabIndex = 4;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(55, 107);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(60, 21);
            resultsLabel.TabIndex = 5;
            resultsLabel.Text = "Results";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 469);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(949, 22);
            statusStrip.TabIndex = 6;
            statusStrip.Text = "System Status";
            statusStrip.BackColor = Color.White;
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(38, 17);
            systemStatus.Text = "Ready";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(949, 491);
            Controls.Add(statusStrip);
            Controls.Add(resultsLabel);
            Controls.Add(resultsText);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Dashboard";
            Text = "Postman Clone Ivan";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private TextBox resultsText;
        private Label resultsLabel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
    }
}
