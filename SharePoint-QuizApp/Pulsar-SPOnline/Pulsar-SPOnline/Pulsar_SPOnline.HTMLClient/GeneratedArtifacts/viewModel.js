/// <reference path="data.js" />

(function (lightSwitchApplication) {

    var $Screen = msls.Screen,
        $defineScreen = msls._defineScreen,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString,
        $defineShowScreen = msls._defineShowScreen;

    function BrowseTeams(parameters, dataWorkspace) {
        /// <summary>
        /// Select a team
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="Teams" type="msls.VisualCollection" elementType="msls.application.Team">
        /// Gets the teams for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseTeams.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseTeams", parameters);
    }

    function BrowseCategories(parameters, dataWorkspace) {
        /// <summary>
        /// Select a category
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="SelectedTeamName" type="String">
        /// Gets or sets the selectedTeamName for this screen.
        /// </field>
        /// <field name="SelectedTeamId" type="Number">
        /// Gets or sets the selectedTeamId for this screen.
        /// </field>
        /// <field name="Categories" type="msls.VisualCollection" elementType="msls.application.Category">
        /// Gets the categories for this screen.
        /// </field>
        /// <field name="details" type="msls.application.BrowseCategories.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "BrowseCategories", parameters);
    }

    function ViewQuestion(parameters, dataWorkspace) {
        /// <summary>
        /// Represents the ViewQuestion screen.
        /// </summary>
        /// <param name="parameters" type="Array">
        /// An array of screen parameter values.
        /// </param>
        /// <param name="dataWorkspace" type="msls.application.DataWorkspace" optional="true">
        /// An existing data workspace for this screen to use. By default, a new data workspace is created.
        /// </param>
        /// <field name="SelectedTeamName" type="String">
        /// Gets or sets the selectedTeamName for this screen.
        /// </field>
        /// <field name="SelectedTeamId" type="Number">
        /// Gets or sets the selectedTeamId for this screen.
        /// </field>
        /// <field name="SelectedCategory" type="String">
        /// Gets or sets the selectedCategory for this screen.
        /// </field>
        /// <field name="Query_GetQuestion" type="msls.application.Question">
        /// Gets the query_GetQuestion for this screen.
        /// </field>
        /// <field name="details" type="msls.application.ViewQuestion.Details">
        /// Gets the details for this screen.
        /// </field>
        if (!dataWorkspace) {
            dataWorkspace = new lightSwitchApplication.DataWorkspace();
        }
        $Screen.call(this, dataWorkspace, "ViewQuestion", parameters);
    }

    msls._addToNamespace("msls.application", {

        BrowseTeams: $defineScreen(BrowseTeams, [
            {
                name: "Teams", kind: "collection", elementType: lightSwitchApplication.Team,
                createQuery: function () {
                    return this.dataWorkspace.Pulsar_DataSource.Teams.orderBy("Title");
                }
            }
        ], [
            { name: "Title_Tap" }
        ]),

        BrowseCategories: $defineScreen(BrowseCategories, [
            { name: "SelectedTeamName", kind: "local", type: String },
            { name: "SelectedTeamId", kind: "local", type: Number },
            {
                name: "Categories", kind: "collection", elementType: lightSwitchApplication.Category,
                createQuery: function () {
                    return this.dataWorkspace.Pulsar_DataSource.Categories.orderBy("Title");
                }
            }
        ], [
            { name: "Title_Tap" }
        ]),

        ViewQuestion: $defineScreen(ViewQuestion, [
            { name: "SelectedTeamName", kind: "local", type: String },
            { name: "SelectedTeamId", kind: "local", type: Number },
            { name: "SelectedCategory", kind: "local", type: String },
            {
                name: "Query_GetQuestion", kind: "reference", type: lightSwitchApplication.Question,
                createQuery: function (SelectedCategory_Parameter) {
                    return this.dataWorkspace.Pulsar_DataSource.Query_GetQuestion(SelectedCategory_Parameter);
                }
            }
        ], [
            { name: "AnswerA_Tap" },
            { name: "AnswerB_Tap" },
            { name: "AnswerC_Tap" },
            { name: "AnswerD_Tap" }
        ]),

        showBrowseTeams: $defineShowScreen(function showBrowseTeams(options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseTeams screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 0);
            return lightSwitchApplication.showScreen("BrowseTeams", parameters, options);
        }),

        showBrowseCategories: $defineShowScreen(function showBrowseCategories(SelectedTeamName, SelectedTeamId, options) {
            /// <summary>
            /// Asynchronously navigates forward to the BrowseCategories screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 2);
            return lightSwitchApplication.showScreen("BrowseCategories", parameters, options);
        }),

        showViewQuestion: $defineShowScreen(function showViewQuestion(SelectedTeamName, SelectedTeamId, SelectedCategory, options) {
            /// <summary>
            /// Asynchronously navigates forward to the ViewQuestion screen.
            /// </summary>
            /// <param name="options" optional="true">
            /// An object that provides one or more of the following options:<br/>- beforeShown: a function that is called after boundary behavior has been applied but before the screen is shown.<br/>+ Signature: beforeShown(screen)<br/>- afterClosed: a function that is called after boundary behavior has been applied and the screen has been closed.<br/>+ Signature: afterClosed(screen, action : msls.NavigateBackAction)
            /// </param>
            /// <returns type="WinJS.Promise" />
            var parameters = Array.prototype.slice.call(arguments, 0, 3);
            return lightSwitchApplication.showScreen("ViewQuestion", parameters, options);
        })

    });

}(msls.application));
