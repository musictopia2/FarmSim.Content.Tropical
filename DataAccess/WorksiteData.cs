namespace FarmSim.Content.Tropical.DataAccess;
public static class WorksiteData
{
    public static BasicList<WorksiteRecipe> Get()
    {
        BasicList<WorksiteRecipe> output = [];
        WorksiteRecipe recipe = new()
        {
            StartText = "Go snorkeling!",
            Location = TropicalWorksiteListClass.CorelReef,
            Duration = TimeSpan.FromMinutes(15),
            MaximumWorkers = 3,
            CanFocus = false
        };
        recipe.Inputs.Add(TropicalItemList.PineappleSmoothie, 2);
        WorksiteBaselineBenefit benefit = new()
        {
            Guarantee = true,
            Item = TropicalItemList.Crab,
            EachWorkerGivesOne = true
        };
        recipe.BaselineBenefits.Add(benefit);
        benefit = new()
        {
            Chance = 0.25,
            Item = TropicalItemList.Seashell
        };
        recipe.BaselineBenefits.Add(benefit);
        //later will figure out something else you get from the corel reef

        output.Add(recipe);
        recipe = new()
        {
            StartText = "Take a hot soak!",
            Location = TropicalWorksiteListClass.HotSprings,
            Duration = TimeSpan.FromHours(2),
            MaximumWorkers = 4,
        };
        recipe.Inputs.Add(TropicalItemList.Ceviche, 2);

        benefit = new()
        {
            Guarantee = true,
            Item = TropicalItemList.Clay,
            EachWorkerGivesOne = true
        };
        recipe.BaselineBenefits.Add(benefit);


        benefit = new()
        {
            Item = TropicalItemList.Vanilla,
            Chance = 0.13
        };
        recipe.BaselineBenefits.Add(benefit);
        benefit = new()
        {
            Item = TropicalItemList.Jasmine,
            Chance = 0.3
        };
        recipe.BaselineBenefits.Add(benefit);
        output.Add(recipe);

        recipe = new()
        {
            StartText = "Go spelunking!",
            Location = TropicalWorksiteListClass.SmugglersCave,
            Duration = TimeSpan.FromHours(1),
            MaximumWorkers = 4,
        };
        recipe.Inputs.Add(TropicalItemList.TruffleFries, 2);
        recipe.Inputs.Add(TropicalItemList.FriedRice, 2);
        benefit = new()
        {
            Guarantee = true,
            Item = TropicalItemList.IronOre,
            EachWorkerGivesOne = true
        };
        recipe.BaselineBenefits.Add(benefit);


        benefit = new()
        {
            Item = TropicalItemList.BlueCrystal,
            Chance = 0.13
        };
        recipe.BaselineBenefits.Add(benefit);
        benefit = new()
        {
            Item = TropicalItemList.SilverOre,
            Chance = 0.3
        };
        recipe.BaselineBenefits.Add(benefit);
        output.Add(recipe);
        return output;
    }
    public static Task<BasicList<WorksiteRecipe>> GetAsync()
    {
        var output = Get();
        return Task.FromResult(output);
    }
}