﻿//============================================================
// Student Number : S10205942, S10205045
// Student Name : Elsa Lee Ting, Brayden Choi Di Rong
// Module Group : T06
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_T06_Team9
{
    class SHNFacility
    {
        public string FacilityName { get; set; }
        public int FacilityCapacity { get; set; }
        public int FacilityVacancy { get; set; }
        public double DistFromAirCheckpoint { get; set; }
        public double DistFromSeaCheckpoint { get; set; }
        public double DistFromLandCheckpoint { get; set; }

        public SHNFacility()
        {

        }

        public SHNFacility(string facilityName, int facilityCapacity, double distFromAirCheckpoint, double distFromSeaCheckpoint, double distFromLandCheckpoint)
        {
            FacilityName = facilityName;
            FacilityCapacity = facilityCapacity;
            DistFromAirCheckpoint = distFromAirCheckpoint;
            DistFromSeaCheckpoint = distFromSeaCheckpoint;
            DistFromLandCheckpoint = distFromLandCheckpoint;
        }

        public double CalculateTravelCost(string entryMode, DateTime entryDate)
        {
            double baseFare = 0;
            if (entryMode == "Air")
            {
                baseFare += 50 + DistFromAirCheckpoint * 0.22;
                var start = new TimeSpan(6, 0, 0);
                
                if (entryDate.TimeOfDay >= start)
                {

                }

            }
            else if (entryMode == "Land")
            {
                baseFare += 50 + DistFromLandCheckpoint * 0.22;
            }
            else if (entryMode == "Sea")
            {
                baseFare += 50 + DistFromSeaCheckpoint * 0.22;
            }
        }

        public bool IsAvailable()
        {
            bool isAvail = true;
            if (FacilityVacancy == 0)
            {
                isAvail = false;
            }
            return isAvail;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
