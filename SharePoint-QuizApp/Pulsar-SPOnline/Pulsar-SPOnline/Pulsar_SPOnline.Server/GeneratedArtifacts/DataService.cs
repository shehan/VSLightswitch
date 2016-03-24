﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the Pulsar_DataSource datasource.
    /// </summary>
    public sealed partial class Pulsar_DataSourceService
        : global::LightSwitchApplication.Pulsar_DataSource
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Pulsar_DataSourceService() : base()
        {
        }
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Server Interceptions Points
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_Inserting(global::LightSwitchApplication.Category entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_Inserted(global::LightSwitchApplication.Category entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_Updating(global::LightSwitchApplication.Category entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_Updated(global::LightSwitchApplication.Category entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_Deleting(global::LightSwitchApplication.Category entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_Deleted(global::LightSwitchApplication.Category entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categories_Validate(global::LightSwitchApplication.Category entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_Inserting(global::LightSwitchApplication.Team entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_Inserted(global::LightSwitchApplication.Team entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_Updating(global::LightSwitchApplication.Team entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_Updated(global::LightSwitchApplication.Team entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_Deleting(global::LightSwitchApplication.Team entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_Deleted(global::LightSwitchApplication.Team entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Teams_Validate(global::LightSwitchApplication.Team entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_Inserting(global::LightSwitchApplication.UserInformationList entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_Inserted(global::LightSwitchApplication.UserInformationList entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_Updating(global::LightSwitchApplication.UserInformationList entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_Updated(global::LightSwitchApplication.UserInformationList entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_Deleting(global::LightSwitchApplication.UserInformationList entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_Deleted(global::LightSwitchApplication.UserInformationList entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void UserInformationLists_Validate(global::LightSwitchApplication.UserInformationList entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_Inserting(global::LightSwitchApplication.Question entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_Inserted(global::LightSwitchApplication.Question entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_Updating(global::LightSwitchApplication.Question entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_Updated(global::LightSwitchApplication.Question entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_Deleting(global::LightSwitchApplication.Question entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_Deleted(global::LightSwitchApplication.Question entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Questions_Validate(global::LightSwitchApplication.Question entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executed();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_ExecuteFailed(global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_GetQuestion_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void Query_GetQuestion_Executing(string SelectedCategory_Parameter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_GetQuestion_PreprocessQuery(string SelectedCategory_Parameter, ref global::System.Linq.IQueryable<global::LightSwitchApplication.Question> query);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void Query_GetQuestion_Executed(string SelectedCategory_Parameter, global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Question> result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        partial void Query_GetQuestion_ExecuteFailed(string SelectedCategory_Parameter, global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executing(global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executed(global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_ExecuteFailed(global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor);
    
        #endregion
    
        #region Details Class
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static new class DetailsClass
        {
    
            static DetailsClass()
            {
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.Category>
                __CategoriesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.Category>(
                    "Categories",
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_CanInsert,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_CanUpdate,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_CanDelete,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_CanRead,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_Inserting,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_Inserted,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_Updating,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_Updated,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_Deleting,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_Deleted,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Categories_Validate,
                    null);
            private static bool __Categories_CanInsert(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Categories_CanInsert(ref result);
                return result;
            }
            private static bool __Categories_CanUpdate(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Categories_CanUpdate(ref result);
                return result;
            }
            private static bool __Categories_CanDelete(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Categories_CanDelete(ref result);
                return result;
            }
            private static bool __Categories_CanRead(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Categories_CanRead(ref result);
                return result;
            }
            private static void __Categories_Inserting(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Category e)
            {
                d.Categories_Inserting(e);
            }
            private static void __Categories_Inserted(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Category e)
            {
                d.Categories_Inserted(e);
            }
            private static void __Categories_Updating(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Category e)
            {
                d.Categories_Updating(e);
            }
            private static void __Categories_Updated(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Category e)
            {
                d.Categories_Updated(e);
            }
            private static void __Categories_Deleting(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Category e)
            {
                d.Categories_Deleting(e);
            }
            private static void __Categories_Deleted(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Category e)
            {
                d.Categories_Deleted(e);
            }
            private static void __Categories_Validate(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Category e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Categories_Validate(e, r);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.Team>
                __TeamsEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.Team>(
                    "Teams",
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_CanInsert,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_CanUpdate,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_CanDelete,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_CanRead,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_Inserting,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_Inserted,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_Updating,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_Updated,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_Deleting,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_Deleted,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Teams_Validate,
                    null);
            private static bool __Teams_CanInsert(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Teams_CanInsert(ref result);
                return result;
            }
            private static bool __Teams_CanUpdate(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Teams_CanUpdate(ref result);
                return result;
            }
            private static bool __Teams_CanDelete(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Teams_CanDelete(ref result);
                return result;
            }
            private static bool __Teams_CanRead(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Teams_CanRead(ref result);
                return result;
            }
            private static void __Teams_Inserting(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Team e)
            {
                d.Teams_Inserting(e);
            }
            private static void __Teams_Inserted(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Team e)
            {
                d.Teams_Inserted(e);
            }
            private static void __Teams_Updating(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Team e)
            {
                d.Teams_Updating(e);
            }
            private static void __Teams_Updated(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Team e)
            {
                d.Teams_Updated(e);
            }
            private static void __Teams_Deleting(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Team e)
            {
                d.Teams_Deleting(e);
            }
            private static void __Teams_Deleted(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Team e)
            {
                d.Teams_Deleted(e);
            }
            private static void __Teams_Validate(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Team e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Teams_Validate(e, r);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.UserInformationList>
                __UserInformationListsEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.UserInformationList>(
                    "UserInformationLists",
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_CanInsert,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_CanUpdate,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_CanDelete,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_CanRead,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_Inserting,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_Inserted,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_Updating,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_Updated,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_Deleting,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_Deleted,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__UserInformationLists_Validate,
                    null);
            private static bool __UserInformationLists_CanInsert(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.UserInformationLists_CanInsert(ref result);
                return result;
            }
            private static bool __UserInformationLists_CanUpdate(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.UserInformationLists_CanUpdate(ref result);
                return result;
            }
            private static bool __UserInformationLists_CanDelete(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.UserInformationLists_CanDelete(ref result);
                return result;
            }
            private static bool __UserInformationLists_CanRead(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.UserInformationLists_CanRead(ref result);
                return result;
            }
            private static void __UserInformationLists_Inserting(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.UserInformationList e)
            {
                d.UserInformationLists_Inserting(e);
            }
            private static void __UserInformationLists_Inserted(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.UserInformationList e)
            {
                d.UserInformationLists_Inserted(e);
            }
            private static void __UserInformationLists_Updating(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.UserInformationList e)
            {
                d.UserInformationLists_Updating(e);
            }
            private static void __UserInformationLists_Updated(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.UserInformationList e)
            {
                d.UserInformationLists_Updated(e);
            }
            private static void __UserInformationLists_Deleting(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.UserInformationList e)
            {
                d.UserInformationLists_Deleting(e);
            }
            private static void __UserInformationLists_Deleted(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.UserInformationList e)
            {
                d.UserInformationLists_Deleted(e);
            }
            private static void __UserInformationLists_Validate(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.UserInformationList e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.UserInformationLists_Validate(e, r);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.Question>
                __QuestionsEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.Question>(
                    "Questions",
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_CanInsert,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_CanUpdate,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_CanDelete,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_CanRead,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_Inserting,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_Inserted,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_Updating,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_Updated,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_Deleting,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_Deleted,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Questions_Validate,
                    null);
            private static bool __Questions_CanInsert(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Questions_CanInsert(ref result);
                return result;
            }
            private static bool __Questions_CanUpdate(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Questions_CanUpdate(ref result);
                return result;
            }
            private static bool __Questions_CanDelete(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Questions_CanDelete(ref result);
                return result;
            }
            private static bool __Questions_CanRead(global::LightSwitchApplication.Pulsar_DataSourceService d)
            {
                bool result = true;
                d.Questions_CanRead(ref result);
                return result;
            }
            private static void __Questions_Inserting(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Question e)
            {
                d.Questions_Inserting(e);
            }
            private static void __Questions_Inserted(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Question e)
            {
                d.Questions_Inserted(e);
            }
            private static void __Questions_Updating(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Question e)
            {
                d.Questions_Updating(e);
            }
            private static void __Questions_Updated(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Question e)
            {
                d.Questions_Updated(e);
            }
            private static void __Questions_Deleting(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Question e)
            {
                d.Questions_Deleting(e);
            }
            private static void __Questions_Deleted(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Question e)
            {
                d.Questions_Deleted(e);
            }
            private static void __Questions_Validate(global::LightSwitchApplication.Pulsar_DataSourceService d, global::LightSwitchApplication.Question e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Questions_Validate(e, r);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.Pulsar_DataSourceService>
                __SaveChangesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.Pulsar_DataSourceService>(
                    "SaveChanges",
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__SaveChanges_CanExecute,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__SaveChanges_Executing,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__SaveChanges_Executed,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__SaveChanges_Failed);
            private static bool __SaveChanges_CanExecute(global::LightSwitchApplication.Pulsar_DataSourceService d, bool r)
            {
                d.SaveChanges_CanExecute(ref r);
                return r;
            }
            private static void __SaveChanges_Executing(global::LightSwitchApplication.Pulsar_DataSourceService d, object[] args)
            {
                d.SaveChanges_Executing();
            }
            private static void __SaveChanges_Executed(global::LightSwitchApplication.Pulsar_DataSourceService d, object[] args)
            {
                d.SaveChanges_Executed();
            }
            private static void __SaveChanges_Failed(global::LightSwitchApplication.Pulsar_DataSourceService d, object[] args, global::System.Exception ex)
            {
                d.SaveChanges_ExecuteFailed(ex);
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.Question>
                __Query_GetQuestionEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryOperationEntry<global::LightSwitchApplication.Pulsar_DataSourceService, global::LightSwitchApplication.Question>(
                    "Query_GetQuestion",
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Query_GetQuestion_CanExecute,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Query_GetQuestion_Executing,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Query_GetQuestion_Executed,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Query_GetQuestion_Failed,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Query_GetQuestion_PreprocessQuery);
            private static bool __Query_GetQuestion_CanExecute(global::LightSwitchApplication.Pulsar_DataSourceService d, bool r)
            {
                d.Query_GetQuestion_CanExecute(ref r);
                return r;
            }
            private static void __Query_GetQuestion_Executing(global::LightSwitchApplication.Pulsar_DataSourceService d, object[] args)
            {
                d.Query_GetQuestion_Executing((string)args[0]);
            }
            private static void __Query_GetQuestion_Executed(global::LightSwitchApplication.Pulsar_DataSourceService d, object[] args)
            {
                d.Query_GetQuestion_Executed((string)args[0], (global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Question>)args[1]);
            }
            private static void __Query_GetQuestion_Failed(global::LightSwitchApplication.Pulsar_DataSourceService d, object[] args, global::System.Exception ex)
            {
                d.Query_GetQuestion_ExecuteFailed((string)args[0], ex);
            }
            private static global::System.Linq.IQueryable __Query_GetQuestion_PreprocessQuery(global::LightSwitchApplication.Pulsar_DataSourceService d, object[] args)
            {
                global::System.Linq.IQueryable<global::LightSwitchApplication.Question> query = (global::System.Linq.IQueryable<global::LightSwitchApplication.Question>)args[1];
                d.Query_GetQuestion_PreprocessQuery((string)args[0], ref query);
                return query;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.Pulsar_DataSourceService>
                ___QueryEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.Pulsar_DataSourceService>(
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Query_Executing,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Query_Executed,
                    global::LightSwitchApplication.Pulsar_DataSourceService.DetailsClass.__Query_Failed);
            private static void __Query_Executing(global::LightSwitchApplication.Pulsar_DataSourceService d, global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor)
            {
                d.Query_Executing(queryDescriptor);
            }
            private static void __Query_Executed(global::LightSwitchApplication.Pulsar_DataSourceService d, global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor)
            {
                d.Query_Executed(queryDescriptor);
            }
            private static void __Query_Failed(global::LightSwitchApplication.Pulsar_DataSourceService d, global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor)
            {
                d.Query_ExecuteFailed(queryDescriptor);
            }
        }
    
        #endregion
    }
    
    #endregion
}
