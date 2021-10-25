using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpsMasterAssigments
{
    public enum PayoutType
    {
        Hourly,
        Daily, 
        Weekly,
        Monthly,
        Commission
    }
    public  class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        internal decimal Salary { get; set; }
        public Employee() { }
        ~Employee() { }
        public void Work() { }

        public virtual void Payout()
        { }
            

       
    }

    public class Consultant : Employee
    {
        public string ProjectName { get; set; }
    }
    public class QualityEngineer : Employee
    {
        public string TestingTool { get; set; }
    }
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
    }

    public class Contructual: Employee
    {
        public PayoutType _payout { get; private set; }
        /// <summary>
        /// constructor with parameter Payout
        /// constructor/function overloading
        /// </summary>
        /// <param name="payoutType"></param>
        public Contructual(PayoutType payoutType)
        {
            _payout = payoutType;
        }

        /// <summary>
        /// Default constructor 
        /// constructor/function overloading
        /// </summary>
        public Contructual()
        {
            // default payout type
            _payout = PayoutType.Monthly;

        }

       /// <summary>
       /// overriding 
       /// </summary>
        public override void Payout()
        {

        }

        public void Payout(PayoutType payoutType)
        {

        }
        
    }
}

