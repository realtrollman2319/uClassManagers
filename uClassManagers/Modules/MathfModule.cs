using uScript.API.Attributes;

namespace uClassManagers.Modules
{
    [ScriptModule("Mathf")]
    public static class MathfModule
    {
        [ScriptFunction("add")]
        public static float Add(float n1, float n2) => n1 + n2;

        [ScriptFunction("subtract")]
        public static float Subtract(float n1, float n2) => n1 - n2;

        [ScriptFunction("multiply")]
        public static float Multiply(float n1, float n2) => n1 * n2;

        [ScriptFunction("divide")]
        public static float Divide(float n1, float n2) => n1 / n2;
    }
}
