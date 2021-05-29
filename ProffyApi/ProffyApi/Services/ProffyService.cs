using ProffyApi.Context;
using ProffyApi.Interfaces;
using ProffyApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProffyApi.Services
{
    public class ProffyService : IProffyService
    {
        ProffyContext _proffyContext;
        public ProffyService( ProffyContext proffyContext)
        {
            _proffyContext = proffyContext;
        }

        public Proffy Add(Proffy proffy)
        {
            _proffyContext.Proffys.Add(proffy);
            _proffyContext.SaveChanges();
            return proffy;
        }

        public string Delete(int id)
        {
            var proffy = _proffyContext.Proffys.FirstOrDefault(x => x.Id == id);

            if(proffy != null)
            {
                _proffyContext.Proffys.Remove(proffy);
                _proffyContext.SaveChanges();
                return "Proffy deletado com sucesso";
            }

            return $"Proffy com id {id} não encontrado";
        }

        public Proffy GetId(int id)
        {
            return _proffyContext.Proffys.FirstOrDefault(x => x.Id == id);
        }

        public List<Proffy> Get()
        {
            return _proffyContext.Proffys.ToList();
        }

        public Proffy Update(Proffy proffy)
        {
            _proffyContext.Proffys.Update(proffy);
            _proffyContext.SaveChanges();
            return proffy;
        }
    }
}
