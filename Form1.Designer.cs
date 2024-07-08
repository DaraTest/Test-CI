namespace MatrixToLaTeXExporter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        private void InitializeComponent()
        {
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.numZeilen = new System.Windows.Forms.Label();
            this.numSplaten = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxFormula = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonExportFormula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutPutAnzeige = new System.Windows.Forms.Label();
            this.Formula = new System.Windows.Forms.Label();

            // Neue Steuerelemente für quadratische Gleichung
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.buttonSolveQuadratic = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(675, 243);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(868, 32);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(135, 22);
            this.textBoxRows.TabIndex = 1;
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(868, 84);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(135, 22);
            this.textBoxColumns.TabIndex = 2;
            // 
            // numZeilen
            // 
            this.numZeilen.AutoSize = true;
            this.numZeilen.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numZeilen.Location = new System.Drawing.Point(739, 33);
            this.numZeilen.Name = "numZeilen";
            this.numZeilen.Size = new System.Drawing.Size(102, 19);
            this.numZeilen.TabIndex = 3;
            this.numZeilen.Text = "Zeilen Anzahl:";
            // 
            // numSplaten
            // 
            this.numSplaten.AutoSize = true;
            this.numSplaten.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSplaten.Location = new System.Drawing.Point(739, 84);
            this.numSplaten.Name = "numSplaten";
            this.numSplaten.Size = new System.Drawing.Size(112, 19);
            this.numSplaten.TabIndex = 4;
            this.numSplaten.Text = "Spalten Anzahl:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 324);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(456, 261);
            this.textBoxOutput.TabIndex = 5;
            // 
            // textBoxFormula
            // 
            this.textBoxFormula.Location = new System.Drawing.Point(726, 433);
            this.textBoxFormula.Multiline = true;
            this.textBoxFormula.Name = "textBoxFormula";
            this.textBoxFormula.Size = new System.Drawing.Size(258, 141);
            this.textBoxFormula.TabIndex = 6;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(743, 177);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(98, 36);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Generieren ";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(886, 177);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(98, 36);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Text = "Expotrieren";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonExportFormula
            // 
            this.buttonExportFormula.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportFormula.Location = new System.Drawing.Point(799, 298);
            this.buttonExportFormula.Name = "buttonExportFormula";
            this.buttonExportFormula.Size = new System.Drawing.Size(141, 73);
            this.buttonExportFormula.TabIndex = 9;
            this.buttonExportFormula.Text = "Export Formula";
            this.buttonExportFormula.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Matrix Eingabe:";
            // 
            // OutPutAnzeige
            // 
            this.OutPutAnzeige.AutoSize = true;
            this.OutPutAnzeige.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutAnzeige.Location = new System.Drawing.Point(13, 302);
            this.OutPutAnzeige.Name = "OutPutAnzeige";
            this.OutPutAnzeige.Size = new System.Drawing.Size(71, 19);
            this.OutPutAnzeige.TabIndex = 11;
            this.OutPutAnzeige.Text = "Ausgabe:";
            // 
            // Formula
            // 
            this.Formula.AutoSize = true;
            this.Formula.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formula.Location = new System.Drawing.Point(729, 400);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(125, 19);
            this.Formula.TabIndex = 12;
            this.Formula.Text = "Formula Eingabe:";

            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(868, 150);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(135, 22);
            this.textBoxA.TabIndex = 13;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(868, 180);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(135, 22);
            this.textBoxB.TabIndex = 14;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(868, 210);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(135, 22);
            this.textBoxC.TabIndex = 15;
            // 
            // buttonSolveQuadratic
            // 
            this.buttonSolveQuadratic.Location = new System.Drawing.Point(868, 240);
            this.buttonSolveQuadratic.Name = "buttonSolveQuadratic";
            this.buttonSolveQuadratic.Size = new System.Drawing.Size(135, 23);
            this.buttonSolveQuadratic.TabIndex = 16;
            this.buttonSolveQuadratic.Text = "Quadratische Lösen";
            this.buttonSolveQuadratic.UseVisualStyleBackColor = true;
            this.buttonSolveQuadratic.Click += new System.EventHandler(this.buttonSolveQuadratic_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(739, 150);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(68, 17);
            this.labelA.TabIndex = 17;
            this.labelA.Text = "Wert für a:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(739, 180);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(68, 17);
            this.labelB.TabIndex = 18;
            this.labelB.Text = "Wert für b:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(739, 210);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(68, 17);
            this.labelC.TabIndex = 19;
            this.labelC.Text = "Wert für c:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 646);
            this.Controls.Add(this.Formula);
            this.Controls.Add(this.OutPutAnzeige);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExportFormula);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxFormula);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.numSplaten);
            this.Controls.Add(this.numZeilen);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.textBoxRows);

            // Neue Steuerelemente hinzufügen
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.buttonSolveQuadratic);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelC);

            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label numZeilen;
        private System.Windows.Forms.Label numSplaten;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxFormula;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonExportFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutPutAnzeige;
        private System.Windows.Forms.Label Formula;

        // Neue Steuerelemente für quadratische Gleichung
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button buttonSolveQuadratic;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
    }
}
