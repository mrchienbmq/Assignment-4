using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace T1807M1.Assignment4
{
    public class PhoneBook : Phone
    {
        private List<PhoneNumber> PhoneList;

        public override void insertPhone (string name, string phone)
        {
          
            foreach (var phonevar in PhoneList)
            {
                if (phonevar.Name.Equals(name))
                {
                    if (phonevar.Phone.Equals(phone))
                    {
                        Console.WriteLine("SO DIEN THOAI TON TAI");
                        return;
                    }

                    phonevar.Phone = phonevar.Phone + " : " + phone;

                } 
            }
            this.PhoneList.Add(new PhoneNumber(name,phone));

        }

        public override void removePhone(string name)
        {
            foreach (var phonevar in PhoneList)
            {
                if (phonevar.Name.Equals(name))
                {
                    Console.WriteLine("Số Điện Thoại Đã Cùng Tên Xóa");
                    this.PhoneList.Remove(phonevar);
                    return;
                }
                Console.WriteLine("No Thing");
            }
            
        }

        public override void updatePhone(string name, string newphone)
        {
            foreach (var phonevar in PhoneList)
            {
                if (phonevar.Name.Equals(name))
                {
                    Console.WriteLine("Them SDT");
                    phonevar.Name = phonevar.name + ":" + newphone;
                    Console.WriteLine("Them SDT Thanh Cong");
                }
                
            }
        }

        public override void searchPhone(string name)
        {
            foreach (var phonevar in PhoneList)
            {
                if (phonevar.Name.Equals(name))
                {
                    Console.WriteLine("Tim Ten");
                    Console.WriteLine(phonevar.Name +""+ phonevar.name);
                }
            }
        }
        
    }
    
}