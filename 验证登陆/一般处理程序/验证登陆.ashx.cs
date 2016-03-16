using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 验证登陆.一般处理程序
{
    /// <summary>
    /// 验证登陆 的摘要说明
    /// </summary>
    public class 验证登陆 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}