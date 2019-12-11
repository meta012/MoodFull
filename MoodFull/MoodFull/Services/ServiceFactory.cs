using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Services
{
    static class ServiceFactory
    {
       //Service factory. Returns service according to query
        public static EvaluationService GetEvaluationService()
        {
            return new EvaluationService();
        }
        public static ListService GetListService()
        {
            return new ListService();
        }
        public static UserService GetUserService()
        {
            return new UserService();
        }
        public static RestaurantService GetRestaurantService()
        {
            return new RestaurantService();
        }
    }
}
