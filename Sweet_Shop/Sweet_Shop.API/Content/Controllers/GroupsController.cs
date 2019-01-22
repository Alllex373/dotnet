using Sweet_Shop.BuisnesLogic.Services;
using Sweet_Shop.Models.Datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sweet_Shop.API.Controllers
{
    public class GroupsController : ApiController
    {
        private readonly IGroupServices _groupService;

        public GroupsController()
        {
            _groupService = new GroupServices();
        }

        [HttpGet]

        public IHttpActionResult GetAll()
        {
            var groups = _groupService.GetList();

            return Ok(groups);
        }


        [HttpPost]

        public IHttpActionResult Add([FromBody] Group group)
        {
            if (!ModelState.IsValid)
                return (BadRequest(ModelState));

            //if (string.IsNullOrEmpty(group.Name))
            //    return BadRequest("Oops");
            return Ok();
        }

    }
}
