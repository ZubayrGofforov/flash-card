using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashCards.Desktop.Common
{
    public class IdentitySingelton
    {
        public long UserId { get; set; }

        public long TitleId { get; set; }    

        private static IdentitySingelton _identitySingelton;
        private IdentitySingelton()
        {

        }
        
        public static void BuildInstance(long userId)
        {
            if (_identitySingelton is null)
            {
                _identitySingelton = new IdentitySingelton();
                _identitySingelton.UserId = userId;
            }
            else throw new Exception("Instance is not null");
        }

        public static IdentitySingelton GetInstance()
        {
            return _identitySingelton;
        }
    }
}
