namespace CDEKTestingServie.Models
{
    public class ResponseAnswer<T>
    {
        public int statusCode { get; set; }

        public string message { get; set; }

        public T body { get; set; }

        public ResponseAnswer(int statusCode, string message, T body)
        {
            this.statusCode = statusCode;
            this.message = message;
            this.body = body;
        }

        public ResponseAnswer(int statusCode, string message)
        {
            this.statusCode = statusCode;
            this.message = message;
        }

        public ResponseAnswer() { }
    }
}
