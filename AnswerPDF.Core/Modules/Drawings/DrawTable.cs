using AnswerPDF.Core.Modules.Grid.Models;
using AnswerPDF.Core.Modules.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace AnswerPDF.Core.Modules.Drawings;

public class DrawTable : GenericDrawModel
{
    private readonly TableModel Table;
    public DrawTable(TableModel table)
    {
        Table = table;
    }

    public IContainer Draw(IContainer container)
    {
        container.Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
                for (var columnIndex = 1; columnIndex <= Table.ColumnsAmount; columnIndex++)
                {
                    columns.RelativeColumn();
                }
            });

            for (uint columnIndex = 1; columnIndex <= Table.ColumnsAmount; columnIndex++)
            {
                for (uint rowIndex = 1; rowIndex <= Table.RowsAmount; rowIndex++)
                {
                    table.Cell().Row(1).Column(columnIndex).Element(Block).Text(Table.Data[columnIndex][rowIndex]);
                }
            }
        });

        return container;
    }

    private static IContainer Block(IContainer container)
    {
        return container
            .Border(1)
            .Background(Colors.Grey.Lighten3)
            .ShowOnce()
            .MinWidth(50)
            .MinHeight(50)
            .AlignCenter()
            .AlignMiddle();
    }

}
