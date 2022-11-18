using System.Configuration;
namespace Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string departmentName = ConfigurationManager.AppSettings.Get("Department");
            string message = ConfigurationManager.AppSettings.Get("Message");
            Tz20200440718_University.Instance.教务部.FindDepartment(departmentName).Receive(message);
        }
    }
}
