using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorTask
{
    internal class Product
    {
        public int Id;
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int Income;
        public int Count;

        public Product(int id,string brandName,string model,int price,int cost,int count)
        {
            Id= id;
            BrandName= brandName;
            Model= model;
            Price= price;
            Cost= cost;
            Count= count;
            Sale();
        }
        public void GetInfo()
        {
            Console.WriteLine($"Id:{Id},Brand name:{BrandName},Model: {Model},Price: {Price},Cost: {Cost},Income: {Income},Count: {Count}");
        }
        public int Sale()
        {
            if (Count > 0)
            {
                Income = Price * Count - Cost * Count;
                Count--;
            }
            else
            {
                return 0;
            }
            return Income;

        }
    }
    //Product classi yaradirsiz:

    // Id

    // BrandName,

    // Model,

    // Price,

    // Cost, - xercleri   

    // Income, - umumi gelir

    // Count - mehsulun sayi

    // fieldleri olur. 

    //Constructor ishe dushdukde Income butun deyerleri qebul edir.(Income 0-dan bashliyib mehsul satildiqca artacaq. Count menfi ola bilmez. Menfi gonderilerse 0 verilsin).
    //GetInfo() methodu olur.



    //Sale() methodu olur.Eger kifayet qeder mehsul varsa Satishi heyata kecirir satilan qiymetden xercler cixilaraq gelire elave edir ve mehsul sayini azaldir.
}

