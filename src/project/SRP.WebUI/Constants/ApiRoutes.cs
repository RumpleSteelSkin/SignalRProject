namespace SRP.WebUI.Constants;

public static class ApiRoutes
{
    public const string BaseUrl = "http://localhost:5161/api/";

    public const string CategoryGetAll = $"{BaseUrl}Categories/GetAll";
    public const string CategoryAdd = $"{BaseUrl}Categories/Add";
    public const string CategoryUpdate = $"{BaseUrl}Categories/Update";
    public const string CategoryDelete = $"{BaseUrl}Categories/Delete";
    public const string CategoryGetById = $"{BaseUrl}Categories/GetById";

    public const string ProductGetAllWithCategoryName = $"{BaseUrl}Products/GetAllWithCategoryName";
    public const string ProductAdd = $"{BaseUrl}Products/Add";
    public const string ProductUpdate = $"{BaseUrl}Products/Update";
    public const string ProductDelete = $"{BaseUrl}Products/Delete";
    public const string ProductGetById = $"{BaseUrl}Products/GetById";

    public const string AboutGetAll = $"{BaseUrl}Abouts/GetAll";
    public const string AboutAdd = $"{BaseUrl}Abouts/Add";
    public const string AboutUpdate = $"{BaseUrl}Abouts/Update";
    public const string AboutDelete = $"{BaseUrl}Abouts/Delete";
    public const string AboutGetById = $"{BaseUrl}Abouts/GetById";
    
    public const string BookingGetAll = $"{BaseUrl}Bookings/GetAll";
    public const string BookingAdd = $"{BaseUrl}Bookings/Add";
    public const string BookingUpdate = $"{BaseUrl}Bookings/Update";
    public const string BookingDelete = $"{BaseUrl}Bookings/Delete";
    public const string BookingGetById = $"{BaseUrl}Bookings/GetById";
    
    public const string ContactGetAll = $"{BaseUrl}Contacts/GetAll";
    public const string ContactAdd = $"{BaseUrl}Contacts/Add";
    public const string ContactUpdate = $"{BaseUrl}Contacts/Update";
    public const string ContactDelete = $"{BaseUrl}Contacts/Delete";
    public const string ContactGetById = $"{BaseUrl}Contacts/GetById";
    
    public const string DiscountGetAll = $"{BaseUrl}Discounts/GetAll";
    public const string DiscountAdd = $"{BaseUrl}Discounts/Add";
    public const string DiscountUpdate = $"{BaseUrl}Discounts/Update";
    public const string DiscountDelete = $"{BaseUrl}Discounts/Delete";
    public const string DiscountGetById = $"{BaseUrl}Discounts/GetById";
    
    
    public const string FeatureGetAll = $"{BaseUrl}Features/GetAll";
    public const string FeatureAdd = $"{BaseUrl}Features/Add";
    public const string FeatureUpdate = $"{BaseUrl}Features/Update";
    public const string FeatureDelete = $"{BaseUrl}Features/Delete";
    public const string FeatureGetById = $"{BaseUrl}Features/GetById";
    
    public const string SocialMediaGetAll = $"{BaseUrl}SocialMedias/GetAll";
    public const string SocialMediaAdd = $"{BaseUrl}SocialMedias/Add";
    public const string SocialMediaUpdate = $"{BaseUrl}SocialMedias/Update";
    public const string SocialMediaDelete = $"{BaseUrl}SocialMedias/Delete";
    public const string SocialMediaGetById = $"{BaseUrl}SocialMedias/GetById";
}