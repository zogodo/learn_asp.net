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
            context.Response.ContentType = "text/html";

            string username = context.Request["username"];
            string password = context.Request["password"];

            if (username == "" || password == "")
            {
                context.Response.Write(@"<script>
                                            alert('用户名或密码不能为空 !');
                                            location.href = '../html页/2.后台验证.html';
                                        </script>");
            }
            else if (username == "admin" && password == "123")
            {
                context.Response.Redirect("https://www.baidu.com/");
            }
            else
            {
                context.Response.Write("用户名或密码错误 ! ");
                context.Response.Write("<a href='../html页/2.后台验证.html'> 点击返回</a>");
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