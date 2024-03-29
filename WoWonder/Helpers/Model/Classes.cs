﻿using System.Collections.Generic;
using Android.Graphics;
using Newtonsoft.Json;
using WoWonderClient.Classes.Games;
using WoWonderClient.Classes.Global;
using WoWonderClient.Classes.Jobs;
using WoWonderClient.Classes.Product;

namespace WoWonder.Helpers.Model
{ 
    public class Classes
    {  
        public class PostType
        {
            public long Id { get; set; }
            public string TypeText { get; set; }
            public int Image { get; set; }
            public string ImageColor { get; set; }
        }
        
        public class Categories
        {
            public string CategoriesId { get; set; }
            public string CategoriesName { get; set; }
            public string CategoriesColor { get; set; }
            public string CategoriesIcon  { get; set; }
            public List<SubCategories> SubList { get; set; }
        }

        public class Family
        {
            public string FamilyId { get; set; }
            public string FamilyName { get; set; }
        }

        public class Gender
        {
            public string GenderId { get; set; }
            public string GenderName { get; set; }
            public string GenderColor { get; set; }
            public bool GenderSelect { get; set; }
        }
        
        public class MyInformation
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public Color Color { get; set; }
            public Color BgColor { get; set; }
            public int Icon { get; set; }
            public string Type { get; set; }
        }
           
        public class ShortCuts
        { 
            public string Type { get; set; }
            public string SocialId { get; set; }
            public string Name { get; set; }
            public PageDataObject PageClass { get; set; }  
            public GroupDataObject GroupClass { get; set; }  
        }
         
        public class ExchangeCurrencyObject
        {
            [JsonProperty("disclaimer", NullValueHandling = NullValueHandling.Ignore)]
            public string Disclaimer { get; set; }

            [JsonProperty("license", NullValueHandling = NullValueHandling.Ignore)]
            public string License { get; set; }

            [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
            public long? Timestamp { get; set; }

            [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
            public string Base { get; set; }

            [JsonProperty("rates", NullValueHandling = NullValueHandling.Ignore)]
            public Dictionary<string, double> Rates { get; set; }
        }
         
        public class ExErrorObject
        {
            [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Error { get; set; }

            [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public long? Status { get; set; }

            [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
            public string Message { get; set; }

            [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }
        }


        public class TrendingClass
        {
            public long Id { get; set; }
            public ItemType Type { get; set; }
            public string Title { get; set; } 
            public ItemType SectionType { get; set; } 

            public List<UserDataObject> UserList { get; set; }
            public List<PageDataObject> PageList { get; set; }
            public ActivityDataObject LastActivities  { get; set; }
            public List<ShortCuts> ShortcutsList { get; set; }
            public ArticleDataObject LastBlogs  { get; set; }
            public TrendingHashtag HashTags  { get; set; } 
            public GetWeatherObject Weather  { get; set; } 
            public ExchangeCurrencyObject ExchangeCurrency { get; set; } 
        }
        
        public class ProductClass
        {
            public long Id { get; set; }
            public ItemType Type { get; set; }
            public string Title { get; set; } 
            
            public List<ProductDataObject> ProductList { get; set; } 
            public ProductDataObject Product  { get; set; } 
        }
        
        public class JobClass
        {
            public long Id { get; set; }
            public ItemType Type { get; set; }
            public string Title { get; set; } 
            
            public List<JobInfoObject> JobList { get; set; } 
            public JobInfoObject Job { get; set; } 
        }

        public class GameClass
        {
            public long Id { get; set; }
            public ItemType Type { get; set; }
            public string Title { get; set; }

            public List<GamesDataObject> GameList { get; set; }
            public GamesDataObject Game { get; set; }
        }
        
        public enum ItemType
        {
            ProUser = 20201,
            ProPage = 20202,
            HashTag = 20203,
            FriendRequest = 20204,
            LastActivities = 20205,
            Weather = 20206,
            Shortcuts = 20207,
            AdMob = 20208,
            Section = 20209,
            EmptyPage = 202010,
            Divider = 202011,
            LastBlogs  = 202012,
            ExchangeCurrency = 202013,
            CoronaVirus = 202014,
             
            NearbyShops = 202015,
            Product = 202016,
            MyProduct = 202017,
             
            NearbyJob = 202018,
            Job = 202019,
            JobRecent = 202020,

            FriendsBirthday = 202021,
             
            RecentGame = 202022,
            PopularGame = 202023,
            RecommendGame = 202024,
            MyGame = 202025,
            SearchGame = 202026,
        } 

    }
}