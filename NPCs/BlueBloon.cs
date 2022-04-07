using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace TerraBloons.NPCs
{
	public class BlueBloon : ModNPC
	{
		public override void SetDefaults()
		{
			NPC.width = 22;
			NPC.height = 28;
			NPC.damage = 10;
			NPC.lifeMax = 22;
			NPC.HitSound = SoundID.NPCDeath63;
			NPC.DeathSound = SoundID.NPCDeath63;
			NPC.value = 15.0f;
			NPC.aiStyle = 14; // Bat AI
			NPC.noGravity = true;
			NPC.npcSlots = 0.75f;
			NPC.scale = 1.0f;
			NPC.buffImmune[BuffID.Bleeding] = true;
			NPC.buffImmune[BuffID.Poisoned] = true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) => SpawnCondition.OverworldDaySlime.Chance * 0.15f;
		public override void OnKill() => NPC.NewNPC(NPC.GetSpawnSourceForNPCFromNPCAI(), (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<RedBloon>());

		public override void ModifyHitByProjectile(Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			if (TerraBloons.IsSharpThrowableOrDart(projectile.type))
				damage *= 2;
		}
	}
}
