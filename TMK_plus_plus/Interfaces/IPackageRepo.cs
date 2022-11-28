using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMK_plus_plus.Classes;

namespace TMK_plus_plus.Interfaces
{
    public interface IPackageRepo
    {
        Task<List<PipePackage>> GetPackages();
        Task<bool> AddPackage(PipePackage pipe);
        Task<bool> DeletePackage(PipePackage pipe);
        Task<bool> UpdatePackage(PipePackage pipe);
    }
}

