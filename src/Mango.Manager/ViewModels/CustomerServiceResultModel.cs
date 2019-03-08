using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Manager.ViewModels
{
    public class CustomerServiceResultModel
    {
        /// <summary>
        /// 分组ID
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// 分组名称
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 客服列表
        /// </summary>
        public List<CustomerServiceModel> CustomerServices { get; set; }
    }
}
