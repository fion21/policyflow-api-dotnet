using Microsoft.AspNetCore.Mvc;
using TestApi.Services;

namespace TestApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MetricsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var processed = PolicyStore.Policies
            .Where(p => p.SubmittedAt.HasValue && p.ProcessedAt.HasValue)
            .ToList();

        var averageProcessingTimeHours = processed.Any()
            ? processed.Average(p => (p.ProcessedAt!.Value - p.SubmittedAt!.Value).TotalHours)
            : 0;

        return Ok(new
        {
            totalPolicies = PolicyStore.Policies.Count,
            submittedPolicies = PolicyStore.Policies.Count(p => p.Status.Equals("Submitted", StringComparison.OrdinalIgnoreCase)),
            processedPolicies = PolicyStore.Policies.Count(p => p.Status.Equals("Processed", StringComparison.OrdinalIgnoreCase)),
            averageProcessingTimeHours = Math.Round(averageProcessingTimeHours, 2)
        });
    }
}