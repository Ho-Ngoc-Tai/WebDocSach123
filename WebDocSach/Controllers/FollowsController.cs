//using Microsoft.AspNet.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Security.Permissions;
//using System.Web.Http;
//using WebDocSach.Models;
//using WebDocSach.FLOB;
//using Microsoft.AspNet.Identity.Owin;


//namespace WebDocSach.Controllers
//{
//    public class FollowsController : ApiController
//    {
//        private ApplicationDbContext _dbContext;
//        public FollowsController()
//        {
//            _dbContext = new ApplicationDbContext();
//        }
//        [Authorize]
//        [HttpPost]
//        public IHttpActionResult Follow(FollowBook followBook)
//        {
//            var userId = User.Identity.GetUserId();
//            var follow = new Follow
//            {
//                IdBook = followBook.IdBook,
//                FolloweeId = userId
//            };
//            Follow find = _dbContext.Follows.FirstOrDefault(f => f.FolloweeId == userId && f.IdBook == followBook.IdBook);
//            if (find == null)
//            {
//                _dbContext.Follows.Add(follow);

//            }
//            else
//            {
//                _dbContext.Follows.Remove(find);
//            }

//            _dbContext.SaveChanges();
//            return Ok();
//        }
//    }
//}
