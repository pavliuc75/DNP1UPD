using System.Collections;
using System.Collections.Generic;
using DNPAssigment1.Models;

namespace DNPAssigment1.Data
{
    public interface IFamilyService
    {
        IList<Family> GetFamilies();

        void AddFamily(Family family);

        void RemoveFamily(int familyId);

        void Update(Family family);

        Family getSelectedFamily();

        void setSelectedFamily(Family family);
    }
}