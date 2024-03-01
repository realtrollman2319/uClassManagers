using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Classes
{
    [ScriptClass("Useable")]
    public class UseableClass
    {
        public Useable useable { get; private set; }
        public UseableClass(Useable c_Useable) => useable = c_Useable;

        [ScriptProperty("canInspect")]
        public bool CanInspect => useable.canInspect;

        [ScriptProperty("isUseableShowingMenu")]
        public bool IsUseableShowingMenu => useable.isUseableShowingMenu;

        [ScriptFunction("dequip")]
        public void Dequip()
        {
            useable.dequip();
        }

        [ScriptFunction("equip")]
        public void Equip()
        {
            useable.equip();
        }

        [ScriptFunction("simulate")]
        public void Simulate(uint simulation, bool inputSteady)
        {
            useable.simulate(simulation, inputSteady);
        }

        [ScriptFunction("startPrimary")]
        public bool StartPrimary()
        {
            return useable.startPrimary();
        }

        [ScriptFunction("startSecondary")]
        public bool StartSecondary()
        {
            return useable.startSecondary();
        }

        [ScriptFunction("stopPrimary")]
        public void StopPrimary()
        {
            useable.stopPrimary();
        }

        [ScriptFunction("stopSecondary")]
        public void StopSecondary()
        {
            useable.stopSecondary();
        }

        [ScriptFunction("tick")]
        public void Tick()
        {
            useable.tick();
        }

        [ScriptFunction("tock")]
        public void Tock(uint clock)
        {
            useable.tock(clock);
        }

        [ScriptFunction("updateState")]
        public void UpdateState(ExpressionValue newState)
        {
            useable.updateState(ByteTool.FromExpressionValue(newState));
        }
    }
}
