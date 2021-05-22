using ProffyApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProffyApi.Interfaces
{
    public interface IProffyService
    {
        Proffy AddProffy(Proffy proffy);

        List<Proffy> GetProffys();

        Proffy GetProffyId(int id);

        string DeleteProffy(int id);

        Proffy UpdateProffy(Proffy proffy);

    }
}
