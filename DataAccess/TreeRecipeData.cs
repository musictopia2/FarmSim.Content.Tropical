namespace FarmSim.Content.Tropical.DataAccess;
internal static class TreeRecipeData
{
    public static Task<BasicList<TreeRecipe>> GetAsync()
    {
        BasicList<TreeRecipe> output = [];
        TreeRecipe tree = new()
        {
            TreeName = TropicalTreeListClass.Coconut,
            Item = TropicalItemList.Coconut,
            ProductionTimeForEach = TimeSpan.FromMinutes(2),
            IsFast = true
        };
        output.Add(tree);

        tree = new()
        {
            TreeName = TropicalTreeListClass.Mango,
            Item = TropicalItemList.Mango,
            ProductionTimeForEach = TimeSpan.FromMinutes(5),
            IsFast = false
        };
        output.Add(tree);

        tree = new()
        {
            TreeName = TropicalTreeListClass.Lime,
            Item = TropicalItemList.Lime,
            ProductionTimeForEach = TimeSpan.FromMinutes(45),
            IsFast = false
        };
        output.Add(tree);
        return Task.FromResult(output);
    }
}