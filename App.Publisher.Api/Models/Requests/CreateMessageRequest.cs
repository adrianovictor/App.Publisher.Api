namespace App.Publisher.Api.Models.Requests
{
    public class CreateMessageRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
