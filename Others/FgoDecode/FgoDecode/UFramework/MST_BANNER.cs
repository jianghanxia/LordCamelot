using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BANNER : IMessage, IMessage<MST_BANNER>, IEquatable<MST_BANNER>, IDeepCloneable<MST_BANNER>
	{
		public const int IdFieldNumber = 1;

		public const int BannerIdFieldNumber = 2;

		public const int BannerPriorityFieldNumber = 3;

		public const int TerminalBannerPriorityFieldNumber = 4;

		public const int NoticeAtFieldNumber = 5;

		public const int FinishedAtFieldNumber = 6;

		public const int LinkTypeFieldNumber = 7;

		public const int LinkBodyFieldNumber = 8;

		public const int DeviceTypeFieldNumber = 9;

		public const int UpdatedAtFieldNumber = 10;

		public const int CreatedAtFieldNumber = 11;

		private static readonly MessageParser<MST_BANNER> _parser = new MessageParser<MST_BANNER>(() => new MST_BANNER());

		private int id_;

		private int bannerId_;

		private int bannerPriority_;

		private int terminalBannerPriority_;

		private ulong noticeAt_;

		private ulong finishedAt_;

		private int linkType_;

		private ByteString linkBody_ = ByteString.Empty;

		private int deviceType_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BANNER.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BANNER> Parser => MST_BANNER._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBannerReflection.Descriptor.MessageTypes[0];

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
		public int BannerId
		{
			get => this.bannerId_;
			set
			{
				this.bannerId_ = value;
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
		public int TerminalBannerPriority
		{
			get => this.terminalBannerPriority_;
			set
			{
				this.terminalBannerPriority_ = value;
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
		public ulong FinishedAt
		{
			get => this.finishedAt_;
			set
			{
				this.finishedAt_ = value;
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
		public MST_BANNER()
		{
		}

		[DebuggerNonUserCode]
		public MST_BANNER(MST_BANNER other) : this()
		{
			this.id_ = other.id_;
			this.bannerId_ = other.bannerId_;
			this.bannerPriority_ = other.bannerPriority_;
			this.terminalBannerPriority_ = other.terminalBannerPriority_;
			this.noticeAt_ = other.noticeAt_;
			this.finishedAt_ = other.finishedAt_;
			this.linkType_ = other.linkType_;
			this.linkBody_ = other.linkBody_;
			this.deviceType_ = other.deviceType_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_BANNER Clone()
		{
			return new MST_BANNER(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BANNER);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BANNER other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.BannerId == other.BannerId && this.BannerPriority == other.BannerPriority && this.TerminalBannerPriority == other.TerminalBannerPriority && this.NoticeAt == other.NoticeAt && this.FinishedAt == other.FinishedAt && this.LinkType == other.LinkType && !(this.LinkBody != other.LinkBody) && this.DeviceType == other.DeviceType && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BannerId != 0)
			{
				num ^= this.BannerId.GetHashCode();
			}
			if (this.BannerPriority != 0)
			{
				num ^= this.BannerPriority.GetHashCode();
			}
			if (this.TerminalBannerPriority != 0)
			{
				num ^= this.TerminalBannerPriority.GetHashCode();
			}
			if (this.NoticeAt != 0uL)
			{
				num ^= this.NoticeAt.GetHashCode();
			}
			if (this.FinishedAt != 0uL)
			{
				num ^= this.FinishedAt.GetHashCode();
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
			if (this.BannerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BannerId);
			}
			if (this.BannerPriority != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BannerPriority);
			}
			if (this.TerminalBannerPriority != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TerminalBannerPriority);
			}
			if (this.NoticeAt != 0uL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.NoticeAt);
			}
			if (this.FinishedAt != 0uL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.FinishedAt);
			}
			if (this.LinkType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LinkType);
			}
			if (this.LinkBody.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.LinkBody);
			}
			if (this.DeviceType != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DeviceType);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(88);
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
			if (this.BannerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BannerId);
			}
			if (this.BannerPriority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BannerPriority);
			}
			if (this.TerminalBannerPriority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TerminalBannerPriority);
			}
			if (this.NoticeAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.NoticeAt);
			}
			if (this.FinishedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.FinishedAt);
			}
			if (this.LinkType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LinkType);
			}
			if (this.LinkBody.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.LinkBody);
			}
			if (this.DeviceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeviceType);
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
		public void MergeFrom(MST_BANNER other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BannerId != 0)
			{
				this.BannerId = other.BannerId;
			}
			if (other.BannerPriority != 0)
			{
				this.BannerPriority = other.BannerPriority;
			}
			if (other.TerminalBannerPriority != 0)
			{
				this.TerminalBannerPriority = other.TerminalBannerPriority;
			}
			if (other.NoticeAt != 0uL)
			{
				this.NoticeAt = other.NoticeAt;
			}
			if (other.FinishedAt != 0uL)
			{
				this.FinishedAt = other.FinishedAt;
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
											if (num2 != 66u)
											{
												if (num2 != 72u)
												{
													if (num2 != 80u)
													{
														if (num2 != 88u)
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
										this.FinishedAt = input.ReadUInt64();
									}
								}
								else
								{
									this.NoticeAt = input.ReadUInt64();
								}
							}
							else
							{
								this.TerminalBannerPriority = input.ReadInt32();
							}
						}
						else
						{
							this.BannerPriority = input.ReadInt32();
						}
					}
					else
					{
						this.BannerId = input.ReadInt32();
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
