namespace FarmSim.Content.Tropical.DataAccess;
internal static class CropRecipeData
{
    public static Task<BasicList<CropRecipe>> GetAsync()
    {
        BasicList<CropRecipe> output = [];
        output.Add(new CropRecipe
        {
            Item = TropicalItemList.Pineapple,
            Duration = TimeSpan.FromSeconds(45),
            IsFast = true,
            HowMany = 3
        });
        output.Add(new CropRecipe
        {
            Item = TropicalItemList.Rice,
            Duration = TimeSpan.FromMinutes(1),
            IsFast = false,
            HowMany = 2
        });
        output.Add(new CropRecipe
        {
            Item = TropicalItemList.Orchid,
            Duration = TimeSpan.FromMinutes(12),
            IsFast = false,
            HowMany = 3
        });
        output.Add(new CropRecipe
        {
            Item = TropicalItemList.SugarCane,
            Duration = TimeSpan.FromMinutes(15),
            IsFast = false,
            HowMany = 3
        });
        output.Add(new CropRecipe
        {
            Item = TropicalItemList.Tapioca,
            Duration = TimeSpan.FromMinutes(20),
            IsFast = false,
            HowMany = 3
        });
        return Task.FromResult(output);
    }
}