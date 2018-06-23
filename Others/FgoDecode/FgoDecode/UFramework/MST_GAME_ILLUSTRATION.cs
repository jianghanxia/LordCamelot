using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_GAME_ILLUSTRATION : IMessage, IMessage<MST_GAME_ILLUSTRATION>, IEquatable<MST_GAME_ILLUSTRATION>, IDeepCloneable<MST_GAME_ILLUSTRATION>
	{
		public const int TitleNameFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		public const int NumFieldNumber = 3;

		public const int LabelNameFieldNumber = 4;

		public const int DetialFieldNumber = 5;

		private static readonly MessageParser<MST_GAME_ILLUSTRATION> _parser = new MessageParser<MST_GAME_ILLUSTRATION>(() => new MST_GAME_ILLUSTRATION());

		private ByteString titleName_ = ByteString.Empty;

		private int type_;

		private int num_;

		private ByteString labelName_ = ByteString.Empty;

		private ByteString detial_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_GAME_ILLUSTRATION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_GAME_ILLUSTRATION> Parser => MST_GAME_ILLUSTRATION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstGameIllustrationReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public ByteString TitleName
		{
			get => this.titleName_;
			set
			{
				this.titleName_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Num
		{
			get => this.num_;
			set
			{
				this.num_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString LabelName
		{
			get => this.labelName_;
			set
			{
				this.labelName_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString Detial
		{
			get => this.detial_;
			set
			{
				this.detial_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_GAME_ILLUSTRATION()
		{
		}

		[DebuggerNonUserCode]
		public MST_GAME_ILLUSTRATION(MST_GAME_ILLUSTRATION other) : this()
		{
			this.titleName_ = other.titleName_;
			this.type_ = other.type_;
			this.num_ = other.num_;
			this.labelName_ = other.labelName_;
			this.detial_ = other.detial_;
		}

		[DebuggerNonUserCode]
		public MST_GAME_ILLUSTRATION Clone()
		{
			return new MST_GAME_ILLUSTRATION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_GAME_ILLUSTRATION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_GAME_ILLUSTRATION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (!(this.TitleName != other.TitleName) && this.Type == other.Type && this.Num == other.Num && !(this.LabelName != other.LabelName) && !(this.Detial != other.Detial)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TitleName.Length != 0)
			{
				num ^= this.TitleName.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.LabelName.Length != 0)
			{
				num ^= this.LabelName.GetHashCode();
			}
			if (this.Detial.Length != 0)
			{
				num ^= this.Detial.GetHashCode();
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
			if (this.TitleName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.TitleName);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Num);
			}
			if (this.LabelName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.LabelName);
			}
			if (this.Detial.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.Detial);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TitleName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.TitleName);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.LabelName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.LabelName);
			}
			if (this.Detial.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detial);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_GAME_ILLUSTRATION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TitleName.Length != 0)
			{
				this.TitleName = other.TitleName;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.LabelName.Length != 0)
			{
				this.LabelName = other.LabelName;
			}
			if (other.Detial.Length != 0)
			{
				this.Detial = other.Detial;
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
									input.SkipLastField();
								}
								else
								{
									this.Detial = input.ReadBytes();
								}
							}
							else
							{
								this.LabelName = input.ReadBytes();
							}
						}
						else
						{
							this.Num = input.ReadInt32();
						}
					}
					else
					{
						this.Type = input.ReadInt32();
					}
				}
				else
				{
					this.TitleName = input.ReadBytes();
				}
			}
		}
	}
}
