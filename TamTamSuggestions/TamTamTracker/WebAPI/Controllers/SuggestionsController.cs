using IronPython.Hosting;
using MySql.Data.MySqlClient;
using Nager.Date;
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

        public MySqlConnection MyConnection;
        [HttpGet]
        [Route("api/suggestions/IsHoliday/{datum}")]
        public int IsHoliday(DateTime datum)
        {
            int schoolvakantie = 0; // no school holiday
            if (DateSystem.IsPublicHoliday(datum, CountryCode.NL))
            {
                schoolvakantie = 1;
            }
            else
            {
                schoolvakantie = 0;
            }
            return schoolvakantie;
        }

        [HttpGet]
        [Route("api/suggestions/GetDataBeacons")]
        public List<DataBeacon> GetDataBeacons()
        {

            List<DataBeacon> dataBeacon = new List<DataBeacon>();
            MySqlDataReader reader = DB.QuerySelect("select * from data_beacon");
            while (reader.Read())
            {
                var db = new DataBeacon();
                db.dt_created = reader.GetDateTime("dt_created");
                db.file = reader.GetInt32("file");
                db.module = reader.GetString("module");
                db.school_holiday = reader.GetInt32("school_holiday");
                db.amount_of_people = reader.GetInt32("amount_of_people");
                dataBeacon.Add(db);
            }

            return dataBeacon;
        }
        [HttpGet]
        [Route("api/suggestions/GetSuggestion")]
        public  string GetSuggestion(SuggestionGenerator sugGenerator)
        {
            string suggestion = "";
            //Cmd_Python.run_cmd();
            PythonRequest pr = new PythonRequest();
     //       pr.run_cmd();
            Cmd_Python.run_cmd();
            // Generare random suggestion_id and save it in DB
            string suggestion_id = Guid.NewGuid().ToString();

            // Save results in db
            //   DB.QueryInsert<SugesstionsResponse>("INSERT INTO TABLE suggestions () VALUES()");

            return suggestion;
        }

        // Save suggestion Choice of user  // YES OR NO
        public void  PostSuggestionChoice([FromBody] SugesstionsResponse sugResponse)
        {
            
            DB.QueryInsert<SugesstionsResponse>("INSERT INTO TABLE () VALUES()");
            
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
