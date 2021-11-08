using System;
using System.Collections.Generic;

namespace ProductReviewManagementwithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement");

            List<ProductReviewManagement> ProductReviewlist = new List<ProductReviewManagement>()
            {
                new ProductReviewManagement(){ProductID=1,UserID=1,Rating=5,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=2,UserID=1,Rating=3,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=3,UserID=2,Rating=5,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=4,UserID=3,Rating=3,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=5,UserID=2,Rating=3,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=6,UserID=4,Rating=2,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=1,UserID=3,Rating=1,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=11,UserID=10,Rating=1,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=10,UserID=10,Rating=2,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=12,UserID=10,Rating=3,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=13,UserID=10,Rating=3,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=14,UserID=10,Rating=3,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=15,UserID=10,Rating=3,Review="Good",islike=true},
                new ProductReviewManagement(){ProductID=16,UserID=10,Rating=3,Review="Good",islike=true},


            };
            //foreach(var list in ProductReviewlist)
            //{
            //    Console.WriteLine("ProductID:-" + list.ProductID + "" + "UserID:-" + list.UserID + "" + "Rating:-" + list.Rating + "" + "Review:-" + list.Review + "" + "islike:-" + list.islike + "");
            //}

            Management management = new Management();
            //UC-2
            //management.TopRecords(ProductReviewlist);

            //UC-3
            //management.selectedRecords(ProductReviewlist);

            //UC-4
            management.RetrieveCountofRecords(ProductReviewlist);


        }
    }
}

