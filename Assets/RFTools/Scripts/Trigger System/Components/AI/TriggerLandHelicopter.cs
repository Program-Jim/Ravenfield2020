using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [AddComponentMenu("Trigger/AI/Trigger Land Helicopter")]
	[TriggerDoc("When Triggered, The squad will proceed to land their helicopter at the specified position. Sends OnLanded when the landing has completed.")]
	public class TriggerLandHelicopter : TriggerReceiver
    {
		public enum Type
		{
			Land,
			TakeOff,
		}

		public SquadReference squad;

		public Type type = Type.Land;
		[ConditionalField("type", Type.Land)] public Transform landPosition;
		[ConditionalField("type", Type.Land)] public TriggerSend onLanded;
	}
}
