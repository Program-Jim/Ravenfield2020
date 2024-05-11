using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Flow/Trigger Pick One")]
	[TriggerDoc("When triggered, sends a signal to a single destination")]
	public class TriggerPickOne : TriggerReceiver
    {
		[AutoPopulateChildReceivers]
		public TriggerSend sends;
    }
}