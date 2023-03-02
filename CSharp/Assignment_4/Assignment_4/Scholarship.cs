using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Scholarship
    {
        private int totalMarks;
        private float fees;

        public Scholarship(int totalMarks, float fees)
        {
            this.totalMarks = totalMarks;
            this.fees = fees;
        }

        public float Merit()
        {
            float scholarshipAmount = 0;

            if (totalMarks > 70 && totalMarks < 80)
            {
                scholarshipAmount = 0.2f * fees;
            }
            else if (totalMarks > 80 && totalMarks < 90)
            {
                scholarshipAmount = 0.4f * fees;
            }
            else if (totalMarks > 90)
            {
                scholarshipAmount = 0.6f * fees;
            }

            return scholarshipAmount;
        }
    }
}
