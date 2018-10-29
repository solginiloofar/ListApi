using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ListApi.Models;
using ListApi.Methods;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using ListApi.DB;
using System.Data.Entity.Infrastructure;
using System.Web.Http.ModelBinding;

namespace ListApi.Controllers
{
    public class GeneratDataController : ApiController
    {




        public List<InitializeModel> GeneratData()
        {

            return null;
            //List<InitializeModel> listdata = new List<InitializeModel>
            //{
            //   new InitializeModel
            //   {
            //      Uniqid="T1",
            //      TicketNumber=43,
            //      Title="ATM",
            //      Priority=1 ,
            //      type="ÏÑÎæÇÓÊ äÕÈ ATM"
            //   },
            //   new InitializeModel
            //   {
            //       Uniqid="T2",
            //       TicketNumber=22,
            //       Title="POS",
            //       Priority=2,
            //       type="ÏÑÎæÇÓÊ äÕÈ POS"

            //   }

            //};
            //return listdata;
            //}

            //public List<InitializeModel> _ticket = new List<InitializeModel>()
            //{
            //    new InitializeModel() { Uniqid="t1",TicketNumber=43,Title="ATM",Priority=1,type="ISC" }

            //};



            //[HttpGet]
            //public List<InitializeModel> getall()
            //{

            //    var instance = new List<InitializeModel>();
            //    DB.DataBase context = new DB.DataBase();
            //    var query = context.InitializeList.ToList();
            //    return query.ToList();
            //}


            //[HttpGet]
            //public List<InitializeModel> getparam(string id)
            //{

            //    var instance = new List<InitializeModel>();
            //    DB.DataBase context = new DB.DataBase();
            //    var query = context.InitializeList.Where(f => f.Uniqid == id).ToList();
            //    return query.ToList();

            //}

            //[HttpPut]
            //public IHttpActionResult UpdateRow(InitializeModel ticket )

            //{

            //    if (!ModelState.IsValid)
            //    {
            //        return BadRequest("Not a valid Model");
            //    }
            //    using (DB.DataBase context = new DB.DataBase())
            //    {

            //        var existingTicket = context.InitializeList.SingleOrDefault(s => s.Uniqid == ticket.Uniqid);

            //        if (existingTicket != null)
            //        {
            //            existingTicket.Uniqid = ticket.Uniqid;
            //            existingTicket.type = ticket.type;
            //            existingTicket.Title = ticket.Title;
            //            existingTicket.TicketNumber = ticket.TicketNumber;
            //            existingTicket.Priority = ticket.Priority;
            //            context.Entry(existingTicket).State = System.Data.Entity.EntityState.Modified;
            //            context.SaveChanges();

            //        }
            //        else
            //        {
            //            return NotFound();
            //        }
            //    }
            //    return Ok();


            //----------------------------------------------
            //InitializeModel ticket= _ticket.Find(tic=>tic.Uniqid==p.Uniqid);

            //if (ticket== null)
            //{
            //    var obj1 = new List<InitializeModel>();
            //    DB.DataBase context = new DB.DataBase();
            //    var query = context.InitializeList.ToList();
            //    return query.ToList();
            //}
            //else
            //{
            //    //var obj2 = new List<InitializeModel>();
            //    ticket.Uniqid = p.Uniqid;
            //    ticket.TicketNumber = p.TicketNumber;
            //    ticket.Priority = p.Priority;
            //    ticket.Title = p.Title;
            //    ticket.type = p.type;
            //    return _ticket;

            //var obj2 = new List<InitializeModel>();
            //DB.DataBase context = new DB.DataBase();
            //var query = context.InitializeList.SqlQuery("update dbo.InitializeModel set TicketNumber=newTicketNumber where Uniqid=id").ToList();
            //return obj2.ToList();


            //}
        }

        [HttpPost]
        public List<InitializeModel> PostAdd(InitializeModel pro)
        {

            //List<InitializeModel> t = new List<InitializeModel>();
            //if (pro == null)
            //{
            //    return null;
            //}
            //else
            //{
            //    t.Add(pro);
            //    return t;
            //}


            //----------------------------------------

            using (DB.DataBase context = new DB.DataBase())
            {

                var query = context.InitializeList.ToList();
                List<InitializeModel> ticket = new List<InitializeModel>();
                if (ticket != null)
                    return null;

                if (pro != null)
                {

                    context.InitializeList.Add(new InitializeModel()
                    {
                        Uniqid = pro.Uniqid,
                        TicketNumber = pro.TicketNumber,
                        Title = pro.Title,
                        Priority = pro.Priority,
                        type = pro.type





                    })
                    ;

                    context.SaveChanges();

                }
                else
                {
                    return null;
                }
                return query;
            }



        }

    } 


    }





//--------------------------------------------


//InitializeModel MyList = new InitializeModel();
//DB.DataBase context = new DB.DataBase();
//var query = update InitializeModel set Uniqid = "id" , TicketNumber = "TN", Type = "T" ,Priority =" P",type = "TY" where id == Uniqid;
//("update InitializeModel set '{Uniqid}'=id , '{TicketNumber}'= TN, '{Title}'=T ,'{Priority}'=P,'{type}'=TY where id='{Uniqid}'").ToList();  
//var q = "update dbo.InitializeModel set Uinqid=@newId where newId=@newId";
//SqlConnection cn = new SqlConnection("Data Source = n - solgi - 7; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
//SqlCommand com = new SqlCommand(q);
//cn.Open();
//com.ExecuteNonQuery();
//cn.Close();
//new InitializeModel() { Uinqid = "t8", TicketNumber = 50, Title = "POS", Priority = 60, type = "ISC" }
