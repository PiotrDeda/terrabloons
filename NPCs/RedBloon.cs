using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace TerraBloons.NPCs
{
	public class RedBloon : ModNPC
	{
		public override void SetDefaults()
		{
			NPC.width = 22;
			NPC.height = 28;
			NPC.damage = 5;
			NPC.lifeMax = 1000;
			NPC.HitSound = SoundID.NPCDeath63;
			NPC.DeathSound = SoundID.NPCDeath63;
			NPC.value = 1.0f;
			NPC.aiStyle = 14; // Bat AI
			NPC.noGravity = true;
			NPC.npcSlots = 0.5f;
			NPC.scale = 0.925f;
			NPC.buffImmune[BuffID.Bleeding] = true;
			NPC.buffImmune[BuffID.Poisoned] = true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) => SpawnCondition.OverworldDaySlime.Chance * 0.25f;
		public override void ModifyNPCLoot(NPCLoot npcLoot) => npcLoot.Add(ItemDropRule.NormalvsExpert(ItemID.ShinyRedBalloon, 1000, 500));
		//public override void OnKill() => NPC.NewNPC(NPC.GetSpawnSourceForNPCFromNPCAI(), (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<RedBloon>());

		public override void ModifyHitByProjectile(Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			switch (projectile.type)
			{
				case ProjectileID.Shuriken:
				case ProjectileID.ThrowingKnife:
				case ProjectileID.PoisonedKnife:
				case ProjectileID.BoneDagger:
				case ProjectileID.StarAnise:
				case ProjectileID.SpikyBall:
				case ProjectileID.JavelinFriendly:
				case ProjectileID.FrostDaggerfish:
				case ProjectileID.BoneJavelin:
				case ProjectileID.NailFriendly:
				case ProjectileID.PoisonDart:
				case ProjectileID.CrystalDart:
				case ProjectileID.CursedDart:
				case ProjectileID.IchorDart:
					damage *= 2;
					break;
			}
		}
	}
}
