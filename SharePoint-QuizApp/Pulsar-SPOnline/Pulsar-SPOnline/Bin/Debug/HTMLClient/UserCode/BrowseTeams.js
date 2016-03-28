/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.BrowseTeams.Title_Tap_execute = function (screen) {
    var selectedTeamName = screen.details.properties.Teams.value.selectedItem.Title;
    var selectedTeamId = screen.details.properties.Teams.value.selectedItem.Id;
    myapp.showBrowseCategories(selectedTeamName, selectedTeamId);
};