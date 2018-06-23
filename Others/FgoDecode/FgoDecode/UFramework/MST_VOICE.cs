using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_VOICE : IMessage, IMessage<MST_VOICE>, IEquatable<MST_VOICE>, IDeepCloneable<MST_VOICE>
	{
		public const int IdFieldNumber = 1;

		public const int PriorityFieldNumber = 2;

		public const int SvtVoiceTypeFieldNumber = 3;

		public const int NameFieldNumber = 4;

		public const int NameDefaultFieldNumber = 5;

		public const int CondTypeFieldNumber = 6;

		public const int CondValueFieldNumber = 7;

		public const int ClosedTypeFieldNumber = 8;

		private static readonly MessageParser<MST_VOICE> _parser = new MessageParser<MST_VOICE>(() => new MST_VOICE());

		private ByteString id_ = ByteString.Empty;

		private int priority_;

		private int svtVoiceType_;

		private ByteString name_ = ByteString.Empty;

		private ByteString nameDefault_ = ByteString.Empty;

		private int condType_;

		private int condValue_;

		private int closedType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_VOICE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_VOICE> Parser => MST_VOICE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstVoiceReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public ByteString Id
		{
			get => this.id_;
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int SvtVoiceType
		{
			get => this.svtVoiceType_;
			set
			{
				this.svtVoiceType_ = value;
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
		public ByteString NameDefault
		{
			get => this.nameDefault_;
			set
			{
				this.nameDefault_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int CondType
		{
			get => this.condType_;
			set
			{
				this.condType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondValue
		{
			get => this.condValue_;
			set
			{
				this.condValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ClosedType
		{
			get => this.closedType_;
			set
			{
				this.closedType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_VOICE()
		{
		}

		[DebuggerNonUserCode]
		public MST_VOICE(MST_VOICE other) : this()
		{
			this.id_ = other.id_;
			this.priority_ = other.priority_;
			this.svtVoiceType_ = other.svtVoiceType_;
			this.name_ = other.name_;
			this.nameDefault_ = other.nameDefault_;
			this.condType_ = other.condType_;
			this.condValue_ = other.condValue_;
			this.closedType_ = other.closedType_;
		}

		[DebuggerNonUserCode]
		public MST_VOICE Clone()
		{
			return new MST_VOICE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_VOICE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_VOICE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (!(this.Id != other.Id) && this.Priority == other.Priority && this.SvtVoiceType == other.SvtVoiceType && !(this.Name != other.Name) && !(this.NameDefault != other.NameDefault) && this.CondType == other.CondType && this.CondValue == other.CondValue && this.ClosedType == other.ClosedType));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.SvtVoiceType != 0)
			{
				num ^= this.SvtVoiceType.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.NameDefault.Length != 0)
			{
				num ^= this.NameDefault.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			if (this.CondValue != 0)
			{
				num ^= this.CondValue.GetHashCode();
			}
			if (this.ClosedType != 0)
			{
				num ^= this.ClosedType.GetHashCode();
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
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Id);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Priority);
			}
			if (this.SvtVoiceType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SvtVoiceType);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.Name);
			}
			if (this.NameDefault.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.NameDefault);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CondType);
			}
			if (this.CondValue != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CondValue);
			}
			if (this.ClosedType != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ClosedType);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Id);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.SvtVoiceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtVoiceType);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.NameDefault.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.NameDefault);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			if (this.CondValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue);
			}
			if (this.ClosedType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClosedType);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_VOICE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.SvtVoiceType != 0)
			{
				this.SvtVoiceType = other.SvtVoiceType;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.NameDefault.Length != 0)
			{
				this.NameDefault = other.NameDefault;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			if (other.CondValue != 0)
			{
				this.CondValue = other.CondValue;
			}
			if (other.ClosedType != 0)
			{
				this.ClosedType = other.ClosedType;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0u)
			{
				uint num2 = num;
				if (num2 != 10u)
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
											if (num2 != 64u)
											{
												input.SkipLastField();
											}
											else
											{
												this.ClosedType = input.ReadInt32();
											}
										}
										else
										{
											this.CondValue = input.ReadInt32();
										}
									}
									else
									{
										this.CondType = input.ReadInt32();
									}
								}
								else
								{
									this.NameDefault = input.ReadBytes();
								}
							}
							else
							{
								this.Name = input.ReadBytes();
							}
						}
						else
						{
							this.SvtVoiceType = input.ReadInt32();
						}
					}
					else
					{
						this.Priority = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadBytes();
				}
			}
		}
	}
}
