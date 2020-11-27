using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Bloons
{
    public interface IBloon
    {
        string getType();
        string getBaseType();
        Modifier[] getModifiers();
        Immunity[] getImmunities();
        int getMaxHealth();
        int getLeakDamage();
        bool isInvulnerable();
        float getSpeed();
        float getSpeedFrames();
        float getRadius();
        float getDanger();
        bool isRotateable();
        string getIcon();
        string getDisplay();
        string[] getTags();

        enum Modifier { Regen, Camo, Fortified, Moab }
        enum Immunity { Lead, Spikes, Glue, Ice }
    }
}
