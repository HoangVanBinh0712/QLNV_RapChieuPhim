using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim
{
    public class NhanVienDAO
    {
        private int ID;
        private string Name;
        private DateTime birthday;
        private string PhoneNumber;
        private string Email;
        private string Job;
        private DateTime DayRented;
        private string password;
        private Image image;
        public int getNVid()
        {
            return this.ID;
        }
        public void setNVid(int id)
        {
            this.ID = id;
        }
        public string getNVName()
        {
            return this.Name;
        }
        public void setNVName(string name)
        {
            this.Name = name;
        }
        public string getNVPNum()
        {
            return PhoneNumber;
        }
        public void setNVPnum(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public string getNVJob()
        {
            return Job;
        }
        public void setNVJob(string Job)
        {
            this.Job = Job;
        }
        public string getNVEmail()
        {
            return this.Email;
        }
        public void setNVEmail(string Email)
        {
            this.Email = Email;
        }
        public DateTime getNVBirth()
        {
            return this.birthday;
        }
        public void setNVBirth(DateTime dt)
        {
            this.birthday = dt;
        }
        /* private DateTime DayRented;
        private string password;*/
        public DateTime getDRented()
        {
            return this.DayRented;
        }
        public void setDRented(DateTime dr)
        {
            this.DayRented = dr;
        }
        public string getpassword()
        {
            return this.password;
        }
        public void setpassword(string pass)
        {
            this.password = pass;
        }
        public Image getNVimg()
        {
            return this.image;
        }
        public void setNVimg(Image x)
        {
            this.image = x;
        }
    }
}
