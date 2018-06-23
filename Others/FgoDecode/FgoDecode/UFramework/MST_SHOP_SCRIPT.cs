using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SHOP_SCRIPT : IMessage, IMessage<MST_SHOP_SCRIPT>, IEquatable<MST_SHOP_SCRIPT>, IDeepCloneable<MST_SHOP_SCRIPT>
	{
		public const int ShopIdFieldNumber = 1;

		public const int PriorityFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int ScriptIdFieldNumber = 4;

		public const int EventIdFieldNumber = 5;

		public const int SvtIdFieldNumber = 6;

		private static readonly MessageParser<MST_SHOP_SCRIPT> _parser = new MessageParser<MST_SHOP_SCRIPT>(() => new MST_SHOP_SCRIPT());

		private int shopId_;

		private int priority_;

		private ByteString name_ = ByteString.Empty;

		private ulong scriptId_;

		private int eventId_;

		private int svtId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SHOP_SCRIPT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SHOP_SCRIPT> Parser => MST_SHOP_SCRIPT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstShopScriptReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int ShopId
		{
			get => this.shopId_;
			set
			{
				this.shopId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Priority
		{
			get => this.priority_;
			set
			{
				this.priority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ulong ScriptId
		{
			get => this.scriptId_;
			set
			{
				this.scriptId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int EventId
		{
			get => this.eventId_;
			set
			{
				this.eventId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SvtId
		{
			get => this.svtId_;
			set
			{
				this.svtId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SHOP_SCRIPT()
		{
		}

		[DebuggerNonUserCode]
		public MST_SHOP_SCRIPT(MST_SHOP_SCRIPT other) : this()
		{
			this.shopId_ = other.shopId_;
			this.priority_ = other.priority_;
			this.name_ = other.name_;
			this.scriptId_ = other.scriptId_;
			this.eventId_ = other.eventId_;
			this.svtId_ = other.svtId_;
		}

		[DebuggerNonUserCode]
		public MST_SHOP_SCRIPT Clone()
		{
			return new MST_SHOP_SCRIPT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SHOP_SCRIPT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SHOP_SCRIPT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.ShopId == other.ShopId && this.Priority == other.Priority && !(this.Name != other.Name) && this.ScriptId == other.ScriptId && this.EventId == other.EventId && this.SvtId == other.SvtId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.ScriptId != 0uL)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Priority);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Name);
			}
			if (this.ScriptId != 0uL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ScriptId);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EventId);
			}
			if (this.SvtId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SvtId);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.ScriptId != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ScriptId);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SHOP_SCRIPT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.ScriptId != 0uL)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0u)
			{
				uint num2 = num;
				if (num2 != 8u)
				{
					if (num2 != 16u)
					{
						if (num2 != 26u)
						{
							if (num2 != 32u)
							{
								if (num2 != 40u)
								{
									if (num2 != 48u)
									{
										input.SkipLastField();
									}
									else
									{
										this.SvtId = input.ReadInt32();
									}
								}
								else
								{
									this.EventId = input.ReadInt32();
								}
							}
							else
							{
								this.ScriptId = input.ReadUInt64();
							}
						}
						else
						{
							this.Name = input.ReadBytes();
						}
					}
					else
					{
						this.Priority = input.ReadInt32();
					}
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}
	}
}
