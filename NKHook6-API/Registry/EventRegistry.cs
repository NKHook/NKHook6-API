using System;
using System.Collections.Generic;
using System.Reflection;
using NKHook6.API.Events;

namespace NKHook6.API.Registry
{
    public class EventRegistry : Registry<List<MethodInfo>>
    {
        //Compat for old mods
        public static EventRegistry subscriber => instance;
        public static EventRegistry instance;
        internal EventRegistry() : base()
        {
            instance = this;

            //Unity
            CreateEvent("UpdateEvent"); //Updated
            CreateEvent("KeyPressEvent"); //Updated
            CreateEvent("KeyHeldEvent"); //Updated
            CreateEvent("KeyReleaseEvent"); //Updated

            //Bloons
            CreateEvent("BloonCreatedEvent"); //Updated
            CreateEvent("BloonDamagedEvent"); //Updated
            CreateEvent("BloonLeakedEvent"); //Updated
            CreateEvent("BloonDeletedEvent"); //Updated
            CreateEvent("BloonMoveEvent"); //Not possible yet, gotta do more investigation
            CreateEvent("BloonRotateEvent"); //Updated

            //Towers
            CreateEvent("TowerCreatedEvent"); //Updated
            CreateEvent("TowerDeletedEvent"); //Updated
            CreateEvent("TowerSoldEvent"); //Updated
            CreateEvent("TowerSelectedEvent"); //Updated
            CreateEvent("TowerDeselectedEvent"); //Updated
            CreateEvent("TowerUpgradeEvent"); //Updated

            //Player
            CreateEvent("CashChangedEvent"); //Updated
            CreateEvent("CashLostEvent"); //Updated
            CreateEvent("CashGainedEvent"); //Updated
            CreateEvent("HealthChangedEvent");
            CreateEvent("HealthLostEvent");
            CreateEvent("HealthGainedEvent");

            //Weapons
            CreateEvent("WeaponCreatedEvent"); //Updated
            CreateEvent("WeaponDeletedEvent"); //Updated

            //Game events
            CreateEvent("VictoryEvent"); //Updated
            CreateEvent("StartMatchEvent");
            CreateEvent("RoundStartEvent"); //Updated
            CreateEvent("RoundEndEvent"); //Updated
            CreateEvent("DefeatedEvent"); //Updated

            //Projectiles
            CreateEvent("ProjectileCreatedEvent");
            CreateEvent("ProjectileDeletedEvent");
            //CreateEvent("ProjectileModelChangedEvent");

            //TODO:
            /*CreateEvent("HealthChangedEvent");
            CreateEvent("HealthLostEvent");
            CreateEvent("HealthGainedEvent");
            CreateEvent("FastForwardToggleEvent");*/
        }

        public void CreateEvent(string eventName) => Register(eventName, new List<MethodInfo>());


        public void Listen(Type toSubscribe)
        {
            foreach(MethodInfo method in toSubscribe.GetMethods())
                if (method.IsStatic)
                    foreach (Attribute attrib in method.GetCustomAttributes())
                        if(attrib is EventAttribute)
                        {
                            bool registered = false;
                            EventAttribute eventAttrib = (EventAttribute)attrib;
                            foreach(string currentEventName in GetIDs())
                                if (currentEventName == eventAttrib.eventName)
                                {
                                    GetItem(currentEventName).Add(method);
                                    registered = true;
                                    continue;
                                }

                            if (!registered)
                                throw new UnknownEventException(eventAttrib.eventName);
                        }
        }
        public void DispatchEvent<T>(ref T e) where T : EventBase
        {
            foreach (string name in GetIDs())
            {
                List<MethodInfo> callbacks = GetItem(name);
                if (callbacks == null)
                    continue;
                if (callbacks.Count == 0)
                    continue;

                foreach(MethodInfo callback in callbacks)
                foreach (Attribute attrib in callback.GetCustomAttributes())
                    if (attrib is EventAttribute)
                    {
                        EventAttribute eventAttrib = (EventAttribute)attrib;
                        if (eventAttrib.eventName == e.eventName) callback.Invoke(null, new object[] { e });
                    }
            }
        }
    }
}
