using System.Collections.Generic;

namespace Zestware.ConsoleUI
{
    /// <summary>
    /// A table definition.
    /// </summary>
    public class Table
    {
        /// <summary>
        /// The table headers.
        /// </summary>
        /// <returns></returns>
        public List<TableColumn> Columns { get; set; } = new List<TableColumn>();

        /// <summary>
        /// The table rows.
        /// </summary>
        /// <returns></returns>
        public List<TableRow> Rows { get; set; } = new List<TableRow>();

        public int CalculatedWidth
        {
            get
            {
                return 100;
            }
        }
    }
}