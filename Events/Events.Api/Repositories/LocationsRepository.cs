﻿using Kvpbldsck.NastolochkiAPI.Common.Db.Repositories;
using Kvpbldsck.NastolochkiAPI.Events.Api.Database;
using Kvpbldsck.NastolochkiAPI.Events.Api.Models;
using Kvpbldsck.NastolochkiAPI.Events.Api.Repositories.Contracts;

namespace Kvpbldsck.NastolochkiAPI.Events.Api.Repositories;

public sealed class LocationsRepository : BaseEntityRepository<Location>, ILocationsRepository
{
    public LocationsRepository(EventsDbContext dbContext) : base(dbContext, dbContext.Locations)
    {
    }
}
