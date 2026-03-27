namespace TestApi.DTOs;

public class CreatePolicyRequest
{
    public string PolicyNumber { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;
    public string PolicyType { get; set; } = string.Empty;
    public decimal Premium { get; set; }
}