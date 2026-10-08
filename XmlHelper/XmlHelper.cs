using System.Xml.Linq;

public class XmlHelper
{
    private readonly XDocument _doc;
    private readonly string _filePath;

    public XmlHelper(string filePath)
    {
        _filePath = filePath;
        _doc = XDocument.Load(filePath);
    }

    public string GetString(params string[] elements)
    {
        XElement? current = _doc.Root;

        foreach (var element in elements)
        {
            current = current?.Element(element);

            if (current is null)
                return "";
        }

        return current.Value;
    }

    public int GetInt(string elementName)
    {
        return int.TryParse(
            _doc.Root?.Element(elementName)?.Value,
            out int result)
            ? result
            : 0;
    }

    public IEnumerable<XElement> GetElements(string elementName)
    {
        return _doc.Root?.Elements(elementName)
            ?? Enumerable.Empty<XElement>();
    }

    public void Save()
    {
        _doc.Save(_filePath);
    }
}