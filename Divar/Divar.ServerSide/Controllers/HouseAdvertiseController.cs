using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using MongoDB.Bson;
using UnitOfWork;

namespace Divar.Server.Controllers;


public class HouseAdvertiseController : BaseApiControllerWithDatabase
{
    public HouseAdvertiseController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
        
    }

    [HttpGet]
    public virtual async Task<ActionResult<List<HouseAdvertise>>> GetAsync()
    {
        var result = await UnitOfWork.HouseAdvertiseRepo.GetAllHousesAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public virtual async Task<ActionResult<List<HouseAdvertise>>> GetAsync(ObjectId id)
    {
        var result = await UnitOfWork.HouseAdvertiseRepo.GetHouseByIdAsync(id);
        return Ok(result);
    }

    [HttpPost]
    public virtual async Task<ActionResult> PostAsync(HouseAdvertise advertise)
    {
        if (advertise == null)
            return BadRequest();
        await UnitOfWork.HouseAdvertiseRepo.InsertHouseAsync(advertise);
        await UnitOfWork.SaveAsync();
        return Ok();
    }

    [HttpPut]
    public virtual async Task<ActionResult> PutAsync(HouseAdvertise advertise)
    {
        await UnitOfWork.HouseAdvertiseRepo.UpdateHouseAsync(advertise);
        await UnitOfWork.SaveAsync();
        return Ok();
    }

    [HttpDelete("{id}")]
    public virtual async Task<ActionResult> DeleteAsync(ObjectId id)
    {
        var result = await UnitOfWork.HouseAdvertiseRepo.DeleteHouseByIdAsync(id);
        if (!result)
        {
            return NotFound();
        }
        await UnitOfWork.SaveAsync();
        return Ok();
    }
}