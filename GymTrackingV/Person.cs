using System;
using System.Collections.Generic;
using System.Text;
/*
 * Title:   Person
 * Author:  Paul McKillop
 * Date:    04 January 2020
 * Purpose: Hold data for person as user
 */

namespace GymTrackingV
{
    public class Person
    {
        private string personName;

        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private float rate;

        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

    }

 /******************************
 *  Notes
 * **************************** 
 *  
 *  No methods in this class
 *  
 ******************************/
}
