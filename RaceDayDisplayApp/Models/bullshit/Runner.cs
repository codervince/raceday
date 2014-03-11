//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaceDayDisplayApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Runner
    {
        public int Id { get; set; }
        public Nullable<int> RaceId { get; set; }
        public Nullable<short> HorseNumber { get; set; }
        public string Place { get; set; }
        public Nullable<short> Barrier { get; set; }
        public Nullable<int> HorseId { get; set; }
        public Nullable<int> JockeyId { get; set; }
        public Nullable<int> TrainerId { get; set; }
        public Nullable<double> AUS_HcpWt { get; set; }
        public Nullable<double> HK_ActualWtLbs { get; set; }
        public Nullable<double> HK_DeclaredHorseWtLbs { get; set; }
        public Nullable<short> AUS_HcpRatingAtJump { get; set; }
        public Nullable<short> HK_Rating { get; set; }
        public Nullable<double> AUS_BM { get; set; }
        public string HK_LBW { get; set; }
        public Nullable<double> HK_FinishTime { get; set; }
        public Nullable<decimal> AUS_SPW { get; set; }
        public Nullable<decimal> AUS_SPP { get; set; }
        public Nullable<decimal> HK_WinOdds { get; set; }
        public Nullable<short> RP2000 { get; set; }
        public Nullable<short> RP1600 { get; set; }
        public Nullable<short> RP1200 { get; set; }
        public Nullable<short> RP800 { get; set; }
        public Nullable<short> RP400 { get; set; }
        public Nullable<short> AUS_RP200 { get; set; }
        public Nullable<int> GearId { get; set; }
        public Nullable<double> Z_AUS_FinishTime { get; set; }
        public Nullable<bool> Z_newTrainerSinceLastStart { get; set; }
        public Nullable<short> Z_WinOdds { get; set; }
        public Nullable<short> Z_BPAdvFactor { get; set; }
    
        public virtual Gear Gear { get; set; }
        public virtual Horse Horse { get; set; }
        public virtual Jockey Jockey { get; set; }
        public virtual Race Race { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
