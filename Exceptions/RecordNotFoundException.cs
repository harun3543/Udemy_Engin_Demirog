using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class RecordNotFoundException : Exception
    { 
        /*Bir yapıcı method da oluşturduğumuz message kelimesini base ile ana exception class ına gönderebilriz. Constructor bloğu sayesinde 
         base in constructor bloğuna kendi yazacağımız bir veri göndermiş olduk.*/
        public RecordNotFoundException(string message):base(message)
        {

        }
    }
}
