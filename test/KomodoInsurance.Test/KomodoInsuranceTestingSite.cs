using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

public class KomodoInsuranceTestingSite
{
    [Fact]
    public void CreateADeveloper()
    {
        Developer developers = new Developer(1, "Stan", "Smith", Pluralsight.Has_Access);
        developers.ID = 1234;

        int expectedDevID = 1234;
        int actualDevID = developers.ID;

        Assert.Equal(expectedDevID, actualDevID);
    }

    // [Fact]
    // public void CreateADevTeam()
    // {
    //     DevTeam devTeam = new DevTeam();
    //     devTeam.Developers = new List<Developer>
    //     {
    //         new Developer("Steve", "Smith")
    //     };

    //     int expected = 1;
    //     int actual = devTeam.Developers.Count;

    //     Assert.Equal(expected, actual);
    // }
}