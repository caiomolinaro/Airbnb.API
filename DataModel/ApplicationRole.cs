using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace Airbnb.API.DataModel;

[CollectionName("roles")]
public class ApplicationRole : MongoIdentityRole<Guid>
{
}