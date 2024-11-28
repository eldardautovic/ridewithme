using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public abstract class BaseCRUDService<TModel, TSearch, TDbEntity, TInsert, TUpdate> : BaseService<TModel, TSearch, TDbEntity> where TModel : class where TSearch : BaseSearchObject where TDbEntity : class, ICRUDService<TModel, TSearch, TInsert, TUpdate>
    {
        public BaseCRUDService(RidewithmeContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public TModel Insert(TInsert request)
        {
            //if (request.Lozinka != request.LozinkaPotvrda)
            //{
            //    throw new Exception("Lozinka i LozinkaPotvrda se moraju podudarati.");
            //}

            TDbEntity entity = Mapper.Map<TDbEntity>(request);

            //entity.LozinkaSalt = GenerateSalt();
            //entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);

            //var korisnikRole = Context.Uloges.FirstOrDefault(x => x.Naziv.Equals("Korisnik"))?.Id;

            //if (korisnikRole == null)
            //{
            //    throw new Exception("Interna greska.");
            //}

            BeforeInsert(request, entity);

            Context.Add(entity);
            Context.SaveChanges();

            return Mapper.Map<TModel>(entity);
        }

        public void BeforeInsert(TInsert request, TDbEntity entity) { }

        public TModel Update(int id, TUpdate request)
        {
            var set = Context.Set<TDbEntity>();

            var entity = set.Find(id);

            Mapper.Map(request, entity);

            BeforeUpdate(request, entity);

            Context.SaveChanges();

            return Mapper.Map<TModel>(entity);
        }
        public void BeforeUpdate(TUpdate request, TDbEntity entity) { }

    }
}
