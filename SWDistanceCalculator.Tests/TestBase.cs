using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleInjector;
using SWDistanceCalculator.Interfaces;
using SWDistanceCalculator.Services;
using SWDistanceCalculator.Utils;

namespace SWDistanceCalculator.Tests
{
    [TestClass]
    public class TestBase
    {
        protected readonly Container container;
        public TestBase()
        {
            container = new Container();
            container.Options.DefaultScopedLifestyle = new SimpleInjector.Lifestyles.AsyncScopedLifestyle();
            container.Register<IParser, Parser>();
            container.Register<ICalculator, Calculator>();
            container.Register<IStarshipService, StarshipService>();
            container.Verify();
        }
    }
}
