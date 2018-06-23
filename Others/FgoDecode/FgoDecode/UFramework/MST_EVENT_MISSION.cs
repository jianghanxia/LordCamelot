using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_MISSION : IMessage, IMessage<MST_EVENT_MISSION>, IEquatable<MST_EVENT_MISSION>, IDeepCloneable<MST_EVENT_MISSION>
	{
		public const int IdFieldNumber = 1;

		public const int FlagFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int MissionTargetIdFieldNumber = 4;

		public const int DispNoFieldNumber = 5;

		public const int NotfyPriorityFieldNumber = 6;

		public const int NameFieldNumber = 7;

		public const int DetailFieldNumber = 8;

		public const int StartedAtFieldNumber = 9;

		public const int EndedAtFieldNumber = 10;

		public const int ClosedAtFieldNumber = 11;

		public const int RewardTypeFieldNumber = 12;

		public const int PresentMessageIdFieldNumber = 13;

		public const int GiftIdFieldNumber = 14;

		public const int EventIdFieldNumber = 15;

		private static readonly MessageParser<MST_EVENT_MISSION> _parser = new MessageParser<MST_EVENT_MISSION>(() => new MST_EVENT_MISSION());

		private int id_;

		private int flag_;

		private int type_;

		private int missionTargetId_;

		private int dispNo_;

		private int notfyPriority_;

		private ByteString name_ = ByteString.Empty;

		private ByteString detail_ = ByteString.Empty;

		private ulong startedAt_;

		private ulong endedAt_;

		private ulong closedAt_;

		private int rewardType_;

		private int presentMessageId_;

		private int giftId_;

		private int eventId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_MISSION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_MISSION> Parser => MST_EVENT_MISSION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventMissionReflection.Descriptor.MessageTypes[0];

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
		public int Flag
		{
			get => this.flag_;
			set
			{
				this.flag_ = value;
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
		public int MissionTargetId
		{
			get => this.missionTargetId_;
			set
			{
				this.missionTargetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispNo
		{
			get => this.dispNo_;
			set
			{
				this.dispNo_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int NotfyPriority
		{
			get => this.notfyPriority_;
			set
			{
				this.notfyPriority_ = value;
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
		public ulong ClosedAt
		{
			get => this.closedAt_;
			set
			{
				this.closedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int RewardType
		{
			get => this.rewardType_;
			set
			{
				this.rewardType_ = value;
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
		public int GiftId
		{
			get => this.giftId_;
			set
			{
				this.giftId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int EventId
		{
			get => this.eventId_;
			set
			{
				this.eventId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION(MST_EVENT_MISSION other) : this()
		{
			this.id_ = other.id_;
			this.flag_ = other.flag_;
			this.type_ = other.type_;
			this.missionTargetId_ = other.missionTargetId_;
			this.dispNo_ = other.dispNo_;
			this.notfyPriority_ = other.notfyPriority_;
			this.name_ = other.name_;
			this.detail_ = other.detail_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
			this.closedAt_ = other.closedAt_;
			this.rewardType_ = other.rewardType_;
			this.presentMessageId_ = other.presentMessageId_;
			this.giftId_ = other.giftId_;
			this.eventId_ = other.eventId_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION Clone()
		{
			return new MST_EVENT_MISSION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_MISSION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_MISSION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Flag == other.Flag && this.Type == other.Type && this.MissionTargetId == other.MissionTargetId && this.DispNo == other.DispNo && this.NotfyPriority == other.NotfyPriority && !(this.Name != other.Name) && !(this.Detail != other.Detail) && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt && this.ClosedAt == other.ClosedAt && this.RewardType == other.RewardType && this.PresentMessageId == other.PresentMessageId && this.GiftId == other.GiftId && this.EventId == other.EventId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.MissionTargetId != 0)
			{
				num ^= this.MissionTargetId.GetHashCode();
			}
			if (this.DispNo != 0)
			{
				num ^= this.DispNo.GetHashCode();
			}
			if (this.NotfyPriority != 0)
			{
				num ^= this.NotfyPriority.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this.StartedAt != 0uL)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			if (this.EndedAt != 0uL)
			{
				num ^= this.EndedAt.GetHashCode();
			}
			if (this.ClosedAt != 0uL)
			{
				num ^= this.ClosedAt.GetHashCode();
			}
			if (this.RewardType != 0)
			{
				num ^= this.RewardType.GetHashCode();
			}
			if (this.PresentMessageId != 0)
			{
				num ^= this.PresentMessageId.GetHashCode();
			}
			if (this.GiftId != 0)
			{
				num ^= this.GiftId.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
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
			if (this.Flag != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Flag);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.MissionTargetId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MissionTargetId);
			}
			if (this.DispNo != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DispNo);
			}
			if (this.NotfyPriority != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NotfyPriority);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.Detail);
			}
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.EndedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.ClosedAt);
			}
			if (this.RewardType != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RewardType);
			}
			if (this.PresentMessageId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PresentMessageId);
			}
			if (this.GiftId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.GiftId);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EventId);
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
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.MissionTargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MissionTargetId);
			}
			if (this.DispNo != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispNo);
			}
			if (this.NotfyPriority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NotfyPriority);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			if (this.StartedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClosedAt);
			}
			if (this.RewardType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardType);
			}
			if (this.PresentMessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PresentMessageId);
			}
			if (this.GiftId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftId);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_MISSION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.MissionTargetId != 0)
			{
				this.MissionTargetId = other.MissionTargetId;
			}
			if (other.DispNo != 0)
			{
				this.DispNo = other.DispNo;
			}
			if (other.NotfyPriority != 0)
			{
				this.NotfyPriority = other.NotfyPriority;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			if (other.StartedAt != 0uL)
			{
				this.StartedAt = other.StartedAt;
			}
			if (other.EndedAt != 0uL)
			{
				this.EndedAt = other.EndedAt;
			}
			if (other.ClosedAt != 0uL)
			{
				this.ClosedAt = other.ClosedAt;
			}
			if (other.RewardType != 0)
			{
				this.RewardType = other.RewardType;
			}
			if (other.PresentMessageId != 0)
			{
				this.PresentMessageId = other.PresentMessageId;
			}
			if (other.GiftId != 0)
			{
				this.GiftId = other.GiftId;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
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
										if (num2 != 58u)
										{
											if (num2 != 66u)
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
																			input.SkipLastField();
																		}
																		else
																		{
																			this.EventId = input.ReadInt32();
																		}
																	}
																	else
																	{
																		this.GiftId = input.ReadInt32();
																	}
																}
																else
																{
																	this.PresentMessageId = input.ReadInt32();
																}
															}
															else
															{
																this.RewardType = input.ReadInt32();
															}
														}
														else
														{
															this.ClosedAt = input.ReadUInt64();
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
										this.NotfyPriority = input.ReadInt32();
									}
								}
								else
								{
									this.DispNo = input.ReadInt32();
								}
							}
							else
							{
								this.MissionTargetId = input.ReadInt32();
							}
						}
						else
						{
							this.Type = input.ReadInt32();
						}
					}
					else
					{
						this.Flag = input.ReadInt32();
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
