using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_MASTER_MISSION_DISPLAY_INFO : IMessage, IMessage<MST_MASTER_MISSION_DISPLAY_INFO>, IEquatable<MST_MASTER_MISSION_DISPLAY_INFO>, IDeepCloneable<MST_MASTER_MISSION_DISPLAY_INFO>
	{
		public const int IdFieldNumber = 1;

		public const int GuideImageIdFieldNumber = 2;

		public const int TalkIdsFieldNumber = 3;

		public const int GuideLimitCountFieldNumber = 4;

		public const int StartedAtFieldNumber = 5;

		public const int EndedAtFieldNumber = 6;

		private static readonly MessageParser<MST_MASTER_MISSION_DISPLAY_INFO> _parser = new MessageParser<MST_MASTER_MISSION_DISPLAY_INFO>(() => new MST_MASTER_MISSION_DISPLAY_INFO());

		private int id_;

		private int guideImageId_;

		private static readonly FieldCodec<ByteString> _repeated_talkIds_codec = FieldCodec.ForBytes(26u);

		private readonly RepeatedField<ByteString> talkIds_ = new RepeatedField<ByteString>();

		private int guideLimitCount_;

		private ulong startedAt_;

		private ulong endedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_MASTER_MISSION_DISPLAY_INFO.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_MASTER_MISSION_DISPLAY_INFO> Parser => MST_MASTER_MISSION_DISPLAY_INFO._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstMasterMissionDisplayInfoReflection.Descriptor.MessageTypes[0];

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
		public int GuideImageId
		{
			get => this.guideImageId_;
			set
			{
				this.guideImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> TalkIds => this.talkIds_;

		[DebuggerNonUserCode]
		public int GuideLimitCount
		{
			get => this.guideLimitCount_;
			set
			{
				this.guideLimitCount_ = value;
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
		public MST_MASTER_MISSION_DISPLAY_INFO()
		{
		}

		[DebuggerNonUserCode]
		public MST_MASTER_MISSION_DISPLAY_INFO(MST_MASTER_MISSION_DISPLAY_INFO other) : this()
		{
			this.id_ = other.id_;
			this.guideImageId_ = other.guideImageId_;
			this.talkIds_ = other.talkIds_.Clone();
			this.guideLimitCount_ = other.guideLimitCount_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
		}

		[DebuggerNonUserCode]
		public MST_MASTER_MISSION_DISPLAY_INFO Clone()
		{
			return new MST_MASTER_MISSION_DISPLAY_INFO(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_MASTER_MISSION_DISPLAY_INFO);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_MASTER_MISSION_DISPLAY_INFO other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.GuideImageId == other.GuideImageId && this.talkIds_.Equals(other.talkIds_) && this.GuideLimitCount == other.GuideLimitCount && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GuideImageId != 0)
			{
				num ^= this.GuideImageId.GetHashCode();
			}
			num ^= this.talkIds_.GetHashCode();
			if (this.GuideLimitCount != 0)
			{
				num ^= this.GuideLimitCount.GetHashCode();
			}
			if (this.StartedAt != 0uL)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			if (this.EndedAt != 0uL)
			{
				num ^= this.EndedAt.GetHashCode();
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
			if (this.GuideImageId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GuideImageId);
			}
			this.talkIds_.WriteTo(output, MST_MASTER_MISSION_DISPLAY_INFO._repeated_talkIds_codec);
			if (this.GuideLimitCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GuideLimitCount);
			}
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.EndedAt);
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
			if (this.GuideImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideImageId);
			}
			num += this.talkIds_.CalculateSize(MST_MASTER_MISSION_DISPLAY_INFO._repeated_talkIds_codec);
			if (this.GuideLimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideLimitCount);
			}
			if (this.StartedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_MASTER_MISSION_DISPLAY_INFO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.GuideImageId != 0)
			{
				this.GuideImageId = other.GuideImageId;
			}
			this.talkIds_.Add(other.talkIds_);
			if (other.GuideLimitCount != 0)
			{
				this.GuideLimitCount = other.GuideLimitCount;
			}
			if (other.StartedAt != 0uL)
			{
				this.StartedAt = other.StartedAt;
			}
			if (other.EndedAt != 0uL)
			{
				this.EndedAt = other.EndedAt;
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
						if (num2 != 26u)
						{
							if (num2 != 32u)
							{
								if (num2 != 40u)
								{
									if (num2 != 48u)
									{
										input.SkipLastField();
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
								this.GuideLimitCount = input.ReadInt32();
							}
						}
						else
						{
							this.talkIds_.AddEntriesFrom(input, MST_MASTER_MISSION_DISPLAY_INFO._repeated_talkIds_codec);
						}
					}
					else
					{
						this.GuideImageId = input.ReadInt32();
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
