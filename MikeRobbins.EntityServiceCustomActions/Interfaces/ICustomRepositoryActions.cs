using Sitecore.Services.Core;

namespace MikeRobbins.EntityServiceCustomActions.Interfaces
{
    public interface ICustomRepositoryActions<T> : Sitecore.Services.Core.IRepository<T> where T : IEntityIdentity
    {
        string DoSometingCustom();
    }
}
