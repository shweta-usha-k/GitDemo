using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder(). 
    AddUserSecrets<Program>();

string apiKey = config["apikey"];

Console.WriteLine(apiKey);
