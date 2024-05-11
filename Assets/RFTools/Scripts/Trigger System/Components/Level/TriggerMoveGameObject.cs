using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Level/Trigger Move GameObject")]
	[TriggerDoc("When triggered, Moves the ObjectToMove to the target point or object.")]
	public class TriggerMoveGameObject : TriggerReceiver
    {
		public enum TargetType
		{
			Transform,
			Actor,
			Vehicle,
		}

		[Header("Parameters")]
		public Transform objectToMove;

		[Header("Move To")]
		public TargetType target;

		[ConditionalField("target", TargetType.Transform)] public Transform destination;
		[ConditionalField("target", TargetType.Actor)] public ActorReference actor;
		[ConditionalField("target", TargetType.Vehicle)] public VehicleReference vehicle;
		

		public bool makeNewParent = false;

		[Header("Sends")]
		public TriggerSend onSuccess;
		public TriggerSend onFail;
	}
}