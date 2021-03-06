﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.4952
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.ComponentModel;

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=2.0.50727.3038.
// 

// 
// ATTENTION:
// Manual changes have been made to this auto-generated code. As these will be lost if the code is 
// generated again, make sure to make the following changes to the freshly generated code:
// - add "using System.ComponentModel;"
// - add everything to "namespace Asterics.ACS"
// - to the property "id" in class "componentType" add the attributes
// 	"[DisplayName("Component Name")]
//   [Category(categoryComponent)]"   			
//- to the property "id" in class "componentType" add to the setter
//   OnPropertyChanged("Component Name");			
// - to the property "description" in class "componentType" add the attributes   
//   "[DisplayName("Component Description")]
//    [Category(categoryComponent)]"
// - to the properties "ports", "properties", "layout", "gui", "type_id" in class "modelComponent" add the attribute
// 	"[Browsable(false)]"
// - in class "inputPortType" add attributes as follows:
// 	- to the property "properties" add
// 		"[Browsable(false)]"
// 	- to the property "portTypeID" add
// 		"[ReadOnly(true)]
//     [DisplayName("Port Label")]
//     [Category("ACSInternalProperty")]"
//  - to the property "sync" add
//     [DisplayName("Synchronise Inputs")]
//     [Category("ACSInternalProperty")]
//  - at setter of property sync, add:
//     this.syncSpecified = true;
// - in class "propertyType" add attributes as follows:
// 	- to the property "name" add
// 		"[DisplayName("Property Name")]
//     [ReadOnly(true)]" 
//   - to the property value add
//   	"[DisplayName("Value")]"
// - in class "propertyType" add the following lines to the setter of the property "value":
//            if (Validate(value)) {
//                this.valueField = value;
//                OnPropertyChanged(name);
//            } else {
//                OnPropertyChangeError(name);
//            }
//        }
// - in class "outputPortType" add attributes as follows:
// 	- to the property "properties" add
// 		"[Browsable(false)]"
// 	- to the property "portTypeID" add
// 		"[ReadOnly(true)]
//     [DisplayName("Port Label")]
//     [Category("ACSInternalProperty")]"
//


