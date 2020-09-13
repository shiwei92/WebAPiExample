using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiExample.Controllers
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class ValuesController : ApiController
    {
        /*这里的调用都是api/controllername/
         * 至于具体要执行哪个方法，要看发送的请求（是get请求，就执行get方法，get请求传入id参数，就执行带参数的get方法。）
         *Get：获取资源，Post：新增资源，Put：修改资源，Delete：删除资源
         *如果get请求的url中有参数?name=jack，api会自动智能识别出要调用GetName方法，这就是restful语义，前提是方法名必须以get开头
         *WebApiConfig中配置了默认api地址是 api/controller/id(可选)，所以，如果要传入id参数，很简单只需api/controller/1即可，但如果要传入别的参数呢？
         *使用queryString，或是将要传入的参数封装为json对象。
         *
         */

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
        public string GetName(string name)
        {
            return "you input" + name;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public Person Put(int id, Person person)//推荐对象这种写法，不推荐FromBody这种写法。
        {
            return person;
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "you deleted " + id + "";
        }
    }
}
