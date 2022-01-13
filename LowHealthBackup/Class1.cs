using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CitizenFX.Core;
using FivePD.API;
using FivePD.API.Utils;
using static FivePD.API.Callout;


namespace LowHealthBackup
{
    public class LowHealth : FivePD.API.Plugin
    {

        internal LowHealth()
        {
            int health = CitizenFX.Core.Native.API.GetEntityHealth(Game.PlayerPed.NetworkId);
            if (health < 10)
            {
                FivePD.API.Utilities.RequestBackup(Utilities.Backups.Code99);
                
            }
        }

    }
}
