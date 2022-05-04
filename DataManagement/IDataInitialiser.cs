using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public interface IDataInitialiser
    {
        void BuildDataBase();
        void SeedDataBase();
    }
}
