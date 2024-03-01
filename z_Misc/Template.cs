using UnityEngine;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("xyz")]
    public class xyzClass
    {
        public xyz xyz { get; private set; }
        public xyzClass(xyz c_xyz) => xyz = c_xyz;
    }
}

/*
    [ScriptClass("xyz")]
    public class xyzClass
    {
        public xyz xyz { get; private set; }
        public xyzClass(xyz c_xyz) => xyz = c_xyz;
    }
*/