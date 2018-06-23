using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_VOICE : IMessage, IMessage<MST_SVT_VOICE>, IEquatable<MST_SVT_VOICE>, IDeepCloneable<MST_SVT_VOICE>
	{
		public const int IdFieldNumber = 1;

		public const int VoicePrefixFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int ScriptJsonFieldNumber = 4;

		private static readonly MessageParser<MST_SVT_VOICE> _parser = new MessageParser<MST_SVT_VOICE>(() => new MST_SVT_VOICE());

		private int id_;

		private int voicePrefix_;

		private int type_;

		private ByteString scriptJson_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_VOICE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_VOICE> Parser => MST_SVT_VOICE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtVoiceReflection.Descriptor.MessageTypes[0];

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
		public int VoicePrefix
		{
			get => this.voicePrefix_;
			set
			{
				this.voicePrefix_ = value;
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
		public ByteString ScriptJson
		{
			get => this.scriptJson_;
			set
			{
				this.scriptJson_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_VOICE()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_VOICE(MST_SVT_VOICE other) : this()
		{
			this.id_ = other.id_;
			this.voicePrefix_ = other.voicePrefix_;
			this.type_ = other.type_;
			this.scriptJson_ = other.scriptJson_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_VOICE Clone()
		{
			return new MST_SVT_VOICE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_VOICE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_VOICE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.VoicePrefix == other.VoicePrefix && this.Type == other.Type && !(this.ScriptJson != other.ScriptJson)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.VoicePrefix != 0)
			{
				num ^= this.VoicePrefix.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ScriptJson.Length != 0)
			{
				num ^= this.ScriptJson.GetHashCode();
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
			if (this.VoicePrefix != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.VoicePrefix);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.ScriptJson.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.ScriptJson);
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
			if (this.VoicePrefix != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoicePrefix);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.ScriptJson.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ScriptJson);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_VOICE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.VoicePrefix != 0)
			{
				this.VoicePrefix = other.VoicePrefix;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.ScriptJson.Length != 0)
			{
				this.ScriptJson = other.ScriptJson;
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
							if (num2 != 34u)
							{
								input.SkipLastField();
							}
							else
							{
								this.ScriptJson = input.ReadBytes();
							}
						}
						else
						{
							this.Type = input.ReadInt32();
						}
					}
					else
					{
						this.VoicePrefix = input.ReadInt32();
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
