namespace GestElection
{
    partial class FormElection
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
            this.comboBoxnom = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DElec = new System.Windows.Forms.DateTimePicker();
            this.nom_lb = new System.Windows.Forms.Label();
            this.buttonCrée = new System.Windows.Forms.Button();
            this.label_gestion_elec = new System.Windows.Forms.Label();
            this.date_elec_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxnom
            // 
            this.comboBoxnom.FormattingEnabled = true;
            this.comboBoxnom.Items.AddRange(new object[] {
            "Municipale ",
            "Provincial ",
            "Fédéral"});
            this.comboBoxnom.Location = new System.Drawing.Point(375, 152);
            this.comboBoxnom.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxnom.Name = "comboBoxnom";
            this.comboBoxnom.Size = new System.Drawing.Size(151, 21);
            this.comboBoxnom.TabIndex = 24;
            this.comboBoxnom.SelectedIndexChanged += new System.EventHandler(this.comboBoxProgramme_SelectedIndexChanged);
            // 
            // dateTimePicker_DElec
            // 
            this.dateTimePicker_DElec.Location = new System.Drawing.Point(375, 219);
            this.dateTimePicker_DElec.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_DElec.Name = "dateTimePicker_DElec";
            this.dateTimePicker_DElec.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker_DElec.TabIndex = 23;
            this.dateTimePicker_DElec.ValueChanged += new System.EventHandler(this.dateTimePicker_DN_ValueChanged);
            // 
            // nom_lb
            // 
            this.nom_lb.AutoSize = true;
            this.nom_lb.Location = new System.Drawing.Point(270, 152);
            this.nom_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nom_lb.Name = "nom_lb";
            this.nom_lb.Size = new System.Drawing.Size(27, 13);
            this.nom_lb.TabIndex = 22;
            this.nom_lb.Text = "nom";
            // 
            // buttonCrée
            // 
            this.buttonCrée.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrée.Location = new System.Drawing.Point(344, 296);
            this.buttonCrée.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCrée.Name = "buttonCrée";
            this.buttonCrée.Size = new System.Drawing.Size(142, 40);
            this.buttonCrée.TabIndex = 21;
            this.buttonCrée.Text = "Créer";
            this.buttonCrée.UseVisualStyleBackColor = true;
            // 
            // label_gestion_elec
            // 
            this.label_gestion_elec.AutoSize = true;
            this.label_gestion_elec.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label_gestion_elec.ForeColor = System.Drawing.Color.Red;
            this.label_gestion_elec.Location = new System.Drawing.Point(266, 25);
            this.label_gestion_elec.Name = "label_gestion_elec";
            this.label_gestion_elec.Size = new System.Drawing.Size(342, 39);
            this.label_gestion_elec.TabIndex = 26;
            this.label_gestion_elec.Text = "Gestion des élections";
            // 
            // date_elec_lb
            // 
            this.date_elec_lb.AutoSize = true;
            this.date_elec_lb.Location = new System.Drawing.Point(270, 219);
            this.date_elec_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_elec_lb.Name = "date_elec_lb";
            this.date_elec_lb.Size = new System.Drawing.Size(78, 13);
            this.date_elec_lb.TabIndex = 27;
            this.date_elec_lb.Text = "Date d\'élection";
            this.date_elec_lb.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date_elec_lb);
            this.Controls.Add(this.label_gestion_elec);
            this.Controls.Add(this.comboBoxnom);
            this.Controls.Add(this.dateTimePicker_DElec);
            this.Controls.Add(this.nom_lb);
            this.Controls.Add(this.buttonCrée);
            this.Name = "FormElection";
            this.Text = "Élection";
            this.Load += new System.EventHandler(this.FormElection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxnom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DElec;
        private System.Windows.Forms.Label nom_lb;
        private System.Windows.Forms.Button buttonCrée;
        private System.Windows.Forms.Label label_gestion_elec;
        private System.Windows.Forms.Label date_elec_lb;
    }
}