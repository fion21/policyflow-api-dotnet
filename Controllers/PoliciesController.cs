using Microsoft.AspNetCore.Mvc;
using TestApi.DTOs;
using TestApi.Models;
using TestApi.Services;

namespace TestApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PoliciesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(PolicyStore.Policies);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var policy = PolicyStore.Policies.FirstOrDefault(p => p.Id == id);

        if (policy is null)
            return NotFound();

        return Ok(policy);
    }

    [HttpPost]
    public IActionResult Create(CreatePolicyRequest request)
    {
        var newPolicy = new Policy
        {
            Id = PolicyStore.Policies.Count == 0 ? 1 : PolicyStore.Policies.Max(p => p.Id) + 1,
            PolicyNumber = request.PolicyNumber,
            CustomerName = request.CustomerName,
            PolicyType = request.PolicyType,
            Premium = request.Premium,
            Status = "Draft",
            CreatedAt = DateTime.UtcNow,
            LastUpdatedAt = DateTime.UtcNow
        };

        PolicyStore.Policies.Add(newPolicy);

        return CreatedAtAction(nameof(GetById), new { id = newPolicy.Id }, newPolicy);
    }

    [HttpPut("{id:int}/status")]
    public IActionResult UpdateStatus(int id, UpdatePolicyStatusRequest request)
    {
        var policy = PolicyStore.Policies.FirstOrDefault(p => p.Id == id);

        if (policy is null)
            return NotFound();

        policy.Status = request.NewStatus;
        policy.LastUpdatedAt = DateTime.UtcNow;

        if (request.NewStatus.Equals("Submitted", StringComparison.OrdinalIgnoreCase) && policy.SubmittedAt is null)
        {
            policy.SubmittedAt = DateTime.UtcNow;
        }

        if (request.NewStatus.Equals("Processed", StringComparison.OrdinalIgnoreCase))
        {
            policy.ProcessedAt = DateTime.UtcNow;
        }

        return NoContent();
    }
}