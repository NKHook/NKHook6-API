﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API
{
    public class Registry<T>
    {
        public static Registry<T> operator +(Registry<T> inst, T item) => (Registry<T>)inst.Register(item.ToString(), item);
        public static Registry<T> operator -(Registry<T> inst, T item) => (Registry<T>)inst.Unregister(item.ToString());
        public static T operator ^(Registry<T> inst, string item) => inst.GetItem(item);

        private Dictionary<string, T> registryItems = new Dictionary<string, T>();
        public Registry()
        {
        }


        /// <summary>
        /// Registers a new item into the target registry
        /// </summary>
        /// <param name="item">Item to register</param>
        public virtual Registry<T> Register(string ID, T item)
        {
            if (!registryItems.ContainsKey(ID))
            {
                this.registryItems.Add(ID, item);
                return this;
            }
            throw new RegistryIDTakenException(ID);
        }

        /// <summary>
        /// Unregisters something from the registry. WARNING: Probably super duper unsafe for certain things
        /// </summary>
        /// <param name="ID"></param>
        public virtual Registry<T> Unregister(string ID)
        {
            foreach(string key in registryItems.Keys)
            {
                if(key == ID)
                {
                    return this;
                }
            }
            throw new RegistryIDNotFoundException(ID);
        }


        /// <summary>
        /// Gets a given registry item by it's ID
        /// </summary>
        /// <param name="ID">The ID of the item to retrieve</param>
        /// <returns>The registry item</returns>
        public virtual T GetItem(string ID)
        {
            return registryItems[ID];
        }

        /// <summary>
        /// Gets all items in the registry
        /// </summary>
        /// <returns>All items known to the registry</returns>
        public virtual T[] GetItems()
        {
            return registryItems.Values.ToArray();
        }



        /// <summary>
        /// Gets all known IDs of the Registry
        /// </summary>
        /// <returns>All known Registry IDs</returns>
        public virtual string[] GetIDs()
        {
            return registryItems.Keys.ToArray();
        }
    }

    public class RegistryIDTakenException : Exception
    {
        public RegistryIDTakenException(string problematicId) : base("The given registry ID \"" + problematicId + "\" was already registered.") { }
    }
    public class RegistryIDNotFoundException : Exception
    {
        public RegistryIDNotFoundException(string unknownId) : base("The given registry ID, \"" + unknownId + "\" doesn't exist!") { }
    }
}
