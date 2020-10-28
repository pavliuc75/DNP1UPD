using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNPAssigment1.Models;

namespace DNPAssigment1.Data
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetFamilies();

        Task AddFamily(Family family);

        Task RemoveFamily(int familyId);

        Task Update(Family family);

        Family getSelectedFamily();

        void setSelectedFamily(Family family);
    }
}