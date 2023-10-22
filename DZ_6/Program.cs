using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DZ_6;

try
{
    const string InputPath = "C:\\Users\\volos\\OneDrive\\Рабочий стол\\К-27\\ООП\\DZ_6\\DZ_6\\input.json";
    const string OutputPath = "C:\\Users\\volos\\OneDrive\\Рабочий стол\\К-27\\ООП\\DZ_6\\DZ_6\\output.json";

    FileStream fs = new FileStream(InputPath, FileMode.OpenOrCreate);

    var books = await JsonSerializer.DeserializeAsync<List<Book>>(fs);


    foreach (var book in books)
    {
        Console.WriteLine(JsonSerializer.Serialize(book));
    }

    fs.Close();

    var options = new JsonSerializerOptions
    {
        WriteIndented = true,
    };

    File.WriteAllText(OutputPath, JsonSerializer.Serialize(books, options));

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
