namespace APIAutomationCSharp;

[TestFixture]
public class APIRequests : CommonClass
{
    
    [Test,Order(4)]
    public void GetAllCheckItemsFromACard() 
    {
        GetAllCheckItems getAllCheckItems = new GetAllCheckItems();
        getAllCheckItems.getAllCheckItems("636c20d892257900b49ed01b",response,request,client);

    }

    [TestCase("Board created by api automation..... try 2",TestName =" CreateTrelloBoard"),Order(1)]
   // [TestCase("Test Case 8", TestName = " Test Case 2")]
   // [TestCase("Test Case 9", TestName = " Test Case 3")]
    public void CreateANewBoardAPI(string boardName)
    {
        CreateTrelloBoard createTrelloBoard = new CreateTrelloBoard();
        createTrelloBoard.createTrelloBoard(boardName, response, request, client);
        Thread.Sleep(5000);
    }

    [Test,Order(3)]
    public void DeleteATrelloBoard()
    {
        DeleteTrelloBoard deleteTBoard=new DeleteTrelloBoard();
        deleteTBoard.deleteTrelloBoard(_boardID, response, request, client);
        Thread.Sleep(5000);
    }

    [Test,Order(2)]
    public void EditTrelloBoard()
    {
        EditTrelloB editBoard = new EditTrelloB();
        editBoard.editTrelloBoard(_boardID, "Updated using c# API automation", response, request, client);
        Thread.Sleep(5000);
    }
}

