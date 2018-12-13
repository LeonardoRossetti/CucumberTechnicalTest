using System;

namespace CucumberTechnicalTest.Models
{
    public class ResultModel
    {
        public String Name { get; set; }
        public String Number { get; set; }

        public ResultModel(String Name, String Number)
        {
            this.Name = Name;
            this.Number = Number;
        }
    }
}