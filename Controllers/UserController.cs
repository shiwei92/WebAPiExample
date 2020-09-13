using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiExample.Controllers
{
    public class LoginModel
    {
        public string Name { get; set; }
        public string Pwd { get; set; }
    }
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //路由前缀
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        //路由名称，会和路由前缀组合成完整的url
        //没有使用restful风格（发送get请求自动寻找get方法，发送post请求自动寻找post方法），需要自己指定用哪种类型来处理
        [HttpPost]
        [Route("Login")]
        public string LoginName(LoginModel model)
        {
            return model.Name + " " + model.Pwd;
        }

        [HttpGet]
        [Route("Get")]
        public LoginModel GetUser()
        {
            return new LoginModel { Name = "rose", Pwd = "456" };
        }

    }
}
