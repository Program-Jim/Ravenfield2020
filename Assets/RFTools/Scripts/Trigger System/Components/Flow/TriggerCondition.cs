using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ravenfield.Trigger
{
    [AddComponentMenu("Trigger/Flow/Trigger Condition")]
    [TriggerDoc("When triggered, sends OnTrue if the condition is true, otherwise sends OnFalse")]
    public class TriggerCondition : TriggerReceiver
    {
		public enum Condition
		{
			ActorIsInAnyVehicle = 0,
			ActorIsInVehicle = 1,
			ActorIsInsideVolume = 2,
			ActorIsVehiclePilot = 3,

			SquadMemberCountGreaterOrEqual = 100,
			SquadIsOnTeam = 101,

			TeamHasActorsInsideVolume = 200,
			TeamAllActorsDead = 201,
			TeamActorsAliveGreaterOrEqual = 202,

			GameObjectIsActive = 300,

			MatchIsOver = 400,
		}

		[Header("Parameters")]
		public Condition condition;

		[ConditionalField("condition", Condition.ActorIsInAnyVehicle, Condition.ActorIsInVehicle, Condition.ActorIsInsideVolume, Condition.ActorIsVehiclePilot)]
		public ActorReference actor;

		[ConditionalField("condition", Condition.SquadMemberCountGreaterOrEqual, Condition.SquadIsOnTeam)]
		public SquadReference squad;

		[ConditionalField("condition", Condition.ActorIsInVehicle)]
		public VehicleReference vehicle;

		[ConditionalField("condition", Condition.GameObjectIsActive)]
		public GameObject targetGameObject;

		[ConditionalField("condition", Condition.TeamHasActorsInsideVolume, Condition.TeamAllActorsDead, Condition.TeamActorsAliveGreaterOrEqual, Condition.SquadIsOnTeam)]
		public Team team;

		[ConditionalField("condition", Condition.ActorIsInsideVolume, Condition.TeamHasActorsInsideVolume)]
		public TriggerVolume volume;

		[ConditionalField("condition", Condition.SquadMemberCountGreaterOrEqual, Condition.TeamActorsAliveGreaterOrEqual)]
		public int count;

		[Header("Sends")]
        public TriggerSend onTrue;
        public TriggerSend onFalse;
	}
}
