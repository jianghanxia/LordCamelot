using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EQUIP : IMessage, IMessage<MST_EQUIP>, IEquatable<MST_EQUIP>, IDeepCloneable<MST_EQUIP>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		public const int DetailFieldNumber = 3;

		public const int CondUserLvFieldNumber = 4;

		public const int MaxLvFieldNumber = 5;

		public const int MaleImageIdFieldNumber = 6;

		public const int FemaleImageIdFieldNumber = 7;

		public const int ImageIdFieldNumber = 8;

		public const int MaleSpellIdFieldNumber = 9;

		public const int FemaleSpellIdFieldNumber = 10;

		public const int UpdatedAtFieldNumber = 11;

		public const int CreatedAtFieldNumber = 12;

		private static readonly MessageParser<MST_EQUIP> _parser = new MessageParser<MST_EQUIP>(() => new MST_EQUIP());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		private ByteString detail_ = ByteString.Empty;

		private int condUserLv_;

		private int maxLv_;

		private int maleImageId_;

		private int femaleImageId_;

		private int imageId_;

		private int maleSpellId_;

		private int femaleSpellId_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EQUIP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EQUIP> Parser => MST_EQUIP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEquipReflection.Descriptor.MessageTypes[0];

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
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int CondUserLv
		{
			get => this.condUserLv_;
			set
			{
				this.condUserLv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MaxLv
		{
			get => this.maxLv_;
			set
			{
				this.maxLv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MaleImageId
		{
			get => this.maleImageId_;
			set
			{
				this.maleImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FemaleImageId
		{
			get => this.femaleImageId_;
			set
			{
				this.femaleImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ImageId
		{
			get => this.imageId_;
			set
			{
				this.imageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MaleSpellId
		{
			get => this.maleSpellId_;
			set
			{
				this.maleSpellId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FemaleSpellId
		{
			get => this.femaleSpellId_;
			set
			{
				this.femaleSpellId_ = value;
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
		public MST_EQUIP()
		{
		}

		[DebuggerNonUserCode]
		public MST_EQUIP(MST_EQUIP other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.detail_ = other.detail_;
			this.condUserLv_ = other.condUserLv_;
			this.maxLv_ = other.maxLv_;
			this.maleImageId_ = other.maleImageId_;
			this.femaleImageId_ = other.femaleImageId_;
			this.imageId_ = other.imageId_;
			this.maleSpellId_ = other.maleSpellId_;
			this.femaleSpellId_ = other.femaleSpellId_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EQUIP Clone()
		{
			return new MST_EQUIP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EQUIP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EQUIP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name) && !(this.Detail != other.Detail) && this.CondUserLv == other.CondUserLv && this.MaxLv == other.MaxLv && this.MaleImageId == other.MaleImageId && this.FemaleImageId == other.FemaleImageId && this.ImageId == other.ImageId && this.MaleSpellId == other.MaleSpellId && this.FemaleSpellId == other.FemaleSpellId && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this.CondUserLv != 0)
			{
				num ^= this.CondUserLv.GetHashCode();
			}
			if (this.MaxLv != 0)
			{
				num ^= this.MaxLv.GetHashCode();
			}
			if (this.MaleImageId != 0)
			{
				num ^= this.MaleImageId.GetHashCode();
			}
			if (this.FemaleImageId != 0)
			{
				num ^= this.FemaleImageId.GetHashCode();
			}
			if (this.ImageId != 0)
			{
				num ^= this.ImageId.GetHashCode();
			}
			if (this.MaleSpellId != 0)
			{
				num ^= this.MaleSpellId.GetHashCode();
			}
			if (this.FemaleSpellId != 0)
			{
				num ^= this.FemaleSpellId.GetHashCode();
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
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Detail);
			}
			if (this.CondUserLv != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CondUserLv);
			}
			if (this.MaxLv != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxLv);
			}
			if (this.MaleImageId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaleImageId);
			}
			if (this.FemaleImageId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FemaleImageId);
			}
			if (this.ImageId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ImageId);
			}
			if (this.MaleSpellId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MaleSpellId);
			}
			if (this.FemaleSpellId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.FemaleSpellId);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(96);
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
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			if (this.CondUserLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondUserLv);
			}
			if (this.MaxLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLv);
			}
			if (this.MaleImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaleImageId);
			}
			if (this.FemaleImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FemaleImageId);
			}
			if (this.ImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageId);
			}
			if (this.MaleSpellId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaleSpellId);
			}
			if (this.FemaleSpellId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FemaleSpellId);
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
		public void MergeFrom(MST_EQUIP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			if (other.CondUserLv != 0)
			{
				this.CondUserLv = other.CondUserLv;
			}
			if (other.MaxLv != 0)
			{
				this.MaxLv = other.MaxLv;
			}
			if (other.MaleImageId != 0)
			{
				this.MaleImageId = other.MaleImageId;
			}
			if (other.FemaleImageId != 0)
			{
				this.FemaleImageId = other.FemaleImageId;
			}
			if (other.ImageId != 0)
			{
				this.ImageId = other.ImageId;
			}
			if (other.MaleSpellId != 0)
			{
				this.MaleSpellId = other.MaleSpellId;
			}
			if (other.FemaleSpellId != 0)
			{
				this.FemaleSpellId = other.FemaleSpellId;
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
									if (num2 != 48u)
									{
										if (num2 != 56u)
										{
											if (num2 != 64u)
											{
												if (num2 != 72u)
												{
													if (num2 != 80u)
													{
														if (num2 != 88u)
														{
															if (num2 != 96u)
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
														this.FemaleSpellId = input.ReadInt32();
													}
												}
												else
												{
													this.MaleSpellId = input.ReadInt32();
												}
											}
											else
											{
												this.ImageId = input.ReadInt32();
											}
										}
										else
										{
											this.FemaleImageId = input.ReadInt32();
										}
									}
									else
									{
										this.MaleImageId = input.ReadInt32();
									}
								}
								else
								{
									this.MaxLv = input.ReadInt32();
								}
							}
							else
							{
								this.CondUserLv = input.ReadInt32();
							}
						}
						else
						{
							this.Detail = input.ReadBytes();
						}
					}
					else
					{
						this.Name = input.ReadBytes();
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
