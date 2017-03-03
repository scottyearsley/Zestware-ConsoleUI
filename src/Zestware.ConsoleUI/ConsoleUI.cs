using Zestware.ConsoleUI.Renderers;

namespace Zestware.ConsoleUI
{
    public static class ConsoleUI
    {
        public static void WriteTable(Table table)
        {
            new BorderedTableRenderer().Render(table);
        }
    }
}