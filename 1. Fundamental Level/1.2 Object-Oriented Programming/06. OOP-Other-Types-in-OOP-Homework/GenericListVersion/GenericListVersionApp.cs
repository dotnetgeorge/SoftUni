using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericListApp.Data;

namespace GenericListVersion
{
    [Version("1.0")]
    class GenericListVersionApp
    { 
        static void Main(string[] args)
        {
            Type type = typeof(GenericListVersionApp);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAtribute in allAttributes)
            {
                Console.WriteLine("Version: {0} ", versionAtribute.Version);
            }

        }
    }
}
