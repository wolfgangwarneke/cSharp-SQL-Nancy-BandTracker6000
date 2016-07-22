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
    [Fact]
    public void Test_Save_SavesBandsToDatabase()
    {
      Band saveThisBand = new Band("Cat Sabbath");
      saveThisBand.Save();
      Band retrievedBand = Band.GetAll()[0];
      Assert.Equal(saveThisBand.GetName(), retrievedBand.GetName());
    }
    [Fact]
    public void Test_Find_FindBandByDataBaseId()
    {
      Band saveThisBand = new Band("Catnip Stevens");
      saveThisBand.Save();
      Band expectedBandToFind = Band.GetAll()[0];
      int idToFindBy = expectedBandToFind.GetId();
      Band foundBand = Band.Find(idToFindBy);
      Assert.Equal(expectedBandToFind, foundBand);
    }

    public void Dispose()
    {
      Band.DeleteAll();
    }
  }
}
