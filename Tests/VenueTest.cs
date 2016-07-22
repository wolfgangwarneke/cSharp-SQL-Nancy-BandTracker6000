using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Xunit;

namespace BandTracker
{
  public class VenueTest : IDisposable
  {
    public VenueTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=band_tracker_test;Integrated Security=SSPI;";
    }
    [Fact]
    public void Test_GetAll_DatabaseEmptyAtFirst()
    {
      List<Venue> emptyList = new List<Venue> {};
      Assert.Equal(emptyList, Venue.GetAll());
    }
    [Fact]
    public void Test_Equals_VenuesWithSameNameAndIdAreEqual()
    {
      Venue firstVenue = new Venue("The Cat's Cradle", 4);
      Venue firstVenueReplicant = new Venue("The Cat's Cradle", 4);
      Assert.Equal(firstVenue, firstVenueReplicant);
    }
    [Fact]
    public void Test_Save_SavesVenuesToDatabase()
    {
      Venue saveThisVenue = new Venue("The Cat's Meow");
      saveThisVenue.Save();
      Venue retrievedVenue = Venue.GetAll()[0];
      Assert.Equal(saveThisVenue.GetName(), retrievedVenue.GetName());
    }
    [Fact]
    public void Test_DeleteAll_DeletesAllVenuesInDatabase()
    {
      Venue saveThisVenue = new Venue("Cat Sabbath");
      saveThisVenue.Save();
      Venue saveThisVenueToo = new Venue("Meow Meow Meows");
      saveThisVenueToo.Save();
      Venue.DeleteAll();
      Assert.Equal(0, Venue.GetAll().Count);
    }
    [Fact]
    public void Test_DeleteThis_DeletesVenueWhichCallsDeleteThis()
    {
      Venue saveThisVenue = new Venue("The Meow");
      saveThisVenue.Save();
      Venue saveThisVenueToo = new Venue("The Yarn Ballroom");
      saveThisVenueToo.Save();
      saveThisVenueToo.DeleteThis();
      Assert.Equal(1, Venue.GetAll().Count);
    }
    [Fact]
    public void Test_Find_FindVenueByDataBaseId()
    {
      Venue saveThisVenue = new Venue("The Meow");
      saveThisVenue.Save();
      Venue expectedVenueToFind = Venue.GetAll()[0];
      int idToFindBy = expectedVenueToFind.GetId();
      Venue foundVenue = Venue.Find(idToFindBy);
      Assert.Equal(expectedVenueToFind, foundVenue);
    }
    [Fact]
    public void Test_UpdateVenueName_ChangeNameFrom()
    {
      Venue firstVenue = new Venue("The Meow Hall");
      firstVenue.Save();
      Venue secondVenue = new Venue("The Yarn Ballroom");
      secondVenue.Save();
      firstVenue.UpdateVenueName("The Kitten Sit-In");
      Venue firstVenueFromDatabase = Venue.Find(firstVenue.GetId());
      Assert.Equal("The Kitten Sit-In", firstVenueFromDatabase.GetName());
    }
    public void Dispose()
    {
      Venue.DeleteAll();
    }
  }
}
