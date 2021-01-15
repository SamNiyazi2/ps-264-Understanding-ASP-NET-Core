using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 01/15/2021 06:05 am - SSN - [20210115-0605] - [001] - M02-06 - The startup class

namespace PS_FishTankApp_M02.Models
{
    public class IntHistoryModel
    {

        public IntHistoryModel(DateTime timeStamp, int value)
        {
            TimeStamp = timeStamp;
            Value = value;
        }

        public DateTime TimeStamp { get; }
        public int Value { get; }
    }
}
