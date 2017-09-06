namespace BreakingNews
{
    partial class FormMain
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
            this.rbAfonbladet = new System.Windows.Forms.RadioButton();
            this.rbExpressen = new System.Windows.Forms.RadioButton();
            this.rbDagensNyheter = new System.Windows.Forms.RadioButton();
            this.rbTrump = new System.Windows.Forms.RadioButton();
            this.rbEkonomi = new System.Windows.Forms.RadioButton();
            this.rbPolis = new System.Windows.Forms.RadioButton();
            this.rbHemlig = new System.Windows.Forms.RadioButton();
            this.gbKeyword = new System.Windows.Forms.GroupBox();
            this.gbSite = new System.Windows.Forms.GroupBox();
            this.btnGetStatistics = new System.Windows.Forms.Button();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.gbKeyword.SuspendLayout();
            this.gbSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAfonbladet
            // 
            this.rbAfonbladet.AutoSize = true;
            this.rbAfonbladet.Checked = true;
            this.rbAfonbladet.Location = new System.Drawing.Point(6, 14);
            this.rbAfonbladet.Name = "rbAfonbladet";
            this.rbAfonbladet.Size = new System.Drawing.Size(79, 17);
            this.rbAfonbladet.TabIndex = 1;
            this.rbAfonbladet.TabStop = true;
            this.rbAfonbladet.Text = "Aftonbladet";
            this.rbAfonbladet.UseVisualStyleBackColor = true;
            // 
            // rbExpressen
            // 
            this.rbExpressen.AutoSize = true;
            this.rbExpressen.Location = new System.Drawing.Point(6, 37);
            this.rbExpressen.Name = "rbExpressen";
            this.rbExpressen.Size = new System.Drawing.Size(74, 17);
            this.rbExpressen.TabIndex = 2;
            this.rbExpressen.TabStop = true;
            this.rbExpressen.Text = "Expressen";
            this.rbExpressen.UseVisualStyleBackColor = true;
            // 
            // rbDagensNyheter
            // 
            this.rbDagensNyheter.AutoSize = true;
            this.rbDagensNyheter.Location = new System.Drawing.Point(6, 60);
            this.rbDagensNyheter.Name = "rbDagensNyheter";
            this.rbDagensNyheter.Size = new System.Drawing.Size(102, 17);
            this.rbDagensNyheter.TabIndex = 3;
            this.rbDagensNyheter.TabStop = true;
            this.rbDagensNyheter.Text = "Dagens Nyheter";
            this.rbDagensNyheter.UseVisualStyleBackColor = true;
            // 
            // rbTrump
            // 
            this.rbTrump.AutoSize = true;
            this.rbTrump.Checked = true;
            this.rbTrump.Location = new System.Drawing.Point(6, 19);
            this.rbTrump.Name = "rbTrump";
            this.rbTrump.Size = new System.Drawing.Size(55, 17);
            this.rbTrump.TabIndex = 0;
            this.rbTrump.TabStop = true;
            this.rbTrump.Text = "Trump";
            this.rbTrump.UseVisualStyleBackColor = true;
            // 
            // rbEkonomi
            // 
            this.rbEkonomi.AutoSize = true;
            this.rbEkonomi.Location = new System.Drawing.Point(6, 42);
            this.rbEkonomi.Name = "rbEkonomi";
            this.rbEkonomi.Size = new System.Drawing.Size(66, 17);
            this.rbEkonomi.TabIndex = 1;
            this.rbEkonomi.TabStop = true;
            this.rbEkonomi.Text = "Ekonomi";
            this.rbEkonomi.UseVisualStyleBackColor = true;
            // 
            // rbPolis
            // 
            this.rbPolis.AutoSize = true;
            this.rbPolis.Location = new System.Drawing.Point(6, 65);
            this.rbPolis.Name = "rbPolis";
            this.rbPolis.Size = new System.Drawing.Size(47, 17);
            this.rbPolis.TabIndex = 2;
            this.rbPolis.TabStop = true;
            this.rbPolis.Text = "Polis";
            this.rbPolis.UseVisualStyleBackColor = true;
            // 
            // rbHemlig
            // 
            this.rbHemlig.AutoSize = true;
            this.rbHemlig.Location = new System.Drawing.Point(6, 88);
            this.rbHemlig.Name = "rbHemlig";
            this.rbHemlig.Size = new System.Drawing.Size(57, 17);
            this.rbHemlig.TabIndex = 3;
            this.rbHemlig.TabStop = true;
            this.rbHemlig.Text = "Hemlig";
            this.rbHemlig.UseVisualStyleBackColor = true;
            // 
            // gbKeyword
            // 
            this.gbKeyword.Controls.Add(this.rbTrump);
            this.gbKeyword.Controls.Add(this.rbHemlig);
            this.gbKeyword.Controls.Add(this.rbEkonomi);
            this.gbKeyword.Controls.Add(this.rbPolis);
            this.gbKeyword.Location = new System.Drawing.Point(12, 27);
            this.gbKeyword.Name = "gbKeyword";
            this.gbKeyword.Size = new System.Drawing.Size(154, 135);
            this.gbKeyword.TabIndex = 4;
            this.gbKeyword.TabStop = false;
            this.gbKeyword.Text = "Keyword selection";
            // 
            // gbSite
            // 
            this.gbSite.Controls.Add(this.rbAfonbladet);
            this.gbSite.Controls.Add(this.rbDagensNyheter);
            this.gbSite.Controls.Add(this.rbExpressen);
            this.gbSite.Location = new System.Drawing.Point(172, 27);
            this.gbSite.Name = "gbSite";
            this.gbSite.Size = new System.Drawing.Size(155, 135);
            this.gbSite.TabIndex = 5;
            this.gbSite.TabStop = false;
            this.gbSite.Text = "Site selection";
            // 
            // btnGetStatistics
            // 
            this.btnGetStatistics.Location = new System.Drawing.Point(9, 168);
            this.btnGetStatistics.Name = "btnGetStatistics";
            this.btnGetStatistics.Size = new System.Drawing.Size(318, 23);
            this.btnGetStatistics.TabIndex = 6;
            this.btnGetStatistics.Text = "Get statistics";
            this.btnGetStatistics.UseVisualStyleBackColor = true;
            this.btnGetStatistics.Click += new System.EventHandler(this.btnGetStatistics_Click);
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Location = new System.Drawing.Point(152, 194);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(37, 13);
            this.lblResultTitle.TabIndex = 7;
            this.lblResultTitle.Text = "Result";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(121, 210);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 20);
            this.tbResult.TabIndex = 8;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 242);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.btnGetStatistics);
            this.Controls.Add(this.gbSite);
            this.Controls.Add(this.gbKeyword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Breaking News";
            this.gbKeyword.ResumeLayout(false);
            this.gbKeyword.PerformLayout();
            this.gbSite.ResumeLayout(false);
            this.gbSite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbDagensNyheter;
        private System.Windows.Forms.RadioButton rbExpressen;
        private System.Windows.Forms.RadioButton rbAfonbladet;
        private System.Windows.Forms.RadioButton rbTrump;
        private System.Windows.Forms.RadioButton rbEkonomi;
        private System.Windows.Forms.RadioButton rbPolis;
        private System.Windows.Forms.RadioButton rbHemlig;
        private System.Windows.Forms.GroupBox gbKeyword;
        private System.Windows.Forms.GroupBox gbSite;
        private System.Windows.Forms.Button btnGetStatistics;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.TextBox tbResult;
    }
}

