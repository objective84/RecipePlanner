using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipePlanner.Service
{
    public interface IRecipeSvc : IService
    {
        void Create();
        void Edit();
        void Delete();

    }
}
