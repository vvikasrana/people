using System;
using System.Collections.Generic;
using PeopleApi.Model;

namespace PeopleApi.Repository
{
    public interface IPeopleRepository
    {
        void Add(People people);
        void Update(int id, People people);
        List<People> GetList();

        People Find(int personId);
    }
}
