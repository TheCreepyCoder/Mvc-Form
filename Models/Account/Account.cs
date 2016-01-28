using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace  MvcLogin.models
{
  public class Account
  {
    // My Username
    [Display(Name = "Username")]
    public string Username { get; set; }

    //My Password
    [Display(Name = "Password")]
    public string Password { get; set; }
  }
}
