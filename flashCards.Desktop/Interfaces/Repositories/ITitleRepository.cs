using flashCards.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashCards.Desktop.Interfaces.Repositories
{
    public interface ITitleRepository : IGenericRepository<Title>
    {
        Task<IList<Title>> GetAllByUserIdAsync(long userId, int skip, int take);

        Task<IList<Title>> GetAllAsync();
    }
}