namespace Asterics.ACS {

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class model {

        private modelDescriptionType modelDescriptionField;

        private componentType[] componentsField;

        private channel[] channelsField;

        private eventChannel[] eventChannelsField;
        
        private group[] groupsField;
        
        private modelGUIType modelGUIField;

        private string modelNameField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public modelDescriptionType modelDescription {
            get {
                return this.modelDescriptionField;
            }
            set {
                this.modelDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("component", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public componentType[] components {
            get {
                return this.componentsField;
            }
            set {
                this.componentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public channel[] channels {
            get {
                return this.channelsField;
            }
            set {
                this.channelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public eventChannel[] eventChannels {
            get {
                return this.eventChannelsField;
            }
            set {
                this.eventChannelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public group[] groups {
            get {
                return this.groupsField;
            }
            set {
                this.groupsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public modelGUIType modelGUI {
            get {
                return this.modelGUIField;
            }
            set {
                this.modelGUIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modelName {
            get {
                return this.modelNameField;
            }
            set {
                this.modelNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class modelDescriptionType {

        private string shortDescriptionField;

        private string requirementsField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string shortDescription {
            get {
                return this.shortDescriptionField;
            }
            set {
                this.shortDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string requirements {
            get {
                return this.requirementsField;
            }
            set {
                this.requirementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class modelGUIType {

        private bool decorationField;

        private bool fullscreenField;

        private bool alwaysOnTopField;

        private bool toSystemTrayField;

        private bool shopControlPanelField;

        private guiType aREGUIWindowField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Decoration {
            get {
                return this.decorationField;
            }
            set {
                this.decorationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Fullscreen {
            get {
                return this.fullscreenField;
            }
            set {
                this.fullscreenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool AlwaysOnTop {
            get {
                return this.alwaysOnTopField;
            }
            set {
                this.alwaysOnTopField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ToSystemTray {
            get {
                return this.toSystemTrayField;
            }
            set {
                this.toSystemTrayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ShopControlPanel {
            get {
                return this.shopControlPanelField;
            }
            set {
                this.shopControlPanelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public guiType AREGUIWindow {
            get {
                return this.aREGUIWindowField;
            }
            set {
                this.aREGUIWindowField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class portAlias {

        private string portIdField;

        private string portAlias1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string portId {
            get {
                return this.portIdField;
            }
            set {
                this.portIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("portAlias")]
        public string portAlias1 {
            get {
                return this.portAlias1Field;
            }
            set {
                this.portAlias1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class group {

        private string descriptionField;

        private string[] componentIdField;

        private portAlias[] portAliasField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("componentId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] componentId {
            get {
                return this.componentIdField;
            }
            set {
                this.componentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("portAlias", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public portAlias[] portAlias {
            get {
                return this.portAliasField;
            }
            set {
                this.portAliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eventChannelTargetsType {

        private eventEdge targetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public eventEdge target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eventEdge {

        private eventEdgeComponentType componentField;

        private eventEdgeEventPortType eventPortField;

        private refType refsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public eventEdgeComponentType component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public eventEdgeEventPortType eventPort {
            get {
                return this.eventPortField;
            }
            set {
                this.eventPortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public refType refs {
            get {
                return this.refsField;
            }
            set {
                this.refsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eventEdgeComponentType {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eventEdgeEventPortType {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class refType {

        private string componentIDField;

        private string portIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string componentID {
            get {
                return this.componentIDField;
            }
            set {
                this.componentIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string portID {
            get {
                return this.portIDField;
            }
            set {
                this.portIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eventChannelSourcesType {

        private eventEdge sourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public eventEdge source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eventChannel {       

        private string descriptionField;

        private eventChannelSourcesType sourcesField;

        private eventChannelTargetsType targetsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public eventChannelSourcesType sources {
            get {
                return this.sourcesField;
            }
            set {
                this.sourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public eventChannelTargetsType targets {
            get {
                return this.targetsField;
            }
            set {
                this.targetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class bindingEdgePortType {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class bindingEdgeComponentType {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class bindingEdge {

        private bindingEdgeComponentType componentField;

        private bindingEdgePortType portField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bindingEdgeComponentType component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bindingEdgePortType port {
            get {
                return this.portField;
            }
            set {
                this.portField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class channel {

        private string descriptionField;

        private bindingEdge sourceField;

        private bindingEdge targetField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bindingEdge source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bindingEdge target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class guiType {

        private string posXField;

        private string posYField;

        private string widthField;

        private string heightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string posX {
            get {
                return this.posXField;
            }
            set {
                this.posXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string posY {
            get {
                return this.posYField;
            }
            set {
                this.posYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string width {
            get {
                return this.widthField;
            }
            set {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string height {
            get {
                return this.heightField;
            }
            set {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class layoutType {

        private string posXField;

        private string posYField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string posX {
            get {
                return this.posXField;
            }
            set {
                this.posXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "integer")]
        public string posY {
            get {
                return this.posYField;
            }
            set {
                this.posYField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class outputPortType {

        private propertyType[] propertiesField;

        private refType refsField;

        private string portTypeIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("property", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        [Browsable(false)]
        public propertyType[] properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Browsable(false)]
        public refType refs {
            get {
                return this.refsField;
            }
            set {
                this.refsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [ReadOnly(true)]
        [DisplayName("Port Label")]
        [Category("ACSInternalProperty")]
        public string portTypeID {
            get {
                return this.portTypeIDField;
            }
            set {
                this.portTypeIDField = value;
            }
        }

       
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class propertyType {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [DisplayName("Property Name")]
        [ReadOnly(true)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [DisplayName("Value")]
        public string value {
            get {
                return this.valueField;
            }
            set {
                if (Validate(value)) {
                    this.valueField = value;
                    OnPropertyChanged(name);
                } else {
                    OnPropertyChangeError(name);
                }
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class inputPortType {

        private propertyType[] propertiesField;

        private refType refsField;

        private string portTypeIDField;

        private bool syncField;

        private bool syncFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("property", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        [Browsable(false)]
        public propertyType[] properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Browsable(false)]
        public refType refs {
            get {
                return this.refsField;
            }
            set {
                this.refsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [ReadOnly(true)]
        [DisplayName("Port Label")]
        [Category("ACSInternalProperty")]
        public string portTypeID {
            get {
                return this.portTypeIDField;
            }
            set {
                this.portTypeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [DisplayName("Synchronise Inputs")]
        [Category("ACSInternalProperty")]
        public bool sync {
            get {
                return this.syncField;
            }
            set {
                this.syncField = value;
                this.syncSpecified = true;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Browsable(false)]
        public bool syncSpecified {
            get {
                return this.syncFieldSpecified;
            }
            set {
                this.syncFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class componentType {

        private string descriptionField;

        private object[] portsField;

        private propertyType[] propertiesField;

        private layoutType layoutField;

        private guiType guiField;

        private string type_idField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [DisplayName("Component Name")]
        [Category(categoryComponent)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                OnPropertyChanged("Component Name");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        //[Browsable(false)]
        [DisplayName("Component Type")]
        [Category(categoryComponent)]
        [ReadOnly(true)]
        public string type_id {
            get {
                return this.type_idField;
            }
            set {
                this.type_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [DisplayName("Component Description")]
        [Category(categoryComponent)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                OnPropertyChanged("Component Description");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("inputPort", typeof(inputPortType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("outputPort", typeof(outputPortType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        [Browsable(false)]
        public object[] ports {
            get {
                return this.portsField;
            }
            set {
                this.portsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("property", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        [Browsable(false)]
        public propertyType[] properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Browsable(false)]
        public layoutType layout {
            get {
                return this.layoutField;
            }
            set {
                this.layoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Browsable(false)]
        public guiType gui {
            get {
                return this.guiField;
            }
            set {
                this.guiField = value;
            }
        }


    }



}