using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace phirSOFT.ApiDiff.Core
{
    public class AssemblyDiff
    {
        public static DifferenceCollection CalculateDifferences(Assembly before, Assembly after)
        {
            var differences = new DifferenceCollection();

            var beforeTypes = new HashSet<Type>(before.ExportedTypes);
            var afterTypes = new HashSet<Type>(after.ExportedTypes);


        }

        public static DifferenceCollection CalculateDifference(Type before, Type after)
        {
            var differences = new DifferenceCollection();
            
        }

        public static DifferenceCollection CalculateClassTypeDifference(Type before, Type after)
        {
            
        }

        public class DifferenceCollection : Collection<Difference>
        {

        }

        public class Difference
        {
            public bool Breaking { get; }
        }

    }
}
