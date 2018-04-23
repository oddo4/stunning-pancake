# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (SpoonacularAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=spoonacular%20API-CSharp&workspaceName=SpoonacularAPI&projectName=SpoonacularAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the SpoonacularAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=spoonacular%20API-CSharp&workspaceName=SpoonacularAPI&projectName=SpoonacularAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=spoonacular%20API-CSharp&workspaceName=SpoonacularAPI&projectName=SpoonacularAPI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=spoonacular%20API-CSharp&workspaceName=SpoonacularAPI&projectName=SpoonacularAPI.PCL)

### 3. Add reference of the library project

In order to use the SpoonacularAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=spoonacular%20API-CSharp&workspaceName=SpoonacularAPI&projectName=SpoonacularAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` SpoonacularAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```SpoonacularAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=spoonacular%20API-CSharp&workspaceName=SpoonacularAPI&projectName=SpoonacularAPI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=spoonacular%20API-CSharp&workspaceName=SpoonacularAPI&projectName=SpoonacularAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 
You need the following information for initializing the API client.

| Parameter | Description |
|-----------|-------------|
| xMashapeKey | The Mashape application you want to use for this session. |



API client can be initialized as following.

```csharp
// Configuration parameters
string xMashapeKey = "xMashapeKey"; // The Mashape application you want to use for this session.

SpoonacularAPIClient client = new SpoonacularAPIClient(xMashapeKey);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [APIController](#api_controller)

### <a name="api_controller"></a>![Class: ](https://apidocs.io/img/class.png "SpoonacularAPI.PCL.Controllers.APIController") APIController

#### Get singleton instance

The singleton instance of the ``` APIController ``` class can be accessed from the API Client.

```csharp
APIController client = client.Client;
```

#### <a name="get_product_information"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.GetProductInformation") GetProductInformation

> *Tags:*  ``` Skips Authentication ``` 

> Get information about a packaged food product.


```csharp
Task<dynamic> GetProductInformation(int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  ``` DefaultValue ```  | The id of the packaged food product. |


#### Example Usage

```csharp
int id = 22347;

dynamic result = await client.GetProductInformation(id);

```


#### <a name="find_similar_recipes"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.FindSimilarRecipes") FindSimilarRecipes

> *Tags:*  ``` Skips Authentication ``` 

> Find recipes which are similar to the given one.


```csharp
Task<dynamic> FindSimilarRecipes(int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  ``` DefaultValue ```  | The id of the source recipe to which similar recipes should be found. |


#### Example Usage

```csharp
int id = 156992;

dynamic result = await client.FindSimilarRecipes(id);

```


#### <a name="get_autocomplete_ingredient_search"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.GetAutocompleteIngredientSearch") GetAutocompleteIngredientSearch

> *Tags:*  ``` Skips Authentication ``` 

> Autocomplete a search for an ingredient.


```csharp
Task<dynamic> GetAutocompleteIngredientSearch(string query)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| query |  ``` Required ```  ``` DefaultValue ```  | The query - a partial or full ingredient name. |


#### Example Usage

```csharp
string query = "appl";

dynamic result = await client.GetAutocompleteIngredientSearch(query);

```


#### <a name="create_visualize_price_breakdown"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateVisualizePriceBreakdown") CreateVisualizePriceBreakdown

> *Tags:*  ``` Skips Authentication ``` 

> Visualize the price breakdown of a recipe.


```csharp
Task<dynamic> CreateVisualizePriceBreakdown(
        string ingredientList,
        int servings,
        string defaultCss = "checked",
        int? mode = 1,
        Dictionary<string, object> fieldParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ingredientList |  ``` Required ```  ``` DefaultValue ```  | The ingredient list of the recipe, one ingredient per line. |
| servings |  ``` Required ```  ``` DefaultValue ```  | The number of servings. |
| defaultCss |  ``` Optional ```  ``` DefaultValue ```  | Whether the widget should be styled with the default css. |
| mode |  ``` Optional ```  ``` DefaultValue ```  | The mode in which the widget should be delivered. 1 = separate views (compact), 2 = all in one view (full). |
| fieldParameters | ``` Optional ``` | Additional optional form parameters are supported by this method |


#### Example Usage

```csharp
string ingredientList = "3 oz flour";
int servings = 2;
string defaultCss = "checked";
int? mode = 1;
// key-value map for optional form parameters
var formParams = new Dictionary<string, object>();


dynamic result = await client.CreateVisualizePriceBreakdown(ingredientList, servings, defaultCss, mode, formParams);

```


#### <a name="create_visualize_nutrition"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateVisualizeNutrition") CreateVisualizeNutrition

> *Tags:*  ``` Skips Authentication ``` 

> Visualize a recipe's nutritional information.


```csharp
Task<dynamic> CreateVisualizeNutrition(
        string ingredientList,
        int servings,
        string defaultCss = "checked",
        Dictionary<string, object> fieldParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ingredientList |  ``` Required ```  ``` DefaultValue ```  | The ingredient list of the recipe, one ingredient per line. |
| servings |  ``` Required ```  ``` DefaultValue ```  | The number of servings. |
| defaultCss |  ``` Optional ```  ``` DefaultValue ```  | Whether the ingredient list should be styled with the default css. |
| fieldParameters | ``` Optional ``` | Additional optional form parameters are supported by this method |


#### Example Usage

```csharp
string ingredientList = "3 oz flour";
int servings = 2;
string defaultCss = "checked";
// key-value map for optional form parameters
var formParams = new Dictionary<string, object>();


dynamic result = await client.CreateVisualizeNutrition(ingredientList, servings, defaultCss, formParams);

```


#### <a name="create_visualize_ingredients"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateVisualizeIngredients") CreateVisualizeIngredients

> *Tags:*  ``` Skips Authentication ``` 

> Visualize ingredients of a recipe.


```csharp
Task<dynamic> CreateVisualizeIngredients(
        string ingredientList,
        int servings,
        string defaultCss = "checked",
        string measure = "metric",
        string view = "grid",
        Dictionary<string, object> fieldParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ingredientList |  ``` Required ```  ``` DefaultValue ```  | The ingredient list of the recipe, one ingredient per line. |
| servings |  ``` Required ```  ``` DefaultValue ```  | The initial number of servings. |
| defaultCss |  ``` Optional ```  ``` DefaultValue ```  | Whether the ingredient list should be styled with the default css. |
| measure |  ``` Optional ```  ``` DefaultValue ```  | The initial measure, either "metric" or "us". |
| view |  ``` Optional ```  ``` DefaultValue ```  | The initial view, either "grid" or "list". |
| fieldParameters | ``` Optional ``` | Additional optional form parameters are supported by this method |


#### Example Usage

```csharp
string ingredientList = "3 oz flour";
int servings = 2;
string defaultCss = "checked";
string measure = "metric";
string view = "grid";
// key-value map for optional form parameters
var formParams = new Dictionary<string, object>();


dynamic result = await client.CreateVisualizeIngredients(ingredientList, servings, defaultCss, measure, view, formParams);

```


#### <a name="get_summarize_recipe"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.GetSummarizeRecipe") GetSummarizeRecipe

> *Tags:*  ``` Skips Authentication ``` 

> Summarize the recipe in a short text.


```csharp
Task<dynamic> GetSummarizeRecipe(int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  ``` DefaultValue ```  | The id of the recipe that should be summarized. |


#### Example Usage

```csharp
int id = 4632;

dynamic result = await client.GetSummarizeRecipe(id);

```


#### <a name="search_grocery_products"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.SearchGroceryProducts") SearchGroceryProducts

> *Tags:*  ``` Skips Authentication ``` 

> Search packaged food products like frozen pizza and snickers bars.


```csharp
Task<dynamic> SearchGroceryProducts(
        string query,
        int? number = 10,
        int? offset = 0,
        Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| query |  ``` Required ```  ``` DefaultValue ```  | The search query. |
| number |  ``` Optional ```  ``` DefaultValue ```  | The number of results to retrieve, defaults to 10. |
| offset |  ``` Optional ```  ``` DefaultValue ```  | The number of results to skip, defaults to 0. |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
string query = "snickers";
int? number = 10;
int? offset = 0;
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


dynamic result = await client.SearchGroceryProducts(query, number, offset, queryParams);

```


#### <a name="get_quick_answer"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.GetQuickAnswer") GetQuickAnswer

> *Tags:*  ``` Skips Authentication ``` 

> Answer a nutrition related natural language question.


```csharp
Task<dynamic> GetQuickAnswer(string q)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  ``` DefaultValue ```  | The nutrition-related question. |


#### Example Usage

```csharp
string q = "How much vitamin c is in 2 apples?";

dynamic result = await client.GetQuickAnswer(q);

```


#### <a name="get_recipe_information"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.GetRecipeInformation") GetRecipeInformation

> *Tags:*  ``` Skips Authentication ``` 

> Get information about a recipe.


```csharp
Task<dynamic> GetRecipeInformation(int id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  ``` DefaultValue ```  | The id of the recipe. |


#### Example Usage

```csharp
int id = 156992;

dynamic result = await client.GetRecipeInformation(id);

```


#### <a name="create_parse_ingredients"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateParseIngredients") CreateParseIngredients

> *Tags:*  ``` Skips Authentication ``` 

> Extract an ingredient from plain text.


```csharp
Task<dynamic> CreateParseIngredients(string ingredientList, int servings)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ingredientList |  ``` Required ```  ``` DefaultValue ```  | The ingredient list of the recipe, one ingredient per line. |
| servings |  ``` Required ```  ``` DefaultValue ```  | The number of servings that you can make from the ingredients. |


#### Example Usage

```csharp
string ingredientList = "3 oz pork shoulder";
int servings = 2;

dynamic result = await client.CreateParseIngredients(ingredientList, servings);

```


#### <a name="create_map_ingredients"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateMapIngredients") CreateMapIngredients

> *Tags:*  ``` Skips Authentication ``` 

> Map ingredients to food products.


```csharp
Task<dynamic> CreateMapIngredients(string ingredientList, int servings)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ingredientList |  ``` Required ```  ``` DefaultValue ```  | A new line-separated list of ingredients. |
| servings |  ``` Required ```  ``` DefaultValue ```  | The number of servings this recipe makes. |


#### Example Usage

```csharp
string ingredientList = "200g flour\\n3 eggs";
int servings = 1;

dynamic result = await client.CreateMapIngredients(ingredientList, servings);

```


#### <a name="get_extract_recipe_from_website"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.GetExtractRecipeFromWebsite") GetExtractRecipeFromWebsite

> *Tags:*  ``` Skips Authentication ``` 

> Extract recipe data from a recipe blog or Web page.


```csharp
Task<dynamic> GetExtractRecipeFromWebsite(string url, bool? forceExtraction = false, Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| url |  ``` Required ```  ``` DefaultValue ```  | The URL of the recipe page. |
| forceExtraction |  ``` Optional ```  ``` DefaultValue ```  | If true, the extraction will be triggered no matter whether we know the recipe already. Use that only if information is missing as this operation is slower. |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
string url = "http://www.melskitchencafe.com/the-best-fudgy-brownies/";
bool? forceExtraction = false;
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


dynamic result = await client.GetExtractRecipeFromWebsite(url, forceExtraction, queryParams);

```


#### <a name="get_compute_daily_meal_plan"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.GetComputeDailyMealPlan") GetComputeDailyMealPlan

> *Tags:*  ``` Skips Authentication ``` 

> Compute a meal plan for a day.


```csharp
Task<dynamic> GetComputeDailyMealPlan(int targetCalories, string timeFrame)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| targetCalories |  ``` Required ```  ``` DefaultValue ```  | The target number of calories per day. |
| timeFrame |  ``` Required ```  ``` DefaultValue ```  | For one day or a complete week, allowed values are "day" and "week". |


#### Example Usage

```csharp
int targetCalories = 2000;
string timeFrame = "day";

dynamic result = await client.GetComputeDailyMealPlan(targetCalories, timeFrame);

```


#### <a name="create_classify_grocery_products_batch"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateClassifyGroceryProductsBatch") CreateClassifyGroceryProductsBatch

> *Tags:*  ``` Skips Authentication ``` 

> Given a set of product jsons, get back classified products.


```csharp
Task<dynamic> CreateClassifyGroceryProductsBatch(List<Productjsonarray> productJsonArray)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| productJsonArray |  ``` Required ```  ``` Collection ```  | A JSON Array of products. |


#### Example Usage

```csharp
var productJsonArray = new List<Productjsonarray>();

dynamic result = await client.CreateClassifyGroceryProductsBatch(productJsonArray);

```


#### <a name="create_classify_cuisine"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateClassifyCuisine") CreateClassifyCuisine

> *Tags:*  ``` Skips Authentication ``` 

> Classify the recipe's cuisine.


```csharp
Task<dynamic> CreateClassifyCuisine(string ingredientList, string title)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ingredientList |  ``` Required ```  ``` DefaultValue ```  | The ingredient list of the recipe, one ingredient per line. |
| title |  ``` Required ```  ``` DefaultValue ```  | The title of the recipe. |


#### Example Usage

```csharp
string ingredientList = "3 oz pork shoulder";
string title = "Pork roast with green beans";

dynamic result = await client.CreateClassifyCuisine(ingredientList, title);

```


#### <a name="create_classify_a_grocery_product"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateClassifyAGroceryProduct") CreateClassifyAGroceryProduct

> *Tags:*  ``` Skips Authentication ``` 

> Given a grocery product title, this endpoint allows you to detect what basic ingredient it is.


```csharp
Task<Classifiedproduct> CreateClassifyAGroceryProduct(Productjson productJson)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| productJson |  ``` Required ```  | The json representation of a product. |


#### Example Usage

```csharp
var productJson = new Productjson();

Classifiedproduct result = await client.CreateClassifyAGroceryProduct(productJson);

```


#### <a name="search_recipes"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.SearchRecipes") SearchRecipes

> *Tags:*  ``` Skips Authentication ``` 

> Search recipes in natural language.


```csharp
Task<dynamic> SearchRecipes(
        string query,
        string cuisine = "italian",
        string diet = "vegetarian",
        string excludeIngredients = "coconut",
        string intolerances = "egg, gluten",
        bool? limitLicense = false,
        int? number = 10,
        int? offset = 0,
        string type = "main course",
        Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| query |  ``` Required ```  ``` DefaultValue ```  | The (natural language) recipe search query. |
| cuisine |  ``` Optional ```  ``` DefaultValue ```  | The cuisine(s) of the recipes. One or more (comma separated) of the following: african, chinese, japanese, korean, vietnamese, thai, indian, british, irish, french, italian, mexican, spanish, middle eastern, jewish, american, cajun, southern, greek, german, nordic, eastern european, caribbean, or latin american. |
| diet |  ``` Optional ```  ``` DefaultValue ```  | The diet to which the recipes must be compliant. Possible values are: pescetarian, lacto vegetarian, ovo vegetarian, vegan, and vegetarian. |
| excludeIngredients |  ``` Optional ```  ``` DefaultValue ```  | An comma-separated list of ingredients or ingredient types that must not be contained in the recipes. |
| intolerances |  ``` Optional ```  ``` DefaultValue ```  | A comma-separated list of intolerances. All found recipes must not have ingredients that could cause problems for people with one of the given tolerances. Possible values are: dairy, egg, gluten, peanut, sesame, seafood, shellfish, soy, sulfite, tree nut, and wheat. |
| limitLicense |  ``` Optional ```  ``` DefaultValue ```  | Whether the recipes should have an open license that allows for displaying with proper attribution. |
| number |  ``` Optional ```  ``` DefaultValue ```  | The number of results to return (between 0 and 100). |
| offset |  ``` Optional ```  ``` DefaultValue ```  | The number of results to skip (between 0 and 900). |
| type |  ``` Optional ```  ``` DefaultValue ```  | The type of the recipes. One of the following: main course, side dish, dessert, appetizer, salad, bread, breakfast, soup, beverage, sauce, or drink. |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
string query = "burger";
string cuisine = "italian";
string diet = "vegetarian";
string excludeIngredients = "coconut";
string intolerances = "egg, gluten";
bool? limitLicense = false;
int? number = 10;
int? offset = 0;
string type = "main course";
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


dynamic result = await client.SearchRecipes(query, cuisine, diet, excludeIngredients, intolerances, limitLicense, number, offset, type, queryParams);

```


#### <a name="find_by_nutrients"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.FindByNutrients") FindByNutrients

> *Tags:*  ``` Skips Authentication ``` 

> Find a set of recipes that adhere to the given nutrient limits. All the found recipes will have macro nutrients within the calories, protein, fat, and carbohydrate limits.


```csharp
Task<dynamic> FindByNutrients(
        int? maxcalories = 1500,
        int? maxcarbs = 100,
        int? maxfat = 100,
        int? maxprotein = 100,
        int? mincalories = 0,
        int? minCarbs = 0,
        int? minfat = 0,
        int? minProtein = 0,
        Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| maxcalories |  ``` Optional ```  ``` DefaultValue ```  | The maximum number of calories the recipe can have. |
| maxcarbs |  ``` Optional ```  ``` DefaultValue ```  | The maximum number of carbohydrates in grams the recipe can have. |
| maxfat |  ``` Optional ```  ``` DefaultValue ```  | The maximum number of fat in grams the recipe can have. |
| maxprotein |  ``` Optional ```  ``` DefaultValue ```  | The maximum number of protein in grams the recipe can have. |
| mincalories |  ``` Optional ```  ``` DefaultValue ```  | The minimum number of calories the recipe must have. |
| minCarbs |  ``` Optional ```  ``` DefaultValue ```  | The minimum number of carbohydrates in grams the recipe must have. |
| minfat |  ``` Optional ```  ``` DefaultValue ```  | The minimum number of fat in grams the recipe must have. |
| minProtein |  ``` Optional ```  ``` DefaultValue ```  | The minimum number of protein in grams the recipe must have. |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
int? maxcalories = 1500;
int? maxcarbs = 100;
int? maxfat = 100;
int? maxprotein = 100;
int? mincalories = 0;
int? minCarbs = 0;
int? minfat = 0;
int? minProtein = 0;
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


dynamic result = await client.FindByNutrients(maxcalories, maxcarbs, maxfat, maxprotein, mincalories, minCarbs, minfat, minProtein, queryParams);

```


#### <a name="find_by_ingredients"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.FindByIngredients") FindByIngredients

> *Tags:*  ``` Skips Authentication ``` 

> Find recipes that use as many of the given ingredients as possible and have as little as possible missing ingredients. This is a whats in your fridge API endpoint.


```csharp
Task<List<FindByIngredientsModel>> FindByIngredients(
        string ingredients,
        bool? limitLicense = false,
        int? number = 5,
        int? ranking = 1,
        Dictionary<string, object> queryParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ingredients |  ``` Required ```  ``` DefaultValue ```  | A comma-separated list of ingredients that the recipes should contain. |
| limitLicense |  ``` Optional ```  ``` DefaultValue ```  | Whether to only show recipes with an attribution license. |
| number |  ``` Optional ```  ``` DefaultValue ```  | The maximal number of recipes to return (default = 5). |
| ranking |  ``` Optional ```  ``` DefaultValue ```  | Whether to maximize used ingredients (1) or minimize missing ingredients (2) first. |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |


#### Example Usage

```csharp
string ingredients = "apples,flour,sugar";
bool? limitLicense = false;
int? number = 5;
int? ranking = 1;
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


List<FindByIngredientsModel> result = await client.FindByIngredients(ingredients, limitLicense, number, ranking, queryParams);

```


#### <a name="create_recipe_card"></a>![Method: ](https://apidocs.io/img/method.png "SpoonacularAPI.PCL.Controllers.APIController.CreateRecipeCard") CreateRecipeCard

> *Tags:*  ``` Skips Authentication ``` 

> Create a recipe card given a recipe.


```csharp
Task<dynamic> CreateRecipeCard(
        string backgroundImage,
        Stream image,
        string ingredients,
        string instructions,
        string mask,
        int readyInMinutes,
        int servings,
        string title,
        string author = "Emily Henderson",
        string backgroundColor = "#ffffff",
        string fontColor = "#333333",
        string source = "spoonacular.com",
        Dictionary<string, object> fieldParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| backgroundImage |  ``` Required ```  ``` DefaultValue ```  | The background image ("none","background1", or "background2"). |
| image |  ``` Required ```  ``` DefaultValue ```  | The binary image of the recipe as jpg. |
| ingredients |  ``` Required ```  ``` DefaultValue ```  | The ingredient list of the recipe, one ingredient per line. |
| instructions |  ``` Required ```  ``` DefaultValue ```  | The instructions to make the recipe. One step per line. |
| mask |  ``` Required ```  ``` DefaultValue ```  | The mask to put over the recipe image ("ellipseMask", "diamondMask", "diamondMask", "starMask", "heartMask", "potMask", "fishMask"). |
| readyInMinutes |  ``` Required ```  ``` DefaultValue ```  | The number of minutes it takes to get the recipe on the table. |
| servings |  ``` Required ```  ``` DefaultValue ```  | The number of servings that you can make from the ingredients. |
| title |  ``` Required ```  ``` DefaultValue ```  | The title of the recipe. |
| author |  ``` Optional ```  ``` DefaultValue ```  | The author of the recipe. |
| backgroundColor |  ``` Optional ```  ``` DefaultValue ```  | The background color on the recipe card as a hex-string. |
| fontColor |  ``` Optional ```  ``` DefaultValue ```  | The font color on the recipe card as a hex-string. |
| source |  ``` Optional ```  ``` DefaultValue ```  | The source of the recipe. |
| fieldParameters | ``` Optional ``` | Additional optional form parameters are supported by this method |


#### Example Usage

```csharp
string backgroundImage = "background1";
Stream image = new Stream(new FileStream(@"pathToFile",FileMode.Open));
string ingredients = "2 cups of green beans";
string instructions = "cook the beans";
string mask = "ellipseMask";
int readyInMinutes = 60;
int servings = 2;
string title = "Pork tenderloin with green beans";
string author = "Emily Henderson";
string backgroundColor = "#ffffff";
string fontColor = "#333333";
string source = "spoonacular.com";
// key-value map for optional form parameters
var formParams = new Dictionary<string, object>();


dynamic result = await client.CreateRecipeCard(backgroundImage, image, ingredients, instructions, mask, readyInMinutes, servings, title, author, backgroundColor, fontColor, source, formParams);

```


[Back to List of Controllers](#list_of_controllers)



