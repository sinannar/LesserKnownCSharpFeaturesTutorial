using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesserKnownCSharpFeaturesTutorial
{
    /*
     * DebuggerDisplay attribute controls how a  type or member is displayed in the debugger windows. 
     * For example, consider the below class with DebuggerDisplay attribute.
    */
    [DebuggerDisplay("Name of employee is {FirstName} {Surname} and his department is {Department}")]
    class Employee
    {
        /*
         * DebuggerBrowser attribute can be used to further control how the properties and fields appear in the debugger window. 
         * This attribute takes DebuggerBrowserState enum, which defines  states: Never, Collapsed and RootHidden
         */
        [DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
        public string FirstName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Surname { get; set; }

        public string Department { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<string> Reportees { get; set; }
    }
}
