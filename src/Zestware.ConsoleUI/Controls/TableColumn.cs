namespace Zestware.ConsoleUI
{
    public class TableColumn
    {
        /// <summary>
        /// TableColumn constructor.
        /// </summary>
        public TableColumn()
        {
        }

        /// <summary>
        /// TableColumn constructor.
        /// </summary>
        /// <param name="header"></param>
        public TableColumn(string header, TextAlign headerAlignment = TextAlign.Left)
        {
            Header = header;
        }

        /// <summary>
        /// The header text for the column.
        /// </summary>
        /// <returns></returns>
        public string Header { get; set; }

        /// <summary>
        /// The alignment for the header text.
        /// </summary>
        /// <returns></returns>
        public TextAlign HeaderAlignment { get; set; }
    }
}