using Xunit;
using TestStack.BDDfy;
using Zestware.ConsoleUI.Specs;

namespace Zestware.ConsoleUI.Render.Specs
{
    public class TableColumnSpecs
    {
        public class SimpleTableColumnConfigurationSpec: ConsoleSpec
        {
            private Table _sut;

            [Given]
            public void GivenASimpleTableColumnConfiguration()
            {
                _sut = new Table();
                _sut.Columns.Add(new TableColumn("Column A"));
                _sut.Columns.Add(new TableColumn("Column B"));
                _sut.Columns.Add(new TableColumn("Column C"));
            }

            [When]
            public void WhenRenderedWithoutAnyRowsOrColumnWidths()
            {
                ConsoleUI.WriteTable(_sut);
            }

            [Then]
            public void ThenTheColumnsShouldBeRenderedWithNoAdditionalSpacing()
            {
                var result = GetResult();
                Assert.Equal("---------------------------------", result);
            }
        }
    }
}
