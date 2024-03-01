using SDG.Unturned;
using uScript.API.Attributes;

namespace uClassManagers.Classes
{
    [ScriptClass("HotkeyInfo")]
    public class HotkeyInfoClass
    {
        public HotkeyInfo hotkeyInfo { get; private set; }
        public HotkeyInfoClass(HotkeyInfo c_HotkeyInfo) => hotkeyInfo = c_HotkeyInfo;

        [ScriptProperty("id")]
        public ushort Id => hotkeyInfo.id;

        [ScriptProperty("page")]
        public byte Page => hotkeyInfo.page;

        [ScriptProperty("x")]
        public byte X => hotkeyInfo.x;

        [ScriptProperty("y")]
        public byte Y => hotkeyInfo.y;
    }
}