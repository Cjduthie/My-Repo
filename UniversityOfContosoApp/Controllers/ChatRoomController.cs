﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityofContoso.Controllers
{
    public class ChatRoomController : Controller
    {
        // GET: /ChatRoom/
        public ActionResult SignalRChat()
        {
            return View();
        }
    }
}