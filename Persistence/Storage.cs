using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Westcoast_Education.Persistence;

public class Storage<T>
{
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        Converters = {new JsonStringEnumConverter()},
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public static List<T> Read(string path)
    {
        if (!File.Exists(path))
        {
            return [];
        }

        try
        {
            string data = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(data) || !string.IsNullOrWhiteSpace(data))
            {
                return JsonSerializer.Deserialize<List<T>>(data, _options)??[];
            }
            else
            {
                return [];
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static void Write(List<T> items, string path)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        try
        {
            string json = JsonSerializer.Serialize(items, _options);
            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}