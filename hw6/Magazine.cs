namespace hw6
{
    class Magazine
    {
        public string Name { get; set; }
        public string FoundYear { get; set; }
        public string Descript { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public int EmployeeAmount { get; set; }

        public static Magazine operator +(Magazine Magazine, int increment)
        {
            return new Magazine { EmployeeAmount = Magazine.EmployeeAmount + increment };
        }
        public static Magazine operator -(Magazine Magazine, int increment)
        {
            return new Magazine { EmployeeAmount = Magazine.EmployeeAmount - increment };
        }

        public static bool operator ==(Magazine left, Magazine right)
        {
            return left.EmployeeAmount == right.EmployeeAmount;
        }
        public static bool operator !=(Magazine left, Magazine right)
        {
            return left.EmployeeAmount != right.EmployeeAmount;
        }

        public static bool operator >(Magazine left, Magazine right)
        {
            return left.EmployeeAmount > right.EmployeeAmount;
        }
        public static bool operator <(Magazine left, Magazine right)
        {
            return left.EmployeeAmount < right.EmployeeAmount;
        }

        public override bool Equals(object obj)
        {
            if (obj is Magazine)
            {
                Magazine other = (Magazine)obj;
                return this.EmployeeAmount == other.EmployeeAmount;
            }
            return false;
        }

    }
}
