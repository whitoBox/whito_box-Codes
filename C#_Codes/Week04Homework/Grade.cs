using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if false
namespace Week04Homework
{
    class Grade
    {
        //static field
        public static int MAX_GRADE_COUNT = 9;

        //instance field
        public string StudentNumber;
        public List<double> Scores = new List<double>();

        //instance method
        public double Average()
        {
            if (this.Scores.Count == 0) {
                return -1.0;
            }

            double sum = 0.0;
            foreach (var score in this.Scores) {
                sum += score;
            }
            return sum / Scores.Count;
        }
    }
}
#else
namespace Week04Homework
{
    class Grade
    {
        //static field
        //public static int MAX_GRADE_COUNT = 9;
        //private static int MAX_GRADE_COUNT = 9;
        //const = const + static
        public const int MAX_GRADE_COUNT = 9;

        //instance field
        public string StudentNumber;
        private List<double> _scores = new List<double>();

        public int Count()
        {
            return _scores.Count;
        }
        public double Get(int i)
        {
            return _scores[i];
        }

        //instance method
        public double Average()
        {
            if (this._scores.Count == 0) {
                return -1.0;
            }

            double sum = 0.0;
            foreach (var score in this._scores) {
                sum += score;
            }
            return sum / _scores.Count;
        }

        public void Clear()
        {
            _scores.Clear();
        }

        public bool Add(double score)
        {
            //score범위 확인 

            //if (_scores.Count >= MAX_GRADE_COUNT) {
            //if (_scores.Count >= this.MAX_GRADE_COUNT) {
            if (_scores.Count >= Grade.MAX_GRADE_COUNT) {
                return false;
            }

            _scores.Add(score);
            return true;
        }
    }
}
#endif