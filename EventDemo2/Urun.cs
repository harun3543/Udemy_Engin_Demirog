using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo2
{
    public delegate void StokAzaldiEventHandler();              //Bir tane delegate belirledik.
    class Urun
    {
        int _id;
        string _ad;
        double _fiyat;
        int _stokMiktarı;

        public event StokAzaldiEventHandler StokAzaldiEvent;        //Bir tane event belirledik.
        public Urun(int id,string ad,double fiyat,int stoksayisi)
        {
            _id = id;
            _ad = ad;
            _fiyat = fiyat;
            _stokMiktarı = stoksayisi;
        }

        public int StokMiktarı
        {
            get { return _stokMiktarı; }
            set { _stokMiktarı = value;
                if (_stokMiktarı<10 && StokAzaldiEvent != null )
                {
                    StokAzaldiEvent();          //Event çalıştırılır.
                }
            }
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Ad { get { return _ad; } set { _ad = value; } }
        public double Fiyat { get { return _fiyat; } set { _fiyat = value; } }
    }
}
