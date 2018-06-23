using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_MASTER_MISSION : IMessage, IMessage<MST_MASTER_MISSION>, IEquatable<MST_MASTER_MISSION>, IDeepCloneable<MST_MASTER_MISSION>
	{
		public const int IdFieldNumber = 1;

		public const int StartedAtFieldNumber = 2;

		public const int EndedAtFieldNumber = 3;

		public const int ClosedAtFieldNumber = 4;

		private static readonly MessageParser<MST_MASTER_MISSION> _parser = new MessageParser<MST_MASTER_MISSION>(() => new MST_MASTER_MISSION());

		private int id_;

		private ulong startedAt_;

		private ulong endedAt_;

		private ulong closedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_MASTER_MISSION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_MASTER_MISSION> Parser => MST_MASTER_MISSION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstMasterMissionReflection.Descriptor.MessageTypes[0];

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
		public MST_MASTER_MISSION()
		{
		}

		[DebuggerNonUserCode]
		public MST_MASTER_MISSION(MST_MASTER_MISSION other) : this()
		{
			this.id_ = other.id_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
			this.closedAt_ = other.closedAt_;
		}

		[DebuggerNonUserCode]
		public MST_MASTER_MISSION Clone()
		{
			return new MST_MASTER_MISSION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_MASTER_MISSION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_MASTER_MISSION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt && this.ClosedAt == other.ClosedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
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
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.EndedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(32);
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
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_MASTER_MISSION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
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
								input.SkipLastField();
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
					this.Id = input.ReadInt32();
				}
			}
		}
	}
}
