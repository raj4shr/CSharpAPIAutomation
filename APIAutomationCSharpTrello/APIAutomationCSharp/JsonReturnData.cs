namespace APIAutomationCSharp
{
    public class JsonReturnData
    {
    public string Id { get; set; }
    public string Name { get; set; }
    public int Pos { get; set; }
    public string Due { get; set; }
    public string DueReminder { get; set; }
    public string IdMember { get; set; }
    public string IdChecklist { get; set; }
    public string State { get; set; }
    }

    public class createBoardInfo
    {
        public string id { get; set; }
        public string name { get; set; }

        public string shortUrl { get; set; }
    }

    public class deleteBoard
    {
        public string _value { get; set; }
    }

    public class updateBoard
    {
        public string  name { get; set; }
    }
}
