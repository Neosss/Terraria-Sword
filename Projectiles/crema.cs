using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Projectiles //Nota importante el namespace se tiene que llamar como la carpeta contenedora
{
	public class crema : ModProjectile
	{
		public override void SetDefaults()
		{
			//projectile.name = "crema"; Da error compilar con el nombre, la solucion es comentarla
			projectile.width = 30;
			projectile.height = 58;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.tileCollide = false;
			projectile.penetrate = 30;
			projectile.timeLeft = 200;
			projectile.light = 0.75f;
			projectile.extraUpdates = 1;
			projectile.ignoreWater = true;
		}
		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.10f;
		}
	}
	
}