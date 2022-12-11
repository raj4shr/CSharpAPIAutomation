
namespace APIAutomationCSharp;

public class GetAllCheckItems
{
    public void getAllCheckItems(string pathParam,RestResponse response, RestRequest request, RestClient client)
    {
        //Assigning the end point as a resource to Rest request
        string endPoint = "/1/checklists/" + pathParam + "/checkitems";
        request.Resource = endPoint;
        //Setting the request method for the request
        request.Method=Method.Get;
        //Executing the request
        response = client.Execute(request);
        //Converting json to custom class
        List<JsonReturnData> testCaseInfo = JsonConvert.DeserializeObject<List<JsonReturnData>>(response.Content);
        //Using fluent assertions
        testCaseInfo.Count.Should().Be(17, "Validating count");
    }
}




        /*JToken jt = JToken.Parse(jsonString);
        var beautiful = jt.ToString(Formatting.Indented);
        string str = beautiful;
        beautiful = str.Trim(new char[] { '[', ']' });
        Console.WriteLine(beautiful);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));*/