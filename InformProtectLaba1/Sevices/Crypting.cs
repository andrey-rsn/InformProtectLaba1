using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InformProtectLaba1.Sevices;
public static class Crypting
{
    public static string Encrypt(string input)
    {
        return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input)));
    }
    private static byte[] Encrypt(byte[] input)
    {
        PasswordDeriveBytes pdb = new PasswordDeriveBytes("andrey", new byte[] { 0x43, 0x87, 0x23, 0x72, 0x45, 0x56, 0x68, 0x14, 0x62, 0x84 });
        MemoryStream ms = new MemoryStream();
        Aes aes = new AesManaged();
        aes.Key = pdb.GetBytes(aes.KeySize / 8);
        aes.IV = pdb.GetBytes(aes.BlockSize / 8);
        CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
        cs.Write(input, 0, input.Length);
        cs.Close();
        return ms.ToArray();
    }
    public static string Decrypt(string input,string key)
    {
        return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input),key));
    }
    private static byte[] Decrypt(byte[] input,string key)
    {
        PasswordDeriveBytes pdb = new PasswordDeriveBytes(key, new byte[] { 0x43, 0x87, 0x23, 0x72, 0x45, 0x56, 0x68, 0x14, 0x62, 0x84 });
        MemoryStream ms = new MemoryStream();
        Aes aes = new AesManaged();
        aes.Key = pdb.GetBytes(aes.KeySize / 8);
        aes.IV = pdb.GetBytes(aes.BlockSize / 8);
        CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);
        cs.Write(input, 0, input.Length);
        cs.Close();
        return ms.ToArray();
    }
}
