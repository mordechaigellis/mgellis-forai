use RecipeDB
go
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.

Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select ItemType = 'Recipes', Count = count(*)
from Recipe r
select ItemType = 'Meals', Count = count(*)
from meal m
select ItemType = 'Cookbooks', Count = count(*)
from cookbook c

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select 
    RecipeName = case r.RecipeStatus when 'Archived' then concat('<span style="color:gray">',r.RecipeName,'</span>') else r.RecipeName end, 
    r.RecipeStatus, 
    DatePublished = isnull(convert(varchar(10),r.DatePublished,101),''),
    DateArchived = isnull(convert(varchar(10),r.DateArchived,101),''),
    s.Username,
    r.Calories, 
    NumOfIngredients = count(*)
from Recipe r
join Staff s
on s.StaffId = r.StaffId
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
where r.RecipeStatus in('Published','Archived') --can also use date columns for this
group by r.RecipeStatus, r.RecipeName, r.DatePublished, r.DateArchived, r.Calories, s.Username
order by r.RecipeStatus desc, r.RecipeName
/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
select r.RecipeName, r.Calories, NumOfIngredients = count(distinct ri.RecipeIngredientId), NumOfSteps = count(distinct rs.RecipeStepId), r.ImageName
from Recipe r
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
join RecipeStep rs
on r.RecipeId = rs.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
group by r.RecipeName, r.Calories, r.ImageName

select Ingredient = concat(ri.MeasurementQty,' ',m.MeasurementType,' ', i.Ingredient), i.ImageName
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredient i
on i.IngredientId = ri.IngredientId
join Measurement m
on ri.MeasurementId = m.MeasurementId
where r.RecipeName = 'Apple Yogurt Smoothie'
order by ri.SequenceVal

select rs.SequenceVal, rs.Instruction
from Recipe r
join RecipeStep rs
on r.RecipeId = rs.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
order by rs.SequenceVal

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
select m.MealName, s.Username, TotalCalories = sum(r.Calories), NumOfCourses = count(distinct mc.CourseId), NumOfRecipes = count(distinct mcr.RecipeId)
from Meal m
join Staff s
on m.StaffId = s.StaffId
join MealCourse mc
on m.MealId = mc.MealId
join MealCourseRecipe mcr
on mcr.MealCourseId = mc.MealCourseId
join Recipe r
on mcr.RecipeId = r.RecipeId
where m.Active = 1
group by m.MealName, s.Username
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
*/
select m.MealName, s.Username, m.DateCreated, m.ImageName
from Staff s
join Meal m
on m.StaffId = s.StaffId
where m.MealName = 'Super Supper'
/*
    b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select MealRecipe = concat(
    case when c.CourseName = 'Main' and mcr.IsMain = 1 then '<b>' end,
    c.CourseName,
    ': ',
    case c.CourseName when 'Main' then case mcr.IsMain when 1 then 'Main' else 'Side' end + ' dish - ' end,
    r.RecipeName,
    case when c.CourseName = 'Main' and mcr.IsMain = 1 then '</b>' end)
from Meal m
join MealCourse mc
on m.MealId = mc.MealId
join Course c
on c.CourseId = mc.CourseId
join MealCourseRecipe mcr
on mcr.MealCourseId = mc.MealCourseId
join Recipe r
on r.RecipeId = mcr.RecipeId
where m.MealName = 'Super Supper'

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookbookName, s.Username, NumOfRecipes = count(*)
from Staff s
join Cookbook c
on c.StaffId = s.StaffId
join CookbookRecipe cr
on cr.CookbookId = c.CookbookId
where c.Active = 1
group by c.CookbookName, s.Username
order by c.CookbookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
*/
select c.CookbookName, s.Username, c.DateCreated, c.Price, NumOfRecipes = count(*), c.ImageName
from Staff s
join Cookbook c
on c.StaffId = s.StaffId
join CookbookRecipe cr
on cr.CookbookId = c.CookbookId
where c.CookbookName = 'Eat to Live'
group by c.CookbookName, s.Username, c.DateCreated, c.Price, c.ImageName

/*
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
select 
    r.RecipeName, 
    c.CuisineType, 
    NumOfIngredients = count(distinct ri.RecipeIngredientId), 
    NumOfSteps = count(distinct rs.RecipeStepId), 
    b.ImageName
from Cookbook b
join CookbookRecipe cr
on cr.CookbookId = b.CookbookId
join Recipe r
on r.RecipeId = cr.RecipeId
join Cuisine c
on c.CuisineId = r.CuisineId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join RecipeStep rs
on rs.RecipeId = r.RecipeId
where b.CookbookName = 'Eat to Live'
group by r.RecipeName, c.CuisineType, b.ImageName, cr.SequenceVal
order by cr.SequenceVal
go

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
*/

SELECT distinct r.recipename, 
                ReversedRecipe = concat(upper(substring(reverse(r.RecipeName), 1,1)), lower(SUBSTRING(reverse(r.RecipeName), 2,LEN(r.recipename)))), 
                NewPicture = replace(CONCAT('Recipe_', upper(substring(reverse(r.RecipeName), 1,1)), lower(SUBSTRING(reverse(r.RecipeName), 2,LEN(r.recipename))), '.jpg'), ' ', '_')
