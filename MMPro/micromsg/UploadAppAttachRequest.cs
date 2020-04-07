using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "UploadAppAttachRequest")]
	[Serializable]
	public class UploadAppAttachRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private string _AppId = "";

		private uint _SdkVersion;

		private string _ClientAppDataId = "";

		private string _UserName = "";

		private uint _TotalLen;

		private uint _StartPos;

		private uint _DataLen;

		private SKBuiltinBuffer_t _Data;

		private uint _Type = 0u;

		private string _MD5 = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
		public BaseRequest BaseRequest
		{
			get
			{
				return this._BaseRequest;
			}
			set
			{
				this._BaseRequest = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "AppId", DataFormat = DataFormat.Default), DefaultValue("")]
		public string AppId
		{
			get
			{
				return this._AppId;
			}
			set
			{
				this._AppId = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "SdkVersion", DataFormat = DataFormat.TwosComplement)]
		public uint SdkVersion
		{
			get
			{
				return this._SdkVersion;
			}
			set
			{
				this._SdkVersion = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "ClientAppDataId", DataFormat = DataFormat.Default), DefaultValue("")]
		public string ClientAppDataId
		{
			get
			{
				return this._ClientAppDataId;
			}
			set
			{
				this._ClientAppDataId = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "UserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				this._UserName = value;
			}
		}

		[ProtoMember(6, IsRequired = true, Name = "TotalLen", DataFormat = DataFormat.TwosComplement)]
		public uint TotalLen
		{
			get
			{
				return this._TotalLen;
			}
			set
			{
				this._TotalLen = value;
			}
		}

		[ProtoMember(7, IsRequired = true, Name = "StartPos", DataFormat = DataFormat.TwosComplement)]
		public uint StartPos
		{
			get
			{
				return this._StartPos;
			}
			set
			{
				this._StartPos = value;
			}
		}

		[ProtoMember(8, IsRequired = true, Name = "DataLen", DataFormat = DataFormat.TwosComplement)]
		public uint DataLen
		{
			get
			{
				return this._DataLen;
			}
			set
			{
				this._DataLen = value;
			}
		}

		[ProtoMember(9, IsRequired = true, Name = "Data", DataFormat = DataFormat.Default)]
		public SKBuiltinBuffer_t Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				this._Data = value;
			}
		}

		[ProtoMember(10, IsRequired = false, Name = "Type", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				this._Type = value;
			}
		}

		[ProtoMember(11, IsRequired = false, Name = "MD5", DataFormat = DataFormat.Default), DefaultValue("")]
		public string MD5
		{
			get
			{
				return this._MD5;
			}
			set
			{
				this._MD5 = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
