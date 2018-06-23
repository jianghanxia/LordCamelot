using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_COMBINE_MATERIAL : IMessage, IMessage<MST_COMBINE_MATERIAL>, IEquatable<MST_COMBINE_MATERIAL>, IDeepCloneable<MST_COMBINE_MATERIAL>
	{
		public const int IdFieldNumber = 1;

		public const int LvFieldNumber = 2;

		public const int ValueFieldNumber = 3;

		public const int UpdatedAtFieldNumber = 4;

		public const int CreatedAtFieldNumber = 5;

		private static readonly MessageParser<MST_COMBINE_MATERIAL> _parser = new MessageParser<MST_COMBINE_MATERIAL>(() => new MST_COMBINE_MATERIAL());

		private int id_;

		private int lv_;

		private int value_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_COMBINE_MATERIAL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_COMBINE_MATERIAL> Parser => MST_COMBINE_MATERIAL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstCombineMaterialReflection.Descriptor.MessageTypes[0];

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
		public int Lv
		{
			get => this.lv_;
			set
			{
				this.lv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Value
		{
			get => this.value_;
			set
			{
				this.value_ = value;
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
		public MST_COMBINE_MATERIAL()
		{
		}

		[DebuggerNonUserCode]
		public MST_COMBINE_MATERIAL(MST_COMBINE_MATERIAL other) : this()
		{
			this.id_ = other.id_;
			this.lv_ = other.lv_;
			this.value_ = other.value_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_COMBINE_MATERIAL Clone()
		{
			return new MST_COMBINE_MATERIAL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_COMBINE_MATERIAL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_COMBINE_MATERIAL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Lv == other.Lv && this.Value == other.Value && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
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
			if (this.Lv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Lv);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Value);
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
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
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
		public void MergeFrom(MST_COMBINE_MATERIAL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
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
					if (num2 != 16u)
					{
						if (num2 != 24u)
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
							this.Value = input.ReadInt32();
						}
					}
					else
					{
						this.Lv = input.ReadInt32();
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
