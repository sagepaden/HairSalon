using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClassNamesController : Controller
  {
    private readonly HairSalonContext _db;

    public ClassNamesController(HairSalonContext db)
    {
      _db = db;
    }
  }
}