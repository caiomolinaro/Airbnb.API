using Airbnb.API.DataModel;
using Airbnb.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.API.Controllers;

[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class ListingsController : ControllerBase
{
    private readonly ListingDataService _listingDataService;

    public ListingsController(ListingDataService listingDataService)
    {
        _listingDataService = listingDataService;
    }

    [HttpGet]
    public async Task<List<Listing>> Get(int? page, int? limit)
    {
        if (!page.HasValue) page = 1;

        if (!limit.HasValue) limit = 5;

        int offSet = limit.Value * (page.Value - 1);

        return await _listingDataService.GetAsync(limit.Value, offSet);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Listing newListing)
    {
        await _listingDataService.CreateAsync(newListing);

        return CreatedAtAction(nameof(Get), new { id = newListing._id }, newListing);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, Listing updateListing)
    {
        if (id != updateListing._id)
        {
            return BadRequest();
        }

        await _listingDataService.UpdateAsync(id, updateListing);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var listing = _listingDataService.GetAsync(id);

        if (listing is null)
        {
            return NotFound();
        }

        await _listingDataService.RemoveAsync(id);

        return NoContent();
    }
}