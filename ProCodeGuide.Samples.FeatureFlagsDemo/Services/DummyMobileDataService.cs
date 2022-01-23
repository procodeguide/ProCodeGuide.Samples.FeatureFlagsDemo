using ProCodeGuide.Samples.FeatureFlagsDemo.Interfaces;
using ProCodeGuide.Samples.FeatureFlagsDemo.Models;

namespace ProCodeGuide.Samples.FeatureFlagsDemo.Services
{
    public class DummyMobileDataService : IMobileDataService
    {
        public List<Mobile> GetAllMobileReviews()
        {
            List<Mobile> mobileReviews = new();

            mobileReviews.Add(PrepareMobileObject("1", "iPhone 12", "6.1 inch Display Screen", "2 Star", "Old Model - Current Model is 13"));
            mobileReviews.Add(PrepareMobileObject("2", "iPhone 13 Mini", "5.4 inch Display Screen", "3 Star", "Small Display - Bigger Display Available"));
            mobileReviews.Add(PrepareMobileObject("3", "iPhone 13", "6.1 inch Display Screen", "3 Star", "Decent Diaplay Size but other models with better camera options available"));
            mobileReviews.Add(PrepareMobileObject("4", "iPhone 13 Pro", "6.1 inch Display Screen", "4 Star", "Good Display Size and best camera but other models with bigger display available"));
            mobileReviews.Add(PrepareMobileObject("5", "iPhone 13 Pro Max", "6.7 inch Display Screen", "5 Star", "Good display size and best camera"));
            return mobileReviews;
        }

        private Mobile PrepareMobileObject(string Id, string Name, string Specification, string Rating, string Remarks)
        {
            return (new Mobile
            {
                Id = Id,
                Name = Name,
                Specfication = Specification,
                ReviewDetails = new MobileReview
                {
                    Rating = Rating,
                    Remarks = Remarks
                }
            });
        }
    }
}
