namespace FarmSim.Content.Tropical.DataAccess;
internal static class AnimalRecipeData
{
    public static Task<BasicList<AnimalRecipe>> GetAsync()
    {
        BasicList<AnimalRecipe> output = [];
        BasicList<AnimalProductionOption> options = [];
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(1),
            Input = 1,
            Output = new(TropicalItemList.Fish, 2),
            Required = TropicalItemList.Pineapple
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(2),
            Input = 2,
            Output = new(TropicalItemList.Fish, 4),
            Required = TropicalItemList.Pineapple
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(30),
            Input = 4,
            Output = new(TropicalItemList.Fish, 8),
            Required = TropicalItemList.Pineapple
        });
        AnimalRecipe recipe = new()
        {
            Animal = TropicalAnimalListClass.Dolphin,
            Options = options,
            IsFast = true
        };
        output.Add(recipe);

        options = [];
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(2),
            Input = 2,
            Output = new(TropicalItemList.Egg, 1),
            Required = TropicalItemList.Rice
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(6),
            Input = 6,
            Output = new(TropicalItemList.Egg, 3),
            Required = TropicalItemList.Rice
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(90),
            Input = 20,
            Output = new(TropicalItemList.Egg, 10),
            Required = TropicalItemList.Rice
        });
        recipe = new()
        {
            Animal = TropicalAnimalListClass.Chicken,
            Options = options,
            IsFast = false
        };
        output.Add(recipe);

        options = [];
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(3),
            Input = 2,
            Output = new(TropicalItemList.Mushroom, 1),
            Required = TropicalItemList.Tapioca
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromMinutes(9),
            Input = 6,
            Output = new(TropicalItemList.Mushroom, 3),
            Required = TropicalItemList.Tapioca
        });
        options.Add(new AnimalProductionOption
        {
            Duration = TimeSpan.FromHours(2),
            Input = 20,
            Output = new(TropicalItemList.Mushroom, 10),
            Required = TropicalItemList.Tapioca
        });
        recipe = new()
        {
            Animal = TropicalAnimalListClass.Boar,
            Options = options,
            IsFast = false
        };
        output.Add(recipe);
        return Task.FromResult(output);
    }
}