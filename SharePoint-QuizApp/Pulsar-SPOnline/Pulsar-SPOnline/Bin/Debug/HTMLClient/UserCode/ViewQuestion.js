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

    if (selectedChoice == null) {
        PlayMusic("Timeout", false);
        alert("Oh no! You ran out of time!");
        //msls.showMessageBox("Oh no! You ran out of time! :-(", {
        //    title: "Pulsar",
        //    buttons: msls.MessageBoxButtons.ok
        //});

        screen.details.properties.Query_GetQuestion.value.AnswerStatus = "Timeout";
    }
    else if (selectedChoice === correctAnswer) {
        resetVariables();
        PlayMusic("Correct", false);
        alert("Yay! You answered correctly!");
        //msls.showMessageBox("Yay! You answered correctly! :-)", {
        //    title: "Pulsar",
        //    buttons: msls.MessageBoxButtons.ok
        //});

        screen.details.properties.Query_GetQuestion.value.AnswerStatus = "Correct";
    }
    else {
        resetVariables();
        PlayMusic("Wrong", false);
        alert("Oh no! Your answer was incorrect!");
        //msls.showMessageBox("Oh no! Your answer was incorrect! :-(", {
        //    title: "Pulsar",
        //    buttons: msls.MessageBoxButtons.ok
        //});

        screen.details.properties.Query_GetQuestion.value.AnswerStatus = "Wrong";
    }


    screen.details.properties.Query_GetQuestion.value.IsAvailable = "False";
    screen.details.properties.Query_GetQuestion.value.SelectedAnswer = selectedChoice;

    //retrieve the "Team" entity item based on the selection in the previous screen
    screen.details.dataWorkspace.Pulsar_DataSource.Teams.filter("Title eq '" + screen.SelectedTeamName + "'").
        execute().then(function (result) { //async call
            screen.details.properties.Query_GetQuestion.value.setTeam(result.results[0]); //store the selected team in the questions list

            myapp.applyChanges().then(function (result) { //save the item (async call)
                resetVariables();
                myapp.navigateHome();
            });
        });
}

myapp.ViewQuestion.ScreenContent_render = function (element, contentItem) {
    // Write code here.
    element.outerHTML = "<div id='countdownDiv'></div>";
};

var timeLeft = 30;
var timerId;
var currentScreen;

function countdown() {
    if (timeLeft == -1) {
        checkAnswer(null, currentScreen);
    } else {
        $('#countdownDiv').text(timeLeft + ' seconds');

        if (timeLeft <= 15 && timeLeft > 10) {
            $('#countdownDiv').css('color', 'orange');
        }
        else if (timeLeft <= 10) {
            $('#countdownDiv').css('color', 'red');
        }

        timeLeft--;
    }

}

myapp.ViewQuestion.created = function (screen) {

    if (timerId == null) {
        timerId = setInterval(countdown, 1000);
    }

    if (currentScreen == null) {
        currentScreen = screen;
    }

    //$(".subControl").on("click", function (e) {
    //    clearTimeout(timerId);
    //    timerId = null;
    //    timeLeft = 30;
    //    checkAnswer(null, currentScreen);
    //    currentScreen = null;
    //    alert('done!');
    //});
};

myapp.ViewQuestion.Details_postRender = function (element, contentItem) {
    $(".msls-back-button").hide();

};

function resetVariables() {
    //  $("audio#background_music").remove();
    clearTimeout(timerId);
    timerId = null;
    timeLeft = 30;
    currentScreen = null;
}
myapp.ViewQuestion.EliminateAnswers_execute = function (screen) {

    var contentValue;
    switch (screen.details.properties.Query_GetQuestion.value.EliminateAnswer1) {
        case 'A': contentValue = screen.findContentItem("AnswerA").value; break;
        case 'B': contentValue = screen.findContentItem("AnswerB").value; break;
        case 'C': contentValue = screen.findContentItem("AnswerC").value; break;
        case 'D': contentValue = screen.findContentItem("AnswerD").value; break;
    }
    $('span.id-element:contains(' + contentValue + ')').css('text-decoration', 'line-through');
    $('span.id-element:contains(' + contentValue + ')').css('background-color', 'red');

    switch (screen.details.properties.Query_GetQuestion.value.EliminateAnswer2) {
        case 'A': contentValue = screen.findContentItem("AnswerA").value; break;
        case 'B': contentValue = screen.findContentItem("AnswerB").value; break;
        case 'C': contentValue = screen.findContentItem("AnswerC").value; break;
        case 'D': contentValue = screen.findContentItem("AnswerD").value; break;
    }
    $('span.id-element:contains(' + contentValue + ')').css('text-decoration', 'line-through');
    $('span.id-element:contains(' + contentValue + ')').css('background-color', 'red');

    screen.findContentItem("EliminateAnswers").isEnabled = false;

};






myapp.ViewQuestion.Sound_Background_render = function (element, contentItem) {
    var audioTag = "<audio id='background_music' autoplay='true' preload=''><source></source></audio>";
    element.outerHTML = audioTag;

    PlayMusic("Thinking", true);
};

function PlayMusic(musicType, loop) {
    var musicFile;

    switch (musicType) {
        case 'Timeout':
            musicFile = 'Content/Sound/out_of_time.mp3';
            break;
        case 'Correct':
            musicFile = 'Content/Sound/correct_answer.mp3';
            break;
        case 'Wrong':
            musicFile = 'Content/Sound/wrong_answer.mp3';
            break;
        case 'Thinking':
            musicFile = 'Content/Sound/background_countdown.mp3';
            break;
    }
    var audioPlayer = $("audio#background_music")[0];
    audioPlayer.pause();
    audioPlayer.loop = loop;
    audioPlayer.src = musicFile;
    audioPlayer.load();
    audioPlayer.play();
    //$("audio#background_music").append("<source src='"+musicFile+"' type='audio/mp3'></source>");
}