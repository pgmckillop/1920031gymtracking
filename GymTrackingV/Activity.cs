using System;
using System.Collections.Generic;
using System.Text;

/*
 * Title:   Activity
 * Author:  Paul McKillop
 * Date:    04 January 2020
 * Purpose: Holds data for gym activities
 */

namespace GymTrackingV
{
    public class Activity
    {
        public string MachineName { get; set; }
        public string Level { get; set; }
        public bool Weighted { get; set; }
        public int Duration { get; set; }
        
        //-- Hold corrected rate
        public double Used { get; set; }
    }
}
