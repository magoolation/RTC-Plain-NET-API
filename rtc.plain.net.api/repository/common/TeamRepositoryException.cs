using rtc.plain.net.api.extras.emf.ecore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtc.plain.net.api.repository.common
{
    public class TeamRepositoryException : Exception
    {

        public const String EXCEPTION_DATA = "exceptionData";

        private static String getMessage(Exception cause)
        {
            if (cause == null)
                return null;

            String message = cause.Message;

            if (message == null)
            {
                message = "Internal error";
            }

            return message;
        }


        [NonSerialized]
        private Object origin = null;

        private Dictionary<String, Object> extraData = null;


        public TeamRepositoryException(String message) : base(message)
        {

        }




        public TeamRepositoryException(String message, Exception cause) : base(message, cause)
        {

        }













        public TeamRepositoryException(Object origin, String message) : base(message)
        {
            setOrigin(origin);
        }














        public TeamRepositoryException(Exception cause) : this(getMessage(cause), cause)
        {


        }




















        public TeamRepositoryException(Object origin, String message, Exception cause) : this(message, cause)
        {

            setOrigin(origin);

        }













        public Object getOrigin()
        {

            return origin;

        }














        public void setOrigin(Object origin)
        {

            this.origin = origin;

        }













        public Object getData()
        {

            return getExtraData("exceptionData");

        }















        public void setData(Object data)
        {

            setExtraData("exceptionData", data);

        }

















        protected void setExtraData(String key, Object data)
        {

            if (extraData == null)
            {

                extraData = new Dictionary<string, object>(3);

            }

            extraData.Add(key, data);

        }


        protected Object getExtraData(String key)
        {

            if (extraData == null)
            {

                return null;

            }

            return extraData[key];

        }










        public Dictionary<String, Object> getSerializableData()
        {

            if (extraData == null)
            {

                return new Dictionary<string, Object>();

            }

            return new Dictionary<string, Object>(extraData);

        }

        public void setSerializedData(Dictionary<String, Object> toSet)
        {

            if (extraData == null)
            {
                extraData = new Dictionary<String, Object>(toSet);
            }

            else
            {
                extraData.Concat(toSet).GroupBy(p => p.Key).ToDictionary(g => g.Key, g => g.Last().Value);
            }

        }

    }
}
