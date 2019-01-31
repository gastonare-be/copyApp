using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repositories
{
    public class CategoryRepository : BaseRepository<Category, int>, ICategoryRepository
    {
        protected virtual string GetAllCategoriesStoredProcedureName => $"mg_{EntityName}_GetByMessageId";

        public CategoryRepository(IDatabaseProviderFactory factory) : base(factory)
        {
        }

        public void AddCategory(string CategoryName)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            using (var command = Db.GetStoredProcCommand(GetAllCategoriesStoredProcedureName))
            {
                return LoadCategories(command);
            }
        }

        public List<Category> LoadCategories(DbCommand command)
        {
            var categories = new List<Category>();

            using (var objDataReader = Db.ExecuteReader(command))
            {
                while (objDataReader.Read())
                {
                    var category = Category.MapTo(objDataReader);

                    categories.Add(category);
                }

            }
            return categories;
        }
    }
}
