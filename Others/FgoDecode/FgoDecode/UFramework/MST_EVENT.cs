using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT : IMessage, IMessage<MST_EVENT>, IEquatable<MST_EVENT>, IDeepCloneable<MST_EVENT>
	{
		public const int IdFieldNumber = 1;

		public const int BaseEventIdFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int OpenTypeFieldNumber = 4;

		public const int NameFieldNumber = 5;

		public const int DetailFieldNumber = 6;

		public const int NoticeBannerIdFieldNumber = 7;

		public const int BannerIdFieldNumber = 8;

		public const int IconIdFieldNumber = 9;

		public const int BannerPriorityFieldNumber = 10;

		public const int OpenHoursFieldNumber = 11;

		public const int IntervalHoursFieldNumber = 12;

		public const int NoticeAtFieldNumber = 13;

		public const int StartedAtFieldNumber = 14;

		public const int EndedAtFieldNumber = 15;

		public const int FinishedAtFieldNumber = 16;

		public const int MaterialOpenedAtFieldNumber = 17;

		public const int LinkTypeFieldNumber = 18;

		public const int LinkBodyFieldNumber = 19;

		public const int DeviceTypeFieldNumber = 20;

		public const int MyroomBgIdFieldNumber = 21;

		public const int MyroomBgmIdFieldNumber = 22;

		public const int UpdatedAtFieldNumber = 23;

		public const int CreatedAtFieldNumber = 24;

		private static readonly MessageParser<MST_EVENT> _parser = new MessageParser<MST_EVENT>(() => new MST_EVENT());

		private int id_;

		private int baseEventId_;

		private int type_;

		private int openType_;

		private ByteString name_ = ByteString.Empty;

		private ByteString detail_ = ByteString.Empty;

		private int noticeBannerId_;

		private int bannerId_;

		private int iconId_;

		private int bannerPriority_;

		private int openHours_;

		private int intervalHours_;

		private ulong noticeAt_;

		private ulong startedAt_;

		private ulong endedAt_;

		private ulong finishedAt_;

		private ulong materialOpenedAt_;

		private int linkType_;

		private ByteString linkBody_ = ByteString.Empty;

		private int deviceType_;

		private int myroomBgId_;

		private int myroomBgmId_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT> Parser => MST_EVENT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventReflection.Descriptor.MessageTypes[0];

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
		public int BaseEventId
		{
			get => this.baseEventId_;
			set
			{
				this.baseEventId_ = value;
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
		public int OpenType
		{
			get => this.openType_;
			set
			{
				this.openType_ = value;
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
		public int NoticeBannerId
		{
			get => this.noticeBannerId_;
			set
			{
				this.noticeBannerId_ = value;
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
		public int BannerPriority
		{
			get => this.bannerPriority_;
			set
			{
				this.bannerPriority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OpenHours
		{
			get => this.openHours_;
			set
			{
				this.openHours_ = value;
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
		public ulong NoticeAt
		{
			get => this.noticeAt_;
			set
			{
				this.noticeAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong StartedAt
		{
			get => this.startedAt_;
			set
			{
				this.startedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong EndedAt
		{
			get => this.endedAt_;
			set
			{
				this.endedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong FinishedAt
		{
			get => this.finishedAt_;
			set
			{
				this.finishedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong MaterialOpenedAt
		{
			get => this.materialOpenedAt_;
			set
			{
				this.materialOpenedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int LinkType
		{
			get => this.linkType_;
			set
			{
				this.linkType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString LinkBody
		{
			get => this.linkBody_;
			set
			{
				this.linkBody_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int DeviceType
		{
			get => this.deviceType_;
			set
			{
				this.deviceType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MyroomBgId
		{
			get => this.myroomBgId_;
			set
			{
				this.myroomBgId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MyroomBgmId
		{
			get => this.myroomBgmId_;
			set
			{
				this.myroomBgmId_ = value;
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
		public MST_EVENT()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT(MST_EVENT other) : this()
		{
			this.id_ = other.id_;
			this.baseEventId_ = other.baseEventId_;
			this.type_ = other.type_;
			this.openType_ = other.openType_;
			this.name_ = other.name_;
			this.detail_ = other.detail_;
			this.noticeBannerId_ = other.noticeBannerId_;
			this.bannerId_ = other.bannerId_;
			this.iconId_ = other.iconId_;
			this.bannerPriority_ = other.bannerPriority_;
			this.openHours_ = other.openHours_;
			this.intervalHours_ = other.intervalHours_;
			this.noticeAt_ = other.noticeAt_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
			this.finishedAt_ = other.finishedAt_;
			this.materialOpenedAt_ = other.materialOpenedAt_;
			this.linkType_ = other.linkType_;
			this.linkBody_ = other.linkBody_;
			this.deviceType_ = other.deviceType_;
			this.myroomBgId_ = other.myroomBgId_;
			this.myroomBgmId_ = other.myroomBgmId_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT Clone()
		{
			return new MST_EVENT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.BaseEventId == other.BaseEventId && this.Type == other.Type && this.OpenType == other.OpenType && !(this.Name != other.Name) && !(this.Detail != other.Detail) && this.NoticeBannerId == other.NoticeBannerId && this.BannerId == other.BannerId && this.IconId == other.IconId && this.BannerPriority == other.BannerPriority && this.OpenHours == other.OpenHours && this.IntervalHours == other.IntervalHours && this.NoticeAt == other.NoticeAt && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt && this.FinishedAt == other.FinishedAt && this.MaterialOpenedAt == other.MaterialOpenedAt && this.LinkType == other.LinkType && !(this.LinkBody != other.LinkBody) && this.DeviceType == other.DeviceType && this.MyroomBgId == other.MyroomBgId && this.MyroomBgmId == other.MyroomBgmId && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BaseEventId != 0)
			{
				num ^= this.BaseEventId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.OpenType != 0)
			{
				num ^= this.OpenType.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this.NoticeBannerId != 0)
			{
				num ^= this.NoticeBannerId.GetHashCode();
			}
			if (this.BannerId != 0)
			{
				num ^= this.BannerId.GetHashCode();
			}
			if (this.IconId != 0)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this.BannerPriority != 0)
			{
				num ^= this.BannerPriority.GetHashCode();
			}
			if (this.OpenHours != 0)
			{
				num ^= this.OpenHours.GetHashCode();
			}
			if (this.IntervalHours != 0)
			{
				num ^= this.IntervalHours.GetHashCode();
			}
			if (this.NoticeAt != 0uL)
			{
				num ^= this.NoticeAt.GetHashCode();
			}
			if (this.StartedAt != 0uL)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			if (this.EndedAt != 0uL)
			{
				num ^= this.EndedAt.GetHashCode();
			}
			if (this.FinishedAt != 0uL)
			{
				num ^= this.FinishedAt.GetHashCode();
			}
			if (this.MaterialOpenedAt != 0uL)
			{
				num ^= this.MaterialOpenedAt.GetHashCode();
			}
			if (this.LinkType != 0)
			{
				num ^= this.LinkType.GetHashCode();
			}
			if (this.LinkBody.Length != 0)
			{
				num ^= this.LinkBody.GetHashCode();
			}
			if (this.DeviceType != 0)
			{
				num ^= this.DeviceType.GetHashCode();
			}
			if (this.MyroomBgId != 0)
			{
				num ^= this.MyroomBgId.GetHashCode();
			}
			if (this.MyroomBgmId != 0)
			{
				num ^= this.MyroomBgmId.GetHashCode();
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
			if (this.BaseEventId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BaseEventId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.OpenType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OpenType);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteBytes(this.Detail);
			}
			if (this.NoticeBannerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NoticeBannerId);
			}
			if (this.BannerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BannerId);
			}
			if (this.IconId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IconId);
			}
			if (this.BannerPriority != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.BannerPriority);
			}
			if (this.OpenHours != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.OpenHours);
			}
			if (this.IntervalHours != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IntervalHours);
			}
			if (this.NoticeAt != 0uL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.NoticeAt);
			}
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(120);
				output.WriteUInt64(this.EndedAt);
			}
			if (this.FinishedAt != 0uL)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt64(this.FinishedAt);
			}
			if (this.MaterialOpenedAt != 0uL)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt64(this.MaterialOpenedAt);
			}
			if (this.LinkType != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.LinkType);
			}
			if (this.LinkBody.Length != 0)
			{
				output.WriteRawTag(154, 1);
				output.WriteBytes(this.LinkBody);
			}
			if (this.DeviceType != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.DeviceType);
			}
			if (this.MyroomBgId != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.MyroomBgId);
			}
			if (this.MyroomBgmId != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.MyroomBgmId);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(184, 1);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(192, 1);
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
			if (this.BaseEventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseEventId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.OpenType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OpenType);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			if (this.NoticeBannerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NoticeBannerId);
			}
			if (this.BannerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BannerId);
			}
			if (this.IconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconId);
			}
			if (this.BannerPriority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BannerPriority);
			}
			if (this.OpenHours != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OpenHours);
			}
			if (this.IntervalHours != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IntervalHours);
			}
			if (this.NoticeAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.NoticeAt);
			}
			if (this.StartedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndedAt);
			}
			if (this.FinishedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.FinishedAt);
			}
			if (this.MaterialOpenedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.MaterialOpenedAt);
			}
			if (this.LinkType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.LinkType);
			}
			if (this.LinkBody.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.LinkBody);
			}
			if (this.DeviceType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DeviceType);
			}
			if (this.MyroomBgId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MyroomBgId);
			}
			if (this.MyroomBgmId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MyroomBgmId);
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
		public void MergeFrom(MST_EVENT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BaseEventId != 0)
			{
				this.BaseEventId = other.BaseEventId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.OpenType != 0)
			{
				this.OpenType = other.OpenType;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			if (other.NoticeBannerId != 0)
			{
				this.NoticeBannerId = other.NoticeBannerId;
			}
			if (other.BannerId != 0)
			{
				this.BannerId = other.BannerId;
			}
			if (other.IconId != 0)
			{
				this.IconId = other.IconId;
			}
			if (other.BannerPriority != 0)
			{
				this.BannerPriority = other.BannerPriority;
			}
			if (other.OpenHours != 0)
			{
				this.OpenHours = other.OpenHours;
			}
			if (other.IntervalHours != 0)
			{
				this.IntervalHours = other.IntervalHours;
			}
			if (other.NoticeAt != 0uL)
			{
				this.NoticeAt = other.NoticeAt;
			}
			if (other.StartedAt != 0uL)
			{
				this.StartedAt = other.StartedAt;
			}
			if (other.EndedAt != 0uL)
			{
				this.EndedAt = other.EndedAt;
			}
			if (other.FinishedAt != 0uL)
			{
				this.FinishedAt = other.FinishedAt;
			}
			if (other.MaterialOpenedAt != 0uL)
			{
				this.MaterialOpenedAt = other.MaterialOpenedAt;
			}
			if (other.LinkType != 0)
			{
				this.LinkType = other.LinkType;
			}
			if (other.LinkBody.Length != 0)
			{
				this.LinkBody = other.LinkBody;
			}
			if (other.DeviceType != 0)
			{
				this.DeviceType = other.DeviceType;
			}
			if (other.MyroomBgId != 0)
			{
				this.MyroomBgId = other.MyroomBgId;
			}
			if (other.MyroomBgmId != 0)
			{
				this.MyroomBgmId = other.MyroomBgmId;
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
								if (num2 != 42u)
								{
									if (num2 != 50u)
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
																						if (num2 != 154u)
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
																										this.MyroomBgmId = input.ReadInt32();
																									}
																								}
																								else
																								{
																									this.MyroomBgId = input.ReadInt32();
																								}
																							}
																							else
																							{
																								this.DeviceType = input.ReadInt32();
																							}
																						}
																						else
																						{
																							this.LinkBody = input.ReadBytes();
																						}
																					}
																					else
																					{
																						this.LinkType = input.ReadInt32();
																					}
																				}
																				else
																				{
																					this.MaterialOpenedAt = input.ReadUInt64();
																				}
																			}
																			else
																			{
																				this.FinishedAt = input.ReadUInt64();
																			}
																		}
																		else
																		{
																			this.EndedAt = input.ReadUInt64();
																		}
																	}
																	else
																	{
																		this.StartedAt = input.ReadUInt64();
																	}
																}
																else
																{
																	this.NoticeAt = input.ReadUInt64();
																}
															}
															else
															{
																this.IntervalHours = input.ReadInt32();
															}
														}
														else
														{
															this.OpenHours = input.ReadInt32();
														}
													}
													else
													{
														this.BannerPriority = input.ReadInt32();
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
											this.NoticeBannerId = input.ReadInt32();
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
								this.OpenType = input.ReadInt32();
							}
						}
						else
						{
							this.Type = input.ReadInt32();
						}
					}
					else
					{
						this.BaseEventId = input.ReadInt32();
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
