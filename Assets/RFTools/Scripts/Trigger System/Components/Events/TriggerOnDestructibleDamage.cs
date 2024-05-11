using UnityEngine;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Level/Trigger On Destructible Damage")]
	[TriggerDoc("Sends a signal when the specificed destructible takes damage or is destroyed.")]
	public class TriggerOnDestructibleDamage : TriggerBaseComponent
	{
		public Destructible destructible;

		public TriggerSend onDestructibleDamaged;
		public TriggerSend onDestructibleDestroyed;

		private void Reset() {
			this.destructible = GetComponent<Destructible>();
		}
	}
}