using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BOX_GACHA_BASE_DETAIL : IMessage, IMessage<MST_BOX_GACHA_BASE_DETAIL>, IEquatable<MST_BOX_GACHA_BASE_DETAIL>, IDeepCloneable<MST_BOX_GACHA_BASE_DETAIL>
	{
		public const int BaseIdFieldNumber = 1;

		public const int DetailUrlFieldNumber = 2;

		public const int UpdatedAtFieldNumber = 3;

		public const int CreatedAtFieldNumber = 4;

		private static readonly MessageParser<MST_BOX_GACHA_BASE_DETAIL> _parser = new MessageParser<MST_BOX_GACHA_BASE_DETAIL>(() => new MST_BOX_GACHA_BASE_DETAIL());

		private int baseId_;

		private ByteString detailUrl_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BOX_GACHA_BASE_DETAIL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BOX_GACHA_BASE_DETAIL> Parser => MST_BOX_GACHA_BASE_DETAIL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBoxGachaBaseDetailReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int BaseId
		{
			get => this.baseId_;
			set
			{
				this.baseId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString DetailUrl
		{
			get => this.detailUrl_;
			set
			{
				this.detailUrl_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ulong UpdatedAt
		{
			get => this.updatedAt_;
			set
			{
				this.updatedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong CreatedAt
		{
			get => this.createdAt_;
			set
			{
				this.createdAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA_BASE_DETAIL()
		{
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA_BASE_DETAIL(MST_BOX_GACHA_BASE_DETAIL other) : this()
		{
			this.baseId_ = other.baseId_;
			this.detailUrl_ = other.detailUrl_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA_BASE_DETAIL Clone()
		{
			return new MST_BOX_GACHA_BASE_DETAIL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BOX_GACHA_BASE_DETAIL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BOX_GACHA_BASE_DETAIL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.BaseId == other.BaseId && !(this.DetailUrl != other.DetailUrl) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BaseId != 0)
			{
				num ^= this.BaseId.GetHashCode();
			}
			if (this.DetailUrl.Length != 0)
			{
				num ^= this.DetailUrl.GetHashCode();
			}
			if (this.UpdatedAt != 0uL)
			{
				num ^= this.UpdatedAt.GetHashCode();
			}
			if (this.CreatedAt != 0uL)
			{
				num ^= this.CreatedAt.GetHashCode();
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
			if (this.BaseId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BaseId);
			}
			if (this.DetailUrl.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.DetailUrl);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BaseId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseId);
			}
			if (this.DetailUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.DetailUrl);
			}
			if (this.UpdatedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_BOX_GACHA_BASE_DETAIL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BaseId != 0)
			{
				this.BaseId = other.BaseId;
			}
			if (other.DetailUrl.Length != 0)
			{
				this.DetailUrl = other.DetailUrl;
			}
			if (other.UpdatedAt != 0uL)
			{
				this.UpdatedAt = other.UpdatedAt;
			}
			if (other.CreatedAt != 0uL)
			{
				this.CreatedAt = other.CreatedAt;
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
					if (num2 != 18u)
					{
						if (num2 != 24u)
						{
							if (num2 != 32u)
							{
								input.SkipLastField();
							}
							else
							{
								this.CreatedAt = input.ReadUInt64();
							}
						}
						else
						{
							this.UpdatedAt = input.ReadUInt64();
						}
					}
					else
					{
						this.DetailUrl = input.ReadBytes();
					}
				}
				else
				{
					this.BaseId = input.ReadInt32();
				}
			}
		}
	}
}
