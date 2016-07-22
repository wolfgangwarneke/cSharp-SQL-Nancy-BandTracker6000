using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Xunit;

namespace BandTracker
{
  public class BandTest : IDisposable
  {
    public BandTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=band_tracker_test;Integrated Security=SSPI;";
    }
    [Fact]
    public void Test_GetAll_DatabaseEmptyAtFirst()
    {
      List<Band> emptyList = new List<Band> {};
      Assert.Equal(emptyList, Band.GetAll());
    }
    [Fact]
    public void Test_Equals_BandsWithSameNameAndIdAreEqual()
    {
      Band firstBand = new Band("Vet Shop Boys", 4);
      Band firstBandReplicant = new Band("Vet Shop Boys", 4);
      Assert.Equal(firstBand, firstBandReplicant);
    }
    public void Dispose()
    {
      // Band.DeleteAll();
    }
  }
}
