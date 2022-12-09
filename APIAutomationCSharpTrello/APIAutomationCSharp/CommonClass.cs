global using RestSharp;
global using System;
global using System.Collections.Generic;
global using Newtonsoft.Json;
global using NUnit.Framework;
global using FluentAssertions;

namespace APIAutomationCSharp;

public class CommonClass
{
    //To use the id of the new trello board created to update and then delete the board
    public static string? _boardID;
    public RestClient? client { get; set; }

    public RestResponse? response { get;set; }

    public RestRequest? request { get; set; }

    [SetUp]
    public void TrelloAPIInitialize()
    {
        //Common initialazation for CRUD
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
