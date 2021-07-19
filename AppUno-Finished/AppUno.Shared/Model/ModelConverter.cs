using System;

namespace AppUno.Model
{
    public static class ModelConverter
    {
        public static Doc CreateDocFromString(string str)
        {
            var values = str.Split(',');
            return new Doc
            {
                Id = Convert.ToInt32(values[0]),
                Title = values[1],
                Expiration = values[2]
            };
        }
    }
}
