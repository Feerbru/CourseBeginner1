﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBeginner1
{
    public class Media
    {
        private int parentRate;

        public string Title { get; set; }

        protected bool ThisContentIsCorrectForThisAge(int age)
        {
            if (age >= parentRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            var mediaObj = (Media)obj;

            if (mediaObj.Title == this.Title)
                return true;
            else
                return false;

        }

        public virtual void Play()
        {
            Console.WriteLine($"Playing {Title}");
        }
    }
}
