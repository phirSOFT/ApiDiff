using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace phirSOFT.ApiDiff.Core
{
    public class ApiMember
    {
        public ApiAttributeCollection Attributes { get; }


    }

    public class ApiAttributeCollection : IReadOnlyCollection<ApiAttributeCollection>
    {
    }
}
