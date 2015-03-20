using System.Web.Http;
using MikeRobbins.EntityServiceCustomActions.Interfaces;
using MikeRobbins.EntityServiceCustomActions.Models;
using MikeRobbins.EntityServiceCustomActions.Repositories;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;

namespace MikeRobbins.EntityServiceCustomActions.Controllers
{
    [ServicesController]
    public class EntityController : EntityService<Entity>
    {
        private ICustomRepositoryActions<Entity> _customRepositoryActions;

        public EntityController(ICustomRepositoryActions<Entity> repository)
            : base(repository)
        {
            _customRepositoryActions = repository;
        }

        public EntityController()
            : this(new EntityRespository())
        {
        }

        [HttpGet]
        [ActionName("DoSomethingCustom")]
        public string Get()
        {
            return _customRepositoryActions.DoSometingCustom();
        }
    }
}