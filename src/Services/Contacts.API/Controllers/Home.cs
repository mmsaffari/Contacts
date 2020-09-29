﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace Contacts.API.Controllers {

	[ApiController]
	[Route("api/[controller]")]
	public class Home : ControllerBase {
		[HttpGet]
		public string Index() {
			return "Hello World!";
		}
	}
}
