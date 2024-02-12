using UnitOfWork;

namespace Infrastructure
{
	public class BaseApiControllerWithDatabase : BaseApiController
	{
		public BaseApiControllerWithDatabase(IUnitOfWork unitOfWork) : base()
		{
			UnitOfWork = unitOfWork;
		}

		protected IUnitOfWork UnitOfWork { get; }
	}
}
