using AvaSpace.Repository;

namespace AvaSpace.Test
{
    public abstract class BaseTest
    {
        public BaseTest() 
        {
            RegisterMappers.Register();
        }

        public abstract void IntegratedTest();
    }
}
