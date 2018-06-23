using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_FRIENDSHIP : IMessage, IMessage<MST_FRIENDSHIP>, IEquatable<MST_FRIENDSHIP>, IDeepCloneable<MST_FRIENDSHIP>
	{
		public const int IdFieldNumber = 1;

		public const int RankFieldNumber = 2;

		public const int FriendshipFieldNumber = 3;

		private static readonly MessageParser<MST_FRIENDSHIP> _parser = new MessageParser<MST_FRIENDSHIP>(() => new MST_FRIENDSHIP());

		private int id_;

		private int rank_;

		private int friendship_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_FRIENDSHIP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_FRIENDSHIP> Parser => MST_FRIENDSHIP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstFriendshipReflection.Descriptor.MessageTypes[0];

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
		public int Rank
		{
			get => this.rank_;
			set
			{
				this.rank_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Friendship
		{
			get => this.friendship_;
			set
			{
				this.friendship_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_FRIENDSHIP()
		{
		}

		[DebuggerNonUserCode]
		public MST_FRIENDSHIP(MST_FRIENDSHIP other) : this()
		{
			this.id_ = other.id_;
			this.rank_ = other.rank_;
			this.friendship_ = other.friendship_;
		}

		[DebuggerNonUserCode]
		public MST_FRIENDSHIP Clone()
		{
			return new MST_FRIENDSHIP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_FRIENDSHIP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_FRIENDSHIP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Rank == other.Rank && this.Friendship == other.Friendship));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Rank != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.Friendship != 0)
			{
				num ^= this.Friendship.GetHashCode();
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
			if (this.Rank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Rank);
			}
			if (this.Friendship != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Friendship);
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
			if (this.Rank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
			}
			if (this.Friendship != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Friendship);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_FRIENDSHIP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Rank != 0)
			{
				this.Rank = other.Rank;
			}
			if (other.Friendship != 0)
			{
				this.Friendship = other.Friendship;
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
							input.SkipLastField();
						}
						else
						{
							this.Friendship = input.ReadInt32();
						}
					}
					else
					{
						this.Rank = input.ReadInt32();
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
