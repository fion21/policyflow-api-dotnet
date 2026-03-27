using TestApi.Models;

namespace TestApi.Services;

public static class PolicyStore
{
    public static List<Policy> Policies { get; } = new()
    {
        new Policy
        {
            Id = 1,
            PolicyNumber = "POL-1001",
            CustomerName = "Sarah Jones",
            PolicyType = "Health Plus",
            Premium = 350,
            Status = "Draft",
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow
        }
    };
}