using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

namespace SimpleEmailClient
{
	public static class SecureCrypt
	{
		public static void AssignCspKey(string cspContainerName)
		{
			CspParameters csp = new CspParameters
			{
				KeyContainerName = cspContainerName,
				Flags = CspProviderFlags.UseMachineKeyStore
			};

			using(var rsa = new RSACryptoServiceProvider(csp))
				rsa.PersistKeyInCsp = true;
		}

		public static void DeleteCspKey(string cspContainerName)
		{
			CspParameters csp = new CspParameters { KeyContainerName = cspContainerName };

			using(var rsa = new RSACryptoServiceProvider(csp))
			{
				rsa.PersistKeyInCsp = false;
				rsa.Clear();
			}
		}

		public static byte[] EncryptCsp(string cspContainerName, int keySize, byte[] data)
		{
			CspParameters csp = new CspParameters { KeyContainerName = cspContainerName };

			using(var rsa = new RSACryptoServiceProvider(keySize, csp))
				return rsa.Encrypt(data, true);
		}

		public static byte[] DecryptCsp(string cspContainerName, int keySize, byte[] data)
		{
			CspParameters csp = new CspParameters { KeyContainerName = cspContainerName };

			using(var rsa = new RSACryptoServiceProvider(keySize, csp))
				return rsa.Decrypt(data, true);
		}

		public static SecureString ToSecure(char[] data)
		{
			SecureString str = new SecureString();
			Array.ForEach(data, str.AppendChar);
			return str;
		}

		public static char[] FromSecure(SecureString str)
		{
			char[] data = new char[str.Length];
			IntPtr ptr = IntPtr.Zero;
			try
			{
				ptr = Marshal.SecureStringToBSTR(str);
				Marshal.Copy(ptr, data, 0, str.Length);
			}
			finally
			{
				if(ptr != IntPtr.Zero)
					Marshal.ZeroFreeBSTR(ptr);
			}
			return data;
		}
	}
}
