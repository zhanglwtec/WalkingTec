using WalkingTec.Mvvm.Abstraction;
using WalkingTec.Mvvm.Core;

namespace GitTest.Model
{
    [Authority("工厂", "FactoryName")]
    public class FrameworkFactory : BasePoco
    {
        public string FactoryName { get; set; }

    }
}
