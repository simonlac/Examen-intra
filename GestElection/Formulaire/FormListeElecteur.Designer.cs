namespace GestElection.Formulaire
{
    partial class FormListeElecteur
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
            this.listViewelecteurs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxcirconscript = new System.Windows.Forms.ComboBox();
            this.labelcirconscript = new System.Windows.Forms.Label();
            this.labelnomelec = new System.Windows.Forms.Label();
            this.labeldateelec = new System.Windows.Forms.Label();
            this.lbdenom = new System.Windows.Forms.Label();
            this.labeldedate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewelecteurs
            // 
            this.listViewelecteurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewelecteurs.HideSelection = false;
            this.listViewelecteurs.Location = new System.Drawing.Point(95, 168);
            this.listViewelecteurs.Margin = new System.Windows.Forms.Padding(2);
            this.listViewelecteurs.Name = "listViewelecteurs";
            this.listViewelecteurs.Size = new System.Drawing.Size(583, 271);
            this.listViewelecteurs.TabIndex = 1;
            this.listViewelecteurs.UseCompatibleStateImageBehavior = false;
            this.listViewelecteurs.View = System.Windows.Forms.View.Details;
            this.listViewelecteurs.SelectedIndexChanged += new System.EventHandler(this.listViewEtudiants_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prénom";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Courriel";
            this.columnHeader4.Width = 120;
            // 
            // comboBoxcirconscript
            // 
            this.comboBoxcirconscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxcirconscript.FormattingEnabled = true;
            this.comboBoxcirconscript.Items.AddRange(new object[] {
            "Gatineau",
            "Aylmer",
            "Hull"});
            this.comboBoxcirconscript.Location = new System.Drawing.Point(197, 54);
            this.comboBoxcirconscript.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxcirconscript.Name = "comboBoxcirconscript";
            this.comboBoxcirconscript.Size = new System.Drawing.Size(151, 28);
            this.comboBoxcirconscript.TabIndex = 28;
            // 
            // labelcirconscript
            // 
            this.labelcirconscript.AutoSize = true;
            this.labelcirconscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelcirconscript.Location = new System.Drawing.Point(92, 54);
            this.labelcirconscript.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcirconscript.Name = "labelcirconscript";
            this.labelcirconscript.Size = new System.Drawing.Size(70, 13);
            this.labelcirconscript.TabIndex = 27;
            this.labelcirconscript.Text = "Circonsription";
            // 
            // labelnomelec
            // 
            this.labelnomelec.AutoSize = true;
            this.labelnomelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelnomelec.Location = new System.Drawing.Point(92, 103);
            this.labelnomelec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnomelec.Name = "labelnomelec";
            this.labelnomelec.Size = new System.Drawing.Size(92, 13);
            this.labelnomelec.TabIndex = 29;
            this.labelnomelec.Text = "Nom de L\'élection";
            // 
            // labeldateelec
            // 
            this.labeldateelec.AutoSize = true;
            this.labeldateelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labeldateelec.Location = new System.Drawing.Point(92, 139);
            this.labeldateelec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldateelec.Name = "labeldateelec";
            this.labeldateelec.Size = new System.Drawing.Size(89, 13);
            this.labeldateelec.TabIndex = 30;
            this.labeldateelec.Text = "Date de l\'élection";
            // 
            // lbdenom
            // 
            this.lbdenom.AutoSize = true;
            this.lbdenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbdenom.Location = new System.Drawing.Point(194, 103);
            this.lbdenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdenom.Name = "lbdenom";
            this.lbdenom.Size = new System.Drawing.Size(58, 13);
            this.lbdenom.TabIndex = 31;
            this.lbdenom.Text = "Municipale";
            // 
            // labeldedate
            // 
            this.labeldedate.AutoSize = true;
            this.labeldedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labeldedate.Location = new System.Drawing.Point(194, 139);
            this.labeldedate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldedate.Name = "labeldedate";
            this.labeldedate.Size = new System.Drawing.Size(96, 13);
            this.labeldedate.TabIndex = 32;
            this.labeldedate.Text = "10 novembre 2023";
            // 
            // FormListeElecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeldedate);
            this.Controls.Add(this.lbdenom);
            this.Controls.Add(this.labeldateelec);
            this.Controls.Add(this.labelnomelec);
            this.Controls.Add(this.comboBoxcirconscript);
            this.Controls.Add(this.labelcirconscript);
            this.Controls.Add(this.listViewelecteurs);
            this.Name = "FormListeElecteur";
            this.Text = "Liste des électeurs";
            this.Load += new System.EventHandler(this.FormListeElecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewelecteurs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comboBoxcirconscript;
        private System.Windows.Forms.Label labelcirconscript;
        private System.Windows.Forms.Label labelnomelec;
        private System.Windows.Forms.Label labeldateelec;
        private System.Windows.Forms.Label lbdenom;
        private System.Windows.Forms.Label labeldedate;
    }
}