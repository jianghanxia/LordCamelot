using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Directory.CreateDirectory("File");

			ExportImage("MonoBehaviour #035.txt", "DownloadFaceAtlas1.png");
			ExportImage("MonoBehaviour #033.txt", "DownloadFaceAtlas2.png");
			ExportImage("MonoBehaviour #004.txt", "DownloadFaceAtlas3.png");
			ExportImage("MonoBehaviour #021.txt", "DownloadFaceAtlas4.png");
			ExportImage("MonoBehaviour #001.txt", "DownloadFaceAtlas5.png");
			ExportImage("MonoBehaviour #036.txt", "DownloadFaceAtlas6.png");
			ExportImage("MonoBehaviour #007.txt", "DownloadFaceAtlas7.png");

			//ExportImage("MonoBehaviour #005.txt", "DownloadEquipFaceAtlas1.png");
			//ExportImage("MonoBehaviour #002.txt", "DownloadEquipFaceAtlas2.png");

			//ExportImage("MonoBehaviour #008.txt", "DownloadItemAtlas1.png");
			//ExportImage("MonoBehaviour #032.txt", "DownloadItemAtlas2.png");
			//ExportImage("MonoBehaviour #019.txt", "DownloadItemAtlas3.png");
			//ExportImage("MonoBehaviour #026.txt", "DownloadItemAtlas4.png");
			//ExportImage("MonoBehaviour #003.txt", "DownloadItemAtlas5.png");
		}

		private static void ExportImage(string beh, string src)
		{
			var file = new FileStream(beh, FileMode.Open);
			var sReader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
			var res = sReader.ReadToEnd();

			var imgSrc = Image.FromFile(src);
			Regex regexObj = new Regex(@"string name = ""(?<name>.*?)""\s*?int x = (?<x>\d*)\s*?int y = (?<y>\d*)\s*?int width = (?<width>\d*)\s*?int height = (?<height>\d*)", RegexOptions.Singleline | RegexOptions.Multiline);
			Match matchResult = regexObj.Match(res);
			while (matchResult.Success)
			{
				var ss = KiCut(imgSrc, int.Parse(matchResult.Groups["x"].Value), int.Parse(matchResult.Groups["y"].Value), int.Parse(matchResult.Groups["width"].Value),
					int.Parse(matchResult.Groups["height"].Value));
				ss.Save($"File\\{matchResult.Groups["name"]}.png", ImageFormat.Png);

				matchResult = matchResult.NextMatch();
			}
		}

		public static Image KiCut(Image b, int StartX, int StartY, int iWidth, int iHeight)
		{
			if (b == null)
			{
				return null;
			}

			int w = b.Width;
			int h = b.Height;

			if (StartX >= w || StartY >= h)
			{
				return null;
			}

			if (StartX + iWidth > w)
			{
				iWidth = w - StartX;
			}

			if (StartY + iHeight > h)
			{
				iHeight = h - StartY;
			}

			try
			{
				var bmpOut = new Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb);

				Graphics g = Graphics.FromImage(bmpOut);
				g.DrawImage(b, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX, StartY, iWidth, iHeight), GraphicsUnit.Pixel);
				g.Dispose();

				return bmpOut;
			}
			catch
			{
				return null;
			}
		}
	}
}
