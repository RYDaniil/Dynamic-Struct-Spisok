using System;

namespace LabList
{
    class Program
    {
        static Elem<object> Add(double data, Elem<object> predElem)
        {
            var newElem = new Elem<object>(data);
            predElem.pnext = newElem;
            newElem.ppred = predElem;
            return newElem;
        }

        static void Main(string[] args)
        {
            var head = new Elem<object>();
            var elem = head;
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                elem = Add(Convert.ToDouble(Console.ReadLine()), elem);
            }

            head.ppred = elem;
            elem.pnext = head;

            Console.WriteLine("");
            elem = head.pnext;
            while (elem.Data != null)
            {
                Console.WriteLine(elem.Data);
                elem = elem.pnext;
            }
            Console.WriteLine("");


            elem = head.pnext;
            while (elem.Data != null)
            {
                if (Convert.ToDouble(elem.Data) < 0)
                {
                    if (elem.pnext.Data == null)
                    {
                        var elem1 = elem.pnext.pnext;
                        elem.pnext.pnext = elem1.pnext;
                        elem1.pnext.ppred = elem.pnext;
                    }
                    else
                    {
                        var elem1 = elem.pnext;
                        elem.pnext = elem1.pnext;
                        elem1.pnext.ppred = elem;
                    }
                }
                elem = elem.pnext;
            }


            elem = head.pnext;
            while (elem.Data != null)
            {
                Console.WriteLine(elem.Data);
                elem = elem.pnext;
            }
            Console.WriteLine("");
        }
    }
}
