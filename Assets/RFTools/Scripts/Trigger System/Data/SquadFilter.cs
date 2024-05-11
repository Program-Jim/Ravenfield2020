using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [System.Serializable]
    public struct SquadFilter
    {
        public Filter[] filters;

        [System.Serializable]
        public struct Filter
        {
            public enum Type
            {
                IsPlayerSquad,
                MemberCountGreaterOrEqual,
                IsAlert,
                HasVehicle,
            }

            public Type type;

            [ConditionalField("type", Type.MemberCountGreaterOrEqual)] public int memberCount;
            public bool invertFilter;
        }
    }
}