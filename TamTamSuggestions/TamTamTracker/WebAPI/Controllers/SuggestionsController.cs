using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
namespace WebAPI.Controllers
{
    public class SuggestionsController : ApiController
    {
        
        public string GetSuggestion(SuggestionGenerator sugGenerator)
        {           

            // de variabelen moeten we hier weten 
            Cmd_Python.run_cmd();
            // Generare random suggestion_id and save it in DB
            string suggestion_id = Guid.NewGuid().ToString();
            string suggestion = ""; // Python script 
            // mac adres -> sugGenerator.mac_adres
            // Welke module -> sugGenerator.module

         // Save results in db
        DB.Query<SugesstionsResponse>("INSERT INTO TABLE () VALUES()");

            return suggestion;
        }

        // Save suggestion Choice of user  // YES OR NO
        public void  PostSuggestionChoice([FromBody] SugesstionsResponse sugResponse)
        {
            DB.Query<SugesstionsResponse>("INSERT INTO TABLE () VALUES()");
            
        }
       
      
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
