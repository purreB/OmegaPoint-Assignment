using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Services
{
  public class MD5ChecksumHelper
  {
    public static string GetMD5Checksum(MemoryStream stream)
    {
      using (var md5 = System.Security.Cryptography.MD5.Create())
      {
        {
          var hash = md5.ComputeHash(stream);
          return BitConverter.ToString(hash).Replace("-", "");
        }
      }
    }
  }
}