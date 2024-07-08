using System;
using System.Windows.Forms;

namespace MatrixToLaTeXExporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridViewMatrix.AllowUserToAddRows = false; // Verhindert das automatische Hinzufügen neuer Zeilen
            dataGridViewMatrix.CellEndEdit += DataGridViewMatrix_CellEndEdit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event-Handler für die Buttons hinzufügen
            buttonGenerate.Click += buttonGenerate_Click;
            buttonExport.Click += buttonExport_Click;
            buttonExportFormula.Click += buttonExportFormula_Click;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRows.Text, out int rows) && rows > 0 &&
                int.TryParse(textBoxColumns.Text, out int columns) && columns > 0)
            {
                MatrixOperations.GenerateMatrix(dataGridViewMatrix, rows, columns);
            }
            else
            {
                MessageBox.Show("Bitte geben Sie gültige Zahlen für Zeilen und Spalten ein.");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                string latexMatrix = MatrixOperations.ExportMatrixToLatex(dataGridViewMatrix);
                textBoxOutput.Text = latexMatrix;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}");
            }
        }

        private void buttonExportFormula_Click(object sender, EventArgs e)
        {
            try
            {
                string formula = textBoxFormula.Text;
                string latexFormula = FormulaOperations.ExportFormulaToLatex(formula);
                textBoxOutput.Text = latexFormula;

                // Optional: Symbolische Darstellung anzeigen
                string symbolicFormula = FormulaOperations.ConvertLatexToSymbolic(latexFormula);
                MessageBox.Show($"Symbolische Darstellung: {symbolicFormula}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}");
            }
        }

        private void DataGridViewMatrix_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMatrix.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void buttonSolveQuadratic_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);
                string solution = FormulaOperations.SolveQuadraticEquation(a, b, c);
                MessageBox.Show($"Lösung der quadratischen Gleichung: {solution}");

                string latexEquation = FormulaOperations.ConvertQuadraticEquationToLatex(a, b, c);
                textBoxOutput.Text = latexEquation;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}");
            }
        }

    }
}
