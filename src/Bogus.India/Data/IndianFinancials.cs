namespace Bogus.India.Data
{
    /// <summary>
    /// Contains datasets for Indian financial and identity document formats.
    /// </summary>
    internal static class IndianFinancials
    {
        /// <summary>
        /// Major Indian bank names.
        /// </summary>
        internal static readonly string[] BankNames = new[]
        {
            // Public Sector
            "State Bank of India", "Punjab National Bank", "Bank of Baroda", "Canara Bank",
            "Union Bank of India", "Bank of India", "Indian Bank", "Central Bank of India",
            "Indian Overseas Bank", "UCO Bank", "Bank of Maharashtra", "Punjab and Sind Bank",
            // Private Sector
            "HDFC Bank", "ICICI Bank", "Axis Bank", "Kotak Mahindra Bank",
            "IndusInd Bank", "Yes Bank", "IDBI Bank", "Federal Bank",
            "Bandhan Bank", "IDFC First Bank", "RBL Bank", "South Indian Bank",
            // Small Finance Banks
            "AU Small Finance Bank", "Ujjivan Small Finance Bank", "Equitas Small Finance Bank",
            // Payments Banks
            "Paytm Payments Bank", "Airtel Payments Bank", "India Post Payments Bank"
        };

        /// <summary>
        /// IFSC code prefixes for major banks (first 4 characters).
        /// </summary>
        internal static readonly (string BankName, string IfscPrefix)[] IfscPrefixes = new[]
        {
            ("State Bank of India", "SBIN"),
            ("Punjab National Bank", "PUNB"),
            ("Bank of Baroda", "BARB"),
            ("Canara Bank", "CNRB"),
            ("Union Bank of India", "UBIN"),
            ("Bank of India", "BKID"),
            ("Indian Bank", "IDIB"),
            ("Central Bank of India", "CBIN"),
            ("HDFC Bank", "HDFC"),
            ("ICICI Bank", "ICIC"),
            ("Axis Bank", "UTIB"),
            ("Kotak Mahindra Bank", "KKBK"),
            ("IndusInd Bank", "INDB"),
            ("Yes Bank", "YESB"),
            ("IDBI Bank", "IBKL"),
            ("Federal Bank", "FDRL"),
            ("Bandhan Bank", "BDBL"),
            ("IDFC First Bank", "IDFB"),
            ("RBL Bank", "RATN"),
            ("South Indian Bank", "SIBL"),
            ("AU Small Finance Bank", "AUBL"),
            ("Indian Overseas Bank", "IOBA"),
            ("UCO Bank", "UCBA"),
            ("Bank of Maharashtra", "MAHB"),
            ("Punjab and Sind Bank", "PSIB")
        };

        /// <summary>
        /// PAN card fourth character representing entity type.
        /// C = Company, P = Person, H = HUF, F = Firm, A = AOP, T = Trust, etc.
        /// </summary>
        internal static readonly char[] PanEntityTypes = new[]
        {
            'A', 'B', 'C', 'F', 'G', 'H', 'J', 'L', 'P', 'T'
        };

        /// <summary>
        /// Common UPI handle/suffix providers.
        /// </summary>
        internal static readonly string[] UpiHandles = new[]
        {
            "@upi", "@paytm", "@ybl", "@oksbi", "@okaxis", "@okicici",
            "@okhdfcbank", "@axl", "@ibl", "@sbi", "@apl", "@boi",
            "@federal", "@kotak", "@indus", "@rbl", "@pnb", "@cnrb"
        };

        /// <summary>
        /// Common telecom operator prefixes for Indian mobile numbers.
        /// Format: +91 XXXXX XXXXX where first digit after 91 is 6, 7, 8, or 9.
        /// </summary>
        internal static readonly int[] MobileFirstDigits = new[] { 6, 7, 8, 9 };

        /// <summary>
        /// Indian STD code prefixes for major cities (landline).
        /// </summary>
        internal static readonly (string City, string StdCode)[] StdCodes = new[]
        {
            ("Mumbai", "022"), ("Delhi", "011"), ("Bengaluru", "080"), ("Hyderabad", "040"),
            ("Chennai", "044"), ("Kolkata", "033"), ("Ahmedabad", "079"), ("Pune", "020"),
            ("Jaipur", "0141"), ("Lucknow", "0522"), ("Chandigarh", "0172"), ("Kochi", "0484"),
            ("Thiruvananthapuram", "0471"), ("Bhopal", "0755"), ("Patna", "0612"), ("Guwahati", "0361")
        };

        /// <summary>
        /// Indian vehicle registration state codes (RTO codes).
        /// </summary>
        internal static readonly string[] VehicleStateCodes = new[]
        {
            "MH", "DL", "KA", "TN", "AP", "TS", "KL", "GJ", "RJ", "UP",
            "WB", "MP", "HR", "PB", "BR", "JH", "OD", "CG", "GA", "UK",
            "HP", "JK", "AS", "SK", "MN", "ML", "MZ", "NL", "TR", "AR"
        };
    }
}