from Recipe r 
join CookBookRecipe cr 
on cr.Recipeid = r.Recipeid

/*
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
    Hint: Use CTE
*/
;with x as(
    select r.RecipeId, Step = max(rs.SequenceVal)
    from Recipe r
    join RecipeStep rs
    on r.RecipeId = rs.RecipeId
    group by r.RecipeId
)
select rs.Instruction
from x
join RecipeStep rs
on rs.SequenceVal = x.Step
and rs.RecipeId = x.RecipeId
/*
For site administration page:
--5 seperate reports
*/
--a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
select s.Username, RecipeStatus = isnull(r.RecipeStatus,''), NumOfRecipes = count(r.RecipeId)
from Staff s
left join Recipe r
on r.StaffId = s.StaffId
group by s.Username, r.RecipeStatus

-- b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
select s.Username, NumOfRecipes = count(*), AvgDaysToPublish = avg(datediff(day,r.DateDrafted,r.DatePublished))
from Staff s
join Recipe r
on s.StaffId = r.StaffId
group by s.Username

--c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
--Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 

select s.Username, NumOfMeals = count(m.MealId), Active = isnull(sum(case when m.Active = 1 then 1 end),0), Inactive = isnull(sum(case when m.Active = 0 then 1 end),0)
from Staff s
left join Meal m
on s.StaffId = m.StaffId
group by s.Username

--d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
--Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
select s.Username, NumOfCookbooks = count(c.CookbookId), Active = isnull(sum(case when c.Active = 1 then 1 end),0), Inactive = isnull(sum(case when c.Active = 0 then 1 end),0)
from Staff s
left join Cookbook c
on s.StaffId = c.StaffId
group by s.Username, c.Active

-- e) List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, NumOfDaysDrafted = datediff(day,r.DateDrafted,r.DateArchived)
from Recipe r
where r.DatePublished is null
and r.RecipeStatus = 'Archived'

/*
For user dashboard page:
*/

-- a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
--Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select

select ItemName = 'Recipes', Count = count(r.RecipeId)--, NumOfMeals = count(distinct m.MealId), NumOfCookbooks = count(distinct c.CookbookId)
from Recipe r
join staff s
on r.StaffId = s.StaffId
where s.Username = 'mike@heartyhearth.com'
union select 'Meals', count(m.MealId)
from Meal m
join staff s
on m.StaffId = s.StaffId
where s.Username = 'mike@heartyhearth.com'
union select 'Cookbooks', count(c.CookbookId)
from Cookbook c
join staff s
on c.StaffId = s.StaffId
where s.Username = 'mike@heartyhearth.com'

--CTE:
;
with ThisUser as (
    select s.StaffId from Staff s where s.Username = 'mike@heartyhearth.com'
)
select ItemName = 'Recipes', Count = count(r.RecipeId)--, NumOfMeals = count(distinct m.MealId), NumOfCookbooks = count(distinct c.CookbookId)
from Recipe r
join ThisUser x 
on r.StaffId = x.StaffId
union select 'Meals', count(m.MealId)
from Meal m
join ThisUser x 
on m.StaffId = x.StaffId
union select 'Cookbooks', count(c.CookbookId)
from Cookbook c
join ThisUser x 
on c.StaffId = x.StaffId


-- b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
select 
    s.Username, 
    r.RecipeName, 
    r.RecipeStatus, 
    HoursBetweenStatuses = 
        datediff(hour,
        case r.RecipeStatus when 'Published' then r.DateDrafted when 'Archived' then isnull(r.DatePublished,r.DateDrafted) end,
        case r.RecipeStatus when 'Published' then r.DatePublished when 'Archived' then r.DateArchived end)
from Staff s
join Recipe r
on r.StaffId = s.StaffId
where s.Username = 'mike@heartyhearth.com'
and r.RecipeStatus <> 'Drafted'

--If they use CTE
;with StatusChangeDates as (
    select r.RecipeId, 
        r.RecipeName,
        r.RecipeStatus, -- or case Status when Published then DatePublished... 
        PreviousStatus = case 
            when r.DateArchived is not null and r.DatePublished is not null then r.DatePublished 
            else r.DateDrafted
        end,
        CurrentStatus = isnull(r.DateArchived, r.DatePublished)
    from Recipe r
    join Staff s
    on r.StaffId = s.StaffId
    where s.Username = 'mike@heartyhearth.com'  
    and r.RecipeStatus <> 'Drafted'  
)
select s.RecipeName,s.RecipeStatus, HoursBetweenStatuses = datediff(hour, PreviousStatus, CurrentStatus)
from StatusChangeDates s

--OPTIONAL CHALLENGE QUESTION
--c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
--Hint: For the number of recipes, use count of records that have a staffid or CTE.
select c.CuisineType, NumOfRecipes = count(case when s.staffid is not null then 1 end)
from Cuisine C 
left join recipe r 
on c.CuisineId = r.CuisineId
left join Staff s
on r.StaffId = s.StaffId
and s.Username = 'mike@heartyhearth.com'
group by c.CuisineType, s.Username
order by NumOfRecipes desc