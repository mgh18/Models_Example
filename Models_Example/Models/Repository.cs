using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models_Example.Models
{
    public static class Repository
    {
        public static List<Person> people = new List<Person>()
        {
                new Person(){Id =1,Name="Maral Asadi",email="m.asadi@gmail.com",webSite="http://www.itsmaral.ir"},
                new Person(){Id =2,Name="Farhad HajiHoseeieni",email="fhaji@yahoo.com",webSite="http://www.merical.com"},
                new Person(){Id =3,Name="karim  jahanshir",email="kaj@jahan.com",webSite="http://www.google.com"}
        };

    }
} 