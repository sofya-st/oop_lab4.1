using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab4._1
{
    class Object
    {
        Object()
        {

        }
        ~Object()
        {

        }
    }

    class Storage
    {
        public Object[] arr;
        private int size;
        public Storage()
        {
            size = 0;
            arr = new Object[size];
        }

        public void AddObj(Object obj)
        {
            resize(size + 1);
            arr[size - 1] = obj;
        }

        public int CountObj()
        {
            return size;
        }

        private void resize(int newsize)
        {
            Object[] tmpArr = new Object[size];
            for (int i = 0; i < size; i++)
            {
                tmpArr[i] = arr[i];
            }
            arr = new Object[newsize];
            for (int i = 0; i < size; i++)
            {
                arr[i] = tmpArr[i];
            }
            size = newsize;
        }

        public void DeleteObj(int ind)
        {
            if (ind < (size - 1))
            {
                for (int i = ind; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
            }
            arr[size - 1] = null;
            resize(size - 1);
        }


    }
}