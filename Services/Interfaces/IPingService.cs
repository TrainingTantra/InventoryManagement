using InternalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IPingService
    {
        string Ping();
        IEnumerable<StudentDetails>? StudentDetails(int id);
    }
}
