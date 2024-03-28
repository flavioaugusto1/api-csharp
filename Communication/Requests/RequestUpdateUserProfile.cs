namespace MyFirstAPI.Communication.Requests;

public class RequestUpdateUserProfile
{
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
