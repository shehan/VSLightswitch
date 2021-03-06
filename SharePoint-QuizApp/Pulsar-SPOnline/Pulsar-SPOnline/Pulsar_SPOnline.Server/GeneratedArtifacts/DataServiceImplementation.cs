﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class Pulsar_DataSourceDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.Pulsar_DataSource>
    {
    
        public Pulsar_DataSourceDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).Pulsar_DataSource;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class Pulsar_DataSourceServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.AstoriaDataServiceImplementation<global::LightSwitchApplication.Implementation.Pulsar_DataSource, global::Pulsar_DataSource.Pulsar_DataSourceService.DevTestDataContext>
    {
        public Pulsar_DataSourceServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Question> Query_GetQuestion(string SelectedCategory_Parameter)
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Question> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.Question>("Questions"),
                (q) => ((q.Category.Title.CompareTo(SelectedCategory_Parameter) == 0) && (q.IsAvailable.HasValue && (q.IsAvailable == true))));
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Category))
            {
                return new global::LightSwitchApplication.Implementation.Category();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Team))
            {
                return new global::LightSwitchApplication.Implementation.Team();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.UserInformationList))
            {
                return new global::LightSwitchApplication.Implementation.UserInformationList();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Question))
            {
                return new global::LightSwitchApplication.Implementation.Question();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.Pulsar_DataSource CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.Pulsar_DataSource(this.GetEntityConnectionString(
                "Pulsar_DataSource",
                "res://" + assemblyName + "/Pulsar_DataSource.csdl|res://" + assemblyName + "/Pulsar_DataSource.ssdl|res://" + assemblyName + "/Pulsar_DataSource.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Category))
            {
                return new global::LightSwitchApplication.Implementation.Category();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Team))
            {
                return new global::LightSwitchApplication.Implementation.Team();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.UserInformationList))
            {
                return new global::LightSwitchApplication.Implementation.UserInformationList();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Question))
            {
                return new global::LightSwitchApplication.Implementation.Question();
            }
            return null;
        }
    
        protected override string WebConfigurationConnectionStringName
        {
            get
            {
                return "Pulsar_DataSource";
            }
        }
    
        protected override global::System.Type ConvertType(global::System.Type outerType)
        {
            if (outerType == typeof(global::LightSwitchApplication.Implementation.Category))
            {
                return typeof(global::Pulsar_DataSource.Pulsar_DataSourceService.CategoryItem);
            }
            if (outerType == typeof(global::LightSwitchApplication.Implementation.Team))
            {
                return typeof(global::Pulsar_DataSource.Pulsar_DataSourceService.TeamItem);
            }
            if (outerType == typeof(global::LightSwitchApplication.Implementation.UserInformationList))
            {
                return typeof(global::Pulsar_DataSource.Pulsar_DataSourceService.UserInformationListItem);
            }
            if (outerType == typeof(global::LightSwitchApplication.Implementation.Question))
            {
                return typeof(global::Pulsar_DataSource.Pulsar_DataSourceService.QuestionItem);
            }
            return base.ConvertType(outerType);
        }
    
    
        protected override global::System.String ConvertProperty(global::System.Reflection.PropertyInfo outerProperty)
        {
            if (outerProperty.DeclaringType == typeof(global::LightSwitchApplication.Implementation.Question))
            {
                switch(outerProperty.Name)
                {
                    case "CorrectAnswer":
                        return "CorrectAnswerValue";
                    case "EliminateAnswer1":
                        return "EliminateAnswer1Value";
                    case "EliminateAnswer2":
                        return "EliminateAnswer2Value";
                    case "SelectedAnswer":
                        return "SelectedAnswerValue";
                    case "AnswerStatus":
                        return "AnswerStatusValue";
                }
            }
            return base.ConvertProperty(outerProperty);
        }
    
        protected override object ConvertEntity(object outerEntity)
        {
            global::LightSwitchApplication.Implementation.Category category = outerEntity as global::LightSwitchApplication.Implementation.Category;
            if (category != null)
            {
                global::Pulsar_DataSource.Pulsar_DataSourceService.CategoryItem result = new global::Pulsar_DataSource.Pulsar_DataSourceService.CategoryItem();
                result.Id = category.Id;
                result.ContentType = category.ContentType;
                result.Title = category.Title;
                result.CreatedById = category.CreatedById;
                result.ModifiedById = category.ModifiedById;
                return result;
            }
            global::LightSwitchApplication.Implementation.Team team = outerEntity as global::LightSwitchApplication.Implementation.Team;
            if (team != null)
            {
                global::Pulsar_DataSource.Pulsar_DataSourceService.TeamItem result = new global::Pulsar_DataSource.Pulsar_DataSourceService.TeamItem();
                result.Id = team.Id;
                result.ContentType = team.ContentType;
                result.Title = team.Title;
                result.CreatedById = team.CreatedById;
                result.ModifiedById = team.ModifiedById;
                return result;
            }
            global::LightSwitchApplication.Implementation.UserInformationList userInformationList = outerEntity as global::LightSwitchApplication.Implementation.UserInformationList;
            if (userInformationList != null)
            {
                global::Pulsar_DataSource.Pulsar_DataSourceService.UserInformationListItem result = new global::Pulsar_DataSource.Pulsar_DataSourceService.UserInformationListItem();
                result.Id = userInformationList.Id;
                result.ContentType = userInformationList.ContentType;
                result.CreatedById = userInformationList.CreatedById;
                result.ModifiedById = userInformationList.ModifiedById;
                return result;
            }
            global::LightSwitchApplication.Implementation.Question question = outerEntity as global::LightSwitchApplication.Implementation.Question;
            if (question != null)
            {
                global::Pulsar_DataSource.Pulsar_DataSourceService.QuestionItem result = new global::Pulsar_DataSource.Pulsar_DataSourceService.QuestionItem();
                result.Title = question.Title;
                result.AnswerA = question.AnswerA;
                result.AnswerB = question.AnswerB;
                result.AnswerC = question.AnswerC;
                result.AnswerD = question.AnswerD;
                result.CorrectAnswerValue = question.CorrectAnswer;
                result.EliminateAnswer1Value = question.EliminateAnswer1;
                result.EliminateAnswer2Value = question.EliminateAnswer2;
                result.IsAvailable = question.IsAvailable;
                result.SelectedAnswerValue = question.SelectedAnswer;
                result.AnswerStatusValue = question.AnswerStatus;
                result.Id = question.Id;
                result.ContentType = question.ContentType;
                result.CategoryId = question.CategoryId;
                result.TeamId = question.TeamId;
                result.CreatedById = question.CreatedById;
                result.ModifiedById = question.ModifiedById;
                return result;
            }
            return null;
        }
    
        protected override void UpdateResult(object outerEntity, object innerResult)
        {
            global::LightSwitchApplication.Implementation.Category outerCategory = outerEntity as global::LightSwitchApplication.Implementation.Category;
            global::Pulsar_DataSource.Pulsar_DataSourceService.CategoryItem innerCategory = innerResult as global::Pulsar_DataSource.Pulsar_DataSourceService.CategoryItem;
            if ((outerCategory != null) && (innerCategory != null))
            {
                outerCategory.Id = innerCategory.Id;
                outerCategory.ContentType = innerCategory.ContentType;
                outerCategory.Title = innerCategory.Title;
                outerCategory.ContentTypeID = innerCategory.ContentTypeID;
                outerCategory.Modified = innerCategory.Modified;
                outerCategory.Created = innerCategory.Created;
                outerCategory.Owshiddenversion = innerCategory.Owshiddenversion;
                outerCategory.Version = innerCategory.Version;
                outerCategory.Path = innerCategory.Path;
                outerCategory.CreatedById = innerCategory.CreatedById;
                outerCategory.ModifiedById = innerCategory.ModifiedById;
                return;
            }
            global::LightSwitchApplication.Implementation.Team outerTeam = outerEntity as global::LightSwitchApplication.Implementation.Team;
            global::Pulsar_DataSource.Pulsar_DataSourceService.TeamItem innerTeam = innerResult as global::Pulsar_DataSource.Pulsar_DataSourceService.TeamItem;
            if ((outerTeam != null) && (innerTeam != null))
            {
                outerTeam.Id = innerTeam.Id;
                outerTeam.ContentType = innerTeam.ContentType;
                outerTeam.Title = innerTeam.Title;
                outerTeam.ContentTypeID = innerTeam.ContentTypeID;
                outerTeam.Modified = innerTeam.Modified;
                outerTeam.Created = innerTeam.Created;
                outerTeam.Owshiddenversion = innerTeam.Owshiddenversion;
                outerTeam.Version = innerTeam.Version;
                outerTeam.Path = innerTeam.Path;
                outerTeam.CreatedById = innerTeam.CreatedById;
                outerTeam.ModifiedById = innerTeam.ModifiedById;
                return;
            }
            global::LightSwitchApplication.Implementation.UserInformationList outerUserInformationList = outerEntity as global::LightSwitchApplication.Implementation.UserInformationList;
            global::Pulsar_DataSource.Pulsar_DataSourceService.UserInformationListItem innerUserInformationList = innerResult as global::Pulsar_DataSource.Pulsar_DataSourceService.UserInformationListItem;
            if ((outerUserInformationList != null) && (innerUserInformationList != null))
            {
                outerUserInformationList.Id = innerUserInformationList.Id;
                outerUserInformationList.ContentType = innerUserInformationList.ContentType;
                outerUserInformationList.ContentTypeID = innerUserInformationList.ContentTypeID;
                outerUserInformationList.Name = innerUserInformationList.Name;
                outerUserInformationList.Account = innerUserInformationList.Account;
                outerUserInformationList.WorkEmail = innerUserInformationList.WorkEmail;
                outerUserInformationList.MobilePhone = innerUserInformationList.MobilePhone;
                outerUserInformationList.AboutMe = innerUserInformationList.AboutMe;
                outerUserInformationList.SIPAddress = innerUserInformationList.SIPAddress;
                outerUserInformationList.IsSiteAdmin = innerUserInformationList.IsSiteAdmin;
                outerUserInformationList.Deleted = innerUserInformationList.Deleted;
                outerUserInformationList.Hidden = innerUserInformationList.Hidden;
                outerUserInformationList.Picture = innerUserInformationList.Picture;
                outerUserInformationList.Department = innerUserInformationList.Department;
                outerUserInformationList.Title = innerUserInformationList.Title;
                outerUserInformationList.FirstName = innerUserInformationList.FirstName;
                outerUserInformationList.LastName = innerUserInformationList.LastName;
                outerUserInformationList.WorkPhone = innerUserInformationList.WorkPhone;
                outerUserInformationList.UserName = innerUserInformationList.UserName;
                outerUserInformationList.WebSite = innerUserInformationList.WebSite;
                outerUserInformationList.AskMeAbout = innerUserInformationList.AskMeAbout;
                outerUserInformationList.Office = innerUserInformationList.Office;
                outerUserInformationList.PictureTimestamp = innerUserInformationList.PictureTimestamp;
                outerUserInformationList.PicturePlaceholderState = innerUserInformationList.PicturePlaceholderState;
                outerUserInformationList.PictureExchangeSyncState = innerUserInformationList.PictureExchangeSyncState;
                outerUserInformationList.Modified = innerUserInformationList.Modified;
                outerUserInformationList.Created = innerUserInformationList.Created;
                outerUserInformationList.Owshiddenversion = innerUserInformationList.Owshiddenversion;
                outerUserInformationList.Version = innerUserInformationList.Version;
                outerUserInformationList.Path = innerUserInformationList.Path;
                outerUserInformationList.CreatedById = innerUserInformationList.CreatedById;
                outerUserInformationList.ModifiedById = innerUserInformationList.ModifiedById;
                return;
            }
            global::LightSwitchApplication.Implementation.Question outerQuestion = outerEntity as global::LightSwitchApplication.Implementation.Question;
            global::Pulsar_DataSource.Pulsar_DataSourceService.QuestionItem innerQuestion = innerResult as global::Pulsar_DataSource.Pulsar_DataSourceService.QuestionItem;
            if ((outerQuestion != null) && (innerQuestion != null))
            {
                outerQuestion.Title = innerQuestion.Title;
                outerQuestion.AnswerA = innerQuestion.AnswerA;
                outerQuestion.AnswerB = innerQuestion.AnswerB;
                outerQuestion.AnswerC = innerQuestion.AnswerC;
                outerQuestion.AnswerD = innerQuestion.AnswerD;
                outerQuestion.CorrectAnswer = innerQuestion.CorrectAnswerValue;
                outerQuestion.EliminateAnswer1 = innerQuestion.EliminateAnswer1Value;
                outerQuestion.EliminateAnswer2 = innerQuestion.EliminateAnswer2Value;
                outerQuestion.IsAvailable = innerQuestion.IsAvailable;
                outerQuestion.SelectedAnswer = innerQuestion.SelectedAnswerValue;
                outerQuestion.AnswerStatus = innerQuestion.AnswerStatusValue;
                outerQuestion.Id = innerQuestion.Id;
                outerQuestion.ContentType = innerQuestion.ContentType;
                outerQuestion.ContentTypeID = innerQuestion.ContentTypeID;
                outerQuestion.Modified = innerQuestion.Modified;
                outerQuestion.Created = innerQuestion.Created;
                outerQuestion.Owshiddenversion = innerQuestion.Owshiddenversion;
                outerQuestion.Version = innerQuestion.Version;
                outerQuestion.Path = innerQuestion.Path;
                outerQuestion.CategoryId = innerQuestion.CategoryId;
                outerQuestion.TeamId = innerQuestion.TeamId;
                outerQuestion.CreatedById = innerQuestion.CreatedById;
                outerQuestion.ModifiedById = innerQuestion.ModifiedById;
                return;
            }
            base.UpdateResult(outerEntity, innerResult);
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.Pulsar_DataSourceService))
            {
                return new global::LightSwitchApplication.Pulsar_DataSourceService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.Pulsar_DataSourceService))
            {
                return new global::LightSwitchApplication.Implementation.Pulsar_DataSourceServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Category) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Category);
            }
            if (typeof(global::LightSwitchApplication.Team) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Team);
            }
            if (typeof(global::LightSwitchApplication.UserInformationList) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.UserInformationList);
            }
            if (typeof(global::LightSwitchApplication.Question) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Question);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Category :
        global::LightSwitchApplication.Category.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation
    {
    
        [global::System.Runtime.Serialization.DataMember]
        public string Microsoft_LightSwitch_ETag
        {
            get;
            set;
        }
    
        string global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation.ETag
        {
            get { return this.Microsoft_LightSwitch_ETag; }
            set { this.Microsoft_LightSwitch_ETag = value; }
        }
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Category.DetailsClass.IImplementation.CreatedBy
        {
            get
            {
                return this.CreatedBy;
            }
            set
            {
                this.CreatedBy = (global::LightSwitchApplication.Implementation.UserInformationList)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("CreatedBy");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Category.DetailsClass.IImplementation.ModifiedBy
        {
            get
            {
                return this.ModifiedBy;
            }
            set
            {
                this.ModifiedBy = (global::LightSwitchApplication.Implementation.UserInformationList)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("ModifiedBy");
                }
            }
        }
        
        partial void OnCreatedByIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("CreatedBy");
            }
        }
        
        partial void OnModifiedByIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("ModifiedBy");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Team :
        global::LightSwitchApplication.Team.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation
    {
    
        [global::System.Runtime.Serialization.DataMember]
        public string Microsoft_LightSwitch_ETag
        {
            get;
            set;
        }
    
        string global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation.ETag
        {
            get { return this.Microsoft_LightSwitch_ETag; }
            set { this.Microsoft_LightSwitch_ETag = value; }
        }
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Team.DetailsClass.IImplementation.CreatedBy
        {
            get
            {
                return this.CreatedBy;
            }
            set
            {
                this.CreatedBy = (global::LightSwitchApplication.Implementation.UserInformationList)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("CreatedBy");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Team.DetailsClass.IImplementation.ModifiedBy
        {
            get
            {
                return this.ModifiedBy;
            }
            set
            {
                this.ModifiedBy = (global::LightSwitchApplication.Implementation.UserInformationList)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("ModifiedBy");
                }
            }
        }
        
        partial void OnCreatedByIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("CreatedBy");
            }
        }
        
        partial void OnModifiedByIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("ModifiedBy");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class UserInformationList :
        global::LightSwitchApplication.UserInformationList.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation
    {
    
        [global::System.Runtime.Serialization.DataMember]
        public string Microsoft_LightSwitch_ETag
        {
            get;
            set;
        }
    
        string global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation.ETag
        {
            get { return this.Microsoft_LightSwitch_ETag; }
            set { this.Microsoft_LightSwitch_ETag = value; }
        }
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.UserInformationList.DetailsClass.IImplementation.CreatedBy
        {
            get
            {
                return this.CreatedBy;
            }
            set
            {
                this.CreatedBy = (global::LightSwitchApplication.Implementation.UserInformationList)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("CreatedBy");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.UserInformationList.DetailsClass.IImplementation.ModifiedBy
        {
            get
            {
                return this.ModifiedBy;
            }
            set
            {
                this.ModifiedBy = (global::LightSwitchApplication.Implementation.UserInformationList)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("ModifiedBy");
                }
            }
        }
        
        partial void OnCreatedByIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("CreatedBy");
            }
        }
        
        partial void OnModifiedByIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("ModifiedBy");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Question :
        global::LightSwitchApplication.Question.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation
    {
    
        [global::System.Runtime.Serialization.DataMember]
        public string Microsoft_LightSwitch_ETag
        {
            get;
            set;
        }
    
        string global::Microsoft.LightSwitch.Internal.IAstoriaEntityImplementation.ETag
        {
            get { return this.Microsoft_LightSwitch_ETag; }
            set { this.Microsoft_LightSwitch_ETag = value; }
        }
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Question.DetailsClass.IImplementation.Category
        {
            get
            {
                return this.Category;
            }
            set
            {
                this.Category = (global::LightSwitchApplication.Implementation.Category)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Category");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Question.DetailsClass.IImplementation.Team
        {
            get
            {
                return this.Team;
            }
            set
            {
                this.Team = (global::LightSwitchApplication.Implementation.Team)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Team");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Question.DetailsClass.IImplementation.CreatedBy
        {
            get
            {
                return this.CreatedBy;
            }
            set
            {
                this.CreatedBy = (global::LightSwitchApplication.Implementation.UserInformationList)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("CreatedBy");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Question.DetailsClass.IImplementation.ModifiedBy
        {
            get
            {
                return this.ModifiedBy;
            }
            set
            {
                this.ModifiedBy = (global::LightSwitchApplication.Implementation.UserInformationList)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("ModifiedBy");
                }
            }
        }
        
        partial void OnCategoryIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Category");
            }
        }
        
        partial void OnTeamIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Team");
            }
        }
        
        partial void OnCreatedByIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("CreatedBy");
            }
        }
        
        partial void OnModifiedByIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("ModifiedBy");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

