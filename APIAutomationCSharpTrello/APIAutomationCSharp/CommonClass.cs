global using RestSharp;
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using Newtonsoft.Json;
global using Newtonsoft.Json.Linq;
global using NUnit.Framework;
global using RestSharp;
global using RestSharp.Authenticators;
global using RestSharp.Serializers;
global using SpecFlow.Internal.Json;
global using System;
global using System.Collections.ObjectModel;
global using System.Net.Http.Json;
global using System.Text.Json.Nodes;
using System.Net;
using TechTalk.SpecFlow;

namespace APIAutomationCSharp;

public class CommonClass
{
    public RestClient? client { get; set; }

    public RestResponse? response { get;set; }

    public RestRequest? request { get; set; }

    [SetUp]
    public void TrelloAPIInitialize()
    {
        client= new("https://api.trello.com");
        request = new();
        request.AddQueryParameter("key", "a2217463f78c8c772148298e82eadb4c");
        request.AddQueryParameter("token", "4284fd45a6edb09b08952b601f5f7894447170cabc80dc9fe141cf3bce7e38b6");

    }

    [TearDown]
    public void TrelloAPIShutdown()
    {
        Console.Write("Test successful.....");
    }
}
