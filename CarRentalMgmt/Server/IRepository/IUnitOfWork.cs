using CarRentalMgmt.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalMgmt.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> Makes { get;  }
        //IGenericRepository<Model> Makes { get;  }
        //IGenericRepository<Vehicle> Makes { get;  }

    }
}
