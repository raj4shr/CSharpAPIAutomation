using System.Collections.ObjectModel;

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

    [Test,Order(1),TestCaseSource(nameof(boardNames))]
    public void CreateANewBoardAPI(string boardName)
    {
        CreateTrelloBoard createTrelloBoard = new CreateTrelloBoard();
        createTrelloBoard.createTrelloBoard(boardName, response, request, client);
        //Just to see it create in realtime
        Thread.Sleep(1000);
    }

    [Test,Order(3),TestCaseSource(nameof(index))]
    public void DeleteATrelloBoard(int index)
    {
        DeleteTrelloBoard deleteTBoard=new DeleteTrelloBoard();
        deleteTBoard.deleteTrelloBoard(boardID[index], response, request, client);
        //Just to see it delete in real time
        Thread.Sleep(1000);
    }

    [Test,Order(2),TestCaseSource(nameof(index))]
    public void EditTrelloBoard(int index)
    {
        EditTrelloB editBoard = new EditTrelloB();
        editBoard.editTrelloBoard(boardID[index],index, response, request, client);
        //Just to see it update in real time
        Thread.Sleep(1000);
    }
}

