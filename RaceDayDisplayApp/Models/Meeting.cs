﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RaceDayDisplayApp.Models
{
    public class MeetingBase
    {
        [Key]
        [CustomDisplay(DisplayOn.NONE)]
        public int MeetingId { get; set; }

        [CustomDisplay(DisplayOn.NONE)]
        public DateTime MeetingDate { get; set; }

        [Display(Name = "Date", Order = 1)]
        [CustomDisplay(DisplayOn.ALL)]
        public string _MeetingDate { get { return MeetingDate.ToString(@"ddd MMM d\t\h yyyy"); } }
        
        [CustomDisplay(DisplayOn.NONE)]
        public DateTime MinRaceJumpDateTimeUTC { get; set; }

        [CustomDisplay(DisplayOn.NONE)]
        public TimeSpan MinJumpTimeLocal { get; set; }

        [Display(Name = "Venue", Order = 2)]
        [CustomDisplay(DisplayOn.ALL)]
        public string RaceCourseName { get; set; }
    }

    public class Meeting : MeetingBase
    {
        [CustomDisplay(DisplayOn.NONE)]
        public int supermeetingtypeid { get; set; }

        [CustomDisplay(DisplayOn.NONE)]
        public int RaceCourseId { get; set; }

        [CustomDisplay(DisplayOn.NONE)]
        public int CountryId { get; set; }

        [CustomDisplay(DisplayOn.NONE)]
        public string CountryCode { get; set; }

        //[Display(Name = "Weather", Order = 0)]
        //[CustomDisplay(DisplayOn.BOTH)]
        //public string WeatherName { get; set; }

        //[Display(Name = "Going", Order = 0)]
        //[CustomDisplay(DisplayOn.BOTH)]
        //public string DefaultGoingName { get; set; }

        [Display(Name = "No./Races", Order = 3)]
        [CustomDisplay(DisplayOn.ALL)]
        public int NumberOfRaces { get; set; }

        //[CustomDisplay(DisplayOn.NONE)]
        //public string MeetingCode { get; set; }

        [Display(Name = "Time of Day", Order = 4)]
        [CustomDisplay(DisplayOn.HK)]
        public bool HK_isNightMeet { get; set; }

        //[Display(Name = "Time of Day", Order = 0)]
        //[CustomDisplay(DisplayOn.BOTH)]
        //public string TimeOfDay { get; set; }

        [Display(Name = "Track Variant", Order = 5)]
        [CustomDisplay(DisplayOn.ALL)]
        public string CourseVariantName { get; set; }
        
        //public string Code { get; set; }
        //public bool InUse { get; set; }
        //public DateTime SeasonStart { get; set; }

        [CustomDisplay(DisplayOn.NONE)]
        public IList<RaceBase> Races { get; set; }


        [CustomDisplay(DisplayOn.NONE)]
        public CountryEnum CountryEnum
        {
            get { return Country.GetEnum(CountryCode); }
        }

        //[CustomDisplay(DisplayOn.NONE)]
        //public static Meeting DummyMeeting
        //{
        //    get
        //    {
        //        Random rdm = new Random();
        //        Meeting m = FizzWare.NBuilder.Builder<Meeting>.CreateNew().Build();
        //        m.Races = FizzWare.NBuilder.Builder<RaceBase>.CreateListOfSize(rdm.Next(10) + 1).Build();

        //        return m;
        //    }
        //}
    }

}