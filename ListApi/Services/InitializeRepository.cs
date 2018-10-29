using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListApi.Models;

namespace ListApi.Services
{
    public class InitializeRepository
    {



        private List<InitializeModel> GeneratAllData()
        {

            var listdata = new List<InitializeModel>
            {
               new InitializeModel
               {
                  Uniqid="T1",
                  TicketNumber=43,
                  Title="ATM",
                  Priority=1 ,
                  type="ÏÑÎæÇÓÊ äÕÈ ATM"
               },
               new InitializeModel
               {
                   Uniqid="T2",
                   TicketNumber=22,
                   Title="POS",
                   Priority=2,
                   type="ÏÑÎæÇÓÊ äÕÈ POS"

               }

            };
            return listdata;
        }
    }
}