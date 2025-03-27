using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModTest.Content.Items
{
    public class CustomMagicWeapon : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 400; // Dano da arma mágica
            Item.DamageType = DamageClass.Magic;
            Item.mana = 5; // Consumo de mana por disparo
            Item.width = 28;
            Item.height = 30;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.noMelee = true;
            Item.knockBack = 3;
            Item.value = 50000;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item20;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.PurpleLaser; // Tipo de projétil mágico
            Item.shootSpeed = 12f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 13);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}