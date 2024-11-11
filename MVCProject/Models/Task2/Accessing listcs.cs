using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using System.Xml.Linq;

namespace MVCProject.Models.Task2
{
    public class Accessing_listcs
    {
        public ListDatamodel Accessinglistcs(int id)
        {
            ListDatamodel listDatamodel = new ListDatamodel();

            switch (id)
            {
                case 1:
                    listDatamodel = new ListDatamodel()
                    {
                        Name = "BOB",
                        Description = "CS Senior Engineer",
                        Experince = 7.5,
                    };
                    break;
                case 2:
                    listDatamodel = new ListDatamodel()
                    {
                        Name = "Alice",
                        Description = "CS Senior Associate",
                        Experince = 6.0,
                    };
                    break;
                case 3:
                    listDatamodel = new ListDatamodel()
                    {
                        Name = "Trent",
                        Description = "CSE Analyst",
                        Experince = 5.5,
                    };
                    break;
                case 4:
                    listDatamodel = new ListDatamodel()
                    {
                        Name = "Eve",
                        Description = "CS Associate Engineer",
                        Experince = 4.0,
                    };
                    break;
            }
            return listDatamodel;
        }
    }
}
