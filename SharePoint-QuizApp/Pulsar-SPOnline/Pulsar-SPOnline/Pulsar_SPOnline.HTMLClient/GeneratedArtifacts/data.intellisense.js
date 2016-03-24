/// <reference path="data.js" />

(function (lightSwitchApplication) {

    msls._addEntryPoints(lightSwitchApplication.Category, {
        /// <field>
        /// Called when a new category is created.
        /// <br/>created(msls.application.Category entity)
        /// </field>
        created: [lightSwitchApplication.Category]
    });

    msls._addEntryPoints(lightSwitchApplication.Team, {
        /// <field>
        /// Called when a new team is created.
        /// <br/>created(msls.application.Team entity)
        /// </field>
        created: [lightSwitchApplication.Team]
    });

    msls._addEntryPoints(lightSwitchApplication.UserInformationList, {
        /// <field>
        /// Called when a new userInformationList is created.
        /// <br/>created(msls.application.UserInformationList entity)
        /// </field>
        created: [lightSwitchApplication.UserInformationList]
    });

    msls._addEntryPoints(lightSwitchApplication.Question, {
        /// <field>
        /// Called when a new question is created.
        /// <br/>created(msls.application.Question entity)
        /// </field>
        created: [lightSwitchApplication.Question]
    });

}(msls.application));
