namespace SRP.WebUI.Constants
{
    public static class ApiRoutes
    {
        public const string BaseUrl = "http://localhost:5161/";

        public static class Auth
        {
            private const string Prefix = $"{BaseUrl}api/Authentications/";
            public const string Register = $"{Prefix}Register";
            public const string Login = $"{Prefix}Login";
            public const string GetUsersByRoleId = $"{Prefix}GetUsersByRoleId";
            public const string GetAllUsers = $"{Prefix}GetAllUsers";
            public const string GetCurrentUser = $"{Prefix}GetCurrentUser";
            public const string GetUserById = $"{Prefix}GetUserById";
            public const string UpdateUser = $"{Prefix}UpdateUser";
        }


        public static class Category
        {
            private const string Prefix = $"{BaseUrl}api/Categories/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
            public const string GetActiveCount = $"{Prefix}GetActiveCount";
            public const string GetPassiveCount = $"{Prefix}GetPassiveCount";
        }

        public static class Product
        {
            private const string Prefix = $"{BaseUrl}api/Products/";

            public const string GetAllWithCategoryName = $"{Prefix}GetAllWithCategoryName";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
            public const string GetCountWithCategoryNameOfHamburger = $"{Prefix}GetCountWithCategoryNameOfHamburger";
            public const string GetCountWithCategoryNameOfDrink = $"{Prefix}GetCountWithCategoryNameOfDrink";
            public const string GetTotalAveragePrice = $"{Prefix}GetTotalAveragePrice";
            public const string GetNameByMaxPrice = $"{Prefix}GetNameByMaxPrice";
            public const string GetNameByMinPrice = $"{Prefix}GetNameByMinPrice";

            public const string GetAllWithNotNullImageAndCategoryNames =
                $"{Prefix}GetAllWithNotNullImageAndCategoryNames";
        }

        public static class About
        {
            private const string Prefix = $"{BaseUrl}api/Abouts/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
        }

        public static class Message
        {
            private const string Prefix = $"{BaseUrl}api/Messages/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
        }

        public static class MenuTable
        {
            private const string Prefix = $"{BaseUrl}api/MenuTables/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
        }

        public static class Basket
        {
            private const string Prefix = $"{BaseUrl}api/Baskets/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
            public const string GetByMenuTableNumber = $"{Prefix}GetByMenuTableNumber";
            public const string AddWithProductId = $"{Prefix}AddWithProductId";
        }

        public static class Booking
        {
            private const string Prefix = $"{BaseUrl}api/Bookings/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
            public const string StatusChangeById = $"{Prefix}StatusChangeById";
        }

        public static class Contact
        {
            private const string Prefix = $"{BaseUrl}api/Contacts/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
        }

        public static class Discount
        {
            private const string Prefix = $"{BaseUrl}api/Discounts/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
            public const string StatusChangeById = $"{Prefix}StatusChangeById";
            public const string GetAllByStatus = $"{Prefix}GetAllByStatus";
        }

        public static class Feature
        {
            private const string Prefix = $"{BaseUrl}api/Features/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
        }

        public static class SocialMedia
        {
            private const string Prefix = $"{BaseUrl}api/SocialMedias/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
        }

        public static class Testimonial
        {
            private const string Prefix = $"{BaseUrl}api/Testimonials/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
        }

        public static class Notification
        {
            private const string Prefix = $"{BaseUrl}api/Notifications/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string UpdateStatusById = $"{Prefix}UpdateStatusById";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
        }
    }
}