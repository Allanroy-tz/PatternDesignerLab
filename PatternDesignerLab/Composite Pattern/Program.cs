using System.Configuration;
namespace Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string departmentName = ConfigurationManager.AppSettings.Get("Department");
            string message = ConfigurationManager.AppSettings.Get("Message");
            University.Instance.教务部.FindDepartment(departmentName).Receive(message);
        }
    }
}
