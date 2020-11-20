using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerBaseLib;

namespace NKHook6.Api.Upgrades
{
    public class UpgradeRegistry : Registry<UpgradeModel>
    {
        //The registry instance
        public static UpgradeRegistry instance;
        internal UpgradeRegistry()
        {
            instance = this;
        }

        /// <summary>
        /// Register a new upgrade model with a given ID
        /// </summary>
        /// <param name="ID">The ID/Name of the upgrade</param>
        /// <param name="item">The actual model to be registered</param>
        public override void register(string ID, UpgradeModel item)
        {
            //Store it using the base function
            base.register(ID, item);

            //Get game instance
            Game game = Game.instance;
            //Get upgrade list
            var p_towerList = game.model.upgrades;
            //Create a managed version of the upgrade list to modify it easily
            List<UpgradeModel> upgradeList = new List<UpgradeModel>(p_towerList.ToArray());
            //Add the model
            upgradeList.Add(item);
            //Make the list an il2cpp array again
            Il2CppReferenceArray<UpgradeModel> m_upgradeList = new Il2CppReferenceArray<UpgradeModel>(upgradeList.ToArray());
            //Set the list of upgrades
            game.model.upgrades = m_upgradeList;
        }
    }
}
