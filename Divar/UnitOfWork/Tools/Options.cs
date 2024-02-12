using UnitOfWork.Tools.Enums;

namespace UnitOfWork.Tools
{
	public class Options : object
	{
		public Options() : base()
		{
		}

		public Provider Provider { get; set; }

		public string ConnectionString { get; set; }

		//In Case Of MongoDB:
		public string DatabaseName { get; set; }
	}
}
