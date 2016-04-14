using System.Web;

namespace 验证登陆.一般处理程序
{
    /// <summary>
    /// 数据库验证登陆 的摘要说明
    /// </summary>
    public class 数据库验证登陆 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            string username = context.Request["username"];
            string password = context.Request["password"];

            //

            if (username == "" || password == "")
            {
                context.Response.Write(@"empty");
            }
            else if (true)
            {
                context.Response.Write(@"OK");
            }
            else
            {
                context.Response.Write("error");
            }
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