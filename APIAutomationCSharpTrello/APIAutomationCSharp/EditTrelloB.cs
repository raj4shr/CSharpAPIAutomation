using System.IO;

namespace APIAutomationCSharp;

public class EditTrelloB
{
    public void editTrelloBoard(string pathID,int index, RestResponse response, RestRequest request, RestClient client)
    {
        //Assigning the end point as a resource to Rest request
        string endPoint = "/1/boards/" + pathID;
        request.Resource = endPoint;
        //Adding a query parameter to update the board
        request.AddQueryParameter("name", CommonClass.updateNames[index]);
        //Setting the request method for the request
        request.Method = Method.Put;
        //Executing the request
        response = client.Execute(request);
        //Converting json to custom class
        updateBoard updated =JsonConvert.DeserializeObject<updateBoard>(response.Content);
        //Using fluent assertions
        updated.name.Should().Be(CommonClass.updateNames[index]);
    }
}

