using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BandTracker
{
  public class Show
  {
    public static void HostShow(string venue, string headliner, string opener = "", string secondBand = "", string thirdBand = "")
    {
      SqlConnection conn = DB.Connection();
      conn.Open();
      SqlDataReader rdr = null;
      SqlCommand cmd = new SqlCommand ("INSERT INTO shows (venue_id, headliner_band_id, opener_band_id, second_band_id, third_band_id) OUTPUT INSERTED.id VALUES (@VenueName);", conn);
      SqlParameter headlinerBandIdParameter = new SqlParameter();
      headlinerBandIdParameter.ParameterName = "@HeadlinerBandId";
      headlinerBandIdParameter.Value = Band.FindByName(headliner).GetId();
      SqlParameter openerBandIdParameter = new SqlParameter();
      openerBandIdParameter.ParameterName = "@OpenerBandId";
      int openerOrEmpty = Band.FindByName(opener).GetId();
      openerBandIdParameter.Value = openerOrEmpty;
      SqlParameter secondBandIdParameter = new SqlParameter();
      secondBandIdParameter.ParameterName = "@SecondBandId";
      int secondBandOrEmpty = Band.FindByName(secondBand).GetId();
      secondBandIdParameter.Value = secondBandOrEmpty;
      SqlParameter thirdBandIdParameter = new SqlParameter();
      thirdBandIdParameter.ParameterName = "@ThirdId";
      int thirdBandOrEmpty = Band.FindByName(thirdBand).GetId();
      thirdBandIdParameter.Value = thirdBandOrEmpty;
      SqlParameter venueIdParameter = new SqlParameter();
      venueIdParameter.ParameterName = "@VenueId";
      venueIdParameter.Value = Venue.FindByName(venue).GetId();
      cmd.Parameters.Add(headlinerBandIdParameter);
      cmd.Parameters.Add(openerBandIdParameter);
      cmd.Parameters.Add(secondBandIdParameter);
      cmd.Parameters.Add(thirdBandIdParameter);
      cmd.Parameters.Add(venueIdParameter);
      rdr = cmd.ExecuteReader();
      while (rdr.Read())
      {
       Venue.FindByName(venue).SetId(rdr.GetInt32(0));
      }
      if (rdr != null)
      {
       rdr.Close();
      }
      if (conn != null)
      {
       conn.Close();
      }
    }
  }
}
