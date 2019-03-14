using System;
using System.Collections.ObjectModel;
using System.Text;

namespace phirSOFT.ApiDiff.Core
{
    public class Api
    {
        public Version Version { get; }

        public AssemblyDiff.DifferenceCollection CalculateDifference(Api other)
        {

        }

        public ApiMemberCollection ApiMembers { get; }
    }
}
