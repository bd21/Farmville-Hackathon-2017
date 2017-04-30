using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Farmville.Models
{
    enum Crop { Corn, Oats, Barley, Rice, Tobacco, Wheat, Soybean};
    enum Cattle { Beef, Chicken, Pork, Lamb, Milk }
    public class FarmerSideModel
    {
        [Key]
        int Id { get; set; }
        Crop cropType { get; set; }
        Cattle cattleType { get; set; }
        int cropQuantity { get; set; }
        int acres { get; set; }
        String measurementType { get; set; }
        int zipcode { get; set; }
        //API TO GET CURRENT PRICES?
    }

    public class FarmerInfoDb : DbContext
    {
        public DbSet<FarmerInfoDb> Movies { get; set; }
    }
}