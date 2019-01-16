using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    /// <summary>
    /// 包含未知列信息
    /// </summary>
    public interface IUdfAccesser
    {
        /// <summary>
        /// 未知列访问器
        /// </summary>
        Dictionary<string, object> UdfColumns { get; set; }
    }

    /// <summary>
    /// 包含未知列信息
    /// </summary>
    public abstract class UdfAccesserBase : IUdfAccesser
    {
        /// <summary>
        /// 未知列访问器
        /// </summary>
        public Dictionary<string,object> UdfColumns { get; set; }
    }

    /// <summary>
    /// 包含未知列信息
    /// </summary>
    public sealed class UdfAccesser : UdfAccesserBase
    { 
    }
}
