using BlazorRadzenGridTests.BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRadzenGridTest.Server.Services
{
    public class TestDataService
    {
        public IQueryable<TestDataModel> GetAll()
        {
            return data.AsQueryable();
        }

        public static List<TestDataModel> data = new()
        {
            new TestDataModel { ArtistId=1, ArtistType="Person", Name="Artist 1", IsVerified=false },
            new TestDataModel { ArtistId=2, ArtistType="Group", Name="Artist 2", IsVerified=false },
            new TestDataModel { ArtistId=3, ArtistType="Person", Name="Artist 3", IsVerified=false },
            new TestDataModel { ArtistId=4, ArtistType="Group", Name="Artist 4", IsVerified=false },
            new TestDataModel { ArtistId=5, ArtistType="Person", Name="Artist 5", IsVerified=false },
            new TestDataModel { ArtistId=6, ArtistType="Group", Name="Artist 6", IsVerified=false },
            new TestDataModel { ArtistId=7, ArtistType="Person", Name="Artist 7", IsVerified=false },
            new TestDataModel { ArtistId=8, ArtistType="Group", Name="Artist 8", IsVerified=false },
            new TestDataModel { ArtistId=9, ArtistType="Person", Name="Artist 9", IsVerified=false },
            new TestDataModel { ArtistId=10, ArtistType="Group", Name="Artist 10", IsVerified=false },
            new TestDataModel { ArtistId=11, ArtistType="Person", Name="Artist 11", IsVerified=false },
            new TestDataModel { ArtistId=12, ArtistType="Group", Name="Artist 12", IsVerified=false },
            new TestDataModel { ArtistId=13, ArtistType="Person", Name="Artist 13", IsVerified=false },
            new TestDataModel { ArtistId=14, ArtistType="Group", Name="Artist 14", IsVerified=false },
            new TestDataModel { ArtistId=15, ArtistType="Person", Name="Artist 15", IsVerified=false },
            new TestDataModel { ArtistId=16, ArtistType="Group", Name="Artist 16", IsVerified=false },
            new TestDataModel { ArtistId=17, ArtistType="Person", Name="Artist 17", IsVerified=false },
            new TestDataModel { ArtistId=18, ArtistType="Group", Name="Artist 18", IsVerified=true },
            new TestDataModel { ArtistId=19, ArtistType="Person", Name="Artist 19", IsVerified=false },
            new TestDataModel { ArtistId=20, ArtistType="Group", Name="Artist 20", IsVerified=false },
            new TestDataModel { ArtistId=21, ArtistType="Person", Name="Artist 21", IsVerified=false },
            new TestDataModel { ArtistId=22, ArtistType="Group", Name="Artist 22", IsVerified=false },
            new TestDataModel { ArtistId=23, ArtistType="Person", Name="Artist 23", IsVerified=false },
            new TestDataModel { ArtistId=24, ArtistType="Group", Name="Artist 24", IsVerified=false },
            new TestDataModel { ArtistId=25, ArtistType="Person", Name="Artist 25", IsVerified=false },
            new TestDataModel { ArtistId=26, ArtistType="Group", Name="Artist 26", IsVerified=false },
            new TestDataModel { ArtistId=27, ArtistType="Person", Name="Artist 27", IsVerified=false },
            new TestDataModel { ArtistId=28, ArtistType="Group", Name="Artist 28", IsVerified=false },
            new TestDataModel { ArtistId=29, ArtistType="Person", Name="Artist 29", IsVerified=false },
            new TestDataModel { ArtistId=30, ArtistType="Group", Name="Artist 30", IsVerified=false },
            new TestDataModel { ArtistId=31, ArtistType="Person", Name="Artist 31", IsVerified=false },
            new TestDataModel { ArtistId=32, ArtistType="Group", Name="Artist 32", IsVerified=false },
            new TestDataModel { ArtistId=33, ArtistType="Person", Name="Artist 33", IsVerified=false },
            new TestDataModel { ArtistId=34, ArtistType="Group", Name="Artist 34", IsVerified=false },
            new TestDataModel { ArtistId=35, ArtistType="Person", Name="Artist 35", IsVerified=false },
            new TestDataModel { ArtistId=36, ArtistType="Group", Name="Artist 36", IsVerified=true },
            new TestDataModel { ArtistId=37, ArtistType="Person", Name="Artist 37", IsVerified=false },
            new TestDataModel { ArtistId=38, ArtistType="Group", Name="Artist 38", IsVerified=false },
            new TestDataModel { ArtistId=39, ArtistType="Person", Name="Artist 39", IsVerified=false },
            new TestDataModel { ArtistId=40, ArtistType="Group", Name="Artist 40", IsVerified=false },
            new TestDataModel { ArtistId=41, ArtistType="Person", Name="Artist 41", IsVerified=false },
            new TestDataModel { ArtistId=42, ArtistType="Group", Name="Artist 42", IsVerified=false },
            new TestDataModel { ArtistId=43, ArtistType="Person", Name="Artist 43", IsVerified=false },
            new TestDataModel { ArtistId=44, ArtistType="Group", Name="Artist 44", IsVerified=false },
            new TestDataModel { ArtistId=45, ArtistType="Person", Name="Artist 45", IsVerified=true },
            new TestDataModel { ArtistId=46, ArtistType="Group", Name="Artist 46", IsVerified=false },
            new TestDataModel { ArtistId=47, ArtistType="Person", Name="Artist 47", IsVerified=false },
            new TestDataModel { ArtistId=48, ArtistType="Group", Name="Artist 48", IsVerified=false },
            new TestDataModel { ArtistId=49, ArtistType="Person", Name="Artist 49", IsVerified=false },
            new TestDataModel { ArtistId=50, ArtistType="Group", Name="Artist 50", IsVerified=false },



        };

    }
}
