using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationCSharp;

public class DeleteTrelloBoard
{
    public void deleteTrelloBoard(string pathId, RestResponse response, RestRequest request, RestClient client)
    {
        string endPoint = "/1/boards/" + pathId;
        request.Resource = endPoint;
        request.Method = Method.Delete;
        response=client.Execute(request);
    }
}
