using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationCSharp;

public class EditTrelloB
{
    public void editTrelloBoard(string pathID, string updatedName, RestResponse response, RestRequest request, RestClient client)
    {
        string endPoint = "/1/boards/" + pathID;
        request.Resource = endPoint;
        request.AddQueryParameter("name",updatedName);
        request.Method = Method.Put;
        response = client.Execute(request);
    }
}
