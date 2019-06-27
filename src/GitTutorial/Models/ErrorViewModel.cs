namespace GitTutorial.Models
{
    public class ErrorViewModel
    {
        public ErrorViewModel()
        {
            Message = "OK!";
            // altereação mais nova ainda
        }

        public string RequestId { get; set; }
        public string Message { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}