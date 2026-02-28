namespace FarmSim.Content.Tropical.DataAccess;
public class WorkshopRecipeRepository : IWorkshopRecipes
{
    async Task<BasicList<WorkshopRecipe>> IWorkshopRecipes.GetWorkshopRecipesAsync()
    {
        var list = await WorkshopData.GetAsync();
        return await RecipeExtensions.MergeAsync(list, RecipeExtensions.ExtraWorkshopRecipes);
    }
}