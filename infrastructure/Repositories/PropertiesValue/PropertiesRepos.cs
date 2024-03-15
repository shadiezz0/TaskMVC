using Core.Interfaces.PropertiesValues;
using Core.Models;
using infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Repositories.PropertiesValue
{
    public class PropertiesRepos : BaseRepository<Category>, IPropertiesRepos
    {
        public PropertiesRepos(DataBaseContext baseContext) : base(baseContext)
        {
        }
    }
}
