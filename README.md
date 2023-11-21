# RecipeManager
 Recipe Manager using Winforms for Final Project

# Feature List
*\<FeatureDescription> ~ \<Implement>*
 - [x] Options ~ Dropdown Menu
    - [x] Create New Recipe ~ Menu Option
      - [x] Clear Recipe Editing Contents ~ `private void ClearContentBoxes()`
    - [x] Save Recipe ~ Menu Option
      - [x] Save Current Recipe ~ `private void tsmiSave_Click(object sender, EventArgs e)`
      - [x] Confirm Save ~ Formatted MessageBox
    - [x] Delete Recipe ~ Menu Option
      - [x] Delete Current Recipe File ~ `private void tsmiDelete_Click(object sender, EventArgs e)`
      - [x] Confirm Delete ~ Formatted MessageBox
      - [x] Clear Recipe editing Contents ~ `private void ClearContentBoxes()`
    - [x] Help ~ Formatted MessageBox
 - [x] Recipe List ~ ListBox
    - [x] Load Recipe Contents in Textboxes ~ `private void lbRecipeList_SelectedValueChanged(object sender, EventArgs e)`
 - [x] Recipe Editing Contents Display ~ Multiple TextBoxes
    - [x] Recipe Name ~ TextBox
    - [x] Recipe Description ~ RichTextBox
    - [x] Recipe Ingredient List ~ RichTextBox
       - [x] Bullet Point Toggle ~ `rtxt_KeyDown(object sender, KeyEventArgs e)`
    - [x] Recipe Directions ~ RichTextBox
       - [x] Bullet Point Toggle ~ `rtxt_KeyDown(object sender, KeyEventArgs e)`
 - [x] File Path Generator ~ `GenerateRecipePath()`
 - [x] File Loader ~ `private void Load_Files()`
    - [x] Load Recipe Names ~ Iterate through files and find names
    - [x] Display Recipe Names ~ Display names in the recipe list box
 - [x] Is Present ~ `private string IsPresent(TextBox textBox, string name)`
    - [x] Recipe Name ~ Check in `IsValidData()`
    - [x] Recipe Description ~ Check in `IsValidData()`
    - [x] Recipe Ingredient List ~ Check in `IsValidData()`
    - [x] Recipe Directions ~ Check in `IsValidData()`
 - [x] Time Is Present ~ `private bool TimeIsPresent(GroupBox groupBox)`
    - [x] Prep Time ~ Check in `IsValidData()`
    - [x] Cook Time ~ Check in `IsValidData()`
 - [x] Is Valid Data ~ `private bool IsValidData()`
    - [x] Is Present
    - [x] Time Is Present
 - [x] Exit ~ Button

 - [ ] Implement better time formats
 - [ ] Themes
 - [ ] Author saving, and loading
 - [ ] Ctrl-+ & Ctrl-- to resize font



 - [ ] Extra Features
    - [ ] Recipe List ~ ListBox
       - [ ] Categorizing ~ (Some kind of togglable dropdown)
   - [ ] Save Recipe As ~ Menu Option ?
 - [ ] Recipe Editing Contents Display ~ Multiple TextBoxes
    - [ ] Recipe Category ~ TextBox
 - [ ] Change Display Font ~ Button

 - [ ] Creative Addons
    - [x] Alternative Colors For Form
    - [x] Alternative Font
    - [x] Custom Icon
    - [ ] Image Attachment Option (For the Recipes)