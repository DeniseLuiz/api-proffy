using ProffyApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProffyApi.Interfaces
{
    public interface IProffyService
    {
        Proffy Add(Proffy proffy);

        List<Proffy> Get();

        Proffy GetId(int id);

        string Delete(int id);

        Proffy Update(Proffy proffy);

    }
}
