using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [AddComponentMenu("Trigger/Events/Trigger On Actor Enter Volume")]
    [TriggerDoc("Sends OnEnter/OnExit when an actor passing the filter enters/exits the trigger volume.")]
    public class TriggerOnActorEnter : TriggerBaseComponent
    {
        public TriggerVolume triggerVolume;

        public ActorFilter filter;

        [SignalContextProvider(ContextType.Actor)] public TriggerSend onEnter;
        [SignalContextProvider(ContextType.Actor)] public TriggerSend onExit;

		private void Reset() {
            // Find any trigger volume component on the same game object
            this.triggerVolume = GetComponent<TriggerVolume>();
		}
	}
}