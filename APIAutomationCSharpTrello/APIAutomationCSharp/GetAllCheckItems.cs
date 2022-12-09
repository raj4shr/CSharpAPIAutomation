
namespace APIAutomationCSharp;

public class GetAllCheckItems
{
    public void getAllCheckItems(string pathParam,RestResponse response, RestRequest request, RestClient client)
    {
        string endPoint = "/1/checklists/" + pathParam + "/checkitems";
        request.Resource = endPoint;
        response = client.Execute(request);
        string jsonString = response.Content.ToString();
        JToken jt = JToken.Parse(jsonString);
        var beautiful = jt.ToString(Formatting.Indented);
        string str = beautiful;
        beautiful = str.Trim(new char[] { '[', ']' });
        Console.WriteLine(beautiful);
    }
}
