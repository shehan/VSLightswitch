/// <reference path="../Scripts/msls-1.0.0.js" />

window.myapp = msls.application;

(function (lightSwitchApplication) {

    var $Entity = msls.Entity,
        $DataService = msls.DataService,
        $DataWorkspace = msls.DataWorkspace,
        $defineEntity = msls._defineEntity,
        $defineDataService = msls._defineDataService,
        $defineDataWorkspace = msls._defineDataWorkspace,
        $DataServiceQuery = msls.DataServiceQuery,
        $toODataString = msls._toODataString;

    function Category(entitySet) {
        /// <summary>
        /// Represents the Category entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this category.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this category.
        /// </field>
        /// <field name="ContentType" type="String">
        /// Gets or sets the contentType for this category.
        /// </field>
        /// <field name="Title" type="String">
        /// Gets or sets the title for this category.
        /// </field>
        /// <field name="ContentTypeID" type="String">
        /// Gets or sets the contentTypeID for this category.
        /// </field>
        /// <field name="Modified" type="Date">
        /// Gets or sets the modified for this category.
        /// </field>
        /// <field name="Created" type="Date">
        /// Gets or sets the created for this category.
        /// </field>
        /// <field name="Owshiddenversion" type="Number">
        /// Gets or sets the owshiddenversion for this category.
        /// </field>
        /// <field name="Version" type="String">
        /// Gets or sets the version for this category.
        /// </field>
        /// <field name="Path" type="String">
        /// Gets or sets the path for this category.
        /// </field>
        /// <field name="CreatedBy" type="msls.application.UserInformationList">
        /// Gets or sets the createdBy for this category.
        /// </field>
        /// <field name="ModifiedBy" type="msls.application.UserInformationList">
        /// Gets or sets the modifiedBy for this category.
        /// </field>
        /// <field name="details" type="msls.application.Category.Details">
        /// Gets the details for this category.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Team(entitySet) {
        /// <summary>
        /// Represents the Team entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this team.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this team.
        /// </field>
        /// <field name="ContentType" type="String">
        /// Gets or sets the contentType for this team.
        /// </field>
        /// <field name="Title" type="String">
        /// Gets or sets the title for this team.
        /// </field>
        /// <field name="ContentTypeID" type="String">
        /// Gets or sets the contentTypeID for this team.
        /// </field>
        /// <field name="Modified" type="Date">
        /// Gets or sets the modified for this team.
        /// </field>
        /// <field name="Created" type="Date">
        /// Gets or sets the created for this team.
        /// </field>
        /// <field name="Owshiddenversion" type="Number">
        /// Gets or sets the owshiddenversion for this team.
        /// </field>
        /// <field name="Version" type="String">
        /// Gets or sets the version for this team.
        /// </field>
        /// <field name="Path" type="String">
        /// Gets or sets the path for this team.
        /// </field>
        /// <field name="CreatedBy" type="msls.application.UserInformationList">
        /// Gets or sets the createdBy for this team.
        /// </field>
        /// <field name="ModifiedBy" type="msls.application.UserInformationList">
        /// Gets or sets the modifiedBy for this team.
        /// </field>
        /// <field name="details" type="msls.application.Team.Details">
        /// Gets the details for this team.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function UserInformationList(entitySet) {
        /// <summary>
        /// All people.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this userInformationList.
        /// </param>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this userInformationList.
        /// </field>
        /// <field name="ContentType" type="String">
        /// Gets or sets the contentType for this userInformationList.
        /// </field>
        /// <field name="ContentTypeID" type="String">
        /// Gets or sets the contentTypeID for this userInformationList.
        /// </field>
        /// <field name="Name" type="String">
        /// Gets or sets the name for this userInformationList.
        /// </field>
        /// <field name="Account" type="String">
        /// Gets or sets the account for this userInformationList.
        /// </field>
        /// <field name="WorkEmail" type="String">
        /// Gets or sets the workEmail for this userInformationList.
        /// </field>
        /// <field name="MobilePhone" type="String">
        /// Gets or sets the mobilePhone for this userInformationList.
        /// </field>
        /// <field name="AboutMe" type="String">
        /// Gets or sets the aboutMe for this userInformationList.
        /// </field>
        /// <field name="SIPAddress" type="String">
        /// Gets or sets the sIPAddress for this userInformationList.
        /// </field>
        /// <field name="IsSiteAdmin" type="Boolean">
        /// Gets or sets the isSiteAdmin for this userInformationList.
        /// </field>
        /// <field name="Deleted" type="Boolean">
        /// Gets or sets the deleted for this userInformationList.
        /// </field>
        /// <field name="Hidden" type="Boolean">
        /// Gets or sets the hidden for this userInformationList.
        /// </field>
        /// <field name="Picture" type="String">
        /// Gets or sets the picture for this userInformationList.
        /// </field>
        /// <field name="Department" type="String">
        /// Gets or sets the department for this userInformationList.
        /// </field>
        /// <field name="Title" type="String">
        /// Gets or sets the title for this userInformationList.
        /// </field>
        /// <field name="FirstName" type="String">
        /// Gets or sets the firstName for this userInformationList.
        /// </field>
        /// <field name="LastName" type="String">
        /// Gets or sets the lastName for this userInformationList.
        /// </field>
        /// <field name="WorkPhone" type="String">
        /// Gets or sets the workPhone for this userInformationList.
        /// </field>
        /// <field name="UserName" type="String">
        /// Gets or sets the userName for this userInformationList.
        /// </field>
        /// <field name="WebSite" type="String">
        /// Gets or sets the webSite for this userInformationList.
        /// </field>
        /// <field name="AskMeAbout" type="String">
        /// Gets or sets the askMeAbout for this userInformationList.
        /// </field>
        /// <field name="Office" type="String">
        /// Gets or sets the office for this userInformationList.
        /// </field>
        /// <field name="PictureTimestamp" type="String">
        /// Gets or sets the pictureTimestamp for this userInformationList.
        /// </field>
        /// <field name="PicturePlaceholderState" type="Number">
        /// Gets or sets the picturePlaceholderState for this userInformationList.
        /// </field>
        /// <field name="PictureExchangeSyncState" type="Number">
        /// Gets or sets the pictureExchangeSyncState for this userInformationList.
        /// </field>
        /// <field name="Modified" type="Date">
        /// Gets or sets the modified for this userInformationList.
        /// </field>
        /// <field name="Created" type="Date">
        /// Gets or sets the created for this userInformationList.
        /// </field>
        /// <field name="Owshiddenversion" type="Number">
        /// Gets or sets the owshiddenversion for this userInformationList.
        /// </field>
        /// <field name="Version" type="String">
        /// Gets or sets the version for this userInformationList.
        /// </field>
        /// <field name="Path" type="String">
        /// Gets or sets the path for this userInformationList.
        /// </field>
        /// <field name="CreatedBy" type="msls.application.UserInformationList">
        /// Gets or sets the createdBy for this userInformationList.
        /// </field>
        /// <field name="ModifiedBy" type="msls.application.UserInformationList">
        /// Gets or sets the modifiedBy for this userInformationList.
        /// </field>
        /// <field name="details" type="msls.application.UserInformationList.Details">
        /// Gets the details for this userInformationList.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Question(entitySet) {
        /// <summary>
        /// Represents the Question entity type.
        /// </summary>
        /// <param name="entitySet" type="msls.EntitySet" optional="true">
        /// The entity set that should contain this question.
        /// </param>
        /// <field name="Title" type="String">
        /// Gets or sets the title for this question.
        /// </field>
        /// <field name="AnswerA" type="String">
        /// Gets or sets the answerA for this question.
        /// </field>
        /// <field name="AnswerB" type="String">
        /// Gets or sets the answerB for this question.
        /// </field>
        /// <field name="AnswerC" type="String">
        /// Gets or sets the answerC for this question.
        /// </field>
        /// <field name="AnswerD" type="String">
        /// Gets or sets the answerD for this question.
        /// </field>
        /// <field name="CorrectAnswer" type="String">
        /// Gets or sets the correctAnswer for this question.
        /// </field>
        /// <field name="EliminateAnswer1" type="String">
        /// Gets or sets the eliminateAnswer1 for this question.
        /// </field>
        /// <field name="EliminateAnswer2" type="String">
        /// Gets or sets the eliminateAnswer2 for this question.
        /// </field>
        /// <field name="IsAvailable" type="Boolean">
        /// Gets or sets the isAvailable for this question.
        /// </field>
        /// <field name="SelectedAnswer" type="String">
        /// Gets or sets the selectedAnswer for this question.
        /// </field>
        /// <field name="AnswerStatus" type="String">
        /// Gets or sets the answerStatus for this question.
        /// </field>
        /// <field name="Id" type="Number">
        /// Gets or sets the id for this question.
        /// </field>
        /// <field name="ContentType" type="String">
        /// Gets or sets the contentType for this question.
        /// </field>
        /// <field name="ContentTypeID" type="String">
        /// Gets or sets the contentTypeID for this question.
        /// </field>
        /// <field name="Modified" type="Date">
        /// Gets or sets the modified for this question.
        /// </field>
        /// <field name="Created" type="Date">
        /// Gets or sets the created for this question.
        /// </field>
        /// <field name="Owshiddenversion" type="Number">
        /// Gets or sets the owshiddenversion for this question.
        /// </field>
        /// <field name="Version" type="String">
        /// Gets or sets the version for this question.
        /// </field>
        /// <field name="Path" type="String">
        /// Gets or sets the path for this question.
        /// </field>
        /// <field name="Category" type="msls.application.Category">
        /// Gets or sets the category for this question.
        /// </field>
        /// <field name="Team" type="msls.application.Team">
        /// Gets or sets the team for this question.
        /// </field>
        /// <field name="CreatedBy" type="msls.application.UserInformationList">
        /// Gets or sets the createdBy for this question.
        /// </field>
        /// <field name="ModifiedBy" type="msls.application.UserInformationList">
        /// Gets or sets the modifiedBy for this question.
        /// </field>
        /// <field name="details" type="msls.application.Question.Details">
        /// Gets the details for this question.
        /// </field>
        $Entity.call(this, entitySet);
    }

    function Pulsar_DataSource(dataWorkspace) {
        /// <summary>
        /// Represents the Pulsar_DataSource data service.
        /// </summary>
        /// <param name="dataWorkspace" type="msls.DataWorkspace">
        /// The data workspace that created this data service.
        /// </param>
        /// <field name="Categories" type="msls.EntitySet">
        /// Gets the Categories entity set.
        /// </field>
        /// <field name="Teams" type="msls.EntitySet">
        /// Gets the Teams entity set.
        /// </field>
        /// <field name="UserInformationLists" type="msls.EntitySet">
        /// Gets the UserInformationLists entity set.
        /// </field>
        /// <field name="Questions" type="msls.EntitySet">
        /// Gets the Questions entity set.
        /// </field>
        /// <field name="details" type="msls.application.Pulsar_DataSource.Details">
        /// Gets the details for this data service.
        /// </field>
        $DataService.call(this, dataWorkspace);
    };
    function DataWorkspace() {
        /// <summary>
        /// Represents the data workspace.
        /// </summary>
        /// <field name="Pulsar_DataSource" type="msls.application.Pulsar_DataSource">
        /// Gets the Pulsar_DataSource data service.
        /// </field>
        /// <field name="details" type="msls.application.DataWorkspace.Details">
        /// Gets the details for this data workspace.
        /// </field>
        $DataWorkspace.call(this);
    };

    msls._addToNamespace("msls.application", {

        Category: $defineEntity(Category, [
            { name: "Id", type: Number },
            { name: "ContentType", type: String },
            { name: "Title", type: String },
            { name: "ContentTypeID", type: String },
            { name: "Modified", type: Date },
            { name: "Created", type: Date },
            { name: "Owshiddenversion", type: Number },
            { name: "Version", type: String },
            { name: "Path", type: String },
            { name: "CreatedBy", kind: "reference", type: UserInformationList },
            { name: "ModifiedBy", kind: "reference", type: UserInformationList }
        ]),

        Team: $defineEntity(Team, [
            { name: "Id", type: Number },
            { name: "ContentType", type: String },
            { name: "Title", type: String },
            { name: "ContentTypeID", type: String },
            { name: "Modified", type: Date },
            { name: "Created", type: Date },
            { name: "Owshiddenversion", type: Number },
            { name: "Version", type: String },
            { name: "Path", type: String },
            { name: "CreatedBy", kind: "reference", type: UserInformationList },
            { name: "ModifiedBy", kind: "reference", type: UserInformationList }
        ]),

        UserInformationList: $defineEntity(UserInformationList, [
            { name: "Id", type: Number },
            { name: "ContentType", type: String },
            { name: "ContentTypeID", type: String },
            { name: "Name", type: String },
            { name: "Account", type: String },
            { name: "WorkEmail", type: String },
            { name: "MobilePhone", type: String },
            { name: "AboutMe", type: String },
            { name: "SIPAddress", type: String },
            { name: "IsSiteAdmin", type: Boolean },
            { name: "Deleted", type: Boolean },
            { name: "Hidden", type: Boolean },
            { name: "Picture", type: String },
            { name: "Department", type: String },
            { name: "Title", type: String },
            { name: "FirstName", type: String },
            { name: "LastName", type: String },
            { name: "WorkPhone", type: String },
            { name: "UserName", type: String },
            { name: "WebSite", type: String },
            { name: "AskMeAbout", type: String },
            { name: "Office", type: String },
            { name: "PictureTimestamp", type: String },
            { name: "PicturePlaceholderState", type: Number },
            { name: "PictureExchangeSyncState", type: Number },
            { name: "Modified", type: Date },
            { name: "Created", type: Date },
            { name: "Owshiddenversion", type: Number },
            { name: "Version", type: String },
            { name: "Path", type: String },
            { name: "CreatedBy", kind: "reference", type: UserInformationList },
            { name: "ModifiedBy", kind: "reference", type: UserInformationList }
        ]),

        Question: $defineEntity(Question, [
            { name: "Title", type: String },
            { name: "AnswerA", type: String },
            { name: "AnswerB", type: String },
            { name: "AnswerC", type: String },
            { name: "AnswerD", type: String },
            { name: "CorrectAnswer", type: String },
            { name: "EliminateAnswer1", type: String },
            { name: "EliminateAnswer2", type: String },
            { name: "IsAvailable", type: Boolean },
            { name: "SelectedAnswer", type: String },
            { name: "AnswerStatus", type: String },
            { name: "Id", type: Number },
            { name: "ContentType", type: String },
            { name: "ContentTypeID", type: String },
            { name: "Modified", type: Date },
            { name: "Created", type: Date },
            { name: "Owshiddenversion", type: Number },
            { name: "Version", type: String },
            { name: "Path", type: String },
            { name: "Category", kind: "reference", type: Category },
            { name: "Team", kind: "reference", type: Team },
            { name: "CreatedBy", kind: "reference", type: UserInformationList },
            { name: "ModifiedBy", kind: "reference", type: UserInformationList }
        ]),

        Pulsar_DataSource: $defineDataService(Pulsar_DataSource, lightSwitchApplication.rootUri + "/Pulsar_DataSource.svc", [
            { name: "Categories", elementType: Category },
            { name: "Teams", elementType: Team },
            { name: "UserInformationLists", elementType: UserInformationList },
            { name: "Questions", elementType: Question }
        ], [
            {
                name: "Categories_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Categories },
                        lightSwitchApplication.rootUri + "/Pulsar_DataSource.svc" + "/Categories(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Teams_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Teams },
                        lightSwitchApplication.rootUri + "/Pulsar_DataSource.svc" + "/Teams(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "UserInformationLists_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.UserInformationLists },
                        lightSwitchApplication.rootUri + "/Pulsar_DataSource.svc" + "/UserInformationLists(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Questions_SingleOrDefault", value: function (Id) {
                    return new $DataServiceQuery({ _entitySet: this.Questions },
                        lightSwitchApplication.rootUri + "/Pulsar_DataSource.svc" + "/Questions(" + "Id=" + $toODataString(Id, "Int32?") + ")"
                    );
                }
            },
            {
                name: "Query_GetQuestion", value: function (SelectedCategory_Parameter) {
                    return new $DataServiceQuery({ _entitySet: this.Questions },
                        lightSwitchApplication.rootUri + "/Pulsar_DataSource.svc" + "/Query_GetQuestion",
                        {
                            SelectedCategory_Parameter: $toODataString(SelectedCategory_Parameter, "String?")
                        });
                }
            }
        ]),

        DataWorkspace: $defineDataWorkspace(DataWorkspace, [
            { name: "Pulsar_DataSource", type: Pulsar_DataSource }
        ])

    });

}(msls.application));
