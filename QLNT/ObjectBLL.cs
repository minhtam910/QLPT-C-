using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public abstract class ObjectBLL
    {
        protected Dictionary<String, Object> interactObjects;

        public void addObject(String type, Object someObject)
        {
            interactObjects.Add(type, someObject);
        }

        public Dictionary<String, Object> getListObject()
        {
            return interactObjects;
        }

        public void setListObject(Dictionary<String,Object> dict)
        {
            interactObjects = dict;
        }
        public abstract void editObject();

        public abstract DataTable findObject();

        public abstract void addObject();

        public abstract void deleteObject();

    }
}
