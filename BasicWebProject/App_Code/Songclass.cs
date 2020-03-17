using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace BasicWebProject.App_Code
{
    public class Songclass
    {
        public DataSet getAllSongs()
        {
            DataSet ds = new DataSet("playlist");
            DataTable dt = new DataTable("song");
            DataColumn dcId = new DataColumn("id");
            DataColumn dcArtist = new DataColumn("artist");
            DataColumn dcTitle = new DataColumn("title");

            dt.Columns.Add(dcId);
            dt.Columns.Add(dcArtist);
            dt.Columns.Add(dcTitle);
            ds.Tables.Add(dt);

            ds.ReadXml(HttpContext.Current.Server.MapPath("App_Data/playlist.xml"));
        }
    }
}