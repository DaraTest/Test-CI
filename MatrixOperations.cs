using System;
using System.Windows.Forms;

public class MatrixOperations
{
    public static void GenerateMatrix(DataGridView dataGridView, int rows, int columns)
    {
        dataGridView.ColumnCount = columns;
        dataGridView.RowCount = rows;
    }

    public static string ExportMatrixToLatex(DataGridView dataGridView)
    {
        string latexMatrix = "\\begin{pmatrix}\n";
        for (int i = 0; i < dataGridView.RowCount; i++)
        {
            for (int j = 0; j < dataGridView.ColumnCount; j++)
            {
                if (dataGridView[j, i].Value == null || string.IsNullOrWhiteSpace(dataGridView[j, i].Value.ToString()))
                {
                    throw new Exception("Alle Matrixfelder müssen ausgefüllt sein.");
                }

                latexMatrix += dataGridView[j, i].Value.ToString();
                if (j < dataGridView.ColumnCount - 1)
                    latexMatrix += " & ";
            }
            latexMatrix += " \\\\\n";
        }
        latexMatrix += "\\end{pmatrix}";
        return latexMatrix;
    }
}
