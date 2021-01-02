using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; } // auto - properties
        public string Address { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        
        private string _twitterAddress; //Backing variable
        public string TwitterAddress
        {
            //Asegurar que la cuenta de Twitter inicia con @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("La dirección de Twitter debe iniciar con @");
                }
            }
        }
        public School()
        {
            Name = "Untitled school";
            
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;

        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3; //Función expresión corporal, function bodied expression

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
            sb.AppendLine(Department);
            sb.AppendLine(Phone);

            return sb.ToString();
        }

    }
}
