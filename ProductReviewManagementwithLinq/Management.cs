using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductReviewManagementwithLinq
{
    internal class Management
    {

        public DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReviewManagement> listProductReview)
        {
            var recordsData = (from productreviews in listProductReview
                               orderby productreviews.Rating descending
                               select productreviews).Take(3);

            foreach (var list in recordsData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + "" + "UserID:-" + list.UserID + "" + "Rating:-" + list.Rating + "" + "Review:-" + list.Review + "" + "islike:-" + list.islike + "");
            }
        }
        public void selectedRecords(List<ProductReviewManagement> listProductReviews)
        {
            var recordData = (from productReview in listProductReviews
                              where (productReview.ProductID == 1 || productReview.ProductID == 4 || productReview.ProductID == 9) && productReview.Rating > 3
                              select productReview);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + "" + "UserID:-" + list.UserID + "" + "Rating:-" + list.Rating + "" + "Review:-" + list.Review + "" + "islike:-" + list.islike + "");
            }
        }
        public void RetrieveCountofRecords(List<ProductReviewManagement> listProductReviews)
        {
            var RecordData = listProductReviews.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var list in RecordData)
            {
                Console.WriteLine(list.ProductID + "-------" + list.Count);
            }
        }
    }
}

   