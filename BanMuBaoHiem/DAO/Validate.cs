using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanMuBaoHiem.DAO
{
    public class Validate
    {
        public bool Check_PhoneNumber(string s)
        {
            if(s.Length<10 || s.Length>14)
            {
                return false;
            }
            else
            {
                foreach(char c in s)
                {
                    if( c <= 48 || c >= 57)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
