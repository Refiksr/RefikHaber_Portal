using haberPortali1.Models;
using System.Linq.Expressions;

namespace haberPortali1.Models
{
    public interface IHaberRepository : IRepository<Haber>
    {
        void Guncelle(Haber haber);
        void Kaydet();
    }

}
