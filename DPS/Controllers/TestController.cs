using BLL;
using BOL;
using DPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DPS.Controllers
{
    public class TestController : ApiController
    {
        private UserBs _userBs;
        private Common _common;

        public TestController()
        {
            _userBs = new UserBs();
            _common = new Common();
           
        }

        //

        [HttpGet]
        public ResponseObj<List<Users>> GetAllUser()
        {
            ResponseObj<List<Users>> responseObj = new ResponseObj<List<Users>>();

            try
            {
                var lang = Request.Headers.GetValues("Accept-Language").First();
                var _userList = _userBs.GetAllUser();
                responseObj.Data = _userList;
                responseObj.isSuccess = true;
                responseObj.Message = lang == "En" ? "List of User" : "List of User - Ar";
            }
            catch (Exception ex)
            {
                responseObj.Message = ex.Message;
                responseObj.isSuccess = false;
                _common.ExeceptionHandleWithMethodName(ex, "GetAllUser");
            }
            return responseObj;
        }
    }
}
