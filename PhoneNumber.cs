using System;

namespace T1807M1.Assignment4
{
    public class PhoneNumber
    {
        public string name;
        public string phone;



        
        public PhoneNumber()
        {
        }

        public PhoneNumber(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public string Name
        {
            get => Name;
            set => Name = value;
        }

        public string Phone
        {
            get => Phone;
            set => Phone = value;
        }
        
    }
}