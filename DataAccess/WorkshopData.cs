namespace FarmSim.Content.Tropical.DataAccess;
internal static class WorkshopData
{
    public static Task<BasicList<WorkshopRecipe>> GetAsync()
    {
        BasicList<WorkshopRecipe> output = [];


        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.PineappleSmoothie, TropicalWorkshopList.HuluHit,
            TimeSpan.FromMinutes(1),
            i => { i[TropicalItemList.Pineapple] = 3; });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.PinaColada, TropicalWorkshopList.HuluHit,
            TimeSpan.FromMinutes(5),
            i =>
            {
                i[TropicalItemList.Coconut] = 3;
                i[TropicalItemList.Pineapple] = 2;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.MangoJuice, TropicalWorkshopList.HuluHit,
            TimeSpan.FromMinutes(20),
            i => { i[TropicalItemList.Mango] = 2; });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.SteamedRice, TropicalWorkshopList.SushiStand,
            TimeSpan.FromSeconds(30),
            i => { i[TropicalItemList.Rice] = 2; });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.FishRoll, TropicalWorkshopList.SushiStand,
            TimeSpan.FromMinutes(3),
            i =>
            {
                i[TropicalItemList.Fish] = 2;
                i[TropicalItemList.SteamedRice] = 1;
            });
        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.CrabRoll, TropicalWorkshopList.SushiStand,
            TimeSpan.FromMinutes(5),
            i =>
            {
                i[TropicalItemList.GrilledCrab] = 2;
                i[TropicalItemList.SteamedRice] = 1;
            });
        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.EggRoll, TropicalWorkshopList.SushiStand,
            TimeSpan.FromMinutes(10),
            i =>
            {
                i[TropicalItemList.Egg] = 2;
                i[TropicalItemList.SteamedRice] = 1;
            });
        



        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.GrilledCrab, TropicalWorkshopList.Grill,
            TimeSpan.FromMinutes(3),
            i => { i[TropicalItemList.Crab] = 1; });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.SearedFish, TropicalWorkshopList.Grill,
            TimeSpan.FromMinutes(4),
            i => { i[TropicalItemList.Fish] = 3; });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.FriedRice, TropicalWorkshopList.Grill,
            TimeSpan.FromMinutes(8),
            i =>
            {
                i[TropicalItemList.Egg] = 2;
                i[TropicalItemList.SteamedRice] = 1;
                i[TropicalItemList.Pineapple] = 1;
            });


        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.CrabBites, TropicalWorkshopList.Grill,
            TimeSpan.FromMinutes(30),
            i =>
            {
                i[TropicalItemList.Crab] = 2;
                i[TropicalItemList.Lime] = 1;
            });


        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.OrchidPerfume, TropicalWorkshopList.ArtisanWorkshop,
            TimeSpan.FromMinutes(6),
            i =>
            {
                i[TropicalItemList.Orchid] = 2;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.ScentedSoap, TropicalWorkshopList.ArtisanWorkshop,
            TimeSpan.FromMinutes(25),
            i =>
            {
                i[TropicalItemList.CoconutOil] = 1;
                i[TropicalItemList.OrchidPerfume] = 2;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.SugarScrub, TropicalWorkshopList.ArtisanWorkshop,
            TimeSpan.FromMinutes(5),
            i =>
            {
                i[TropicalItemList.Sugar] = 2;
                i[TropicalItemList.Seashell] = 1;
                i[TropicalItemList.CoconutOil] = 1;
            });


        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.CoconutOil, TropicalWorkshopList.Mill,
            TimeSpan.FromMinutes(12),
            i =>
            {
                i[TropicalItemList.Coconut] = 3;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.Sugar, TropicalWorkshopList.Mill,
            TimeSpan.FromMinutes(15),
            i =>
            {
                i[TropicalItemList.SugarCane] = 2;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.Ceviche, TropicalWorkshopList.BeachfrontKitchen,
            TimeSpan.FromMinutes(10),
            i =>
            {
                i[TropicalItemList.Fish] = 3;
                i[TropicalItemList.Coconut] = 2;
                i[TropicalItemList.Lime] = 2;
            });

        WorkshopRecipe.AddWorkshopRecipe(output, TropicalItemList.TruffleFries, TropicalWorkshopList.BeachfrontKitchen,
            TimeSpan.FromMinutes(20),
            i =>
            {
                i[TropicalItemList.Tapioca] = 2;
                i[TropicalItemList.Mushroom] = 2;
            });

        return Task.FromResult(output);
    }
}