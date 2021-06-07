using System;
using System.Collections.Generic;
using System.Text;

namespace LabList
{
    class Elem<T>
    {
        private object data;
        public Elem<object> pnext;
        public Elem<object> ppred;

        public Elem()
        {

        }

        public Elem(object newData)
        {
            data = newData;
            pnext = null;
            ppred = null;
        }

        public object Data {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
        public object DataReturn
        {
            get
            {
                return (T)data;
            }
        }

    }
}
