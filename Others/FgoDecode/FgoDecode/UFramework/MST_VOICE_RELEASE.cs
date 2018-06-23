using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_VOICE_RELEASE : IMessage, IMessage<MST_VOICE_RELEASE>, IEquatable<MST_VOICE_RELEASE>, IDeepCloneable<MST_VOICE_RELEASE>
	{
		public const int VoiceIdFieldNumber = 1;

		public const int CondTypeFieldNumber = 2;

		public const int CondValueFieldNumber = 3;

		private static readonly MessageParser<MST_VOICE_RELEASE> _parser = new MessageParser<MST_VOICE_RELEASE>(() => new MST_VOICE_RELEASE());

		private ByteString voiceId_ = ByteString.Empty;

		private int condType_;

		private int condValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_VOICE_RELEASE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_VOICE_RELEASE> Parser => MST_VOICE_RELEASE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstVoiceReleaseReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public ByteString VoiceId
		{
			get => this.voiceId_;
			set
			{
				this.voiceId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int CondType
		{
			get => this.condType_;
			set
			{
				this.condType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondValue
		{
			get => this.condValue_;
			set
			{
				this.condValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_VOICE_RELEASE()
		{
		}

		[DebuggerNonUserCode]
		public MST_VOICE_RELEASE(MST_VOICE_RELEASE other) : this()
		{
			this.voiceId_ = other.voiceId_;
			this.condType_ = other.condType_;
			this.condValue_ = other.condValue_;
		}

		[DebuggerNonUserCode]
		public MST_VOICE_RELEASE Clone()
		{
			return new MST_VOICE_RELEASE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_VOICE_RELEASE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_VOICE_RELEASE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (!(this.VoiceId != other.VoiceId) && this.CondType == other.CondType && this.CondValue == other.CondValue));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VoiceId.Length != 0)
			{
				num ^= this.VoiceId.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			if (this.CondValue != 0)
			{
				num ^= this.CondValue.GetHashCode();
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
			if (this.VoiceId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.VoiceId);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CondType);
			}
			if (this.CondValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CondValue);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VoiceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.VoiceId);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			if (this.CondValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_VOICE_RELEASE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VoiceId.Length != 0)
			{
				this.VoiceId = other.VoiceId;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			if (other.CondValue != 0)
			{
				this.CondValue = other.CondValue;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0u)
			{
				uint num2 = num;
				if (num2 != 10u)
				{
					if (num2 != 16u)
					{
						if (num2 != 24u)
						{
							input.SkipLastField();
						}
						else
						{
							this.CondValue = input.ReadInt32();
						}
					}
					else
					{
						this.CondType = input.ReadInt32();
					}
				}
				else
				{
					this.VoiceId = input.ReadBytes();
				}
			}
		}
	}
}
