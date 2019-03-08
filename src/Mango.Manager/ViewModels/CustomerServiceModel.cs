using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Manager.ViewModels
{
    public class CustomerServiceModel
    {
        public string UserId { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 头像地址
        /// </summary>
        public string HeadUrl { get; set; }
    }
}
