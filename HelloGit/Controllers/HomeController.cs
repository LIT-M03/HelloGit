using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloGit.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>Hello github!!</h1>");
        }

        public void Foobar()
        {
            Response.Write("<h1>Foobar</h1>");
        }

        public void Stuff()
        {
            Response.Write("Hello from shea");
        }

        public void ActionMethod()
        {
            Response.Write("<h2>Hello stuff</h2>");
        }
    }
}
