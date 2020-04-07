using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "CreateChatRoomResponse")]
	[Serializable]
	public class CreateChatRoomResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private SKBuiltinString_t _Topic;

		private SKBuiltinString_t _PYInitial;

		private SKBuiltinString_t _QuanPin;

		private uint _MemberCount;

		private readonly List<MemberResp> _MemberList = new List<MemberResp>();

		private SKBuiltinString_t _ChatRoomName;

		private SKBuiltinBuffer_t _ImgBuf;

		private string _BigHeadImgUrl = "";

		private string _SmallHeadImgUrl = "";

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

		[ProtoMember(2, IsRequired = true, Name = "Topic", DataFormat = DataFormat.Default)]
		public SKBuiltinString_t Topic
		{
			get
			{
				return this._Topic;
			}
			set
			{
				this._Topic = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "PYInitial", DataFormat = DataFormat.Default)]
		public SKBuiltinString_t PYInitial
		{
			get
			{
				return this._PYInitial;
			}
			set
			{
				this._PYInitial = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "QuanPin", DataFormat = DataFormat.Default)]
		public SKBuiltinString_t QuanPin
		{
			get
			{
				return this._QuanPin;
			}
			set
			{
				this._QuanPin = value;
			}
		}

		[ProtoMember(5, IsRequired = true, Name = "MemberCount", DataFormat = DataFormat.TwosComplement)]
		public uint MemberCount
		{
			get
			{
				return this._MemberCount;
			}
			set
			{
				this._MemberCount = value;
			}
		}

		[ProtoMember(6, Name = "MemberList", DataFormat = DataFormat.Default)]
		public List<MemberResp> MemberList
		{
			get
			{
				return this._MemberList;
			}
		}

		[ProtoMember(7, IsRequired = true, Name = "ChatRoomName", DataFormat = DataFormat.Default)]
		public SKBuiltinString_t ChatRoomName
		{
			get
			{
				return this._ChatRoomName;
			}
			set
			{
				this._ChatRoomName = value;
			}
		}

		[ProtoMember(8, IsRequired = true, Name = "ImgBuf", DataFormat = DataFormat.Default)]
		public SKBuiltinBuffer_t ImgBuf
		{
			get
			{
				return this._ImgBuf;
			}
			set
			{
				this._ImgBuf = value;
			}
		}

		[ProtoMember(9, IsRequired = false, Name = "BigHeadImgUrl", DataFormat = DataFormat.Default), DefaultValue("")]
		public string BigHeadImgUrl
		{
			get
			{
				return this._BigHeadImgUrl;
			}
			set
			{
				this._BigHeadImgUrl = value;
			}
		}

		[ProtoMember(10, IsRequired = false, Name = "SmallHeadImgUrl", DataFormat = DataFormat.Default), DefaultValue("")]
		public string SmallHeadImgUrl
		{
			get
			{
				return this._SmallHeadImgUrl;
			}
			set
			{
				this._SmallHeadImgUrl = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
