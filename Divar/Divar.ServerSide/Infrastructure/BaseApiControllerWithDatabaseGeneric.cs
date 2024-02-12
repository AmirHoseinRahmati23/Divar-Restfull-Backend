using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using UnitOfWork;


namespace Infrastructure;
public class BaseApiControllerWithDatabaseGeneric<T> : BaseApiControllerWithDatabase where T : Models.Base.Entity
{
    public BaseApiControllerWithDatabaseGeneric(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    [HttpGet]
    public virtual async Task<ActionResult<IEnumerable<T>>> GetAsync()
    {
        var result = await UnitOfWork.GetRepository<T>().GetAllAsync();

        return Ok(value: result);
    }

    [HttpGet(template: "{0}")]
    public virtual async Task<ActionResult<T>> GetAsync(Guid id)
    {
        ObjectId identity = ObjectId.Parse(id.ToString());
        var foundedEntity = await UnitOfWork.GetRepository<T>().GetByIdAsync(identity);

        return Ok(value: foundedEntity);
    }

    [HttpPost]
    public virtual async Task<ActionResult<T>> PostAsync(T entity)
    {
        await UnitOfWork.GetRepository<T>().InsertAsync(entity);

        await UnitOfWork.SaveAsync();

        return Ok(value: entity);
    }

    [HttpPut]
    public virtual async Task<ActionResult<T>> PutAsync(T entity)
    {
        await UnitOfWork.GetRepository<T>().UpdateAsync(entity);

        await UnitOfWork.SaveAsync();

        return Ok(value: entity);
    }

    [HttpDelete]
    public virtual async Task<ActionResult<T>> DeleteAsync(Guid id)
    {

        var identity = new ObjectId(id.ToString());
        var result = await UnitOfWork.GetRepository<T>().DeleteByIdAsync(identity);


        await UnitOfWork.SaveAsync();

        if(result == true)
        {
            return Ok();
        }

        return NotFound();
    }
}

