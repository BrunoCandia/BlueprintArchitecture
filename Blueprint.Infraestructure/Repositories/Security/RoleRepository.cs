using Blueprint.Application.Interfaces.Repositories.Security;

namespace Blueprint.Infraestructure.Repositories.Security
{
    public class RoleRepository : IRoleRepository
    {
        private readonly BlueprintContext _blueprintContext;

        public RoleRepository(BlueprintContext blueprintContext)
        {
            _blueprintContext = blueprintContext;
        }

    }
}
