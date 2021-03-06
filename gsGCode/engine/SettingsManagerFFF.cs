﻿using System.Collections.Generic;
using gs.info;
using Sutro.PathWorks.Plugins.API;

namespace gs.engines
{
    public class SettingsManagerFFF : SettingsManager<SingleMaterialFFFSettings>
    {
        public override List<SingleMaterialFFFSettings> FactorySettings { get
            {
                var factory_profiles = new List<SingleMaterialFFFSettings>();

                factory_profiles.Add(new RepRapSettings(RepRap.Models.Unknown));
                factory_profiles.AddRange(FlashforgeSettings.EnumerateDefaults());
                factory_profiles.AddRange(PrusaSettings.EnumerateDefaults());
                factory_profiles.AddRange(MakerbotSettings.EnumerateDefaults());
                factory_profiles.AddRange(MonopriceSettings.EnumerateDefaults());
                factory_profiles.AddRange(PrintrbotSettings.EnumerateDefaults());

                return factory_profiles;
            } }

        public override IUserSettingCollection<SingleMaterialFFFSettings> MachineUserSettings =>
            new MachineUserSettingsFFF<SingleMaterialFFFSettings>();

        public override IUserSettingCollection<SingleMaterialFFFSettings> MaterialUserSettings =>
            new MaterialUserSettingsFFF<SingleMaterialFFFSettings>();

        public override IUserSettingCollection<SingleMaterialFFFSettings> PrintUserSettings =>
            new PrintUserSettingsFFF<SingleMaterialFFFSettings>();
    }
}
