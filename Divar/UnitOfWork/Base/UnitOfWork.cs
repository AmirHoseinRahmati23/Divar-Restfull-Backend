using Microsoft.EntityFrameworkCore;
using Models;
using Models.Base;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Tools;

namespace UnitOfWork.Base
{
    public class UnitOfWork : object, IUnitOfWork
    {
        public UnitOfWork(Options options)
        {
            Options = options;
        }
        protected Options Options { get; set; }

        private DatabaseContext _databaseContext;
        internal DatabaseContext DatabaseContext 
        {
            get
            {
				if (_databaseContext == null)
				{
					var optionsBuilder =
						new DbContextOptionsBuilder<DatabaseContext>();

					switch (Options.Provider)
					{
						case Tools.Enums.Provider.SqlServer:
						{
								//optionsBuilder.UseSqlServer
								//	(connectionString: Options.ConnectionString);

								break;
						}

						case Tools.Enums.Provider.MySql:
						{
							//optionsBuilder.UseMySql
							//	(connectionString: Options.ConnectionString);

							break;
						}

						case Tools.Enums.Provider.Oracle:
						{
							//optionsBuilder.UseOracle
							//	(connectionString: Options.ConnectionString);

							break;
						}

						case Tools.Enums.Provider.PostgreSQL:
						{
							//optionsBuilder.UsePostgreSQL
							//	(connectionString: Options.ConnectionString);

							break;
						}

						case Tools.Enums.Provider.InMemory:
						{
							//optionsBuilder.UseInMemoryDatabase(databaseName: "InMemoryTemp");

						break;
						}

						case Tools.Enums.Provider.MongoDB:
						{
                                var MongoDbDatabase = new MongoClient(Options.ConnectionString)
									.GetDatabase(Options.DatabaseName);
								optionsBuilder.UseMongoDB(MongoDbDatabase.Client, MongoDbDatabase.DatabaseNamespace.DatabaseName);
								break;
						}
						default:
						{
							break;
						}
					}

					_databaseContext =
						new DatabaseContext(optionsBuilder.Options);
				}

				return _databaseContext;
			}
        }

        public Repository<T> GetRepository<T>() where T : Entity
        {
			return new Repository<T>(databaseContext: DatabaseContext);
		}

        public void Save()
        {
			DatabaseContext.SaveChanges();
		}

        public async Task SaveAsync()
        {
			await DatabaseContext.SaveChangesAsync();
		}

		public bool IsDisposed { get; protected set; }




		protected virtual void Dispose(bool disposing)
		{
			if (!IsDisposed)
			{
				if (disposing && _databaseContext != null)
				{
					_databaseContext.Dispose();
				}
			}
			IsDisposed = false;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
