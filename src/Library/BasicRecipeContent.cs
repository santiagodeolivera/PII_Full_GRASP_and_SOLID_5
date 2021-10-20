namespace Full_GRASP_And_SOLID
{
    public class BasicRecipeContent : RecipeContent
    {
        public Recipe Recipe { get; }

        public BasicRecipeContent(Recipe recipe)
        {
            this.Recipe = recipe;
        }

        public string GetTextToPrint()
        {
            string result = $"Receta de {this.Recipe.FinalProduct.Description}:\n";
            foreach (BaseStep step in this.Recipe.Steps)
            {
                result = result + step.GetTextToPrint() + "\n";
            }

            // Agregado por Expert
            result = result + $"Costo de producción: {this.Recipe.GetProductionCost()}";

            return result;
        }
    }
}
