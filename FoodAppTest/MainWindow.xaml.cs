using FoodAppTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FoodAppTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Configure API key authorization: apiKeyScheme
            Configuration.ApiKey.Add("x-api-key", "364b5d8d304542b2a82b2f13805cb2d5");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var analyzeRecipeRequest = new AnalyzeRecipeRequest(); // AnalyzeRecipeRequest | Example request body.
            var language = en;  // string | The input language, either \"en\" or \"de\". (optional) 
            var includeNutrition = false;  // bool? | Whether nutrition data should be added to correctly parsed ingredients. (optional) 
            var includeTaste = false;  // bool? | Whether taste data should be added to correctly parsed ingredients. (optional) 

            try
            {
                // Analyze Recipe
                Object result = apiInstance.AnalyzeRecipe(analyzeRecipeRequest, language, includeNutrition, includeTaste);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AnalyzeRecipe: " + e.Message);
            }

        }
    }
}
