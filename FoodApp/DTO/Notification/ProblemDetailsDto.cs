namespace Api.DTO.Notification
{
    public class ProblemDetailsDto
    {
        public string Detail { get; private set; }

        public int Status { get; private set; }

        public string SupportLink { get; private set; }

        public ProblemDetailsDto(string messages, int statusCode, string supportLink)
        {
            Detail = messages;
            Status = statusCode;
            SupportLink = supportLink;
        }
    }
}
