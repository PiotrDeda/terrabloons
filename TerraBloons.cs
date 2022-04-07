using Terraria.ID;
using Terraria.ModLoader;

namespace TerraBloons
{
	public class TerraBloons : Mod
	{
		public static bool IsSharpThrowableOrDart(int projectileType)
		{
			return projectileType switch
			{
				ProjectileID.Shuriken or ProjectileID.ThrowingKnife or ProjectileID.PoisonedKnife or ProjectileID.BoneDagger or ProjectileID.StarAnise or
				ProjectileID.SpikyBall or ProjectileID.JavelinFriendly or ProjectileID.FrostDaggerfish or ProjectileID.BoneJavelin or ProjectileID.NailFriendly or
				ProjectileID.PoisonDart or ProjectileID.CrystalDart or ProjectileID.CursedDart or ProjectileID.IchorDart => true,
				_ => false,
			};
		}
	}
}