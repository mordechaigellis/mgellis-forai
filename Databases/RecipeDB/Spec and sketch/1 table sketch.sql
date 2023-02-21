-- We need a total of 13 tables.
/*
Staff
    StaffId int pk
    FirstName varchar(25) not null not blank
    LastName varchar(25) not null not blank
    Username varchar(25) not null not blank unique

Cuisine
    CuisineId int pk
    CuisineType varchar(25) not null not blank unique

Measurement
    MeasurementId int pk
    MeasurementType varchar(10) not null not blank unique

Ingredient
    IngredientId int pk
    Ingredient varchar(25) not null not blank unique
    computed ImageName like ingredient_name.jpg

Recipe
    RecipeId int pk
    StaffId int not null fk Staff(StaffId)
    CuisineId int not null fk Cuisine(CuisineId)
    RecipeName varchar(100) not null not blank unique
    Calories int not null > 0
    DateDrafted datetime not null <= today 
        default getdate()
    DatePublished datetime
    DateArchived datetime
    constraint
        DatePublished between DateDrafted and today
        (DatePublished is null and DateArchived between DateDrafted and today) or DateArchived between DatePublished and today
    computed ImageName like recipe-name.jpg 
    computed RecipeStatus Archived where DateArchived <> null, Published where DateArchived = null and DatePublished <> null, else Drafted

RecipeIngredient
    RecipeIngredientId int pk
    MeasurementId int null fk Measurement(MeasurementId)
    IngredientId int not null fk Ingredients(IngredientsId)
    RecipeId int not null fk Recipe(RecipeId)
    SequenceVal int not null > 0
    Amount decimal(4,2) not null > 0
    RecipeId SequenceVal unique
    RecipeId IngredientId unique

RecipeStep
    RecipeStepId int pk
    RecipeId int not null fk Recipe(RecipeId)
    SequenceVal int not null > 0
    Instruction varchar(100) not null not blank
    RecipeId SequenceVal unique

Course
    CourseId int pk
    SequenceVal int not null > 0 unique
    CourseName varchar(20) not null not blank unique

Meal
    MealId int pk
    StaffId int not null fk Staff(StaffId)
    MealName varchar(100) not null not blank unique
    Active bit not null default true
    DateCreated date not null <= today
    computed ImageName like meal_name.jpg

MealCourse
    MealCourseId int pk
    MealId int not null fk Meal(MealId)
    CourseId int not null fk Course(CourseId)
    MealId CourseId unique

MealCourseRecipe
    MealCourseRecipeId int pk
    MealCourseId int not null fk MealCourse(MealCourseId)
    RecipeId int not null fk Recipe(RecipeId)
    IsMain bit not null
    MealCourseId RecipeId unique

Cookbook
    CookbookId int pk
    StaffId int not null fk Staff(StaffId)
    CookbookName varchar(50) not null not blank unique
    Price decimal(5,2) not null > 0
    Active bit not null default true
    DateCreated date not null <= today
    computed ImageName like cookbook_name.jpg 

CookbookRecipe
    CookbookRecipeId int pk
    CookbookId int not null fk Cookbook(CookbookId)
    RecipeId int not null fk Recipe(RecipeId)
    SequenceVal int not null > 0
    CookbookId RecipeId unique

*/