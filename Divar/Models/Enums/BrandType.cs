namespace Models.Enums
{
    public enum BrandType
    {
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.CarBrand))]
        CarBrand = 1,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.MobileBrand))]
        MobileBrand = 2,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.TimeOfExperience))]
        ComputerBrand = 3,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ObjectBrand))]
        ObjectBrand = 10,
    }
}
