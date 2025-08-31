# Recipe App

## Background

This project is inspired by the story of **Sanele**, who, after attending his friend Lindiwe’s birthday party and tasting her family’s incredible cooking, decided he wanted to learn how to cook delicious meals himself.

To help him (and others) start this journey, this application was created: a **Recipe App** where users can store, manage, and explore recipes in both a simple and user-friendly way.

---

## Project Overview

The Recipe App is a **C# application** that evolves from a command-line interface to a graphical interface built with **WPF**. It allows users to create, store, and interact with recipes digitally, while also learning core programming concepts such as **object-oriented design, collections, delegates, and GUI development**.

Key features include:

* Adding recipes with ingredients and preparation steps.
* Scaling ingredient quantities (half, double, or triple).
* Resetting recipes to their original state.
* Managing multiple recipes with nutritional details.
* Tracking calories and warning users when limits are exceeded.
* Filtering recipes or building a menu with food group analysis via a pie chart.

---

## Features

### Recipe Management

* Create and store an unlimited number of recipes.
* Add a name, list of ingredients, and preparation steps.
* Ingredients include **name, quantity, unit, calories, and food group**.
* View recipes in a clear, structured format.

### Scaling & Resetting

* Scale recipes by factors of **0.5, 2, or 3**.
* Reset ingredients to their original values at any time.

### Nutrition Tracking

* Automatically calculate the **total calories** of a recipe.
* Alert users when a recipe exceeds **300 calories**.

### Recipe Browsing & Filtering

* Display all recipes alphabetically.
* Filter recipes by:

  * Ingredient name
  * Food group
  * Maximum calories

### Menu & Food Group Analysis

* Select multiple recipes to form a **menu**.
* Generate a **pie chart** showing the food group distribution across the menu.

### User Interface

* **Command Line (initial versions):** Simple text-based input/output.
* **Graphical Interface (final version, WPF):**

  * Buttons, forms, and menus for navigation.
  * Interactive recipe list and filtering options.
  * Data visualization with charts.

---

## Testing

* Unit tests are included to validate key functions such as calorie calculation.
* Tests can be run in Visual Studio via **Test Explorer**.

---

## How to Compile and Run

### Requirements

* [Visual Studio 2022+](https://visualstudio.microsoft.com/)
* [.NET 6.0 or later](https://dotnet.microsoft.com/)

### Steps

1. Clone this repository:

   ```bash
   git clone https://github.com/Lwandle-Chauke/recipe-app.git
   ```
2. Open the solution file (`RecipeApp.sln`) in Visual Studio.
3. Build the solution (`Ctrl+Shift+B`).
4. Run the application (`F5`).

---

## Repository & Versioning

The project is stored on GitHub with version tags marking milestones:

* **Part1** – Initial recipe app (single recipe, console).
* **Part2** – Extended features (multiple recipes, calories, delegates).
* **PoE** – Final graphical version (WPF).

[GitHub Repository Link](https://github.com/Lwandle-Chauke/recipe-app)

---

## Author

**Name:** Lwandle Chauke
**Module:** PROG6212 – Portfolio of Evidence
**Institution:** IIE MSA

---
