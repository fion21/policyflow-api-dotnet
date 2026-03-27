namespace TestApi.DTOs;

public class UpdatePolicyStatusRequest
{
    public string NewStatus { get; set; } = string.Empty;
    public string ChangedBy { get; set; } = "User";
}