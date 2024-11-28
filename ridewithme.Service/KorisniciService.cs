using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;

namespace ridewithme.Service
{
    public class KorisniciService : IKorisniciService
    {
        public RidewithmeContext Context { get; set; }

        public IMapper Mapper { get; set; }
        public KorisniciService(RidewithmeContext dbContext, IMapper mapper )
        {
            Context = dbContext;
            Mapper = mapper;
        }
        public Model.PagedResult<Model.Korisnici> GetList(KorisniciSearchObject searchObject)
        {
            List<Model.Korisnici> resultList = new List<Model.Korisnici>();

            var query = Context.Korisnicis.AsQueryable();

            if(!string.IsNullOrWhiteSpace(searchObject?.ImeGTE))
            {
                query = query.Where(x => x.Ime.StartsWith(searchObject.ImeGTE));
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.PrezimeGTE))
            {
                query = query.Where(x => x.Prezime.StartsWith(searchObject.PrezimeGTE));
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.Email))
            {
                query = query.Where(x => x.Email == searchObject.Email);
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme == searchObject.KorisnickoIme);
            }

            if(searchObject.IsKorisniciIncluded == true) 
            {
                query.Include(x => x.KorisniciUloge).ThenInclude(x => x.Uloga);
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.OrderBy))
            {
                var items = searchObject.OrderBy.Split(' ');
                if (items.Length > 2 || items.Length == 0)
                {
                    throw new ApplicationException("Mozete sortirati samo po dva polja.");
                }
                if (items.Length == 1)
                {
                    query = query.OrderBy("@0", searchObject.OrderBy);
                }
                else
                {
                    query = query.OrderBy(string.Format("{0} {1}", items[0], items[1]));
                }

            }

            int count = query.Count();

            if (searchObject?.Page.HasValue == true && searchObject?.PageSize.HasValue == true)
            {
                query = query.Skip(searchObject.Page.Value * searchObject.PageSize.Value).Take(searchObject.PageSize.Value);
            }

            

            var korisnici = query.ToList();

            resultList = Mapper.Map(korisnici, resultList);

            Model.PagedResult<Model.Korisnici> result = new Model.PagedResult<Model.Korisnici>();

            result.Results = resultList;
            result.Count = count;

            return result;

        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            if (request.Lozinka != request.LozinkaPotvrda)
            {
                throw new Exception("Lozinka i LozinkaPotvrda se moraju podudarati.");
            }

            Database.Korisnici entity = new Database.Korisnici();

            Mapper.Map(request, entity);

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);

            var korisnikRole = Context.Uloges.FirstOrDefault(x => x.Naziv.Equals("Korisnik"))?.Id;

            if (korisnikRole == null)
            {
                throw new Exception("Interna greska.");
            }

            Context.Add(entity);
            Context.SaveChanges();

            return Mapper.Map<Model.Korisnici>(entity);
        }

        public static string GenerateSalt()
        {
            var byteArray = RandomNumberGenerator.GetBytes(16);


            return Convert.ToBase64String(byteArray);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

    }
}
