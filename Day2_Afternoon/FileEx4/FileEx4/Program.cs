using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace FileEx4
{
	class MainClass
	{
		private static byte[] key = new byte[8] {1, 2, 3, 4, 5, 6, 7, 8};
		private static byte[] iv = new byte[8] {1, 2, 3, 4, 5, 6, 7, 8};

		public static string Crypt(string text)
		{
			SymmetricAlgorithm algorithm = DES.Create();
			ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
			byte[] inputbuffer = Encoding.Unicode.GetBytes(text);
			byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
			return Convert.ToBase64String(outputBuffer);
		}

		public static string Decrypt(string text)
		{
			SymmetricAlgorithm algorithm = DES.Create();
			ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
			byte[] inputbuffer = Convert.FromBase64String(text);
			byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
			return Encoding.Unicode.GetString(outputBuffer);
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter text to encrypt");
			string text = Console.ReadLine ();
			string encryptedText = Crypt (text);
			File.WriteAllText("file.txt", encryptedText);

			Console.WriteLine ();
			string readText = File.ReadAllText("file.txt");
			Console.WriteLine ("Contents of file after encryption : \n" + readText);

			Console.WriteLine ();
			Console.WriteLine ("After decryption : \n" + Decrypt (readText));
		}
	}
}
