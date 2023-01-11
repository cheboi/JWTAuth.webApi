namespace JWTAuth.webApi.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string? DisplayName { get; set; }
        public string?  USerName { get; set; }
        public string? Email  { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
