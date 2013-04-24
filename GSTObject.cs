using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 
 * GPSd.NET
 * 
 * Copyright (C) 2013 Luiz Correia
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */


namespace GPSd.NET
{
    /// <summary>
    ///  A GST object is a pseudorange noise report. <br>
    ///  all getters for double values may return <code>Double.NaN</code> if value is not present<br>
    ///  other getters may return <code>null</code>
    /// </summary>
    public class GSTObject : GPSObject
    {
        /// <summary>
        /// The GPSd internal name 
        /// </summary>
        public static string NAME = "GST";

        private string tag = null;

        private string device = null;

        private double timeStamp = Double.NaN;

        private double rms = Double.NaN;

        private double major = Double.NaN;

        private double minor = Double.NaN;

        private double orient = Double.NaN;

        private double lat = Double.NaN;

        private double lon = Double.NaN;

        private double alt = Double.NaN;

        /// <summary>
        /// Type tag associated with this GPS sentence; from an NMEA device this is just the NMEA sentence type.
        /// </summary>
        public string Tag
        {
            get { return this.tag; }
            set { this.tag = value; }
        }

        /// <summary>
        /// Name of originating device
        /// </summary>
        public string Device
        {
            get { return device; }
            set { device = value; }
        }

        /// <summary>
        /// Seconds since the Unix epoch, UTC. May have a fractional part of up to .001sec precision.
        /// </summary>
        public double TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        /// <summary>
        /// Value of the standard deviation of the range inputs to the navigation process 
        /// (range inputs include pseudoranges and DGPS corrections).
        /// </summary>
        public double Rms
        {
            get { return rms; }
            set { rms = value; }
        }

        /// <summary>
        /// Standard deviation of semi-major axis of error ellipse, in meters.
        /// </summary>
        public double Major
        {
            get { return major; }
            set { major = value; }
        }

        /// <summary>
        /// Standard deviation of semi-minor axis of error ellipse, in meters.
        /// </summary>
        public double Minor
        {
            get { return minor; }
            set { minor = value; }
        }

        /// <summary>
        /// Orientation of semi-major axis of error ellipse, in degrees from true north.
        /// </summary>
        public double Orient
        {
            get { return orient; }
            set { orient = value; }
        }

        /// <summary>
        /// Standard deviation of latitude error, in meters.
        /// </summary>
        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        /// <summary>
        /// Standard deviation of longitude error, in meters.
        /// </summary>
        public double Lon
        {
            get { return lon; }
            set { lon = value; }
        }

        /// <summary>
        /// Standard deviation of altitude error, in meters.
        /// </summary>
        public double Alt
        {
            get { return alt; }
            set { alt = value; }
        }

        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            long temp;
            temp = Convert.ToInt64(this.alt);
            result = (prime * result) + (int)(temp ^ (temp >> 32));
            result = (prime * result) + ((this.device == null) ? 0 : this.device.GetHashCode());
            temp = Convert.ToInt64(this.lat);
            result = (prime * result) + (int)(temp ^ (temp >> 32));
            temp = Convert.ToInt64(this.lon);
            result = (prime * result) + (int)(temp ^ (temp >> 32));
            temp = Convert.ToInt64(this.major);
            result = (prime * result) + (int)(temp ^ (temp >> 32));
            temp = Convert.ToInt64(this.minor);
            result = (prime * result) + (int)(temp ^ (temp >> 32));
            temp = Convert.ToInt64(this.orient);
            result = (prime * result) + (int)(temp ^ (temp >> 32));
            temp = Convert.ToInt64(this.rms);
            result = (prime * result) + (int)(temp ^ (temp >> 32));
            result = (prime * result) + ((this.tag == null) ? 0 : this.tag.GetHashCode());
            temp = Convert.ToInt64(this.timeStamp);
            result = (prime * result) + (int)(temp ^ (temp >> 32));
            return result;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            GSTObject other = (GSTObject)obj;
            if (Convert.ToInt64(this.alt) != Convert.ToInt64(other.alt))
            {
                return false;
            }
            if (this.device == null)
            {
                if (other.device != null)
                {
                    return false;
                }
            }
            else if (!this.device.Equals(other.device))
            {
                return false;
            }
            if (Convert.ToInt64(this.lat) != Convert.ToInt64(other.lat))
            {
                return false;
            }
            if (Convert.ToInt64(this.lon) != Convert.ToInt64(other.lon))
            {
                return false;
            }
            if (Convert.ToInt64(this.major) != Convert.ToInt64(other.major))
            {
                return false;
            }
            if (Convert.ToInt64(this.minor) != Convert.ToInt64(other.minor))
            {
                return false;
            }
            if (Convert.ToInt64(this.orient) != Convert.ToInt64(other.orient))
            {
                return false;
            }
            if (Convert.ToInt64(this.rms) != Convert.ToInt64(other.rms))
            {
                return false;
            }
            if (this.tag == null)
            {
                if (other.tag != null)
                {
                    return false;
                }
            }
            else if (!this.tag.Equals(other.tag))
            {
                return false;
            }
            if (Convert.ToInt64(this.timeStamp) != Convert.ToInt64(other.timeStamp))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("GSTObject{tag=");
            sb.Append(this.tag);
            sb.Append(", device=");
            sb.Append(this.device);
            sb.Append(", timestamp=");
            sb.Append(this.timeStamp);
            sb.Append(", rms=");
            sb.Append(this.rms);
            sb.Append(", major=");
            sb.Append(this.major);
            sb.Append(", minor=");
            sb.Append(this.minor);
            sb.Append(", orient=");
            sb.Append(this.orient);
            sb.Append(", lat=");
            sb.Append(this.lat);
            sb.Append(", lon=");
            sb.Append(this.lon);
            sb.Append(", alt=");
            sb.Append(this.alt);
            sb.Append("}");
            return sb.ToString();
        }

    }
}
