using System.Data;

DataTable dataTable = new DataTable();

dataTable.Columns.Add("Nummer");
dataTable.Columns.Add("Bezeichnung");

for (int i = 0; i < 10; i++)
{
    DataRow Row = dataTable.NewRow();
    Row["Nummer"] = i;
    Row["Bezeichnung"] = "Hallo Welt - " + i;
    dataTable.Rows.Add(Row);
}


DataTable Table = new DataTable();
Table.Columns.Add("Combined");


foreach (DataRow row in dataTable.Rows)
{
    DataRow TableRow = Table.NewRow();
    TableRow["Combined"] = row["Nummer"].ToString() + " - " + row["Bezeichnung"].ToString();
    Table.Rows.Add(TableRow);
}

foreach (DataRow row in Table.Rows)
{
    Console.WriteLine(row["Combined"].ToString());
}


Console.ReadKey();
