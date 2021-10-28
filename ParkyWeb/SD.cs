using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyWeb
{
    public static class SD
    {
        public static string APIBaseUrl = "https://localhost:44338/";
        public static string NationalParkAPIPath = APIBaseUrl+ "api/v1/nationalpark/";
        public static string TrailAPIPath = APIBaseUrl+ "api/v1/trail/";
        public static string AccountAPIPath = APIBaseUrl + "api/v1/users/";
    }
}
