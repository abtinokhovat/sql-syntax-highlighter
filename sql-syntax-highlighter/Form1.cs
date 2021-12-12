using System.Text.RegularExpressions;

namespace sql_syntax_highlighter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void HighlightStrings()
        {
            var strings = Regex.Matches(Codes.Text, "([\"'])(?:(?=(\\\\?))\\2.)*?\\1");

            foreach (Match m in strings)
            {
                int startIndex = m.Index;
                int StopIndex = m.Length;
                Codes.Select(startIndex, StopIndex);
                Codes.SelectionColor = Color.Red;
            }
        }

        public void Highlightkeywords()
        {
            string[] tokens = {
                "ADD"
                , "CONSTRAINT"
                , "ALTER"
                , "ALL"
                , "AND"
                , "ANY"
                , "AS"
                , "ASC"
                , "BACKUP"
                , "BETWEEN"
                , "CASE"
                , "CHECK"
                , "COLUMN"
                , "CONSTRAINT"
                , "CREATE"
                , "INDEX"
                , "VIEW"
                , "DATABASE"
                , "DEFAULT"
                , "DELETE"
                , "DESC"
                , "DISTINCT"
                , "DROP"
                , "EXEC"
                , "EXISTS"
                , "FOREIGN KEY"
                , "FROM"
                , "GROUP BY"
                , "HAVING"
                , "IN"
                , "INDEX"
                , "INSERT INTO"
                , "JOIN"
                , "LEFT"
                , "RIGHT"
                , "OR"
                , "NOT"
                , "PROCEDURE"
                , "SELECT"
                , "TABLE"
                , "use"
                , "if"
                , "select"
                , "from"
                , "where"
                , "begin"
                , "drop"
                , "proc"
                , "go"
                , "as"
                , "with"
                , "nolock"
                , "delete"
                , "update"
                , "int"
                , "char"
                , "varchar"
                , "nvarchar"
                , "double"
                , "decimal"
                , "bigint"
                , "smallint"
                , "drop"
                , "exists"
                ,"from"
                ,"end"
            };

            var finalTokens = string.Empty;

            foreach (var token in tokens)
            {
                finalTokens += $"(?:^|\\W){token}(?:$|\\W)|";
            }



            var keywords = new Regex(finalTokens, RegexOptions.IgnoreCase);
            var matches = keywords.Matches(Codes.Text);
            foreach (Match m in matches)
            {
                int startIndex = m.Index;
                int StopIndex = m.Length;
                Codes.Select(startIndex, StopIndex);
                Codes.SelectionColor = Color.Blue;
            }

        }

        private void Codes_KeyPress(object sender, KeyPressEventArgs e)
        {
            int StartCursorPosition = Codes.SelectionStart;
            Codes.SelectionStart = StartCursorPosition;
            Codes.SelectionColor = Color.Black;
            Highlightkeywords();
            HighlightStrings();
        }
    }
}