﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SourceFEWSAdapter.SourceService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeSeriesResult", Namespace="http://schemas.datacontract.org/2004/07/RiverSystem.Services")]
    [System.SerializableAttribute()]
    public partial class TimeSeriesResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SourceFEWSAdapter.SourceService.TimedResult[] ReadingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnitsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SourceFEWSAdapter.SourceService.TimedResult[] Readings {
            get {
                return this.ReadingsField;
            }
            set {
                if ((object.ReferenceEquals(this.ReadingsField, value) != true)) {
                    this.ReadingsField = value;
                    this.RaisePropertyChanged("Readings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Units {
            get {
                return this.UnitsField;
            }
            set {
                if ((object.ReferenceEquals(this.UnitsField, value) != true)) {
                    this.UnitsField = value;
                    this.RaisePropertyChanged("Units");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimedResult", Namespace="http://schemas.datacontract.org/2004/07/RiverSystem.Services")]
    [System.SerializableAttribute()]
    public partial class TimedResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SourceService.IRiverSystemService", CallbackContract=typeof(SourceFEWSAdapter.SourceService.IRiverSystemServiceCallback))]
    public interface IRiverSystemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/SetReturnBaseSIUnits", ReplyAction="http://tempuri.org/IRiverSystemService/SetReturnBaseSIUnitsResponse")]
        bool SetReturnBaseSIUnits(bool useSIUnits);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/SetRestorable", ReplyAction="http://tempuri.org/IRiverSystemService/SetRestorableResponse")]
        string SetRestorable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/Restore", ReplyAction="http://tempuri.org/IRiverSystemService/RestoreResponse")]
        bool Restore(string restoreID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/Load", ReplyAction="http://tempuri.org/IRiverSystemService/LoadResponse")]
        bool Load(string projectName, string scenarioName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/SaveAs", ReplyAction="http://tempuri.org/IRiverSystemService/SaveAsResponse")]
        bool SaveAs(string projectNewName, string folderPath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetLoadedProject", ReplyAction="http://tempuri.org/IRiverSystemService/GetLoadedProjectResponse")]
        bool GetLoadedProject(out string projectName, out string scenarioName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/Run", ReplyAction="http://tempuri.org/IRiverSystemService/RunResponse")]
        bool Run();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/Step", ReplyAction="http://tempuri.org/IRiverSystemService/StepResponse")]
        bool Step();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetStep", ReplyAction="http://tempuri.org/IRiverSystemService/GetStepResponse")]
        bool GetStep(out int currentStep, out int totalSteps);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetMetaParameters", ReplyAction="http://tempuri.org/IRiverSystemService/GetMetaParametersResponse")]
        string[] GetMetaParameters();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/SetMetaParameterValue", ReplyAction="http://tempuri.org/IRiverSystemService/SetMetaParameterValueResponse")]
        bool SetMetaParameterValue(string parameterName, double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetAllTimeSeries", ReplyAction="http://tempuri.org/IRiverSystemService/GetAllTimeSeriesResponse")]
        SourceFEWSAdapter.SourceService.TimeSeriesResult[] GetAllTimeSeries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetTimeSeries", ReplyAction="http://tempuri.org/IRiverSystemService/GetTimeSeriesResponse")]
        SourceFEWSAdapter.SourceService.TimeSeriesResult GetTimeSeries(string parameterName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetTimeStepValue", ReplyAction="http://tempuri.org/IRiverSystemService/GetTimeStepValueResponse")]
        double GetTimeStepValue(string parameterName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/Reset", ReplyAction="http://tempuri.org/IRiverSystemService/ResetResponse")]
        bool Reset();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/Finish", ReplyAction="http://tempuri.org/IRiverSystemService/FinishResponse")]
        bool Finish();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/QueryProjectDescription", ReplyAction="http://tempuri.org/IRiverSystemService/QueryProjectDescriptionResponse")]
        string QueryProjectDescription(string xpath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetCurrentTime", ReplyAction="http://tempuri.org/IRiverSystemService/GetCurrentTimeResponse")]
        System.DateTime GetCurrentTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetTimeStep", ReplyAction="http://tempuri.org/IRiverSystemService/GetTimeStepResponse")]
        string GetTimeStep();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetProjectDescription", ReplyAction="http://tempuri.org/IRiverSystemService/GetProjectDescriptionResponse")]
        string GetProjectDescription();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetScenarioStartTime", ReplyAction="http://tempuri.org/IRiverSystemService/GetScenarioStartTimeResponse")]
        System.DateTime GetScenarioStartTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/SetScenarioStartTime", ReplyAction="http://tempuri.org/IRiverSystemService/SetScenarioStartTimeResponse")]
        bool SetScenarioStartTime(System.DateTime startTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/GetScenarioEndTime", ReplyAction="http://tempuri.org/IRiverSystemService/GetScenarioEndTimeResponse")]
        System.DateTime GetScenarioEndTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/SetScenarioEndTime", ReplyAction="http://tempuri.org/IRiverSystemService/SetScenarioEndTimeResponse")]
        bool SetScenarioEndTime(System.DateTime endTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRiverSystemService/SetScenarioInputSet", ReplyAction="http://tempuri.org/IRiverSystemService/SetScenarioInputSetResponse")]
        bool SetScenarioInputSet(string inputSet);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRiverSystemServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRiverSystemService/OnProgressChanged")]
        void OnProgressChanged(string stage, int progress);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRiverSystemService/OnError")]
        void OnError(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRiverSystemServiceChannel : SourceFEWSAdapter.SourceService.IRiverSystemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RiverSystemServiceClient : System.ServiceModel.DuplexClientBase<SourceFEWSAdapter.SourceService.IRiverSystemService>, SourceFEWSAdapter.SourceService.IRiverSystemService {
        
        public RiverSystemServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public RiverSystemServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public RiverSystemServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RiverSystemServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RiverSystemServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool SetReturnBaseSIUnits(bool useSIUnits) {
            return base.Channel.SetReturnBaseSIUnits(useSIUnits);
        }
        
        public string SetRestorable() {
            return base.Channel.SetRestorable();
        }
        
        public bool Restore(string restoreID) {
            return base.Channel.Restore(restoreID);
        }
        
        public bool Load(string projectName, string scenarioName) {
            return base.Channel.Load(projectName, scenarioName);
        }
        
        public bool SaveAs(string projectNewName, string folderPath) {
            return base.Channel.SaveAs(projectNewName, folderPath);
        }
        
        public bool GetLoadedProject(out string projectName, out string scenarioName) {
            return base.Channel.GetLoadedProject(out projectName, out scenarioName);
        }
        
        public bool Run() {
            return base.Channel.Run();
        }
        
        public bool Step() {
            return base.Channel.Step();
        }
        
        public bool GetStep(out int currentStep, out int totalSteps) {
            return base.Channel.GetStep(out currentStep, out totalSteps);
        }
        
        public string[] GetMetaParameters() {
            return base.Channel.GetMetaParameters();
        }
        
        public bool SetMetaParameterValue(string parameterName, double value) {
            return base.Channel.SetMetaParameterValue(parameterName, value);
        }
        
        public SourceFEWSAdapter.SourceService.TimeSeriesResult[] GetAllTimeSeries() {
            return base.Channel.GetAllTimeSeries();
        }
        
        public SourceFEWSAdapter.SourceService.TimeSeriesResult GetTimeSeries(string parameterName) {
            return base.Channel.GetTimeSeries(parameterName);
        }
        
        public double GetTimeStepValue(string parameterName) {
            return base.Channel.GetTimeStepValue(parameterName);
        }
        
        public bool Reset() {
            return base.Channel.Reset();
        }
        
        public bool Finish() {
            return base.Channel.Finish();
        }
        
        public string QueryProjectDescription(string xpath) {
            return base.Channel.QueryProjectDescription(xpath);
        }
        
        public System.DateTime GetCurrentTime() {
            return base.Channel.GetCurrentTime();
        }
        
        public string GetTimeStep() {
            return base.Channel.GetTimeStep();
        }
        
        public string GetProjectDescription() {
            return base.Channel.GetProjectDescription();
        }
        
        public System.DateTime GetScenarioStartTime() {
            return base.Channel.GetScenarioStartTime();
        }
        
        public bool SetScenarioStartTime(System.DateTime startTime) {
            return base.Channel.SetScenarioStartTime(startTime);
        }
        
        public System.DateTime GetScenarioEndTime() {
            return base.Channel.GetScenarioEndTime();
        }
        
        public bool SetScenarioEndTime(System.DateTime endTime) {
            return base.Channel.SetScenarioEndTime(endTime);
        }
        
        public bool SetScenarioInputSet(string inputSet) {
            return base.Channel.SetScenarioInputSet(inputSet);
        }
    }
}
