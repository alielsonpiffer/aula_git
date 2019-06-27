namespace GitTutorial.Models
{
    public class ResultViewModel
    {
        public ResultViewModel()
        {
            Message = "OK!";
        }

        public string RequestId { get; set; }
        public string Message { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}