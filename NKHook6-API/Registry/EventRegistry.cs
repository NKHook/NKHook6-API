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
            //Loop through the methods in the class to listen
            foreach(MethodInfo method in toSubscribe.GetMethods())
            {
                //All event methods *must* be static
                if (method.IsStatic)
                {
                    //Loop through the method attributes
                    foreach (Attribute attrib in method.GetCustomAttributes())
                    {
                        //If the attribute is an EventAttribute
                        if(attrib is EventAttribute)
                        {
                            ParameterInfo param = method.GetParameters()[0];
                            //Check the param is okay
                            if(param != null)
                            {
                                Type paramType = param.ParameterType;
                                if(paramType.IsSubclassOf(typeof(EventBase)))
                                {
                                    bool registered = false;
                                    foreach(string currentEventName in GetIDs())
                                    {
                                        //Use the dummy instance for the event name
                                        if (currentEventName == dummyInstance.eventName)
                                        {
                                            GetItem(currentEventName).Add(method);
                                            registered = true;
                                            continue;
                                        }
                                    }
                                    if (!registered)
                                    {
                                        throw new UnknownEventException(dummyInstance.eventName);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Invalid event parameter type! Must be an EventBase!");
                                }
                            }
                            else
                            {
                                throw new Exception("The event method doesn't have any valid paramters!");
                            }
                        }
                    }
                }
            }
        }
        public void DispatchEvent<T>(ref T e) where T : EventBase
        {
            foreach (string name in GetIDs())
            {
                List<MethodInfo> callbacks = GetItem(name);
                if (callbacks == null)
                {
                    continue;
                }
                if (callbacks.Count == 0)
                {
                    continue;
                }
                foreach(MethodInfo callback in callbacks)
                {
                    foreach (Attribute attrib in callback.GetCustomAttributes())
                    {
                        if (attrib is EventAttribute)
                        {
                            ParameterInfo param = callback.GetParameters()[0];
                            if(param != null)
                            {
                                Type paramType = param.ParameterType;
                                if(paramType.IsSubclassOf(typeof(EventBase)))
                                {
                                    EventBase dummyInstance = (EventBase)Activator.CreateInstance(paramType);
                                    if (dummyInstance.eventName == e.eventName)
                                    {
                                        callback.Invoke(null, new object[] { e });
                                    }
                                }
                                else
                                {
                                    throw new Exception("Listen call checks failed! Invalid event parameter type! Must be an EventBase!");
                                }
                            }
                            else
                            {
                                throw new Exception("Listen call checks failed! The event callback doesn't have any valid paramters!");
                            }
                        }
                    }
                }
            }
        }
    }
}
