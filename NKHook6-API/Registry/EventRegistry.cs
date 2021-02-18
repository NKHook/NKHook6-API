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
                        if(attrib is Event)
                        {
                            ParameterInfo param = method.GetParameters()[0];
                            //Check the param is okay
                            if(param != null)
                            {
                                //Get the param type
                                Type paramType = param.ParameterType;
                                //Check if the param is an event
                                if(paramType.IsSubclassOf(typeof(EventBase)))
                                {
                                    //Get the attributes of the type
                                    foreach(Attribute classAttrib in paramType.GetCustomAttributes())
                                    {
                                        //If its an event header
                                        if(classAttrib is EventHeader)
                                        {
                                            EventHeader header = classAttrib as EventHeader;
                                            bool registered = false;
                                            foreach(string currentEventName in GetIDs())
                                            {
                                                //Use the dummy instance for the event name
                                                if (currentEventName == header.eventName)
                                                {
                                                    GetItem(currentEventName).Add(method);
                                                    registered = true;
                                                    continue;
                                                }
                                            }
                                            if (!registered)
                                            {
                                                throw new UnknownEventException(header.eventName);
                                            }
                                        }
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
            //Get the event's class
            Type eventClass = e.GetType();
            //Loop through the attributes
            foreach(Attribute classAttrib in eventClass.GetCustomAttributes())
            {
                //if the attribute is an event header
                if(classAttrib is EventHeader)
                {
                    EventHeader header = classAttrib as EventHeader;
                    //Get the callbacks
                    List<MethodInfo> callbacks = GetItem(header.eventName);
                    //Check that the callbacks are null/bad
                    if (callbacks == null)
                    {
                        continue;
                    }
                    if (callbacks.Count == 0)
                    {
                        continue;
                    }
                    //Call the callbacks
                    foreach(MethodInfo callback in callbacks)
                    {
                        callback.Invoke(null, new object[] { e });
                    }
                    return;
                }
            }
        }
    }
}
