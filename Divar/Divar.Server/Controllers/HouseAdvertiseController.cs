using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using UnitOfWork;

namespace Divar.Server.Controllers;

public class AdvertiseController : BaseApiControllerWithDatabaseGeneric<Advertise>
{
    public AdvertiseController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}

public class HouseAdvertiseController : BaseApiControllerWithDatabaseGeneric<HouseAdvertise>
{
    public HouseAdvertiseController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}

public class DigitalAdvertiseController : BaseApiControllerWithDatabaseGeneric<DigitalAdvertise>
{
    public DigitalAdvertiseController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}
public class CarAdvertiseController : BaseApiControllerWithDatabaseGeneric<CarAdvertise>
{
    public CarAdvertiseController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}
public class ServiceAdvertiseController : BaseApiControllerWithDatabaseGeneric<ServiceAdvertise>
{
    public ServiceAdvertiseController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}