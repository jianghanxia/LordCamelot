using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_FUNC_GROUP : IMessage, IMessage<MST_FUNC_GROUP>, IEquatable<MST_FUNC_GROUP>, IDeepCloneable<MST_FUNC_GROUP>
	{
		public const int FuncIdFieldNumber = 1;

		public const int EventIdFieldNumber = 2;

		public const int BaseFuncIdFieldNumber = 3;

		public const int NameTotalFieldNumber = 4;

		public const int NameFieldNumber = 5;

		public const int PriorityFieldNumber = 6;

		public const int IsDispValueFieldNumber = 7;

		private static readonly MessageParser<MST_FUNC_GROUP> _parser = new MessageParser<MST_FUNC_GROUP>(() => new MST_FUNC_GROUP());

		private int funcId_;

		private int eventId_;

		private int baseFuncId_;

		private ByteString nameTotal_ = ByteString.Empty;

		private ByteString name_ = ByteString.Empty;

		private int priority_;

		private int isDispValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_FUNC_GROUP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_FUNC_GROUP> Parser => MST_FUNC_GROUP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstFuncGroupReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int FuncId
		{
			get => this.funcId_;
			set
			{
				this.funcId_ = value;
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
		public int BaseFuncId
		{
			get => this.baseFuncId_;
			set
			{
				this.baseFuncId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString NameTotal
		{
			get => this.nameTotal_;
			set
			{
				this.nameTotal_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int Priority
		{
			get => this.priority_;
			set
			{
				this.priority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IsDispValue
		{
			get => this.isDispValue_;
			set
			{
				this.isDispValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_FUNC_GROUP()
		{
		}

		[DebuggerNonUserCode]
		public MST_FUNC_GROUP(MST_FUNC_GROUP other) : this()
		{
			this.funcId_ = other.funcId_;
			this.eventId_ = other.eventId_;
			this.baseFuncId_ = other.baseFuncId_;
			this.nameTotal_ = other.nameTotal_;
			this.name_ = other.name_;
			this.priority_ = other.priority_;
			this.isDispValue_ = other.isDispValue_;
		}

		[DebuggerNonUserCode]
		public MST_FUNC_GROUP Clone()
		{
			return new MST_FUNC_GROUP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_FUNC_GROUP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_FUNC_GROUP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.FuncId == other.FuncId && this.EventId == other.EventId && this.BaseFuncId == other.BaseFuncId && !(this.NameTotal != other.NameTotal) && !(this.Name != other.Name) && this.Priority == other.Priority && this.IsDispValue == other.IsDispValue));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncId != 0)
			{
				num ^= this.FuncId.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.BaseFuncId != 0)
			{
				num ^= this.BaseFuncId.GetHashCode();
			}
			if (this.NameTotal.Length != 0)
			{
				num ^= this.NameTotal.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.IsDispValue != 0)
			{
				num ^= this.IsDispValue.GetHashCode();
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
			if (this.FuncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FuncId);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventId);
			}
			if (this.BaseFuncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BaseFuncId);
			}
			if (this.NameTotal.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.NameTotal);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.Name);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Priority);
			}
			if (this.IsDispValue != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IsDispValue);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncId);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.BaseFuncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseFuncId);
			}
			if (this.NameTotal.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.NameTotal);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.IsDispValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsDispValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_FUNC_GROUP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncId != 0)
			{
				this.FuncId = other.FuncId;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.BaseFuncId != 0)
			{
				this.BaseFuncId = other.BaseFuncId;
			}
			if (other.NameTotal.Length != 0)
			{
				this.NameTotal = other.NameTotal;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.IsDispValue != 0)
			{
				this.IsDispValue = other.IsDispValue;
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
						if (num2 != 24u)
						{
							if (num2 != 34u)
							{
								if (num2 != 42u)
								{
									if (num2 != 48u)
									{
										if (num2 != 56u)
										{
											input.SkipLastField();
										}
										else
										{
											this.IsDispValue = input.ReadInt32();
										}
									}
									else
									{
										this.Priority = input.ReadInt32();
									}
								}
								else
								{
									this.Name = input.ReadBytes();
								}
							}
							else
							{
								this.NameTotal = input.ReadBytes();
							}
						}
						else
						{
							this.BaseFuncId = input.ReadInt32();
						}
					}
					else
					{
						this.EventId = input.ReadInt32();
					}
				}
				else
				{
					this.FuncId = input.ReadInt32();
				}
			}
		}
	}
}
