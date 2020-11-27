using NKHook6.API.Towers;
using NKHook6.API.Towers.Upgrades;

namespace NKHook6.API.Registry
{
    public class TowerRegistry : Registry<ITower>
    {
        public static TowerRegistry instance = new TowerRegistry();
        public static TowerRegistry operator +(TowerRegistry inst, ITower tower) => (TowerRegistry)inst.register(tower.getType(), tower);
        public static TowerRegistry operator -(TowerRegistry inst, ITower tower) => (TowerRegistry)inst.unregister(tower.getType());
        public static ITower operator ^(TowerRegistry inst, string tower) => inst.getItem(tower);

        public void test()
        {
            instance += new TestTower();
            ITower t = instance ^ "Jo";
            instance -= new TestTower();
        }
    }

    public class TestTower : ITower
    {
        public double attackRadius()
        {
            throw new System.NotImplementedException();
        }

        public bool canPlaceOnLand()
        {
            throw new System.NotImplementedException();
        }

        public bool canPlaceOnPath()
        {
            throw new System.NotImplementedException();
        }

        public bool canPlaceOnWater()
        {
            throw new System.NotImplementedException();
        }

        public bool canTargetCamo()
        {
            throw new System.NotImplementedException();
        }

        public double getCost()
        {
            throw new System.NotImplementedException();
        }

        public string getType()
        {
            throw new System.NotImplementedException();
        }

        public IUpgrade getUpgrade(int path, int tier)
        {
            throw new System.NotImplementedException();
        }

        public bool isInfiniteRadius()
        {
            throw new System.NotImplementedException();
        }

        public bool rotateToTarget()
        {
            throw new System.NotImplementedException();
        }
    }
}