namespace SRP.WebUI.Constants
{
    public static class ApiRoutes
    {
        public const string BaseUrl = "http://localhost:5161/";

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
            public const string GetAllWithNotNullImageAndCategoryNames = $"{Prefix}GetAllWithNotNullImageAndCategoryNames";
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

        public static class Booking
        {
            private const string Prefix = $"{BaseUrl}api/Bookings/";

            public const string GetAll = $"{Prefix}GetAll";
            public const string Add = $"{Prefix}Add";
            public const string Update = $"{Prefix}Update";
            public const string Delete = $"{Prefix}Delete";
            public const string GetById = $"{Prefix}GetById";
            public const string GetCount = $"{Prefix}GetCount";
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
    }
}