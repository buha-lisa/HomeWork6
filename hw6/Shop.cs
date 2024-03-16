namespace hw6
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Descript { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        
        public double Square { get; set; }

        public static Shop operator +(Shop shop, double increment)
        {
            return new Shop { Square = shop.Square + increment };
        }
        public static Shop operator -(Shop shop, double increment)
        {
            return new Shop { Square = shop.Square - increment };
        }

        public static bool operator ==(Shop left, Shop right)
        {
            return left.Square == right.Square;
        }
        public static bool operator !=(Shop left, Shop right)
        {
            return left.Square != right.Square;
        }

        public static bool operator >(Shop left, Shop right)
        {
            return left.Square > right.Square;
        }
        public static bool operator <(Shop left, Shop right)
        {
            return left.Square < right.Square;
        }

        public override bool Equals(object obj)
        {
            if (obj is Shop)
            {
                Shop other = (Shop)obj;
                return this.Square == other.Square;
            }
            return false;
        }
    }
}
