// Resharper disable All

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#nullable disable

namespace Schemas.VisualStudio.TeamTest
{
    /// <summary>
    /// <para>Shared between all test types.</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("Shared between all test types.")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CodedWebTestElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeclarativeWebTestElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericTestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderedTestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlainTextManualTestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitTestType))]
    public abstract partial class BaseTestType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypeCss> _css;

        /// <summary>
        /// <para>Currituck subsystem something ...</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Currituck subsystem something ...")]
        [System.Xml.Serialization.XmlElementAttribute("Css", Order = 0)]
        public System.Collections.ObjectModel.Collection<BaseTestTypeCss> Css
        {
            get { return _css; }
            private set { _css = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Css collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CssSpecified
        {
            get { return (this.Css.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BaseTestType" /> class.</para>
        /// </summary>
        public BaseTestType()
        {
            this._css = new System.Collections.ObjectModel.Collection<BaseTestTypeCss>();
            this._description = new System.Collections.ObjectModel.Collection<object>();
            this._agent = new System.Collections.ObjectModel.Collection<BaseTestTypeAgent>();
            this._owners = new System.Collections.ObjectModel.Collection<BaseTestTypeOwners>();
            this._deploymentItems = new System.Collections.ObjectModel.Collection<BaseTestTypeDeploymentItems>();
            this._testCategory = new System.Collections.ObjectModel.Collection<BaseTestTypeTestCategory>();
            this._execution = new System.Collections.ObjectModel.Collection<BaseTestTypeExecution>();
            this._properties = new System.Collections.ObjectModel.Collection<BaseTestTypeProperties>();
            this._workItemIDs = new System.Collections.ObjectModel.Collection<WorkItemIDsType>();
            this._tcmInformation = new System.Collections.ObjectModel.Collection<TcmInformationType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _description;

        /// <summary>
        /// <para>Describes the test. This is shown in the properties window.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Describes the test. This is shown in the properties window.")]
        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 1)]
        public System.Collections.ObjectModel.Collection<object> Description
        {
            get { return _description; }
            private set { _description = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get { return (this.Description.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypeAgent> _agent;

        [System.Xml.Serialization.XmlElementAttribute("Agent", Order = 2)]
        public System.Collections.ObjectModel.Collection<BaseTestTypeAgent> Agent
        {
            get { return _agent; }
            private set { _agent = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Agent collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentSpecified
        {
            get { return (this.Agent.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypeOwners> _owners;

        /// <summary>
        /// <para>At the moment only one owner is allowed, but in the future we might extend to multiple owner support.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "At the moment only one owner is allowed, but in the future we might extend to mul" +
            "tiple owner support.")]
        [System.Xml.Serialization.XmlElementAttribute("Owners", Order = 3)]
        public System.Collections.ObjectModel.Collection<BaseTestTypeOwners> Owners
        {
            get { return _owners; }
            private set { _owners = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Owners collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OwnersSpecified
        {
            get { return (this.Owners.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypeDeploymentItems> _deploymentItems;

        /// <summary>
        /// <para>Files to deploy before executing this test.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Files to deploy before executing this test.")]
        [System.Xml.Serialization.XmlElementAttribute("DeploymentItems", Order = 4)]
        public System.Collections.ObjectModel.Collection<BaseTestTypeDeploymentItems> DeploymentItems
        {
            get { return _deploymentItems; }
            private set { _deploymentItems = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DeploymentItems collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeploymentItemsSpecified
        {
            get { return (this.DeploymentItems.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypeTestCategory> _testCategory;

        /// <summary>
        /// <para>Categories applied to the test</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("Categories applied to the test")]
        [System.Xml.Serialization.XmlElementAttribute("TestCategory", Order = 5)]
        public System.Collections.ObjectModel.Collection<BaseTestTypeTestCategory> TestCategory
        {
            get { return _testCategory; }
            private set { _testCategory = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestCategory collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestCategorySpecified
        {
            get { return (this.TestCategory.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypeExecution> _execution;

        [System.Xml.Serialization.XmlElementAttribute("Execution", Order = 6)]
        public System.Collections.ObjectModel.Collection<BaseTestTypeExecution> Execution
        {
            get { return _execution; }
            private set { _execution = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Execution collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExecutionSpecified
        {
            get { return (this.Execution.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypeProperties> _properties;

        [System.Xml.Serialization.XmlElementAttribute("Properties", Order = 7)]
        public System.Collections.ObjectModel.Collection<BaseTestTypeProperties> Properties
        {
            get { return _properties; }
            private set { _properties = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Properties collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertiesSpecified
        {
            get { return (this.Properties.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WorkItemIDsType> _workItemIDs;

        /// <summary>
        /// <para>References to workitems (bugs, issues) related to this test on the team server.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "References to workitems (bugs, issues) related to this test on the team server.")]
        [System.Xml.Serialization.XmlElementAttribute("WorkItemIDs", Order = 8)]
        public System.Collections.ObjectModel.Collection<WorkItemIDsType> WorkItemIDs
        {
            get { return _workItemIDs; }
            private set { _workItemIDs = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WorkItemIDs collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WorkItemIDsSpecified
        {
            get { return (this.WorkItemIDs.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TcmInformationType> _tcmInformation;

        [System.Xml.Serialization.XmlElementAttribute("TcmInformation", Order = 9)]
        public System.Collections.ObjectModel.Collection<TcmInformationType> TcmInformation
        {
            get { return _tcmInformation; }
            private set { _tcmInformation = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TcmInformation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TcmInformationSpecified
        {
            get { return (this.TcmInformation.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isGroupable = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("isGroupable")]
        public bool IsGroupable
        {
            get { return _isGroupable; }
            set { _isGroupable = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _priority = 2147483647;

        [System.ComponentModel.DefaultValueAttribute(2147483647)]
        [System.Xml.Serialization.XmlAttributeAttribute("priority")]
        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _namedCategory = "";

        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("namedCategory")]
        public string NamedCategory
        {
            get { return _namedCategory; }
            set { _namedCategory = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("storage")]
        public string Storage { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeCss",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeCss
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("projectStructure")]
        public string ProjectStructure { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("iteration")]
        public string Iteration { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeAgent",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeAgent
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypeAgentAgentAttribute> _agentAttribute;

        [System.Xml.Serialization.XmlElementAttribute("AgentAttribute", Order = 0)]
        public System.Collections.ObjectModel.Collection<BaseTestTypeAgentAgentAttribute> AgentAttribute
        {
            get { return _agentAttribute; }
            private set { _agentAttribute = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AgentAttribute collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentAttributeSpecified
        {
            get { return (this.AgentAttribute.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BaseTestTypeAgent" /> class.</para>
        /// </summary>
        public BaseTestTypeAgent()
        {
            this._agentAttribute = new System.Collections.ObjectModel.Collection<BaseTestTypeAgentAgentAttribute>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _abortRunOnFailure = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("abortRunOnFailure")]
        public bool AbortRunOnFailure
        {
            get { return _abortRunOnFailure; }
            set { _abortRunOnFailure = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeAgentAgentAttribute",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeAgentAgentAttribute
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeOwners",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeOwners
    {
        /// <summary>
        /// <para>For example REDMOND\user1</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("For example REDMOND\\user1")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Owner", Order = 0)]
        public BaseTestTypeOwnersOwner Owner { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeOwnersOwner",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeOwnersOwner
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeDeploymentItems",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeDeploymentItems : DeploymentItemsType
    {
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DeploymentItemsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseTestTypeDeploymentItems))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TestRunConfigurationDeployment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TestSettingsTypeDeployment))]
    public partial class DeploymentItemsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DeploymentItemsTypeDeploymentItem> _deploymentItem;

        [System.Xml.Serialization.XmlElementAttribute("DeploymentItem", Order = 0)]
        public System.Collections.ObjectModel.Collection<DeploymentItemsTypeDeploymentItem> DeploymentItem
        {
            get { return _deploymentItem; }
            private set { _deploymentItem = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DeploymentItem collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeploymentItemSpecified
        {
            get { return (this.DeploymentItem.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DeploymentItemsType" /> class.</para>
        /// </summary>
        public DeploymentItemsType()
        {
            this._deploymentItem = new System.Collections.ObjectModel.Collection<DeploymentItemsTypeDeploymentItem>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DeploymentItemsTypeDeploymentItem",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeploymentItemsTypeDeploymentItem
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("filename")]
        public string Filename { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("outputDirectory")]
        public string OutputDirectory { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeTestCategory",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeTestCategory : TestCategoryType
    {
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestCategoryType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseTestTypeTestCategory))]
    public partial class TestCategoryType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestCategoryTypeTestCategoryItem> _testCategoryItem;

        [System.Xml.Serialization.XmlElementAttribute("TestCategoryItem", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestCategoryTypeTestCategoryItem> TestCategoryItem
        {
            get { return _testCategoryItem; }
            private set { _testCategoryItem = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestCategoryItem collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestCategoryItemSpecified
        {
            get { return (this.TestCategoryItem.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestCategoryType" /> class.</para>
        /// </summary>
        public TestCategoryType()
        {
            this._testCategoryItem = new System.Collections.ObjectModel.Collection<TestCategoryTypeTestCategoryItem>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestCategoryTypeTestCategoryItem",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestCategoryTypeTestCategoryItem
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("TestCategory")]
        public string TestCategory { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeExecution",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeExecution
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _id = "00000000-0000-0000-0000-000000000000";

        [System.ComponentModel.DefaultValueAttribute("00000000-0000-0000-0000-000000000000")]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _parentId = "00000000-0000-0000-0000-000000000000";

        [System.ComponentModel.DefaultValueAttribute("00000000-0000-0000-0000-000000000000")]
        [System.Xml.Serialization.XmlAttributeAttribute("parentId")]
        public string ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isRunOnRestart = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isRunOnRestart")]
        public bool IsRunOnRestart
        {
            get { return _isRunOnRestart; }
            set { _isRunOnRestart = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _timeOut = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("timeOut")]
        public int TimeOut
        {
            get { return _timeOut; }
            set { _timeOut = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypeProperties",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypeProperties
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BaseTestTypePropertiesProperty> _property;

        [System.Xml.Serialization.XmlElementAttribute("Property", Order = 0)]
        public System.Collections.ObjectModel.Collection<BaseTestTypePropertiesProperty> Property
        {
            get { return _property; }
            private set { _property = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Property collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertySpecified
        {
            get { return (this.Property.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BaseTestTypeProperties" /> class.</para>
        /// </summary>
        public BaseTestTypeProperties()
        {
            this._property = new System.Collections.ObjectModel.Collection<BaseTestTypePropertiesProperty>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseTestTypePropertiesProperty",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BaseTestTypePropertiesProperty
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Key", Order = 0)]
        public object Key { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Value", Order = 1)]
        public object Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WorkItemIDsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WorkItemIDsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<IdElementType> _workItem;

        [System.Xml.Serialization.XmlElementAttribute("WorkItem", Order = 0)]
        public System.Collections.ObjectModel.Collection<IdElementType> WorkItem
        {
            get { return _workItem; }
            private set { _workItem = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WorkItem collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WorkItemSpecified
        {
            get { return (this.WorkItem.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WorkItemIDsType" /> class.</para>
        /// </summary>
        public WorkItemIDsType()
        {
            this._workItem = new System.Collections.ObjectModel.Collection<IdElementType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("IDElementType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IdElementType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TcmInformationType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TcmInformationType
    {
        /// <summary>
        /// <para xml:lang="en">Minimum exclusive value: 0.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testCaseId")]
        public int TestCaseId { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum exclusive value: 0.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testRunId")]
        public int TestRunId { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum exclusive value: 0.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testResultId")]
        public int TestResultId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testIterationId")]
        public string TestIterationId { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BrowserType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BrowserType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<HeadersTypeHeader> _headers;

        [System.Xml.Serialization.XmlArrayAttribute("Headers", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Header",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<HeadersTypeHeader> Headers
        {
            get { return _headers; }
            private set { _headers = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Headers collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeadersSpecified
        {
            get { return (this.Headers.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BrowserType" /> class.</para>
        /// </summary>
        public BrowserType()
        {
            this._headers = new System.Collections.ObjectModel.Collection<HeadersTypeHeader>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxConnections")]
        public int MaxConnectionsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxConnections property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxConnectionsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxConnections
        {
            get
            {
                if (this.MaxConnectionsValueSpecified)
                {
                    return this.MaxConnectionsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxConnectionsValue = value.GetValueOrDefault();
                this.MaxConnectionsValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("HeadersType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HeadersType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<HeadersTypeHeader> _header;

        [System.Xml.Serialization.XmlElementAttribute("Header", Order = 0)]
        public System.Collections.ObjectModel.Collection<HeadersTypeHeader> Header
        {
            get { return _header; }
            private set { _header = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Header collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeaderSpecified
        {
            get { return (this.Header.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="HeadersType" /> class.</para>
        /// </summary>
        public HeadersType()
        {
            this._header = new System.Collections.ObjectModel.Collection<HeadersTypeHeader>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("HeadersTypeHeader",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HeadersTypeHeader
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }

    /// <summary>
    /// <para>Coded web test in TRX file</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("Coded web test in TRX file")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CodedWebTestElementType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CodedWebTestElementType : BaseTestType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CodedWebTestElementTypeWebTestClass> _webTestClass;

        [System.Xml.Serialization.XmlElementAttribute("WebTestClass", Order = 0)]
        public System.Collections.ObjectModel.Collection<CodedWebTestElementTypeWebTestClass> WebTestClass
        {
            get { return _webTestClass; }
            private set { _webTestClass = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestClass collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestClassSpecified
        {
            get { return (this.WebTestClass.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CodedWebTestElementType" /> class.</para>
        /// </summary>
        public CodedWebTestElementType()
        {
            this._webTestClass = new System.Collections.ObjectModel.Collection<CodedWebTestElementTypeWebTestClass>();
            this._includedWebTests =
                new System.Collections.ObjectModel.Collection<CodedWebTestElementTypeIncludedWebTests>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CodedWebTestElementTypeIncludedWebTests> _includedWebTests;

        [System.Xml.Serialization.XmlElementAttribute("IncludedWebTests", Order = 1)]
        public System.Collections.ObjectModel.Collection<CodedWebTestElementTypeIncludedWebTests> IncludedWebTests
        {
            get { return _includedWebTests; }
            private set { _includedWebTests = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the IncludedWebTests collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludedWebTestsSpecified
        {
            get { return (this.IncludedWebTests.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CodedWebTestElementTypeWebTestClass",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CodedWebTestElementTypeWebTestClass
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("assembly")]
        public string Assembly { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("class")]
        public string Class { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CodedWebTestElementTypeIncludedWebTests",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CodedWebTestElementTypeIncludedWebTests
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CodedWebTestElementTypeIncludedWebTestsIncludedWebTest>
            _includedWebTest;

        [System.Xml.Serialization.XmlElementAttribute("IncludedWebTest", Order = 0)]
        public System.Collections.ObjectModel.Collection<CodedWebTestElementTypeIncludedWebTestsIncludedWebTest>
            IncludedWebTest
        {
            get { return _includedWebTest; }
            private set { _includedWebTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the IncludedWebTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludedWebTestSpecified
        {
            get { return (this.IncludedWebTest.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CodedWebTestElementTypeIncludedWebTests" /> class.</para>
        /// </summary>
        public CodedWebTestElementTypeIncludedWebTests()
        {
            this._includedWebTest =
                new System.Collections.ObjectModel.Collection<CodedWebTestElementTypeIncludedWebTestsIncludedWebTest>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CodedWebTestElementTypeIncludedWebTestsIncludedWebTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CodedWebTestElementTypeIncludedWebTestsIncludedWebTest
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("path")]
        public string Path { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testId")]
        public string TestId { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isCodedWebTest = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isCodedWebTest")]
        public bool IsCodedWebTest
        {
            get { return _isCodedWebTest; }
            set { _isCodedWebTest = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterDescriptorType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterDescriptorType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("machineName")]
        public string MachineName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("categoryName")]
        public string CategoryName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("counterName")]
        public string CounterName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("instanceName")]
        public string InstanceName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("baseInstanceName")]
        public string BaseInstanceName { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _loadTestItemId = -1;

        [System.ComponentModel.DefaultValueAttribute(-1)]
        [System.Xml.Serialization.XmlAttributeAttribute("loadTestItemId")]
        public int LoadTestItemId
        {
            get { return _loadTestItemId; }
            set { _loadTestItemId = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterSetType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterSetType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CounterSetTypeCounterCategoriesCounterCategory>
            _counterCategories;

        [System.Xml.Serialization.XmlArrayAttribute("CounterCategories", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CounterCategory",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<CounterSetTypeCounterCategoriesCounterCategory>
            CounterCategories
        {
            get { return _counterCategories; }
            private set { _counterCategories = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CounterCategories collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CounterCategoriesSpecified
        {
            get { return (this.CounterCategories.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CounterSetType" /> class.</para>
        /// </summary>
        public CounterSetType()
        {
            this._counterCategories =
                new System.Collections.ObjectModel.Collection<CounterSetTypeCounterCategoriesCounterCategory>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("counterSetType")]
        public string CounterSetTypeProperty { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterSetTypeCounterCategories",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterSetTypeCounterCategories
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CounterSetTypeCounterCategoriesCounterCategory>
            _counterCategory;

        [System.Xml.Serialization.XmlElementAttribute("CounterCategory", Order = 0)]
        public System.Collections.ObjectModel.Collection<CounterSetTypeCounterCategoriesCounterCategory> CounterCategory
        {
            get { return _counterCategory; }
            private set { _counterCategory = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CounterCategory collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CounterCategorySpecified
        {
            get { return (this.CounterCategory.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CounterSetTypeCounterCategories" /> class.</para>
        /// </summary>
        public CounterSetTypeCounterCategories()
        {
            this._counterCategory =
                new System.Collections.ObjectModel.Collection<CounterSetTypeCounterCategoriesCounterCategory>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterSetTypeCounterCategoriesCounterCategory",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterSetTypeCounterCategoriesCounterCategory
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CounterType> _counters;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("Counters", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Counter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<CounterType> Counters
        {
            get { return _counters; }
            private set { _counters = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CounterSetTypeCounterCategoriesCounterCategory" /> class.</para>
        /// </summary>
        public CounterSetTypeCounterCategoriesCounterCategory()
        {
            this._counters = new System.Collections.ObjectModel.Collection<CounterType>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Instances", Order = 1)]
        public object Instances { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterSetTypeCounterCategoriesCounterCategoryCounters",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterSetTypeCounterCategoriesCounterCategoryCounters
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CounterType> _counter;

        [System.Xml.Serialization.XmlElementAttribute("Counter", Order = 0)]
        public System.Collections.ObjectModel.Collection<CounterType> Counter
        {
            get { return _counter; }
            private set { _counter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Counter collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CounterSpecified
        {
            get { return (this.Counter.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CounterSetTypeCounterCategoriesCounterCategoryCounters" /> class.</para>
        /// </summary>
        public CounterSetTypeCounterCategoriesCounterCategoryCounters()
        {
            this._counter = new System.Collections.ObjectModel.Collection<CounterType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRule> _thresholdRules;

        [System.Xml.Serialization.XmlArrayAttribute("ThresholdRules", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ThresholdRule",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRule> ThresholdRules
        {
            get { return _thresholdRules; }
            private set { _thresholdRules = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ThresholdRules collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThresholdRulesSpecified
        {
            get { return (this.ThresholdRules.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CounterType" /> class.</para>
        /// </summary>
        public CounterType()
        {
            this._thresholdRules =
                new System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRule>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterTypeThresholdRules",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterTypeThresholdRules
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRule> _thresholdRule;

        [System.Xml.Serialization.XmlElementAttribute("ThresholdRule", Order = 0)]
        public System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRule> ThresholdRule
        {
            get { return _thresholdRule; }
            private set { _thresholdRule = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ThresholdRule collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThresholdRuleSpecified
        {
            get { return (this.ThresholdRule.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CounterTypeThresholdRules" /> class.</para>
        /// </summary>
        public CounterTypeThresholdRules()
        {
            this._thresholdRule =
                new System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRule>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterTypeThresholdRulesThresholdRule",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterTypeThresholdRulesThresholdRule
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRuleParametersRuleParameter>
            _parameters;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("Parameters", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RuleParameter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRuleParametersRuleParameter>
            Parameters
        {
            get { return _parameters; }
            private set { _parameters = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CounterTypeThresholdRulesThresholdRule" /> class.</para>
        /// </summary>
        public CounterTypeThresholdRulesThresholdRule()
        {
            this._parameters =
                new System.Collections.ObjectModel.Collection<
                    CounterTypeThresholdRulesThresholdRuleParametersRuleParameter>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("className")]
        public string ClassName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterTypeThresholdRulesThresholdRuleParameters",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterTypeThresholdRulesThresholdRuleParameters
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRuleParametersRuleParameter>
            _ruleParameter;

        [System.Xml.Serialization.XmlElementAttribute("RuleParameter", Order = 0)]
        public System.Collections.ObjectModel.Collection<CounterTypeThresholdRulesThresholdRuleParametersRuleParameter>
            RuleParameter
        {
            get { return _ruleParameter; }
            private set { _ruleParameter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RuleParameter collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RuleParameterSpecified
        {
            get { return (this.RuleParameter.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CounterTypeThresholdRulesThresholdRuleParameters" /> class.</para>
        /// </summary>
        public CounterTypeThresholdRulesThresholdRuleParameters()
        {
            this._ruleParameter =
                new System.Collections.ObjectModel.Collection<
                    CounterTypeThresholdRulesThresholdRuleParametersRuleParameter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CounterTypeThresholdRulesThresholdRuleParametersRuleParameter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CounterTypeThresholdRulesThresholdRuleParametersRuleParameter
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CountersType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CountersType
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("total")]
        public int TotalValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Total property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TotalValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Total
        {
            get
            {
                if (this.TotalValueSpecified)
                {
                    return this.TotalValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TotalValue = value.GetValueOrDefault();
                this.TotalValueSpecified = value.HasValue;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _error = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("error")]
        public int Error
        {
            get { return _error; }
            set { _error = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _failed = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("failed")]
        public int Failed
        {
            get { return _failed; }
            set { _failed = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _timeout = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("timeout")]
        public int Timeout
        {
            get { return _timeout; }
            set { _timeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _aborted = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("aborted")]
        public int Aborted
        {
            get { return _aborted; }
            set { _aborted = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _inconclusive = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("inconclusive")]
        public int Inconclusive
        {
            get { return _inconclusive; }
            set { _inconclusive = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _passedButRunAborted = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("passedButRunAborted")]
        public int PassedButRunAborted
        {
            get { return _passedButRunAborted; }
            set { _passedButRunAborted = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _notRunnable = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("notRunnable")]
        public int NotRunnable
        {
            get { return _notRunnable; }
            set { _notRunnable = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _notExecuted = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("notExecuted")]
        public int NotExecuted
        {
            get { return _notExecuted; }
            set { _notExecuted = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _executed = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("executed")]
        public int Executed
        {
            get { return _executed; }
            set { _executed = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _disconnected = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("disconnected")]
        public int Disconnected
        {
            get { return _disconnected; }
            set { _disconnected = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _warning = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("warning")]
        public int Warning
        {
            get { return _warning; }
            set { _warning = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _passed = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("passed")]
        public int Passed
        {
            get { return _passed; }
            set { _passed = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _completed = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("completed")]
        public int Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _inProgress = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("inProgress")]
        public int InProgress
        {
            get { return _inProgress; }
            set { _inProgress = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _pending = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("pending")]
        public int Pending
        {
            get { return _pending; }
            set { _pending = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }

    /// <summary>
    /// <para>Declarative web test in TRX file</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute("Declarative web test in TRX file")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DeclarativeWebTestElementType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeclarativeWebTestElementType : BaseTestType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("persistedWebTest")]
        public string PersistedWebTest { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DevelopmentServerType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevelopmentServerType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("pathToWebSite")]
        public string PathToWebSite { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("webApplicationRoot")]
        public string WebApplicationRoot { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ExecutionTypeEnum",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum ExecutionTypeEnum
    {
        [System.Xml.Serialization.XmlEnumAttribute("local")]
        Local,

        [System.Xml.Serialization.XmlEnumAttribute("remote")]
        Remote,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("HostProcessPlatformTypeEnum",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum HostProcessPlatformTypeEnum
    {
        [System.Xml.Serialization.XmlEnumAttribute("MSIL")]
        Msil,

        X86,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GenericTestType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("GenericTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class GenericTestType : BaseTestType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GenericTestTypeCommand> _command;

        [System.Xml.Serialization.XmlElementAttribute("Command", Order = 0)]
        public System.Collections.ObjectModel.Collection<GenericTestTypeCommand> Command
        {
            get { return _command; }
            private set { _command = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Command collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommandSpecified
        {
            get { return (this.Command.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GenericTestType" /> class.</para>
        /// </summary>
        public GenericTestType()
        {
            this._command = new System.Collections.ObjectModel.Collection<GenericTestTypeCommand>();
            this._summaryXmlFile = new System.Collections.ObjectModel.Collection<GenericTestTypeSummaryXmlFile>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GenericTestTypeSummaryXmlFile> _summaryXmlFile;

        /// <summary>
        /// <para>If this element does not exist it's the same as if it was not enabled.
        ///                But if it's not enabled, we still allow the user to change the file location and persist the file location for later use.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "If this element does not exist it\'s the same as if it was not enabled. But if it\'" +
            "s not enabled, we still allow the user to change the file location and persist t" +
            "he file location for later use.")]
        [System.Xml.Serialization.XmlElementAttribute("SummaryXmlFile", Order = 1)]
        public System.Collections.ObjectModel.Collection<GenericTestTypeSummaryXmlFile> SummaryXmlFile
        {
            get { return _summaryXmlFile; }
            private set { _summaryXmlFile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the SummaryXmlFile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SummaryXmlFileSpecified
        {
            get { return (this.SummaryXmlFile.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GenericTestTypeCommand",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GenericTestTypeCommand
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GenericTestTypeCommandEnvironmentVariablesEnvironmentVariable>
            _environmentVariables;

        [System.Xml.Serialization.XmlArrayAttribute("EnvironmentVariables", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("EnvironmentVariable",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<GenericTestTypeCommandEnvironmentVariablesEnvironmentVariable>
            EnvironmentVariables
        {
            get { return _environmentVariables; }
            private set { _environmentVariables = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the EnvironmentVariables collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnvironmentVariablesSpecified
        {
            get { return (this.EnvironmentVariables.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GenericTestTypeCommand" /> class.</para>
        /// </summary>
        public GenericTestTypeCommand()
        {
            this._environmentVariables =
                new System.Collections.ObjectModel.Collection<
                    GenericTestTypeCommandEnvironmentVariablesEnvironmentVariable>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("filename")]
        public string Filename { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("arguments")]
        public string Arguments { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("workingDirectory")]
        public string WorkingDirectory { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _maxDuration = 3600000;

        /// <summary>
        /// <para>This is in addition to the timeout to distinguish between a failed command and a test that timed out.</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(3600000)]
        [System.ComponentModel.DescriptionAttribute(
            "This is in addition to the timeout to distinguish between a failed command and a " +
            "test that timed out.")]
        [System.Xml.Serialization.XmlAttributeAttribute("maxDuration")]
        public int MaxDuration
        {
            get { return _maxDuration; }
            set { _maxDuration = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _redirectStandardOutputAndError = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("redirectStandardOutputAndError")]
        public bool RedirectStandardOutputAndError
        {
            get { return _redirectStandardOutputAndError; }
            set { _redirectStandardOutputAndError = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GenericTestTypeCommandEnvironmentVariables",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GenericTestTypeCommandEnvironmentVariables
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GenericTestTypeCommandEnvironmentVariablesEnvironmentVariable>
            _environmentVariable;

        [System.Xml.Serialization.XmlElementAttribute("EnvironmentVariable", Order = 0)]
        public System.Collections.ObjectModel.Collection<GenericTestTypeCommandEnvironmentVariablesEnvironmentVariable>
            EnvironmentVariable
        {
            get { return _environmentVariable; }
            private set { _environmentVariable = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the EnvironmentVariable collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnvironmentVariableSpecified
        {
            get { return (this.EnvironmentVariable.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GenericTestTypeCommandEnvironmentVariables" /> class.</para>
        /// </summary>
        public GenericTestTypeCommandEnvironmentVariables()
        {
            this._environmentVariable =
                new System.Collections.ObjectModel.Collection<
                    GenericTestTypeCommandEnvironmentVariablesEnvironmentVariable>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GenericTestTypeCommandEnvironmentVariablesEnvironmentVariable",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GenericTestTypeCommandEnvironmentVariablesEnvironmentVariable
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GenericTestTypeSummaryXmlFile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GenericTestTypeSummaryXmlFile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("path")]
        public string Path { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GraphDescriptorType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GraphDescriptorType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("HorizontalZoomRange", Order = 0)]
        public RangeType HorizontalZoomRange { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("VerticalZoomRange", Order = 1)]
        public RangeType VerticalZoomRange { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PlotDescriptorType> _plotDescriptors;

        [System.Xml.Serialization.XmlArrayAttribute("PlotDescriptors", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PlotDescriptor",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<PlotDescriptorType> PlotDescriptors
        {
            get { return _plotDescriptors; }
            private set { _plotDescriptors = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PlotDescriptors collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PlotDescriptorsSpecified
        {
            get { return (this.PlotDescriptors.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GraphDescriptorType" /> class.</para>
        /// </summary>
        public GraphDescriptorType()
        {
            this._plotDescriptors = new System.Collections.ObjectModel.Collection<PlotDescriptorType>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("graphName")]
        public string GraphName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RangeType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RangeType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("lower")]
        public string Lower { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("upper")]
        public string Upper { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GraphDescriptorTypePlotDescriptors",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GraphDescriptorTypePlotDescriptors
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PlotDescriptorType> _plotDescriptor;

        [System.Xml.Serialization.XmlElementAttribute("PlotDescriptor", Order = 0)]
        public System.Collections.ObjectModel.Collection<PlotDescriptorType> PlotDescriptor
        {
            get { return _plotDescriptor; }
            private set { _plotDescriptor = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PlotDescriptor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PlotDescriptorSpecified
        {
            get { return (this.PlotDescriptor.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GraphDescriptorTypePlotDescriptors" /> class.</para>
        /// </summary>
        public GraphDescriptorTypePlotDescriptors()
        {
            this._plotDescriptor = new System.Collections.ObjectModel.Collection<PlotDescriptorType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PlotDescriptorType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PlotDescriptorType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CounterDescriptor", Order = 0)]
        public CounterDescriptorType CounterDescriptor { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("colorArgb")]
        public int ColorArgb { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("lineStyle")]
        public int LineStyle { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("fixedRange")]
        public double FixedRange { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _showOnGraph = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("showOnGraph")]
        public bool ShowOnGraph
        {
            get { return _showOnGraph; }
            set { _showOnGraph = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isSelected = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isSelected")]
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("counterMetadata")]
        public string CounterMetadata { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("rangeGroup")]
        public string RangeGroup { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LinkType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LinkType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("storage")]
        public string Storage { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadRunConfigurationType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadRunConfigurationType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadRunConfigurationTypeCounterSetMappingsCounterSetMapping>
            _counterSetMappings;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("CounterSetMappings", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CounterSetMapping",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LoadRunConfigurationTypeCounterSetMappingsCounterSetMapping>
            CounterSetMappings
        {
            get { return _counterSetMappings; }
            private set { _counterSetMappings = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadRunConfigurationType" /> class.</para>
        /// </summary>
        public LoadRunConfigurationType()
        {
            this._counterSetMappings =
                new System.Collections.ObjectModel.Collection<
                    LoadRunConfigurationTypeCounterSetMappingsCounterSetMapping>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ContextParameters", Order = 1)]
        public object ContextParameters { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ApplicationsUnderTest", Order = 2)]
        public object ApplicationsUnderTest { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("description")]
        public string Description { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("timingDetailsStorage")]
        public int TimingDetailsStorageValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TimingDetailsStorage property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TimingDetailsStorageValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> TimingDetailsStorage
        {
            get
            {
                if (this.TimingDetailsStorageValueSpecified)
                {
                    return this.TimingDetailsStorageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TimingDetailsStorageValue = value.GetValueOrDefault();
                this.TimingDetailsStorageValueSpecified = value.HasValue;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _resultsStoreType = 1;

        [System.ComponentModel.DefaultValueAttribute(1)]
        [System.Xml.Serialization.XmlAttributeAttribute("resultsStoreType")]
        public int ResultsStoreType
        {
            get { return _resultsStoreType; }
            set { _resultsStoreType = value; }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("saveTestLogsOnError")]
        public bool SaveTestLogsOnErrorValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SaveTestLogsOnError property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SaveTestLogsOnErrorValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> SaveTestLogsOnError
        {
            get
            {
                if (this.SaveTestLogsOnErrorValueSpecified)
                {
                    return this.SaveTestLogsOnErrorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SaveTestLogsOnErrorValue = value.GetValueOrDefault();
                this.SaveTestLogsOnErrorValueSpecified = value.HasValue;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _saveTestLogsFrequency = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("saveTestLogsFrequency")]
        public int SaveTestLogsFrequency
        {
            get { return _saveTestLogsFrequency; }
            set { _saveTestLogsFrequency = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _maxErrorDetails = 100;

        [System.ComponentModel.DefaultValueAttribute(100)]
        [System.Xml.Serialization.XmlAttributeAttribute("maxErrorDetails")]
        public int MaxErrorDetails
        {
            get { return _maxErrorDetails; }
            set { _maxErrorDetails = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _maxErrorsPerType = 1000;

        [System.ComponentModel.DefaultValueAttribute(1000)]
        [System.Xml.Serialization.XmlAttributeAttribute("maxErrorsPerType")]
        public int MaxErrorsPerType
        {
            get { return _maxErrorsPerType; }
            set { _maxErrorsPerType = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _maxThresholdViolations = 1000;

        [System.ComponentModel.DefaultValueAttribute(1000)]
        [System.Xml.Serialization.XmlAttributeAttribute("maxThresholdViolations")]
        public int MaxThresholdViolations
        {
            get { return _maxThresholdViolations; }
            set { _maxThresholdViolations = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("maxRequestUrlsReported")]
        public int MaxRequestUrlsReported { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("useTestIterations")]
        public bool UseTestIterationsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UseTestIterations property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UseTestIterationsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> UseTestIterations
        {
            get
            {
                if (this.UseTestIterationsValueSpecified)
                {
                    return this.UseTestIterationsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UseTestIterationsValue = value.GetValueOrDefault();
                this.UseTestIterationsValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("runDuration")]
        public int RunDuration { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("warmupTime")]
        public int WarmupTime { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("coolDownTime")]
        public int CoolDownTimeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CoolDownTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CoolDownTimeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> CoolDownTime
        {
            get
            {
                if (this.CoolDownTimeValueSpecified)
                {
                    return this.CoolDownTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CoolDownTimeValue = value.GetValueOrDefault();
                this.CoolDownTimeValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("testIterations")]
        public int TestIterationsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TestIterations property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TestIterationsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> TestIterations
        {
            get
            {
                if (this.TestIterationsValueSpecified)
                {
                    return this.TestIterationsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TestIterationsValue = value.GetValueOrDefault();
                this.TestIterationsValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("webTestConnectionModel")]
        public string WebTestConnectionModel { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("webTestConnectionPoolSize")]
        public int WebTestConnectionPoolSizeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the WebTestConnectionPoolSize property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool WebTestConnectionPoolSizeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> WebTestConnectionPoolSize
        {
            get
            {
                if (this.WebTestConnectionPoolSizeValueSpecified)
                {
                    return this.WebTestConnectionPoolSizeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.WebTestConnectionPoolSizeValue = value.GetValueOrDefault();
                this.WebTestConnectionPoolSizeValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("sampleRate")]
        public int SampleRate { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("validationLevel")]
        public int ValidationLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("sqlTracingConnectString")]
        public string SqlTracingConnectString { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("sqlTracingConnectStringDisplayValue")]
        public string SqlTracingConnectStringDisplayValue { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("sqlTracingDirectory")]
        public string SqlTracingDirectory { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("sqlTracingEnabled")]
        public bool SqlTracingEnabledValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SqlTracingEnabled property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SqlTracingEnabledValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> SqlTracingEnabled
        {
            get
            {
                if (this.SqlTracingEnabledValueSpecified)
                {
                    return this.SqlTracingEnabledValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SqlTracingEnabledValue = value.GetValueOrDefault();
                this.SqlTracingEnabledValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("sqlTracingFileCount")]
        public int SqlTracingFileCountValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SqlTracingFileCount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SqlTracingFileCountValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> SqlTracingFileCount
        {
            get
            {
                if (this.SqlTracingFileCountValueSpecified)
                {
                    return this.SqlTracingFileCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SqlTracingFileCountValue = value.GetValueOrDefault();
                this.SqlTracingFileCountValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("sqlTracingRolloverEnabled")]
        public bool SqlTracingRolloverEnabledValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SqlTracingRolloverEnabled property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SqlTracingRolloverEnabledValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> SqlTracingRolloverEnabled
        {
            get
            {
                if (this.SqlTracingRolloverEnabledValueSpecified)
                {
                    return this.SqlTracingRolloverEnabledValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SqlTracingRolloverEnabledValue = value.GetValueOrDefault();
                this.SqlTracingRolloverEnabledValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("sqlTracingMinimumDuration")]
        public int SqlTracingMinimumDurationValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SqlTracingMinimumDuration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SqlTracingMinimumDurationValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> SqlTracingMinimumDuration
        {
            get
            {
                if (this.SqlTracingMinimumDurationValueSpecified)
                {
                    return this.SqlTracingMinimumDurationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SqlTracingMinimumDurationValue = value.GetValueOrDefault();
                this.SqlTracingMinimumDurationValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("runUnitTestsInAppDomain")]
        public bool RunUnitTestsInAppDomainValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RunUnitTestsInAppDomain property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RunUnitTestsInAppDomainValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> RunUnitTestsInAppDomain
        {
            get
            {
                if (this.RunUnitTestsInAppDomainValueSpecified)
                {
                    return this.RunUnitTestsInAppDomainValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RunUnitTestsInAppDomainValue = value.GetValueOrDefault();
                this.RunUnitTestsInAppDomainValueSpecified = value.HasValue;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _resourcesRetentionTimeInMinutes = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("resourcesRetentionTimeInMinutes")]
        public int ResourcesRetentionTimeInMinutes
        {
            get { return _resourcesRetentionTimeInMinutes; }
            set { _resourcesRetentionTimeInMinutes = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadRunConfigurationTypeCounterSetMappings",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadRunConfigurationTypeCounterSetMappings
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadRunConfigurationTypeCounterSetMappingsCounterSetMapping>
            _counterSetMapping;

        [System.Xml.Serialization.XmlElementAttribute("CounterSetMapping", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadRunConfigurationTypeCounterSetMappingsCounterSetMapping>
            CounterSetMapping
        {
            get { return _counterSetMapping; }
            private set { _counterSetMapping = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CounterSetMapping collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CounterSetMappingSpecified
        {
            get { return (this.CounterSetMapping.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadRunConfigurationTypeCounterSetMappings" /> class.</para>
        /// </summary>
        public LoadRunConfigurationTypeCounterSetMappings()
        {
            this._counterSetMapping =
                new System.Collections.ObjectModel.Collection<
                    LoadRunConfigurationTypeCounterSetMappingsCounterSetMapping>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadRunConfigurationTypeCounterSetMappingsCounterSetMapping",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadRunConfigurationTypeCounterSetMappingsCounterSetMapping
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CounterSetReferences", Order = 0)]
        public LoadRunConfigurationTypeCounterSetMappingsCounterSetMappingCounterSetReferences CounterSetReferences
        {
            get;
            set;
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("computerName")]
        public string ComputerName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadRunConfigurationTypeCounterSetMappingsCounterSetMappingCounterSetReferences",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadRunConfigurationTypeCounterSetMappingsCounterSetMappingCounterSetReferences
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CounterSetReference", Order = 0)]
        public LoadRunConfigurationTypeCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference
            CounterSetReference { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadRunConfigurationTypeCounterSetMappingsCounterSetMappingCounterSetReferencesCo" +
        "unterSetReference", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010",
        AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadRunConfigurationTypeCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("counterSetName")]
        public string CounterSetName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultType : TestResultAggregationType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("AnalyzerViewState", Order = 0)]
        public LoadTestResultTypeAnalyzerViewState AnalyzerViewState { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Summary", Order = 1)]
        public LoadTestResultTypeSummary Summary { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private LoadTestRunStatusType _runStatus = Schemas.VisualStudio.TeamTest.LoadTestRunStatusType.NotStarted;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.LoadTestRunStatusType.NotStarted)]
        [System.Xml.Serialization.XmlAttributeAttribute("runStatus")]
        public LoadTestRunStatusType RunStatus
        {
            get { return _runStatus; }
            set { _runStatus = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("runId")]
        public int RunId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("controllerStartTime")]
        public string ControllerStartTime { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("loadTestDuration")]
        public int LoadTestDurationValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoadTestDuration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool LoadTestDurationValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> LoadTestDuration
        {
            get
            {
                if (this.LoadTestDurationValueSpecified)
                {
                    return this.LoadTestDurationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoadTestDurationValue = value.GetValueOrDefault();
                this.LoadTestDurationValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("loadTestWarmupTime")]
        public int LoadTestWarmupTimeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoadTestWarmupTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool LoadTestWarmupTimeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> LoadTestWarmupTime
        {
            get
            {
                if (this.LoadTestWarmupTimeValueSpecified)
                {
                    return this.LoadTestWarmupTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoadTestWarmupTimeValue = value.GetValueOrDefault();
                this.LoadTestWarmupTimeValueSpecified = value.HasValue;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _previouslyViewed = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("previouslyViewed")]
        public bool PreviouslyViewed
        {
            get { return _previouslyViewed; }
            set { _previouslyViewed = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("resultsRepositoryConnectString")]
        public string ResultsRepositoryConnectString { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("resultsStoreType")]
        public LoadTestResultStoreType ResultsStoreTypeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ResultsStoreType property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ResultsStoreTypeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<LoadTestResultStoreType> ResultsStoreType
        {
            get
            {
                if (this.ResultsStoreTypeValueSpecified)
                {
                    return this.ResultsStoreTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ResultsStoreTypeValue = value.GetValueOrDefault();
                this.ResultsStoreTypeValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestResultAggregationType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoadTestResultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitTestResultType))]
    public partial class TestResultAggregationType : TestResultType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Counters", Order = 0)]
        public CountersType Counters { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("InnerResults", Order = 1)]
        public ResultsType InnerResults { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestResultType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoadTestResultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualTestResultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TestResultAggregationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnitTestResultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WebTestResultType))]
    public partial class TestResultType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<OutputType> _output;

        [System.Xml.Serialization.XmlElementAttribute("Output", Order = 0)]
        public System.Collections.ObjectModel.Collection<OutputType> Output
        {
            get { return _output; }
            private set { _output = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Output collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutputSpecified
        {
            get { return (this.Output.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestResultType" /> class.</para>
        /// </summary>
        public TestResultType()
        {
            this._output = new System.Collections.ObjectModel.Collection<OutputType>();
            this._workItems = new System.Collections.ObjectModel.Collection<WorkItemIDsType>();
            this._timers = new System.Collections.ObjectModel.Collection<TestResultTypeTimers>();
            this._resultFiles = new System.Collections.ObjectModel.Collection<ResultFilesType>();
            this._fileUris = new System.Collections.ObjectModel.Collection<FileUrisType>();
            this._collectorDataEntries = new System.Collections.ObjectModel.Collection<CollectorDataEntriesType>();
            this._dataCollectorMessages = new System.Collections.ObjectModel.Collection<DataCollectorMessagesType>();
            this._tcmInformation = new System.Collections.ObjectModel.Collection<TcmInformationType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WorkItemIDsType> _workItems;

        [System.Xml.Serialization.XmlElementAttribute("WorkItems", Order = 1)]
        public System.Collections.ObjectModel.Collection<WorkItemIDsType> WorkItems
        {
            get { return _workItems; }
            private set { _workItems = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WorkItems collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WorkItemsSpecified
        {
            get { return (this.WorkItems.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestResultTypeTimers> _timers;

        [System.Xml.Serialization.XmlElementAttribute("Timers", Order = 2)]
        public System.Collections.ObjectModel.Collection<TestResultTypeTimers> Timers
        {
            get { return _timers; }
            private set { _timers = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Timers collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimersSpecified
        {
            get { return (this.Timers.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResultFilesType> _resultFiles;

        [System.Xml.Serialization.XmlElementAttribute("ResultFiles", Order = 3)]
        public System.Collections.ObjectModel.Collection<ResultFilesType> ResultFiles
        {
            get { return _resultFiles; }
            private set { _resultFiles = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ResultFiles collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultFilesSpecified
        {
            get { return (this.ResultFiles.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<FileUrisType> _fileUris;

        [System.Xml.Serialization.XmlElementAttribute("FileUris", Order = 4)]
        public System.Collections.ObjectModel.Collection<FileUrisType> FileUris
        {
            get { return _fileUris; }
            private set { _fileUris = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the FileUris collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FileUrisSpecified
        {
            get { return (this.FileUris.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CollectorDataEntriesType> _collectorDataEntries;

        [System.Xml.Serialization.XmlElementAttribute("CollectorDataEntries", Order = 5)]
        public System.Collections.ObjectModel.Collection<CollectorDataEntriesType> CollectorDataEntries
        {
            get { return _collectorDataEntries; }
            private set { _collectorDataEntries = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CollectorDataEntries collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CollectorDataEntriesSpecified
        {
            get { return (this.CollectorDataEntries.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataCollectorMessagesType> _dataCollectorMessages;

        [System.Xml.Serialization.XmlElementAttribute("DataCollectorMessages", Order = 6)]
        public System.Collections.ObjectModel.Collection<DataCollectorMessagesType> DataCollectorMessages
        {
            get { return _dataCollectorMessages; }
            private set { _dataCollectorMessages = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataCollectorMessages collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCollectorMessagesSpecified
        {
            get { return (this.DataCollectorMessages.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TcmInformationType> _tcmInformation;

        [System.Xml.Serialization.XmlElementAttribute("TcmInformation", Order = 7)]
        public System.Collections.ObjectModel.Collection<TcmInformationType> TcmInformation
        {
            get { return _tcmInformation; }
            private set { _tcmInformation = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TcmInformation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TcmInformationSpecified
        {
            get { return (this.TcmInformation.Count != 0); }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testName")]
        public string TestName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testType")]
        public string TestType { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testId")]
        public string TestId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("executionId")]
        public string ExecutionId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("parentExecutionId")]
        public string ParentExecutionId { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testListId")]
        public string TestListId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("outcome")]
        public string Outcome { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("computerName")]
        public string ComputerName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("relativeResultsDirectory")]
        public string RelativeResultsDirectory { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("startTime")]
        public string StartTime { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("endTime")]
        public string EndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("duration")]
        public string Duration { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _spoolMessage = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("spoolMessage")]
        public bool SpoolMessage
        {
            get { return _spoolMessage; }
            set { _spoolMessage = value; }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("processExitCode")]
        public int ProcessExitCodeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ProcessExitCode property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ProcessExitCodeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> ProcessExitCode
        {
            get
            {
                if (this.ProcessExitCodeValueSpecified)
                {
                    return this.ProcessExitCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProcessExitCodeValue = value.GetValueOrDefault();
                this.ProcessExitCodeValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("isAborted")]
        public bool IsAbortedValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsAborted property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IsAbortedValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IsAborted
        {
            get
            {
                if (this.IsAbortedValueSpecified)
                {
                    return this.IsAbortedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IsAbortedValue = value.GetValueOrDefault();
                this.IsAbortedValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("relativeTestOutputDirectory")]
        public string RelativeTestOutputDirectory { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OutputType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OutputType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("StdOut", Order = 0)]
        public object StdOut { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("StdErr", Order = 1)]
        public object StdErr { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DebugTrace", Order = 2)]
        public object DebugTrace { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TraceInfo", Order = 3)]
        public object TraceInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ErrorInfo", Order = 4)]
        public OutputTypeErrorInfo ErrorInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Exception", Order = 5)]
        public object Exception { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _textMessages;

        [System.Xml.Serialization.XmlArrayAttribute("TextMessages", Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Message",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<object> TextMessages
        {
            get { return _textMessages; }
            private set { _textMessages = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TextMessages collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TextMessagesSpecified
        {
            get { return (this.TextMessages.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="OutputType" /> class.</para>
        /// </summary>
        public OutputType()
        {
            this._textMessages = new System.Collections.ObjectModel.Collection<object>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OutputTypeErrorInfo",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OutputTypeErrorInfo
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Message", Order = 0)]
        public object Message { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("StackTrace", Order = 1)]
        public object StackTrace { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OutputTypeTextMessages",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OutputTypeTextMessages
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _message;

        [System.Xml.Serialization.XmlElementAttribute("Message", Order = 0)]
        public System.Collections.ObjectModel.Collection<object> Message
        {
            get { return _message; }
            private set { _message = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Message collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageSpecified
        {
            get { return (this.Message.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="OutputTypeTextMessages" /> class.</para>
        /// </summary>
        public OutputTypeTextMessages()
        {
            this._message = new System.Collections.ObjectModel.Collection<object>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestResultTypeTimers",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestResultTypeTimers
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestResultTypeTimersTimer> _timer;

        [System.Xml.Serialization.XmlElementAttribute("Timer", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestResultTypeTimersTimer> Timer
        {
            get { return _timer; }
            private set { _timer = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Timer collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimerSpecified
        {
            get { return (this.Timer.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestResultTypeTimers" /> class.</para>
        /// </summary>
        public TestResultTypeTimers()
        {
            this._timer = new System.Collections.ObjectModel.Collection<TestResultTypeTimersTimer>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestResultTypeTimersTimer",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestResultTypeTimersTimer
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("startTime")]
        public string StartTime { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("duration")]
        public int DurationValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Duration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DurationValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Duration
        {
            get
            {
                if (this.DurationValueSpecified)
                {
                    return this.DurationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DurationValue = value.GetValueOrDefault();
                this.DurationValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ResultFilesType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResultFilesType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResultFilesTypeResultFile> _resultFile;

        [System.Xml.Serialization.XmlElementAttribute("ResultFile", Order = 0)]
        public System.Collections.ObjectModel.Collection<ResultFilesTypeResultFile> ResultFile
        {
            get { return _resultFile; }
            private set { _resultFile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ResultFile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultFileSpecified
        {
            get { return (this.ResultFile.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ResultFilesType" /> class.</para>
        /// </summary>
        public ResultFilesType()
        {
            this._resultFile = new System.Collections.ObjectModel.Collection<ResultFilesTypeResultFile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ResultFilesTypeResultFile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResultFilesTypeResultFile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("path")]
        public string Path { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("FileUrisType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FileUrisType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<FileUriType> _fileUri;

        [System.Xml.Serialization.XmlElementAttribute("FileUri", Order = 0)]
        public System.Collections.ObjectModel.Collection<FileUriType> FileUri
        {
            get { return _fileUri; }
            private set { _fileUri = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the FileUri collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FileUriSpecified
        {
            get { return (this.FileUri.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="FileUrisType" /> class.</para>
        /// </summary>
        public FileUrisType()
        {
            this._fileUri = new System.Collections.ObjectModel.Collection<FileUriType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("FileUriType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FileUriType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("file")]
        public string File { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("uri")]
        public string Uri { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CollectorDataEntriesType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CollectorDataEntriesType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CollectorType> _collector;

        [System.Xml.Serialization.XmlElementAttribute("Collector", Order = 0)]
        public System.Collections.ObjectModel.Collection<CollectorType> Collector
        {
            get { return _collector; }
            private set { _collector = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Collector collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CollectorSpecified
        {
            get { return (this.Collector.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CollectorDataEntriesType" /> class.</para>
        /// </summary>
        public CollectorDataEntriesType()
        {
            this._collector = new System.Collections.ObjectModel.Collection<CollectorType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CollectorType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CollectorType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<UriAttachmentType> _uriAttachments;

        [System.Xml.Serialization.XmlArrayAttribute("UriAttachments", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UriAttachment",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<UriAttachmentType> UriAttachments
        {
            get { return _uriAttachments; }
            private set { _uriAttachments = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UriAttachments collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UriAttachmentsSpecified
        {
            get { return (this.UriAttachments.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CollectorType" /> class.</para>
        /// </summary>
        public CollectorType()
        {
            this._uriAttachments = new System.Collections.ObjectModel.Collection<UriAttachmentType>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("agentName")]
        public string AgentName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("agentDisplayName")]
        public string AgentDisplayName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("collectorDisplayName")]
        public string CollectorDisplayName { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isFromRemoteAgent = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isFromRemoteAgent")]
        public bool IsFromRemoteAgent
        {
            get { return _isFromRemoteAgent; }
            set { _isFromRemoteAgent = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("uri")]
        public string Uri { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UriAttachmentsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UriAttachmentsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<UriAttachmentType> _uriAttachment;

        [System.Xml.Serialization.XmlElementAttribute("UriAttachment", Order = 0)]
        public System.Collections.ObjectModel.Collection<UriAttachmentType> UriAttachment
        {
            get { return _uriAttachment; }
            private set { _uriAttachment = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UriAttachment collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UriAttachmentSpecified
        {
            get { return (this.UriAttachment.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="UriAttachmentsType" /> class.</para>
        /// </summary>
        public UriAttachmentsType()
        {
            this._uriAttachment = new System.Collections.ObjectModel.Collection<UriAttachmentType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UriAttachmentType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UriAttachmentType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("A", Order = 0)]
        public UriAttachmentTypeA A { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UriAttachmentTypeA",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UriAttachmentTypeA
    {
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("href")]
        public string Href { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorMessagesType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorMessagesType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataCollectorMessageType> _dataCollectorMessage;

        [System.Xml.Serialization.XmlElementAttribute("DataCollectorMessage", Order = 0)]
        public System.Collections.ObjectModel.Collection<DataCollectorMessageType> DataCollectorMessage
        {
            get { return _dataCollectorMessage; }
            private set { _dataCollectorMessage = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataCollectorMessage collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCollectorMessageSpecified
        {
            get { return (this.DataCollectorMessage.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DataCollectorMessagesType" /> class.</para>
        /// </summary>
        public DataCollectorMessagesType()
        {
            this._dataCollectorMessage = new System.Collections.ObjectModel.Collection<DataCollectorMessageType>();
            this._dataCollectorExceptionMessage =
                new System.Collections.ObjectModel.Collection<DataCollectorExceptionMessageType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataCollectorExceptionMessageType>
            _dataCollectorExceptionMessage;

        [System.Xml.Serialization.XmlElementAttribute("DataCollectorExceptionMessage", Order = 1)]
        public System.Collections.ObjectModel.Collection<DataCollectorExceptionMessageType>
            DataCollectorExceptionMessage
        {
            get { return _dataCollectorExceptionMessage; }
            private set { _dataCollectorExceptionMessage = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataCollectorExceptionMessage collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCollectorExceptionMessageSpecified
        {
            get { return (this.DataCollectorExceptionMessage.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorMessageType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataCollectorExceptionMessageType))]
    public partial class DataCollectorMessageType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Text", Order = 0)]
        public string Text { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("level")]
        public DataCollectorMessageLevelType Level { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("agentName")]
        public string AgentName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("timestamp")]
        public string Timestamp { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("dataCollectorUri")]
        public string DataCollectorUri { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("dataCollectorFriendlyName")]
        public string DataCollectorFriendlyName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorMessageLevelType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum DataCollectorMessageLevelType
    {
        Error,

        Warning,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorExceptionMessageType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorExceptionMessageType : DataCollectorMessageType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ExceptionType", Order = 0)]
        public string ExceptionType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ExceptionMessage", Order = 1)]
        public string ExceptionMessage { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("StackTrace", Order = 2)]
        public string StackTrace { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ResultsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResultsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<UnitTestResultType> _unitTestResult;

        [System.Xml.Serialization.XmlElementAttribute("UnitTestResult", Order = 0)]
        public System.Collections.ObjectModel.Collection<UnitTestResultType> UnitTestResult
        {
            get { return _unitTestResult; }
            private set { _unitTestResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UnitTestResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitTestResultSpecified
        {
            get { return (this.UnitTestResult.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ResultsType" /> class.</para>
        /// </summary>
        public ResultsType()
        {
            this._unitTestResult = new System.Collections.ObjectModel.Collection<UnitTestResultType>();
            this._genericTestResult = new System.Collections.ObjectModel.Collection<TestResultAggregationType>();
            this._testResult = new System.Collections.ObjectModel.Collection<TestResultType>();
            this._manualTestResult = new System.Collections.ObjectModel.Collection<ManualTestResultType>();
            this._testResultAggregation = new System.Collections.ObjectModel.Collection<TestResultAggregationType>();
            this._webTestResult = new System.Collections.ObjectModel.Collection<WebTestResultType>();
            this._loadTestResult = new System.Collections.ObjectModel.Collection<LoadTestResultType>();
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestResultAggregationType> _genericTestResult;

        [System.Xml.Serialization.XmlElementAttribute("GenericTestResult", Order = 1)]
        public System.Collections.ObjectModel.Collection<TestResultAggregationType> GenericTestResult
        {
            get { return _genericTestResult; }
            private set { _genericTestResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the GenericTestResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenericTestResultSpecified
        {
            get { return (this.GenericTestResult.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestResultType> _testResult;

        [System.Xml.Serialization.XmlElementAttribute("TestResult", Order = 2)]
        public System.Collections.ObjectModel.Collection<TestResultType> TestResult
        {
            get { return _testResult; }
            private set { _testResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestResultSpecified
        {
            get { return (this.TestResult.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ManualTestResultType> _manualTestResult;

        [System.Xml.Serialization.XmlElementAttribute("ManualTestResult", Order = 3)]
        public System.Collections.ObjectModel.Collection<ManualTestResultType> ManualTestResult
        {
            get { return _manualTestResult; }
            private set { _manualTestResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ManualTestResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ManualTestResultSpecified
        {
            get { return (this.ManualTestResult.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestResultAggregationType> _testResultAggregation;

        /// <summary>
        /// <para>This one can be used by any other test type as they all can internally call another set of tests and produce results, which are later merged into this aggregation for unified presentation to the caller.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "This one can be used by any other test type as they all can internally call anoth" +
            "er set of tests and produce results, which are later merged into this aggregatio" +
            "n for unified presentation to the caller.")]
        [System.Xml.Serialization.XmlElementAttribute("TestResultAggregation", Order = 4)]
        public System.Collections.ObjectModel.Collection<TestResultAggregationType> TestResultAggregation
        {
            get { return _testResultAggregation; }
            private set { _testResultAggregation = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestResultAggregation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestResultAggregationSpecified
        {
            get { return (this.TestResultAggregation.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultType> _webTestResult;

        [System.Xml.Serialization.XmlElementAttribute("WebTestResult", Order = 5)]
        public System.Collections.ObjectModel.Collection<WebTestResultType> WebTestResult
        {
            get { return _webTestResult; }
            private set { _webTestResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestResultSpecified
        {
            get { return (this.WebTestResult.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestResultType> _loadTestResult;

        [System.Xml.Serialization.XmlElementAttribute("LoadTestResult", Order = 6)]
        public System.Collections.ObjectModel.Collection<LoadTestResultType> LoadTestResult
        {
            get { return _loadTestResult; }
            private set { _loadTestResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LoadTestResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LoadTestResultSpecified
        {
            get { return (this.LoadTestResult.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 7)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestResultType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTestResultType : TestResultAggregationType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ExtensionResult", Order = 0)]
        public UnitTestResultTypeExtensionResult ExtensionResult { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("resultType")]
        public string ResultType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("dataRowInfo")]
        public string DataRowInfo { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _hasSufficientAccess = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("hasSufficientAccess")]
        public bool HasSufficientAccess
        {
            get { return _hasSufficientAccess; }
            set { _hasSufficientAccess = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestResultTypeExtensionResult",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTestResultTypeExtensionResult
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="UnitTestResultTypeExtensionResult" /> class.</para>
        /// </summary>
        public UnitTestResultTypeExtensionResult()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ManualTestResultType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ManualTestResultType : TestResultType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Comments", Order = 0)]
        public object Comments { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testFile")]
        public string TestFile { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultType : TestResultType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultTypeByteArrayCache> _byteArrayCache;

        [System.Xml.Serialization.XmlElementAttribute("ByteArrayCache", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestResultTypeByteArrayCache> ByteArrayCache
        {
            get { return _byteArrayCache; }
            private set { _byteArrayCache = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ByteArrayCache collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ByteArrayCacheSpecified
        {
            get { return (this.ByteArrayCache.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestResultType" /> class.</para>
        /// </summary>
        public WebTestResultType()
        {
            this._byteArrayCache = new System.Collections.ObjectModel.Collection<WebTestResultTypeByteArrayCache>();
            this._testRunConfiguration = new System.Collections.ObjectModel.Collection<TestRunConfiguration>();
            this._testSettings = new System.Collections.ObjectModel.Collection<TestSettingsType>();
            this._webRequestResults = new System.Collections.ObjectModel.Collection<WebRequestResultsType>();
            this._webTestResultDetails = new System.Collections.ObjectModel.Collection<WebTestResultDetailsType>();
            this._webTestResultFilePath = new System.Collections.ObjectModel.Collection<string>();
            this._webTestRecordedResultFilePath = new System.Collections.ObjectModel.Collection<string>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfiguration> _testRunConfiguration;

        [System.Xml.Serialization.XmlElementAttribute("TestRunConfiguration", Order = 1)]
        public System.Collections.ObjectModel.Collection<TestRunConfiguration> TestRunConfiguration
        {
            get { return _testRunConfiguration; }
            private set { _testRunConfiguration = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestRunConfiguration collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestRunConfigurationSpecified
        {
            get { return (this.TestRunConfiguration.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestSettingsType> _testSettings;

        [System.Xml.Serialization.XmlElementAttribute("TestSettings", Order = 2)]
        public System.Collections.ObjectModel.Collection<TestSettingsType> TestSettings
        {
            get { return _testSettings; }
            private set { _testSettings = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestSettings collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestSettingsSpecified
        {
            get { return (this.TestSettings.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebRequestResultsType> _webRequestResults;

        [System.Xml.Serialization.XmlElementAttribute("WebRequestResults", Order = 3)]
        public System.Collections.ObjectModel.Collection<WebRequestResultsType> WebRequestResults
        {
            get { return _webRequestResults; }
            private set { _webRequestResults = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebRequestResults collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebRequestResultsSpecified
        {
            get { return (this.WebRequestResults.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultDetailsType> _webTestResultDetails;

        [System.Xml.Serialization.XmlElementAttribute("WebTestResultDetails", Order = 4)]
        public System.Collections.ObjectModel.Collection<WebTestResultDetailsType> WebTestResultDetails
        {
            get { return _webTestResultDetails; }
            private set { _webTestResultDetails = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestResultDetails collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestResultDetailsSpecified
        {
            get { return (this.WebTestResultDetails.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _webTestResultFilePath;

        [System.Xml.Serialization.XmlElementAttribute("WebTestResultFilePath", Order = 5)]
        public System.Collections.ObjectModel.Collection<string> WebTestResultFilePath
        {
            get { return _webTestResultFilePath; }
            private set { _webTestResultFilePath = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestResultFilePath collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestResultFilePathSpecified
        {
            get { return (this.WebTestResultFilePath.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _webTestRecordedResultFilePath;

        [System.Xml.Serialization.XmlElementAttribute("WebTestRecordedResultFilePath", Order = 6)]
        public System.Collections.ObjectModel.Collection<string> WebTestRecordedResultFilePath
        {
            get { return _webTestRecordedResultFilePath; }
            private set { _webTestRecordedResultFilePath = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestRecordedResultFilePath collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestRecordedResultFilePathSpecified
        {
            get { return (this.WebTestRecordedResultFilePath.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private uint _dataRowCount = 0u;

        [System.ComponentModel.DefaultValueAttribute(0u)]
        [System.Xml.Serialization.XmlAttributeAttribute("dataRowCount")]
        public uint DataRowCount
        {
            get { return _dataRowCount; }
            set { _dataRowCount = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultTypeByteArrayCache",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultTypeByteArrayCache
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultTypeByteArrayCacheEntry> _entry;

        [System.Xml.Serialization.XmlElementAttribute("Entry", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestResultTypeByteArrayCacheEntry> Entry
        {
            get { return _entry; }
            private set { _entry = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Entry collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntrySpecified
        {
            get { return (this.Entry.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestResultTypeByteArrayCache" /> class.</para>
        /// </summary>
        public WebTestResultTypeByteArrayCache()
        {
            this._entry = new System.Collections.ObjectModel.Collection<WebTestResultTypeByteArrayCacheEntry>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _nextHandle = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("nextHandle")]
        public int NextHandle
        {
            get { return _nextHandle; }
            set { _nextHandle = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultTypeByteArrayCacheEntry",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultTypeByteArrayCacheEntry
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("handle")]
        public int Handle { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("bytes")]
        public string Bytes { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfiguration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TestRunConfiguration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunConfiguration
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _description;

        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 0)]
        public System.Collections.ObjectModel.Collection<object> Description
        {
            get { return _description; }
            private set { _description = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get { return (this.Description.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfiguration" /> class.</para>
        /// </summary>
        public TestRunConfiguration()
        {
            this._description = new System.Collections.ObjectModel.Collection<object>();
            this._codeCoverage = new System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverage>();
            this._timeouts = new System.Collections.ObjectModel.Collection<TestRunConfigurationTimeouts>();
            this._remote = new System.Collections.ObjectModel.Collection<TestRunConfigurationRemote>();
            this._deployment = new System.Collections.ObjectModel.Collection<TestRunConfigurationDeployment>();
            this._namingScheme = new System.Collections.ObjectModel.Collection<TestRunConfigurationNamingScheme>();
            this._scripts = new System.Collections.ObjectModel.Collection<TestRunConfigurationScripts>();
            this._buckets = new System.Collections.ObjectModel.Collection<TestRunConfigurationBuckets>();
            this._executionThread =
                new System.Collections.ObjectModel.Collection<TestRunConfigurationExecutionThread>();
            this._hosts = new System.Collections.ObjectModel.Collection<TestRunConfigurationHosts>();
            this._testTypeSpecific =
                new System.Collections.ObjectModel.Collection<TestRunConfigurationTestTypeSpecific>();
            this._plugins = new System.Collections.ObjectModel.Collection<TestRunConfigurationPlugins>();
            this._constraints = new System.Collections.ObjectModel.Collection<TestRunConfigurationConstraints>();
            this._execution = new System.Collections.ObjectModel.Collection<TestRunConfigurationExecution>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverage> _codeCoverage;

        [System.Xml.Serialization.XmlElementAttribute("CodeCoverage", Order = 1)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverage> CodeCoverage
        {
            get { return _codeCoverage; }
            private set { _codeCoverage = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CodeCoverage collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeCoverageSpecified
        {
            get { return (this.CodeCoverage.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationTimeouts> _timeouts;

        [System.Xml.Serialization.XmlElementAttribute("Timeouts", Order = 2)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationTimeouts> Timeouts
        {
            get { return _timeouts; }
            private set { _timeouts = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Timeouts collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeoutsSpecified
        {
            get { return (this.Timeouts.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationRemote> _remote;

        [System.Xml.Serialization.XmlElementAttribute("Remote", Order = 3)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationRemote> Remote
        {
            get { return _remote; }
            private set { _remote = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Remote collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemoteSpecified
        {
            get { return (this.Remote.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationDeployment> _deployment;

        [System.Xml.Serialization.XmlElementAttribute("Deployment", Order = 4)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationDeployment> Deployment
        {
            get { return _deployment; }
            private set { _deployment = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Deployment collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeploymentSpecified
        {
            get { return (this.Deployment.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationNamingScheme> _namingScheme;

        [System.Xml.Serialization.XmlElementAttribute("NamingScheme", Order = 5)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationNamingScheme> NamingScheme
        {
            get { return _namingScheme; }
            private set { _namingScheme = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the NamingScheme collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NamingSchemeSpecified
        {
            get { return (this.NamingScheme.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationScripts> _scripts;

        [System.Xml.Serialization.XmlElementAttribute("Scripts", Order = 6)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationScripts> Scripts
        {
            get { return _scripts; }
            private set { _scripts = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Scripts collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScriptsSpecified
        {
            get { return (this.Scripts.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationBuckets> _buckets;

        [System.Xml.Serialization.XmlElementAttribute("Buckets", Order = 7)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationBuckets> Buckets
        {
            get { return _buckets; }
            private set { _buckets = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Buckets collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BucketsSpecified
        {
            get { return (this.Buckets.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationExecutionThread> _executionThread;

        [System.Xml.Serialization.XmlElementAttribute("ExecutionThread", Order = 8)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationExecutionThread> ExecutionThread
        {
            get { return _executionThread; }
            private set { _executionThread = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ExecutionThread collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExecutionThreadSpecified
        {
            get { return (this.ExecutionThread.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationHosts> _hosts;

        [System.Xml.Serialization.XmlElementAttribute("Hosts", Order = 9)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationHosts> Hosts
        {
            get { return _hosts; }
            private set { _hosts = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Hosts collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HostsSpecified
        {
            get { return (this.Hosts.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationTestTypeSpecific> _testTypeSpecific;

        [System.Xml.Serialization.XmlElementAttribute("TestTypeSpecific", Order = 10)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationTestTypeSpecific> TestTypeSpecific
        {
            get { return _testTypeSpecific; }
            private set { _testTypeSpecific = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestTypeSpecific collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestTypeSpecificSpecified
        {
            get { return (this.TestTypeSpecific.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationPlugins> _plugins;

        [System.Xml.Serialization.XmlElementAttribute("Plugins", Order = 11)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationPlugins> Plugins
        {
            get { return _plugins; }
            private set { _plugins = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Plugins collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PluginsSpecified
        {
            get { return (this.Plugins.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationConstraints> _constraints;

        [System.Xml.Serialization.XmlElementAttribute("Constraints", Order = 12)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationConstraints> Constraints
        {
            get { return _constraints; }
            private set { _constraints = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Constraints collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConstraintsSpecified
        {
            get { return (this.Constraints.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationExecution> _execution;

        [System.Xml.Serialization.XmlElementAttribute("Execution", Order = 13)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationExecution> Execution
        {
            get { return _execution; }
            private set { _execution = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Execution collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExecutionSpecified
        {
            get { return (this.Execution.Count != 0); }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isExecutedRemotely = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isExecutedRemotely")]
        public bool IsExecutedRemotely
        {
            get { return _isExecutedRemotely; }
            set { _isExecutedRemotely = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _abortRunOnError = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("abortRunOnError")]
        public bool AbortRunOnError
        {
            get { return _abortRunOnError; }
            set { _abortRunOnError = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _autoSaveResults = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("autoSaveResults")]
        public bool AutoSaveResults
        {
            get { return _autoSaveResults; }
            set { _autoSaveResults = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _mapIpAddresses = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("mapIPAddresses")]
        public bool MapIpAddresses
        {
            get { return _mapIpAddresses; }
            set { _mapIpAddresses = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _traceExecutionSequence = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("traceExecutionSequence")]
        public bool TraceExecutionSequence
        {
            get { return _traceExecutionSequence; }
            set { _traceExecutionSequence = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationCodeCoverage",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationCodeCoverage
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageRegularCodeCoverageItem>
            _regular;

        [System.Xml.Serialization.XmlArrayAttribute("Regular", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CodeCoverageItem",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageRegularCodeCoverageItem>
            Regular
        {
            get { return _regular; }
            private set { _regular = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Regular collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegularSpecified
        {
            get { return (this.Regular.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationCodeCoverage" /> class.</para>
        /// </summary>
        public TestRunConfigurationCodeCoverage()
        {
            this._regular =
                new System.Collections.ObjectModel.Collection<
                    TestRunConfigurationCodeCoverageRegularCodeCoverageItem>();
            this._aspNet =
                new System.Collections.ObjectModel.Collection<
                    TestRunConfigurationCodeCoverageAspNetAspNetCodeCoverageItem>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageAspNetAspNetCodeCoverageItem>
            _aspNet;

        [System.Xml.Serialization.XmlArrayAttribute("AspNet", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AspNetCodeCoverageItem",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageAspNetAspNetCodeCoverageItem>
            AspNet
        {
            get { return _aspNet; }
            private set { _aspNet = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AspNet collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AspNetSpecified
        {
            get { return (this.AspNet.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _perTest = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("perTest")]
        public bool PerTest
        {
            get { return _perTest; }
            set { _perTest = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _instrumentInPlace = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("instrumentInPlace")]
        public bool InstrumentInPlace
        {
            get { return _instrumentInPlace; }
            set { _instrumentInPlace = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("keyFile")]
        public string KeyFile { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationCodeCoverageRegular",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationCodeCoverageRegular
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageRegularCodeCoverageItem>
            _codeCoverageItem;

        [System.Xml.Serialization.XmlElementAttribute("CodeCoverageItem", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageRegularCodeCoverageItem>
            CodeCoverageItem
        {
            get { return _codeCoverageItem; }
            private set { _codeCoverageItem = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CodeCoverageItem collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodeCoverageItemSpecified
        {
            get { return (this.CodeCoverageItem.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationCodeCoverageRegular" /> class.</para>
        /// </summary>
        public TestRunConfigurationCodeCoverageRegular()
        {
            this._codeCoverageItem =
                new System.Collections.ObjectModel.Collection<
                    TestRunConfigurationCodeCoverageRegularCodeCoverageItem>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationCodeCoverageRegularCodeCoverageItem",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationCodeCoverageRegularCodeCoverageItem
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            TestRunConfigurationCodeCoverageRegularCodeCoverageItemKeyFile> _keyFile;

        [System.Xml.Serialization.XmlElementAttribute("KeyFile", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageRegularCodeCoverageItemKeyFile>
            KeyFile
        {
            get { return _keyFile; }
            private set { _keyFile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the KeyFile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KeyFileSpecified
        {
            get { return (this.KeyFile.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationCodeCoverageRegularCodeCoverageItem" /> class.</para>
        /// </summary>
        public TestRunConfigurationCodeCoverageRegularCodeCoverageItem()
        {
            this._keyFile =
                new System.Collections.ObjectModel.Collection<
                    TestRunConfigurationCodeCoverageRegularCodeCoverageItemKeyFile>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("binaryFile")]
        public string BinaryFile { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("pdbFile")]
        public string PdbFile { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("outputDirectory")]
        public string OutputDirectory { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _instrumentInPlace = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("instrumentInPlace")]
        public bool InstrumentInPlace
        {
            get { return _instrumentInPlace; }
            set { _instrumentInPlace = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationCodeCoverageRegularCodeCoverageItemKeyFile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationCodeCoverageRegularCodeCoverageItemKeyFile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("path")]
        public string Path { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isPublicKey = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isPublicKey")]
        public bool IsPublicKey
        {
            get { return _isPublicKey; }
            set { _isPublicKey = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationCodeCoverageAspNet",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationCodeCoverageAspNet
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageAspNetAspNetCodeCoverageItem>
            _aspNetCodeCoverageItem;

        [System.Xml.Serialization.XmlElementAttribute("AspNetCodeCoverageItem", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationCodeCoverageAspNetAspNetCodeCoverageItem>
            AspNetCodeCoverageItem
        {
            get { return _aspNetCodeCoverageItem; }
            private set { _aspNetCodeCoverageItem = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AspNetCodeCoverageItem collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AspNetCodeCoverageItemSpecified
        {
            get { return (this.AspNetCodeCoverageItem.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationCodeCoverageAspNet" /> class.</para>
        /// </summary>
        public TestRunConfigurationCodeCoverageAspNet()
        {
            this._aspNetCodeCoverageItem =
                new System.Collections.ObjectModel.Collection<
                    TestRunConfigurationCodeCoverageAspNetAspNetCodeCoverageItem>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationCodeCoverageAspNetAspNetCodeCoverageItem",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationCodeCoverageAspNetAspNetCodeCoverageItem
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("applicationRoot")]
        public string ApplicationRoot { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("url")]
        public string Url { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("isIIS")]
        public bool IsIisValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsIis property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IsIisValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IsIis
        {
            get
            {
                if (this.IsIisValueSpecified)
                {
                    return this.IsIisValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IsIisValue = value.GetValueOrDefault();
                this.IsIisValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationTimeouts",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationTimeouts
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _runTimeout = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("runTimeout")]
        public int RunTimeout
        {
            get { return _runTimeout; }
            set { _runTimeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _testTimeout = 1800000;

        [System.ComponentModel.DefaultValueAttribute(1800000)]
        [System.Xml.Serialization.XmlAttributeAttribute("testTimeout")]
        public int TestTimeout
        {
            get { return _testTimeout; }
            set { _testTimeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _agentNotRespondingTimeout = 300000;

        [System.ComponentModel.DefaultValueAttribute(300000)]
        [System.Xml.Serialization.XmlAttributeAttribute("agentNotRespondingTimeout")]
        public int AgentNotRespondingTimeout
        {
            get { return _agentNotRespondingTimeout; }
            set { _agentNotRespondingTimeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _deploymentTimeout = 300000;

        [System.ComponentModel.DefaultValueAttribute(300000)]
        [System.Xml.Serialization.XmlAttributeAttribute("deploymentTimeout")]
        public int DeploymentTimeout
        {
            get { return _deploymentTimeout; }
            set { _deploymentTimeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _scriptTimeout = 300000;

        [System.ComponentModel.DefaultValueAttribute(300000)]
        [System.Xml.Serialization.XmlAttributeAttribute("scriptTimeout")]
        public int ScriptTimeout
        {
            get { return _scriptTimeout; }
            set { _scriptTimeout = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationRemote",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationRemote
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Agent", Order = 0)]
        public TestRunConfigurationRemoteAgent Agent { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("controllerName")]
        public string ControllerName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationRemoteAgent",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationRemoteAgent
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NameValuePropertyType> _requiredProperties;

        [System.Xml.Serialization.XmlArrayAttribute("RequiredProperties", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Property",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<NameValuePropertyType> RequiredProperties
        {
            get { return _requiredProperties; }
            private set { _requiredProperties = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RequiredProperties collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredPropertiesSpecified
        {
            get { return (this.RequiredProperties.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationRemoteAgent" /> class.</para>
        /// </summary>
        public TestRunConfigurationRemoteAgent()
        {
            this._requiredProperties = new System.Collections.ObjectModel.Collection<NameValuePropertyType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationRemoteAgentRequiredProperties",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationRemoteAgentRequiredProperties
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NameValuePropertyType> _property;

        [System.Xml.Serialization.XmlElementAttribute("Property", Order = 0)]
        public System.Collections.ObjectModel.Collection<NameValuePropertyType> Property
        {
            get { return _property; }
            private set { _property = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Property collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertySpecified
        {
            get { return (this.Property.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationRemoteAgentRequiredProperties" /> class.</para>
        /// </summary>
        public TestRunConfigurationRemoteAgentRequiredProperties()
        {
            this._property = new System.Collections.ObjectModel.Collection<NameValuePropertyType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("NameValuePropertyType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NameValuePropertyType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationDeployment",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationDeployment : DeploymentItemsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _deploySatelliteAssemblies = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("deploySatelliteAssemblies")]
        public bool DeploySatelliteAssemblies
        {
            get { return _deploySatelliteAssemblies; }
            set { _deploySatelliteAssemblies = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ignoredDependentAssemblies")]
        public string IgnoredDependentAssemblies { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("userDeploymentRoot")]
        public string UserDeploymentRoot { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("runDeploymentRoot")]
        public string RunDeploymentRoot { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _useDefaultDeploymentRoot = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("useDefaultDeploymentRoot")]
        public bool UseDefaultDeploymentRoot
        {
            get { return _useDefaultDeploymentRoot; }
            set { _useDefaultDeploymentRoot = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _uploadDeploymentItems = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("uploadDeploymentItems")]
        public bool UploadDeploymentItems
        {
            get { return _uploadDeploymentItems; }
            set { _uploadDeploymentItems = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationNamingScheme",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationNamingScheme
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("baseName")]
        public string BaseName { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _appendTimeStamp = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("appendTimeStamp")]
        public bool AppendTimeStamp
        {
            get { return _appendTimeStamp; }
            set { _appendTimeStamp = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _useDefault = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("useDefault")]
        public bool UseDefault
        {
            get { return _useDefault; }
            set { _useDefault = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationScripts",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationScripts
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("cleanupScript")]
        public string CleanupScript { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("setupScript")]
        public string SetupScript { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationBuckets",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationBuckets
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _size = 200;

        [System.ComponentModel.DefaultValueAttribute(200)]
        [System.Xml.Serialization.XmlAttributeAttribute("size")]
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationExecutionThread",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationExecutionThread
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _apartmentState = "0";

        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.XmlAttributeAttribute("apartmentState")]
        public string ApartmentState
        {
            get { return _apartmentState; }
            set { _apartmentState = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationHosts",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationHosts
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationHostsAspNet> _aspNet;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("AspNet", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationHostsAspNet> AspNet
        {
            get { return _aspNet; }
            private set { _aspNet = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AspNet collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AspNetSpecified
        {
            get { return (this.AspNet.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationHosts" /> class.</para>
        /// </summary>
        public TestRunConfigurationHosts()
        {
            this._aspNet = new System.Collections.ObjectModel.Collection<TestRunConfigurationHostsAspNet>();
            this._deviceHostRunConfigData =
                new System.Collections.ObjectModel.Collection<TestRunConfigurationHostsDeviceHostRunConfigData>();
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfigurationHostsDeviceHostRunConfigData>
            _deviceHostRunConfigData;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("DeviceHostRunConfigData", Order = 1)]
        public System.Collections.ObjectModel.Collection<TestRunConfigurationHostsDeviceHostRunConfigData>
            DeviceHostRunConfigData
        {
            get { return _deviceHostRunConfigData; }
            private set { _deviceHostRunConfigData = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DeviceHostRunConfigData collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeviceHostRunConfigDataSpecified
        {
            get { return (this.DeviceHostRunConfigData.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 2)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _skipUnhostableTests = true;

        /// <summary>
        /// <para>New in Orcas</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DescriptionAttribute("New in Orcas")]
        [System.Xml.Serialization.XmlAttributeAttribute("skipUnhostableTests")]
        public bool SkipUnhostableTests
        {
            get { return _skipUnhostableTests; }
            set { _skipUnhostableTests = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationHostsAspNet",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationHostsAspNet
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DevelopmentServer", Order = 0)]
        public DevelopmentServerType DevelopmentServer { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("urlToTest")]
        public string UrlToTest { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("executionType")]
        public string ExecutionType { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationHostsDeviceHostRunConfigData",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationHostsDeviceHostRunConfigData
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("deviceId")]
        public string DeviceId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("deviceName")]
        public string DeviceName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("platformId")]
        public string PlatformId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("platformName")]
        public string PlatformName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("uiPlatformId")]
        public string UiPlatformId { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationTestTypeSpecific",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationTestTypeSpecific
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRunConfigurationType> _webTestRunConfiguration;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("WebTestRunConfiguration", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestRunConfigurationType> WebTestRunConfiguration
        {
            get { return _webTestRunConfiguration; }
            private set { _webTestRunConfiguration = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestRunConfiguration collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestRunConfigurationSpecified
        {
            get { return (this.WebTestRunConfiguration.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationTestTypeSpecific" /> class.</para>
        /// </summary>
        public TestRunConfigurationTestTypeSpecific()
        {
            this._webTestRunConfiguration =
                new System.Collections.ObjectModel.Collection<WebTestRunConfigurationType>();
            this._webTestRunConfig = new System.Collections.ObjectModel.Collection<WebTestRunConfigurationType>();
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRunConfigurationType> _webTestRunConfig;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// <para>Deprecated. Use WebTestRunConfiguration instead.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("WebTestRunConfig", Order = 1)]
        public System.Collections.ObjectModel.Collection<WebTestRunConfigurationType> WebTestRunConfig
        {
            get { return _webTestRunConfig; }
            private set { _webTestRunConfig = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestRunConfig collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestRunConfigSpecified
        {
            get { return (this.WebTestRunConfig.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 2)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRunConfigurationType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRunConfigurationType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Browser", Order = 0)]
        public BrowserType Browser { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Network", Order = 1)]
        public NetworkType Network { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _simulateThinkTimes = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("simulateThinkTimes")]
        public bool SimulateThinkTimes
        {
            get { return _simulateThinkTimes; }
            set { _simulateThinkTimes = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _useNewCookieDefaultPath = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("UseNewCookieDefaultPath")]
        public bool UseNewCookieDefaultPath
        {
            get { return _useNewCookieDefaultPath; }
            set { _useNewCookieDefaultPath = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _automaticallyDecompressResponse = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("AutomaticallyDecompressResponse")]
        public bool AutomaticallyDecompressResponse
        {
            get { return _automaticallyDecompressResponse; }
            set { _automaticallyDecompressResponse = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _stepping = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("stepping")]
        public bool Stepping
        {
            get { return _stepping; }
            set { _stepping = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _runUntilDataExhausted = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("runUntilDataExhausted")]
        public bool RunUntilDataExhausted
        {
            get { return _runUntilDataExhausted; }
            set { _runUntilDataExhausted = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _iterationCount = 1;

        [System.ComponentModel.DefaultValueAttribute(1)]
        [System.Xml.Serialization.XmlAttributeAttribute("iterationCount")]
        public int IterationCount
        {
            get { return _iterationCount; }
            set { _iterationCount = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testTypeId")]
        public string TestTypeId { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("NetworkType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NetworkType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("BandwidthInKbps")]
        public float BandwidthInKbps { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("NetworkProfileConfigurationXml")]
        public string NetworkProfileConfigurationXml { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationPlugins",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationPlugins
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _plugin;

        [System.Xml.Serialization.XmlElementAttribute("Plugin", Order = 0)]
        public System.Collections.ObjectModel.Collection<object> Plugin
        {
            get { return _plugin; }
            private set { _plugin = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Plugin collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PluginSpecified
        {
            get { return (this.Plugin.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationPlugins" /> class.</para>
        /// </summary>
        public TestRunConfigurationPlugins()
        {
            this._plugin = new System.Collections.ObjectModel.Collection<object>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationConstraints",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationConstraints
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _agent;

        [System.Xml.Serialization.XmlElementAttribute("Agent", Order = 0)]
        public System.Collections.ObjectModel.Collection<object> Agent
        {
            get { return _agent; }
            private set { _agent = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Agent collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentSpecified
        {
            get { return (this.Agent.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunConfigurationConstraints" /> class.</para>
        /// </summary>
        public TestRunConfigurationConstraints()
        {
            this._agent = new System.Collections.ObjectModel.Collection<object>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunConfigurationExecution",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunConfigurationExecution
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _parallelTestCount = 1;

        [System.ComponentModel.DefaultValueAttribute(1)]
        [System.Xml.Serialization.XmlAttributeAttribute("parallelTestCount")]
        public int ParallelTestCount
        {
            get { return _parallelTestCount; }
            set { _parallelTestCount = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TestSettings",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestSettingsType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 0)]
        public object Description { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Deployment", Order = 1)]
        public TestSettingsTypeDeployment Deployment { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NameValuePropertyType> _properties;

        [System.Xml.Serialization.XmlArrayAttribute("Properties", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Property",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<NameValuePropertyType> Properties
        {
            get { return _properties; }
            private set { _properties = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Properties collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertiesSpecified
        {
            get { return (this.Properties.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestSettingsType" /> class.</para>
        /// </summary>
        public TestSettingsType()
        {
            this._properties = new System.Collections.ObjectModel.Collection<NameValuePropertyType>();
            this._constraints = new System.Collections.ObjectModel.Collection<object>();
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("NamingScheme", Order = 3)]
        public TestSettingsTypeNamingScheme NamingScheme { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Scripts", Order = 4)]
        public TestSettingsTypeScripts Scripts { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _constraints;

        [System.Xml.Serialization.XmlArrayAttribute("Constraints", Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Agent",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<object> Constraints
        {
            get { return _constraints; }
            private set { _constraints = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Constraints collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConstraintsSpecified
        {
            get { return (this.Constraints.Count != 0); }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("RemoteController", Order = 6)]
        public TestSettingsTypeRemoteController RemoteController { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Execution", Order = 7)]
        public TestSettingsTypeExecution Execution { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CollectionOnlyAgents", Order = 8)]
        public AgentRuleCollectionType CollectionOnlyAgents { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _abortRunOnError = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("abortRunOnError")]
        public bool AbortRunOnError
        {
            get { return _abortRunOnError; }
            set { _abortRunOnError = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _autoSaveResults = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("autoSaveResults")]
        public bool AutoSaveResults
        {
            get { return _autoSaveResults; }
            set { _autoSaveResults = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _mapIpAddresses = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("mapIPAddresses")]
        public bool MapIpAddresses
        {
            get { return _mapIpAddresses; }
            set { _mapIpAddresses = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _traceExecutionSequence = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("traceExecutionSequence")]
        public bool TraceExecutionSequence
        {
            get { return _traceExecutionSequence; }
            set { _traceExecutionSequence = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enableDefaultDataCollectors = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("enableDefaultDataCollectors")]
        public bool EnableDefaultDataCollectors
        {
            get { return _enableDefaultDataCollectors; }
            set { _enableDefaultDataCollectors = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeDeployment",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeDeployment : DeploymentItemsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _deploySatelliteAssemblies = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("deploySatelliteAssemblies")]
        public bool DeploySatelliteAssemblies
        {
            get { return _deploySatelliteAssemblies; }
            set { _deploySatelliteAssemblies = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ignoredDependentAssemblies")]
        public string IgnoredDependentAssemblies { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("userDeploymentRoot")]
        public string UserDeploymentRoot { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("runDeploymentRoot")]
        public string RunDeploymentRoot { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _useDefaultDeploymentRoot = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("useDefaultDeploymentRoot")]
        public bool UseDefaultDeploymentRoot
        {
            get { return _useDefaultDeploymentRoot; }
            set { _useDefaultDeploymentRoot = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _uploadDeploymentItems = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("uploadDeploymentItems")]
        public bool UploadDeploymentItems
        {
            get { return _uploadDeploymentItems; }
            set { _uploadDeploymentItems = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PropertiesType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PropertiesType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NameValuePropertyType> _property;

        [System.Xml.Serialization.XmlElementAttribute("Property", Order = 0)]
        public System.Collections.ObjectModel.Collection<NameValuePropertyType> Property
        {
            get { return _property; }
            private set { _property = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Property collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertySpecified
        {
            get { return (this.Property.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PropertiesType" /> class.</para>
        /// </summary>
        public PropertiesType()
        {
            this._property = new System.Collections.ObjectModel.Collection<NameValuePropertyType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeNamingScheme",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeNamingScheme
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("baseName")]
        public string BaseName { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _appendTimeStamp = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("appendTimeStamp")]
        public bool AppendTimeStamp
        {
            get { return _appendTimeStamp; }
            set { _appendTimeStamp = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _useDefault = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("useDefault")]
        public bool UseDefault
        {
            get { return _useDefault; }
            set { _useDefault = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeScripts",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeScripts
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("cleanupScript")]
        public string CleanupScript { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("setupScript")]
        public string SetupScript { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeConstraints",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeConstraints
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _agent;

        [System.Xml.Serialization.XmlElementAttribute("Agent", Order = 0)]
        public System.Collections.ObjectModel.Collection<object> Agent
        {
            get { return _agent; }
            private set { _agent = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Agent collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentSpecified
        {
            get { return (this.Agent.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestSettingsTypeConstraints" /> class.</para>
        /// </summary>
        public TestSettingsTypeConstraints()
        {
            this._agent = new System.Collections.ObjectModel.Collection<object>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeRemoteController",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeRemoteController
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecution",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeExecution
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Buckets", Order = 0)]
        public TestSettingsTypeExecutionBuckets Buckets { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ExecutionThread", Order = 1)]
        public TestSettingsTypeExecutionExecutionThread ExecutionThread { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Hosts", Order = 2)]
        public TestSettingsTypeExecutionHosts Hosts { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TestTypeSpecific", Order = 3)]
        public TestSettingsTypeExecutionTestTypeSpecific TestTypeSpecific { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Timeouts", Order = 4)]
        public TestSettingsTypeExecutionTimeouts Timeouts { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("AgentRule", Order = 5)]
        public AgentRuleType AgentRule { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private TestSettingsTypeExecutionLocation _location =
            Schemas.VisualStudio.TeamTest.TestSettingsTypeExecutionLocation.Local;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.TestSettingsTypeExecutionLocation
            .Local)]
        [System.Xml.Serialization.XmlAttributeAttribute("location")]
        public TestSettingsTypeExecutionLocation Location
        {
            get { return _location; }
            set { _location = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private HostProcessPlatformTypeEnum _hostProcessPlatform =
            Schemas.VisualStudio.TeamTest.HostProcessPlatformTypeEnum.X86;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.HostProcessPlatformTypeEnum.X86)]
        [System.Xml.Serialization.XmlAttributeAttribute("hostProcessPlatform")]
        public HostProcessPlatformTypeEnum HostProcessPlatform
        {
            get { return _hostProcessPlatform; }
            set { _hostProcessPlatform = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _parallelTestCount = 1;

        [System.ComponentModel.DefaultValueAttribute(1)]
        [System.Xml.Serialization.XmlAttributeAttribute("parallelTestCount")]
        public int ParallelTestCount
        {
            get { return _parallelTestCount; }
            set { _parallelTestCount = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecutionBuckets",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeExecutionBuckets
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _threshold = 1000;

        [System.ComponentModel.DefaultValueAttribute(1000)]
        [System.Xml.Serialization.XmlAttributeAttribute("threshold")]
        public int Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _size = 200;

        [System.ComponentModel.DefaultValueAttribute(200)]
        [System.Xml.Serialization.XmlAttributeAttribute("size")]
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecutionExecutionThread",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeExecutionExecutionThread
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _apartmentState = "0";

        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.XmlAttributeAttribute("apartmentState")]
        public string ApartmentState
        {
            get { return _apartmentState; }
            set { _apartmentState = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecutionHosts",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeExecutionHosts
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestSettingsTypeExecutionHostsAspNet> _aspNet;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("AspNet", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestSettingsTypeExecutionHostsAspNet> AspNet
        {
            get { return _aspNet; }
            private set { _aspNet = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AspNet collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AspNetSpecified
        {
            get { return (this.AspNet.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestSettingsTypeExecutionHosts" /> class.</para>
        /// </summary>
        public TestSettingsTypeExecutionHosts()
        {
            this._aspNet = new System.Collections.ObjectModel.Collection<TestSettingsTypeExecutionHostsAspNet>();
            this._deviceHostRunConfigData =
                new System.Collections.ObjectModel.Collection<TestSettingsTypeExecutionHostsDeviceHostRunConfigData>();
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestSettingsTypeExecutionHostsDeviceHostRunConfigData>
            _deviceHostRunConfigData;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("DeviceHostRunConfigData", Order = 1)]
        public System.Collections.ObjectModel.Collection<TestSettingsTypeExecutionHostsDeviceHostRunConfigData>
            DeviceHostRunConfigData
        {
            get { return _deviceHostRunConfigData; }
            private set { _deviceHostRunConfigData = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DeviceHostRunConfigData collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeviceHostRunConfigDataSpecified
        {
            get { return (this.DeviceHostRunConfigData.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 2)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _skipUnhostableTests = true;

        /// <summary>
        /// <para>New in Orcas</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DescriptionAttribute("New in Orcas")]
        [System.Xml.Serialization.XmlAttributeAttribute("skipUnhostableTests")]
        public bool SkipUnhostableTests
        {
            get { return _skipUnhostableTests; }
            set { _skipUnhostableTests = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecutionHostsAspNet",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeExecutionHostsAspNet
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DevelopmentServer", Order = 0)]
        public DevelopmentServerType DevelopmentServer { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("urlToTest")]
        public string UrlToTest { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("executionType")]
        public string ExecutionType { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecutionHostsDeviceHostRunConfigData",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeExecutionHostsDeviceHostRunConfigData
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("deviceId")]
        public string DeviceId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("deviceName")]
        public string DeviceName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("platformId")]
        public string PlatformId { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("platformName")]
        public string PlatformName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("uiPlatformId")]
        public string UiPlatformId { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecutionTestTypeSpecific",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeExecutionTestTypeSpecific
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRunConfigurationType> _webTestRunConfiguration;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("WebTestRunConfiguration", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestRunConfigurationType> WebTestRunConfiguration
        {
            get { return _webTestRunConfiguration; }
            private set { _webTestRunConfiguration = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestRunConfiguration collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestRunConfigurationSpecified
        {
            get { return (this.WebTestRunConfiguration.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestSettingsTypeExecutionTestTypeSpecific" /> class.</para>
        /// </summary>
        public TestSettingsTypeExecutionTestTypeSpecific()
        {
            this._webTestRunConfiguration =
                new System.Collections.ObjectModel.Collection<WebTestRunConfigurationType>();
            this._webTestRunConfig = new System.Collections.ObjectModel.Collection<WebTestRunConfigurationType>();
            this._unitTestRunConfig = new System.Collections.ObjectModel.Collection<AssemblyResolutionSettingsType>();
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRunConfigurationType> _webTestRunConfig;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// <para>Deprecated. Use WebTestRunConfiguration instead.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("WebTestRunConfig", Order = 1)]
        public System.Collections.ObjectModel.Collection<WebTestRunConfigurationType> WebTestRunConfig
        {
            get { return _webTestRunConfig; }
            private set { _webTestRunConfig = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestRunConfig collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestRunConfigSpecified
        {
            get { return (this.WebTestRunConfig.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AssemblyResolutionSettingsType> _unitTestRunConfig;

        /// <summary>
        /// <para>Only one instance is allowed but no check is done due to xsd limitations.</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute(
            "Only one instance is allowed but no check is done due to xsd limitations.")]
        [System.Xml.Serialization.XmlElementAttribute("UnitTestRunConfig", Order = 2)]
        public System.Collections.ObjectModel.Collection<AssemblyResolutionSettingsType> UnitTestRunConfig
        {
            get { return _unitTestRunConfig; }
            private set { _unitTestRunConfig = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UnitTestRunConfig collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitTestRunConfigSpecified
        {
            get { return (this.UnitTestRunConfig.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 3)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AssemblyResolutionSettingsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TestExecution",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class AssemblyResolutionSettingsType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("AssemblyResolution", Order = 0)]
        public AssemblyResolutionSettingsTypeAssemblyResolution AssemblyResolution { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testTypeId")]
        public string TestTypeId { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AssemblyResolutionSettingsTypeAssemblyResolution",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AssemblyResolutionSettingsTypeAssemblyResolution
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TestDirectory", Order = 0)]
        public AssemblyResolutionSettingsTypeAssemblyResolutionTestDirectory TestDirectory { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RuntimeResolutionDirectoryType> _runtimeResolution;

        [System.Xml.Serialization.XmlArrayAttribute("RuntimeResolution", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Directory",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<RuntimeResolutionDirectoryType> RuntimeResolution
        {
            get { return _runtimeResolution; }
            private set { _runtimeResolution = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RuntimeResolution collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RuntimeResolutionSpecified
        {
            get { return (this.RuntimeResolution.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AssemblyResolutionSettingsTypeAssemblyResolution" /> class.</para>
        /// </summary>
        public AssemblyResolutionSettingsTypeAssemblyResolution()
        {
            this._runtimeResolution = new System.Collections.ObjectModel.Collection<RuntimeResolutionDirectoryType>();
            this._discoveryResolution = new System.Collections.ObjectModel.Collection<ResolutionDirectoryType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResolutionDirectoryType> _discoveryResolution;

        [System.Xml.Serialization.XmlArrayAttribute("DiscoveryResolution", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Directory",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<ResolutionDirectoryType> DiscoveryResolution
        {
            get { return _discoveryResolution; }
            private set { _discoveryResolution = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DiscoveryResolution collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscoveryResolutionSpecified
        {
            get { return (this.DiscoveryResolution.Count != 0); }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("applicationBaseDirectory")]
        public string ApplicationBaseDirectory { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AssemblyResolutionSettingsTypeAssemblyResolutionTestDirectory",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AssemblyResolutionSettingsTypeAssemblyResolutionTestDirectory
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("useLoadContext")]
        public bool UseLoadContext { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AssemblyResolutionSettingsTypeAssemblyResolutionRuntimeResolution",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AssemblyResolutionSettingsTypeAssemblyResolutionRuntimeResolution
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RuntimeResolutionDirectoryType> _directory;

        [System.Xml.Serialization.XmlElementAttribute("Directory", Order = 0)]
        public System.Collections.ObjectModel.Collection<RuntimeResolutionDirectoryType> Directory
        {
            get { return _directory; }
            private set { _directory = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Directory collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectorySpecified
        {
            get { return (this.Directory.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AssemblyResolutionSettingsTypeAssemblyResolutionRuntimeResolution" /> class.</para>
        /// </summary>
        public AssemblyResolutionSettingsTypeAssemblyResolutionRuntimeResolution()
        {
            this._directory = new System.Collections.ObjectModel.Collection<RuntimeResolutionDirectoryType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RuntimeResolutionDirectoryType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RuntimeResolutionDirectoryType : ResolutionDirectoryType
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("useLoadContext")]
        public bool UseLoadContextValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UseLoadContext property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UseLoadContextValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> UseLoadContext
        {
            get
            {
                if (this.UseLoadContextValueSpecified)
                {
                    return this.UseLoadContextValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UseLoadContextValue = value.GetValueOrDefault();
                this.UseLoadContextValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ResolutionDirectoryType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RuntimeResolutionDirectoryType))]
    public partial class ResolutionDirectoryType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("path")]
        public string Path { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("includeSubDirectories")]
        public bool IncludeSubDirectories { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AssemblyResolutionSettingsTypeAssemblyResolutionDiscoveryResolution",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AssemblyResolutionSettingsTypeAssemblyResolutionDiscoveryResolution
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResolutionDirectoryType> _directory;

        [System.Xml.Serialization.XmlElementAttribute("Directory", Order = 0)]
        public System.Collections.ObjectModel.Collection<ResolutionDirectoryType> Directory
        {
            get { return _directory; }
            private set { _directory = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Directory collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectorySpecified
        {
            get { return (this.Directory.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AssemblyResolutionSettingsTypeAssemblyResolutionDiscoveryResolution" /> class.</para>
        /// </summary>
        public AssemblyResolutionSettingsTypeAssemblyResolutionDiscoveryResolution()
        {
            this._directory = new System.Collections.ObjectModel.Collection<ResolutionDirectoryType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecutionTimeouts",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestSettingsTypeExecutionTimeouts
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _runTimeout = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("runTimeout")]
        public int RunTimeout
        {
            get { return _runTimeout; }
            set { _runTimeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _testTimeout = 1800000;

        [System.ComponentModel.DefaultValueAttribute(1800000)]
        [System.Xml.Serialization.XmlAttributeAttribute("testTimeout")]
        public int TestTimeout
        {
            get { return _testTimeout; }
            set { _testTimeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _agentNotRespondingTimeout = 300000;

        [System.ComponentModel.DefaultValueAttribute(300000)]
        [System.Xml.Serialization.XmlAttributeAttribute("agentNotRespondingTimeout")]
        public int AgentNotRespondingTimeout
        {
            get { return _agentNotRespondingTimeout; }
            set { _agentNotRespondingTimeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _deploymentTimeout = 300000;

        [System.ComponentModel.DefaultValueAttribute(300000)]
        [System.Xml.Serialization.XmlAttributeAttribute("deploymentTimeout")]
        public int DeploymentTimeout
        {
            get { return _deploymentTimeout; }
            set { _deploymentTimeout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _scriptTimeout = 300000;

        [System.ComponentModel.DefaultValueAttribute(300000)]
        [System.Xml.Serialization.XmlAttributeAttribute("scriptTimeout")]
        public int ScriptTimeout
        {
            get { return _scriptTimeout; }
            set { _scriptTimeout = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AgentRuleType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgentRuleType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("SelectionCriteria", Order = 0)]
        public AgentRuleTypeSelectionCriteria SelectionCriteria { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AgentRuleTypeDataCollectorsDataCollector> _dataCollectors;

        [System.Xml.Serialization.XmlArrayAttribute("DataCollectors", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DataCollector",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<AgentRuleTypeDataCollectorsDataCollector> DataCollectors
        {
            get { return _dataCollectors; }
            private set { _dataCollectors = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataCollectors collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCollectorsSpecified
        {
            get { return (this.DataCollectors.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AgentRuleType" /> class.</para>
        /// </summary>
        public AgentRuleType()
        {
            this._dataCollectors =
                new System.Collections.ObjectModel.Collection<AgentRuleTypeDataCollectorsDataCollector>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AgentRuleTypeSelectionCriteria",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgentRuleTypeSelectionCriteria
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NameValuePropertyType> _agentProperty;

        [System.Xml.Serialization.XmlElementAttribute("AgentProperty", Order = 0)]
        public System.Collections.ObjectModel.Collection<NameValuePropertyType> AgentProperty
        {
            get { return _agentProperty; }
            private set { _agentProperty = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AgentProperty collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentPropertySpecified
        {
            get { return (this.AgentProperty.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AgentRuleTypeSelectionCriteria" /> class.</para>
        /// </summary>
        public AgentRuleTypeSelectionCriteria()
        {
            this._agentProperty = new System.Collections.ObjectModel.Collection<NameValuePropertyType>();
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("selectAllAgents")]
        public bool SelectAllAgentsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SelectAllAgents property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SelectAllAgentsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> SelectAllAgents
        {
            get
            {
                if (this.SelectAllAgentsValueSpecified)
                {
                    return this.SelectAllAgentsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SelectAllAgentsValue = value.GetValueOrDefault();
                this.SelectAllAgentsValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AgentRuleTypeDataCollectors",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgentRuleTypeDataCollectors
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AgentRuleTypeDataCollectorsDataCollector> _dataCollector;

        [System.Xml.Serialization.XmlElementAttribute("DataCollector", Order = 0)]
        public System.Collections.ObjectModel.Collection<AgentRuleTypeDataCollectorsDataCollector> DataCollector
        {
            get { return _dataCollector; }
            private set { _dataCollector = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataCollector collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCollectorSpecified
        {
            get { return (this.DataCollector.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AgentRuleTypeDataCollectors" /> class.</para>
        /// </summary>
        public AgentRuleTypeDataCollectors()
        {
            this._dataCollector =
                new System.Collections.ObjectModel.Collection<AgentRuleTypeDataCollectorsDataCollector>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AgentRuleTypeDataCollectorsDataCollector",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgentRuleTypeDataCollectorsDataCollector
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Configuration", Order = 0)]
        public AgentRuleTypeDataCollectorsDataCollectorConfiguration Configuration { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("uri")]
        public string Uri { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("friendlyName")]
        public string FriendlyName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("assemblyQualifiedName")]
        public string AssemblyQualifiedName { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AgentRuleTypeDataCollectorsDataCollectorConfiguration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgentRuleTypeDataCollectorsDataCollectorConfiguration
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AgentRuleTypeDataCollectorsDataCollectorConfiguration" /> class.</para>
        /// </summary>
        public AgentRuleTypeDataCollectorsDataCollectorConfiguration()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestSettingsTypeExecutionLocation",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    public enum TestSettingsTypeExecutionLocation
    {
        Local,

        Remote,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AgentRuleCollectionType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgentRuleCollectionType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AgentRuleType> _agentRules;

        [System.Xml.Serialization.XmlArrayAttribute("AgentRules", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AgentRule",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<AgentRuleType> AgentRules
        {
            get { return _agentRules; }
            private set { _agentRules = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AgentRules collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentRulesSpecified
        {
            get { return (this.AgentRules.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AgentRuleCollectionType" /> class.</para>
        /// </summary>
        public AgentRuleCollectionType()
        {
            this._agentRules = new System.Collections.ObjectModel.Collection<AgentRuleType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AgentRuleCollectionTypeAgentRules",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgentRuleCollectionTypeAgentRules
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AgentRuleType> _agentRule;

        [System.Xml.Serialization.XmlElementAttribute("AgentRule", Order = 0)]
        public System.Collections.ObjectModel.Collection<AgentRuleType> AgentRule
        {
            get { return _agentRule; }
            private set { _agentRule = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AgentRule collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentRuleSpecified
        {
            get { return (this.AgentRule.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AgentRuleCollectionTypeAgentRules" /> class.</para>
        /// </summary>
        public AgentRuleCollectionTypeAgentRules()
        {
            this._agentRule = new System.Collections.ObjectModel.Collection<AgentRuleType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebRequestResultType> _webRequestResult;

        [System.Xml.Serialization.XmlElementAttribute("WebRequestResult", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebRequestResultType> WebRequestResult
        {
            get { return _webRequestResult; }
            private set { _webRequestResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebRequestResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebRequestResultSpecified
        {
            get { return (this.WebRequestResult.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebRequestResultsType" /> class.</para>
        /// </summary>
        public WebRequestResultsType()
        {
            this._webRequestResult = new System.Collections.ObjectModel.Collection<WebRequestResultType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Request", Order = 0)]
        public WebRequestResultTypeRequest Request { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Response", Order = 1)]
        public WebRequestResultTypeResponse Response { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebRequestResultTypeContextEntry> _context;

        [System.Xml.Serialization.XmlArrayAttribute("Context", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Entry",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<WebRequestResultTypeContextEntry> Context
        {
            get { return _context; }
            private set { _context = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Context collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContextSpecified
        {
            get { return (this.Context.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebRequestResultType" /> class.</para>
        /// </summary>
        public WebRequestResultType()
        {
            this._context = new System.Collections.ObjectModel.Collection<WebRequestResultTypeContextEntry>();
            this._errors = new System.Collections.ObjectModel.Collection<WebRequestResultTypeErrorsError>();
            this._dependantResults = new System.Collections.ObjectModel.Collection<WebRequestResultType>();
            this._validationRuleResults = new System.Collections.ObjectModel.Collection<RuleResultType>();
            this._extractionRuleResults = new System.Collections.ObjectModel.Collection<RuleResultType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebRequestResultTypeErrorsError> _errors;

        [System.Xml.Serialization.XmlArrayAttribute("Errors", Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Error",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<WebRequestResultTypeErrorsError> Errors
        {
            get { return _errors; }
            private set { _errors = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Errors collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorsSpecified
        {
            get { return (this.Errors.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebRequestResultType> _dependantResults;

        [System.Xml.Serialization.XmlArrayAttribute("DependantResults", Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("WebRequestResult",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<WebRequestResultType> DependantResults
        {
            get { return _dependantResults; }
            private set { _dependantResults = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DependantResults collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DependantResultsSpecified
        {
            get { return (this.DependantResults.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RuleResultType> _validationRuleResults;

        [System.Xml.Serialization.XmlArrayAttribute("ValidationRuleResults", Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ValidationRuleResult",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<RuleResultType> ValidationRuleResults
        {
            get { return _validationRuleResults; }
            private set { _validationRuleResults = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ValidationRuleResults collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidationRuleResultsSpecified
        {
            get { return (this.ValidationRuleResults.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RuleResultType> _extractionRuleResults;

        [System.Xml.Serialization.XmlArrayAttribute("ExtractionRuleResults", Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtractionRuleResult",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<RuleResultType> ExtractionRuleResults
        {
            get { return _extractionRuleResults; }
            private set { _extractionRuleResults = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ExtractionRuleResults collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtractionRuleResultsSpecified
        {
            get { return (this.ExtractionRuleResults.Count != 0); }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("redirectUrl")]
        public string RedirectUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("exceptionMessage")]
        public string ExceptionMessage { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("run")]
        public int RunValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Run property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RunValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Run
        {
            get
            {
                if (this.RunValueSpecified)
                {
                    return this.RunValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RunValue = value.GetValueOrDefault();
                this.RunValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("submitted")]
        public bool SubmittedValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Submitted property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SubmittedValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Submitted
        {
            get
            {
                if (this.SubmittedValueSpecified)
                {
                    return this.SubmittedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SubmittedValue = value.GetValueOrDefault();
                this.SubmittedValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("cached")]
        public bool CachedValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Cached property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CachedValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Cached
        {
            get
            {
                if (this.CachedValueSpecified)
                {
                    return this.CachedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CachedValue = value.GetValueOrDefault();
                this.CachedValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("isRedirectFollow")]
        public bool IsRedirectFollowValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsRedirectFollow property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IsRedirectFollowValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IsRedirectFollow
        {
            get
            {
                if (this.IsRedirectFollowValueSpecified)
                {
                    return this.IsRedirectFollowValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IsRedirectFollowValue = value.GetValueOrDefault();
                this.IsRedirectFollowValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("requestBodyBytesHandle")]
        public int RequestBodyBytesHandleValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RequestBodyBytesHandle property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RequestBodyBytesHandleValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> RequestBodyBytesHandle
        {
            get
            {
                if (this.RequestBodyBytesHandleValueSpecified)
                {
                    return this.RequestBodyBytesHandleValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RequestBodyBytesHandleValue = value.GetValueOrDefault();
                this.RequestBodyBytesHandleValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("responseBytesHandle")]
        public int ResponseBytesHandleValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ResponseBytesHandle property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ResponseBytesHandleValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> ResponseBytesHandle
        {
            get
            {
                if (this.ResponseBytesHandleValueSpecified)
                {
                    return this.ResponseBytesHandleValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ResponseBytesHandleValue = value.GetValueOrDefault();
                this.ResponseBytesHandleValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("resultsUrl")]
        public string ResultsUrl { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _httpStatus = 200;

        [System.ComponentModel.DefaultValueAttribute(200)]
        [System.Xml.Serialization.XmlAttributeAttribute("httpStatus")]
        public int HttpStatus
        {
            get { return _httpStatus; }
            set { _httpStatus = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _recordResult = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("recordResult")]
        public bool RecordResult
        {
            get { return _recordResult; }
            set { _recordResult = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("scenarioName")]
        public string ScenarioName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testCaseName")]
        public string TestCaseName { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("failedValidationRuleCount")]
        public int FailedValidationRuleCountValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FailedValidationRuleCount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool FailedValidationRuleCountValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> FailedValidationRuleCount
        {
            get
            {
                if (this.FailedValidationRuleCountValueSpecified)
                {
                    return this.FailedValidationRuleCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FailedValidationRuleCountValue = value.GetValueOrDefault();
                this.FailedValidationRuleCountValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("successfulExtractionRuleCount")]
        public int SuccessfulExtractionRuleCountValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SuccessfulExtractionRuleCount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SuccessfulExtractionRuleCountValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> SuccessfulExtractionRuleCount
        {
            get
            {
                if (this.SuccessfulExtractionRuleCountValueSpecified)
                {
                    return this.SuccessfulExtractionRuleCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SuccessfulExtractionRuleCountValue = value.GetValueOrDefault();
                this.SuccessfulExtractionRuleCountValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("failedExtractionRuleCount")]
        public int FailedExtractionRuleCountValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FailedExtractionRuleCount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool FailedExtractionRuleCountValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> FailedExtractionRuleCount
        {
            get
            {
                if (this.FailedExtractionRuleCountValueSpecified)
                {
                    return this.FailedExtractionRuleCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FailedExtractionRuleCountValue = value.GetValueOrDefault();
                this.FailedExtractionRuleCountValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("requestPassedByCode")]
        public bool RequestPassedByCodeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RequestPassedByCode property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RequestPassedByCodeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> RequestPassedByCode
        {
            get
            {
                if (this.RequestPassedByCodeValueSpecified)
                {
                    return this.RequestPassedByCodeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RequestPassedByCodeValue = value.GetValueOrDefault();
                this.RequestPassedByCodeValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultTypeRequest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultTypeRequest
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Headers", Order = 0)]
        public object Headers { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("url")]
        public string Url { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("command")]
        public string Command { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("contentType")]
        public string ContentType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("encoding")]
        public string Encoding { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultTypeResponse",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultTypeResponse
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Headers", Order = 0)]
        public object Headers { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("url")]
        public string Url { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("contentType")]
        public string ContentType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("statusLine")]
        public string StatusLine { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("pageTime")]
        public string PageTime { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("time")]
        public string Time { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("statusCodeString")]
        public string StatusCodeString { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("contentLength")]
        public string ContentLength { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultTypeContext",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultTypeContext
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebRequestResultTypeContextEntry> _entry;

        [System.Xml.Serialization.XmlElementAttribute("Entry", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebRequestResultTypeContextEntry> Entry
        {
            get { return _entry; }
            private set { _entry = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Entry collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntrySpecified
        {
            get { return (this.Entry.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebRequestResultTypeContext" /> class.</para>
        /// </summary>
        public WebRequestResultTypeContext()
        {
            this._entry = new System.Collections.ObjectModel.Collection<WebRequestResultTypeContextEntry>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultTypeContextEntry",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultTypeContextEntry
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultTypeErrors",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultTypeErrors
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebRequestResultTypeErrorsError> _error;

        [System.Xml.Serialization.XmlElementAttribute("Error", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebRequestResultTypeErrorsError> Error
        {
            get { return _error; }
            private set { _error = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Error collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorSpecified
        {
            get { return (this.Error.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebRequestResultTypeErrors" /> class.</para>
        /// </summary>
        public WebRequestResultTypeErrors()
        {
            this._error = new System.Collections.ObjectModel.Collection<WebRequestResultTypeErrorsError>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultTypeErrorsError",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultTypeErrorsError
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("StackTrace", Order = 0)]
        public object StackTrace { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ExceptionText", Order = 1)]
        public object ExceptionText { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public WebTestErrorType TypeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Type property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TypeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<WebTestErrorType> Type
        {
            get
            {
                if (this.TypeValueSpecified)
                {
                    return this.TypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TypeValue = value.GetValueOrDefault();
                this.TypeValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("subType")]
        public string SubType { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("text")]
        public string Text { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("stackTrace")]
        public string StackTrace1 { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("exceptionText")]
        public string ExceptionText1 { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("time")]
        public string Time { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestErrorType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum WebTestErrorType
    {
        TestError,

        Exception,

        HttpError,

        ValidationRuleError,

        ExtractionRuleError,

        ConditionalRuleError,

        Timeout,

        DataCollectionError,

        DataCollectionWarning,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultTypeValidationRuleResults",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultTypeValidationRuleResults
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RuleResultType> _validationRuleResult;

        [System.Xml.Serialization.XmlElementAttribute("ValidationRuleResult", Order = 0)]
        public System.Collections.ObjectModel.Collection<RuleResultType> ValidationRuleResult
        {
            get { return _validationRuleResult; }
            private set { _validationRuleResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ValidationRuleResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidationRuleResultSpecified
        {
            get { return (this.ValidationRuleResult.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebRequestResultTypeValidationRuleResults" /> class.</para>
        /// </summary>
        public WebRequestResultTypeValidationRuleResults()
        {
            this._validationRuleResult = new System.Collections.ObjectModel.Collection<RuleResultType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RuleResultType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RuleResultType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RuleResultTypeRulePropertiesRuleProperty> _ruleProperties;

        [System.Xml.Serialization.XmlArrayAttribute("RuleProperties", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RuleProperty",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<RuleResultTypeRulePropertiesRuleProperty> RuleProperties
        {
            get { return _ruleProperties; }
            private set { _ruleProperties = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RuleProperties collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RulePropertiesSpecified
        {
            get { return (this.RuleProperties.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RuleResultType" /> class.</para>
        /// </summary>
        public RuleResultType()
        {
            this._ruleProperties =
                new System.Collections.ObjectModel.Collection<RuleResultTypeRulePropertiesRuleProperty>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ruleType")]
        public string RuleType { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _success = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("success")]
        public bool Success
        {
            get { return _success; }
            set { _success = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("message")]
        public string Message { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RuleResultTypeRuleProperties",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RuleResultTypeRuleProperties
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RuleResultTypeRulePropertiesRuleProperty> _ruleProperty;

        [System.Xml.Serialization.XmlElementAttribute("RuleProperty", Order = 0)]
        public System.Collections.ObjectModel.Collection<RuleResultTypeRulePropertiesRuleProperty> RuleProperty
        {
            get { return _ruleProperty; }
            private set { _ruleProperty = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RuleProperty collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RulePropertySpecified
        {
            get { return (this.RuleProperty.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RuleResultTypeRuleProperties" /> class.</para>
        /// </summary>
        public RuleResultTypeRuleProperties()
        {
            this._ruleProperty =
                new System.Collections.ObjectModel.Collection<RuleResultTypeRulePropertiesRuleProperty>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RuleResultTypeRulePropertiesRuleProperty",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RuleResultTypeRulePropertiesRuleProperty
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebRequestResultTypeExtractionRuleResults",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebRequestResultTypeExtractionRuleResults
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RuleResultType> _extractionRuleResult;

        [System.Xml.Serialization.XmlElementAttribute("ExtractionRuleResult", Order = 0)]
        public System.Collections.ObjectModel.Collection<RuleResultType> ExtractionRuleResult
        {
            get { return _extractionRuleResult; }
            private set { _extractionRuleResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ExtractionRuleResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtractionRuleResultSpecified
        {
            get { return (this.ExtractionRuleResult.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebRequestResultTypeExtractionRuleResults" /> class.</para>
        /// </summary>
        public WebRequestResultTypeExtractionRuleResults()
        {
            this._extractionRuleResult = new System.Collections.ObjectModel.Collection<RuleResultType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultDetailsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultDetailsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            WebTestResultDetailsTypeWebTestResultIterationsWebTestResultIteration> _webTestResultIterations;

        [System.Xml.Serialization.XmlArrayAttribute("WebTestResultIterations", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("WebTestResultIteration",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            WebTestResultDetailsTypeWebTestResultIterationsWebTestResultIteration> WebTestResultIterations
        {
            get { return _webTestResultIterations; }
            private set { _webTestResultIterations = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestResultIterations collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestResultIterationsSpecified
        {
            get { return (this.WebTestResultIterations.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestResultDetailsType" /> class.</para>
        /// </summary>
        public WebTestResultDetailsType()
        {
            this._webTestResultIterations =
                new System.Collections.ObjectModel.Collection<
                    WebTestResultDetailsTypeWebTestResultIterationsWebTestResultIteration>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultDetailsTypeWebTestResultIterations",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultDetailsTypeWebTestResultIterations
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            WebTestResultDetailsTypeWebTestResultIterationsWebTestResultIteration> _webTestResultIteration;

        [System.Xml.Serialization.XmlElementAttribute("WebTestResultIteration", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            WebTestResultDetailsTypeWebTestResultIterationsWebTestResultIteration> WebTestResultIteration
        {
            get { return _webTestResultIteration; }
            private set { _webTestResultIteration = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestResultIteration collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestResultIterationSpecified
        {
            get { return (this.WebTestResultIteration.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestResultDetailsTypeWebTestResultIterations" /> class.</para>
        /// </summary>
        public WebTestResultDetailsTypeWebTestResultIterations()
        {
            this._webTestResultIteration =
                new System.Collections.ObjectModel.Collection<
                    WebTestResultDetailsTypeWebTestResultIterationsWebTestResultIteration>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultDetailsTypeWebTestResultIterationsWebTestResultIteration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultDetailsTypeWebTestResultIterationsWebTestResultIteration
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("WebTestResultGroup", Order = 0)]
        public WebTestResultGroupType WebTestResultGroup { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("iterationNumber")]
        public int IterationNumber { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultGroupType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultGroupType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultCommentType> _webTestResultComment;

        [System.Xml.Serialization.XmlElementAttribute("WebTestResultComment", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestResultCommentType> WebTestResultComment
        {
            get { return _webTestResultComment; }
            private set { _webTestResultComment = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestResultComment collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestResultCommentSpecified
        {
            get { return (this.WebTestResultComment.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestResultGroupType" /> class.</para>
        /// </summary>
        public WebTestResultGroupType()
        {
            this._webTestResultComment = new System.Collections.ObjectModel.Collection<WebTestResultCommentType>();
            this._webTestResultTransaction =
                new System.Collections.ObjectModel.Collection<WebTestResultTransactionType>();
            this._webTestResultPage = new System.Collections.ObjectModel.Collection<WebTestResultPageType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultTransactionType> _webTestResultTransaction;

        [System.Xml.Serialization.XmlElementAttribute("WebTestResultTransaction", Order = 1)]
        public System.Collections.ObjectModel.Collection<WebTestResultTransactionType> WebTestResultTransaction
        {
            get { return _webTestResultTransaction; }
            private set { _webTestResultTransaction = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestResultTransaction collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestResultTransactionSpecified
        {
            get { return (this.WebTestResultTransaction.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultPageType> _webTestResultPage;

        [System.Xml.Serialization.XmlElementAttribute("WebTestResultPage", Order = 2)]
        public System.Collections.ObjectModel.Collection<WebTestResultPageType> WebTestResultPage
        {
            get { return _webTestResultPage; }
            private set { _webTestResultPage = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTestResultPage collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestResultPageSpecified
        {
            get { return (this.WebTestResultPage.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultCommentType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultCommentType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("comment")]
        public string Comment { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultTransactionType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultTransactionType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("WebTestResultGroup", Order = 0)]
        public WebTestResultGroupType WebTestResultGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("isIncludedTest")]
        public bool IsIncludedTestValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsIncludedTest property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IsIncludedTestValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IsIncludedTest
        {
            get
            {
                if (this.IsIncludedTestValueSpecified)
                {
                    return this.IsIncludedTestValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IsIncludedTestValue = value.GetValueOrDefault();
                this.IsIncludedTestValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("responseTime")]
        public string ResponseTime { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultPageType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultPageType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("WebRequestResult", Order = 0)]
        public WebRequestResultType WebRequestResult { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultRedirectedPageType> _redirectedPages;

        [System.Xml.Serialization.XmlArrayAttribute("RedirectedPages", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RedirectedPage",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<WebTestResultRedirectedPageType> RedirectedPages
        {
            get { return _redirectedPages; }
            private set { _redirectedPages = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RedirectedPages collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RedirectedPagesSpecified
        {
            get { return (this.RedirectedPages.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestResultPageType" /> class.</para>
        /// </summary>
        public WebTestResultPageType()
        {
            this._redirectedPages = new System.Collections.ObjectModel.Collection<WebTestResultRedirectedPageType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultPageTypeRedirectedPages",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultPageTypeRedirectedPages
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestResultRedirectedPageType> _redirectedPage;

        [System.Xml.Serialization.XmlElementAttribute("RedirectedPage", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestResultRedirectedPageType> RedirectedPage
        {
            get { return _redirectedPage; }
            private set { _redirectedPage = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RedirectedPage collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RedirectedPageSpecified
        {
            get { return (this.RedirectedPage.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestResultPageTypeRedirectedPages" /> class.</para>
        /// </summary>
        public WebTestResultPageTypeRedirectedPages()
        {
            this._redirectedPage = new System.Collections.ObjectModel.Collection<WebTestResultRedirectedPageType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestResultRedirectedPageType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestResultRedirectedPageType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("WebRequestResult", Order = 0)]
        public WebRequestResultType WebRequestResult { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeAnalyzerViewState",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeAnalyzerViewState
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("LoadTestRunDescriptor", Order = 0)]
        public LoadTestRunDescriptorType LoadTestRunDescriptor { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestRunDescriptorType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestRunDescriptorType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GraphDescriptorType> _graphDescriptors;

        [System.Xml.Serialization.XmlArrayAttribute("GraphDescriptors", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("GraphDescriptor",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<GraphDescriptorType> GraphDescriptors
        {
            get { return _graphDescriptors; }
            private set { _graphDescriptors = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the GraphDescriptors collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GraphDescriptorsSpecified
        {
            get { return (this.GraphDescriptors.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestRunDescriptorType" /> class.</para>
        /// </summary>
        public LoadTestRunDescriptorType()
        {
            this._graphDescriptors = new System.Collections.ObjectModel.Collection<GraphDescriptorType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isLegendPanelVisible = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("isLegendPanelVisible")]
        public bool IsLegendPanelVisible
        {
            get { return _isLegendPanelVisible; }
            set { _isLegendPanelVisible = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isOverviewPanelVisible = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("isOverviewPanelVisible")]
        public bool IsOverviewPanelVisible
        {
            get { return _isOverviewPanelVisible; }
            set { _isOverviewPanelVisible = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isCounterPanelVisible = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("isCounterPanelVisible")]
        public bool IsCounterPanelVisible
        {
            get { return _isCounterPanelVisible; }
            set { _isCounterPanelVisible = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _scrollingGraph = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("scrollingGraph")]
        public bool ScrollingGraph
        {
            get { return _scrollingGraph; }
            set { _scrollingGraph = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _minMaxGraph = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("minMaxGraph")]
        public bool MinMaxGraph
        {
            get { return _minMaxGraph; }
            set { _minMaxGraph = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _showHorizontalGridOnGraph = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("showHorizontalGridOnGraph")]
        public bool ShowHorizontalGridOnGraph
        {
            get { return _showHorizontalGridOnGraph; }
            set { _showHorizontalGridOnGraph = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _showThresholdsOnGraph = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("showThresholdsOnGraph")]
        public bool ShowThresholdsOnGraph
        {
            get { return _showThresholdsOnGraph; }
            set { _showThresholdsOnGraph = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _showComparison = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("showComparison")]
        public bool ShowComparison
        {
            get { return _showComparison; }
            set { _showComparison = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _showZoom = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("showZoom")]
        public bool ShowZoom
        {
            get { return _showZoom; }
            set { _showZoom = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _lockZoom = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("lockZoom")]
        public bool LockZoom
        {
            get { return _lockZoom; }
            set { _lockZoom = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private LoadTestRunDescriptorViewType _activeConsoleView =
            Schemas.VisualStudio.TeamTest.LoadTestRunDescriptorViewType.Graph;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.LoadTestRunDescriptorViewType.Graph)]
        [System.Xml.Serialization.XmlAttributeAttribute("activeConsoleView")]
        public LoadTestRunDescriptorViewType ActiveConsoleView
        {
            get { return _activeConsoleView; }
            set { _activeConsoleView = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("selectedGraphPanel1")]
        public string SelectedGraphPanel1 { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("selectedGraphPanel2")]
        public string SelectedGraphPanel2 { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("selectedGraphPanel3")]
        public string SelectedGraphPanel3 { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("selectedGraphPanel4")]
        public string SelectedGraphPanel4 { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private PanelLayoutType _graphPanelLayout = Schemas.VisualStudio.TeamTest.PanelLayoutType.FourGrid;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.PanelLayoutType.FourGrid)]
        [System.Xml.Serialization.XmlAttributeAttribute("graphPanelLayout")]
        public PanelLayoutType GraphPanelLayout
        {
            get { return _graphPanelLayout; }
            set { _graphPanelLayout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private PanelLayoutType _tablePanelLayout = Schemas.VisualStudio.TeamTest.PanelLayoutType.TwoHorizontal;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.PanelLayoutType.TwoHorizontal)]
        [System.Xml.Serialization.XmlAttributeAttribute("tablePanelLayout")]
        public PanelLayoutType TablePanelLayout
        {
            get { return _tablePanelLayout; }
            set { _tablePanelLayout = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _selectedTablePanel1 = "Tests";

        [System.ComponentModel.DefaultValueAttribute("Tests")]
        [System.Xml.Serialization.XmlAttributeAttribute("selectedTablePanel1")]
        public string SelectedTablePanel1
        {
            get { return _selectedTablePanel1; }
            set { _selectedTablePanel1 = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _selectedTablePanel2 = "Errors";

        [System.ComponentModel.DefaultValueAttribute("Errors")]
        [System.Xml.Serialization.XmlAttributeAttribute("selectedTablePanel2")]
        public string SelectedTablePanel2
        {
            get { return _selectedTablePanel2; }
            set { _selectedTablePanel2 = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _selectedTablePanel3 = "Thresholds";

        [System.ComponentModel.DefaultValueAttribute("Thresholds")]
        [System.Xml.Serialization.XmlAttributeAttribute("selectedTablePanel3")]
        public string SelectedTablePanel3
        {
            get { return _selectedTablePanel3; }
            set { _selectedTablePanel3 = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _selectedTablePanel4 = "Transactions";

        [System.ComponentModel.DefaultValueAttribute("Transactions")]
        [System.Xml.Serialization.XmlAttributeAttribute("selectedTablePanel4")]
        public string SelectedTablePanel4
        {
            get { return _selectedTablePanel4; }
            set { _selectedTablePanel4 = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("controllerName")]
        public string ControllerName { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isLocalRun = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("isLocalRun")]
        public bool IsLocalRun
        {
            get { return _isLocalRun; }
            set { _isLocalRun = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testRunId")]
        public string TestRunId { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _repositoryRunId = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("repositoryRunId")]
        public int RepositoryRunId
        {
            get { return _repositoryRunId; }
            set { _repositoryRunId = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestRunDescriptorTypeGraphDescriptors",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestRunDescriptorTypeGraphDescriptors
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GraphDescriptorType> _graphDescriptor;

        [System.Xml.Serialization.XmlElementAttribute("GraphDescriptor", Order = 0)]
        public System.Collections.ObjectModel.Collection<GraphDescriptorType> GraphDescriptor
        {
            get { return _graphDescriptor; }
            private set { _graphDescriptor = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the GraphDescriptor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GraphDescriptorSpecified
        {
            get { return (this.GraphDescriptor.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestRunDescriptorTypeGraphDescriptors" /> class.</para>
        /// </summary>
        public LoadTestRunDescriptorTypeGraphDescriptors()
        {
            this._graphDescriptor = new System.Collections.ObjectModel.Collection<GraphDescriptorType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestRunDescriptorViewType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum LoadTestRunDescriptorViewType
    {
        None,

        Graph,

        Summary,

        Table,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PanelLayoutType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum PanelLayoutType
    {
        One,

        TwoHorizontal,

        TwoVertical,

        ThreeLeft,

        ThreeRight,

        ThreeTop,

        ThreeBottom,

        ThreeHorizontal,

        ThreeVertical,

        FourHorizontal,

        FourVertical,

        FourGrid,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeSummary",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummary
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestResultTypeSummaryPerformanceCounterResultsPerformanceCounterResult> _performanceCounterResults;

        [System.Xml.Serialization.XmlArrayAttribute("PerformanceCounterResults", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PerformanceCounterResult",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestResultTypeSummaryPerformanceCounterResultsPerformanceCounterResult> PerformanceCounterResults
        {
            get { return _performanceCounterResults; }
            private set { _performanceCounterResults = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PerformanceCounterResults collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PerformanceCounterResultsSpecified
        {
            get { return (this.PerformanceCounterResults.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestResultTypeSummary" /> class.</para>
        /// </summary>
        public LoadTestResultTypeSummary()
        {
            this._performanceCounterResults =
                new System.Collections.ObjectModel.Collection<
                    LoadTestResultTypeSummaryPerformanceCounterResultsPerformanceCounterResult>();
            this._pageSummaries =
                new System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryPageSummariesPageSummary>();
            this._testSummaries =
                new System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryTestSummariesTestSummary>();
            this._transactionSummaries =
                new System.Collections.ObjectModel.Collection<
                    LoadTestResultTypeSummaryTransactionSummariesTransactionSummary>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryPageSummariesPageSummary>
            _pageSummaries;

        [System.Xml.Serialization.XmlArrayAttribute("PageSummaries", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PageSummary",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryPageSummariesPageSummary>
            PageSummaries
        {
            get { return _pageSummaries; }
            private set { _pageSummaries = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PageSummaries collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageSummariesSpecified
        {
            get { return (this.PageSummaries.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryTestSummariesTestSummary>
            _testSummaries;

        [System.Xml.Serialization.XmlArrayAttribute("TestSummaries", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TestSummary",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryTestSummariesTestSummary>
            TestSummaries
        {
            get { return _testSummaries; }
            private set { _testSummaries = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestSummaries collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestSummariesSpecified
        {
            get { return (this.TestSummaries.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestResultTypeSummaryTransactionSummariesTransactionSummary> _transactionSummaries;

        [System.Xml.Serialization.XmlArrayAttribute("TransactionSummaries", Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TransactionSummary",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestResultTypeSummaryTransactionSummariesTransactionSummary> TransactionSummaries
        {
            get { return _transactionSummaries; }
            private set { _transactionSummaries = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TransactionSummaries collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionSummariesSpecified
        {
            get { return (this.TransactionSummaries.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeSummaryPerformanceCounterResults",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummaryPerformanceCounterResults
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestResultTypeSummaryPerformanceCounterResultsPerformanceCounterResult> _performanceCounterResult;

        [System.Xml.Serialization.XmlElementAttribute("PerformanceCounterResult", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestResultTypeSummaryPerformanceCounterResultsPerformanceCounterResult> PerformanceCounterResult
        {
            get { return _performanceCounterResult; }
            private set { _performanceCounterResult = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PerformanceCounterResult collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PerformanceCounterResultSpecified
        {
            get { return (this.PerformanceCounterResult.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestResultTypeSummaryPerformanceCounterResults" /> class.</para>
        /// </summary>
        public LoadTestResultTypeSummaryPerformanceCounterResults()
        {
            this._performanceCounterResult =
                new System.Collections.ObjectModel.Collection<
                    LoadTestResultTypeSummaryPerformanceCounterResultsPerformanceCounterResult>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestResultTypeSummaryPerformanceCounterResultsPerformanceCounterResult",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummaryPerformanceCounterResultsPerformanceCounterResult
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("machineName")]
        public string MachineName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("categoryName")]
        public string CategoryName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("instanceName")]
        public string InstanceName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("counterName")]
        public string CounterName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public double Value { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isOverallResultCounter = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("isOverallResultCounter")]
        public bool IsOverallResultCounter
        {
            get { return _isOverallResultCounter; }
            set { _isOverallResultCounter = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _higherIsBetter = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("higherIsBetter")]
        public bool HigherIsBetter
        {
            get { return _higherIsBetter; }
            set { _higherIsBetter = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeSummaryPageSummaries",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummaryPageSummaries
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryPageSummariesPageSummary>
            _pageSummary;

        [System.Xml.Serialization.XmlElementAttribute("PageSummary", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryPageSummariesPageSummary> PageSummary
        {
            get { return _pageSummary; }
            private set { _pageSummary = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PageSummary collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageSummarySpecified
        {
            get { return (this.PageSummary.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestResultTypeSummaryPageSummaries" /> class.</para>
        /// </summary>
        public LoadTestResultTypeSummaryPageSummaries()
        {
            this._pageSummary =
                new System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryPageSummariesPageSummary>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeSummaryPageSummariesPageSummary",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummaryPageSummariesPageSummary
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("scenarioName")]
        public string ScenarioName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testName")]
        public string TestName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("url")]
        public string Url { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("pageCount")]
        public int PageCount { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("responseTime")]
        public int ResponseTime { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeSummaryTestSummaries",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummaryTestSummaries
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryTestSummariesTestSummary>
            _testSummary;

        [System.Xml.Serialization.XmlElementAttribute("TestSummary", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryTestSummariesTestSummary> TestSummary
        {
            get { return _testSummary; }
            private set { _testSummary = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestSummary collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestSummarySpecified
        {
            get { return (this.TestSummary.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestResultTypeSummaryTestSummaries" /> class.</para>
        /// </summary>
        public LoadTestResultTypeSummaryTestSummaries()
        {
            this._testSummary =
                new System.Collections.ObjectModel.Collection<LoadTestResultTypeSummaryTestSummariesTestSummary>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeSummaryTestSummariesTestSummary",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummaryTestSummariesTestSummary
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("scenarioName")]
        public string ScenarioName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testName")]
        public string TestName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("totalTests")]
        public int TotalTests { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testsFailed")]
        public int TestsFailed { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("averageDuration")]
        public int AverageDuration { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeSummaryTransactionSummaries",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummaryTransactionSummaries
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestResultTypeSummaryTransactionSummariesTransactionSummary> _transactionSummary;

        [System.Xml.Serialization.XmlElementAttribute("TransactionSummary", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestResultTypeSummaryTransactionSummariesTransactionSummary> TransactionSummary
        {
            get { return _transactionSummary; }
            private set { _transactionSummary = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TransactionSummary collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionSummarySpecified
        {
            get { return (this.TransactionSummary.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestResultTypeSummaryTransactionSummaries" /> class.</para>
        /// </summary>
        public LoadTestResultTypeSummaryTransactionSummaries()
        {
            this._transactionSummary =
                new System.Collections.ObjectModel.Collection<
                    LoadTestResultTypeSummaryTransactionSummariesTransactionSummary>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultTypeSummaryTransactionSummariesTransactionSummary",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestResultTypeSummaryTransactionSummariesTransactionSummary
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("scenarioName")]
        public string ScenarioName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testName")]
        public string TestName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("transactionName")]
        public string TransactionName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("transactionCount")]
        public int TransactionCount { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("elapsedTime")]
        public string ElapsedTime { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("responseTime")]
        public string ResponseTime { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestRunStatusType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum LoadTestRunStatusType
    {
        Connecting,

        InitializingResultsCollection,

        NotStarted,

        Queued,

        Starting,

        Stopping,

        Stopped,

        WarmingUp,

        WritingResults,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestResultStoreType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum LoadTestResultStoreType
    {
        None,

        Database,

        XmlResultFile,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("LoadTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class LoadTestType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenarios> _scenarios;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Scenarios", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenarios> Scenarios
        {
            get { return _scenarios; }
            private set { _scenarios = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestType" /> class.</para>
        /// </summary>
        public LoadTestType()
        {
            this._scenarios = new System.Collections.ObjectModel.Collection<LoadTestTypeScenarios>();
            this._counterSets = new System.Collections.ObjectModel.Collection<LoadTestTypeCounterSets>();
            this._runConfigurations = new System.Collections.ObjectModel.Collection<LoadTestTypeRunConfigurations>();
            this._loadTestPlugins = new System.Collections.ObjectModel.Collection<LoadTestTypeLoadTestPlugins>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeCounterSets> _counterSets;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CounterSets", Order = 1)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeCounterSets> CounterSets
        {
            get { return _counterSets; }
            private set { _counterSets = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeRunConfigurations> _runConfigurations;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("RunConfigurations", Order = 2)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeRunConfigurations> RunConfigurations
        {
            get { return _runConfigurations; }
            private set { _runConfigurations = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeLoadTestPlugins> _loadTestPlugins;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("LoadTestPlugins", Order = 3)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeLoadTestPlugins> LoadTestPlugins
        {
            get { return _loadTestPlugins; }
            private set { _loadTestPlugins = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Description")]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Owner")]
        public string Owner { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("storage")]
        public string Storage { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Priority")]
        public int PriorityValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Priority property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PriorityValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Priority
        {
            get
            {
                if (this.PriorityValueSpecified)
                {
                    return this.PriorityValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PriorityValue = value.GetValueOrDefault();
                this.PriorityValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Enabled")]
        public bool EnabledValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Enabled property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool EnabledValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Enabled
        {
            get
            {
                if (this.EnabledValueSpecified)
                {
                    return this.EnabledValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EnabledValue = value.GetValueOrDefault();
                this.EnabledValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CssProjectStructure")]
        public string CssProjectStructure { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CssIteration")]
        public string CssIteration { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("DeploymentItemsEditable")]
        public string DeploymentItemsEditable { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("WorkItemIds")]
        public string WorkItemIds { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("TraceLevel")]
        public string TraceLevel { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CurrentRunConfig")]
        public string CurrentRunConfig { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenarios",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenarios
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenario> _scenario;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Scenario", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenario> Scenario
        {
            get { return _scenario; }
            private set { _scenario = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenarios" /> class.</para>
        /// </summary>
        public LoadTestTypeScenarios()
        {
            this._scenario = new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenario>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenario",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenario
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ThinkProfile", Order = 0)]
        public LoadTestTypeScenariosScenarioThinkProfile ThinkProfile { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("LoadProfile", Order = 1)]
        public LoadTestTypeScenariosScenarioLoadProfile LoadProfile { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioInitializeTestTestProfile>
            _initializeTest;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("InitializeTest", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TestProfile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioInitializeTestTestProfile>
            InitializeTest
        {
            get { return _initializeTest; }
            private set { _initializeTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenariosScenario" /> class.</para>
        /// </summary>
        public LoadTestTypeScenariosScenario()
        {
            this._initializeTest =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioInitializeTestTestProfile>();
            this._terminateTest =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTerminateTestTestProfile>();
            this._testMix =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTestMixTestProfile>();
            this._browserMix =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioBrowserMixBrowserProfile>();
            this._networkMix =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioNetworkMixNetworkProfile>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTerminateTestTestProfile>
            _terminateTest;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("TerminateTest", Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TestProfile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTerminateTestTestProfile>
            TerminateTest
        {
            get { return _terminateTest; }
            private set { _terminateTest = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTestMixTestProfile> _testMix;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("TestMix", Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TestProfile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTestMixTestProfile> TestMix
        {
            get { return _testMix; }
            private set { _testMix = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioBrowserMixBrowserProfile>
            _browserMix;

        [System.Xml.Serialization.XmlArrayAttribute("BrowserMix", Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BrowserProfile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioBrowserMixBrowserProfile>
            BrowserMix
        {
            get { return _browserMix; }
            private set { _browserMix = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the BrowserMix collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrowserMixSpecified
        {
            get { return (this.BrowserMix.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioNetworkMixNetworkProfile>
            _networkMix;

        [System.Xml.Serialization.XmlArrayAttribute("NetworkMix", Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("NetworkProfile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioNetworkMixNetworkProfile>
            NetworkMix
        {
            get { return _networkMix; }
            private set { _networkMix = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the NetworkMix collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NetworkMixSpecified
        {
            get { return (this.NetworkMix.Count != 0); }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("AllowedAgents")]
        public string AllowedAgents { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("IPSwitching")]
        public bool IpSwitchingValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IpSwitching property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IpSwitchingValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IpSwitching
        {
            get
            {
                if (this.IpSwitchingValueSpecified)
                {
                    return this.IpSwitchingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IpSwitchingValue = value.GetValueOrDefault();
                this.IpSwitchingValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("DisableDuringWarmup")]
        public bool DisableDuringWarmupValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DisableDuringWarmup property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DisableDuringWarmupValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> DisableDuringWarmup
        {
            get
            {
                if (this.DisableDuringWarmupValueSpecified)
                {
                    return this.DisableDuringWarmupValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DisableDuringWarmupValue = value.GetValueOrDefault();
                this.DisableDuringWarmupValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("DelayStartTime")]
        public int DelayStartTimeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DelayStartTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DelayStartTimeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> DelayStartTime
        {
            get
            {
                if (this.DelayStartTimeValueSpecified)
                {
                    return this.DelayStartTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DelayStartTimeValue = value.GetValueOrDefault();
                this.DelayStartTimeValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("DelayBetweenIterations")]
        public int DelayBetweenIterationsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DelayBetweenIterations property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DelayBetweenIterationsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> DelayBetweenIterations
        {
            get
            {
                if (this.DelayBetweenIterationsValueSpecified)
                {
                    return this.DelayBetweenIterationsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DelayBetweenIterationsValue = value.GetValueOrDefault();
                this.DelayBetweenIterationsValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxTestIterations")]
        public int MaxTestIterationsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxTestIterations property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxTestIterationsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxTestIterations
        {
            get
            {
                if (this.MaxTestIterationsValueSpecified)
                {
                    return this.MaxTestIterationsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxTestIterationsValue = value.GetValueOrDefault();
                this.MaxTestIterationsValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("PercentNewUsers")]
        public int PercentNewUsersValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PercentNewUsers property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PercentNewUsersValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> PercentNewUsers
        {
            get
            {
                if (this.PercentNewUsersValueSpecified)
                {
                    return this.PercentNewUsersValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PercentNewUsersValue = value.GetValueOrDefault();
                this.PercentNewUsersValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("TestMixType")]
        public TestMixType TestMixTypeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TestMixType property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TestMixTypeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<TestMixType> TestMixType
        {
            get
            {
                if (this.TestMixTypeValueSpecified)
                {
                    return this.TestMixTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TestMixTypeValue = value.GetValueOrDefault();
                this.TestMixTypeValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("ApplyDistributionToPacingDelay")]
        public bool ApplyDistributionToPacingDelayValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ApplyDistributionToPacingDelay property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ApplyDistributionToPacingDelayValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> ApplyDistributionToPacingDelay
        {
            get
            {
                if (this.ApplyDistributionToPacingDelayValueSpecified)
                {
                    return this.ApplyDistributionToPacingDelayValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ApplyDistributionToPacingDelayValue = value.GetValueOrDefault();
                this.ApplyDistributionToPacingDelayValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioThinkProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioThinkProfile
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Pattern")]
        public string Pattern { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Value")]
        public float Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioLoadProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioLoadProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Pattern")]
        public string Pattern { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("InitialUsers")]
        public int InitialUsers { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxUsers")]
        public int MaxUsersValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxUsers property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxUsersValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxUsers
        {
            get
            {
                if (this.MaxUsersValueSpecified)
                {
                    return this.MaxUsersValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxUsersValue = value.GetValueOrDefault();
                this.MaxUsersValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("StepUsers")]
        public int StepUsersValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StepUsers property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool StepUsersValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> StepUsers
        {
            get
            {
                if (this.StepUsersValueSpecified)
                {
                    return this.StepUsersValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StepUsersValue = value.GetValueOrDefault();
                this.StepUsersValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("StepDuration")]
        public int StepDurationValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StepDuration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool StepDurationValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> StepDuration
        {
            get
            {
                if (this.StepDurationValueSpecified)
                {
                    return this.StepDurationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StepDurationValue = value.GetValueOrDefault();
                this.StepDurationValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("StepRampTime")]
        public int StepRampTimeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StepRampTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool StepRampTimeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> StepRampTime
        {
            get
            {
                if (this.StepRampTimeValueSpecified)
                {
                    return this.StepRampTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StepRampTimeValue = value.GetValueOrDefault();
                this.StepRampTimeValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CounterPath")]
        public string CounterPath { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("MachineName")]
        public string MachineName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CategoryName")]
        public string CategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CounterName")]
        public string CounterName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("InstanceName")]
        public string InstanceName { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MinUserCount")]
        public int MinUserCountValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MinUserCount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MinUserCountValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MinUserCount
        {
            get
            {
                if (this.MinUserCountValueSpecified)
                {
                    return this.MinUserCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MinUserCountValue = value.GetValueOrDefault();
                this.MinUserCountValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxUserCount")]
        public int MaxUserCountValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxUserCount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxUserCountValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxUserCount
        {
            get
            {
                if (this.MaxUserCountValueSpecified)
                {
                    return this.MaxUserCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxUserCountValue = value.GetValueOrDefault();
                this.MaxUserCountValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxUserCountIncrease")]
        public int MaxUserCountIncreaseValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxUserCountIncrease property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxUserCountIncreaseValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxUserCountIncrease
        {
            get
            {
                if (this.MaxUserCountIncreaseValueSpecified)
                {
                    return this.MaxUserCountIncreaseValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxUserCountIncreaseValue = value.GetValueOrDefault();
                this.MaxUserCountIncreaseValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxUserCountDecrease")]
        public int MaxUserCountDecreaseValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxUserCountDecrease property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxUserCountDecreaseValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxUserCountDecrease
        {
            get
            {
                if (this.MaxUserCountDecreaseValueSpecified)
                {
                    return this.MaxUserCountDecreaseValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxUserCountDecreaseValue = value.GetValueOrDefault();
                this.MaxUserCountDecreaseValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MinTargetValue")]
        public double MinTargetValueValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MinTargetValue property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MinTargetValueValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> MinTargetValue
        {
            get
            {
                if (this.MinTargetValueValueSpecified)
                {
                    return this.MinTargetValueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MinTargetValueValue = value.GetValueOrDefault();
                this.MinTargetValueValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxTargetValue")]
        public double MaxTargetValueValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxTargetValue property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxTargetValueValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<double> MaxTargetValue
        {
            get
            {
                if (this.MaxTargetValueValueSpecified)
                {
                    return this.MaxTargetValueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxTargetValueValue = value.GetValueOrDefault();
                this.MaxTargetValueValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("HigherValuesBetter")]
        public bool HigherValuesBetterValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HigherValuesBetter property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool HigherValuesBetterValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> HigherValuesBetter
        {
            get
            {
                if (this.HigherValuesBetterValueSpecified)
                {
                    return this.HigherValuesBetterValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HigherValuesBetterValue = value.GetValueOrDefault();
                this.HigherValuesBetterValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("StopAdjustingAtGoal")]
        public bool StopAdjustingAtGoalValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StopAdjustingAtGoal property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool StopAdjustingAtGoalValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> StopAdjustingAtGoal
        {
            get
            {
                if (this.StopAdjustingAtGoalValueSpecified)
                {
                    return this.StopAdjustingAtGoalValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StopAdjustingAtGoalValue = value.GetValueOrDefault();
                this.StopAdjustingAtGoalValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioInitializeTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioInitializeTest
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioInitializeTestTestProfile>
            _testProfile;

        [System.Xml.Serialization.XmlElementAttribute("TestProfile", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioInitializeTestTestProfile>
            TestProfile
        {
            get { return _testProfile; }
            private set { _testProfile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestProfile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestProfileSpecified
        {
            get { return (this.TestProfile.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenariosScenarioInitializeTest" /> class.</para>
        /// </summary>
        public LoadTestTypeScenariosScenarioInitializeTest()
        {
            this._testProfile =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioInitializeTestTestProfile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioInitializeTestTestProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioInitializeTestTestProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Path")]
        public string Path { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Percentage")]
        public float Percentage { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Type")]
        public string Type { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioTerminateTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioTerminateTest
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTerminateTestTestProfile>
            _testProfile;

        [System.Xml.Serialization.XmlElementAttribute("TestProfile", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTerminateTestTestProfile>
            TestProfile
        {
            get { return _testProfile; }
            private set { _testProfile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestProfile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestProfileSpecified
        {
            get { return (this.TestProfile.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenariosScenarioTerminateTest" /> class.</para>
        /// </summary>
        public LoadTestTypeScenariosScenarioTerminateTest()
        {
            this._testProfile =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTerminateTestTestProfile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioTerminateTestTestProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioTerminateTestTestProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Path")]
        public string Path { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Percentage")]
        public float Percentage { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Type")]
        public string Type { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioTestMix",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioTestMix
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTestMixTestProfile> _testProfile;

        [System.Xml.Serialization.XmlElementAttribute("TestProfile", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTestMixTestProfile> TestProfile
        {
            get { return _testProfile; }
            private set { _testProfile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestProfile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestProfileSpecified
        {
            get { return (this.TestProfile.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenariosScenarioTestMix" /> class.</para>
        /// </summary>
        public LoadTestTypeScenariosScenarioTestMix()
        {
            this._testProfile =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioTestMixTestProfile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioTestMixTestProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioTestMixTestProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Path")]
        public string Path { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Percentage")]
        public float Percentage { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Type")]
        public string Type { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioBrowserMix",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioBrowserMix
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioBrowserMixBrowserProfile>
            _browserProfile;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("BrowserProfile", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioBrowserMixBrowserProfile>
            BrowserProfile
        {
            get { return _browserProfile; }
            private set { _browserProfile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenariosScenarioBrowserMix" /> class.</para>
        /// </summary>
        public LoadTestTypeScenariosScenarioBrowserMix()
        {
            this._browserProfile =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioBrowserMixBrowserProfile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioBrowserMixBrowserProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioBrowserMixBrowserProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Browser", Order = 0)]
        public LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowser Browser { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Percentage")]
        public float Percentage { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowser",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowser
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeadersHeader> _headers;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("Headers", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Header",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeadersHeader> Headers
        {
            get { return _headers; }
            private set { _headers = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowser" /> class.</para>
        /// </summary>
        public LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowser()
        {
            this._headers =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeadersHeader>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxConnections")]
        public int MaxConnectionsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxConnections property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxConnectionsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxConnections
        {
            get
            {
                if (this.MaxConnectionsValueSpecified)
                {
                    return this.MaxConnectionsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxConnectionsValue = value.GetValueOrDefault();
                this.MaxConnectionsValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeaders",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeaders
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeadersHeader> _header;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Header", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeadersHeader> Header
        {
            get { return _header; }
            private set { _header = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeaders" /> class.</para>
        /// </summary>
        public LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeaders()
        {
            this._header =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeadersHeader>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeadersHeader",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioBrowserMixBrowserProfileBrowserHeadersHeader
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioNetworkMix",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioNetworkMix
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioNetworkMixNetworkProfile>
            _networkProfile;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("NetworkProfile", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioNetworkMixNetworkProfile>
            NetworkProfile
        {
            get { return _networkProfile; }
            private set { _networkProfile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeScenariosScenarioNetworkMix" /> class.</para>
        /// </summary>
        public LoadTestTypeScenariosScenarioNetworkMix()
        {
            this._networkProfile =
                new System.Collections.ObjectModel.Collection<LoadTestTypeScenariosScenarioNetworkMixNetworkProfile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeScenariosScenarioNetworkMixNetworkProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeScenariosScenarioNetworkMixNetworkProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Network", Order = 0)]
        public NetworkType Network { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Percentage")]
        public float Percentage { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestMixType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum TestMixType
    {
        Sequential,

        PercentageOfTestsStarted,

        PercentageOfUsersRunning,

        UserPacing,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeCounterSets",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSets
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeCounterSetsCounterSet> _counterSet;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CounterSet", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeCounterSetsCounterSet> CounterSet
        {
            get { return _counterSet; }
            private set { _counterSet = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSets" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSets()
        {
            this._counterSet = new System.Collections.ObjectModel.Collection<LoadTestTypeCounterSetsCounterSet>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeCounterSetsCounterSet",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSet
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory> _counterCategories;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("CounterCategories", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CounterCategory",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory> CounterCategories
        {
            get { return _counterCategories; }
            private set { _counterCategories = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSet" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSetsCounterSet()
        {
            this._counterCategories =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory>();
            this._defaultCountersForAutomaticGraphs =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphsDefaultCounter>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphsDefaultCounter>
            _defaultCountersForAutomaticGraphs;

        [System.Xml.Serialization.XmlArrayAttribute("DefaultCountersForAutomaticGraphs", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DefaultCounter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphsDefaultCounter>
            DefaultCountersForAutomaticGraphs
        {
            get { return _defaultCountersForAutomaticGraphs; }
            private set { _defaultCountersForAutomaticGraphs = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DefaultCountersForAutomaticGraphs collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultCountersForAutomaticGraphsSpecified
        {
            get { return (this.DefaultCountersForAutomaticGraphs.Count != 0); }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CounterSetType")]
        public string CounterSetType { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("LocId")]
        public string LocId { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeCounterSetsCounterSetCounterCategories",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetCounterCategories
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory> _counterCategory;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CounterCategory", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory> CounterCategory
        {
            get { return _counterCategory; }
            private set { _counterCategory = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetCounterCategories" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSetsCounterSetCounterCategories()
        {
            this._counterCategory =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter> _counters;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("Counters", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Counter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter> Counters
        {
            get { return _counters; }
            private set { _counters = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategory()
        {
            this._counters =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter>();
            this._instances =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstancesInstance>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstancesInstance> _instances;

        [System.Xml.Serialization.XmlArrayAttribute("Instances", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Instance",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstancesInstance> Instances
        {
            get { return _instances; }
            private set { _instances = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Instances collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstancesSpecified
        {
            get { return (this.Instances.Count != 0); }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCounters",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCounters
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter> _counter;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Counter", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter> Counter
        {
            get { return _counter; }
            private set { _counter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCounters" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCounters()
        {
            this._counter =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule>
            _thresholdRules;

        [System.Xml.Serialization.XmlArrayAttribute("ThresholdRules", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ThresholdRule",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule>
            ThresholdRules
        {
            get { return _thresholdRules; }
            private set { _thresholdRules = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ThresholdRules collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThresholdRulesSpecified
        {
            get { return (this.ThresholdRules.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounter()
        {
            this._thresholdRules =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Range")]
        public int RangeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Range property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RangeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Range
        {
            get
            {
                if (this.RangeValueSpecified)
                {
                    return this.RangeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RangeValue = value.GetValueOrDefault();
                this.RangeValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("RangeGroup")]
        public string RangeGroup { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _higherIsBetter = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("HigherIsBetter")]
        public bool HigherIsBetter
        {
            get { return _higherIsBetter; }
            set { _higherIsBetter = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterT" +
        "hresholdRules", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRules
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule>
            _thresholdRule;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ThresholdRule", Order = 0)]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule>
            ThresholdRule
        {
            get { return _thresholdRule; }
            private set { _thresholdRule = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRules" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRules()
        {
            this._thresholdRule =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterT" +
        "hresholdRulesThresholdRule", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010",
        AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParametersRuleParameter>
            _ruleParameters;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("RuleParameters", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RuleParameter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParametersRuleParameter>
            RuleParameters
        {
            get { return _ruleParameters; }
            private set { _ruleParameters = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule" /> class.</para>
        /// </summary>
        public
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRule()
        {
            this._ruleParameters =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParametersRuleParameter>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Classname")]
        public string Classname { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterT" +
        "hresholdRulesThresholdRuleRuleParameters",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParameters
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParametersRuleParameter>
            _ruleParameter;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("RuleParameter", Order = 0)]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParametersRuleParameter>
            RuleParameter
        {
            get { return _ruleParameter; }
            private set { _ruleParameter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParameters" /> class.</para>
        /// </summary>
        public
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParameters()
        {
            this._ruleParameter =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParametersRuleParameter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterT" +
        "hresholdRulesThresholdRuleRuleParametersRuleParameter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryCountersCounterThresholdRulesThresholdRuleRuleParametersRuleParameter
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstances",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstances
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstancesInstance> _instance;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Instance", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstancesInstance> Instance
        {
            get { return _instance; }
            private set { _instance = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstances" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstances()
        {
            this._instance =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstancesInstance>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstancesInstanc" +
        "e", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetCounterCategoriesCounterCategoryInstancesInstance
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphs",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphs
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphsDefaultCounter> _defaultCounter;

        [System.Xml.Serialization.XmlElementAttribute("DefaultCounter", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphsDefaultCounter> DefaultCounter
        {
            get { return _defaultCounter; }
            private set { _defaultCounter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DefaultCounter collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultCounterSpecified
        {
            get { return (this.DefaultCounter.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphs" /> class.</para>
        /// </summary>
        public LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphs()
        {
            this._defaultCounter =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphsDefaultCounter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphsDefaultCounter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeCounterSetsCounterSetDefaultCountersForAutomaticGraphsDefaultCounter
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CategoryName")]
        public string CategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CounterName")]
        public string CounterName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("InstanceName")]
        public string InstanceName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("GraphName")]
        public string GraphName { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Range")]
        public int RangeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Range property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RangeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Range
        {
            get
            {
                if (this.RangeValueSpecified)
                {
                    return this.RangeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RangeValue = value.GetValueOrDefault();
                this.RangeValueSpecified = value.HasValue;
            }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("RunType")]
        public string RunType { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeRunConfigurations",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurations
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeRunConfigurationsRunConfiguration>
            _runConfiguration;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("RunConfiguration", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeRunConfigurationsRunConfiguration> RunConfiguration
        {
            get { return _runConfiguration; }
            private set { _runConfiguration = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurations" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurations()
        {
            this._runConfiguration =
                new System.Collections.ObjectModel.Collection<LoadTestTypeRunConfigurationsRunConfiguration>();
        }
    }

    /// <summary>
    /// <para>TODO: leave up to NC: this type is a duplicate of LoadTestRunCOnfigurationType. The differentces are results of WebTestSuiteSerializer (upper case for attributes and enums are strings vs ints)</para>
    /// </summary>
    [System.ComponentModel.DescriptionAttribute(
        "TODO: leave up to NC: this type is a duplicate of LoadTestRunCOnfigurationType. T" +
        "he differentces are results of WebTestSuiteSerializer (upper case for attributes" +
        " and enums are strings vs ints)")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeRunConfigurationsRunConfiguration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfiguration
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CounterSetMappings", Order = 0)]
        public LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappings CounterSetMappings { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent> _applications;

        [System.Xml.Serialization.XmlArrayAttribute("Applications", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AutComponent",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent> Applications
        {
            get { return _applications; }
            private set { _applications = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Applications collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationsSpecified
        {
            get { return (this.Applications.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfiguration" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfiguration()
        {
            this._applications =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent>();
            this._loadGeneratorLocations =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocationsGeoLocation>();
            this._contextParameters =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationContextParametersContextParameter>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocationsGeoLocation> _loadGeneratorLocations;

        [System.Xml.Serialization.XmlArrayAttribute("LoadGeneratorLocations", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("GeoLocation",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocationsGeoLocation> LoadGeneratorLocations
        {
            get { return _loadGeneratorLocations; }
            private set { _loadGeneratorLocations = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LoadGeneratorLocations collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LoadGeneratorLocationsSpecified
        {
            get { return (this.LoadGeneratorLocations.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationContextParametersContextParameter> _contextParameters;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("ContextParameters", Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ContextParameter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationContextParametersContextParameter> ContextParameters
        {
            get { return _contextParameters; }
            private set { _contextParameters = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Description")]
        public string Description { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ResultsStoreType")]
        public string ResultsStoreType { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("TimingDetailsStorage")]
        public string TimingDetailsStorage { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxErrorDetails")]
        public int MaxErrorDetails { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxRequestUrlsReported")]
        public int MaxRequestUrlsReported { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxErrorsPerType")]
        public int MaxErrorsPerTypeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxErrorsPerType property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxErrorsPerTypeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxErrorsPerType
        {
            get
            {
                if (this.MaxErrorsPerTypeValueSpecified)
                {
                    return this.MaxErrorsPerTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxErrorsPerTypeValue = value.GetValueOrDefault();
                this.MaxErrorsPerTypeValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("MaxThresholdViolations")]
        public int MaxThresholdViolationsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxThresholdViolations property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxThresholdViolationsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> MaxThresholdViolations
        {
            get
            {
                if (this.MaxThresholdViolationsValueSpecified)
                {
                    return this.MaxThresholdViolationsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxThresholdViolationsValue = value.GetValueOrDefault();
                this.MaxThresholdViolationsValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("UseTestIterations")]
        public bool UseTestIterationsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UseTestIterations property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UseTestIterationsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> UseTestIterations
        {
            get
            {
                if (this.UseTestIterationsValueSpecified)
                {
                    return this.UseTestIterationsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UseTestIterationsValue = value.GetValueOrDefault();
                this.UseTestIterationsValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("RunDuration")]
        public int RunDuration { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("WarmupTime")]
        public int WarmupTime { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("CoolDownTime")]
        public int CoolDownTimeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CoolDownTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CoolDownTimeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> CoolDownTime
        {
            get
            {
                if (this.CoolDownTimeValueSpecified)
                {
                    return this.CoolDownTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CoolDownTimeValue = value.GetValueOrDefault();
                this.CoolDownTimeValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("TestIterations")]
        public int TestIterationsValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TestIterations property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TestIterationsValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> TestIterations
        {
            get
            {
                if (this.TestIterationsValueSpecified)
                {
                    return this.TestIterationsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TestIterationsValue = value.GetValueOrDefault();
                this.TestIterationsValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("WebTestConnectionModel")]
        public WebTestConnectionModel WebTestConnectionModel { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("WebTestConnectionPoolSize")]
        public int WebTestConnectionPoolSize { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("SampleRate")]
        public int SampleRate { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ValidationLevel")]
        public LoadTestValidationLevel ValidationLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("SqlTracingConnectString")]
        public string SqlTracingConnectString { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("SqlTracingConnectStringDisplayValue")]
        public string SqlTracingConnectStringDisplayValue { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("SqlTracingDirectory")]
        public string SqlTracingDirectory { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("SqlTracingEnabled")]
        public bool SqlTracingEnabledValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SqlTracingEnabled property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SqlTracingEnabledValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> SqlTracingEnabled
        {
            get
            {
                if (this.SqlTracingEnabledValueSpecified)
                {
                    return this.SqlTracingEnabledValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SqlTracingEnabledValue = value.GetValueOrDefault();
                this.SqlTracingEnabledValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("SqlTracingFileCount")]
        public int SqlTracingFileCountValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SqlTracingFileCount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SqlTracingFileCountValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> SqlTracingFileCount
        {
            get
            {
                if (this.SqlTracingFileCountValueSpecified)
                {
                    return this.SqlTracingFileCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SqlTracingFileCountValue = value.GetValueOrDefault();
                this.SqlTracingFileCountValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("SqlTracingRolloverEnabled")]
        public bool SqlTracingRolloverEnabledValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SqlTracingRolloverEnabled property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SqlTracingRolloverEnabledValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> SqlTracingRolloverEnabled
        {
            get
            {
                if (this.SqlTracingRolloverEnabledValueSpecified)
                {
                    return this.SqlTracingRolloverEnabledValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SqlTracingRolloverEnabledValue = value.GetValueOrDefault();
                this.SqlTracingRolloverEnabledValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("SqlTracingMinimumDuration")]
        public int SqlTracingMinimumDurationValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SqlTracingMinimumDuration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SqlTracingMinimumDurationValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> SqlTracingMinimumDuration
        {
            get
            {
                if (this.SqlTracingMinimumDurationValueSpecified)
                {
                    return this.SqlTracingMinimumDurationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SqlTracingMinimumDurationValue = value.GetValueOrDefault();
                this.SqlTracingMinimumDurationValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("RunUnitTestsInAppDomain")]
        public bool RunUnitTestsInAppDomainValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RunUnitTestsInAppDomain property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RunUnitTestsInAppDomainValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> RunUnitTestsInAppDomain
        {
            get
            {
                if (this.RunUnitTestsInAppDomainValueSpecified)
                {
                    return this.RunUnitTestsInAppDomainValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RunUnitTestsInAppDomainValue = value.GetValueOrDefault();
                this.RunUnitTestsInAppDomainValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("SaveTestLogsOnError")]
        public bool SaveTestLogsOnErrorValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SaveTestLogsOnError property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SaveTestLogsOnErrorValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> SaveTestLogsOnError
        {
            get
            {
                if (this.SaveTestLogsOnErrorValueSpecified)
                {
                    return this.SaveTestLogsOnErrorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SaveTestLogsOnErrorValue = value.GetValueOrDefault();
                this.SaveTestLogsOnErrorValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("SaveTestLogsFrequency")]
        public int SaveTestLogsFrequencyValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SaveTestLogsFrequency property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SaveTestLogsFrequencyValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> SaveTestLogsFrequency
        {
            get
            {
                if (this.SaveTestLogsFrequencyValueSpecified)
                {
                    return this.SaveTestLogsFrequencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SaveTestLogsFrequencyValue = value.GetValueOrDefault();
                this.SaveTestLogsFrequencyValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("CoreCount")]
        public int CoreCountValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CoreCount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CoreCountValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> CoreCount
        {
            get
            {
                if (this.CoreCountValueSpecified)
                {
                    return this.CoreCountValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CoreCountValue = value.GetValueOrDefault();
                this.CoreCountValueSpecified = value.HasValue;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _useMultipleIPs = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("UseMultipleIPs")]
        public bool UseMultipleIPs
        {
            get { return _useMultipleIPs; }
            set { _useMultipleIPs = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private LoadTestAgentConfiguration _testAgentConfiguration =
            Schemas.VisualStudio.TeamTest.LoadTestAgentConfiguration.Default;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.LoadTestAgentConfiguration.Default)]
        [System.Xml.Serialization.XmlAttributeAttribute("TestAgentConfiguration")]
        public LoadTestAgentConfiguration TestAgentConfiguration
        {
            get { return _testAgentConfiguration; }
            set { _testAgentConfiguration = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private AgentDiagnosticsTraceLevel _agentDiagnosticsLevel =
            Schemas.VisualStudio.TeamTest.AgentDiagnosticsTraceLevel.Warning;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.AgentDiagnosticsTraceLevel.Warning)]
        [System.Xml.Serialization.XmlAttributeAttribute("AgentDiagnosticsLevel")]
        public AgentDiagnosticsTraceLevel AgentDiagnosticsLevel
        {
            get { return _agentDiagnosticsLevel; }
            set { _agentDiagnosticsLevel = value; }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("ResourcesRetentionTimeInMinutes")]
        public int ResourcesRetentionTimeInMinutesValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ResourcesRetentionTimeInMinutes property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ResourcesRetentionTimeInMinutesValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> ResourcesRetentionTimeInMinutes
        {
            get
            {
                if (this.ResourcesRetentionTimeInMinutesValueSpecified)
                {
                    return this.ResourcesRetentionTimeInMinutesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ResourcesRetentionTimeInMinutesValue = value.GetValueOrDefault();
                this.ResourcesRetentionTimeInMinutesValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappings",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappings
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMapping> _counterSetMapping;

        [System.Xml.Serialization.XmlElementAttribute("CounterSetMapping", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMapping> CounterSetMapping
        {
            get { return _counterSetMapping; }
            private set { _counterSetMapping = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CounterSetMapping collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CounterSetMappingSpecified
        {
            get { return (this.CounterSetMapping.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappings" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappings()
        {
            this._counterSetMapping =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMapping>();
            this._applicationsUnderTestSettings =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettings>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettings>
            _applicationsUnderTestSettings;

        [System.Xml.Serialization.XmlElementAttribute("ApplicationsUnderTestSettings", Order = 1)]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettings>
            ApplicationsUnderTestSettings
        {
            get { return _applicationsUnderTestSettings; }
            private set { _applicationsUnderTestSettings = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ApplicationsUnderTestSettings collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationsUnderTestSettingsSpecified
        {
            get { return (this.ApplicationsUnderTestSettings.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMapping",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMapping
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference>
            _counterSetReferences;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("CounterSetReferences", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CounterSetReference",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference>
            CounterSetReferences
        {
            get { return _counterSetReferences; }
            private set { _counterSetReferences = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMapping" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMapping()
        {
            this._counterSetReferences =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ComputerName")]
        public string ComputerName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingC" +
        "ounterSetReferences", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010",
        AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferences
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference>
            _counterSetReference;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("CounterSetReference", Order = 0)]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference>
            CounterSetReference
        {
            get { return _counterSetReference; }
            private set { _counterSetReference = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferences" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferences()
        {
            this._counterSetReference =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingC" +
        "ounterSetReferencesCounterSetReference", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010",
        AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsCounterSetMappingCounterSetReferencesCounterSetReference
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("CounterSetName")]
        public string CounterSetName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderT" +
        "estSettings", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettings
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroup>
            _applicationUnderTestGroup;

        [System.Xml.Serialization.XmlElementAttribute("ApplicationUnderTestGroup", Order = 0)]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroup>
            ApplicationUnderTestGroup
        {
            get { return _applicationUnderTestGroup; }
            private set { _applicationUnderTestGroup = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ApplicationUnderTestGroup collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationUnderTestGroupSpecified
        {
            get { return (this.ApplicationUnderTestGroup.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettings" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettings()
        {
            this._applicationUnderTestGroup =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroup>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderT" +
        "estSettingsApplicationUnderTestGroup", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010",
        AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroup
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest>
            _applicationsUnderTest;

        [System.Xml.Serialization.XmlArrayAttribute("ApplicationsUnderTest", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ApplicationUnderTest",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest>
            ApplicationsUnderTest
        {
            get { return _applicationsUnderTest; }
            private set { _applicationsUnderTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ApplicationsUnderTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationsUnderTestSpecified
        {
            get { return (this.ApplicationsUnderTest.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroup" /> class.</para>
        /// </summary>
        public
            LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroup()
        {
            this._applicationsUnderTest =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Type")]
        public string Type { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderT" +
        "estSettingsApplicationUnderTestGroupApplicationsUnderTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTest
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest>
            _applicationUnderTest;

        [System.Xml.Serialization.XmlElementAttribute("ApplicationUnderTest", Order = 0)]
        public System.Collections.ObjectModel.Collection<
                LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest>
            ApplicationUnderTest
        {
            get { return _applicationUnderTest; }
            private set { _applicationUnderTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ApplicationUnderTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationUnderTestSpecified
        {
            get { return (this.ApplicationUnderTest.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTest" /> class.</para>
        /// </summary>
        public
            LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTest()
        {
            this._applicationUnderTest =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderT" +
        "estSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class
        LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NameValuePropertyType> _properties;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("Properties", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Property",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<NameValuePropertyType> Properties
        {
            get { return _properties; }
            private set { _properties = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest" /> class.</para>
        /// </summary>
        public
            LoadTestTypeRunConfigurationsRunConfigurationCounterSetMappingsApplicationsUnderTestSettingsApplicationUnderTestGroupApplicationsUnderTestApplicationUnderTest()
        {
            this._properties = new System.Collections.ObjectModel.Collection<NameValuePropertyType>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Path")]
        public string Path { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeRunConfigurationsRunConfigurationApplications",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationApplications
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent> _autComponent;

        [System.Xml.Serialization.XmlElementAttribute("AutComponent", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent> AutComponent
        {
            get { return _autComponent; }
            private set { _autComponent = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AutComponent collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutComponentSpecified
        {
            get { return (this.AutComponent.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationApplications" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationApplications()
        {
            this._autComponent =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCountersAutCounter> _autCounters;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("AutCounters", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AutCounter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCountersAutCounter> AutCounters
        {
            get { return _autCounters; }
            private set { _autCounters = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponent()
        {
            this._autCounters =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCountersAutCounter>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Description")]
        public string Description { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Type")]
        public string Type { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Separator")]
        public string Separator { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Version")]
        public string Version { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCounters",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCounters
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCountersAutCounter> _autCounter;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("AutCounter", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCountersAutCounter> AutCounter
        {
            get { return _autCounter; }
            private set { _autCounter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCounters" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCounters()
        {
            this._autCounter =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCountersAutCounter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCountersA" +
        "utCounter", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationApplicationsAutComponentAutCountersAutCounter
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Description")]
        public string Description { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Path")]
        public string Path { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocations",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocations
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocationsGeoLocation> _geoLocation;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("GeoLocation", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocationsGeoLocation> GeoLocation
        {
            get { return _geoLocation; }
            private set { _geoLocation = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocations" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocations()
        {
            this._geoLocation =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocationsGeoLocation>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocationsGeoLocation",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationLoadGeneratorLocationsGeoLocation
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Location")]
        public string Location { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Percentange")]
        public int Percentange { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeRunConfigurationsRunConfigurationContextParameters",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationContextParameters
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationContextParametersContextParameter> _contextParameter;

        [System.Xml.Serialization.XmlElementAttribute("ContextParameter", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeRunConfigurationsRunConfigurationContextParametersContextParameter> ContextParameter
        {
            get { return _contextParameter; }
            private set { _contextParameter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ContextParameter collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContextParameterSpecified
        {
            get { return (this.ContextParameter.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeRunConfigurationsRunConfigurationContextParameters" /> class.</para>
        /// </summary>
        public LoadTestTypeRunConfigurationsRunConfigurationContextParameters()
        {
            this._contextParameter =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeRunConfigurationsRunConfigurationContextParametersContextParameter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "LoadTestTypeRunConfigurationsRunConfigurationContextParametersContextParameter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeRunConfigurationsRunConfigurationContextParametersContextParameter
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestConnectionModel",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum WebTestConnectionModel
    {
        ConnectionPerUser,

        ConnectionPool,

        ConnectionPerTestIteration,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestValidationLevel",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum LoadTestValidationLevel
    {
        Low,

        Medium,

        High,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestAgentConfiguration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum LoadTestAgentConfiguration
    {
        Default,

        [System.Xml.Serialization.XmlEnumAttribute("Trusted IP")]
        TrustedIp,

        [System.Xml.Serialization.XmlEnumAttribute("Private Cloud")]
        PrivateCloud,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AgentDiagnosticsTraceLevel",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum AgentDiagnosticsTraceLevel
    {
        None,

        Error,

        Warning,

        Information,

        Verbose,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeLoadTestPlugins",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeLoadTestPlugins
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestTypeLoadTestPluginsLoadTestPlugin> _loadTestPlugin;

        [System.Xml.Serialization.XmlElementAttribute("LoadTestPlugin", Order = 0)]
        public System.Collections.ObjectModel.Collection<LoadTestTypeLoadTestPluginsLoadTestPlugin> LoadTestPlugin
        {
            get { return _loadTestPlugin; }
            private set { _loadTestPlugin = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LoadTestPlugin collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LoadTestPluginSpecified
        {
            get { return (this.LoadTestPlugin.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeLoadTestPlugins" /> class.</para>
        /// </summary>
        public LoadTestTypeLoadTestPlugins()
        {
            this._loadTestPlugin =
                new System.Collections.ObjectModel.Collection<LoadTestTypeLoadTestPluginsLoadTestPlugin>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeLoadTestPluginsLoadTestPlugin",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeLoadTestPluginsLoadTestPlugin
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeLoadTestPluginsLoadTestPluginRuleParametersRuleParameter> _ruleParameters;

        [System.Xml.Serialization.XmlArrayAttribute("RuleParameters", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RuleParameter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeLoadTestPluginsLoadTestPluginRuleParametersRuleParameter> RuleParameters
        {
            get { return _ruleParameters; }
            private set { _ruleParameters = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RuleParameters collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RuleParametersSpecified
        {
            get { return (this.RuleParameters.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeLoadTestPluginsLoadTestPlugin" /> class.</para>
        /// </summary>
        public LoadTestTypeLoadTestPluginsLoadTestPlugin()
        {
            this._ruleParameters =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeLoadTestPluginsLoadTestPluginRuleParametersRuleParameter>();
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Classname")]
        public string Classname { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("DisplayName")]
        public string DisplayName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Description")]
        public string Description { get; set; }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeLoadTestPluginsLoadTestPluginRuleParameters",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeLoadTestPluginsLoadTestPluginRuleParameters
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            LoadTestTypeLoadTestPluginsLoadTestPluginRuleParametersRuleParameter> _ruleParameter;

        [System.Xml.Serialization.XmlElementAttribute("RuleParameter", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            LoadTestTypeLoadTestPluginsLoadTestPluginRuleParametersRuleParameter> RuleParameter
        {
            get { return _ruleParameter; }
            private set { _ruleParameter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RuleParameter collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RuleParameterSpecified
        {
            get { return (this.RuleParameter.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="LoadTestTypeLoadTestPluginsLoadTestPluginRuleParameters" /> class.</para>
        /// </summary>
        public LoadTestTypeLoadTestPluginsLoadTestPluginRuleParameters()
        {
            this._ruleParameter =
                new System.Collections.ObjectModel.Collection<
                    LoadTestTypeLoadTestPluginsLoadTestPluginRuleParametersRuleParameter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LoadTestTypeLoadTestPluginsLoadTestPluginRuleParametersRuleParameter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoadTestTypeLoadTestPluginsLoadTestPluginRuleParametersRuleParameter
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OrderedTestType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("OrderedTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class OrderedTestType : BaseTestType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LinkType> _testLinks;

        [System.Xml.Serialization.XmlArrayAttribute("TestLinks", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TestLink",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LinkType> TestLinks
        {
            get { return _testLinks; }
            private set { _testLinks = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestLinks collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestLinksSpecified
        {
            get { return (this.TestLinks.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="OrderedTestType" /> class.</para>
        /// </summary>
        public OrderedTestType()
        {
            this._testLinks = new System.Collections.ObjectModel.Collection<LinkType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _continueAfterFailure = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("continueAfterFailure")]
        public bool ContinueAfterFailure
        {
            get { return _continueAfterFailure; }
            set { _continueAfterFailure = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestLinksType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestLinksType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LinkType> _testLink;

        [System.Xml.Serialization.XmlElementAttribute("TestLink", Order = 0)]
        public System.Collections.ObjectModel.Collection<LinkType> TestLink
        {
            get { return _testLink; }
            private set { _testLink = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestLink collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestLinkSpecified
        {
            get { return (this.TestLink.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestLinksType" /> class.</para>
        /// </summary>
        public TestLinksType()
        {
            this._testLink = new System.Collections.ObjectModel.Collection<LinkType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunOutputType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunOutputType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("StdOut", Order = 0)]
        public object StdOut { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("StdErr", Order = 1)]
        public object StdErr { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DebugTrace", Order = 2)]
        public object DebugTrace { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TraceInfo", Order = 3)]
        public object TraceInfo { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PlainTextManualTestType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ManualTest",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class PlainTextManualTestType : BaseTestType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("BodyText", Order = 0)]
        public PlainTextManualTestTypeBodyText BodyText { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PlainTextManualTestTypeBodyText",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PlainTextManualTestTypeBodyText
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PlainTextManualTestTypeBodyText" /> class.</para>
        /// </summary>
        public PlainTextManualTestTypeBodyText()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("LoadProfile", Order = 0)]
        public ScenarioTypeLoadProfile LoadProfile { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ThinkProfile", Order = 1)]
        public ScenarioTypeThinkProfile ThinkProfile { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ScenarioTypeTestMixTestProfile> _testMix;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("TestMix", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TestProfile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<ScenarioTypeTestMixTestProfile> TestMix
        {
            get { return _testMix; }
            private set { _testMix = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ScenarioType" /> class.</para>
        /// </summary>
        public ScenarioType()
        {
            this._testMix = new System.Collections.ObjectModel.Collection<ScenarioTypeTestMixTestProfile>();
            this._browserMix = new System.Collections.ObjectModel.Collection<ScenarioTypeBrowserMixBrowserProfile>();
            this._networkMix = new System.Collections.ObjectModel.Collection<ScenarioTypeNetworkMixNetworkProfile>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ScenarioTypeBrowserMixBrowserProfile> _browserMix;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("BrowserMix", Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BrowserProfile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<ScenarioTypeBrowserMixBrowserProfile> BrowserMix
        {
            get { return _browserMix; }
            private set { _browserMix = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ScenarioTypeNetworkMixNetworkProfile> _networkMix;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("NetworkMix", Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("NetworkProfile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<ScenarioTypeNetworkMixNetworkProfile> NetworkMix
        {
            get { return _networkMix; }
            private set { _networkMix = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testMixType")]
        public string TestMixType { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _allowedAgents = "";

        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("allowedAgents")]
        public string AllowedAgents
        {
            get { return _allowedAgents; }
            set { _allowedAgents = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _ipSwitching = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("ipSwitching")]
        public bool IpSwitching
        {
            get { return _ipSwitching; }
            set { _ipSwitching = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _disableDuringWarmup = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("disableDuringWarmup")]
        public bool DisableDuringWarmup
        {
            get { return _disableDuringWarmup; }
            set { _disableDuringWarmup = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _delayBetweenIterations = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("delayBetweenIterations")]
        public int DelayBetweenIterations
        {
            get { return _delayBetweenIterations; }
            set { _delayBetweenIterations = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _maxTestIterations = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("maxTestIterations")]
        public int MaxTestIterations
        {
            get { return _maxTestIterations; }
            set { _maxTestIterations = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _delayStartTime = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("delayStartTime")]
        public int DelayStartTime
        {
            get { return _delayStartTime; }
            set { _delayStartTime = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _percentNewUsers = 100;

        [System.ComponentModel.DefaultValueAttribute(100)]
        [System.Xml.Serialization.XmlAttributeAttribute("percentNewUsers")]
        public int PercentNewUsers
        {
            get { return _percentNewUsers; }
            set { _percentNewUsers = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeLoadProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeLoadProfile
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _pattern = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("pattern")]
        public int Pattern
        {
            get { return _pattern; }
            set { _pattern = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("initialUsers")]
        public int InitialUsers { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeThinkProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeThinkProfile
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _pattern = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("pattern")]
        public int Pattern
        {
            get { return _pattern; }
            set { _pattern = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private double _value = 0D;

        [System.ComponentModel.DefaultValueAttribute(0D)]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeTestMix",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeTestMix
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ScenarioTypeTestMixTestProfile> _testProfile;

        [System.Xml.Serialization.XmlElementAttribute("TestProfile", Order = 0)]
        public System.Collections.ObjectModel.Collection<ScenarioTypeTestMixTestProfile> TestProfile
        {
            get { return _testProfile; }
            private set { _testProfile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestProfile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestProfileSpecified
        {
            get { return (this.TestProfile.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ScenarioTypeTestMix" /> class.</para>
        /// </summary>
        public ScenarioTypeTestMix()
        {
            this._testProfile = new System.Collections.ObjectModel.Collection<ScenarioTypeTestMixTestProfile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeTestMixTestProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeTestMixTestProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Percentage", Order = 0)]
        public ScenarioTypeTestMixTestProfilePercentage Percentage { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("percentage")]
        public string Percentage1 { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("path")]
        public string Path { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeTestMixTestProfilePercentage",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeTestMixTestProfilePercentage
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _hi = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("hi")]
        public int Hi
        {
            get { return _hi; }
            set { _hi = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _lo = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("lo")]
        public int Lo
        {
            get { return _lo; }
            set { _lo = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _mid = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("mid")]
        public int Mid
        {
            get { return _mid; }
            set { _mid = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _flags = 0;

        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("flags")]
        public int Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeBrowserMix",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeBrowserMix
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ScenarioTypeBrowserMixBrowserProfile> _browserProfile;

        [System.Xml.Serialization.XmlElementAttribute("BrowserProfile", Order = 0)]
        public System.Collections.ObjectModel.Collection<ScenarioTypeBrowserMixBrowserProfile> BrowserProfile
        {
            get { return _browserProfile; }
            private set { _browserProfile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the BrowserProfile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrowserProfileSpecified
        {
            get { return (this.BrowserProfile.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ScenarioTypeBrowserMix" /> class.</para>
        /// </summary>
        public ScenarioTypeBrowserMix()
        {
            this._browserProfile =
                new System.Collections.ObjectModel.Collection<ScenarioTypeBrowserMixBrowserProfile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeBrowserMixBrowserProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeBrowserMixBrowserProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Browser", Order = 0)]
        public BrowserType Browser { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("percentage")]
        public int PercentageValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Percentage property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PercentageValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Percentage
        {
            get
            {
                if (this.PercentageValueSpecified)
                {
                    return this.PercentageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PercentageValue = value.GetValueOrDefault();
                this.PercentageValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeNetworkMix",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeNetworkMix
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ScenarioTypeNetworkMixNetworkProfile> _networkProfile;

        [System.Xml.Serialization.XmlElementAttribute("NetworkProfile", Order = 0)]
        public System.Collections.ObjectModel.Collection<ScenarioTypeNetworkMixNetworkProfile> NetworkProfile
        {
            get { return _networkProfile; }
            private set { _networkProfile = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the NetworkProfile collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NetworkProfileSpecified
        {
            get { return (this.NetworkProfile.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ScenarioTypeNetworkMix" /> class.</para>
        /// </summary>
        public ScenarioTypeNetworkMix()
        {
            this._networkProfile =
                new System.Collections.ObjectModel.Collection<ScenarioTypeNetworkMixNetworkProfile>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ScenarioTypeNetworkMixNetworkProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScenarioTypeNetworkMixNetworkProfile
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Network", Order = 0)]
        public NetworkType Network { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("percentage")]
        public int PercentageValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Percentage property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PercentageValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> Percentage
        {
            get
            {
                if (this.PercentageValueSpecified)
                {
                    return this.PercentageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PercentageValue = value.GetValueOrDefault();
                this.PercentageValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestEntriesType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestEntriesType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestEntryType> _testEntry;

        [System.Xml.Serialization.XmlElementAttribute("TestEntry", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestEntryType> TestEntry
        {
            get { return _testEntry; }
            private set { _testEntry = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestEntry collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestEntrySpecified
        {
            get { return (this.TestEntry.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestEntriesType" /> class.</para>
        /// </summary>
        public TestEntriesType()
        {
            this._testEntry = new System.Collections.ObjectModel.Collection<TestEntryType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestEntryType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestEntryType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TcmInformation", Order = 0)]
        public TcmInformationType TcmInformation { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestEntryType> _testEntries;

        [System.Xml.Serialization.XmlArrayAttribute("TestEntries", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TestEntry",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<TestEntryType> TestEntries
        {
            get { return _testEntries; }
            private set { _testEntries = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestEntries collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestEntriesSpecified
        {
            get { return (this.TestEntries.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestEntryType" /> class.</para>
        /// </summary>
        public TestEntryType()
        {
            this._testEntries = new System.Collections.ObjectModel.Collection<TestEntryType>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testId")]
        public string TestId { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("executionId")]
        public string ExecutionId { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _parentExecutionId = "00000000-0000-0000-0000-000000000000";

        [System.ComponentModel.DefaultValueAttribute("00000000-0000-0000-0000-000000000000")]
        [System.Xml.Serialization.XmlAttributeAttribute("parentExecutionId")]
        public string ParentExecutionId
        {
            get { return _parentExecutionId; }
            set { _parentExecutionId = value; }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("testListId")]
        public string TestListId { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isTransparent = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("isTransparent")]
        public bool IsTransparent
        {
            get { return _isTransparent; }
            set { _isTransparent = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestListType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestListType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 0)]
        public object Description { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("RunConfiguration", Order = 1)]
        public LinkType RunConfiguration { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LinkType> _testLinks;

        [System.Xml.Serialization.XmlArrayAttribute("TestLinks", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TestLink",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<LinkType> TestLinks
        {
            get { return _testLinks; }
            private set { _testLinks = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestLinks collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestLinksSpecified
        {
            get { return (this.TestLinks.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestListType" /> class.</para>
        /// </summary>
        public TestListType()
        {
            this._testLinks = new System.Collections.ObjectModel.Collection<LinkType>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabled = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabled")]
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _parentListId = "00000000-0000-0000-0000-000000000000";

        [System.ComponentModel.DefaultValueAttribute("00000000-0000-0000-0000-000000000000")]
        [System.Xml.Serialization.XmlAttributeAttribute("parentListId")]
        public string ParentListId
        {
            get { return _parentListId; }
            set { _parentListId = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestResultDetailType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TestResultDetail",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestResultDetailType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TestDefinitions", Order = 0)]
        public TestDefinitionType TestDefinitions { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Result", Order = 1)]
        public ResultsType Result { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("runId")]
        public string RunId { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestDefinitionType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestDefinitionType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<UnitTestType> _unitTest;

        [System.Xml.Serialization.XmlElementAttribute("UnitTest", Order = 0)]
        public System.Collections.ObjectModel.Collection<UnitTestType> UnitTest
        {
            get { return _unitTest; }
            private set { _unitTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UnitTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitTestSpecified
        {
            get { return (this.UnitTest.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestDefinitionType" /> class.</para>
        /// </summary>
        public TestDefinitionType()
        {
            this._unitTest = new System.Collections.ObjectModel.Collection<UnitTestType>();
            this._unitTestElement = new System.Collections.ObjectModel.Collection<UnitTestType>();
            this._manualTest = new System.Collections.ObjectModel.Collection<PlainTextManualTestType>();
            this._webTest = new System.Collections.ObjectModel.Collection<DeclarativeWebTestElementType>();
            this._codedWebTest = new System.Collections.ObjectModel.Collection<CodedWebTestElementType>();
            this._orderedTest = new System.Collections.ObjectModel.Collection<OrderedTestType>();
            this._loadTest = new System.Collections.ObjectModel.Collection<LoadTestType>();
            this._genericTest = new System.Collections.ObjectModel.Collection<GenericTestType>();
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<UnitTestType> _unitTestElement;

        /// <summary>
        /// <para>// Deprecated. Use UnitTest instead</para>
        /// </summary>
        [System.ComponentModel.DescriptionAttribute("// Deprecated. Use UnitTest instead")]
        [System.Xml.Serialization.XmlElementAttribute("UnitTestElement", Order = 1)]
        public System.Collections.ObjectModel.Collection<UnitTestType> UnitTestElement
        {
            get { return _unitTestElement; }
            private set { _unitTestElement = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UnitTestElement collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitTestElementSpecified
        {
            get { return (this.UnitTestElement.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PlainTextManualTestType> _manualTest;

        [System.Xml.Serialization.XmlElementAttribute("ManualTest", Order = 2)]
        public System.Collections.ObjectModel.Collection<PlainTextManualTestType> ManualTest
        {
            get { return _manualTest; }
            private set { _manualTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ManualTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ManualTestSpecified
        {
            get { return (this.ManualTest.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DeclarativeWebTestElementType> _webTest;

        [System.Xml.Serialization.XmlElementAttribute("WebTest", Order = 3)]
        public System.Collections.ObjectModel.Collection<DeclarativeWebTestElementType> WebTest
        {
            get { return _webTest; }
            private set { _webTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the WebTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WebTestSpecified
        {
            get { return (this.WebTest.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CodedWebTestElementType> _codedWebTest;

        [System.Xml.Serialization.XmlElementAttribute("CodedWebTest", Order = 4)]
        public System.Collections.ObjectModel.Collection<CodedWebTestElementType> CodedWebTest
        {
            get { return _codedWebTest; }
            private set { _codedWebTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CodedWebTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodedWebTestSpecified
        {
            get { return (this.CodedWebTest.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<OrderedTestType> _orderedTest;

        [System.Xml.Serialization.XmlElementAttribute("OrderedTest", Order = 5)]
        public System.Collections.ObjectModel.Collection<OrderedTestType> OrderedTest
        {
            get { return _orderedTest; }
            private set { _orderedTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the OrderedTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderedTestSpecified
        {
            get { return (this.OrderedTest.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LoadTestType> _loadTest;

        [System.Xml.Serialization.XmlElementAttribute("LoadTest", Order = 6)]
        public System.Collections.ObjectModel.Collection<LoadTestType> LoadTest
        {
            get { return _loadTest; }
            private set { _loadTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the LoadTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LoadTestSpecified
        {
            get { return (this.LoadTest.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GenericTestType> _genericTest;

        [System.Xml.Serialization.XmlElementAttribute("GenericTest", Order = 7)]
        public System.Collections.ObjectModel.Collection<GenericTestType> GenericTest
        {
            get { return _genericTest; }
            private set { _genericTest = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the GenericTest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenericTestSpecified
        {
            get { return (this.GenericTest.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 8)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTestType : BaseTestType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("TestMethod", Order = 0)]
        public UnitTestTypeTestMethod TestMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DataSource", Order = 1)]
        public UnitTestTypeDataSource DataSource { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("AspNet", Order = 2)]
        public UnitTestTypeAspNet AspNet { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _aspNetDevelopmentServers;

        [System.Xml.Serialization.XmlArrayAttribute("AspNetDevelopmentServers", Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DevelopmentServer",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<object> AspNetDevelopmentServers
        {
            get { return _aspNetDevelopmentServers; }
            private set { _aspNetDevelopmentServers = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AspNetDevelopmentServers collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AspNetDevelopmentServersSpecified
        {
            get { return (this.AspNetDevelopmentServers.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="UnitTestType" /> class.</para>
        /// </summary>
        public UnitTestType()
        {
            this._aspNetDevelopmentServers = new System.Collections.ObjectModel.Collection<object>();
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Extension", Order = 4)]
        public UnitTestTypeExtension Extension { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestTypeTestMethod",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTestTypeTestMethod
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("codeBase")]
        public string CodeBase { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("className")]
        public string ClassName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isValid = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isValid")]
        public bool IsValid
        {
            get { return _isValid; }
            set { _isValid = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("adapterTypeName")]
        public string AdapterTypeName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestTypeDataSource",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTestTypeDataSource
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("settingName")]
        public string SettingName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("accessMethod")]
        public string AccessMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("connectionString")]
        public string ConnectionString { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("providerInvariantName")]
        public string ProviderInvariantName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("tableName")]
        public string TableName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestTypeAspNet",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTestTypeAspNet
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DevelopmentServerType> _developmentServer;

        [System.Xml.Serialization.XmlElementAttribute("DevelopmentServer", Order = 0)]
        public System.Collections.ObjectModel.Collection<DevelopmentServerType> DevelopmentServer
        {
            get { return _developmentServer; }
            private set { _developmentServer = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DevelopmentServer collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DevelopmentServerSpecified
        {
            get { return (this.DevelopmentServer.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="UnitTestTypeAspNet" /> class.</para>
        /// </summary>
        public UnitTestTypeAspNet()
        {
            this._developmentServer = new System.Collections.ObjectModel.Collection<DevelopmentServerType>();
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("webSiteUrl")]
        public string WebSiteUrl { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestTypeAspNetDevelopmentServers",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTestTypeAspNetDevelopmentServers
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<object> _developmentServer;

        [System.Xml.Serialization.XmlElementAttribute("DevelopmentServer", Order = 0)]
        public System.Collections.ObjectModel.Collection<object> DevelopmentServer
        {
            get { return _developmentServer; }
            private set { _developmentServer = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DevelopmentServer collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DevelopmentServerSpecified
        {
            get { return (this.DevelopmentServer.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="UnitTestTypeAspNetDevelopmentServers" /> class.</para>
        /// </summary>
        public UnitTestTypeAspNetDevelopmentServers()
        {
            this._developmentServer = new System.Collections.ObjectModel.Collection<object>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestTypeExtension",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTestTypeExtension
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement Any { get; set; }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TestRun",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunConfiguration> _testRunConfiguration;

        [System.Xml.Serialization.XmlElementAttribute("TestRunConfiguration", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestRunConfiguration> TestRunConfiguration
        {
            get { return _testRunConfiguration; }
            private set { _testRunConfiguration = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestRunConfiguration collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestRunConfigurationSpecified
        {
            get { return (this.TestRunConfiguration.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunType" /> class.</para>
        /// </summary>
        public TestRunType()
        {
            this._testRunConfiguration = new System.Collections.ObjectModel.Collection<TestRunConfiguration>();
            this._testSettings = new System.Collections.ObjectModel.Collection<TestSettingsType>();
            this._resultSummary = new System.Collections.ObjectModel.Collection<TestRunTypeResultSummary>();
            this._times = new System.Collections.ObjectModel.Collection<TestRunTypeTimes>();
            this._testDefinitions = new System.Collections.ObjectModel.Collection<TestDefinitionType>();
            this._testLists = new System.Collections.ObjectModel.Collection<TestRunTypeTestLists>();
            this._testEntries = new System.Collections.ObjectModel.Collection<TestEntriesType>();
            this._results = new System.Collections.ObjectModel.Collection<ResultsType>();
            this._userData = new System.Collections.ObjectModel.Collection<TestRunTypeUserData>();
            this._build = new System.Collections.ObjectModel.Collection<TestRunTypeBuild>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestSettingsType> _testSettings;

        [System.Xml.Serialization.XmlElementAttribute("TestSettings", Order = 1)]
        public System.Collections.ObjectModel.Collection<TestSettingsType> TestSettings
        {
            get { return _testSettings; }
            private set { _testSettings = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestSettings collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestSettingsSpecified
        {
            get { return (this.TestSettings.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunTypeResultSummary> _resultSummary;

        [System.Xml.Serialization.XmlElementAttribute("ResultSummary", Order = 2)]
        public System.Collections.ObjectModel.Collection<TestRunTypeResultSummary> ResultSummary
        {
            get { return _resultSummary; }
            private set { _resultSummary = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ResultSummary collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultSummarySpecified
        {
            get { return (this.ResultSummary.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunTypeTimes> _times;

        [System.Xml.Serialization.XmlElementAttribute("Times", Order = 3)]
        public System.Collections.ObjectModel.Collection<TestRunTypeTimes> Times
        {
            get { return _times; }
            private set { _times = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Times collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimesSpecified
        {
            get { return (this.Times.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestDefinitionType> _testDefinitions;

        [System.Xml.Serialization.XmlElementAttribute("TestDefinitions", Order = 4)]
        public System.Collections.ObjectModel.Collection<TestDefinitionType> TestDefinitions
        {
            get { return _testDefinitions; }
            private set { _testDefinitions = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestDefinitions collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestDefinitionsSpecified
        {
            get { return (this.TestDefinitions.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunTypeTestLists> _testLists;

        [System.Xml.Serialization.XmlElementAttribute("TestLists", Order = 5)]
        public System.Collections.ObjectModel.Collection<TestRunTypeTestLists> TestLists
        {
            get { return _testLists; }
            private set { _testLists = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestLists collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestListsSpecified
        {
            get { return (this.TestLists.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestEntriesType> _testEntries;

        [System.Xml.Serialization.XmlElementAttribute("TestEntries", Order = 6)]
        public System.Collections.ObjectModel.Collection<TestEntriesType> TestEntries
        {
            get { return _testEntries; }
            private set { _testEntries = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestEntries collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestEntriesSpecified
        {
            get { return (this.TestEntries.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResultsType> _results;

        [System.Xml.Serialization.XmlElementAttribute("Results", Order = 7)]
        public System.Collections.ObjectModel.Collection<ResultsType> Results
        {
            get { return _results; }
            private set { _results = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Results collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultsSpecified
        {
            get { return (this.Results.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunTypeUserData> _userData;

        [System.Xml.Serialization.XmlElementAttribute("UserData", Order = 8)]
        public System.Collections.ObjectModel.Collection<TestRunTypeUserData> UserData
        {
            get { return _userData; }
            private set { _userData = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UserData collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserDataSpecified
        {
            get { return (this.UserData.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunTypeBuild> _build;

        [System.Xml.Serialization.XmlElementAttribute("Build", Order = 9)]
        public System.Collections.ObjectModel.Collection<TestRunTypeBuild> Build
        {
            get { return _build; }
            private set { _build = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Build collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuildSpecified
        {
            get { return (this.Build.Count != 0); }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("runUser")]
        public string RunUser { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("tcmPassId")]
        public int TcmPassIdValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TcmPassId property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TcmPassIdValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> TcmPassId
        {
            get
            {
                if (this.TcmPassIdValueSpecified)
                {
                    return this.TcmPassIdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TcmPassIdValue = value.GetValueOrDefault();
                this.TcmPassIdValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunTypeResultSummary",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunTypeResultSummary
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CountersType> _counters;

        [System.Xml.Serialization.XmlElementAttribute("Counters", Order = 0)]
        public System.Collections.ObjectModel.Collection<CountersType> Counters
        {
            get { return _counters; }
            private set { _counters = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Counters collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountersSpecified
        {
            get { return (this.Counters.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunTypeResultSummary" /> class.</para>
        /// </summary>
        public TestRunTypeResultSummary()
        {
            this._counters = new System.Collections.ObjectModel.Collection<CountersType>();
            this._output = new System.Collections.ObjectModel.Collection<TestRunOutputType>();
            this._runInfos = new System.Collections.ObjectModel.Collection<TestRunTypeResultSummaryRunInfos>();
            this._resultFiles = new System.Collections.ObjectModel.Collection<ResultFilesTypeResultFile>();
            this._fileUris = new System.Collections.ObjectModel.Collection<FileUriType>();
            this._collectorDataEntries = new System.Collections.ObjectModel.Collection<CollectorType>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunOutputType> _output;

        [System.Xml.Serialization.XmlElementAttribute("Output", Order = 1)]
        public System.Collections.ObjectModel.Collection<TestRunOutputType> Output
        {
            get { return _output; }
            private set { _output = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Output collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutputSpecified
        {
            get { return (this.Output.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunTypeResultSummaryRunInfos> _runInfos;

        [System.Xml.Serialization.XmlElementAttribute("RunInfos", Order = 2)]
        public System.Collections.ObjectModel.Collection<TestRunTypeResultSummaryRunInfos> RunInfos
        {
            get { return _runInfos; }
            private set { _runInfos = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RunInfos collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RunInfosSpecified
        {
            get { return (this.RunInfos.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResultFilesTypeResultFile> _resultFiles;

        [System.Xml.Serialization.XmlArrayAttribute("ResultFiles", Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ResultFile",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<ResultFilesTypeResultFile> ResultFiles
        {
            get { return _resultFiles; }
            private set { _resultFiles = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ResultFiles collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultFilesSpecified
        {
            get { return (this.ResultFiles.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<FileUriType> _fileUris;

        [System.Xml.Serialization.XmlArrayAttribute("FileUris", Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FileUri",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<FileUriType> FileUris
        {
            get { return _fileUris; }
            private set { _fileUris = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the FileUris collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FileUrisSpecified
        {
            get { return (this.FileUris.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CollectorType> _collectorDataEntries;

        [System.Xml.Serialization.XmlArrayAttribute("CollectorDataEntries", Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Collector",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<CollectorType> CollectorDataEntries
        {
            get { return _collectorDataEntries; }
            private set { _collectorDataEntries = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CollectorDataEntries collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CollectorDataEntriesSpecified
        {
            get { return (this.CollectorDataEntries.Count != 0); }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DataCollectorMessages", Order = 6)]
        public DataCollectorMessagesType DataCollectorMessages { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("outcome")]
        public string Outcome { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isPartialRun = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isPartialRun")]
        public bool IsPartialRun
        {
            get { return _isPartialRun; }
            set { _isPartialRun = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunTypeResultSummaryRunInfos",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunTypeResultSummaryRunInfos
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestRunTypeResultSummaryRunInfosRunInfo> _runInfo;

        [System.Xml.Serialization.XmlElementAttribute("RunInfo", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestRunTypeResultSummaryRunInfosRunInfo> RunInfo
        {
            get { return _runInfo; }
            private set { _runInfo = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RunInfo collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RunInfoSpecified
        {
            get { return (this.RunInfo.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunTypeResultSummaryRunInfos" /> class.</para>
        /// </summary>
        public TestRunTypeResultSummaryRunInfos()
        {
            this._runInfo = new System.Collections.ObjectModel.Collection<TestRunTypeResultSummaryRunInfosRunInfo>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunTypeResultSummaryRunInfosRunInfo",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunTypeResultSummaryRunInfosRunInfo
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Text", Order = 0)]
        public object Text { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Exception", Order = 1)]
        public object Exception { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("computerName")]
        public string ComputerName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("outcome")]
        public TestOutcome Outcome { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("timestamp")]
        public string Timestamp { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestOutcome",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum TestOutcome
    {
        Error,

        Failed,

        Timeout,

        Aborted,

        Inconclusive,

        PassedButRunAborted,

        NotRunnable,

        NotExecuted,

        Disconnected,

        Warning,

        Passed,

        Completed,

        InProgress,

        Pending,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunTypeTimes",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunTypeTimes
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("creation")]
        public string Creation { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("queuing")]
        public string Queuing { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("start")]
        public string Start { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("finish")]
        public string Finish { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunTypeTestLists",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunTypeTestLists
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestListType> _testList;

        [System.Xml.Serialization.XmlElementAttribute("TestList", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestListType> TestList
        {
            get { return _testList; }
            private set { _testList = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestList collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestListSpecified
        {
            get { return (this.TestList.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestRunTypeTestLists" /> class.</para>
        /// </summary>
        public TestRunTypeTestLists()
        {
            this._testList = new System.Collections.ObjectModel.Collection<TestListType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunTypeUserData",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunTypeUserData
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement Any { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestRunTypeBuild",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestRunTypeBuild
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("flavor")]
        public string Flavor { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("platform")]
        public string Platform { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitTestResultTypeEnum",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum UnitTestResultTypeEnum
    {
        NotDataDriven,

        DataDrivenTest,

        DataDrivenDataRow,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ViewType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum ViewType
    {
        None,

        Graph,

        Summary,

        Table,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebDataType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebDataType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Headers", Order = 0)]
        public WebDataTypeHeaders Headers { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("url")]
        public string Url { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("command")]
        public string Command { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("contentType")]
        public string ContentType { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("encodingName")]
        public string EncodingName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebDataTypeHeaders",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebDataTypeHeaders
    {
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestErrorTypeEnum",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum WebTestErrorTypeEnum
    {
        TestError,

        Exception,

        HttpError,

        ValidationRuleError,

        ExtractionRuleError,

        Timeout,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestItemsType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestItemsType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRequestType> _request;

        [System.Xml.Serialization.XmlElementAttribute("Request", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestRequestType> Request
        {
            get { return _request; }
            private set { _request = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Request collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestSpecified
        {
            get { return (this.Request.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestItemsType" /> class.</para>
        /// </summary>
        public WebTestItemsType()
        {
            this._request = new System.Collections.ObjectModel.Collection<WebTestRequestType>();
            this._transactionTimer = new System.Collections.ObjectModel.Collection<WebTestItemsTypeTransactionTimer>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestItemsTypeTransactionTimer> _transactionTimer;

        [System.Xml.Serialization.XmlElementAttribute("TransactionTimer", Order = 1)]
        public System.Collections.ObjectModel.Collection<WebTestItemsTypeTransactionTimer> TransactionTimer
        {
            get { return _transactionTimer; }
            private set { _transactionTimer = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TransactionTimer collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionTimerSpecified
        {
            get { return (this.TransactionTimer.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("StringHttpBody", Order = 0)]
        public WebTestRequestTypeStringHttpBody StringHttpBody { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRequestType> _dependentRequests;

        [System.Xml.Serialization.XmlArrayAttribute("DependentRequests", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Request",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<WebTestRequestType> DependentRequests
        {
            get { return _dependentRequests; }
            private set { _dependentRequests = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DependentRequests collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DependentRequestsSpecified
        {
            get { return (this.DependentRequests.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestRequestType" /> class.</para>
        /// </summary>
        public WebTestRequestType()
        {
            this._dependentRequests = new System.Collections.ObjectModel.Collection<WebTestRequestType>();
            this._headers = new System.Collections.ObjectModel.Collection<HeadersTypeHeader>();
            this._extractionRules =
                new System.Collections.ObjectModel.Collection<WebTestRequestTypeExtractionRulesExtractionRule>();
            this._queryStringParameters =
                new System.Collections.ObjectModel.Collection<
                    WebTestRequestTypeQueryStringParametersQueryStringParameter>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<HeadersTypeHeader> _headers;

        [System.Xml.Serialization.XmlArrayAttribute("Headers", Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Header",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<HeadersTypeHeader> Headers
        {
            get { return _headers; }
            private set { _headers = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Headers collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeadersSpecified
        {
            get { return (this.Headers.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRequestTypeExtractionRulesExtractionRule>
            _extractionRules;

        [System.Xml.Serialization.XmlArrayAttribute("ExtractionRules", Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtractionRule",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<WebTestRequestTypeExtractionRulesExtractionRule>
            ExtractionRules
        {
            get { return _extractionRules; }
            private set { _extractionRules = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ExtractionRules collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtractionRulesSpecified
        {
            get { return (this.ExtractionRules.Count != 0); }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRequestTypeQueryStringParametersQueryStringParameter>
            _queryStringParameters;

        [System.Xml.Serialization.XmlArrayAttribute("QueryStringParameters", Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("QueryStringParameter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<WebTestRequestTypeQueryStringParametersQueryStringParameter>
            QueryStringParameters
        {
            get { return _queryStringParameters; }
            private set { _queryStringParameters = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the QueryStringParameters collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QueryStringParametersSpecified
        {
            get { return (this.QueryStringParameters.Count != 0); }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("FormPostHttpBody", Order = 5)]
        public WebTestRequestTypeFormPostHttpBody FormPostHttpBody { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Guid")]
        public string Guid { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("method")]
        public string Method { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("version")]
        public decimal VersionValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Version property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool VersionValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> Version
        {
            get
            {
                if (this.VersionValueSpecified)
                {
                    return this.VersionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VersionValue = value.GetValueOrDefault();
                this.VersionValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("url")]
        public string Url { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("thinkTime")]
        public byte ThinkTimeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ThinkTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ThinkTimeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<byte> ThinkTime
        {
            get
            {
                if (this.ThinkTimeValueSpecified)
                {
                    return this.ThinkTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ThinkTimeValue = value.GetValueOrDefault();
                this.ThinkTimeValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("timeout")]
        public byte TimeoutValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Timeout property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TimeoutValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<byte> Timeout
        {
            get
            {
                if (this.TimeoutValueSpecified)
                {
                    return this.TimeoutValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TimeoutValue = value.GetValueOrDefault();
                this.TimeoutValueSpecified = value.HasValue;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _parseLinks = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("parseLinks")]
        public bool ParseLinks
        {
            get { return _parseLinks; }
            set { _parseLinks = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _followRedirects = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("followRedirects")]
        public bool FollowRedirects
        {
            get { return _followRedirects; }
            set { _followRedirects = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _cache = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("cache")]
        public bool Cache
        {
            get { return _cache; }
            set { _cache = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeStringHttpBody",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeStringHttpBody
    {
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("contentType")]
        public string ContentType { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeDependentRequests",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeDependentRequests
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRequestType> _request;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Request", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestRequestType> Request
        {
            get { return _request; }
            private set { _request = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestRequestTypeDependentRequests" /> class.</para>
        /// </summary>
        public WebTestRequestTypeDependentRequests()
        {
            this._request = new System.Collections.ObjectModel.Collection<WebTestRequestType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeExtractionRules",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeExtractionRules
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRequestTypeExtractionRulesExtractionRule>
            _extractionRule;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ExtractionRule", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestRequestTypeExtractionRulesExtractionRule> ExtractionRule
        {
            get { return _extractionRule; }
            private set { _extractionRule = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestRequestTypeExtractionRules" /> class.</para>
        /// </summary>
        public WebTestRequestTypeExtractionRules()
        {
            this._extractionRule =
                new System.Collections.ObjectModel.Collection<WebTestRequestTypeExtractionRulesExtractionRule>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeExtractionRulesExtractionRule",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeExtractionRulesExtractionRule
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("className")]
        public string ClassName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("variableName")]
        public string VariableName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeQueryStringParameters",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeQueryStringParameters
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRequestTypeQueryStringParametersQueryStringParameter>
            _queryStringParameter;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("QueryStringParameter", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestRequestTypeQueryStringParametersQueryStringParameter>
            QueryStringParameter
        {
            get { return _queryStringParameter; }
            private set { _queryStringParameter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestRequestTypeQueryStringParameters" /> class.</para>
        /// </summary>
        public WebTestRequestTypeQueryStringParameters()
        {
            this._queryStringParameter =
                new System.Collections.ObjectModel.Collection<
                    WebTestRequestTypeQueryStringParametersQueryStringParameter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeQueryStringParametersQueryStringParameter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeQueryStringParametersQueryStringParameter
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _useToGroupResults = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("useToGroupResults")]
        public bool UseToGroupResults
        {
            get { return _useToGroupResults; }
            set { _useToGroupResults = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeFormPostHttpBody",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeFormPostHttpBody
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WebTestRequestTypeFormPostHttpBodyFormPostParameter>
            _formPostParameter;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("FormPostParameter", Order = 0)]
        public System.Collections.ObjectModel.Collection<WebTestRequestTypeFormPostHttpBodyFormPostParameter>
            FormPostParameter
        {
            get { return _formPostParameter; }
            private set { _formPostParameter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WebTestRequestTypeFormPostHttpBody" /> class.</para>
        /// </summary>
        public WebTestRequestTypeFormPostHttpBody()
        {
            this._formPostParameter =
                new System.Collections.ObjectModel.Collection<WebTestRequestTypeFormPostHttpBodyFormPostParameter>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("FileUploadParameter", Order = 1)]
        public WebTestRequestTypeFormPostHttpBodyFileUploadParameter FileUploadParameter { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeFormPostHttpBodyFormPostParameter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeFormPostHttpBodyFormPostParameter
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestRequestTypeFormPostHttpBodyFileUploadParameter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestRequestTypeFormPostHttpBodyFileUploadParameter
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("fileName")]
        public string FileName { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("contentType")]
        public string ContentType { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("WebTestItemsTypeTransactionTimer",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebTestItemsTypeTransactionTimer
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Items", Order = 0)]
        public WebTestItemsType Items { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("NetworkEmulationProfileType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("NetworkEmulationProfile",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class NetworkEmulationProfileType
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Emulation", Order = 0)]
        public NetworkEmulationProfileTypeEmulation Emulation { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("bandwidthInKbps")]
        public string BandwidthInKbps { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("NetworkEmulationProfileTypeEmulation",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NetworkEmulationProfileTypeEmulation
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="NetworkEmulationProfileTypeEmulation" /> class.</para>
        /// </summary>
        public NetworkEmulationProfileTypeEmulation()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DiscoveryCacheType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DiscoveryCache",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class DiscoveryCacheType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsController> _remoteAgents;

        [System.Xml.Serialization.XmlArrayAttribute("RemoteAgents", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Controller",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsController> RemoteAgents
        {
            get { return _remoteAgents; }
            private set { _remoteAgents = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the RemoteAgents collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemoteAgentsSpecified
        {
            get { return (this.RemoteAgents.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DiscoveryCacheType" /> class.</para>
        /// </summary>
        public DiscoveryCacheType()
        {
            this._remoteAgents =
                new System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsController>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DiscoveryCacheTypeRemoteAgents",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiscoveryCacheTypeRemoteAgents
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsController> _controller;

        [System.Xml.Serialization.XmlElementAttribute("Controller", Order = 0)]
        public System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsController> Controller
        {
            get { return _controller; }
            private set { _controller = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Controller collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ControllerSpecified
        {
            get { return (this.Controller.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DiscoveryCacheTypeRemoteAgents" /> class.</para>
        /// </summary>
        public DiscoveryCacheTypeRemoteAgents()
        {
            this._controller =
                new System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsController>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DiscoveryCacheTypeRemoteAgentsController",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiscoveryCacheTypeRemoteAgentsController
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsControllerAgent> _agent;

        [System.Xml.Serialization.XmlElementAttribute("Agent", Order = 0)]
        public System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsControllerAgent> Agent
        {
            get { return _agent; }
            private set { _agent = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Agent collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentSpecified
        {
            get { return (this.Agent.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DiscoveryCacheTypeRemoteAgentsController" /> class.</para>
        /// </summary>
        public DiscoveryCacheTypeRemoteAgentsController()
        {
            this._agent =
                new System.Collections.ObjectModel.Collection<DiscoveryCacheTypeRemoteAgentsControllerAgent>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DiscoveryCacheTypeRemoteAgentsControllerAgent",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiscoveryCacheTypeRemoteAgentsControllerAgent
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DataCollectorInformation", Order = 0)]
        public DataCollectorInformationType DataCollectorInformation { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NameValuePropertyType> _agentProperties;

        [System.Xml.Serialization.XmlArrayAttribute("AgentProperties", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Property",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<NameValuePropertyType> AgentProperties
        {
            get { return _agentProperties; }
            private set { _agentProperties = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AgentProperties collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgentPropertiesSpecified
        {
            get { return (this.AgentProperties.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DiscoveryCacheTypeRemoteAgentsControllerAgent" /> class.</para>
        /// </summary>
        public DiscoveryCacheTypeRemoteAgentsControllerAgent()
        {
            this._agentProperties = new System.Collections.ObjectModel.Collection<NameValuePropertyType>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorInformationType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorInformationType
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataCollectorInformationTypeDataCollectorsDataCollector>
            _dataCollectors;

        [System.Xml.Serialization.XmlArrayAttribute("DataCollectors", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DataCollector",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<DataCollectorInformationTypeDataCollectorsDataCollector>
            DataCollectors
        {
            get { return _dataCollectors; }
            private set { _dataCollectors = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataCollectors collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCollectorsSpecified
        {
            get { return (this.DataCollectors.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DataCollectorInformationType" /> class.</para>
        /// </summary>
        public DataCollectorInformationType()
        {
            this._dataCollectors =
                new System.Collections.ObjectModel.Collection<
                    DataCollectorInformationTypeDataCollectorsDataCollector>();
            this._configurationEditors =
                new System.Collections.ObjectModel.Collection<
                    DataCollectorInformationTypeConfigurationEditorsConfigurationEditor>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            DataCollectorInformationTypeConfigurationEditorsConfigurationEditor> _configurationEditors;

        [System.Xml.Serialization.XmlArrayAttribute("ConfigurationEditors", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ConfigurationEditor",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<
            DataCollectorInformationTypeConfigurationEditorsConfigurationEditor> ConfigurationEditors
        {
            get { return _configurationEditors; }
            private set { _configurationEditors = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ConfigurationEditors collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfigurationEditorsSpecified
        {
            get { return (this.ConfigurationEditors.Count != 0); }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorInformationTypeDataCollectors",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorInformationTypeDataCollectors
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataCollectorInformationTypeDataCollectorsDataCollector>
            _dataCollector;

        [System.Xml.Serialization.XmlElementAttribute("DataCollector", Order = 0)]
        public System.Collections.ObjectModel.Collection<DataCollectorInformationTypeDataCollectorsDataCollector>
            DataCollector
        {
            get { return _dataCollector; }
            private set { _dataCollector = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataCollector collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCollectorSpecified
        {
            get { return (this.DataCollector.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DataCollectorInformationTypeDataCollectors" /> class.</para>
        /// </summary>
        public DataCollectorInformationTypeDataCollectors()
        {
            this._dataCollector =
                new System.Collections.ObjectModel.Collection<
                    DataCollectorInformationTypeDataCollectorsDataCollector>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorInformationTypeDataCollectorsDataCollector",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorInformationTypeDataCollectorsDataCollector
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("FriendlyName", Order = 0)]
        public object FriendlyName { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 1)]
        public object Description { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DefaultConfiguration", Order = 2)]
        public DataCollectorInformationTypeDataCollectorsDataCollectorDefaultConfiguration DefaultConfiguration
        {
            get;
            set;
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ConfigurationEditor", Order = 3)]
        public DataCollectorInformationTypeDataCollectorsDataCollectorConfigurationEditor ConfigurationEditor
        {
            get;
            set;
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("typeUri")]
        public string TypeUri { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("requiresOutOfProcessCollection")]
        public bool RequiresOutOfProcessCollectionValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RequiresOutOfProcessCollection property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RequiresOutOfProcessCollectionValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> RequiresOutOfProcessCollection
        {
            get
            {
                if (this.RequiresOutOfProcessCollectionValueSpecified)
                {
                    return this.RequiresOutOfProcessCollectionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RequiresOutOfProcessCollectionValue = value.GetValueOrDefault();
                this.RequiresOutOfProcessCollectionValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("assemblyQualifiedName")]
        public string AssemblyQualifiedName { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isEnabledByDefault = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isEnabledByDefault")]
        public bool IsEnabledByDefault
        {
            get { return _isEnabledByDefault; }
            set { _isEnabledByDefault = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _enabledOnCollectionOnlyAgents = true;

        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("enabledOnCollectionOnlyAgents")]
        public bool EnabledOnCollectionOnlyAgents
        {
            get { return _enabledOnCollectionOnlyAgents; }
            set { _enabledOnCollectionOnlyAgents = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("supportedTestClients")]
        public string SupportedTestClients { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("supportedLocations")]
        public string SupportedLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("supportedAgentRoleTypes")]
        public string SupportedAgentRoleTypes { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isEnabledByDefaultForTailoredApplications = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("isEnabledByDefaultForTailoredApplications")]
        public bool IsEnabledByDefaultForTailoredApplications
        {
            get { return _isEnabledByDefaultForTailoredApplications; }
            set { _isEnabledByDefaultForTailoredApplications = value; }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _supportsTailoredApplications = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("supportsTailoredApplications")]
        public bool SupportsTailoredApplications
        {
            get { return _supportsTailoredApplications; }
            set { _supportsTailoredApplications = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "DataCollectorInformationTypeDataCollectorsDataCollectorDefaultConfiguration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorInformationTypeDataCollectorsDataCollectorDefaultConfiguration
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DataCollectorInformationTypeDataCollectorsDataCollectorDefaultConfiguration" /> class.</para>
        /// </summary>
        public DataCollectorInformationTypeDataCollectorsDataCollectorDefaultConfiguration()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "DataCollectorInformationTypeDataCollectorsDataCollectorConfigurationEditor",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorInformationTypeDataCollectorsDataCollectorConfigurationEditor
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Configuration", Order = 0)]
        public DataCollectorInformationTypeDataCollectorsDataCollectorConfigurationEditorConfiguration Configuration
        {
            get;
            set;
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("typeUri")]
        public string TypeUri { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("helpUri")]
        public string HelpUri { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(
        "DataCollectorInformationTypeDataCollectorsDataCollectorConfigurationEditorConfigu" +
        "ration", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorInformationTypeDataCollectorsDataCollectorConfigurationEditorConfiguration
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DataCollectorInformationTypeDataCollectorsDataCollectorConfigurationEditorConfiguration" /> class.</para>
        /// </summary>
        public DataCollectorInformationTypeDataCollectorsDataCollectorConfigurationEditorConfiguration()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorInformationTypeConfigurationEditors",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorInformationTypeConfigurationEditors
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<
            DataCollectorInformationTypeConfigurationEditorsConfigurationEditor> _configurationEditor;

        [System.Xml.Serialization.XmlElementAttribute("ConfigurationEditor", Order = 0)]
        public System.Collections.ObjectModel.Collection<
            DataCollectorInformationTypeConfigurationEditorsConfigurationEditor> ConfigurationEditor
        {
            get { return _configurationEditor; }
            private set { _configurationEditor = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ConfigurationEditor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfigurationEditorSpecified
        {
            get { return (this.ConfigurationEditor.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DataCollectorInformationTypeConfigurationEditors" /> class.</para>
        /// </summary>
        public DataCollectorInformationTypeConfigurationEditors()
        {
            this._configurationEditor =
                new System.Collections.ObjectModel.Collection<
                    DataCollectorInformationTypeConfigurationEditorsConfigurationEditor>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorInformationTypeConfigurationEditorsConfigurationEditor",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorInformationTypeConfigurationEditorsConfigurationEditor
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("typeUri")]
        public string TypeUri { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("assemblyQualifiedName")]
        public string AssemblyQualifiedName { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DiscoveryCacheTypeRemoteAgentsControllerAgentAgentProperties",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiscoveryCacheTypeRemoteAgentsControllerAgentAgentProperties
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NameValuePropertyType> _property;

        [System.Xml.Serialization.XmlElementAttribute("Property", Order = 0)]
        public System.Collections.ObjectModel.Collection<NameValuePropertyType> Property
        {
            get { return _property; }
            private set { _property = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Property collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertySpecified
        {
            get { return (this.Property.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DiscoveryCacheTypeRemoteAgentsControllerAgentAgentProperties" /> class.</para>
        /// </summary>
        public DiscoveryCacheTypeRemoteAgentsControllerAgentAgentProperties()
        {
            this._property = new System.Collections.ObjectModel.Collection<NameValuePropertyType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorConfigurationSection",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DataCollectorConfiguration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class DataCollectorConfigurationSection
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DataCollectorConfigurationSectionDataCollector>
            _dataCollector;

        [System.Xml.Serialization.XmlElementAttribute("DataCollector", Order = 0)]
        public System.Collections.ObjectModel.Collection<DataCollectorConfigurationSectionDataCollector> DataCollector
        {
            get { return _dataCollector; }
            private set { _dataCollector = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataCollector collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCollectorSpecified
        {
            get { return (this.DataCollector.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DataCollectorConfigurationSection" /> class.</para>
        /// </summary>
        public DataCollectorConfigurationSection()
        {
            this._dataCollector =
                new System.Collections.ObjectModel.Collection<DataCollectorConfigurationSectionDataCollector>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorConfigurationSectionDataCollector",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorConfigurationSectionDataCollector
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DefaultConfiguration", Order = 0)]
        public DataCollectorConfigurationSectionDataCollectorDefaultConfiguration DefaultConfiguration { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("typeUri")]
        public string TypeUri { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DataCollectorConfigurationSectionDataCollectorDefaultConfiguration",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DataCollectorConfigurationSectionDataCollectorDefaultConfiguration
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlElement> _any;

        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Any
        {
            get { return _any; }
            private set { _any = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySpecified
        {
            get { return (this.Any.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DataCollectorConfigurationSectionDataCollectorDefaultConfiguration" /> class.</para>
        /// </summary>
        public DataCollectorConfigurationSectionDataCollectorDefaultConfiguration()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.XmlElement>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PeriodicDisconnectionType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PeriodicDisconnectionType
    {
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 0)]
        public decimal Rate { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ConnectionTime", Order = 1)]
        public SecType ConnectionTime { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DisconnectionTime", Order = 2)]
        public SecType DisconnectionTime { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SecType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SecType
    {
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("unit")]
        public SecTypeUnit UnitValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Unit property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UnitValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<SecTypeUnit> Unit
        {
            get
            {
                if (this.UnitValueSpecified)
                {
                    return this.UnitValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UnitValue = value.GetValueOrDefault();
                this.UnitValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SecTypeUnit",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    public enum SecTypeUnit
    {
        [System.Xml.Serialization.XmlEnumAttribute("sec")]
        Sec,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Empirical1Type",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Empirical1Type
    {
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 0)]
        public decimal Rate { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Empirical2Type",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Empirical2Type
    {
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 0)]
        public decimal Rate { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("NormalReorderType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NormalReorderType
    {
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 0)]
        public decimal Rate { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Deviation", Order = 1)]
        public double Deviation { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("MaxPacketLag", Order = 2)]
        public ushort MaxPacketLag { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("FixedLatencyType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FixedLatencyType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Time", Order = 0)]
        public MsecType Time { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MsecType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MsecType
    {
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("unit")]
        public MsecTypeUnit UnitValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Unit property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UnitValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<MsecTypeUnit> Unit
        {
            get
            {
                if (this.UnitValueSpecified)
                {
                    return this.UnitValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UnitValue = value.GetValueOrDefault();
                this.UnitValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MsecTypeUnit",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    public enum MsecTypeUnit
    {
        [System.Xml.Serialization.XmlEnumAttribute("msec")]
        Msec,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UniformLatencyType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearLatencyType))]
    public partial class UniformLatencyType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Min", Order = 0)]
        public MsecType Min { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Max", Order = 1)]
        public MsecType Max { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("NormalLatencyType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NormalLatencyType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Average", Order = 0)]
        public MsecType Average { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Deviation", Order = 1)]
        public MsecType Deviation { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LinearLatencyType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LinearLatencyType : UniformLatencyType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Period", Order = 0)]
        public SecType Period { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BurstLatencyType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BurstLatencyType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Time", Order = 0)]
        public MsecType Time { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PeriodMin", Order = 1)]
        public SecType PeriodMin { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PeriodMax", Order = 2)]
        public SecType PeriodMax { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Probability", Order = 3)]
        public decimal Probability { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RandomErrorType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RandomErrorType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ErrorUnit", Order = 0)]
        public ErrorUnitType ErrorUnit { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 1)]
        public decimal Rate { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ErrorUnitType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum ErrorUnitType
    {
        [System.Xml.Serialization.XmlEnumAttribute("packet")]
        Packet,

        [System.Xml.Serialization.XmlEnumAttribute("bit")]
        Bit,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("NormalQueueType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NormalQueueType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("QueueMode", Order = 0)]
        public UnitType QueueMode { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Size", Order = 1)]
        public string Size { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DropType", Order = 2)]
        public DropType DropType { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnitType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum UnitType
    {
        [System.Xml.Serialization.XmlEnumAttribute("byte")]
        Byte,

        [System.Xml.Serialization.XmlEnumAttribute("kb")]
        Kb,

        [System.Xml.Serialization.XmlEnumAttribute("packet")]
        Packet,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DropType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("DropType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum DropType
    {
        DropTail,

        DropHead,

        DropRandom,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RedQueueType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RedQueueType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DropType", Order = 0)]
        public DropType DropType { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("QueueMode", Order = 1)]
        public UnitType QueueMode { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("MinPacket", Order = 2)]
        public string MinPacket { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("MaxPacket", Order = 3)]
        public string MaxPacket { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PacketSize", Order = 4)]
        public string PacketSize { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ConstantTrafficType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExponentialTrafficType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParetoTrafficType))]
    public partial class ConstantTrafficType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 0)]
        public SpeedType Rate { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PacketSize", Order = 1)]
        public SizeType PacketSize { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SpeedType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SpeedType
    {
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("unit")]
        public SpeedTypeUnit Unit { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SpeedTypeUnit",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    public enum SpeedTypeUnit
    {
        [System.Xml.Serialization.XmlEnumAttribute("kbps")]
        Kbps,

        [System.Xml.Serialization.XmlEnumAttribute("mbps")]
        Mbps,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SizeType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SizeType
    {
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private SizeTypeUnit _unit = Schemas.VisualStudio.TeamTest.SizeTypeUnit.Byte;

        [System.ComponentModel.DefaultValueAttribute(Schemas.VisualStudio.TeamTest.SizeTypeUnit.Byte)]
        [System.Xml.Serialization.XmlAttributeAttribute("unit")]
        public SizeTypeUnit Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SizeTypeUnit",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    public enum SizeTypeUnit
    {
        [System.Xml.Serialization.XmlEnumAttribute("byte")]
        Byte,

        [System.Xml.Serialization.XmlEnumAttribute("kb")]
        Kb,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ExponentialTrafficType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParetoTrafficType))]
    public partial class ExponentialTrafficType : ConstantTrafficType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("BurstTime", Order = 0)]
        public SecType BurstTime { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("IdleTime", Order = 1)]
        public SecType IdleTime { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ParetoTrafficType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ParetoTrafficType : ExponentialTrafficType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Shape", Order = 0)]
        public double Shape { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("PeriodicLossType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PeriodicLossType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PerPackets", Order = 0)]
        public string PerPackets { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RandomLossType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RandomLossType
    {
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 0)]
        public decimal Rate { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BurstLossType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BurstLossType
    {
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 0)]
        public decimal Rate { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("MinPacket", Order = 1)]
        public string MinPacket { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("MaxPacket", Order = 2)]
        public string MaxPacket { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AddressType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddressType
    {
        /// <summary>
        /// <para xml:lang="en">Pattern: ((([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.){3}([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))|(([0-9a-fA-F]{1,4}:){7}([0-9a-fA-F]{1,4})).</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute(
            "((([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.){3}([1-9]?[0-9]|1[0-9][0-9]|2[0" +
            "-4][0-9]|25[0-5]))|(([0-9a-fA-F]{1,4}:){7}([0-9a-fA-F]{1,4}))")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("IpAddress", Order = 0)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para xml:lang="en">Pattern: ((([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.){3}([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))|(([0-9a-fA-F]{1,4}:){7}([0-9a-fA-F]{1,4})).</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute(
            "((([1-9]?[0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.){3}([1-9]?[0-9]|1[0-9][0-9]|2[0" +
            "-4][0-9]|25[0-5]))|(([0-9a-fA-F]{1,4}:){7}([0-9a-fA-F]{1,4}))")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("IpMask", Order = 1)]
        public string IpMask { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PortBegin", Order = 2)]
        public ushort PortBegin { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PortEnd", Order = 3)]
        public ushort PortEnd { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("StatisticalType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatisticalErrorType))]
    public partial class StatisticalType
    {
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Good", Order = 0)]
        public decimal Good { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("GoodToBad", Order = 1)]
        public decimal GoodToBad { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Bad", Order = 2)]
        public decimal Bad { get; set; }

        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1",
            ConvertValueInInvariantCulture = true)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("BadToGood", Order = 3)]
        public decimal BadToGood { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("SwitchTime", Order = 4)]
        public SecType SwitchTime { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("StatisticalErrorType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StatisticalErrorType : StatisticalType
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("ErrorUnit", Order = 0)]
        public ErrorUnitType ErrorUnit { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TestLists",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TestLists",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestLists
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TestListType> _testList;

        [System.Xml.Serialization.XmlElementAttribute("TestList", Order = 0)]
        public System.Collections.ObjectModel.Collection<TestListType> TestList
        {
            get { return _testList; }
            private set { _testList = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TestList collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestListSpecified
        {
            get { return (this.TestList.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TestLists" /> class.</para>
        /// </summary>
        public TestLists()
        {
            this._testList = new System.Collections.ObjectModel.Collection<TestListType>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Emulation",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Emulation",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Emulation
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("VirtualChannel", Order = 0)]
        public VirtualChannel VirtualChannel { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Timestamp> _timestamp;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Timestamp", Order = 1)]
        public System.Collections.ObjectModel.Collection<Timestamp> Timestamp
        {
            get { return _timestamp; }
            private set { _timestamp = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Emulation" /> class.</para>
        /// </summary>
        public Emulation()
        {
            this._timestamp = new System.Collections.ObjectModel.Collection<Timestamp>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("VirtualChannel",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("VirtualChannel",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class VirtualChannel
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Filter> _filterList;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("FilterList", Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Filter",
            Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
        public System.Collections.ObjectModel.Collection<Filter> FilterList
        {
            get { return _filterList; }
            private set { _filterList = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="VirtualChannel" /> class.</para>
        /// </summary>
        public VirtualChannel()
        {
            this._filterList = new System.Collections.ObjectModel.Collection<Filter>();
            this._virtualLink = new System.Collections.ObjectModel.Collection<VirtualLink>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<VirtualLink> _virtualLink;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("VirtualLink", Order = 1)]
        public System.Collections.ObjectModel.Collection<VirtualLink> VirtualLink
        {
            get { return _virtualLink; }
            private set { _virtualLink = value; }
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("DispatchType")]
        public VirtualChannelDispatchType DispatchTypeValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DispatchType property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DispatchTypeValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<VirtualChannelDispatchType> DispatchType
        {
            get
            {
                if (this.DispatchTypeValueSpecified)
                {
                    return this.DispatchTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DispatchTypeValue = value.GetValueOrDefault();
                this.DispatchTypeValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("FilterList",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("FilterList",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class FilterList
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Filter> _filter;

        [System.Xml.Serialization.XmlElementAttribute("Filter", Order = 0)]
        public System.Collections.ObjectModel.Collection<Filter> Filter
        {
            get { return _filter; }
            private set { _filter = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Filter collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterSpecified
        {
            get { return (this.Filter.Count != 0); }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="FilterList" /> class.</para>
        /// </summary>
        public FilterList()
        {
            this._filter = new System.Collections.ObjectModel.Collection<Filter>();
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Filter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Filter",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Filter
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IpVersion", Order = 0)]
        public IpVersion IpVersionValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IpVersion property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IpVersionValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<IpVersion> IpVersion
        {
            get
            {
                if (this.IpVersionValueSpecified)
                {
                    return this.IpVersionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IpVersionValue = value.GetValueOrDefault();
                this.IpVersionValueSpecified = value.HasValue;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Protocol", Order = 1)]
        public Protocol ProtocolValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Protocol property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ProtocolValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<Protocol> Protocol
        {
            get
            {
                if (this.ProtocolValueSpecified)
                {
                    return this.ProtocolValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ProtocolValue = value.GetValueOrDefault();
                this.ProtocolValueSpecified = value.HasValue;
            }
        }

        /// <summary>
        /// <para xml:lang="en">Pattern: ([0-9a-fA-F]{1,2}-){7}([0-9a-fA-F]{1,2}).</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([0-9a-fA-F]{1,2}-){7}([0-9a-fA-F]{1,2})")]
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAddress", Order = 2)]
        public string PhysicalAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Local", Order = 3)]
        public AddressType Local { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Remote", Order = 4)]
        public AddressType Remote { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _not = false;

        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("not")]
        public bool Not
        {
            get { return _not; }
            set { _not = value; }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("IpVersion",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("IpVersion",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum IpVersion
    {
        IPv4,

        IPv6,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Protocol",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("Protocol",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public enum Protocol
    {
        [System.Xml.Serialization.XmlEnumAttribute("ICMP")]
        Icmp,

        [System.Xml.Serialization.XmlEnumAttribute("TCP")]
        Tcp,

        [System.Xml.Serialization.XmlEnumAttribute("UDP")]
        Udp,

        [System.Xml.Serialization.XmlEnumAttribute("ECP")]
        Ecp,

        [System.Xml.Serialization.XmlEnumAttribute("ICMPv6")]
        IcmPv6,

        [System.Xml.Serialization.XmlEnumAttribute("HTTP")]
        Http,

        [System.Xml.Serialization.XmlEnumAttribute("FTP")]
        Ftp,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("VirtualLink",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("VirtualLink",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class VirtualLink
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LinkRule> _linkRule;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("LinkRule", Order = 0)]
        public System.Collections.ObjectModel.Collection<LinkRule> LinkRule
        {
            get { return _linkRule; }
            private set { _linkRule = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="VirtualLink" /> class.</para>
        /// </summary>
        public VirtualLink()
        {
            this._linkRule = new System.Collections.ObjectModel.Collection<LinkRule>();
        }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("instances")]
        public ushort InstancesValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Instances property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool InstancesValueSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<ushort> Instances
        {
            get
            {
                if (this.InstancesValueSpecified)
                {
                    return this.InstancesValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InstancesValue = value.GetValueOrDefault();
                this.InstancesValueSpecified = value.HasValue;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LinkRule",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("LinkRule",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class LinkRule
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Latency", Order = 0)]
        public Latency Latency { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Error", Order = 1)]
        public Error Error { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Loss", Order = 2)]
        public Loss Loss { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Bandwidth", Order = 3)]
        public Bandwidth Bandwidth { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("BackgroundTraffic", Order = 4)]
        public BackgroundTraffic BackgroundTraffic { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Reorder", Order = 5)]
        public Reorder Reorder { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Disconnection", Order = 6)]
        public Disconnection Disconnection { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("dir")]
        public LinkRuleDir Dir { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Latency",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Latency",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Latency
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Fixed", Order = 0)]
        public FixedLatencyType Fixed { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Uniform", Order = 1)]
        public UniformLatencyType Uniform { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Normal", Order = 2)]
        public NormalLatencyType Normal { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Linear", Order = 3)]
        public LinearLatencyType Linear { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Burst", Order = 4)]
        public BurstLatencyType Burst { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Error",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Error",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Error
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Random", Order = 0)]
        public RandomErrorType Random { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Statistical", Order = 1)]
        public StatisticalErrorType Statistical { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Loss",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Loss",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Loss
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Periodic", Order = 0)]
        public PeriodicLossType Periodic { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Random", Order = 1)]
        public RandomLossType Random { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Burst", Order = 2)]
        public BurstLossType Burst { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Statistical", Order = 3)]
        public StatisticalType Statistical { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Bandwidth",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Bandwidth",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Bandwidth
    {
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Speed", Order = 0)]
        public SpeedType Speed { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("QueueManagement", Order = 1)]
        public BandwidthQueueManagement QueueManagement { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BandwidthQueueManagement",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BandwidthQueueManagement
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("RedQueue", Order = 0)]
        public RedQueueType RedQueue { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("NormalQueue", Order = 1)]
        public NormalQueueType NormalQueue { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BackgroundTraffic",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("BackgroundTraffic",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class BackgroundTraffic
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Constant", Order = 0)]
        public ConstantTrafficType Constant { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Exponential", Order = 1)]
        public ExponentialTrafficType Exponential { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Pareto", Order = 2)]
        public ParetoTrafficType Pareto { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Reorder",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Reorder",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Reorder
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Normal", Order = 0)]
        public NormalReorderType Normal { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Empirical1", Order = 1)]
        public Empirical1Type Empirical1 { get; set; }

        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Empirical2", Order = 2)]
        public Empirical2Type Empirical2 { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Disconnection",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Disconnection",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Disconnection
    {
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("Periodic", Order = 0)]
        public PeriodicDisconnectionType Periodic { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LinkRuleDir",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    public enum LinkRuleDir
    {
        [System.Xml.Serialization.XmlEnumAttribute("upstream")]
        Upstream,

        [System.Xml.Serialization.XmlEnumAttribute("downstream")]
        Downstream,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("VirtualChannelDispatchType",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    public enum VirtualChannelDispatchType
    {
        [System.Xml.Serialization.XmlEnumAttribute("packet")]
        Packet,

        [System.Xml.Serialization.XmlEnumAttribute("connection")]
        Connection,
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Timestamp",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Timestamp",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class Timestamp
    {
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<VirtualChannel> _virtualChannel;

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("VirtualChannel", Order = 0)]
        public System.Collections.ObjectModel.Collection<VirtualChannel> VirtualChannel
        {
            get { return _virtualChannel; }
            private set { _virtualChannel = value; }
        }

        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Timestamp" /> class.</para>
        /// </summary>
        public Timestamp()
        {
            this._virtualChannel = new System.Collections.ObjectModel.Collection<VirtualChannel>();
        }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public uint Value { get; set; }

        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("operation")]
        public TimestampOperation Operation { get; set; }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TimestampOperation",
        Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", AnonymousType = true)]
    public enum TimestampOperation
    {
        Add,

        Modify,

        Delete,
    }
}