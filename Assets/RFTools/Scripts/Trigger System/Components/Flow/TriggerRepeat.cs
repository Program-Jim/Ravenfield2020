using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Flow/Trigger Repeat")]
	[TriggerDoc("When triggered, Repeatedly sends a signal")]
	public class TriggerRepeat : TriggerReceiver
	{
		public bool repeatForever = false;
		[ConditionalField("repeatForever", false)] public int repeatCount = 10;
		public float repeatDelay = 0f;
		public TriggerSend send;
	}
}