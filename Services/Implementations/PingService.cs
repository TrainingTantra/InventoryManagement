using CommonData;
using InternalModels;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Services
{
    public class PingService:IPingService
    {
        public string Ping()
        {
            return "Hi..";
        }
        public IEnumerable<StudentDetails>? StudentDetails(int id)
        {
            var mockData = StudentMock.StudentMockData();
            var res = mockData?.StuDetails?.Where(x => x.Id == id);
            return res;
        }
    }
}