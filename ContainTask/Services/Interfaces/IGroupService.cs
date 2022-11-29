using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainTask.Services.Interfaces
{
    internal interface IGroupService
    {
        public void Add(string groupNo);
        public void GetAll();
        public void GetById(string id);
        public void Update(int id,string no);

    }
}
