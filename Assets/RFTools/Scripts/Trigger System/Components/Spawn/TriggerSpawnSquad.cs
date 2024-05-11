using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ravenfield.Data;

namespace Ravenfield.Trigger
{
	[AddComponentMenu("Trigger/Spawn/Trigger Spawn Squad")]
	[TriggerDoc("When triggered, Spawns an AI squad.")]
	public class TriggerSpawnSquad : TriggerReceiver
	{
		public enum RespawnType
		{
			Never,
			Automatically,
		}

		public enum CapType
		{
			IgnoreCap,
			AwaitCap,
			DontSpawn,
		}

		[Header("Actors")]
		public Team team;
		public RespawnType respawnType = RespawnType.Never;
		[ConditionalField("respawnType", RespawnType.Automatically)] public float autoRespawnTime = 10f;

		public int squadMembersToSpawn = 4;
		public ScriptedPathGroup pathGroup;
		public bool spawnAtPathGroupNodes;

		[Header("Enemy Detection")]
		public TriggerDetectionGroup detectionGroup;
		public TriggerSend onSquadAlerted;

		[Header("Squad AI State")]
		public SquadState squadState;
		public SpawnInfo[] squadMemberInfo;
		public AiInfo[] squadMemberAIInfo;

		[Header("Cap Actor Count")]
		public CapType aliveActorsOnTeamCap;
		[ConditionalField("aliveActorsOnTeamCap", CapType.IgnoreCap, invert = true)] public int capCount = 30;

		public TriggerSend onSpawnCompleteTrigger;

		void Reset() {

			this.squadMemberInfo = new SpawnInfo[] {
				new SpawnInfo() {
					loadout = new SpawnInfo.LoadoutInfo() {
						useAutoPick = true,
						autoPickStrategy = new AiActorController.LoadoutPickStrategy() {
							type = default,
							distance = WeaponManager.WeaponEntry.Distance.Mid,
						}
					},

					hp = 100f,
					dropsAmmoWhenKicked = false,
					canDeployParachute = true,
				}
			};

			this.squadMemberAIInfo = new AiInfo[] {
				new AiInfo() {
					modifier = AiActorController.Modifier.Default,
					skill = AiActorController.SkillLevel.Normal,
				}
			};

			this.squadState = SquadState.Default;
		}

		[System.Serializable]
		public struct SquadState
		{
			public static SquadState Default = new SquadState() {
				isAlert = true,
				walkWhileUnalerted = true,
				slowDetection = false,
				leavePathGroupWhenAlerted = false,
				allowLeaveVehicleWhenStuck = true,
				followersInvisibleToUnalertedEnemies = true,
			};

			public bool isAlert;
			public bool walkWhileUnalerted;
			public bool slowDetection;
			public bool leavePathGroupWhenAlerted;
			public bool allowLeaveVehicleWhenStuck;
			public bool followersInvisibleToUnalertedEnemies;
			public Squad.EngagementRule engagementRule;

			public OrderDefinition order;
		}

		[System.Serializable]
		public struct SpawnInfo
		{
			public string overrideName;
			public Transform overrideSpawnPoint;
			public LoadoutInfo loadout;

			public ActorSkinData overrideSkin;

			public EquippedSlot equipped;
			public Health health;
			public float hp;

			public bool attackersIgnoreEngagementRule;
			public bool dropsAmmoWhenKicked;
			public bool canDeployParachute;

			public enum Health
			{
				Normal,
				HeroArmor,
				Invulnerable,
			}

			public enum EquippedSlot
			{
				Primary,
				Secondary,
				Gear1,
				Gear2,
				Gear3,
				Nothing,
			}

			[System.Serializable]
			public struct LoadoutInfo
			{
				public bool useAutoPick;
				public AiActorController.LoadoutPickStrategy autoPickStrategy;
				public string primary, secondary, gear1, gear2, gear3;
				public WeaponStates weaponStates;

				[System.Serializable]
				public struct WeaponStates
				{
					public WeaponState primary, secondary, gear1, gear2, gear3;
				}
			}
		}

		[System.Serializable]
		public struct AiInfo
		{
			public AiActorController.SkillLevel skill;
			public AiActorController.Modifier modifier;
		}
	}

}
