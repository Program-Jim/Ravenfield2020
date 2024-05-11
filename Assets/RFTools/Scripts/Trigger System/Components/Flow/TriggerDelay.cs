using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Flow/Trigger Delay")]
	[TriggerDoc("When triggered, sends OnDelayDone after the specified delay time")]
	public class TriggerDelay : TriggerReceiver
	{
		public enum SignalType
		{
			MultipleSignals,
			OneAtATime,
		}

		public SignalType signalType;
		public float delayTime = 1f;
		public float randomAdd = 0f;
		[InspectorName("On Delay Done")] public TriggerSend onDelayDoneTrigger;
	}
}
