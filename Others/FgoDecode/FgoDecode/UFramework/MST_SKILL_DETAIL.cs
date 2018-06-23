using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SKILL_DETAIL : IMessage, IMessage<MST_SKILL_DETAIL>, IEquatable<MST_SKILL_DETAIL>, IDeepCloneable<MST_SKILL_DETAIL>
	{
		public const int IdFieldNumber = 1;

		public const int DetailFieldNumber = 2;

		public const int DetailShortFieldNumber = 3;

		public const int UpdatedAtFieldNumber = 4;

		public const int CreatedAtFieldNumber = 5;

		private static readonly MessageParser<MST_SKILL_DETAIL> _parser = new MessageParser<MST_SKILL_DETAIL>(() => new MST_SKILL_DETAIL());

		private int id_;

		private ByteString detail_ = ByteString.Empty;

		private ByteString detailShort_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SKILL_DETAIL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SKILL_DETAIL> Parser => MST_SKILL_DETAIL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSkillDetailReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int Id
		{
			get => this.id_;
			set
			{
				this.id_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Detail
		{
			get => this.detail_;
			set
			{
				this.detail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString DetailShort
		{
			get => this.detailShort_;
			set
			{
				this.detailShort_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public MST_SKILL_DETAIL()
		{
		}

		[DebuggerNonUserCode]
		public MST_SKILL_DETAIL(MST_SKILL_DETAIL other) : this()
		{
			this.id_ = other.id_;
			this.detail_ = other.detail_;
			this.detailShort_ = other.detailShort_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_SKILL_DETAIL Clone()
		{
			return new MST_SKILL_DETAIL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SKILL_DETAIL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SKILL_DETAIL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Detail != other.Detail) && !(this.DetailShort != other.DetailShort) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this.DetailShort.Length != 0)
			{
				num ^= this.DetailShort.GetHashCode();
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
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Detail);
			}
			if (this.DetailShort.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.DetailShort);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			if (this.DetailShort.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.DetailShort);
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
		public void MergeFrom(MST_SKILL_DETAIL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			if (other.DetailShort.Length != 0)
			{
				this.DetailShort = other.DetailShort;
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
						if (num2 != 26u)
						{
							if (num2 != 32u)
							{
								if (num2 != 40u)
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
							this.DetailShort = input.ReadBytes();
						}
					}
					else
					{
						this.Detail = input.ReadBytes();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}
	}
}
