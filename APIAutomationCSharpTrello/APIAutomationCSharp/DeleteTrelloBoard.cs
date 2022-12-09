namespace APIAutomationCSharp;

public class DeleteTrelloBoard
{
    public void deleteTrelloBoard(string pathId, RestResponse response, RestRequest request, RestClient client)
    {
        //Assigning the end point as a resource to Rest request
        string endPoint = "/1/boards/" + pathId;
        request.Resource = endPoint;
        //Setting the request method for the request
        request.Method = Method.Delete;
        //Executing the request
        response = client.Execute(request);
        //Converting json to custom class
        deleteBoard deleted = JsonConvert.DeserializeObject<deleteBoard>(response.Content);
        //Using fluent assertions
        deleted._value.Should().Be(null);
    }
}



