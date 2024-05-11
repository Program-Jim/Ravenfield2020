using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Events/Trigger On Captured")]
	[TriggerDoc("Sends OnCaptured when the CapturePoint is captured by the specified Team.")]
	public class TriggerOnCaptured : TriggerBaseComponent
	{
		public CapturePoint capturePoint;
		public Team team;

		public TriggerSend onCaptured;

		private void Reset() {
			this.capturePoint = GetComponent<CapturePoint>();
		}
	}
}