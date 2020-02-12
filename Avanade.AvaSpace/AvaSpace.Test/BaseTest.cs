using AvaSpace.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Test
{
    public abstract class BaseTest
    {
        public BaseTest() 
        {
            //RegisterMappers.Register();
        }

        public abstract void IntegratedTest();
    }
}
