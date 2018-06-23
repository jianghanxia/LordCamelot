using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_SCRIPT : IMessage, IMessage<MST_SVT_SCRIPT>, IEquatable<MST_SVT_SCRIPT>, IDeepCloneable<MST_SVT_SCRIPT>
	{
		public const int SvtIdFieldNumber = 1;

		public const int LimitCountFieldNumber = 2;

		public const int FaceXFieldNumber = 3;

		public const int FaceYFieldNumber = 4;

		public const int BgImageIdFieldNumber = 5;

		public const int ScaleFieldNumber = 6;

		public const int OffsetXFieldNumber = 7;

		public const int OffsetYFieldNumber = 8;

		public const int OffsetXMyroomFieldNumber = 9;

		public const int OffsetYMyroomFieldNumber = 10;

		private static readonly MessageParser<MST_SVT_SCRIPT> _parser = new MessageParser<MST_SVT_SCRIPT>(() => new MST_SVT_SCRIPT());

		private int svtId_;

		private int limitCount_;

		private int faceX_;

		private int faceY_;

		private int bgImageId_;

		private float scale_;

		private int offsetX_;

		private int offsetY_;

		private int offsetXMyroom_;

		private int offsetYMyroom_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_SCRIPT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_SCRIPT> Parser => MST_SVT_SCRIPT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtScriptReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int SvtId
		{
			get => this.svtId_;
			set
			{
				this.svtId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int LimitCount
		{
			get => this.limitCount_;
			set
			{
				this.limitCount_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FaceX
		{
			get => this.faceX_;
			set
			{
				this.faceX_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FaceY
		{
			get => this.faceY_;
			set
			{
				this.faceY_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BgImageId
		{
			get => this.bgImageId_;
			set
			{
				this.bgImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public float Scale
		{
			get => this.scale_;
			set
			{
				this.scale_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetX
		{
			get => this.offsetX_;
			set
			{
				this.offsetX_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetY
		{
			get => this.offsetY_;
			set
			{
				this.offsetY_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetXMyroom
		{
			get => this.offsetXMyroom_;
			set
			{
				this.offsetXMyroom_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetYMyroom
		{
			get => this.offsetYMyroom_;
			set
			{
				this.offsetYMyroom_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_SCRIPT()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_SCRIPT(MST_SVT_SCRIPT other) : this()
		{
			this.svtId_ = other.svtId_;
			this.limitCount_ = other.limitCount_;
			this.faceX_ = other.faceX_;
			this.faceY_ = other.faceY_;
			this.bgImageId_ = other.bgImageId_;
			this.scale_ = other.scale_;
			this.offsetX_ = other.offsetX_;
			this.offsetY_ = other.offsetY_;
			this.offsetXMyroom_ = other.offsetXMyroom_;
			this.offsetYMyroom_ = other.offsetYMyroom_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_SCRIPT Clone()
		{
			return new MST_SVT_SCRIPT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_SCRIPT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_SCRIPT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.LimitCount == other.LimitCount && this.FaceX == other.FaceX && this.FaceY == other.FaceY && this.BgImageId == other.BgImageId && this.Scale == other.Scale && this.OffsetX == other.OffsetX && this.OffsetY == other.OffsetY && this.OffsetXMyroom == other.OffsetXMyroom && this.OffsetYMyroom == other.OffsetYMyroom));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.FaceX != 0)
			{
				num ^= this.FaceX.GetHashCode();
			}
			if (this.FaceY != 0)
			{
				num ^= this.FaceY.GetHashCode();
			}
			if (this.BgImageId != 0)
			{
				num ^= this.BgImageId.GetHashCode();
			}
			if (this.Scale != 0f)
			{
				num ^= this.Scale.GetHashCode();
			}
			if (this.OffsetX != 0)
			{
				num ^= this.OffsetX.GetHashCode();
			}
			if (this.OffsetY != 0)
			{
				num ^= this.OffsetY.GetHashCode();
			}
			if (this.OffsetXMyroom != 0)
			{
				num ^= this.OffsetXMyroom.GetHashCode();
			}
			if (this.OffsetYMyroom != 0)
			{
				num ^= this.OffsetYMyroom.GetHashCode();
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
			if (this.SvtId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SvtId);
			}
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LimitCount);
			}
			if (this.FaceX != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FaceX);
			}
			if (this.FaceY != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FaceY);
			}
			if (this.BgImageId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BgImageId);
			}
			if (this.Scale != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.Scale);
			}
			if (this.OffsetX != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.OffsetX);
			}
			if (this.OffsetY != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.OffsetY);
			}
			if (this.OffsetXMyroom != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.OffsetXMyroom);
			}
			if (this.OffsetYMyroom != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.OffsetYMyroom);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.FaceX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FaceX);
			}
			if (this.FaceY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FaceY);
			}
			if (this.BgImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BgImageId);
			}
			if (this.Scale != 0f)
			{
				num += 5;
			}
			if (this.OffsetX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetX);
			}
			if (this.OffsetY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetY);
			}
			if (this.OffsetXMyroom != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetXMyroom);
			}
			if (this.OffsetYMyroom != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetYMyroom);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_SCRIPT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.FaceX != 0)
			{
				this.FaceX = other.FaceX;
			}
			if (other.FaceY != 0)
			{
				this.FaceY = other.FaceY;
			}
			if (other.BgImageId != 0)
			{
				this.BgImageId = other.BgImageId;
			}
			if (other.Scale != 0f)
			{
				this.Scale = other.Scale;
			}
			if (other.OffsetX != 0)
			{
				this.OffsetX = other.OffsetX;
			}
			if (other.OffsetY != 0)
			{
				this.OffsetY = other.OffsetY;
			}
			if (other.OffsetXMyroom != 0)
			{
				this.OffsetXMyroom = other.OffsetXMyroom;
			}
			if (other.OffsetYMyroom != 0)
			{
				this.OffsetYMyroom = other.OffsetYMyroom;
			}
		}

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                uint num2 = num;
                switch (num2)
                {
                    case 0x35:
                        {
                            this.Scale = input.ReadFloat();
                            continue;
                        }
                    case 0x38:
                        {
                            this.OffsetX = input.ReadInt32();
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.SvtId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.LimitCount = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.FaceX = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.FaceY = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.BgImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.OffsetY = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.OffsetXMyroom = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.OffsetYMyroom = input.ReadInt32();
            }
        }


    }
}
