using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBMIScore
{
    public class Person
    {
        public const int DEFAULT_HEIGHT = 5;
        public const int DEFAULT_WEIGHT = 50;
        private int _PersonId {  get; set; }
        private string _PersonName { get; set; }
        private int _PersonAge {  get; set; }
        private int _PersonHeight { get; set; }
        private int _PersonWeight { get; set; }

        public double PersonBmi { get; set; }


        public Person(int personId, string personName, int personAge ) :this(personId, personName, personAge, DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {
           
        }

        public Person(int personId, string personName, int personAge, int DEFAULT_HEIGHT, int DEFAULT_WEIGHT)
        {
            _PersonId = personId;
            _PersonName = personName;
            _PersonAge = personAge;
            _PersonHeight = DEFAULT_HEIGHT;
            _PersonWeight = DEFAULT_WEIGHT;
        }

    

        public double BMICalculator()
        {
            double ftTometerHeight = _PersonHeight * 0.3048;
            double heightSquare = Math.Pow( ftTometerHeight, 2 );
            double score =  _PersonWeight / heightSquare ;
            return PersonBmi = score;
        }


        public string Remark(double score)
        {
            if (score < 18.5)
            {
                return "Underweight";
            }
            else if (score > 18.5 && score < 24.9)
            {
                return "Healthy Weight";
            }
            else 
            {
                return "Overweight";
            }
        }



        public string PersonDetails()
        {
            return ("\n"+
                $"\nPerson Id: {_PersonId}" +
                $"\nPerson Name: {_PersonName}" +
                $"\nPerson Age: {_PersonAge}" +
                $"\nPerson height: {_PersonHeight}"+
                $"\nPerson Weight: {_PersonWeight}"+
                $"\nPerson BMI Score: {BMICalculator()}"+
                $"\nPerson Remark: {Remark(BMICalculator())}"
                );
        }




    }
}
