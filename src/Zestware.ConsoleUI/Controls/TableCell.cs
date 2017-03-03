namespace Zestware.ConsoleUI
{
    /// <summary>
    /// A table cell.
    /// </summary>
    public class TableCell
    {
        /// <summary>
        /// TableCell constructor.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="rowSpan"></param>
        /// <param name="columnSpan"></param>
        public TableCell(object data, int rowSpan = 0, int columnSpan = 0)
        {
            Data = data;
            RowSpan = rowSpan;
            ColumnSpan = columnSpan;
        }

        /// <summary>
        /// The table cell data. .ToString() will be invoked to render the output.
        /// </summary>
        /// <returns></returns>
        public object Data { get; set; }

        public int RowSpan { get; set; } = 0;

        public int ColumnSpan { get; set; } = 0;
    }
}