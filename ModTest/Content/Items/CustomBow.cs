using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModTest.Content.Items
{
    public class CustomBow : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 20; // Dano do arco
            Item.DamageType = DamageClass.Ranged;
            Item.width = 20;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 2;
            Item.value = 10000;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 10f;
            Item.useAmmo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}