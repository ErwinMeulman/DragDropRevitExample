namespace DragDropRevitExample
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this._listViewTestFamilies = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // _listViewTestFamilies
            // 
            this._listViewTestFamilies.AllowDrop = true;
            this._listViewTestFamilies.FullRowSelect = true;
            this._listViewTestFamilies.GridLines = true;
            this._listViewTestFamilies.Location = new System.Drawing.Point(77, 35);
            this._listViewTestFamilies.Name = "_listViewTestFamilies";
            this._listViewTestFamilies.Size = new System.Drawing.Size(121, 97);
            this._listViewTestFamilies.TabIndex = 0;
            this._listViewTestFamilies.UseCompatibleStateImageBehavior = false;
            this._listViewTestFamilies.View = System.Windows.Forms.View.List;
            this._listViewTestFamilies.MouseDown += new System.Windows.Forms.MouseEventHandler(this._listViewTestFamilies_MouseDown);
            this._listViewTestFamilies.MouseMove += new System.Windows.Forms.MouseEventHandler(this._listViewTestFamilies_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this._listViewTestFamilies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _listViewTestFamilies;
    }
}

