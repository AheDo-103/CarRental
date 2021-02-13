using System;
using Business.Abstract;
using Business.Conctrete;
using DataAccess.Conctrete.EntityFramework;
using Entities.Conctrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBrandService _brandService = new BrandManager(new EfBrandDal());
            var result = _brandService.GetAll();
            result.Data.ForEach(x => Console.WriteLine(x.BrandName));
            Console.WriteLine("\n\n------------\n\n");
            Brand brand = new Brand()
            {
                BrandName = "mw",
            };
            var addResult = _brandService.Add(brand);
            Console.WriteLine(addResult.Message);
            result.Data.ForEach(x => Console.WriteLine(x.BrandName));
        }
    }
}