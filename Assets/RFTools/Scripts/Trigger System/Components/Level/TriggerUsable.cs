using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [AddComponentMenu("Trigger/Level/Trigger Usable")]
    [TriggerDoc("Sends OnUse when the player presses the Use button while facing this object's collider. Sends OnKick when player kicks this object's collider. Choose between Use or Kick with the Type value.")]
    public class TriggerUsable : TriggerBaseComponent
    {
        public const int LAYER = 24;

		public enum Type
		{
			Use,
			Kick,
			Both,
		}

		public enum TooltipInteraction
		{
			HideOnUseReappear,
			HideOnUseForever,
			AlwaysShow,
		}

		public Type type;

		[Header("Tooltip")]
		public bool showTooltip;
		[ConditionalField("showTooltip", true)] public string tooltipLabel = "";
		[ConditionalField("showTooltip", true)] public TooltipInteraction tooltipInteraction = TooltipInteraction.HideOnUseReappear;

		[Header("Sends")]
		public TriggerSend onUse;
		public TriggerSend onKick;
	}
}
