using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DABhandin3Del2.Interfaces;
using DABhandin3Del2.Models;
using todo;

namespace DABhandin3Del2.Repo
{
    public class PersonRepo : DocumentDBRepository<Person>, IPersonRepo
    {
    }
}
