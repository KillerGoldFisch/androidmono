// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 1.1.4322.2032
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    
    /// <remarks/>
    public class statuses {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public statusesStatus[] status;
    }
    
    /// <remarks/>
    public class statusesStatus {
        
        /// <remarks/>
        public string created_at;
        
        /// <remarks/>
        public string id;
        
        /// <remarks/>
        public string text;
        
        /// <remarks/>
        public string source;
        
        /// <remarks/>
        public string truncated;
        
        /// <remarks/>
        public string in_reply_to_status_id;
        
        /// <remarks/>
        public string in_reply_to_user_id;
        
        /// <remarks/>
        public string favorited;
        
        /// <remarks/>
        public string in_reply_to_screen_name;
        
        /// <remarks/>
        public string geo;
        
        /// <remarks/>
        public string coordinates;
        
        /// <remarks/>
        public string place;
        
        /// <remarks/>
        public string contributors;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("user")]
        public statusesStatusUser[] user;
    }
    
    /// <remarks/>
    public class statusesStatusUser {
        
        /// <remarks/>
        public string id;
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        public string screen_name;
        
        /// <remarks/>
        public string location;
        
        /// <remarks/>
        public string description;
        
        /// <remarks/>
        public string profile_image_url;
        
        /// <remarks/>
        public string url;
        
        /// <remarks/>
        public string @protected;
        
        /// <remarks/>
        public string followers_count;
        
        /// <remarks/>
        public string profile_background_color;
        
        /// <remarks/>
        public string profile_text_color;
        
        /// <remarks/>
        public string profile_link_color;
        
        /// <remarks/>
        public string profile_sidebar_fill_color;
        
        /// <remarks/>
        public string profile_sidebar_border_color;
        
        /// <remarks/>
        public string friends_count;
        
        /// <remarks/>
        public string created_at;
        
        /// <remarks/>
        public string favourites_count;
        
        /// <remarks/>
        public string utc_offset;
        
        /// <remarks/>
        public string time_zone;
        
        /// <remarks/>
        public string profile_background_image_url;
        
        /// <remarks/>
        public string profile_background_tile;
        
        /// <remarks/>
        public string notifications;
        
        /// <remarks/>
        public string geo_enabled;
        
        /// <remarks/>
        public string verified;
        
        /// <remarks/>
        public string following;
        
        /// <remarks/>
        public string statuses_count;
        
        /// <remarks/>
        public string lang;
        
        /// <remarks/>
        public string contributors_enabled;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public class NewDataSet {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("statuses")]
        public statuses[] statuses;
    }
}
