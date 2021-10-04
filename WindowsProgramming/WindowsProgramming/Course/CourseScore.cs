using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    class CourseScore : ICourse
    {
        private uint _phase;
        private float _credits;
        private uint _hours;
        private string _require;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="phase"></param>
        /// <param name="credits"></param>
        /// <param name="hours"></param>
        /// <param name="require"></param>
        public CourseScore(string phase, string credits, string hours, string require)
        {
            _phase = uint.Parse(phase);
            _credits = float.Parse(credits);
            _hours = uint.Parse(hours);
            _require = require;
            SetData(CourseIndex.Phase, _phase);
            SetData(CourseIndex.Credits, _credits);
            SetData(CourseIndex.Hours, _hours);
            SetData(CourseIndex.Require, _require);
        }

        public CourseScore(List<string> rawData , out List<string> trimmedData)
        {
            uint.TryParse(rawData.First(), out _phase);
            rawData.RemoveAt(0);
            float.TryParse(rawData.First(), out _credits);
            rawData.RemoveAt(0);
            uint.TryParse(rawData.First(), out _hours);
            rawData.RemoveAt(0);
            _require = rawData.First();
            rawData.RemoveAt(0);
            trimmedData = rawData;
        }

        public uint Phase
        {
            get 
            {
                return _phase;
            }
            set
            {
                _phase = value;
            }
        }

        public float Credits
        {
            get 
            {
                return _credits;
            }
            set
            {
                _credits = value;
            }
        }

        public uint Hours
        {
            get 
            {
                return _hours;
            }
            set
            {
                _hours = value;
            }
        }

        public string Require
        {
            get 
            {
                return _require;
            }
            set
            {
                _require = value;
            }
        }
    }
}
