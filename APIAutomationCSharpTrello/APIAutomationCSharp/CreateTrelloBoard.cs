using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationCSharp 
{
    public class CreateTrelloBoard
    {
        public void createTrelloBoard(string boardName, RestResponse response, RestRequest request, RestClient client)
        {
            string endPoint = "/1/boards/";
            request.Resource=endPoint;
            request.AddQueryParameter("name",boardName);
            request.Method=Method.Post;
            response = client.Execute(request);
        }
    }
}
