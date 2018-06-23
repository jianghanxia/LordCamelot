using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_GACHA : IMessage, IMessage<MST_GACHA>, IEquatable<MST_GACHA>, IDeepCloneable<MST_GACHA>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		public const int ImageIdFieldNumber = 3;

		public const int PriorityFieldNumber = 4;

		public const int WarIdFieldNumber = 5;

		public const int GachaSlotFieldNumber = 6;

		public const int TypeFieldNumber = 7;

		public const int ShopId1FieldNumber = 8;

		public const int ShopId2FieldNumber = 9;

		public const int RarityIdFieldNumber = 10;

		public const int BaseIdFieldNumber = 11;

		public const int AdjustIdFieldNumber = 12;

		public const int PickupIdFieldNumber = 13;

		public const int TicketItemIdFieldNumber = 14;

		public const int GachaGroupIdFieldNumber = 15;

		public const int DrawNum1FieldNumber = 16;

		public const int DrawNum2FieldNumber = 17;

		public const int GachaProbabilityIdFieldNumber = 18;

		public const int FreeDrawFlagFieldNumber = 19;

		public const int MaxDrawNumFieldNumber = 20;

		public const int BeforeGachaIdFieldNumber = 21;

		public const int BeforeDrawNumFieldNumber = 22;

		public const int PickupOpenedAtFieldNumber = 23;

		public const int PickupClosedAtFieldNumber = 24;

		public const int OpenedAtFieldNumber = 25;

		public const int ClosedAtFieldNumber = 26;

		public const int CondQuestIdFieldNumber = 27;

		public const int CondQuestPhaseFieldNumber = 28;

		public const int DetailUrlFieldNumber = 29;

		public const int BannerQuestIdFieldNumber = 30;

		public const int BannerQuestPhaseFieldNumber = 31;

		public const int UpdatedAtFieldNumber = 32;

		public const int CreatedAtFieldNumber = 33;

		private static readonly MessageParser<MST_GACHA> _parser = new MessageParser<MST_GACHA>(() => new MST_GACHA());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		private int imageId_;

		private int priority_;

		private int warId_;

		private int gachaSlot_;

		private int type_;

		private int shopId1_;

		private int shopId2_;

		private int rarityId_;

		private int baseId_;

		private int adjustId_;

		private int pickupId_;

		private int ticketItemId_;

		private int gachaGroupId_;

		private int drawNum1_;

		private int drawNum2_;

		private int gachaProbabilityId_;

		private int freeDrawFlag_;

		private int maxDrawNum_;

		private int beforeGachaId_;

		private int beforeDrawNum_;

		private ulong pickupOpenedAt_;

		private ulong pickupClosedAt_;

		private ulong openedAt_;

		private ulong closedAt_;

		private int condQuestId_;

		private int condQuestPhase_;

		private ByteString detailUrl_ = ByteString.Empty;

		private int bannerQuestId_;

		private int bannerQuestPhase_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_GACHA.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_GACHA> Parser => MST_GACHA._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstGachaReflection.Descriptor.MessageTypes[0];

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
		public int ImageId
		{
			get => this.imageId_;
			set
			{
				this.imageId_ = value;
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
		public int WarId
		{
			get => this.warId_;
			set
			{
				this.warId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GachaSlot
		{
			get => this.gachaSlot_;
			set
			{
				this.gachaSlot_ = value;
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
		public int ShopId1
		{
			get => this.shopId1_;
			set
			{
				this.shopId1_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ShopId2
		{
			get => this.shopId2_;
			set
			{
				this.shopId2_ = value;
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
		public int BaseId
		{
			get => this.baseId_;
			set
			{
				this.baseId_ = value;
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
		public int PickupId
		{
			get => this.pickupId_;
			set
			{
				this.pickupId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TicketItemId
		{
			get => this.ticketItemId_;
			set
			{
				this.ticketItemId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GachaGroupId
		{
			get => this.gachaGroupId_;
			set
			{
				this.gachaGroupId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DrawNum1
		{
			get => this.drawNum1_;
			set
			{
				this.drawNum1_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DrawNum2
		{
			get => this.drawNum2_;
			set
			{
				this.drawNum2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GachaProbabilityId
		{
			get => this.gachaProbabilityId_;
			set
			{
				this.gachaProbabilityId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FreeDrawFlag
		{
			get => this.freeDrawFlag_;
			set
			{
				this.freeDrawFlag_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MaxDrawNum
		{
			get => this.maxDrawNum_;
			set
			{
				this.maxDrawNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BeforeGachaId
		{
			get => this.beforeGachaId_;
			set
			{
				this.beforeGachaId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BeforeDrawNum
		{
			get => this.beforeDrawNum_;
			set
			{
				this.beforeDrawNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong PickupOpenedAt
		{
			get => this.pickupOpenedAt_;
			set
			{
				this.pickupOpenedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong PickupClosedAt
		{
			get => this.pickupClosedAt_;
			set
			{
				this.pickupClosedAt_ = value;
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
		public int CondQuestId
		{
			get => this.condQuestId_;
			set
			{
				this.condQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondQuestPhase
		{
			get => this.condQuestPhase_;
			set
			{
				this.condQuestPhase_ = value;
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
		public int BannerQuestId
		{
			get => this.bannerQuestId_;
			set
			{
				this.bannerQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BannerQuestPhase
		{
			get => this.bannerQuestPhase_;
			set
			{
				this.bannerQuestPhase_ = value;
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
		public MST_GACHA()
		{
		}

		[DebuggerNonUserCode]
		public MST_GACHA(MST_GACHA other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.imageId_ = other.imageId_;
			this.priority_ = other.priority_;
			this.warId_ = other.warId_;
			this.gachaSlot_ = other.gachaSlot_;
			this.type_ = other.type_;
			this.shopId1_ = other.shopId1_;
			this.shopId2_ = other.shopId2_;
			this.rarityId_ = other.rarityId_;
			this.baseId_ = other.baseId_;
			this.adjustId_ = other.adjustId_;
			this.pickupId_ = other.pickupId_;
			this.ticketItemId_ = other.ticketItemId_;
			this.gachaGroupId_ = other.gachaGroupId_;
			this.drawNum1_ = other.drawNum1_;
			this.drawNum2_ = other.drawNum2_;
			this.gachaProbabilityId_ = other.gachaProbabilityId_;
			this.freeDrawFlag_ = other.freeDrawFlag_;
			this.maxDrawNum_ = other.maxDrawNum_;
			this.beforeGachaId_ = other.beforeGachaId_;
			this.beforeDrawNum_ = other.beforeDrawNum_;
			this.pickupOpenedAt_ = other.pickupOpenedAt_;
			this.pickupClosedAt_ = other.pickupClosedAt_;
			this.openedAt_ = other.openedAt_;
			this.closedAt_ = other.closedAt_;
			this.condQuestId_ = other.condQuestId_;
			this.condQuestPhase_ = other.condQuestPhase_;
			this.detailUrl_ = other.detailUrl_;
			this.bannerQuestId_ = other.bannerQuestId_;
			this.bannerQuestPhase_ = other.bannerQuestPhase_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_GACHA Clone()
		{
			return new MST_GACHA(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_GACHA);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_GACHA other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name) && this.ImageId == other.ImageId && this.Priority == other.Priority && this.WarId == other.WarId && this.GachaSlot == other.GachaSlot && this.Type == other.Type && this.ShopId1 == other.ShopId1 && this.ShopId2 == other.ShopId2 && this.RarityId == other.RarityId && this.BaseId == other.BaseId && this.AdjustId == other.AdjustId && this.PickupId == other.PickupId && this.TicketItemId == other.TicketItemId && this.GachaGroupId == other.GachaGroupId && this.DrawNum1 == other.DrawNum1 && this.DrawNum2 == other.DrawNum2 && this.GachaProbabilityId == other.GachaProbabilityId && this.FreeDrawFlag == other.FreeDrawFlag && this.MaxDrawNum == other.MaxDrawNum && this.BeforeGachaId == other.BeforeGachaId && this.BeforeDrawNum == other.BeforeDrawNum && this.PickupOpenedAt == other.PickupOpenedAt && this.PickupClosedAt == other.PickupClosedAt && this.OpenedAt == other.OpenedAt && this.ClosedAt == other.ClosedAt && this.CondQuestId == other.CondQuestId && this.CondQuestPhase == other.CondQuestPhase && !(this.DetailUrl != other.DetailUrl) && this.BannerQuestId == other.BannerQuestId && this.BannerQuestPhase == other.BannerQuestPhase && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
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
			if (this.ImageId != 0)
			{
				num ^= this.ImageId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.WarId != 0)
			{
				num ^= this.WarId.GetHashCode();
			}
			if (this.GachaSlot != 0)
			{
				num ^= this.GachaSlot.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ShopId1 != 0)
			{
				num ^= this.ShopId1.GetHashCode();
			}
			if (this.ShopId2 != 0)
			{
				num ^= this.ShopId2.GetHashCode();
			}
			if (this.RarityId != 0)
			{
				num ^= this.RarityId.GetHashCode();
			}
			if (this.BaseId != 0)
			{
				num ^= this.BaseId.GetHashCode();
			}
			if (this.AdjustId != 0)
			{
				num ^= this.AdjustId.GetHashCode();
			}
			if (this.PickupId != 0)
			{
				num ^= this.PickupId.GetHashCode();
			}
			if (this.TicketItemId != 0)
			{
				num ^= this.TicketItemId.GetHashCode();
			}
			if (this.GachaGroupId != 0)
			{
				num ^= this.GachaGroupId.GetHashCode();
			}
			if (this.DrawNum1 != 0)
			{
				num ^= this.DrawNum1.GetHashCode();
			}
			if (this.DrawNum2 != 0)
			{
				num ^= this.DrawNum2.GetHashCode();
			}
			if (this.GachaProbabilityId != 0)
			{
				num ^= this.GachaProbabilityId.GetHashCode();
			}
			if (this.FreeDrawFlag != 0)
			{
				num ^= this.FreeDrawFlag.GetHashCode();
			}
			if (this.MaxDrawNum != 0)
			{
				num ^= this.MaxDrawNum.GetHashCode();
			}
			if (this.BeforeGachaId != 0)
			{
				num ^= this.BeforeGachaId.GetHashCode();
			}
			if (this.BeforeDrawNum != 0)
			{
				num ^= this.BeforeDrawNum.GetHashCode();
			}
			if (this.PickupOpenedAt != 0uL)
			{
				num ^= this.PickupOpenedAt.GetHashCode();
			}
			if (this.PickupClosedAt != 0uL)
			{
				num ^= this.PickupClosedAt.GetHashCode();
			}
			if (this.OpenedAt != 0uL)
			{
				num ^= this.OpenedAt.GetHashCode();
			}
			if (this.ClosedAt != 0uL)
			{
				num ^= this.ClosedAt.GetHashCode();
			}
			if (this.CondQuestId != 0)
			{
				num ^= this.CondQuestId.GetHashCode();
			}
			if (this.CondQuestPhase != 0)
			{
				num ^= this.CondQuestPhase.GetHashCode();
			}
			if (this.DetailUrl.Length != 0)
			{
				num ^= this.DetailUrl.GetHashCode();
			}
			if (this.BannerQuestId != 0)
			{
				num ^= this.BannerQuestId.GetHashCode();
			}
			if (this.BannerQuestPhase != 0)
			{
				num ^= this.BannerQuestPhase.GetHashCode();
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
			if (this.ImageId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ImageId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Priority);
			}
			if (this.WarId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WarId);
			}
			if (this.GachaSlot != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GachaSlot);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Type);
			}
			if (this.ShopId1 != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ShopId1);
			}
			if (this.ShopId2 != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ShopId2);
			}
			if (this.RarityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RarityId);
			}
			if (this.BaseId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BaseId);
			}
			if (this.AdjustId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AdjustId);
			}
			if (this.PickupId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PickupId);
			}
			if (this.TicketItemId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TicketItemId);
			}
			if (this.GachaGroupId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.GachaGroupId);
			}
			if (this.DrawNum1 != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.DrawNum1);
			}
			if (this.DrawNum2 != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.DrawNum2);
			}
			if (this.GachaProbabilityId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.GachaProbabilityId);
			}
			if (this.FreeDrawFlag != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.FreeDrawFlag);
			}
			if (this.MaxDrawNum != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.MaxDrawNum);
			}
			if (this.BeforeGachaId != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.BeforeGachaId);
			}
			if (this.BeforeDrawNum != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.BeforeDrawNum);
			}
			if (this.PickupOpenedAt != 0uL)
			{
				output.WriteRawTag(184, 1);
				output.WriteUInt64(this.PickupOpenedAt);
			}
			if (this.PickupClosedAt != 0uL)
			{
				output.WriteRawTag(192, 1);
				output.WriteUInt64(this.PickupClosedAt);
			}
			if (this.OpenedAt != 0uL)
			{
				output.WriteRawTag(200, 1);
				output.WriteUInt64(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(208, 1);
				output.WriteUInt64(this.ClosedAt);
			}
			if (this.CondQuestId != 0)
			{
				output.WriteRawTag(216, 1);
				output.WriteInt32(this.CondQuestId);
			}
			if (this.CondQuestPhase != 0)
			{
				output.WriteRawTag(224, 1);
				output.WriteInt32(this.CondQuestPhase);
			}
			if (this.DetailUrl.Length != 0)
			{
				output.WriteRawTag(234, 1);
				output.WriteBytes(this.DetailUrl);
			}
			if (this.BannerQuestId != 0)
			{
				output.WriteRawTag(240, 1);
				output.WriteInt32(this.BannerQuestId);
			}
			if (this.BannerQuestPhase != 0)
			{
				output.WriteRawTag(248, 1);
				output.WriteInt32(this.BannerQuestPhase);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(128, 2);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(136, 2);
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
			if (this.ImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.WarId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WarId);
			}
			if (this.GachaSlot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaSlot);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.ShopId1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId1);
			}
			if (this.ShopId2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId2);
			}
			if (this.RarityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RarityId);
			}
			if (this.BaseId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseId);
			}
			if (this.AdjustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdjustId);
			}
			if (this.PickupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PickupId);
			}
			if (this.TicketItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TicketItemId);
			}
			if (this.GachaGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaGroupId);
			}
			if (this.DrawNum1 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DrawNum1);
			}
			if (this.DrawNum2 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DrawNum2);
			}
			if (this.GachaProbabilityId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.GachaProbabilityId);
			}
			if (this.FreeDrawFlag != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FreeDrawFlag);
			}
			if (this.MaxDrawNum != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxDrawNum);
			}
			if (this.BeforeGachaId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BeforeGachaId);
			}
			if (this.BeforeDrawNum != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BeforeDrawNum);
			}
			if (this.PickupOpenedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.PickupOpenedAt);
			}
			if (this.PickupClosedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.PickupClosedAt);
			}
			if (this.OpenedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.ClosedAt);
			}
			if (this.CondQuestId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CondQuestId);
			}
			if (this.CondQuestPhase != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CondQuestPhase);
			}
			if (this.DetailUrl.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.DetailUrl);
			}
			if (this.BannerQuestId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BannerQuestId);
			}
			if (this.BannerQuestPhase != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BannerQuestPhase);
			}
			if (this.UpdatedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_GACHA other)
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
			if (other.ImageId != 0)
			{
				this.ImageId = other.ImageId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.WarId != 0)
			{
				this.WarId = other.WarId;
			}
			if (other.GachaSlot != 0)
			{
				this.GachaSlot = other.GachaSlot;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.ShopId1 != 0)
			{
				this.ShopId1 = other.ShopId1;
			}
			if (other.ShopId2 != 0)
			{
				this.ShopId2 = other.ShopId2;
			}
			if (other.RarityId != 0)
			{
				this.RarityId = other.RarityId;
			}
			if (other.BaseId != 0)
			{
				this.BaseId = other.BaseId;
			}
			if (other.AdjustId != 0)
			{
				this.AdjustId = other.AdjustId;
			}
			if (other.PickupId != 0)
			{
				this.PickupId = other.PickupId;
			}
			if (other.TicketItemId != 0)
			{
				this.TicketItemId = other.TicketItemId;
			}
			if (other.GachaGroupId != 0)
			{
				this.GachaGroupId = other.GachaGroupId;
			}
			if (other.DrawNum1 != 0)
			{
				this.DrawNum1 = other.DrawNum1;
			}
			if (other.DrawNum2 != 0)
			{
				this.DrawNum2 = other.DrawNum2;
			}
			if (other.GachaProbabilityId != 0)
			{
				this.GachaProbabilityId = other.GachaProbabilityId;
			}
			if (other.FreeDrawFlag != 0)
			{
				this.FreeDrawFlag = other.FreeDrawFlag;
			}
			if (other.MaxDrawNum != 0)
			{
				this.MaxDrawNum = other.MaxDrawNum;
			}
			if (other.BeforeGachaId != 0)
			{
				this.BeforeGachaId = other.BeforeGachaId;
			}
			if (other.BeforeDrawNum != 0)
			{
				this.BeforeDrawNum = other.BeforeDrawNum;
			}
			if (other.PickupOpenedAt != 0uL)
			{
				this.PickupOpenedAt = other.PickupOpenedAt;
			}
			if (other.PickupClosedAt != 0uL)
			{
				this.PickupClosedAt = other.PickupClosedAt;
			}
			if (other.OpenedAt != 0uL)
			{
				this.OpenedAt = other.OpenedAt;
			}
			if (other.ClosedAt != 0uL)
			{
				this.ClosedAt = other.ClosedAt;
			}
			if (other.CondQuestId != 0)
			{
				this.CondQuestId = other.CondQuestId;
			}
			if (other.CondQuestPhase != 0)
			{
				this.CondQuestPhase = other.CondQuestPhase;
			}
			if (other.DetailUrl.Length != 0)
			{
				this.DetailUrl = other.DetailUrl;
			}
			if (other.BannerQuestId != 0)
			{
				this.BannerQuestId = other.BannerQuestId;
			}
			if (other.BannerQuestPhase != 0)
			{
				this.BannerQuestPhase = other.BannerQuestPhase;
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
																	if (num2 != 112u)
																	{
																		if (num2 != 120u)
																		{
																			if (num2 != 128u)
																			{
																				if (num2 != 136u)
																				{
																					if (num2 != 144u)
																					{
																						if (num2 != 152u)
																						{
																							if (num2 != 160u)
																							{
																								if (num2 != 168u)
																								{
																									if (num2 != 176u)
																									{
																										if (num2 != 184u)
																										{
																											if (num2 != 192u)
																											{
																												if (num2 != 200u)
																												{
																													if (num2 != 208u)
																													{
																														if (num2 != 216u)
																														{
																															if (num2 != 224u)
																															{
																																if (num2 != 234u)
																																{
																																	if (num2 != 240u)
																																	{
																																		if (num2 != 248u)
																																		{
																																			if (num2 != 256u)
																																			{
																																				if (num2 != 264u)
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
																																			this.BannerQuestPhase = input.ReadInt32();
																																		}
																																	}
																																	else
																																	{
																																		this.BannerQuestId = input.ReadInt32();
																																	}
																																}
																																else
																																{
																																	this.DetailUrl = input.ReadBytes();
																																}
																															}
																															else
																															{
																																this.CondQuestPhase = input.ReadInt32();
																															}
																														}
																														else
																														{
																															this.CondQuestId = input.ReadInt32();
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
																												this.PickupClosedAt = input.ReadUInt64();
																											}
																										}
																										else
																										{
																											this.PickupOpenedAt = input.ReadUInt64();
																										}
																									}
																									else
																									{
																										this.BeforeDrawNum = input.ReadInt32();
																									}
																								}
																								else
																								{
																									this.BeforeGachaId = input.ReadInt32();
																								}
																							}
																							else
																							{
																								this.MaxDrawNum = input.ReadInt32();
																							}
																						}
																						else
																						{
																							this.FreeDrawFlag = input.ReadInt32();
																						}
																					}
																					else
																					{
																						this.GachaProbabilityId = input.ReadInt32();
																					}
																				}
																				else
																				{
																					this.DrawNum2 = input.ReadInt32();
																				}
																			}
																			else
																			{
																				this.DrawNum1 = input.ReadInt32();
																			}
																		}
																		else
																		{
																			this.GachaGroupId = input.ReadInt32();
																		}
																	}
																	else
																	{
																		this.TicketItemId = input.ReadInt32();
																	}
																}
																else
																{
																	this.PickupId = input.ReadInt32();
																}
															}
															else
															{
																this.AdjustId = input.ReadInt32();
															}
														}
														else
														{
															this.BaseId = input.ReadInt32();
														}
													}
													else
													{
														this.RarityId = input.ReadInt32();
													}
												}
												else
												{
													this.ShopId2 = input.ReadInt32();
												}
											}
											else
											{
												this.ShopId1 = input.ReadInt32();
											}
										}
										else
										{
											this.Type = input.ReadInt32();
										}
									}
									else
									{
										this.GachaSlot = input.ReadInt32();
									}
								}
								else
								{
									this.WarId = input.ReadInt32();
								}
							}
							else
							{
								this.Priority = input.ReadInt32();
							}
						}
						else
						{
							this.ImageId = input.ReadInt32();
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
