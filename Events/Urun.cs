using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events.Program;

namespace Events
{
    class Urun
    {
        int _id;
        string _ad;
        double _fiyat;
        public event UrunEventHandler fiyatdegisti;

        public Urun(int id, string ad, double fiyat)
        {
            Id = id;
            Ad = ad;
            Fiyat = fiyat;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public double Fiyat
        {
            get { return _fiyat; }
            set
            {
                double eskiFiyat = _fiyat;
                _fiyat = value;
                if (fiyatdegisti != null)
                {
                    fiyatdegisti.Invoke(eskiFiyat, value, this);
                }
            }
        }
    }
}

