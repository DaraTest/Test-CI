using System;
using System.Text.RegularExpressions;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;

public class FormulaOperations
{
    public static bool ValidateFormula(string formula)
    {
        var validChars = new Regex(@"^[0-9a-zA-Z+\-*/(){}^_\\ ]+$");
        return validChars.IsMatch(formula);
    }

    public static string ExportFormulaToLatex(string formula)
    {
        if (string.IsNullOrWhiteSpace(formula))
        {
            throw new Exception("Die Formeleingabe darf nicht leer sein.");
        }
        if (!ValidateFormula(formula))
        {
            throw new Exception("Die Formeleingabe enthält ungültige Zeichen.");
        }

        // Ersetzen bestimmter Ausdrücke für LaTeX
        formula = formula.Replace("/", "\\frac");
        formula = formula.Replace("^", "^");
        formula = formula.Replace("_", "_");
        formula = formula.Replace("sqrt", "\\sqrt");
        formula = formula.Replace("sum", "\\sum");
        formula = formula.Replace("prod", "\\prod");
        formula = formula.Replace("sin", "\\sin");
        formula = formula.Replace("cos", "\\cos");
        formula = formula.Replace("tan", "\\tan");

        return $"\\({formula}\\)";
    }

    public static string ConvertLatexToSymbolic(string latex)
    {
        // Ersetzen bestimmter LaTeX-Ausdrücke durch ihre symbolischen Darstellungen
        latex = latex.Replace("\\frac", "/");
        latex = latex.Replace("\\sqrt", "sqrt");
        latex = latex.Replace("\\sum", "sum");
        latex = latex.Replace("\\prod", "prod");
        latex = latex.Replace("\\sin", "sin");
        latex = latex.Replace("\\cos", "cos");
        latex = latex.Replace("\\tan", "tan");

        // Entfernen der LaTeX-Klammern
        latex = latex.Replace("\\(", "").Replace("\\)", "");

        return latex;
    }
    public static string SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            return "Keine reelle Lösung";
        }
        else
        {
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double x1 = (-b + sqrtDiscriminant) / (2 * a);
            double x2 = (-b - sqrtDiscriminant) / (2 * a);
            return $"x1 = {x1}, x2 = {x2}";
        }
    }

    public static string ConvertQuadraticEquationToLatex(double a, double b, double c)
    {
        return $"\\( {a}x^2 + {b}x + {c} = 0 \\)";
    }
}
