using Microsoft.AspNetCore.Mvc;

namespace Infrastructure
{
	[ApiController]
	[Route("[controller]")]
	[Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
	public class BaseApiController : ControllerBase
	{
		public BaseApiController() : base()
		{
		}
	}
}
