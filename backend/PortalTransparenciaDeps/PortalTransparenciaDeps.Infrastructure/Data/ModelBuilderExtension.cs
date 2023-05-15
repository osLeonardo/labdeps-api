using Microsoft.EntityFrameworkCore;
using PortalTransparenciaDeps.SharedKernel.Extensions;
using System.Linq;

namespace PortalTransparenciaDeps.Infrastructure.Data
{
    internal static class ModelBuilderExtension
    {
        internal static void ConvertToSnakeCase(this ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {

                foreach (var key in entity.GetKeys())
                {
                    key.SetName(key.GetName().ToSnakeCase());
                }

                foreach (var key in entity.GetForeignKeys())
                {
                    key.SetConstraintName(key.GetConstraintName().ToSnakeCase());
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.SetDatabaseName(index.Name.ToSnakeCase());
                }

                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.Name.ToSnakeCase());
                }

                entity.SetTableName(entity.Name.Split(".").Last().ToSnakeCase());
            }
        }
    }
}
