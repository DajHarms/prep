using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.utility.containers
{
  public class TypeFactoryRegistry : IFindFactoriesForAType
  {
    public ICreateOneDependency get_factory_that_can_create(Type item_to_create)
    {
      throw new NotImplementedException();
    }
  }
}
