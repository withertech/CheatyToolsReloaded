using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace CheatyToolsReloaded.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class SuperCheatyTankLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Super Cheaty Tank Leggings");
            Tooltip.SetDefault("This is a Super Cheaty Tank Leggings and should only be used by cheaters.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.buyPrice(platinum: 100000000);
            item.rare = 13;
            item.defense = GetInstance<SuperCheatyConfig>().TankDefense[2];
            item.expert = true;

        }
    }
}