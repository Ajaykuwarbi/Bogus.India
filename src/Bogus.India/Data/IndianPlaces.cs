namespace Bogus.India.Data
{
    /// <summary>
    /// Contains comprehensive datasets of Indian geographical data — states, union territories, cities, and PIN codes.
    /// </summary>
    internal static class IndianPlaces
    {
        /// <summary>
        /// All 28 states of India.
        /// </summary>
        internal static readonly string[] States = new[]
        {
            "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh",
            "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand",
            "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur",
            "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab",
            "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura",
            "Uttar Pradesh", "Uttarakhand", "West Bengal"
        };

        /// <summary>
        /// Union territories of India.
        /// </summary>
        internal static readonly string[] UnionTerritories = new[]
        {
            "Andaman and Nicobar Islands", "Chandigarh", "Dadra and Nagar Haveli and Daman and Diu",
            "Delhi", "Jammu and Kashmir", "Ladakh", "Lakshadweep", "Puducherry"
        };

        /// <summary>
        /// State capitals mapped by state name.
        /// </summary>
        internal static readonly (string State, string Capital)[] StateCapitals = new[]
        {
            ("Andhra Pradesh", "Amaravati"), ("Arunachal Pradesh", "Itanagar"), ("Assam", "Dispur"),
            ("Bihar", "Patna"), ("Chhattisgarh", "Raipur"), ("Goa", "Panaji"),
            ("Gujarat", "Gandhinagar"), ("Haryana", "Chandigarh"), ("Himachal Pradesh", "Shimla"),
            ("Jharkhand", "Ranchi"), ("Karnataka", "Bengaluru"), ("Kerala", "Thiruvananthapuram"),
            ("Madhya Pradesh", "Bhopal"), ("Maharashtra", "Mumbai"), ("Manipur", "Imphal"),
            ("Meghalaya", "Shillong"), ("Mizoram", "Aizawl"), ("Nagaland", "Kohima"),
            ("Odisha", "Bhubaneswar"), ("Punjab", "Chandigarh"), ("Rajasthan", "Jaipur"),
            ("Sikkim", "Gangtok"), ("Tamil Nadu", "Chennai"), ("Telangana", "Hyderabad"),
            ("Tripura", "Agartala"), ("Uttar Pradesh", "Lucknow"), ("Uttarakhand", "Dehradun"),
            ("West Bengal", "Kolkata")
        };

        /// <summary>
        /// Major Indian cities grouped by approximate population tiers.
        /// </summary>
        internal static readonly string[] MajorCities = new[]
        {
            // Tier 1 (Metro)
            "Mumbai", "Delhi", "Bengaluru", "Hyderabad", "Chennai", "Kolkata", "Ahmedabad", "Pune",
            // Tier 2
            "Jaipur", "Lucknow", "Kanpur", "Nagpur", "Indore", "Bhopal", "Patna", "Vadodara",
            "Ludhiana", "Agra", "Nashik", "Faridabad", "Meerut", "Rajkot", "Varanasi", "Srinagar",
            "Aurangabad", "Dhanbad", "Amritsar", "Allahabad", "Ranchi", "Coimbatore", "Gwalior",
            "Jodhpur", "Madurai", "Raipur", "Kota", "Chandigarh", "Guwahati", "Solapur", "Bareilly",
            // Tier 3
            "Thiruvananthapuram", "Mysuru", "Tiruchirappalli", "Jalandhar", "Bhubaneswar", "Salem",
            "Warangal", "Guntur", "Bhilai", "Noida", "Gurgaon", "Dehradun", "Jamshedpur",
            "Udaipur", "Ajmer", "Siliguri", "Mangaluru", "Hubli-Dharwad", "Belgaum", "Tiruppur"
        };

        /// <summary>
        /// PIN code first digits mapped to postal zones.
        /// Digit 1 = Delhi/Haryana/HP/JK/Punjab/Rajasthan
        /// Digit 2 = UP/Uttarakhand
        /// Digit 3 = Gujarat/Rajasthan/Daman and Diu
        /// Digit 4 = Maharashtra/Goa
        /// Digit 5 = AP/Telangana/Karnataka
        /// Digit 6 = Kerala/Tamil Nadu
        /// Digit 7 = WB/Odisha/NE
        /// Digit 8 = Bihar/Jharkhand
        /// </summary>
        internal static readonly int[] PinCodeFirstDigits = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        /// <summary>
        /// Mapping of states to their PIN code first digit (postal zone).
        /// </summary>
        internal static readonly (string State, int FirstDigit)[] StatePinZones = new[]
        {
            ("Delhi", 1), ("Haryana", 1), ("Himachal Pradesh", 1), ("Punjab", 1), ("Rajasthan", 3),
            ("Uttar Pradesh", 2), ("Uttarakhand", 2),
            ("Gujarat", 3),
            ("Maharashtra", 4), ("Goa", 4),
            ("Andhra Pradesh", 5), ("Telangana", 5), ("Karnataka", 5),
            ("Kerala", 6), ("Tamil Nadu", 6),
            ("West Bengal", 7), ("Odisha", 7), ("Assam", 7), ("Arunachal Pradesh", 7),
            ("Meghalaya", 7), ("Manipur", 7), ("Mizoram", 7), ("Nagaland", 7), ("Tripura", 7), ("Sikkim", 7),
            ("Bihar", 8), ("Jharkhand", 8)
        };

        /// <summary>
        /// Common Indian locality/area names used in street addresses.
        /// </summary>
        internal static readonly string[] Localities = new[]
        {
            "Nehru Nagar", "Gandhi Nagar", "Shivaji Nagar", "Tilak Nagar", "Rajiv Nagar",
            "Indira Colony", "Subhash Nagar", "MG Road", "Civil Lines", "Sadar Bazar",
            "Laxmi Nagar", "Patel Nagar", "Koregaon Park", "Banjara Hills", "Jubilee Hills",
            "Adyar", "Anna Nagar", "T. Nagar", "Whitefield", "Indiranagar",
            "Jayanagar", "Malviya Nagar", "Aundh", "Kothrud", "Viman Nagar",
            "Sector 17", "Sector 22", "Model Town", "Defence Colony", "Green Park",
            "Vasant Kunj", "Dwarka", "Rohini", "Andheri", "Powai",
            "Bandra", "Goregaon", "Borivali", "Thane", "Navi Mumbai"
        };

        /// <summary>
        /// Common Indian road name patterns.
        /// </summary>
        internal static readonly string[] RoadNames = new[]
        {
            "MG Road", "Station Road", "Temple Road", "Main Road", "Ring Road",
            "Bypass Road", "Link Road", "Old Mumbai Road", "GT Road", "NH Road",
            "Park Street", "Mall Road", "Church Street", "Lake Road", "Hill Road",
            "Cross Road", "Inner Ring Road", "Outer Ring Road", "Residency Road", "Brigade Road"
        };
    }
}
