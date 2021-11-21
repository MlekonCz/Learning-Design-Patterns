using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Patterns.Factory
{
    public static class AbilityFactory
    {
        private static Dictionary<string, Type> abilitiesByName;
        private static bool isInitialized => abilitiesByName != null;

        private static void InitializeFactory()
        {
            if (isInitialized){return;}

            
            var abilityTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes()
                .Where(myType => myType.IsSubclassOf(typeof(Ability)) && !myType.IsAbstract);

            abilitiesByName = new Dictionary<string, Type>();

            foreach (var type in abilityTypes)
            {
                var tempEffect = Activator.CreateInstance(type) as Ability;
                abilitiesByName.Add(tempEffect.Name, type);
            }
        }

        public static Ability GetAbility(string abilityType)
        {
            InitializeFactory();
            if (abilitiesByName.ContainsKey(abilityType))
            {
                Type type = abilitiesByName[abilityType];
                var ability = Activator.CreateInstance(type) as Ability;
                return ability;
            }

            return null;
        }

        internal static IEnumerable<string> GetAbilityName()
        {
            UnityEngine.Debug.Log("test");
            InitializeFactory();
            return abilitiesByName.Keys;    
        }
    }
}