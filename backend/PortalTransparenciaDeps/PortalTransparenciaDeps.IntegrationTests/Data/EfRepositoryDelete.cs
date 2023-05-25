using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.IntegrationTests.Data
{
    public class EfRepositoryDelete : BaseEfRepoTestFixture
    {
        [Fact]
        public async Task DeletesPerfilAfterAddingIt()
        {
            var repository = GetPerfilRepository();
            var initialName = Guid.NewGuid().ToString();
            var perfil = Perfil.Factory.NovoPerfil(initialName, 1);
            await repository.AddAsync(perfil);

            await repository.DeleteAsync(perfil);

            Assert.DoesNotContain(await repository.ListAsync(),
                perfil => perfil.Nome == initialName);
        }
    }
}
