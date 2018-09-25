using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class Employee1
    {
         int Id;
         string Name;
         double Salary;
         string Location;
         string Company;
        public Employee1(int id,string name,double salary,string location,string company)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Location = location;
            this.Company = company;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Salary;
                else if (index == 3)
                    return Location;
                else if (index == 4)
                    return Company;
                return null;
            }
            set
            {
                if (index == 0)
                    Id=(int)value;
                else if (index == 1)
                     Name=(string)value;
                else if (index == 2)
                    Salary=(double)value;
                else if (index == 3)
                     Location=(string)value;
                else if (index == 4)
                    Company=(string)value;
                
            }
        }

    }
}
