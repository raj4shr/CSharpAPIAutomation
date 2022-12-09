
namespace APIAutomationCSharp;


[TestFixture]
public class APIRequests : CommonClass
{
    

    [Test]
    public void GetAllCheckItemsFromACard() 
    {
        GetAllCheckItems getAllCheckItems = new GetAllCheckItems();
        getAllCheckItems.getAllCheckItems("636c20d892257900b49ed01b",response,request,client);

    }

    [TestCase("Test Case 7",TestName =" Test Case 1")]
    [TestCase("Test Case 8", TestName = " Test Case 2")]
    [TestCase("Test Case 9", TestName = " Test Case 3")]
    public void CreateANewBoardAPI(string boardName)
    {
        CreateTrelloBoard createTrelloBoard = new CreateTrelloBoard();
        createTrelloBoard.createTrelloBoard(boardName, response, request, client);
    }

    [TestCase("wbdMBOvz", TestName = " D Test Case 1")]
    [TestCase("Ob6VTnH6", TestName = " D Test Case 2")]
    [TestCase("h1R82WT1", TestName = " D Test Case 3")]
    [TestCase("Ec5lq47t", TestName = " D Test Case 4")]
    [TestCase("sqoCO3tw", TestName = " D Test Case 5")]
    [TestCase("4fIAljUR", TestName = " D Test Case 6")]
    public void DeleteATrelloBoard(string boardName)
    {
        DeleteTrelloBoard deleteTBoard=new DeleteTrelloBoard();
        deleteTBoard.deleteTrelloBoard(boardName, response, request, client);
    }

    [Test]
    public void EditTrelloBoard()
    {
        EditTrelloB editBoard = new EditTrelloB();
        editBoard.editTrelloBoard("vJqDDsfy", "Updated using c#", response, request, client);
    }
}

