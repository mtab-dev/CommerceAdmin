namespace CommerceAdmin.API.DTO.Response
{
    public record StandardRespondeDTO
    {
        public string Message { get; set; } = string.Empty;
        public int StatusCode { get; set; }

    }
}
