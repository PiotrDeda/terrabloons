using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace TerraBloons.NPCs
{
	public class YellowBloon : ModNPC
	{
		public override void SetDefaults()
		{
			NPC.width = 22;
			NPC.height = 28;
			NPC.damage = 14;
			NPC.lifeMax = 40;
			NPC.HitSound = SoundID.NPCDeath63;
			NPC.DeathSound = SoundID.NPCDeath63;
			NPC.value = 100.0f;
			NPC.aiStyle = 14; // Bat AI
			NPC.noGravity = true;
			NPC.npcSlots = 1.25f;
			NPC.scale = 1.15f;
			NPC.buffImmune[BuffID.Bleeding] = true;
			NPC.buffImmune[BuffID.Poisoned] = true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) => SpawnCondition.OverworldDaySlime.Chance * 0.025f;
		public override void OnKill() => NPC.NewNPC(NPC.GetSource_FromThis(), (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<GreenBloon>());

		public override void ModifyHitByProjectile(Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			if (TerraBloons.IsSharpThrowableOrDart(projectile.type))
				damage *= 2;
		}
	}
}
