using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Events/Trigger On Actor Enter Vehicle")]
	[TriggerDoc("Sends a signal every time an actor enters or leaves the target vehicle")]
    public class TriggerOnActorEnterVehicle : TriggerBaseComponent
    {
		public VehicleReference vehicle;

		[Header("Sends")]
        public TriggerSend onActorEntered;
        public TriggerSend onActorExited;
	}
}