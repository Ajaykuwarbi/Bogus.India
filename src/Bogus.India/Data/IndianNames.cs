namespace Bogus.India.Data
{
    /// <summary>
    /// Contains comprehensive datasets of Indian names, organized by gender and regional diversity.
    /// </summary>
    internal static class IndianNames
    {
        /// <summary>
        /// Common Indian male first names spanning multiple regions and languages.
        /// </summary>
        internal static readonly string[] MaleFirstNames = new[]
        {
            // North Indian
            "Aarav", "Aditya", "Ajay", "Akash", "Amit", "Anand", "Aniket", "Ankit", "Arjun", "Arun",
            "Ashish", "Bharat", "Chetan", "Deepak", "Dhruv", "Gaurav", "Harsh", "Hemant", "Ishaan", "Jai",
            "Karan", "Kunal", "Lokesh", "Manoj", "Mohit", "Nakul", "Nikhil", "Pankaj", "Pranav", "Rahul",
            "Raj", "Rajesh", "Ravi", "Rohit", "Sachin", "Sagar", "Sahil", "Sandeep", "Sanjay", "Shivam",
            "Sunil", "Suresh", "Tushar", "Varun", "Vijay", "Vikram", "Vinay", "Vishal", "Vivek", "Yash",
            // South Indian
            "Aravind", "Balaji", "Dinesh", "Ganesh", "Harish", "Karthik", "Krishna", "Kumar", "Lakshman", "Mohan",
            "Murali", "Naresh", "Naveen", "Prasad", "Prakash", "Rajendra", "Ramesh", "Sathish", "Senthil", "Shankar",
            "Sridhar", "Srinivas", "Subramaniam", "Venkatesh", "Vijayakumar",
            // East Indian
            "Abhijit", "Arnab", "Debashish", "Partha", "Prosenjit", "Rajdeep", "Saurabh", "Sourav", "Subhash", "Tapan",
            // West Indian
            "Chirag", "Darshan", "Jigar", "Jignesh", "Mitesh", "Nilesh", "Paresh", "Piyush", "Rohan", "Tejas"
        };

        /// <summary>
        /// Common Indian female first names spanning multiple regions and languages.
        /// </summary>
        internal static readonly string[] FemaleFirstNames = new[]
        {
            // North Indian
            "Aanya", "Aditi", "Anjali", "Anushka", "Bhavna", "Deepika", "Diya", "Ekta", "Gauri", "Ishita",
            "Jaya", "Kajal", "Kavita", "Kiara", "Komal", "Kritika", "Mansi", "Meera", "Neha", "Nisha",
            "Pallavi", "Pooja", "Priya", "Renu", "Ritika", "Sakshi", "Sapna", "Shreya", "Simran", "Sneha",
            "Sunita", "Swati", "Tanvi", "Tara", "Vandana", "Vidya", "Yukti",
            // South Indian
            "Aiswarya", "Ananya", "Bhavani", "Chitra", "Divya", "Gomathi", "Harini", "Janani", "Kavya", "Lakshmi",
            "Madhu", "Nandini", "Padma", "Preethi", "Revathi", "Saranya", "Shanti", "Sowmya", "Suchitra", "Vani",
            // East Indian
            "Debika", "Indrani", "Moumita", "Paromita", "Rina", "Sharmila", "Soma", "Sucheta", "Tanushree",
            // West Indian
            "Dhara", "Hetal", "Janki", "Minal", "Nandita", "Payal", "Riya", "Sonal", "Urvi", "Zara"
        };

        /// <summary>
        /// Common Indian last names (surnames) spanning multiple communities, castes, and regions.
        /// </summary>
        internal static readonly string[] LastNames = new[]
        {
            // Pan-Indian & North
            "Agarwal", "Arora", "Bansal", "Bhatia", "Chauhan", "Chopra", "Das", "Dubey", "Garg", "Goyal",
            "Gupta", "Jain", "Jha", "Joshi", "Kapoor", "Khanna", "Kumar", "Malhotra", "Mehra", "Mishra",
            "Mittal", "Pandey", "Patel", "Rajput", "Rana", "Rastogi", "Sachdeva", "Saxena", "Sethi", "Sharma",
            "Shukla", "Singh", "Sinha", "Srivastava", "Tandon", "Tiwari", "Trivedi", "Tyagi", "Upadhyay", "Verma",
            // South Indian
            "Acharya", "Bhat", "Hegde", "Iyer", "Kamath", "Menon", "Nair", "Naidu", "Pillai", "Rao",
            "Reddy", "Shetty", "Subramanian", "Warrier",
            // East Indian
            "Banerjee", "Basu", "Bose", "Chakraborty", "Chatterjee", "Ghosh", "Mukherjee", "Roy", "Sen", "Sarkar",
            // West Indian
            "Bhatt", "Desai", "Doshi", "Gandhi", "Kothari", "Mehta", "Modi", "Parekh", "Shah", "Thakkar"
        };

        /// <summary>
        /// Common Indian prefixes/titles.
        /// </summary>
        internal static readonly string[] Prefixes = new[]
        {
            "Mr.", "Mrs.", "Ms.", "Dr.", "Prof.", "Shri", "Smt."
        };
    }
}
