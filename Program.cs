// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



var expConverter = new Newtonsoft.Json.Converters.ExpandoObjectConverter();

var json = File.ReadAllText("test.json");

var dynamic = (dynamic)Newtonsoft.Json.JsonConvert.DeserializeObject<System.Dynamic.ExpandoObject>(json, expConverter);

var existingProp = dynamic.Url;
var existingPropDifferentCase = dynamic.url;
var nonExistingProp = dynamic.dbCreated;
