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
            this.bCompetenceSave = new System.Windows.Forms.Button();
            this.bCompetenceCancel = new System.Windows.Forms.Button();
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
            this.dataGridViewCompetence.Size = new System.Drawing.Size(769, 422);
            this.dataGridViewCompetence.TabIndex = 2;
            this.dataGridViewCompetence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompet_CellContentClick);
            // 
            // bCompetenceSave
            // 
            this.bCompetenceSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCompetenceSave.Location = new System.Drawing.Point(629, 461);
            this.bCompetenceSave.Name = "bCompetenceSave";
            this.bCompetenceSave.Size = new System.Drawing.Size(75, 23);
            this.bCompetenceSave.TabIndex = 3;
            this.bCompetenceSave.Text = "Сохранить";
            this.bCompetenceSave.UseVisualStyleBackColor = true;
            this.bCompetenceSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCompetenceCancel
            // 
            this.bCompetenceCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCompetenceCancel.Location = new System.Drawing.Point(710, 461);
            this.bCompetenceCancel.Name = "bCompetenceCancel";
            this.bCompetenceCancel.Size = new System.Drawing.Size(74, 23);
            this.bCompetenceCancel.TabIndex = 4;
            this.bCompetenceCancel.Text = "Отменить";
            this.bCompetenceCancel.UseVisualStyleBackColor = true;
            this.bCompetenceCancel.Click += new System.EventHandler(this.bCompetenceCancel_Click);
            // 
            // cCompCode
            // 
            this.cCompCode.HeaderText = "Код";
            this.cCompCode.Name = "cCompCode";
            // 
            // cCompName
            // 
            this.cCompName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCompName.HeaderText = "Наименование";
            this.cCompName.Name = "cCompName";
            this.cCompName.Width = 108;
            // 
            // FormCompetence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 493);
            this.Controls.Add(this.bCompetenceCancel);
            this.Controls.Add(this.bCompetenceSave);
            this.Controls.Add(this.dataGridViewCompetence);
            this.Name = "FormCompetence";
            this.Text = "FormCompetence";
            this.Load += new System.EventHandler(this.FormCompetence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompetence;
        private System.Windows.Forms.Button bCompetenceSave;
        private System.Windows.Forms.Button bCompetenceCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCompCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCompName;
    }
}