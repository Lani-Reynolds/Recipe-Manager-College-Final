# RecipeManager
 Recipe Manager using Winforms for Final Project

# Feature List
*\<FeatureDescription> ~ \<Implement>*
 - [x] Options ~ Dropdown Menu
    - [x] Create New Recipe ~ Menu Option
      - [x] Clear Recipe Editing Contents ~ `private void ClearContentBoxes()`
    - [x] Save Recipe ~ Menu Option
      - [ ] Save Current Recipe ~ `private void tsmiSave_Click(object sender, EventArgs e)`
      - [ ] Confirm Save ~ Formatted MessageBox
    - [x] Delete Recipe ~ Menu Option
      - [x] Delete Current Recipe File ~ `private void tsmiDelete_Click(object sender, EventArgs e)`
      - [x] Confirm Delete ~ Formatted MessageBox
      - [x] Clear Recipe editing Contents ~ `private void ClearContentBoxes()`
    - [x] Help ~ Menu Option/frmHelp
      - [x] Controls ~ Button
        - [ ] Display Conrols ~ GroupBox
       - [x] Ingredients Format ~ Button
        - [ ] Display Ingredients Format ~ GroupBox
       - [x] Directions Format ~ Button
        - [ ] Display Directions Format ~ GroupBox
 - [x] Recipe List ~ ListBox
    - [ ] Load Recipe Contents in Textboxes ~ `private void lbRecipeList_SelectedValueChanged(object sender, EventArgs e)`
    - [ ] Double Click Recipe to View ~ Formatted MessageBox
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
 - [ ] Is Present ~ `private string IsPresent(TextBox textBox, string name)`
    - [ ] Recipe Name ~ Check in `IsValidData()`
    - [ ] Recipe Description ~ Check in `IsValidData()`
    - [ ] Recipe Ingredient List ~ Check in `IsValidData()`
    - [ ] Recipe Directions ~ Check in `IsValidData()`
 - [ ] Is Valid Data ~ `private bool IsValidData()`
    - [ ] Is Present
 - [x] Exit ~ Button



 - [ ] Extra Features
    - [ ] Recipe List ~ ListBox
       - [ ] Categorizing ~ (Some kind of togglable dropdown)
   - [ ] Save Recipe As ~ Menu Option ?
 - [ ] Recipe Editing Contents Display ~ Multiple TextBoxes
    - [ ] Recipe Category ~ TextBox
 - [ ] Change Display Font ~ Button

 - [ ] Creative Addons
    - [ ] Alternative Colors For Form
    - [x] Alternative Font
    - [x] Custom Icon
    - [ ] Pictures For Help Form
    - [ ] Image Attachment Option (For the Recipes)