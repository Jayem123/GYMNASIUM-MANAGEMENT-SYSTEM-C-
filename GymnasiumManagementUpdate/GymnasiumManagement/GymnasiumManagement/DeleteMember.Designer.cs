
namespace GymnasiumManagement
{
    partial class DeleteMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMember));
            this.button3 = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(247, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 80);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Enter
            // 
            this.Enter.AutoSize = true;
            this.Enter.Location = new System.Drawing.Point(133, 160);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(48, 15);
            this.Enter.TabIndex = 21;
            this.Enter.Text = "Enter ID";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(215, 160);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(211, 23);
            this.txtDelete.TabIndex = 22;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Brown;
            this.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(260, 204);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(568, 196);
            this.dataGridView1.TabIndex = 24;
            // 
            // DeleteMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.button3);
            this.Name = "DeleteMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteMember";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Enter;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}