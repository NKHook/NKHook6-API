using NKHook6.API.Bloons;

namespace NKHook6.API.Registry
{
    public class BloonRegistry : Registry<IBloon>
    {
        public static BloonRegistry instance = new BloonRegistry();
        public static BloonRegistry operator +(BloonRegistry inst, IBloon bloon) => (BloonRegistry)inst.register(bloon.getType(), bloon);
        public static BloonRegistry operator -(BloonRegistry inst, IBloon bloon) => (BloonRegistry)inst.unregister(bloon.getType());
        public static IBloon operator ^(BloonRegistry inst, string tower) => inst.getItem(tower);

        public void test()
        {
            instance += new TestBloon();
            IBloon testBloon = instance ^ "TestBloon";
            instance -= new TestBloon();
        }
    }

    public class TestBloon : IBloon
    {
        public string getBaseType()
        {
            throw new System.NotImplementedException();
        }

        public float getDanger()
        {
            throw new System.NotImplementedException();
        }

        public string getDisplay()
        {
            throw new System.NotImplementedException();
        }

        public string getIcon()
        {
            throw new System.NotImplementedException();
        }

        public IBloon.Immunity[] getImmunities()
        {
            throw new System.NotImplementedException();
        }

        public float getLeakDamage()
        {
            throw new System.NotImplementedException();
        }

        public float getMaxHealth()
        {
            throw new System.NotImplementedException();
        }

        public IBloon.Modifier[] getModifiers()
        {
            throw new System.NotImplementedException();
        }

        public float getRadius()
        {
            throw new System.NotImplementedException();
        }

        public float getSpeed()
        {
            throw new System.NotImplementedException();
        }

        public float getSpeedFrames()
        {
            throw new System.NotImplementedException();
        }

        public string[] getTags()
        {
            throw new System.NotImplementedException();
        }

        public string getType()
        {
            throw new System.NotImplementedException();
        }

        public bool isInvulnerable()
        {
            throw new System.NotImplementedException();
        }

        public bool isRotateable()
        {
            throw new System.NotImplementedException();
        }
    }
}
