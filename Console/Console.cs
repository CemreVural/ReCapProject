using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console
{
    class Console
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }

        }
    }
}