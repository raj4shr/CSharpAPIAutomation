global using RestSharp;
global using System;
global using System.Collections.Generic;
global using Newtonsoft.Json;
global using NUnit.Framework;
global using FluentAssertions;
using System.Security.Policy;
using System.Net;


namespace APIAutomationCSharp;

public class CommonClass
{
    //To use the id of the new trello board created to update and then delete the board
    public static int[] index ={0,1,2,3,4};

    //string array values to create new trello board and delete it
    public static string[] boardNames = { "Board1", "Board2", "Board3", "Board4", "Board5" };

    //string array values to update the boards
    public static string[] updateNames = { "Update1", "Update2", "Update3", "Update4", "Update5" };

    //string array values to hold the board id when its created and use it to delete
    public static List<string> boardID = new(5);

    public RestClient? client { get; set; }

    public RestResponse? response { get;set; }

    public RestRequest? request { get; set; }
    
    public HttpClient? httpClient { get; set; }
    public HttpResponseMessage? responseMessage { get; set; }
    public HttpRequestMessage? requestMessage { get; set; }


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
