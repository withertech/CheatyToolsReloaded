
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace CheatyToolsReloaded.Items.Tools
{
	public class SuperCheatyDrill : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Cheaty Drill");
            Tooltip.SetDefault("This is a Super Cheaty Drill and should only be used by cheaters.");
		}
		public override void SetDefaults()
		{
			item.channel = true;
            item.damage = 1000;
            item.melee = true;
            item.useTime = 2;
            item.useAnimation = 2;
			item.noUseGraphic = true;
			item.useStyle = 5;
			item.knockBack = 0;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("SuperCheatyDrill");
			item.shootSpeed = 40f;
            item.rare = 13;
            item.expert = true;
            item.value = Item.buyPrice(platinum: 100000000);
            item.autoReuse = true;
			item.pick = GetInstance<SuperCheatyConfig>().DrillPickaxePower;
		}
    }
}