﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNPAssigment1.Models;
using Models;

namespace DNPAssigment1.Data
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetFamilies();

        Task AddFamily(Family family);

        Task RemoveFamily(string streetName, int houseNumber);

        Task Update(Family family);

        Family getSelectedFamily();

        void setSelectedFamily(Family family);
    }
}