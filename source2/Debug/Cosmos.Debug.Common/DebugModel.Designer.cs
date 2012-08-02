﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Cosmos.Debug.Common
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities() : base("name=Entities", "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(string connectionString) : base(connectionString, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(EntityConnection connection) : base(connection, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<FIELD_INFO> FIELD_INFO
        {
            get
            {
                if ((_FIELD_INFO == null))
                {
                    _FIELD_INFO = base.CreateObjectSet<FIELD_INFO>("FIELD_INFO");
                }
                return _FIELD_INFO;
            }
        }
        private ObjectSet<FIELD_INFO> _FIELD_INFO;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<FIELD_MAPPING> FIELD_MAPPING
        {
            get
            {
                if ((_FIELD_MAPPING == null))
                {
                    _FIELD_MAPPING = base.CreateObjectSet<FIELD_MAPPING>("FIELD_MAPPING");
                }
                return _FIELD_MAPPING;
            }
        }
        private ObjectSet<FIELD_MAPPING> _FIELD_MAPPING;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Label> Labels
        {
            get
            {
                if ((_Labels == null))
                {
                    _Labels = base.CreateObjectSet<Label>("Labels");
                }
                return _Labels;
            }
        }
        private ObjectSet<Label> _Labels;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<LOCAL_ARGUMENT_INFO> LOCAL_ARGUMENT_INFO
        {
            get
            {
                if ((_LOCAL_ARGUMENT_INFO == null))
                {
                    _LOCAL_ARGUMENT_INFO = base.CreateObjectSet<LOCAL_ARGUMENT_INFO>("LOCAL_ARGUMENT_INFO");
                }
                return _LOCAL_ARGUMENT_INFO;
            }
        }
        private ObjectSet<LOCAL_ARGUMENT_INFO> _LOCAL_ARGUMENT_INFO;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<MLSYMBOL> MLSYMBOLs
        {
            get
            {
                if ((_MLSYMBOLs == null))
                {
                    _MLSYMBOLs = base.CreateObjectSet<MLSYMBOL>("MLSYMBOLs");
                }
                return _MLSYMBOLs;
            }
        }
        private ObjectSet<MLSYMBOL> _MLSYMBOLs;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the FIELD_INFO EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFIELD_INFO(FIELD_INFO fIELD_INFO)
        {
            base.AddObject("FIELD_INFO", fIELD_INFO);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the FIELD_MAPPING EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFIELD_MAPPING(FIELD_MAPPING fIELD_MAPPING)
        {
            base.AddObject("FIELD_MAPPING", fIELD_MAPPING);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Labels EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLabels(Label label)
        {
            base.AddObject("Labels", label);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the LOCAL_ARGUMENT_INFO EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLOCAL_ARGUMENT_INFO(LOCAL_ARGUMENT_INFO lOCAL_ARGUMENT_INFO)
        {
            base.AddObject("LOCAL_ARGUMENT_INFO", lOCAL_ARGUMENT_INFO);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MLSYMBOLs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMLSYMBOLs(MLSYMBOL mLSYMBOL)
        {
            base.AddObject("MLSYMBOLs", mLSYMBOL);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DebugModel", Name="FIELD_INFO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class FIELD_INFO : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FIELD_INFO object.
        /// </summary>
        /// <param name="tYPE">Initial value of the TYPE property.</param>
        /// <param name="oFFSET">Initial value of the OFFSET property.</param>
        /// <param name="nAME">Initial value of the NAME property.</param>
        /// <param name="id">Initial value of the ID property.</param>
        public static FIELD_INFO CreateFIELD_INFO(global::System.String tYPE, global::System.Int32 oFFSET, global::System.String nAME, global::System.Guid id)
        {
            FIELD_INFO fIELD_INFO = new FIELD_INFO();
            fIELD_INFO.TYPE = tYPE;
            fIELD_INFO.OFFSET = oFFSET;
            fIELD_INFO.NAME = nAME;
            fIELD_INFO.ID = id;
            return fIELD_INFO;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TYPE
        {
            get
            {
                return _TYPE;
            }
            set
            {
                OnTYPEChanging(value);
                ReportPropertyChanging("TYPE");
                _TYPE = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("TYPE");
                OnTYPEChanged();
            }
        }
        private global::System.String _TYPE;
        partial void OnTYPEChanging(global::System.String value);
        partial void OnTYPEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OFFSET
        {
            get
            {
                return _OFFSET;
            }
            set
            {
                OnOFFSETChanging(value);
                ReportPropertyChanging("OFFSET");
                _OFFSET = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OFFSET");
                OnOFFSETChanged();
            }
        }
        private global::System.Int32 _OFFSET;
        partial void OnOFFSETChanging(global::System.Int32 value);
        partial void OnOFFSETChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NAME
        {
            get
            {
                return _NAME;
            }
            set
            {
                OnNAMEChanging(value);
                ReportPropertyChanging("NAME");
                _NAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NAME");
                OnNAMEChanged();
            }
        }
        private global::System.String _NAME;
        partial void OnNAMEChanging(global::System.String value);
        partial void OnNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DebugModel", Name="FIELD_MAPPING")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class FIELD_MAPPING : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FIELD_MAPPING object.
        /// </summary>
        /// <param name="tYPE_NAME">Initial value of the TYPE_NAME property.</param>
        /// <param name="fIELD_NAME">Initial value of the FIELD_NAME property.</param>
        /// <param name="id">Initial value of the ID property.</param>
        public static FIELD_MAPPING CreateFIELD_MAPPING(global::System.String tYPE_NAME, global::System.String fIELD_NAME, global::System.Guid id)
        {
            FIELD_MAPPING fIELD_MAPPING = new FIELD_MAPPING();
            fIELD_MAPPING.TYPE_NAME = tYPE_NAME;
            fIELD_MAPPING.FIELD_NAME = fIELD_NAME;
            fIELD_MAPPING.ID = id;
            return fIELD_MAPPING;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TYPE_NAME
        {
            get
            {
                return _TYPE_NAME;
            }
            set
            {
                OnTYPE_NAMEChanging(value);
                ReportPropertyChanging("TYPE_NAME");
                _TYPE_NAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("TYPE_NAME");
                OnTYPE_NAMEChanged();
            }
        }
        private global::System.String _TYPE_NAME;
        partial void OnTYPE_NAMEChanging(global::System.String value);
        partial void OnTYPE_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FIELD_NAME
        {
            get
            {
                return _FIELD_NAME;
            }
            set
            {
                OnFIELD_NAMEChanging(value);
                ReportPropertyChanging("FIELD_NAME");
                _FIELD_NAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FIELD_NAME");
                OnFIELD_NAMEChanged();
            }
        }
        private global::System.String _FIELD_NAME;
        partial void OnFIELD_NAMEChanging(global::System.String value);
        partial void OnFIELD_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DebugModel", Name="Label")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Label : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Label object.
        /// </summary>
        /// <param name="lABELNAME">Initial value of the LABELNAME property.</param>
        /// <param name="aDDRESS">Initial value of the ADDRESS property.</param>
        /// <param name="id">Initial value of the ID property.</param>
        public static Label CreateLabel(global::System.String lABELNAME, global::System.Int64 aDDRESS, global::System.Guid id)
        {
            Label label = new Label();
            label.LABELNAME = lABELNAME;
            label.ADDRESS = aDDRESS;
            label.ID = id;
            return label;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LABELNAME
        {
            get
            {
                return _LABELNAME;
            }
            set
            {
                OnLABELNAMEChanging(value);
                ReportPropertyChanging("LABELNAME");
                _LABELNAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LABELNAME");
                OnLABELNAMEChanged();
            }
        }
        private global::System.String _LABELNAME;
        partial void OnLABELNAMEChanging(global::System.String value);
        partial void OnLABELNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ADDRESS
        {
            get
            {
                return _ADDRESS;
            }
            set
            {
                OnADDRESSChanging(value);
                ReportPropertyChanging("ADDRESS");
                _ADDRESS = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ADDRESS");
                OnADDRESSChanged();
            }
        }
        private global::System.Int64 _ADDRESS;
        partial void OnADDRESSChanging(global::System.Int64 value);
        partial void OnADDRESSChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DebugModel", Name="LOCAL_ARGUMENT_INFO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LOCAL_ARGUMENT_INFO : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new LOCAL_ARGUMENT_INFO object.
        /// </summary>
        /// <param name="mETHODLABELNAME">Initial value of the METHODLABELNAME property.</param>
        /// <param name="isArgument">Initial value of the IsArgument property.</param>
        /// <param name="iNDEXINMETHOD">Initial value of the INDEXINMETHOD property.</param>
        /// <param name="oFFSET">Initial value of the OFFSET property.</param>
        /// <param name="nAME">Initial value of the NAME property.</param>
        /// <param name="tYPENAME">Initial value of the TYPENAME property.</param>
        /// <param name="id">Initial value of the ID property.</param>
        public static LOCAL_ARGUMENT_INFO CreateLOCAL_ARGUMENT_INFO(global::System.String mETHODLABELNAME, global::System.Boolean isArgument, global::System.Int32 iNDEXINMETHOD, global::System.Int32 oFFSET, global::System.String nAME, global::System.String tYPENAME, global::System.Guid id)
        {
            LOCAL_ARGUMENT_INFO lOCAL_ARGUMENT_INFO = new LOCAL_ARGUMENT_INFO();
            lOCAL_ARGUMENT_INFO.METHODLABELNAME = mETHODLABELNAME;
            lOCAL_ARGUMENT_INFO.IsArgument = isArgument;
            lOCAL_ARGUMENT_INFO.INDEXINMETHOD = iNDEXINMETHOD;
            lOCAL_ARGUMENT_INFO.OFFSET = oFFSET;
            lOCAL_ARGUMENT_INFO.NAME = nAME;
            lOCAL_ARGUMENT_INFO.TYPENAME = tYPENAME;
            lOCAL_ARGUMENT_INFO.ID = id;
            return lOCAL_ARGUMENT_INFO;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String METHODLABELNAME
        {
            get
            {
                return _METHODLABELNAME;
            }
            set
            {
                OnMETHODLABELNAMEChanging(value);
                ReportPropertyChanging("METHODLABELNAME");
                _METHODLABELNAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("METHODLABELNAME");
                OnMETHODLABELNAMEChanged();
            }
        }
        private global::System.String _METHODLABELNAME;
        partial void OnMETHODLABELNAMEChanging(global::System.String value);
        partial void OnMETHODLABELNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsArgument
        {
            get
            {
                return _IsArgument;
            }
            set
            {
                OnIsArgumentChanging(value);
                ReportPropertyChanging("IsArgument");
                _IsArgument = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsArgument");
                OnIsArgumentChanged();
            }
        }
        private global::System.Boolean _IsArgument;
        partial void OnIsArgumentChanging(global::System.Boolean value);
        partial void OnIsArgumentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 INDEXINMETHOD
        {
            get
            {
                return _INDEXINMETHOD;
            }
            set
            {
                OnINDEXINMETHODChanging(value);
                ReportPropertyChanging("INDEXINMETHOD");
                _INDEXINMETHOD = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("INDEXINMETHOD");
                OnINDEXINMETHODChanged();
            }
        }
        private global::System.Int32 _INDEXINMETHOD;
        partial void OnINDEXINMETHODChanging(global::System.Int32 value);
        partial void OnINDEXINMETHODChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OFFSET
        {
            get
            {
                return _OFFSET;
            }
            set
            {
                OnOFFSETChanging(value);
                ReportPropertyChanging("OFFSET");
                _OFFSET = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OFFSET");
                OnOFFSETChanged();
            }
        }
        private global::System.Int32 _OFFSET;
        partial void OnOFFSETChanging(global::System.Int32 value);
        partial void OnOFFSETChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NAME
        {
            get
            {
                return _NAME;
            }
            set
            {
                OnNAMEChanging(value);
                ReportPropertyChanging("NAME");
                _NAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NAME");
                OnNAMEChanged();
            }
        }
        private global::System.String _NAME;
        partial void OnNAMEChanging(global::System.String value);
        partial void OnNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TYPENAME
        {
            get
            {
                return _TYPENAME;
            }
            set
            {
                OnTYPENAMEChanging(value);
                ReportPropertyChanging("TYPENAME");
                _TYPENAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("TYPENAME");
                OnTYPENAMEChanged();
            }
        }
        private global::System.String _TYPENAME;
        partial void OnTYPENAMEChanging(global::System.String value);
        partial void OnTYPENAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DebugModel", Name="MLSYMBOL")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MLSYMBOL : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MLSYMBOL object.
        /// </summary>
        /// <param name="lABELNAME">Initial value of the LABELNAME property.</param>
        /// <param name="sTACKDIFF">Initial value of the STACKDIFF property.</param>
        /// <param name="iLASMFILE">Initial value of the ILASMFILE property.</param>
        /// <param name="tYPETOKEN">Initial value of the TYPETOKEN property.</param>
        /// <param name="mETHODTOKEN">Initial value of the METHODTOKEN property.</param>
        /// <param name="iLOFFSET">Initial value of the ILOFFSET property.</param>
        /// <param name="mETHODNAME">Initial value of the METHODNAME property.</param>
        /// <param name="id">Initial value of the ID property.</param>
        public static MLSYMBOL CreateMLSYMBOL(global::System.String lABELNAME, global::System.Int32 sTACKDIFF, global::System.String iLASMFILE, global::System.Int32 tYPETOKEN, global::System.Int32 mETHODTOKEN, global::System.Int32 iLOFFSET, global::System.String mETHODNAME, global::System.Guid id)
        {
            MLSYMBOL mLSYMBOL = new MLSYMBOL();
            mLSYMBOL.LABELNAME = lABELNAME;
            mLSYMBOL.STACKDIFF = sTACKDIFF;
            mLSYMBOL.ILASMFILE = iLASMFILE;
            mLSYMBOL.TYPETOKEN = tYPETOKEN;
            mLSYMBOL.METHODTOKEN = mETHODTOKEN;
            mLSYMBOL.ILOFFSET = iLOFFSET;
            mLSYMBOL.METHODNAME = mETHODNAME;
            mLSYMBOL.ID = id;
            return mLSYMBOL;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LABELNAME
        {
            get
            {
                return _LABELNAME;
            }
            set
            {
                OnLABELNAMEChanging(value);
                ReportPropertyChanging("LABELNAME");
                _LABELNAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LABELNAME");
                OnLABELNAMEChanged();
            }
        }
        private global::System.String _LABELNAME;
        partial void OnLABELNAMEChanging(global::System.String value);
        partial void OnLABELNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 STACKDIFF
        {
            get
            {
                return _STACKDIFF;
            }
            set
            {
                OnSTACKDIFFChanging(value);
                ReportPropertyChanging("STACKDIFF");
                _STACKDIFF = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("STACKDIFF");
                OnSTACKDIFFChanged();
            }
        }
        private global::System.Int32 _STACKDIFF;
        partial void OnSTACKDIFFChanging(global::System.Int32 value);
        partial void OnSTACKDIFFChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ILASMFILE
        {
            get
            {
                return _ILASMFILE;
            }
            set
            {
                OnILASMFILEChanging(value);
                ReportPropertyChanging("ILASMFILE");
                _ILASMFILE = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ILASMFILE");
                OnILASMFILEChanged();
            }
        }
        private global::System.String _ILASMFILE;
        partial void OnILASMFILEChanging(global::System.String value);
        partial void OnILASMFILEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TYPETOKEN
        {
            get
            {
                return _TYPETOKEN;
            }
            set
            {
                OnTYPETOKENChanging(value);
                ReportPropertyChanging("TYPETOKEN");
                _TYPETOKEN = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TYPETOKEN");
                OnTYPETOKENChanged();
            }
        }
        private global::System.Int32 _TYPETOKEN;
        partial void OnTYPETOKENChanging(global::System.Int32 value);
        partial void OnTYPETOKENChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 METHODTOKEN
        {
            get
            {
                return _METHODTOKEN;
            }
            set
            {
                OnMETHODTOKENChanging(value);
                ReportPropertyChanging("METHODTOKEN");
                _METHODTOKEN = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("METHODTOKEN");
                OnMETHODTOKENChanged();
            }
        }
        private global::System.Int32 _METHODTOKEN;
        partial void OnMETHODTOKENChanging(global::System.Int32 value);
        partial void OnMETHODTOKENChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ILOFFSET
        {
            get
            {
                return _ILOFFSET;
            }
            set
            {
                OnILOFFSETChanging(value);
                ReportPropertyChanging("ILOFFSET");
                _ILOFFSET = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ILOFFSET");
                OnILOFFSETChanged();
            }
        }
        private global::System.Int32 _ILOFFSET;
        partial void OnILOFFSETChanging(global::System.Int32 value);
        partial void OnILOFFSETChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String METHODNAME
        {
            get
            {
                return _METHODNAME;
            }
            set
            {
                OnMETHODNAMEChanging(value);
                ReportPropertyChanging("METHODNAME");
                _METHODNAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("METHODNAME");
                OnMETHODNAMEChanged();
            }
        }
        private global::System.String _METHODNAME;
        partial void OnMETHODNAMEChanging(global::System.String value);
        partial void OnMETHODNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();

        #endregion
    
    }

    #endregion
    
}
