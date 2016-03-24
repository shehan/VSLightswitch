/// <reference path="viewModel.js" />

(function (lightSwitchApplication) {

    var $parameters = [document.createElement("div"), msls.ContentItem];

    msls._addEntryPoints(lightSwitchApplication.BrowseTeams, {
        /// <field>
        /// Called when a new BrowseTeams screen is created.
        /// <br/>created(msls.application.BrowseTeams screen)
        /// </field>
        created: [lightSwitchApplication.BrowseTeams],
        /// <field>
        /// Called before changes on an active BrowseTeams screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseTeams screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseTeams],
        /// <field>
        /// Called to determine if the Title_Tap method can be executed.
        /// <br/>canExecute(msls.application.BrowseTeams screen)
        /// </field>
        Title_Tap_canExecute: [lightSwitchApplication.BrowseTeams],
        /// <field>
        /// Called to execute the Title_Tap method.
        /// <br/>execute(msls.application.BrowseTeams screen)
        /// </field>
        Title_Tap_execute: [lightSwitchApplication.BrowseTeams],
        /// <field>
        /// Called after the TeamList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        TeamList_postRender: $parameters,
        /// <field>
        /// Called after the Team content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Team_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters,
        /// <field>
        /// Called after the Title content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Title_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.BrowseCategories, {
        /// <field>
        /// Called when a new BrowseCategories screen is created.
        /// <br/>created(msls.application.BrowseCategories screen)
        /// </field>
        created: [lightSwitchApplication.BrowseCategories],
        /// <field>
        /// Called before changes on an active BrowseCategories screen are applied.
        /// <br/>beforeApplyChanges(msls.application.BrowseCategories screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.BrowseCategories],
        /// <field>
        /// Called to determine if the Title_Tap method can be executed.
        /// <br/>canExecute(msls.application.BrowseCategories screen)
        /// </field>
        Title_Tap_canExecute: [lightSwitchApplication.BrowseCategories],
        /// <field>
        /// Called to execute the Title_Tap method.
        /// <br/>execute(msls.application.BrowseCategories screen)
        /// </field>
        Title_Tap_execute: [lightSwitchApplication.BrowseCategories],
        /// <field>
        /// Called after the CategoryList content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        CategoryList_postRender: $parameters,
        /// <field>
        /// Called after the SelectedTeamName content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SelectedTeamName_postRender: $parameters,
        /// <field>
        /// Called after the SelectedTeamId content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SelectedTeamId_postRender: $parameters,
        /// <field>
        /// Called after the Category content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Category_postRender: $parameters,
        /// <field>
        /// Called after the RowTemplate content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        RowTemplate_postRender: $parameters,
        /// <field>
        /// Called after the Title content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Title_postRender: $parameters
    });

    msls._addEntryPoints(lightSwitchApplication.ViewQuestion, {
        /// <field>
        /// Called when a new ViewQuestion screen is created.
        /// <br/>created(msls.application.ViewQuestion screen)
        /// </field>
        created: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called before changes on an active ViewQuestion screen are applied.
        /// <br/>beforeApplyChanges(msls.application.ViewQuestion screen)
        /// </field>
        beforeApplyChanges: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called to determine if the AnswerA_Tap method can be executed.
        /// <br/>canExecute(msls.application.ViewQuestion screen)
        /// </field>
        AnswerA_Tap_canExecute: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called to execute the AnswerA_Tap method.
        /// <br/>execute(msls.application.ViewQuestion screen)
        /// </field>
        AnswerA_Tap_execute: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called to determine if the AnswerB_Tap method can be executed.
        /// <br/>canExecute(msls.application.ViewQuestion screen)
        /// </field>
        AnswerB_Tap_canExecute: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called to execute the AnswerB_Tap method.
        /// <br/>execute(msls.application.ViewQuestion screen)
        /// </field>
        AnswerB_Tap_execute: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called to determine if the AnswerC_Tap method can be executed.
        /// <br/>canExecute(msls.application.ViewQuestion screen)
        /// </field>
        AnswerC_Tap_canExecute: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called to execute the AnswerC_Tap method.
        /// <br/>execute(msls.application.ViewQuestion screen)
        /// </field>
        AnswerC_Tap_execute: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called to determine if the AnswerD_Tap method can be executed.
        /// <br/>canExecute(msls.application.ViewQuestion screen)
        /// </field>
        AnswerD_Tap_canExecute: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called to execute the AnswerD_Tap method.
        /// <br/>execute(msls.application.ViewQuestion screen)
        /// </field>
        AnswerD_Tap_execute: [lightSwitchApplication.ViewQuestion],
        /// <field>
        /// Called after the Details content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Details_postRender: $parameters,
        /// <field>
        /// Called after the SelectedTeamName content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SelectedTeamName_postRender: $parameters,
        /// <field>
        /// Called after the SelectedTeamId content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SelectedTeamId_postRender: $parameters,
        /// <field>
        /// Called after the SelectedCategory content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SelectedCategory_postRender: $parameters,
        /// <field>
        /// Called after the Query_GetQuestion content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Query_GetQuestion_postRender: $parameters,
        /// <field>
        /// Called after the Title content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Title_postRender: $parameters,
        /// <field>
        /// Called after the AnswerA content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AnswerA_postRender: $parameters,
        /// <field>
        /// Called after the AnswerB content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AnswerB_postRender: $parameters,
        /// <field>
        /// Called after the AnswerC content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AnswerC_postRender: $parameters,
        /// <field>
        /// Called after the AnswerD content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AnswerD_postRender: $parameters,
        /// <field>
        /// Called after the CorrectAnswer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        CorrectAnswer_postRender: $parameters,
        /// <field>
        /// Called after the EliminateAnswer1 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EliminateAnswer1_postRender: $parameters,
        /// <field>
        /// Called after the EliminateAnswer2 content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        EliminateAnswer2_postRender: $parameters,
        /// <field>
        /// Called after the IsAvailable content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        IsAvailable_postRender: $parameters,
        /// <field>
        /// Called after the SelectedAnswer content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        SelectedAnswer_postRender: $parameters,
        /// <field>
        /// Called after the AnswerStatus content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        AnswerStatus_postRender: $parameters,
        /// <field>
        /// Called after the ContentType content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ContentType_postRender: $parameters,
        /// <field>
        /// Called after the Category content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Category_postRender: $parameters,
        /// <field>
        /// Called after the Team content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        Team_postRender: $parameters,
        /// <field>
        /// Called after the CreatedBy content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        CreatedBy_postRender: $parameters,
        /// <field>
        /// Called after the ModifiedBy content item has been rendered.
        /// <br/>postRender(HTMLElement element, msls.ContentItem contentItem)
        /// </field>
        ModifiedBy_postRender: $parameters
    });

}(msls.application));
