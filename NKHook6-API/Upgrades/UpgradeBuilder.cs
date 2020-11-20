using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Unity;
using Assets.Scripts.Utils;
using NKHook6.Api.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.Api.Upgrades
{
    public class UpgradeBuilder
    {
        string name;
        int cost;
        int xpCost;
        SpriteReference icon;
        int path;
        int tier;
        int locked;
        string confirmation;
        string localizedNameOverride;
        public UpgradeBuilder() : this(Game.instance.getUpgradeModel("Sharp Shots")) { }
        public UpgradeBuilder(UpgradeModel baseModel)
        {
            this.name = baseModel.name;
            this.cost = baseModel.cost;
            this.xpCost = baseModel.xpCost;
            this.icon = baseModel.icon;
            this.path = baseModel.path;
            this.tier = baseModel.tier;
            this.locked = baseModel.locked;
            this.confirmation = baseModel.confirmation;
            this.localizedNameOverride = baseModel.localizedNameOverride;
        }
        public UpgradeBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public UpgradeBuilder SetCost(int cost)
        {
            this.cost = cost;
            return this;
        }
        public UpgradeBuilder SetXpCost(int xpCost)
        {
            this.xpCost = xpCost;
            return this;
        }
        public UpgradeBuilder SetIcon(SpriteReference icon)
        {
            this.icon = icon;
            return this;
        }
        public UpgradeBuilder SetPath(int path)
        {
            this.path = path;
            return this;
        }
        public UpgradeBuilder SetName(int tier)
        {
            this.tier = tier;
            return this;
        }
        public UpgradeBuilder SetLocked(int locked)
        {
            this.locked = locked;
            return this;
        }
        public UpgradeBuilder SetConfirmation(string confirmation)
        {
            this.confirmation = confirmation;
            return this;
        }
        public UpgradeBuilder SetLocalizedNameOverride(string localizedNameOverride)
        {
            this.localizedNameOverride = localizedNameOverride;
            return this;
        }
        public UpgradeModel build()
        {
            return new UpgradeModel(
                this.name,
                this.cost,
                this.xpCost,
                this.icon,
                this.path,
                this.tier,
                this.locked,
                this.confirmation,
                this.localizedNameOverride);
        }
    }
}
