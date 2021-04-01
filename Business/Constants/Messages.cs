using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Maintenance Time";

        public static string DailyPrice = "DailyPrice Must Be Bigger Than Zero !";

        public static string CarAdded = "Car Added";
        public static string CarNameInvalid = "Car Name Invalid !";
      public static string CarListed = "Cars Successfully Listed";
      public static string CarUpdated = "Car Information Updated";
      public static string CarDeleted = "Car Deleted";
      public static string CarNameAlreadyExists = "Car Name Already Exists Please Change Your Car Name and Try Again";

        public static string ColorAdded = "Color Added";
        public static string ColorNameInvalid = "Color Name Invalid !";
        public static string ColorDeleted = "Color Deleted";
        public static string ColorUpdated = "Color Information Updated";
        public static string CarColorCountOfCategoryError = "You Already Reach Maximum Color Capacity";

        public static string BrandAdded = "Brand Added";
        public static string BrandNameInvalid = "Brand Name Invalid !";
        public static string BrandDeleted = "Brand Deleted";
        public static string BrandUpdated = "Brand Information Updated";
        public static string CarBrandLimitExceded = "You Already Reach Maximum Brand Capacity You Can not Add New Brand Anymore";

        public static string UserAdded = "User Added";
        public static string UserDeleted = "User Deleted";
        public static string UserUpdated = "User Information Updated";

        public static string CustomerAdded = "Customer Added";
        public static string CustomerDeleted = "Customer Deleted";
        public static string CustomerUpdated = "Customer Information Updated";

        public static string RentalAdded = "Rental Added";
        public static string RentalDeleted = "Rental Deleted";
        public static string RentalUpdated = "Rental Information Updated";
        public static string CarNotReturned = "Car Not Yet Returned,Operation Failed ! ";


        public static string CarImageLimitExceeded = "You have reached the maximum picture for 1 vehicle";


        public static string AuthorizationDenied = "Authorization Denied !";
        public static string UserRegistered = "";
        public static string UserNotFound = "";
        public static string PasswordError = "";
        public static string SuccessfulLogin = "";
        public static string UserAlreadyExists = "";
        public static string AccessTokenCreated = "";
    }
}
