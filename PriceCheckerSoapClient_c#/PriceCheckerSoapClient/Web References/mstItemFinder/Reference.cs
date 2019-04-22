﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PriceCheckerSoapClient.mstItemFinder {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ItemFinderSoap11Binding", Namespace="http://mst")]
    public partial class ItemFinder : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback mainOperationCompleted;
        
        private System.Threading.SendOrPostCallback findItemsByBarcodeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ItemFinder() {
            this.Url = global::PriceCheckerSoapClient.Properties.Settings.Default.PriceCheckerSoapClient_mstItemFinder_ItemFinder;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event mainCompletedEventHandler mainCompleted;
        
        /// <remarks/>
        public event findItemsByBarcodeCompletedEventHandler findItemsByBarcodeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:main", RequestNamespace="http://mst", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void main([System.Xml.Serialization.XmlElementAttribute("args", IsNullable=true)] string[] args) {
            this.Invoke("main", new object[] {
                        args});
        }
        
        /// <remarks/>
        public void mainAsync(string[] args) {
            this.mainAsync(args, null);
        }
        
        /// <remarks/>
        public void mainAsync(string[] args, object userState) {
            if ((this.mainOperationCompleted == null)) {
                this.mainOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmainOperationCompleted);
            }
            this.InvokeAsync("main", new object[] {
                        args}, this.mainOperationCompleted, userState);
        }
        
        private void OnmainOperationCompleted(object arg) {
            if ((this.mainCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.mainCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:findItemsByBarcode", RequestNamespace="http://mst", ResponseNamespace="http://mst", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public ItemData[] findItemsByBarcode([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string barcode) {
            object[] results = this.Invoke("findItemsByBarcode", new object[] {
                        barcode});
            return ((ItemData[])(results[0]));
        }
        
        /// <remarks/>
        public void findItemsByBarcodeAsync(string barcode) {
            this.findItemsByBarcodeAsync(barcode, null);
        }
        
        /// <remarks/>
        public void findItemsByBarcodeAsync(string barcode, object userState) {
            if ((this.findItemsByBarcodeOperationCompleted == null)) {
                this.findItemsByBarcodeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindItemsByBarcodeOperationCompleted);
            }
            this.InvokeAsync("findItemsByBarcode", new object[] {
                        barcode}, this.findItemsByBarcodeOperationCompleted, userState);
        }
        
        private void OnfindItemsByBarcodeOperationCompleted(object arg) {
            if ((this.findItemsByBarcodeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findItemsByBarcodeCompleted(this, new findItemsByBarcodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mst/xsd")]
    public partial class ItemData {
        
        private ImageData itemImageField;
        
        private string itemMeasureField;
        
        private string itemNameField;
        
        private double itemPriceField;
        
        private bool itemPriceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ImageData itemImage {
            get {
                return this.itemImageField;
            }
            set {
                this.itemImageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string itemMeasure {
            get {
                return this.itemMeasureField;
            }
            set {
                this.itemMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string itemName {
            get {
                return this.itemNameField;
            }
            set {
                this.itemNameField = value;
            }
        }
        
        /// <remarks/>
        public double itemPrice {
            get {
                return this.itemPriceField;
            }
            set {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemPriceSpecified {
            get {
                return this.itemPriceFieldSpecified;
            }
            set {
                this.itemPriceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://mst/xsd")]
    public partial class ImageData {
        
        private string imageLocationField;
        
        private string imageStringDataField;
        
        private string imageTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string imageLocation {
            get {
                return this.imageLocationField;
            }
            set {
                this.imageLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string imageStringData {
            get {
                return this.imageStringDataField;
            }
            set {
                this.imageStringDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string imageType {
            get {
                return this.imageTypeField;
            }
            set {
                this.imageTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void mainCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void findItemsByBarcodeCompletedEventHandler(object sender, findItemsByBarcodeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findItemsByBarcodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findItemsByBarcodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ItemData[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ItemData[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591