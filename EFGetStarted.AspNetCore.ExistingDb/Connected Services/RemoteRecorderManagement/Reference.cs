﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemoteRecorderManagement
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationInfo", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    public partial class AuthenticationInfo : object
    {
        
        private string AuthCodeField;
        
        private string PasswordField;
        
        private string UserKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthCode
        {
            get
            {
                return this.AuthCodeField;
            }
            set
            {
                this.AuthCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserKey
        {
            get
            {
                return this.UserKeyField;
            }
            set
            {
                this.UserKeyField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RemoteRecorder", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V42.Soa" +
        "p")]
    public partial class RemoteRecorder : object
    {
        
        private RemoteRecorderManagement.RemoteRecorderDevice[] DevicesField;
        
        private string ExternalIdField;
        
        private System.Guid IdField;
        
        private string MachineIPField;
        
        private string NameField;
        
        private string PreviewUrlField;
        
        private System.Guid[] ScheduledRecordingsField;
        
        private string SettingsUrlField;
        
        private RemoteRecorderManagement.RemoteRecorderState StateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RemoteRecorderManagement.RemoteRecorderDevice[] Devices
        {
            get
            {
                return this.DevicesField;
            }
            set
            {
                this.DevicesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExternalId
        {
            get
            {
                return this.ExternalIdField;
            }
            set
            {
                this.ExternalIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MachineIP
        {
            get
            {
                return this.MachineIPField;
            }
            set
            {
                this.MachineIPField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PreviewUrl
        {
            get
            {
                return this.PreviewUrlField;
            }
            set
            {
                this.PreviewUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid[] ScheduledRecordings
        {
            get
            {
                return this.ScheduledRecordingsField;
            }
            set
            {
                this.ScheduledRecordingsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SettingsUrl
        {
            get
            {
                return this.SettingsUrlField;
            }
            set
            {
                this.SettingsUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RemoteRecorderManagement.RemoteRecorderState State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RemoteRecorderDevice", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    public partial class RemoteRecorderDevice : object
    {
        
        private RemoteRecorderManagement.RemoteRecorderDeviceType DeviceTypeField;
        
        private bool IsCapturingField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RemoteRecorderManagement.RemoteRecorderDeviceType DeviceType
        {
            get
            {
                return this.DeviceTypeField;
            }
            set
            {
                this.DeviceTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCapturing
        {
            get
            {
                return this.IsCapturingField;
            }
            set
            {
                this.IsCapturingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RemoteRecorderState", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    public enum RemoteRecorderState : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Stopped = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Previewing = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Recording = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Paused = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Faulted = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Disconnected = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Blocked = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RemoteRecorderDeviceType", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    public enum RemoteRecorderDeviceType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DV = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HDV = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Video = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Audio = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Screen = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Slide = 6,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pagination", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    public partial class Pagination : object
    {
        
        private int MaxNumberResultsField;
        
        private int PageNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxNumberResults
        {
            get
            {
                return this.MaxNumberResultsField;
            }
            set
            {
                this.MaxNumberResultsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageNumber
        {
            get
            {
                return this.PageNumberField;
            }
            set
            {
                this.PageNumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RecorderSortField", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    public enum RecorderSortField : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Name = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        State = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListRecordersResponse", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V42.Soa" +
        "p")]
    public partial class ListRecordersResponse : object
    {
        
        private RemoteRecorderManagement.RemoteRecorder[] PagedResultsField;
        
        private int TotalResultCountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RemoteRecorderManagement.RemoteRecorder[] PagedResults
        {
            get
            {
                return this.PagedResultsField;
            }
            set
            {
                this.PagedResultsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalResultCount
        {
            get
            {
                return this.TotalResultCountField;
            }
            set
            {
                this.TotalResultCountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RecorderSettings", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    public partial class RecorderSettings : object
    {
        
        private System.Guid RecorderIdField;
        
        private bool SuppressPrimaryField;
        
        private bool SuppressSecondaryField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid RecorderId
        {
            get
            {
                return this.RecorderIdField;
            }
            set
            {
                this.RecorderIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SuppressPrimary
        {
            get
            {
                return this.SuppressPrimaryField;
            }
            set
            {
                this.SuppressPrimaryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SuppressSecondary
        {
            get
            {
                return this.SuppressSecondaryField;
            }
            set
            {
                this.SuppressSecondaryField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScheduledRecordingResult", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V42.Soa" +
        "p")]
    public partial class ScheduledRecordingResult : object
    {
        
        private RemoteRecorderManagement.ScheduledRecordingInfo[] ConflictingSessionsField;
        
        private bool ConflictsExistField;
        
        private System.Guid[] SessionIDsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RemoteRecorderManagement.ScheduledRecordingInfo[] ConflictingSessions
        {
            get
            {
                return this.ConflictingSessionsField;
            }
            set
            {
                this.ConflictingSessionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ConflictsExist
        {
            get
            {
                return this.ConflictsExistField;
            }
            set
            {
                this.ConflictsExistField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid[] SessionIDs
        {
            get
            {
                return this.SessionIDsField;
            }
            set
            {
                this.SessionIDsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScheduledRecordingInfo", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V42.Soa" +
        "p")]
    public partial class ScheduledRecordingInfo : object
    {
        
        private System.DateTime EndTimeField;
        
        private System.Guid SessionIDField;
        
        private string SessionNameField;
        
        private System.DateTime StartTimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndTime
        {
            get
            {
                return this.EndTimeField;
            }
            set
            {
                this.EndTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid SessionID
        {
            get
            {
                return this.SessionIDField;
            }
            set
            {
                this.SessionIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionName
        {
            get
            {
                return this.SessionNameField;
            }
            set
            {
                this.SessionNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime
        {
            get
            {
                return this.StartTimeField;
            }
            set
            {
                this.StartTimeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteRecorderManagement.IRemoteRecorderManagement")]
    public interface IRemoteRecorderManagement
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/GetRemoteRecordersById", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/GetRemoteRecordersByIdResponse")]
        System.Threading.Tasks.Task<RemoteRecorderManagement.RemoteRecorder[]> GetRemoteRecordersByIdAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid[] remoteRecorderIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/GetRemoteRecordersByExternalId", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/GetRemoteRecordersByExternalIdRespon" +
            "se")]
        System.Threading.Tasks.Task<RemoteRecorderManagement.RemoteRecorder[]> GetRemoteRecordersByExternalIdAsync(RemoteRecorderManagement.AuthenticationInfo auth, string[] externalIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/UpdateRemoteRecorderExternalId", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/UpdateRemoteRecorderExternalIdRespon" +
            "se")]
        System.Threading.Tasks.Task UpdateRemoteRecorderExternalIdAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid remoteRecorderId, string externalId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/ListRecorders", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/ListRecordersResponse")]
        System.Threading.Tasks.Task<RemoteRecorderManagement.ListRecordersResponse> ListRecordersAsync(RemoteRecorderManagement.AuthenticationInfo auth, RemoteRecorderManagement.Pagination pagination, RemoteRecorderManagement.RecorderSortField sortBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/ScheduleRecording", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/ScheduleRecordingResponse")]
        System.Threading.Tasks.Task<RemoteRecorderManagement.ScheduledRecordingResult> ScheduleRecordingAsync(RemoteRecorderManagement.AuthenticationInfo auth, string name, System.Guid folderId, bool isBroadcast, System.DateTime start, System.DateTime end, RemoteRecorderManagement.RecorderSettings[] recorderSettings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/ScheduleRecurringRecording", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/ScheduleRecurringRecordingResponse")]
        System.Threading.Tasks.Task<RemoteRecorderManagement.ScheduledRecordingResult> ScheduleRecurringRecordingAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid scheduledSessionId, System.DayOfWeek[] daysOfWeek, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/UpdateRecordingTime", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/UpdateRecordingTimeResponse")]
        System.Threading.Tasks.Task<RemoteRecorderManagement.ScheduledRecordingResult> UpdateRecordingTimeAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid sessionId, System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/UpdateRecordingSettings", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/UpdateRecordingSettingsResponse")]
        System.Threading.Tasks.Task<RemoteRecorderManagement.ScheduledRecordingResult> UpdateRecordingSettingsAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid sessionId, RemoteRecorderManagement.RecorderSettings[] recorderSettings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/GetDefaultFolderForRecorder", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/GetDefaultFolderForRecorderResponse")]
        System.Threading.Tasks.Task<System.Guid> GetDefaultFolderForRecorderAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid remoteRecorderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRemoteRecorderManagement/GetMachineSidForRecorder", ReplyAction="http://tempuri.org/IRemoteRecorderManagement/GetMachineSidForRecorderResponse")]
        System.Threading.Tasks.Task<string> GetMachineSidForRecorderAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid remoteRecorderId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IRemoteRecorderManagementChannel : RemoteRecorderManagement.IRemoteRecorderManagement, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class RemoteRecorderManagementClient : System.ServiceModel.ClientBase<RemoteRecorderManagement.IRemoteRecorderManagement>, RemoteRecorderManagement.IRemoteRecorderManagement
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public RemoteRecorderManagementClient() : 
                base(RemoteRecorderManagementClient.GetDefaultBinding(), RemoteRecorderManagementClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpsBinding_IRemoteRecorderManagement.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RemoteRecorderManagementClient(EndpointConfiguration endpointConfiguration) : 
                base(RemoteRecorderManagementClient.GetBindingForEndpoint(endpointConfiguration), RemoteRecorderManagementClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RemoteRecorderManagementClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(RemoteRecorderManagementClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RemoteRecorderManagementClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(RemoteRecorderManagementClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RemoteRecorderManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<RemoteRecorderManagement.RemoteRecorder[]> GetRemoteRecordersByIdAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid[] remoteRecorderIds)
        {
            return base.Channel.GetRemoteRecordersByIdAsync(auth, remoteRecorderIds);
        }
        
        public System.Threading.Tasks.Task<RemoteRecorderManagement.RemoteRecorder[]> GetRemoteRecordersByExternalIdAsync(RemoteRecorderManagement.AuthenticationInfo auth, string[] externalIds)
        {
            return base.Channel.GetRemoteRecordersByExternalIdAsync(auth, externalIds);
        }
        
        public System.Threading.Tasks.Task UpdateRemoteRecorderExternalIdAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid remoteRecorderId, string externalId)
        {
            return base.Channel.UpdateRemoteRecorderExternalIdAsync(auth, remoteRecorderId, externalId);
        }
        
        public System.Threading.Tasks.Task<RemoteRecorderManagement.ListRecordersResponse> ListRecordersAsync(RemoteRecorderManagement.AuthenticationInfo auth, RemoteRecorderManagement.Pagination pagination, RemoteRecorderManagement.RecorderSortField sortBy)
        {
            return base.Channel.ListRecordersAsync(auth, pagination, sortBy);
        }
        
        public System.Threading.Tasks.Task<RemoteRecorderManagement.ScheduledRecordingResult> ScheduleRecordingAsync(RemoteRecorderManagement.AuthenticationInfo auth, string name, System.Guid folderId, bool isBroadcast, System.DateTime start, System.DateTime end, RemoteRecorderManagement.RecorderSettings[] recorderSettings)
        {
            return base.Channel.ScheduleRecordingAsync(auth, name, folderId, isBroadcast, start, end, recorderSettings);
        }
        
        public System.Threading.Tasks.Task<RemoteRecorderManagement.ScheduledRecordingResult> ScheduleRecurringRecordingAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid scheduledSessionId, System.DayOfWeek[] daysOfWeek, System.DateTime end)
        {
            return base.Channel.ScheduleRecurringRecordingAsync(auth, scheduledSessionId, daysOfWeek, end);
        }
        
        public System.Threading.Tasks.Task<RemoteRecorderManagement.ScheduledRecordingResult> UpdateRecordingTimeAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid sessionId, System.DateTime start, System.DateTime end)
        {
            return base.Channel.UpdateRecordingTimeAsync(auth, sessionId, start, end);
        }
        
        public System.Threading.Tasks.Task<RemoteRecorderManagement.ScheduledRecordingResult> UpdateRecordingSettingsAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid sessionId, RemoteRecorderManagement.RecorderSettings[] recorderSettings)
        {
            return base.Channel.UpdateRecordingSettingsAsync(auth, sessionId, recorderSettings);
        }
        
        public System.Threading.Tasks.Task<System.Guid> GetDefaultFolderForRecorderAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid remoteRecorderId)
        {
            return base.Channel.GetDefaultFolderForRecorderAsync(auth, remoteRecorderId);
        }
        
        public System.Threading.Tasks.Task<string> GetMachineSidForRecorderAsync(RemoteRecorderManagement.AuthenticationInfo auth, System.Guid remoteRecorderId)
        {
            return base.Channel.GetMachineSidForRecorderAsync(auth, remoteRecorderId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IRemoteRecorderManagement))
            {
                System.ServiceModel.BasicHttpsBinding result = new System.ServiceModel.BasicHttpsBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IRemoteRecorderManagement))
            {
                return new System.ServiceModel.EndpointAddress("https://pitt.hosted.panopto.com/Panopto/PublicAPI/4.2/RemoteRecorderManagement.svc" +
                        "");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return RemoteRecorderManagementClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpsBinding_IRemoteRecorderManagement);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return RemoteRecorderManagementClient.GetEndpointAddress(EndpointConfiguration.BasicHttpsBinding_IRemoteRecorderManagement);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpsBinding_IRemoteRecorderManagement,
        }
    }
}
