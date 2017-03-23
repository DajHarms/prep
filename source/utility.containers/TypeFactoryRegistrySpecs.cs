using System;
using developwithpassion.specifications.assertions.interactions;
using Machine.Specifications;
using spec = developwithpassion.specifications.use_engine<Machine.Fakes.Adapters.Rhinomocks.RhinoFakeEngine>;

namespace code.utility.containers
{
  [Subject(typeof(TypeFactoryRegistry))]
  public class TypeFactoryRegistrySpecs
  {
    public abstract class concern : spec.observe<IFindFactoriesForAType, TypeFactoryRegistry>
    {
    }

    public class when_i_have_the_factory_for_the_given_type : concern
    {
      Establish c = () =>
      {
        to_create = fake.an<ICreateOneDependency>();
      };

      Because b = () =>
          result = sut.get_factory_that_can_create(typeof(Object));

      private It returns_the_factory_that_matches_the_type = () =>
          result.ShouldEqual(to_create);

      static ICreateOneDependency result, to_create;
    }
  }
}