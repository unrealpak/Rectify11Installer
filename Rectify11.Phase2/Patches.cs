﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 

namespace Rectify11.Phase2
{
    public class PatchesParser
    {
        #region Public Methods
        public static Patches GetAll()
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(Patches));
            Patches patches;
            using (var reader = new System.IO.StringReader(Rectify11.Phase2.Properties.Resources.rectify11))
            {
                patches = (Patches)ser.Deserialize(reader);
            }
            return patches;
        }
        #endregion
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Patches {

        private PatchesPatch[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Patch", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PatchesPatch[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PatchesPatch {

        private string muiField;

        private string maskField;

        private string x86Field;

        private string hardlinkTargetField;

        private string disableOnSafeModeField;

        private string IgnoreField;

        private string MinVersionField;

        private string MaxVersionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mui {
            get {
                return this.muiField;
            }
            set {
                this.muiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mask {
            get {
                return this.maskField;
            }
            set {
                this.maskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string x86 {
            get {
                return this.x86Field;
            }
            set {
                this.x86Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HardlinkTarget {
            get {
                return this.hardlinkTargetField;
            }
            set {
                this.hardlinkTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisableOnSafeMode {
            get {
                return this.disableOnSafeModeField;
            }
            set {
                this.disableOnSafeModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ignore
        {
            get
            {
                return this.IgnoreField;
            }
            set
            {
                this.IgnoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MinVersion
        {
            get
            {
                return this.MinVersionField;
            }
            set
            {
                this.MinVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaxVersion
        {
            get
            {
                return this.MaxVersionField;
            }
            set
            {
                this.MaxVersionField = value;
            }
        }
    }
}