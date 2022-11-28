using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMK_plus_plus.Classes;

namespace TMK_plus_plus.Interfaces
{
    public interface IPipeRepo
    {
        Task<List<Pipe>> GetPipes();
        Task<bool> AddPipe(Pipe pipe);
        Task<bool> DeletePipe(Pipe pipe);
        Task<bool> UpdatePipe(Pipe pipe);
    }
}
