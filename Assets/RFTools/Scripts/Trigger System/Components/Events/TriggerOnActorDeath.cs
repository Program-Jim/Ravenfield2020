using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [AddComponentMenu("Trigger/Events/Trigger On Actor Death")]
    [TriggerDoc("Sends OnDeath when an actor from the specified actor group dies.")]
    public class TriggerOnActorDeath : TriggerBaseComponent
    {
        public ActorFilter filter;
        public bool ignoreSilentKills = false;

        [SignalContextProvider(ContextType.Actor)] public TriggerSend onDeath;
    }
}