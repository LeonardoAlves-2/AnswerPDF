namespace AnswerPDF.Core.Modules.Grid.Models;

public class TableModel
{
    public string[][] Data { get; set; }
    public int ColumnsAmount { get; }
    public int RowsAmount { get; }
    public TableModel(dynamic[][] data)
    {
        ColumnsAmount = data[0].Length;
        RowsAmount = data.Length;

        Data = new string[RowsAmount][];
        for (int i = 0; i < RowsAmount; i++)
        {
            Data[i] = new string[ColumnsAmount];
            for (int j = 0; j < ColumnsAmount; j++)
            {
                Data[i][j] = data[i][j].ToString();
            }
        }
    }

    public TableModel(string[][] data)
    {
        ColumnsAmount = data[0].Length;
        RowsAmount = data.Length;
        Data = data;
    }
}
