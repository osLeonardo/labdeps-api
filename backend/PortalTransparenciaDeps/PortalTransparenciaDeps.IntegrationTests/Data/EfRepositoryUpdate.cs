using Microsoft.EntityFrameworkCore;
using PortalTransparenciaDeps.Core.Entities.PerfilAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PortalTransparenciaDeps.IntegrationTests.Data
{
    public class EfRepositoryUpdate : BaseEfRepoTestFixture
    {
        [Fact]
        public async Task UpdatesPerfilAfterAddingIt()
        {
            // add an item
            var repository = GetPerfilRepository();
            var initialName = Guid.NewGuid().ToString();
            var perfil = Perfil.Factory.NovoPerfil(initialName, 1);

            await repository.AddAsync(perfil);

            // detach the item so we get a different instance
            _dbContext.Entry(perfil).State = EntityState.Detached;

            // fetch the item and update its name
            var novoPerfil = (await repository.ListAsync())
                                    .FirstOrDefault(perfil => perfil.Nome == initialName);
            Assert.NotNull(novoPerfil);
            Assert.NotSame(perfil, novoPerfil);
            var newName = Guid.NewGuid().ToString();
            novoPerfil.AlterarNome(newName);
            novoPerfil.Inativar();

            // Update the item
            await repository.UpdateAsync(novoPerfil);

            // Fetch the updated item
            var updatedItem = (await repository.ListAsync())
                .FirstOrDefault(perfil => perfil.Nome == newName);

            Assert.NotNull(updatedItem);
            Assert.NotEqual(perfil.Nome, updatedItem.Nome);
            Assert.Equal(novoPerfil.Id, updatedItem.Id);
            Assert.NotEqual(perfil.Ativo, updatedItem.Ativo);
        }
    }
}
