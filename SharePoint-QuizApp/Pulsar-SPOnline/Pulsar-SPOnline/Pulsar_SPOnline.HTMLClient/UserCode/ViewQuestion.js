/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.ViewQuestion.AnswerA_Tap_execute = function (screen) {
    checkAnswer("A", screen);
};

myapp.ViewQuestion.AnswerB_Tap_execute = function (screen) {
    checkAnswer("B", screen);
};

myapp.ViewQuestion.AnswerC_Tap_execute = function (screen) {
    checkAnswer("C", screen);
};

myapp.ViewQuestion.AnswerD_Tap_execute = function (screen) {
    checkAnswer("D", screen);
};




function checkAnswer(selectedChoice, screen) {
    var correctAnswer = screen.details.properties.Query_GetQuestion.value.CorrectAnswer;

    if (selectedChoice === correctAnswer) {
        alert("Correct Answer!");
        screen.details.properties.Query_GetQuestion.value.AnswerStatus = "Correct";
    }
    else {
        alert("Wrong Answer!");
        screen.details.properties.Query_GetQuestion.value.AnswerStatus = "Wrong";
    }


    screen.details.properties.Query_GetQuestion.value.IsAvailable = "False";
    screen.details.properties.Query_GetQuestion.value.SelectedAnswer = selectedChoice;

    //retrieve the "Team" entity item based on the selection in the previous screen
    screen.details.dataWorkspace.Pulsar_DataSource.Teams.filter("Title eq '" + screen.SelectedTeamName + "'").
        execute().then(function (result) { //async call
            screen.details.properties.Query_GetQuestion.value.setTeam(result.results[0]); //store the selected team in the questions list

            myapp.applyChanges().then(function (result) { //save the item (async call)
                alert("Item Saved!");
                myapp.navigateHome();
            });
        });
}
