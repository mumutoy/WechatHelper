using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "CheckCanSubscribeBizResponse")]
	[Serializable]
	public class CheckCanSubscribeBizResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private string _CheckTicket = "";

		private string _ToUserName = "";

		private string _WebViewUrl = "";

		private string _ShowWord = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "CheckTicket", DataFormat = DataFormat.Default), DefaultValue("")]
		public string CheckTicket
		{
			get
			{
				return this._CheckTicket;
			}
			set
			{
				this._CheckTicket = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "ToUserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string ToUserName
		{
			get
			{
				return this._ToUserName;
			}
			set
			{
				this._ToUserName = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "WebViewUrl", DataFormat = DataFormat.Default), DefaultValue("")]
		public string WebViewUrl
		{
			get
			{
				return this._WebViewUrl;
			}
			set
			{
				this._WebViewUrl = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "ShowWord", DataFormat = DataFormat.Default), DefaultValue("")]
		public string ShowWord
		{
			get
			{
				return this._ShowWord;
			}
			set
			{
				this._ShowWord = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
