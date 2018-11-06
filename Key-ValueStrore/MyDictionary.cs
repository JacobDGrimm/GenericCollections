using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStrore
{
    public class MyDictionary
    {
        KeyValue[] arr = new KeyValue[2];

        int inserted = 0;

        public object this [string key]
        {
            get
            {
                for (int i = 0; i < inserted; ++i)
                {
                    if (arr[i].key == key)
                        return arr[i].value;
                }

                throw new KeyNotFoundException("invalid key");
            }

            set
            {
                for (int i = 0; i < inserted; i++)
                {
                    if (arr[i].key == key)
                    {
                        arr[i] = new KeyValue(key, value);
                        return;
                    }
                }

                arr[inserted++] = new KeyValue(key, value);
            }
        }


    }
}
