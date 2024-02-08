using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace Airbnb.API.DataModel;

[CollectionName("users")]
public class ApplicationUser : MongoIdentityUser<Guid>
{
}