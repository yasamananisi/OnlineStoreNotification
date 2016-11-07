namespace Publisher
{
    partial class PublisherForm
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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.tmrEvent = new System.Windows.Forms.Timer(this.components);
			this.txtEventCount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEventData = new System.Windows.Forms.TextBox();
			this.txtTopicName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(125, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(225, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Send Message";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.SendEvent);
			// 
			// tmrEvent
			// 
			this.tmrEvent.Tick += new System.EventHandler(this.tmrEvent_Tick);
			// 
			// txtEventCount
			// 
			this.txtEventCount.Location = new System.Drawing.Point(309, 240);
			this.txtEventCount.Name = "txtEventCount";
			this.txtEventCount.Size = new System.Drawing.Size(41, 20);
			this.txtEventCount.TabIndex = 6;
			this.txtEventCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(147, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Total Events  Fired :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(118, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 43;
			this.label4.Text = "Information";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(118, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 42;
			this.label5.Text = "Product Name";
			// 
			// txtEventData
			// 
			this.txtEventData.Location = new System.Drawing.Point(203, 91);
			this.txtEventData.Multiline = true;
			this.txtEventData.Name = "txtEventData";
			this.txtEventData.Size = new System.Drawing.Size(147, 82);
			this.txtEventData.TabIndex = 41;
			// 
			// txtTopicName
			// 
			this.txtTopicName.Location = new System.Drawing.Point(203, 49);
			this.txtTopicName.Name = "txtTopicName";
			this.txtTopicName.Size = new System.Drawing.Size(84, 20);
			this.txtTopicName.TabIndex = 40;
			// 
			// PublisherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 284);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtEventData);
			this.Controls.Add(this.txtTopicName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEventCount);
			this.Controls.Add(this.button1);
			this.Name = "PublisherForm";
			this.Text = "Store";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrEvent;
        private System.Windows.Forms.TextBox txtEventCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEventData;
        private System.Windows.Forms.TextBox txtTopicName;
    }
}