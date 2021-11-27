﻿using LenovoLegionToolkit.Lib.Utils;

namespace LenovoLegionToolkit.Lib.Features
{
    public class PowerModeFeature : AbstractWmiFeature<PowerModeState>
    {
        public PowerModeFeature() : base("SmartFanMode", 1, "IsSupportSmartFan") { }

        public override void SetState(PowerModeState state)
        {
            base.SetState(state);

            OS.SetPowerPlan(state.GetPowerPlanGuid());
        }
    }
}