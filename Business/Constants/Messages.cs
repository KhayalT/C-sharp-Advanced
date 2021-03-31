using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Your product name is invalid";
        public static string MaintenanceTime="Product out of order";
        public static string ProductsListed="Product is Listed";
        public static string ProductCountError = "Product count is higher than 10";

        public static string ProductNameAlreadyExists = "This Product name already exists";

        public static string CategoryLimitExceded = "The Category count bigger than 15";
    }
}
