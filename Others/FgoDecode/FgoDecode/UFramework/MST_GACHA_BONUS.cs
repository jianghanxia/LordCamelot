using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_GACHA_BONUS : IMessage, IMessage<MST_GACHA_BONUS>, IEquatable<MST_GACHA_BONUS>, IDeepCloneable<MST_GACHA_BONUS>
	{
		public const int GachaIdFieldNumber = 1;

		public const int IdFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int TargetIdFieldNumber = 4;

		public const int AdjustIdFieldNumber = 5;

		public const int ValueFieldNumber = 6;

		public const int RequireDrawFieldNumber = 7;

		public const int PresentMessageIdFieldNumber = 8;

		public const int RarityIdFieldNumber = 9;

		public const int OpenedAtFieldNumber = 10;

		public const int ClosedAtFieldNumber = 11;

		public const int UpdatedAtFieldNumber = 12;

		public const int CreatedAtFieldNumber = 13;

		private static readonly MessageParser<MST_GACHA_BONUS> _parser = new MessageParser<MST_GACHA_BONUS>(() => new MST_GACHA_BONUS());

		private int gachaId_;

		private int id_;

		private int type_;

		private int targetId_;

		private int adjustId_;

		private int value_;

		private int requireDraw_;

		private int presentMessageId_;

		private int rarityId_;

		private ulong openedAt_;

		private ulong closedAt_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_GACHA_BONUS.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_GACHA_BONUS> Parser => MST_GACHA_BONUS._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstGachaBonusReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int GachaId
		{
			get => this.gachaId_;
			set
			{
				this.gachaId_ = value;
			}
		}

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
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TargetId
		{
			get => this.targetId_;
			set
			{
				this.targetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AdjustId
		{
			get => this.adjustId_;
			set
			{
				this.adjustId_ = value;
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
		public int RequireDraw
		{
			get => this.requireDraw_;
			set
			{
				this.requireDraw_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int PresentMessageId
		{
			get => this.presentMessageId_;
			set
			{
				this.presentMessageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int RarityId
		{
			get => this.rarityId_;
			set
			{
				this.rarityId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong OpenedAt
		{
			get => this.openedAt_;
			set
			{
				this.openedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong ClosedAt
		{
			get => this.closedAt_;
			set
			{
				this.closedAt_ = value;
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
		public MST_GACHA_BONUS()
		{
		}

		[DebuggerNonUserCode]
		public MST_GACHA_BONUS(MST_GACHA_BONUS other) : this()
		{
			this.gachaId_ = other.gachaId_;
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.targetId_ = other.targetId_;
			this.adjustId_ = other.adjustId_;
			this.value_ = other.value_;
			this.requireDraw_ = other.requireDraw_;
			this.presentMessageId_ = other.presentMessageId_;
			this.rarityId_ = other.rarityId_;
			this.openedAt_ = other.openedAt_;
			this.closedAt_ = other.closedAt_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_GACHA_BONUS Clone()
		{
			return new MST_GACHA_BONUS(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_GACHA_BONUS);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_GACHA_BONUS other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.GachaId == other.GachaId && this.Id == other.Id && this.Type == other.Type && this.TargetId == other.TargetId && this.AdjustId == other.AdjustId && this.Value == other.Value && this.RequireDraw == other.RequireDraw && this.PresentMessageId == other.PresentMessageId && this.RarityId == other.RarityId && this.OpenedAt == other.OpenedAt && this.ClosedAt == other.ClosedAt && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.AdjustId != 0)
			{
				num ^= this.AdjustId.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.RequireDraw != 0)
			{
				num ^= this.RequireDraw.GetHashCode();
			}
			if (this.PresentMessageId != 0)
			{
				num ^= this.PresentMessageId.GetHashCode();
			}
			if (this.RarityId != 0)
			{
				num ^= this.RarityId.GetHashCode();
			}
			if (this.OpenedAt != 0uL)
			{
				num ^= this.OpenedAt.GetHashCode();
			}
			if (this.ClosedAt != 0uL)
			{
				num ^= this.ClosedAt.GetHashCode();
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
			if (this.GachaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GachaId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TargetId);
			}
			if (this.AdjustId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AdjustId);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Value);
			}
			if (this.RequireDraw != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RequireDraw);
			}
			if (this.PresentMessageId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PresentMessageId);
			}
			if (this.RarityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RarityId);
			}
			if (this.OpenedAt != 0uL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.ClosedAt);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.AdjustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdjustId);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this.RequireDraw != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RequireDraw);
			}
			if (this.PresentMessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PresentMessageId);
			}
			if (this.RarityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RarityId);
			}
			if (this.OpenedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClosedAt);
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
		public void MergeFrom(MST_GACHA_BONUS other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.AdjustId != 0)
			{
				this.AdjustId = other.AdjustId;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			if (other.RequireDraw != 0)
			{
				this.RequireDraw = other.RequireDraw;
			}
			if (other.PresentMessageId != 0)
			{
				this.PresentMessageId = other.PresentMessageId;
			}
			if (other.RarityId != 0)
			{
				this.RarityId = other.RarityId;
			}
			if (other.OpenedAt != 0uL)
			{
				this.OpenedAt = other.OpenedAt;
			}
			if (other.ClosedAt != 0uL)
			{
				this.ClosedAt = other.ClosedAt;
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
																if (num2 != 104u)
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
															this.ClosedAt = input.ReadUInt64();
														}
													}
													else
													{
														this.OpenedAt = input.ReadUInt64();
													}
												}
												else
												{
													this.RarityId = input.ReadInt32();
												}
											}
											else
											{
												this.PresentMessageId = input.ReadInt32();
											}
										}
										else
										{
											this.RequireDraw = input.ReadInt32();
										}
									}
									else
									{
										this.Value = input.ReadInt32();
									}
								}
								else
								{
									this.AdjustId = input.ReadInt32();
								}
							}
							else
							{
								this.TargetId = input.ReadInt32();
							}
						}
						else
						{
							this.Type = input.ReadInt32();
						}
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.GachaId = input.ReadInt32();
				}
			}
		}
	}
}
