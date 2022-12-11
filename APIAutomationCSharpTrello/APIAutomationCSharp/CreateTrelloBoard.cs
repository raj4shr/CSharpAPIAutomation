namespace APIAutomationCSharp 
{
    public class CreateTrelloBoard
    {
        public void createTrelloBoard(string boardName, RestResponse response, RestRequest request, RestClient client)
        {
            //Assigning the end point as a resource to Rest request
            string endPoint = "/1/boards/";
            request.Resource=endPoint;
            //Adding a query parameter to create a board
            request.AddQueryParameter("name",boardName);
            //Setting the request method for the request
            request.Method=Method.Post;
            //Executing the request
            response = client.Execute(request);
            //Converting json to custom class
            createBoardInfo cbInfo = JsonConvert.DeserializeObject<createBoardInfo>(response.Content);
            //Getting the ID's of new boards created to be used as path variable for Update and Delete API calls
            CommonClass.boardID.Add(cbInfo.id);
            //Using fluent assertions
            cbInfo.id.Should().NotBe(null);
        }
    }
}
