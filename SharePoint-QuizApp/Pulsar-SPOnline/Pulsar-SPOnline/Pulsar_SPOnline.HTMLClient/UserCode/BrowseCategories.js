/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.BrowseCategories.Title_Tap_execute = function (screen) {
    var selectedCategory = screen.details.properties.Categories.value.selectedItem.Title;
    myapp.showViewQuestion(screen.SelectedTeamName, screen.SelectedTeamId, selectedCategory);
};