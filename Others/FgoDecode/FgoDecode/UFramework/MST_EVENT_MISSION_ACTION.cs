using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_MISSION_ACTION : IMessage, IMessage<MST_EVENT_MISSION_ACTION>, IEquatable<MST_EVENT_MISSION_ACTION>, IDeepCloneable<MST_EVENT_MISSION_ACTION>
	{
		public const int MissionIdFieldNumber = 1;

		public const int MissionProgressTypeFieldNumber = 2;

		public const int IdFieldNumber = 3;

		public const int MissionActionTypeFieldNumber = 4;

		public const int ValsFieldNumber = 5;

		private static readonly MessageParser<MST_EVENT_MISSION_ACTION> _parser = new MessageParser<MST_EVENT_MISSION_ACTION>(() => new MST_EVENT_MISSION_ACTION());

		private int missionId_;

		private int missionProgressType_;

		private int id_;

		private int missionActionType_;

		private static readonly FieldCodec<ByteString> _repeated_vals_codec = FieldCodec.ForBytes(42u);

		private readonly RepeatedField<ByteString> vals_ = new RepeatedField<ByteString>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_MISSION_ACTION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_MISSION_ACTION> Parser => MST_EVENT_MISSION_ACTION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventMissionActionReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int MissionId
		{
			get => this.missionId_;
			set
			{
				this.missionId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MissionProgressType
		{
			get => this.missionProgressType_;
			set
			{
				this.missionProgressType_ = value;
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
		public int MissionActionType
		{
			get => this.missionActionType_;
			set
			{
				this.missionActionType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Vals => this.vals_;

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_ACTION()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_ACTION(MST_EVENT_MISSION_ACTION other) : this()
		{
			this.missionId_ = other.missionId_;
			this.missionProgressType_ = other.missionProgressType_;
			this.id_ = other.id_;
			this.missionActionType_ = other.missionActionType_;
			this.vals_ = other.vals_.Clone();
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_ACTION Clone()
		{
			return new MST_EVENT_MISSION_ACTION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_MISSION_ACTION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_MISSION_ACTION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.MissionId == other.MissionId && this.MissionProgressType == other.MissionProgressType && this.Id == other.Id && this.MissionActionType == other.MissionActionType && this.vals_.Equals(other.vals_)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MissionId != 0)
			{
				num ^= this.MissionId.GetHashCode();
			}
			if (this.MissionProgressType != 0)
			{
				num ^= this.MissionProgressType.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MissionActionType != 0)
			{
				num ^= this.MissionActionType.GetHashCode();
			}
			return num ^ this.vals_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (this.MissionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MissionId);
			}
			if (this.MissionProgressType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MissionProgressType);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.MissionActionType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MissionActionType);
			}
			this.vals_.WriteTo(output, MST_EVENT_MISSION_ACTION._repeated_vals_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MissionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MissionId);
			}
			if (this.MissionProgressType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MissionProgressType);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MissionActionType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MissionActionType);
			}
			return num + this.vals_.CalculateSize(MST_EVENT_MISSION_ACTION._repeated_vals_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_MISSION_ACTION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MissionId != 0)
			{
				this.MissionId = other.MissionId;
			}
			if (other.MissionProgressType != 0)
			{
				this.MissionProgressType = other.MissionProgressType;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MissionActionType != 0)
			{
				this.MissionActionType = other.MissionActionType;
			}
			this.vals_.Add(other.vals_);
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
									input.SkipLastField();
								}
								else
								{
									this.vals_.AddEntriesFrom(input, MST_EVENT_MISSION_ACTION._repeated_vals_codec);
								}
							}
							else
							{
								this.MissionActionType = input.ReadInt32();
							}
						}
						else
						{
							this.Id = input.ReadInt32();
						}
					}
					else
					{
						this.MissionProgressType = input.ReadInt32();
					}
				}
				else
				{
					this.MissionId = input.ReadInt32();
				}
			}
		}
	}
}
