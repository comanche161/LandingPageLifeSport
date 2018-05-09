﻿using System.Web.Mvc;

namespace LandingPageLifeSport.Areas.Public
{
    public class PublicAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Public";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "Public_default",
            //    "Public/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }

            context.MapRoute("", "", defaults: new { area = "Public", controller = "Base", action = "Index" });
        }
    }
}