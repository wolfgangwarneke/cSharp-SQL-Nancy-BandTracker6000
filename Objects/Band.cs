using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BandTracker
{
  public class Band
  {
    private int _id;
    private string _name;

    public Band(string name, int id = 0)
    {
      this.SetName(name);
      this.SetId(id);
    }

    public void SetId(int id)
    {
      _id = id;
    }

    public int GetId()
    {
      return _id;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public string GetName()
    {
      return _name;
    }

    public static List<Band> GetAll()
    {
      List<Band> everyBand = new List<Band>{};
      SqlConnection conn = DB.Connection();
      SqlDataReader rdr = null;
      conn.Open();
      SqlCommand cmd = new SqlCommand("SELECT * FROM bands;", conn);
      rdr = cmd.ExecuteReader();
      while(rdr.Read())
      {
        int bandId = rdr.GetInt32(0);
        string bandName = rdr.GetString(1);
        Band readBand = new Band(bandName, bandId);
        everyBand.Add(readBand);
      }
      if (rdr != null)
      {
        rdr.Close();
      }
      if (conn != null)
      {
        conn.Close();
      }
      return everyBand;
    }
    public override bool Equals(System.Object otherBand)
    {
      if (otherBand is Band)
      {
       Band newBand = (Band) otherBand;
       bool idEquality = (this.GetId() == newBand.GetId());
       bool nameEquality = (this.GetName() == newBand.GetName());
       return (idEquality && nameEquality);
      }
      else
      {
       return false;
      }
    }
  }
}
