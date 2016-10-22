using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using musicRestful.Models;
using System.Data.SqlClient;
using System.Data;

namespace musicRestful.Controllers
{
    public class musicController : ApiController
    {

        ConnectionProvider connectp = new ConnectionProvider();
        [Route("api/music/musicList")]
        [HttpGet]
        [ActionName("musicList")]
        public DataTable musicList()
        {

            SqlCommand cmd = new SqlCommand();
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                connectp.myConnection2.Open();
                cmd.Connection = connectp.myConnection2;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spListMusic";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds, "Table");
            }
            finally
            {
                connectp.myConnection2.Close();
            }
            DataTableCollection dc = ds.Tables;
            DataTable dTable = dc[0];
            return dTable;
        }


        [Route("api/music/songMaintenance")]
        [HttpGet]
        [ActionName("songMaintenance")]
        public string songMaintenance(string acao, string songId, string songName, string songAutor, string songYear)
        {

            SqlCommand cmd = new SqlCommand();
            try
            {
                connectp.myConnection2.Open();
                System.Data.SqlClient.SqlParameter wParam1 = new System.Data.SqlClient.SqlParameter("@acao", System.Data.SqlDbType.Char, 1);
                wParam1.Value = acao;
                cmd.Parameters.Add(wParam1);
                System.Data.SqlClient.SqlParameter wParam2 = new System.Data.SqlClient.SqlParameter("@songId", System.Data.SqlDbType.Int, 7);
                if (songId == "")
                {
                    wParam2.Value = null;
                }
                else
                {
                    wParam2.Value = songId;
                }
                cmd.Parameters.Add(wParam2);
                System.Data.SqlClient.SqlParameter wParam3 = new System.Data.SqlClient.SqlParameter("@songName", System.Data.SqlDbType.VarChar, 50);
                if (songName == "")
                {
                    wParam3.Value = null;
                }
                else
                {
                    wParam3.Value = songName;
                }
                cmd.Parameters.Add(wParam3);
                System.Data.SqlClient.SqlParameter wParam4 = new System.Data.SqlClient.SqlParameter("@songAutor", System.Data.SqlDbType.VarChar, 50);
                if (songAutor == "")
                {
                    wParam4.Value = null;
                }
                else
                {
                    wParam4.Value = songAutor.ToUpper();
                }
                cmd.Parameters.Add(wParam4);
                System.Data.SqlClient.SqlParameter wParam5 = new System.Data.SqlClient.SqlParameter("@songYear", System.Data.SqlDbType.VarChar, 50);
                if (songYear == "")
                {
                    wParam5.Value = null;
                }
                else
                {
                    wParam5.Value = songYear;
                }
                cmd.Parameters.Add(wParam5);

                cmd.Connection = connectp.myConnection2;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spSongMaintenance";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                connectp.myConnection2.Close();
            }
            return "ok";
        }
    }
}
