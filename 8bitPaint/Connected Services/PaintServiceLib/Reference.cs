﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _8bitPaint.PaintServiceLib {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaintServiceLib.IPaintService")]
    public interface IPaintService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/ReturnPath", ReplyAction="http://tempuri.org/IPaintService/ReturnPathResponse")]
        string ReturnPath();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/ReturnPath", ReplyAction="http://tempuri.org/IPaintService/ReturnPathResponse")]
        System.Threading.Tasks.Task<string> ReturnPathAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/HasUpdate", ReplyAction="http://tempuri.org/IPaintService/HasUpdateResponse")]
        bool HasUpdate(int version);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/HasUpdate", ReplyAction="http://tempuri.org/IPaintService/HasUpdateResponse")]
        System.Threading.Tasks.Task<bool> HasUpdateAsync(int version);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetAllCountPicture", ReplyAction="http://tempuri.org/IPaintService/GetAllCountPictureResponse")]
        int GetAllCountPicture(string category, bool isPng);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetAllCountPicture", ReplyAction="http://tempuri.org/IPaintService/GetAllCountPictureResponse")]
        System.Threading.Tasks.Task<int> GetAllCountPictureAsync(string category, bool isPng);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/Download8BP", ReplyAction="http://tempuri.org/IPaintService/Download8BPResponse")]
        byte[] Download8BP();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/Download8BP", ReplyAction="http://tempuri.org/IPaintService/Download8BPResponse")]
        System.Threading.Tasks.Task<byte[]> Download8BPAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetInfoMyFile", ReplyAction="http://tempuri.org/IPaintService/GetInfoMyFileResponse")]
        string[] GetInfoMyFile(string category, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetInfoMyFile", ReplyAction="http://tempuri.org/IPaintService/GetInfoMyFileResponse")]
        System.Threading.Tasks.Task<string[]> GetInfoMyFileAsync(string category, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetAllMyFiles", ReplyAction="http://tempuri.org/IPaintService/GetAllMyFilesResponse")]
        string[] GetAllMyFiles(string category, string uniqueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetAllMyFiles", ReplyAction="http://tempuri.org/IPaintService/GetAllMyFilesResponse")]
        System.Threading.Tasks.Task<string[]> GetAllMyFilesAsync(string category, string uniqueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetNewPictures", ReplyAction="http://tempuri.org/IPaintService/GetNewPicturesResponse")]
        _8bitPaint.PaintServiceLib.GetNewPicturesResponse GetNewPictures(_8bitPaint.PaintServiceLib.GetNewPicturesRequest request);
        
        // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetNewPictures", ReplyAction="http://tempuri.org/IPaintService/GetNewPicturesResponse")]
        System.Threading.Tasks.Task<_8bitPaint.PaintServiceLib.GetNewPicturesResponse> GetNewPicturesAsync(_8bitPaint.PaintServiceLib.GetNewPicturesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/IsDeletePictures", ReplyAction="http://tempuri.org/IPaintService/IsDeletePicturesResponse")]
        bool IsDeletePictures(string namePictures, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/IsDeletePictures", ReplyAction="http://tempuri.org/IPaintService/IsDeletePicturesResponse")]
        System.Threading.Tasks.Task<bool> IsDeletePicturesAsync(string namePictures, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetInfoUpdatesText", ReplyAction="http://tempuri.org/IPaintService/GetInfoUpdatesTextResponse")]
        string[] GetInfoUpdatesText();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetInfoUpdatesText", ReplyAction="http://tempuri.org/IPaintService/GetInfoUpdatesTextResponse")]
        System.Threading.Tasks.Task<string[]> GetInfoUpdatesTextAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetInfoNewsText", ReplyAction="http://tempuri.org/IPaintService/GetInfoNewsTextResponse")]
        string[] GetInfoNewsText();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetInfoNewsText", ReplyAction="http://tempuri.org/IPaintService/GetInfoNewsTextResponse")]
        System.Threading.Tasks.Task<string[]> GetInfoNewsTextAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetAllCategories", ReplyAction="http://tempuri.org/IPaintService/GetAllCategoriesResponse")]
        string[] GetAllCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetAllCategories", ReplyAction="http://tempuri.org/IPaintService/GetAllCategoriesResponse")]
        System.Threading.Tasks.Task<string[]> GetAllCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/DownloadFile", ReplyAction="http://tempuri.org/IPaintService/DownloadFileResponse")]
        byte[] DownloadFile(string name, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/DownloadFile", ReplyAction="http://tempuri.org/IPaintService/DownloadFileResponse")]
        System.Threading.Tasks.Task<byte[]> DownloadFileAsync(string name, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetUpdatePicture", ReplyAction="http://tempuri.org/IPaintService/GetUpdatePictureResponse")]
        byte[][] GetUpdatePicture(string version, string name, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GetUpdatePicture", ReplyAction="http://tempuri.org/IPaintService/GetUpdatePictureResponse")]
        System.Threading.Tasks.Task<byte[][]> GetUpdatePictureAsync(string version, string name, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GenerateUniqeID", ReplyAction="http://tempuri.org/IPaintService/GenerateUniqeIDResponse")]
        string GenerateUniqeID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/GenerateUniqeID", ReplyAction="http://tempuri.org/IPaintService/GenerateUniqeIDResponse")]
        System.Threading.Tasks.Task<string> GenerateUniqeIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/WritePicture", ReplyAction="http://tempuri.org/IPaintService/WritePictureResponse")]
        _8bitPaint.PaintServiceLib.WritePictureResponse WritePicture(_8bitPaint.PaintServiceLib.WritePictureRequest request);
        
        // CODEGEN: Идет формирование контракта на сообщение, так как операция может иметь много возвращаемых значений.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/WritePicture", ReplyAction="http://tempuri.org/IPaintService/WritePictureResponse")]
        System.Threading.Tasks.Task<_8bitPaint.PaintServiceLib.WritePictureResponse> WritePictureAsync(_8bitPaint.PaintServiceLib.WritePictureRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/HasFile", ReplyAction="http://tempuri.org/IPaintService/HasFileResponse")]
        bool HasFile(string category, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaintService/HasFile", ReplyAction="http://tempuri.org/IPaintService/HasFileResponse")]
        System.Threading.Tasks.Task<bool> HasFileAsync(string category, string name);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNewPictures", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetNewPicturesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string[] namePictures;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] idPictures;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string category;
        
        public GetNewPicturesRequest() {
        }
        
        public GetNewPicturesRequest(string[] namePictures, string[] idPictures, string category) {
            this.namePictures = namePictures;
            this.idPictures = idPictures;
            this.category = category;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNewPicturesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetNewPicturesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public byte[][] GetNewPicturesResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] namePictures;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string[] idPictures;
        
        public GetNewPicturesResponse() {
        }
        
        public GetNewPicturesResponse(byte[][] GetNewPicturesResult, string[] namePictures, string[] idPictures) {
            this.GetNewPicturesResult = GetNewPicturesResult;
            this.namePictures = namePictures;
            this.idPictures = idPictures;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WritePicture", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class WritePictureRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public byte[] getFile;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string filename;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string author;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string dicruption;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string category;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public bool isBin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string uniqueId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public int state;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        public string info_get;
        
        public WritePictureRequest() {
        }
        
        public WritePictureRequest(byte[] getFile, string filename, string author, string dicruption, string category, bool isBin, string uniqueId, int state, string info_get) {
            this.getFile = getFile;
            this.filename = filename;
            this.author = author;
            this.dicruption = dicruption;
            this.category = category;
            this.isBin = isBin;
            this.uniqueId = uniqueId;
            this.state = state;
            this.info_get = info_get;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WritePictureResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class WritePictureResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string info_get;
        
        public WritePictureResponse() {
        }
        
        public WritePictureResponse(string info_get) {
            this.info_get = info_get;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaintServiceChannel : _8bitPaint.PaintServiceLib.IPaintService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaintServiceClient : System.ServiceModel.ClientBase<_8bitPaint.PaintServiceLib.IPaintService>, _8bitPaint.PaintServiceLib.IPaintService {
        
        public PaintServiceClient() {
        }
        
        public PaintServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaintServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaintServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaintServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ReturnPath() {
            return base.Channel.ReturnPath();
        }
        
        public System.Threading.Tasks.Task<string> ReturnPathAsync() {
            return base.Channel.ReturnPathAsync();
        }
        
        public bool HasUpdate(int version) {
            return base.Channel.HasUpdate(version);
        }
        
        public System.Threading.Tasks.Task<bool> HasUpdateAsync(int version) {
            return base.Channel.HasUpdateAsync(version);
        }
        
        public int GetAllCountPicture(string category, bool isPng) {
            return base.Channel.GetAllCountPicture(category, isPng);
        }
        
        public System.Threading.Tasks.Task<int> GetAllCountPictureAsync(string category, bool isPng) {
            return base.Channel.GetAllCountPictureAsync(category, isPng);
        }
        
        public byte[] Download8BP() {
            return base.Channel.Download8BP();
        }
        
        public System.Threading.Tasks.Task<byte[]> Download8BPAsync() {
            return base.Channel.Download8BPAsync();
        }
        
        public string[] GetInfoMyFile(string category, string name) {
            return base.Channel.GetInfoMyFile(category, name);
        }
        
        public System.Threading.Tasks.Task<string[]> GetInfoMyFileAsync(string category, string name) {
            return base.Channel.GetInfoMyFileAsync(category, name);
        }
        
        public string[] GetAllMyFiles(string category, string uniqueId) {
            return base.Channel.GetAllMyFiles(category, uniqueId);
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllMyFilesAsync(string category, string uniqueId) {
            return base.Channel.GetAllMyFilesAsync(category, uniqueId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _8bitPaint.PaintServiceLib.GetNewPicturesResponse _8bitPaint.PaintServiceLib.IPaintService.GetNewPictures(_8bitPaint.PaintServiceLib.GetNewPicturesRequest request) {
            return base.Channel.GetNewPictures(request);
        }
        
        public byte[][] GetNewPictures(ref string[] namePictures, ref string[] idPictures, string category) {
            _8bitPaint.PaintServiceLib.GetNewPicturesRequest inValue = new _8bitPaint.PaintServiceLib.GetNewPicturesRequest();
            inValue.namePictures = namePictures;
            inValue.idPictures = idPictures;
            inValue.category = category;
            _8bitPaint.PaintServiceLib.GetNewPicturesResponse retVal = ((_8bitPaint.PaintServiceLib.IPaintService)(this)).GetNewPictures(inValue);
            namePictures = retVal.namePictures;
            idPictures = retVal.idPictures;
            return retVal.GetNewPicturesResult;
        }
        
        public System.Threading.Tasks.Task<_8bitPaint.PaintServiceLib.GetNewPicturesResponse> GetNewPicturesAsync(_8bitPaint.PaintServiceLib.GetNewPicturesRequest request) {
            return base.Channel.GetNewPicturesAsync(request);
        }
        
        public bool IsDeletePictures(string namePictures, string category) {
            return base.Channel.IsDeletePictures(namePictures, category);
        }
        
        public System.Threading.Tasks.Task<bool> IsDeletePicturesAsync(string namePictures, string category) {
            return base.Channel.IsDeletePicturesAsync(namePictures, category);
        }
        
        public string[] GetInfoUpdatesText() {
            return base.Channel.GetInfoUpdatesText();
        }
        
        public System.Threading.Tasks.Task<string[]> GetInfoUpdatesTextAsync() {
            return base.Channel.GetInfoUpdatesTextAsync();
        }
        
        public string[] GetInfoNewsText() {
            return base.Channel.GetInfoNewsText();
        }
        
        public System.Threading.Tasks.Task<string[]> GetInfoNewsTextAsync() {
            return base.Channel.GetInfoNewsTextAsync();
        }
        
        public string[] GetAllCategories() {
            return base.Channel.GetAllCategories();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllCategoriesAsync() {
            return base.Channel.GetAllCategoriesAsync();
        }
        
        public byte[] DownloadFile(string name, string category) {
            return base.Channel.DownloadFile(name, category);
        }
        
        public System.Threading.Tasks.Task<byte[]> DownloadFileAsync(string name, string category) {
            return base.Channel.DownloadFileAsync(name, category);
        }
        
        public byte[][] GetUpdatePicture(string version, string name, string category) {
            return base.Channel.GetUpdatePicture(version, name, category);
        }
        
        public System.Threading.Tasks.Task<byte[][]> GetUpdatePictureAsync(string version, string name, string category) {
            return base.Channel.GetUpdatePictureAsync(version, name, category);
        }
        
        public string GenerateUniqeID() {
            return base.Channel.GenerateUniqeID();
        }
        
        public System.Threading.Tasks.Task<string> GenerateUniqeIDAsync() {
            return base.Channel.GenerateUniqeIDAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        _8bitPaint.PaintServiceLib.WritePictureResponse _8bitPaint.PaintServiceLib.IPaintService.WritePicture(_8bitPaint.PaintServiceLib.WritePictureRequest request) {
            return base.Channel.WritePicture(request);
        }
        
        public void WritePicture(byte[] getFile, string filename, string author, string dicruption, string category, bool isBin, string uniqueId, int state, ref string info_get) {
            _8bitPaint.PaintServiceLib.WritePictureRequest inValue = new _8bitPaint.PaintServiceLib.WritePictureRequest();
            inValue.getFile = getFile;
            inValue.filename = filename;
            inValue.author = author;
            inValue.dicruption = dicruption;
            inValue.category = category;
            inValue.isBin = isBin;
            inValue.uniqueId = uniqueId;
            inValue.state = state;
            inValue.info_get = info_get;
            _8bitPaint.PaintServiceLib.WritePictureResponse retVal = ((_8bitPaint.PaintServiceLib.IPaintService)(this)).WritePicture(inValue);
            info_get = retVal.info_get;
        }
        
        public System.Threading.Tasks.Task<_8bitPaint.PaintServiceLib.WritePictureResponse> WritePictureAsync(_8bitPaint.PaintServiceLib.WritePictureRequest request) {
            return base.Channel.WritePictureAsync(request);
        }
        
        public bool HasFile(string category, string name) {
            return base.Channel.HasFile(category, name);
        }
        
        public System.Threading.Tasks.Task<bool> HasFileAsync(string category, string name) {
            return base.Channel.HasFileAsync(category, name);
        }
    }
}
