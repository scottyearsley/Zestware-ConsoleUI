using System.Collections.Generic;

namespace Zestware.ConsoleUI
{
    /// <summary>
    /// A table row.
    /// </summary>
    public class TableRow
    {
        public TableRow(params object[] Cells)
        {
            
        }
        public List<object> Cells { get; set; }
    }
}