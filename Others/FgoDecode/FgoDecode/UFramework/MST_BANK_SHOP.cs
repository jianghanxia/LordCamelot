using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BANK_SHOP : IMessage, IMessage<MST_BANK_SHOP>, IEquatable<MST_BANK_SHOP>, IDeepCloneable<MST_BANK_SHOP>
	{
		public const int IdFieldNumber = 1;

		public const int AppleShopIdFieldNumber = 2;

		public const int GoogleShopIdFieldNumber = 3;

		public const int ApplePriceFieldNumber = 4;

		public const int GooglePriceFieldNumber = 5;

		public const int NameFieldNumber = 6;

		public const int ChargeStoneNumFieldNumber = 7;

		public const int FreeStoneNumFieldNumber = 8;

		public const int NumDetailFieldNumber = 9;

		public const int PriceDetailFieldNumber = 10;

		public const int OpenedAtFieldNumber = 11;

		public const int ClosedAtFieldNumber = 12;

		public const int GetChargeStoneNumFieldNumber = 13;

		public const int GetFreeStoneNumFieldNumber = 14;

		public const int GetPriceDetailFieldNumber = 15;

		public const int GetNumDetailFieldNumber = 16;

		public const int FirstPayIdFieldNumber = 17;

		private static readonly MessageParser<MST_BANK_SHOP> _parser = new MessageParser<MST_BANK_SHOP>(() => new MST_BANK_SHOP());

		private int id_;

		private ByteString appleShopId_ = ByteString.Empty;

		private ByteString googleShopId_ = ByteString.Empty;

		private int applePrice_;

		private int googlePrice_;

		private ByteString name_ = ByteString.Empty;

		private int chargeStoneNum_;

		private int freeStoneNum_;

		private ByteString numDetail_ = ByteString.Empty;

		private ByteString priceDetail_ = ByteString.Empty;

		private ulong openedAt_;

		private ulong closedAt_;

		private int getChargeStoneNum_;

		private int getFreeStoneNum_;

		private ByteString getPriceDetail_ = ByteString.Empty;

		private ByteString getNumDetail_ = ByteString.Empty;

		private int firstPayId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BANK_SHOP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BANK_SHOP> Parser => MST_BANK_SHOP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBankShopReflection.Descriptor.MessageTypes[0];

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
		public ByteString AppleShopId
		{
			get => this.appleShopId_;
			set
			{
				this.appleShopId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString GoogleShopId
		{
			get => this.googleShopId_;
			set
			{
				this.googleShopId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int ApplePrice
		{
			get => this.applePrice_;
			set
			{
				this.applePrice_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GooglePrice
		{
			get => this.googlePrice_;
			set
			{
				this.googlePrice_ = value;
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
		public int ChargeStoneNum
		{
			get => this.chargeStoneNum_;
			set
			{
				this.chargeStoneNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FreeStoneNum
		{
			get => this.freeStoneNum_;
			set
			{
				this.freeStoneNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString NumDetail
		{
			get => this.numDetail_;
			set
			{
				this.numDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString PriceDetail
		{
			get => this.priceDetail_;
			set
			{
				this.priceDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int GetChargeStoneNum
		{
			get => this.getChargeStoneNum_;
			set
			{
				this.getChargeStoneNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GetFreeStoneNum
		{
			get => this.getFreeStoneNum_;
			set
			{
				this.getFreeStoneNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString GetPriceDetail
		{
			get => this.getPriceDetail_;
			set
			{
				this.getPriceDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString GetNumDetail
		{
			get => this.getNumDetail_;
			set
			{
				this.getNumDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int FirstPayId
		{
			get => this.firstPayId_;
			set
			{
				this.firstPayId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_BANK_SHOP()
		{
		}

		[DebuggerNonUserCode]
		public MST_BANK_SHOP(MST_BANK_SHOP other) : this()
		{
			this.id_ = other.id_;
			this.appleShopId_ = other.appleShopId_;
			this.googleShopId_ = other.googleShopId_;
			this.applePrice_ = other.applePrice_;
			this.googlePrice_ = other.googlePrice_;
			this.name_ = other.name_;
			this.chargeStoneNum_ = other.chargeStoneNum_;
			this.freeStoneNum_ = other.freeStoneNum_;
			this.numDetail_ = other.numDetail_;
			this.priceDetail_ = other.priceDetail_;
			this.openedAt_ = other.openedAt_;
			this.closedAt_ = other.closedAt_;
			this.getChargeStoneNum_ = other.getChargeStoneNum_;
			this.getFreeStoneNum_ = other.getFreeStoneNum_;
			this.getPriceDetail_ = other.getPriceDetail_;
			this.getNumDetail_ = other.getNumDetail_;
			this.firstPayId_ = other.firstPayId_;
		}

		[DebuggerNonUserCode]
		public MST_BANK_SHOP Clone()
		{
			return new MST_BANK_SHOP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BANK_SHOP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BANK_SHOP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.AppleShopId != other.AppleShopId) && !(this.GoogleShopId != other.GoogleShopId) && this.ApplePrice == other.ApplePrice && this.GooglePrice == other.GooglePrice && !(this.Name != other.Name) && this.ChargeStoneNum == other.ChargeStoneNum && this.FreeStoneNum == other.FreeStoneNum && !(this.NumDetail != other.NumDetail) && !(this.PriceDetail != other.PriceDetail) && this.OpenedAt == other.OpenedAt && this.ClosedAt == other.ClosedAt && this.GetChargeStoneNum == other.GetChargeStoneNum && this.GetFreeStoneNum == other.GetFreeStoneNum && !(this.GetPriceDetail != other.GetPriceDetail) && !(this.GetNumDetail != other.GetNumDetail) && this.FirstPayId == other.FirstPayId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.AppleShopId.Length != 0)
			{
				num ^= this.AppleShopId.GetHashCode();
			}
			if (this.GoogleShopId.Length != 0)
			{
				num ^= this.GoogleShopId.GetHashCode();
			}
			if (this.ApplePrice != 0)
			{
				num ^= this.ApplePrice.GetHashCode();
			}
			if (this.GooglePrice != 0)
			{
				num ^= this.GooglePrice.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.ChargeStoneNum != 0)
			{
				num ^= this.ChargeStoneNum.GetHashCode();
			}
			if (this.FreeStoneNum != 0)
			{
				num ^= this.FreeStoneNum.GetHashCode();
			}
			if (this.NumDetail.Length != 0)
			{
				num ^= this.NumDetail.GetHashCode();
			}
			if (this.PriceDetail.Length != 0)
			{
				num ^= this.PriceDetail.GetHashCode();
			}
			if (this.OpenedAt != 0uL)
			{
				num ^= this.OpenedAt.GetHashCode();
			}
			if (this.ClosedAt != 0uL)
			{
				num ^= this.ClosedAt.GetHashCode();
			}
			if (this.GetChargeStoneNum != 0)
			{
				num ^= this.GetChargeStoneNum.GetHashCode();
			}
			if (this.GetFreeStoneNum != 0)
			{
				num ^= this.GetFreeStoneNum.GetHashCode();
			}
			if (this.GetPriceDetail.Length != 0)
			{
				num ^= this.GetPriceDetail.GetHashCode();
			}
			if (this.GetNumDetail.Length != 0)
			{
				num ^= this.GetNumDetail.GetHashCode();
			}
			if (this.FirstPayId != 0)
			{
				num ^= this.FirstPayId.GetHashCode();
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
			if (this.AppleShopId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.AppleShopId);
			}
			if (this.GoogleShopId.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.GoogleShopId);
			}
			if (this.ApplePrice != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ApplePrice);
			}
			if (this.GooglePrice != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GooglePrice);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteBytes(this.Name);
			}
			if (this.ChargeStoneNum != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChargeStoneNum);
			}
			if (this.FreeStoneNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FreeStoneNum);
			}
			if (this.NumDetail.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteBytes(this.NumDetail);
			}
			if (this.PriceDetail.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteBytes(this.PriceDetail);
			}
			if (this.OpenedAt != 0uL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.ClosedAt);
			}
			if (this.GetChargeStoneNum != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.GetChargeStoneNum);
			}
			if (this.GetFreeStoneNum != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.GetFreeStoneNum);
			}
			if (this.GetPriceDetail.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.GetPriceDetail);
			}
			if (this.GetNumDetail.Length != 0)
			{
				output.WriteRawTag(130, 1);
				output.WriteBytes(this.GetNumDetail);
			}
			if (this.FirstPayId != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.FirstPayId);
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
			if (this.AppleShopId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.AppleShopId);
			}
			if (this.GoogleShopId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.GoogleShopId);
			}
			if (this.ApplePrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ApplePrice);
			}
			if (this.GooglePrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GooglePrice);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.ChargeStoneNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChargeStoneNum);
			}
			if (this.FreeStoneNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FreeStoneNum);
			}
			if (this.NumDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.NumDetail);
			}
			if (this.PriceDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.PriceDetail);
			}
			if (this.OpenedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClosedAt);
			}
			if (this.GetChargeStoneNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GetChargeStoneNum);
			}
			if (this.GetFreeStoneNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GetFreeStoneNum);
			}
			if (this.GetPriceDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.GetPriceDetail);
			}
			if (this.GetNumDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.GetNumDetail);
			}
			if (this.FirstPayId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FirstPayId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_BANK_SHOP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.AppleShopId.Length != 0)
			{
				this.AppleShopId = other.AppleShopId;
			}
			if (other.GoogleShopId.Length != 0)
			{
				this.GoogleShopId = other.GoogleShopId;
			}
			if (other.ApplePrice != 0)
			{
				this.ApplePrice = other.ApplePrice;
			}
			if (other.GooglePrice != 0)
			{
				this.GooglePrice = other.GooglePrice;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.ChargeStoneNum != 0)
			{
				this.ChargeStoneNum = other.ChargeStoneNum;
			}
			if (other.FreeStoneNum != 0)
			{
				this.FreeStoneNum = other.FreeStoneNum;
			}
			if (other.NumDetail.Length != 0)
			{
				this.NumDetail = other.NumDetail;
			}
			if (other.PriceDetail.Length != 0)
			{
				this.PriceDetail = other.PriceDetail;
			}
			if (other.OpenedAt != 0uL)
			{
				this.OpenedAt = other.OpenedAt;
			}
			if (other.ClosedAt != 0uL)
			{
				this.ClosedAt = other.ClosedAt;
			}
			if (other.GetChargeStoneNum != 0)
			{
				this.GetChargeStoneNum = other.GetChargeStoneNum;
			}
			if (other.GetFreeStoneNum != 0)
			{
				this.GetFreeStoneNum = other.GetFreeStoneNum;
			}
			if (other.GetPriceDetail.Length != 0)
			{
				this.GetPriceDetail = other.GetPriceDetail;
			}
			if (other.GetNumDetail.Length != 0)
			{
				this.GetNumDetail = other.GetNumDetail;
			}
			if (other.FirstPayId != 0)
			{
				this.FirstPayId = other.FirstPayId;
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
									if (num2 != 50u)
									{
										if (num2 != 56u)
										{
											if (num2 != 64u)
											{
												if (num2 != 74u)
												{
													if (num2 != 82u)
													{
														if (num2 != 88u)
														{
															if (num2 != 96u)
															{
																if (num2 != 104u)
																{
																	if (num2 != 112u)
																	{
																		if (num2 != 122u)
																		{
																			if (num2 != 130u)
																			{
																				if (num2 != 136u)
																				{
																					input.SkipLastField();
																				}
																				else
																				{
																					this.FirstPayId = input.ReadInt32();
																				}
																			}
																			else
																			{
																				this.GetNumDetail = input.ReadBytes();
																			}
																		}
																		else
																		{
																			this.GetPriceDetail = input.ReadBytes();
																		}
																	}
																	else
																	{
																		this.GetFreeStoneNum = input.ReadInt32();
																	}
																}
																else
																{
																	this.GetChargeStoneNum = input.ReadInt32();
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
														this.PriceDetail = input.ReadBytes();
													}
												}
												else
												{
													this.NumDetail = input.ReadBytes();
												}
											}
											else
											{
												this.FreeStoneNum = input.ReadInt32();
											}
										}
										else
										{
											this.ChargeStoneNum = input.ReadInt32();
										}
									}
									else
									{
										this.Name = input.ReadBytes();
									}
								}
								else
								{
									this.GooglePrice = input.ReadInt32();
								}
							}
							else
							{
								this.ApplePrice = input.ReadInt32();
							}
						}
						else
						{
							this.GoogleShopId = input.ReadBytes();
						}
					}
					else
					{
						this.AppleShopId = input.ReadBytes();
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
