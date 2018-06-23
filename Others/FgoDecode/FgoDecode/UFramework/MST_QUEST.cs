using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST : IMessage, IMessage<MST_QUEST>, IEquatable<MST_QUEST>, IDeepCloneable<MST_QUEST>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		public const int NameRubyFieldNumber = 3;

		public const int TypeFieldNumber = 4;

		public const int ConsumeTypeFieldNumber = 5;

		public const int ActConsumeFieldNumber = 6;

		public const int ChaldeaGateCategoryFieldNumber = 7;

		public const int SpotIdFieldNumber = 8;

		public const int GiftIdFieldNumber = 9;

		public const int PriorityFieldNumber = 10;

		public const int BannerIdFieldNumber = 11;

		public const int IconIdFieldNumber = 12;

		public const int CharaIconIdFieldNumber = 13;

		public const int GiftIconIdFieldNumber = 14;

		public const int ForceOperationFieldNumber = 15;

		public const int AfterClearFieldNumber = 16;

		public const int AfterActionValsFieldNumber = 17;

		public const int DisplayHoursFieldNumber = 18;

		public const int IntervalHoursFieldNumber = 19;

		public const int ChapterIdFieldNumber = 20;

		public const int ChapterSubIdFieldNumber = 21;

		public const int RecommendLvFieldNumber = 22;

		public const int HasStartActionFieldNumber = 23;

		public const int FlagFieldNumber = 24;

		public const int ScriptQuestIdFieldNumber = 25;

		public const int NoticeAtFieldNumber = 26;

		public const int OpenedAtFieldNumber = 27;

		public const int ClosedAtFieldNumber = 28;

		private static readonly MessageParser<MST_QUEST> _parser = new MessageParser<MST_QUEST>(() => new MST_QUEST());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		private ByteString nameRuby_ = ByteString.Empty;

		private int type_;

		private int consumeType_;

		private int actConsume_;

		private int chaldeaGateCategory_;

		private int spotId_;

		private int giftId_;

		private int priority_;

		private int bannerId_;

		private int iconId_;

		private int charaIconId_;

		private int giftIconId_;

		private int forceOperation_;

		private int afterClear_;

		private static readonly FieldCodec<ByteString> _repeated_afterActionVals_codec = FieldCodec.ForBytes(138u);

		private readonly RepeatedField<ByteString> afterActionVals_ = new RepeatedField<ByteString>();

		private int displayHours_;

		private int intervalHours_;

		private int chapterId_;

		private int chapterSubId_;

		private int recommendLv_;

		private int hasStartAction_;

		private int flag_;

		private int scriptQuestId_;

		private ulong noticeAt_;

		private ulong openedAt_;

		private ulong closedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST> Parser => MST_QUEST._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestReflection.Descriptor.MessageTypes[0];

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
		public ByteString NameRuby
		{
			get => this.nameRuby_;
			set
			{
				this.nameRuby_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int ConsumeType
		{
			get => this.consumeType_;
			set
			{
				this.consumeType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ActConsume
		{
			get => this.actConsume_;
			set
			{
				this.actConsume_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ChaldeaGateCategory
		{
			get => this.chaldeaGateCategory_;
			set
			{
				this.chaldeaGateCategory_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SpotId
		{
			get => this.spotId_;
			set
			{
				this.spotId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GiftId
		{
			get => this.giftId_;
			set
			{
				this.giftId_ = value;
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
		public int BannerId
		{
			get => this.bannerId_;
			set
			{
				this.bannerId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IconId
		{
			get => this.iconId_;
			set
			{
				this.iconId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CharaIconId
		{
			get => this.charaIconId_;
			set
			{
				this.charaIconId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GiftIconId
		{
			get => this.giftIconId_;
			set
			{
				this.giftIconId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ForceOperation
		{
			get => this.forceOperation_;
			set
			{
				this.forceOperation_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AfterClear
		{
			get => this.afterClear_;
			set
			{
				this.afterClear_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> AfterActionVals => this.afterActionVals_;

		[DebuggerNonUserCode]
		public int DisplayHours
		{
			get => this.displayHours_;
			set
			{
				this.displayHours_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IntervalHours
		{
			get => this.intervalHours_;
			set
			{
				this.intervalHours_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ChapterId
		{
			get => this.chapterId_;
			set
			{
				this.chapterId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ChapterSubId
		{
			get => this.chapterSubId_;
			set
			{
				this.chapterSubId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int RecommendLv
		{
			get => this.recommendLv_;
			set
			{
				this.recommendLv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int HasStartAction
		{
			get => this.hasStartAction_;
			set
			{
				this.hasStartAction_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Flag
		{
			get => this.flag_;
			set
			{
				this.flag_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ScriptQuestId
		{
			get => this.scriptQuestId_;
			set
			{
				this.scriptQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong NoticeAt
		{
			get => this.noticeAt_;
			set
			{
				this.noticeAt_ = value;
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
		public MST_QUEST()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST(MST_QUEST other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.nameRuby_ = other.nameRuby_;
			this.type_ = other.type_;
			this.consumeType_ = other.consumeType_;
			this.actConsume_ = other.actConsume_;
			this.chaldeaGateCategory_ = other.chaldeaGateCategory_;
			this.spotId_ = other.spotId_;
			this.giftId_ = other.giftId_;
			this.priority_ = other.priority_;
			this.bannerId_ = other.bannerId_;
			this.iconId_ = other.iconId_;
			this.charaIconId_ = other.charaIconId_;
			this.giftIconId_ = other.giftIconId_;
			this.forceOperation_ = other.forceOperation_;
			this.afterClear_ = other.afterClear_;
			this.afterActionVals_ = other.afterActionVals_.Clone();
			this.displayHours_ = other.displayHours_;
			this.intervalHours_ = other.intervalHours_;
			this.chapterId_ = other.chapterId_;
			this.chapterSubId_ = other.chapterSubId_;
			this.recommendLv_ = other.recommendLv_;
			this.hasStartAction_ = other.hasStartAction_;
			this.flag_ = other.flag_;
			this.scriptQuestId_ = other.scriptQuestId_;
			this.noticeAt_ = other.noticeAt_;
			this.openedAt_ = other.openedAt_;
			this.closedAt_ = other.closedAt_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST Clone()
		{
			return new MST_QUEST(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name) && !(this.NameRuby != other.NameRuby) && this.Type == other.Type && this.ConsumeType == other.ConsumeType && this.ActConsume == other.ActConsume && this.ChaldeaGateCategory == other.ChaldeaGateCategory && this.SpotId == other.SpotId && this.GiftId == other.GiftId && this.Priority == other.Priority && this.BannerId == other.BannerId && this.IconId == other.IconId && this.CharaIconId == other.CharaIconId && this.GiftIconId == other.GiftIconId && this.ForceOperation == other.ForceOperation && this.AfterClear == other.AfterClear && this.afterActionVals_.Equals(other.afterActionVals_) && this.DisplayHours == other.DisplayHours && this.IntervalHours == other.IntervalHours && this.ChapterId == other.ChapterId && this.ChapterSubId == other.ChapterSubId && this.RecommendLv == other.RecommendLv && this.HasStartAction == other.HasStartAction && this.Flag == other.Flag && this.ScriptQuestId == other.ScriptQuestId && this.NoticeAt == other.NoticeAt && this.OpenedAt == other.OpenedAt && this.ClosedAt == other.ClosedAt));
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
			if (this.NameRuby.Length != 0)
			{
				num ^= this.NameRuby.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ConsumeType != 0)
			{
				num ^= this.ConsumeType.GetHashCode();
			}
			if (this.ActConsume != 0)
			{
				num ^= this.ActConsume.GetHashCode();
			}
			if (this.ChaldeaGateCategory != 0)
			{
				num ^= this.ChaldeaGateCategory.GetHashCode();
			}
			if (this.SpotId != 0)
			{
				num ^= this.SpotId.GetHashCode();
			}
			if (this.GiftId != 0)
			{
				num ^= this.GiftId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.BannerId != 0)
			{
				num ^= this.BannerId.GetHashCode();
			}
			if (this.IconId != 0)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this.CharaIconId != 0)
			{
				num ^= this.CharaIconId.GetHashCode();
			}
			if (this.GiftIconId != 0)
			{
				num ^= this.GiftIconId.GetHashCode();
			}
			if (this.ForceOperation != 0)
			{
				num ^= this.ForceOperation.GetHashCode();
			}
			if (this.AfterClear != 0)
			{
				num ^= this.AfterClear.GetHashCode();
			}
			num ^= this.afterActionVals_.GetHashCode();
			if (this.DisplayHours != 0)
			{
				num ^= this.DisplayHours.GetHashCode();
			}
			if (this.IntervalHours != 0)
			{
				num ^= this.IntervalHours.GetHashCode();
			}
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this.ChapterSubId != 0)
			{
				num ^= this.ChapterSubId.GetHashCode();
			}
			if (this.RecommendLv != 0)
			{
				num ^= this.RecommendLv.GetHashCode();
			}
			if (this.HasStartAction != 0)
			{
				num ^= this.HasStartAction.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.ScriptQuestId != 0)
			{
				num ^= this.ScriptQuestId.GetHashCode();
			}
			if (this.NoticeAt != 0uL)
			{
				num ^= this.NoticeAt.GetHashCode();
			}
			if (this.OpenedAt != 0uL)
			{
				num ^= this.OpenedAt.GetHashCode();
			}
			if (this.ClosedAt != 0uL)
			{
				num ^= this.ClosedAt.GetHashCode();
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
			if (this.NameRuby.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.NameRuby);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Type);
			}
			if (this.ConsumeType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ConsumeType);
			}
			if (this.ActConsume != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActConsume);
			}
			if (this.ChaldeaGateCategory != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChaldeaGateCategory);
			}
			if (this.SpotId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SpotId);
			}
			if (this.GiftId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GiftId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Priority);
			}
			if (this.BannerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BannerId);
			}
			if (this.IconId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IconId);
			}
			if (this.CharaIconId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CharaIconId);
			}
			if (this.GiftIconId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.GiftIconId);
			}
			if (this.ForceOperation != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ForceOperation);
			}
			if (this.AfterClear != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.AfterClear);
			}
			this.afterActionVals_.WriteTo(output, MST_QUEST._repeated_afterActionVals_codec);
			if (this.DisplayHours != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.DisplayHours);
			}
			if (this.IntervalHours != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.IntervalHours);
			}
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.ChapterId);
			}
			if (this.ChapterSubId != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.ChapterSubId);
			}
			if (this.RecommendLv != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.RecommendLv);
			}
			if (this.HasStartAction != 0)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.HasStartAction);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt32(this.Flag);
			}
			if (this.ScriptQuestId != 0)
			{
				output.WriteRawTag(200, 1);
				output.WriteInt32(this.ScriptQuestId);
			}
			if (this.NoticeAt != 0uL)
			{
				output.WriteRawTag(208, 1);
				output.WriteUInt64(this.NoticeAt);
			}
			if (this.OpenedAt != 0uL)
			{
				output.WriteRawTag(216, 1);
				output.WriteUInt64(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(224, 1);
				output.WriteUInt64(this.ClosedAt);
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
			if (this.NameRuby.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.NameRuby);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.ConsumeType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConsumeType);
			}
			if (this.ActConsume != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActConsume);
			}
			if (this.ChaldeaGateCategory != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChaldeaGateCategory);
			}
			if (this.SpotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpotId);
			}
			if (this.GiftId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.BannerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BannerId);
			}
			if (this.IconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconId);
			}
			if (this.CharaIconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CharaIconId);
			}
			if (this.GiftIconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftIconId);
			}
			if (this.ForceOperation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ForceOperation);
			}
			if (this.AfterClear != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.AfterClear);
			}
			num += this.afterActionVals_.CalculateSize(MST_QUEST._repeated_afterActionVals_codec);
			if (this.DisplayHours != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DisplayHours);
			}
			if (this.IntervalHours != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.IntervalHours);
			}
			if (this.ChapterId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this.ChapterSubId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ChapterSubId);
			}
			if (this.RecommendLv != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RecommendLv);
			}
			if (this.HasStartAction != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.HasStartAction);
			}
			if (this.Flag != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.ScriptQuestId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ScriptQuestId);
			}
			if (this.NoticeAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.NoticeAt);
			}
			if (this.OpenedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.ClosedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST other)
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
			if (other.NameRuby.Length != 0)
			{
				this.NameRuby = other.NameRuby;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.ConsumeType != 0)
			{
				this.ConsumeType = other.ConsumeType;
			}
			if (other.ActConsume != 0)
			{
				this.ActConsume = other.ActConsume;
			}
			if (other.ChaldeaGateCategory != 0)
			{
				this.ChaldeaGateCategory = other.ChaldeaGateCategory;
			}
			if (other.SpotId != 0)
			{
				this.SpotId = other.SpotId;
			}
			if (other.GiftId != 0)
			{
				this.GiftId = other.GiftId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.BannerId != 0)
			{
				this.BannerId = other.BannerId;
			}
			if (other.IconId != 0)
			{
				this.IconId = other.IconId;
			}
			if (other.CharaIconId != 0)
			{
				this.CharaIconId = other.CharaIconId;
			}
			if (other.GiftIconId != 0)
			{
				this.GiftIconId = other.GiftIconId;
			}
			if (other.ForceOperation != 0)
			{
				this.ForceOperation = other.ForceOperation;
			}
			if (other.AfterClear != 0)
			{
				this.AfterClear = other.AfterClear;
			}
			this.afterActionVals_.Add(other.afterActionVals_);
			if (other.DisplayHours != 0)
			{
				this.DisplayHours = other.DisplayHours;
			}
			if (other.IntervalHours != 0)
			{
				this.IntervalHours = other.IntervalHours;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			if (other.ChapterSubId != 0)
			{
				this.ChapterSubId = other.ChapterSubId;
			}
			if (other.RecommendLv != 0)
			{
				this.RecommendLv = other.RecommendLv;
			}
			if (other.HasStartAction != 0)
			{
				this.HasStartAction = other.HasStartAction;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			if (other.ScriptQuestId != 0)
			{
				this.ScriptQuestId = other.ScriptQuestId;
			}
			if (other.NoticeAt != 0uL)
			{
				this.NoticeAt = other.NoticeAt;
			}
			if (other.OpenedAt != 0uL)
			{
				this.OpenedAt = other.OpenedAt;
			}
			if (other.ClosedAt != 0uL)
			{
				this.ClosedAt = other.ClosedAt;
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
																if (num2 != 104u)
																{
																	if (num2 != 112u)
																	{
																		if (num2 != 120u)
																		{
																			if (num2 != 128u)
																			{
																				if (num2 != 138u)
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
																																input.SkipLastField();
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
																														this.NoticeAt = input.ReadUInt64();
																													}
																												}
																												else
																												{
																													this.ScriptQuestId = input.ReadInt32();
																												}
																											}
																											else
																											{
																												this.Flag = input.ReadInt32();
																											}
																										}
																										else
																										{
																											this.HasStartAction = input.ReadInt32();
																										}
																									}
																									else
																									{
																										this.RecommendLv = input.ReadInt32();
																									}
																								}
																								else
																								{
																									this.ChapterSubId = input.ReadInt32();
																								}
																							}
																							else
																							{
																								this.ChapterId = input.ReadInt32();
																							}
																						}
																						else
																						{
																							this.IntervalHours = input.ReadInt32();
																						}
																					}
																					else
																					{
																						this.DisplayHours = input.ReadInt32();
																					}
																				}
																				else
																				{
																					this.afterActionVals_.AddEntriesFrom(input, MST_QUEST._repeated_afterActionVals_codec);
																				}
																			}
																			else
																			{
																				this.AfterClear = input.ReadInt32();
																			}
																		}
																		else
																		{
																			this.ForceOperation = input.ReadInt32();
																		}
																	}
																	else
																	{
																		this.GiftIconId = input.ReadInt32();
																	}
																}
																else
																{
																	this.CharaIconId = input.ReadInt32();
																}
															}
															else
															{
																this.IconId = input.ReadInt32();
															}
														}
														else
														{
															this.BannerId = input.ReadInt32();
														}
													}
													else
													{
														this.Priority = input.ReadInt32();
													}
												}
												else
												{
													this.GiftId = input.ReadInt32();
												}
											}
											else
											{
												this.SpotId = input.ReadInt32();
											}
										}
										else
										{
											this.ChaldeaGateCategory = input.ReadInt32();
										}
									}
									else
									{
										this.ActConsume = input.ReadInt32();
									}
								}
								else
								{
									this.ConsumeType = input.ReadInt32();
								}
							}
							else
							{
								this.Type = input.ReadInt32();
							}
						}
						else
						{
							this.NameRuby = input.ReadBytes();
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
