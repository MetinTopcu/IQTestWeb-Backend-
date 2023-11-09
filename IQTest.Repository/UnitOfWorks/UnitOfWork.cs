using IQTest.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork// repository de db verilerinde değişiklik yapıldığında tek tek yapmayıp 
                                         // bütün verileri toplayıp en son savechange savechangeasync yapmayı sağlayan yerdir.
                                         // eğer bir kısımda hata olursa hiçbir değişiklik uygulanmaz.
    {

        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
