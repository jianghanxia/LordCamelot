using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BATTLE_BG : IMessage, IMessage<MST_BATTLE_BG>, IEquatable<MST_BATTLE_BG>, IDeepCloneable<MST_BATTLE_BG>
	{
		public const int IdFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		public const int ImageIdFieldNumber = 3;

		public const int PriorityFieldNumber = 4;

		private static readonly MessageParser<MST_BATTLE_BG> _parser = new MessageParser<MST_BATTLE_BG>(() => new MST_BATTLE_BG());

		private int id_;

		private int type_;

		private int imageId_;

		private int priority_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BATTLE_BG.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BATTLE_BG> Parser => MST_BATTLE_BG._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBattleBgReflection.Descriptor.MessageTypes[0];

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
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
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
		public MST_BATTLE_BG()
		{
		}

		[DebuggerNonUserCode]
		public MST_BATTLE_BG(MST_BATTLE_BG other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.imageId_ = other.imageId_;
			this.priority_ = other.priority_;
		}

		[DebuggerNonUserCode]
		public MST_BATTLE_BG Clone()
		{
			return new MST_BATTLE_BG(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BATTLE_BG);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BATTLE_BG other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Type == other.Type && this.ImageId == other.ImageId && this.Priority == other.Priority));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ImageId != 0)
			{
				num ^= this.ImageId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
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
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
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
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.ImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_BATTLE_BG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.ImageId != 0)
			{
				this.ImageId = other.ImageId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
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
						this.Type = input.ReadInt32();
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
