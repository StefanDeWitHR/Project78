using System;
using App_.Helpers;
using App_.Models;
using App_.Services;

namespace App_
{
    public class App
    {

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}
