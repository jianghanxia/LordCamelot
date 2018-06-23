using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_MISSION : IMessage, IMessage<MST_MISSION>, IEquatable<MST_MISSION>, IDeepCloneable<MST_MISSION>
	{
		public const int IdFieldNumber = 1;

		public const int CommentFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int TargetIdFieldNumber = 4;

		public const int ValueFieldNumber = 5;

		public const int GiftIdFieldNumber = 6;

		public const int PresentMessageIdFieldNumber = 7;

		public const int StartedAtFieldNumber = 8;

		public const int EndedAtFieldNumber = 9;

		private static readonly MessageParser<MST_MISSION> _parser = new MessageParser<MST_MISSION>(() => new MST_MISSION());

		private int id_;

		private ByteString comment_ = ByteString.Empty;

		private int type_;

		private int targetId_;

		private int value_;

		private int giftId_;

		private int presentMessageId_;

		private ulong startedAt_;

		private ulong endedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_MISSION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_MISSION> Parser => MST_MISSION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstMissionReflection.Descriptor.MessageTypes[0];

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
		public ByteString Comment
		{
			get => this.comment_;
			set
			{
				this.comment_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int Value
		{
			get => this.value_;
			set
			{
				this.value_ = value;
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
		public int PresentMessageId
		{
			get => this.presentMessageId_;
			set
			{
				this.presentMessageId_ = value;
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
		public MST_MISSION()
		{
		}

		[DebuggerNonUserCode]
		public MST_MISSION(MST_MISSION other) : this()
		{
			this.id_ = other.id_;
			this.comment_ = other.comment_;
			this.type_ = other.type_;
			this.targetId_ = other.targetId_;
			this.value_ = other.value_;
			this.giftId_ = other.giftId_;
			this.presentMessageId_ = other.presentMessageId_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
		}

		[DebuggerNonUserCode]
		public MST_MISSION Clone()
		{
			return new MST_MISSION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_MISSION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_MISSION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Comment != other.Comment) && this.Type == other.Type && this.TargetId == other.TargetId && this.Value == other.Value && this.GiftId == other.GiftId && this.PresentMessageId == other.PresentMessageId && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Comment.Length != 0)
			{
				num ^= this.Comment.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.GiftId != 0)
			{
				num ^= this.GiftId.GetHashCode();
			}
			if (this.PresentMessageId != 0)
			{
				num ^= this.PresentMessageId.GetHashCode();
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
			if (this.Comment.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Comment);
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
			if (this.Value != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Value);
			}
			if (this.GiftId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GiftId);
			}
			if (this.PresentMessageId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PresentMessageId);
			}
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(72);
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
			if (this.Comment.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Comment);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this.GiftId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftId);
			}
			if (this.PresentMessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PresentMessageId);
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
		public void MergeFrom(MST_MISSION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Comment.Length != 0)
			{
				this.Comment = other.Comment;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			if (other.GiftId != 0)
			{
				this.GiftId = other.GiftId;
			}
			if (other.PresentMessageId != 0)
			{
				this.PresentMessageId = other.PresentMessageId;
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
											this.PresentMessageId = input.ReadInt32();
										}
									}
									else
									{
										this.GiftId = input.ReadInt32();
									}
								}
								else
								{
									this.Value = input.ReadInt32();
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
						this.Comment = input.ReadBytes();
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
