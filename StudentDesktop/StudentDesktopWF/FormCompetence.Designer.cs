namespace vcz.StudentDesktopWF
{
    partial class FormCompetence
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
            this.dataGridViewCompetence = new System.Windows.Forms.DataGridView();
            this.cCompCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCompName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetence)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompetence
            // 
            this.dataGridViewCompetence.AllowUserToDeleteRows = false;
            this.dataGridViewCompetence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCompetence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCompCode,
            this.cCompName});
            this.dataGridViewCompetence.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewCompetence.Name = "dataGridViewCompetence";
            this.dataGridViewCompetence.Size = new System.Drawing.Size(776, 408);
            this.dataGridViewCompetence.TabIndex = 2;
            this.dataGridViewCompetence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompet_CellContentClick);
            // 
            // cCompCode
            // 
            this.cCompCode.HeaderText = "Код";
            this.cCompCode.Name = "cCompCode";
            // 
            // cCompName
            // 
            this.cCompName.HeaderText = "Наименование";
            this.cCompName.Name = "cCompName";
            // 
            // FormCompetence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCompetence);
            this.Name = "FormCompetence";
            this.Text = "FormCompetence";
            this.Load += new System.EventHandler(this.FormCompetence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompetence;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCompCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCompName;
    }
}