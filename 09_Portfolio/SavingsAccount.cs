using System;
namespace _09_Portfolio
{
    public class SavingsAccount : IAsset
    {
        public double InterestRate { get; internal set; }
        public string Accountname { get; internal set; }
        public double Value { get; internal set; }
        public SavingsAccount(string accountname, double value, double interest)
        {
            Accountname = accountname;
            Value = value;
            InterestRate = interest;
        }
        public override string ToString()
        {
            return "SavingsAccount[value="+Value.ToString("0.0").Replace(',','.')+",interestRate="+InterestRate.ToString("0.0").Replace(',','.')+"]";
        }

        internal void ApplyInterest()
        {
            Value *= 1 + (InterestRate / 100);
        }

        public double GetValue()
        {
            return Value;
        }
    }
}