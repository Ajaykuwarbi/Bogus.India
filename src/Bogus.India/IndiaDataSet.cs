using System;
using Bogus.India.Data;

namespace Bogus.India
{
    /// <summary>
    /// Generates fake data specific to India — names, addresses, identity documents,
    /// financial information, and phone numbers.
    /// </summary>
    public class IndiaDataSet : DataSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndiaDataSet"/> class.
        /// </summary>
        public IndiaDataSet() : base("en") { }

        // ──────────────────────────────────────────────
        //  NAMES
        // ──────────────────────────────────────────────

        /// <summary>
        /// Generates a random Indian male first name.
        /// </summary>
        public string MaleFirstName() => Random.ArrayElement(IndianNames.MaleFirstNames);

        /// <summary>
        /// Generates a random Indian female first name.
        /// </summary>
        public string FemaleFirstName() => Random.ArrayElement(IndianNames.FemaleFirstNames);

        /// <summary>
        /// Generates a random Indian first name (male or female).
        /// </summary>
        public string FirstName() => Random.Bool()
            ? MaleFirstName()
            : FemaleFirstName();

        /// <summary>
        /// Generates a random Indian last name (surname).
        /// </summary>
        public string LastName() => Random.ArrayElement(IndianNames.LastNames);

        /// <summary>
        /// Generates a random full Indian name (first + last).
        /// </summary>
        public string FullName() => $"{FirstName()} {LastName()}";

        /// <summary>
        /// Generates a random full Indian male name (first + last).
        /// </summary>
        public string MaleFullName() => $"{MaleFirstName()} {LastName()}";

        /// <summary>
        /// Generates a random full Indian female name (first + last).
        /// </summary>
        public string FemaleFullName() => $"{FemaleFirstName()} {LastName()}";

        /// <summary>
        /// Generates a name with an Indian prefix/title (e.g., "Shri Rajesh Sharma").
        /// </summary>
        public string NameWithPrefix() => $"{Random.ArrayElement(IndianNames.Prefixes)} {FullName()}";

        // ──────────────────────────────────────────────
        //  IDENTITY DOCUMENTS
        // ──────────────────────────────────────────────

        /// <summary>
        /// Generates a random 12-digit Aadhaar number in the format XXXX XXXX XXXX.
        /// The first digit is always 2-9 (as per UIDAI specification).
        /// </summary>
        public string Aadhaar()
        {
            var firstDigit = Random.Number(2, 9);
            var remaining = Random.Replace("###########"); // 11 more digits
            var raw = $"{firstDigit}{remaining}";
            return $"{raw.Substring(0, 4)} {raw.Substring(4, 4)} {raw.Substring(8, 4)}";
        }

        /// <summary>
        /// Generates a random 12-digit Aadhaar number without spaces.
        /// </summary>
        public string AadhaarRaw()
        {
            var firstDigit = Random.Number(2, 9);
            var remaining = Random.Replace("###########");
            return $"{firstDigit}{remaining}";
        }

        /// <summary>
        /// Generates a random PAN (Permanent Account Number) in the format ABCDE1234F.
        /// The 4th character represents the entity type (P for Person by default).
        /// </summary>
        /// <param name="entityType">
        /// The PAN entity type character. Defaults to 'P' (Person).
        /// Valid: A (AOP), B (BOI), C (Company), F (Firm), G (Government), H (HUF), J (AJP), L (Local Authority), P (Person), T (Trust).
        /// </param>
        public string Pan(char entityType = 'P')
        {
            var first3 = Random.Replace("???").ToUpperInvariant();
            var last = Random.Replace("?").ToUpperInvariant();
            var digits = Random.Replace("####");
            return $"{first3}{entityType}{last}{digits}{Random.Replace("?").ToUpperInvariant()}";
        }

        /// <summary>
        /// Generates a random PAN with a random entity type.
        /// </summary>
        public string PanRandom()
        {
            var entityType = Random.ArrayElement(IndianFinancials.PanEntityTypes);
            return Pan(entityType);
        }

        /// <summary>
        /// Generates a random Voter ID (EPIC) number in the format ABC1234567.
        /// </summary>
        public string VoterId()
        {
            var letters = Random.Replace("???").ToUpperInvariant();
            var digits = Random.Replace("#######");
            return $"{letters}{digits}";
        }

        /// <summary>
        /// Generates a random Indian Driving License number.
        /// Format: SS-RRYYYYNNNNNNN (State code, RTO, Year, Serial).
        /// </summary>
        public string DrivingLicense()
        {
            var stateCode = Random.ArrayElement(IndianFinancials.VehicleStateCodes);
            var rto = Random.Number(1, 99).ToString("D2");
            var year = Random.Number(1980, 2026);
            var serial = Random.Number(1, 9999999).ToString("D7");
            return $"{stateCode}-{rto}{year}{serial}";
        }

        /// <summary>
        /// Generates a random Indian Passport number in the format A1234567.
        /// </summary>
        public string Passport()
        {
            var letter = Random.Replace("?").ToUpperInvariant();
            var digits = Random.Replace("#######");
            return $"{letter}{digits}";
        }

        // ──────────────────────────────────────────────
        //  PHONE NUMBERS
        // ──────────────────────────────────────────────

        /// <summary>
        /// Generates a random Indian mobile number in the format +91 XXXXX XXXXX.
        /// First digit after country code is always 6, 7, 8, or 9.
        /// </summary>
        public string MobileNumber()
        {
            var first = Random.ArrayElement(IndianFinancials.MobileFirstDigits);
            var rest = Random.Replace("#########"); // 9 more digits
            var raw = $"{first}{rest}";
            return $"+91 {raw.Substring(0, 5)} {raw.Substring(5, 5)}";
        }

        /// <summary>
        /// Generates a raw 10-digit mobile number without country code or formatting.
        /// </summary>
        public string MobileNumberRaw()
        {
            var first = Random.ArrayElement(IndianFinancials.MobileFirstDigits);
            var rest = Random.Replace("#########");
            return $"{first}{rest}";
        }

        /// <summary>
        /// Generates a random Indian landline number with STD code.
        /// </summary>
        public string LandlineNumber()
        {
            var entry = Random.ArrayElement(IndianFinancials.StdCodes);
            var localDigits = entry.StdCode.Length == 3
                ? Random.Replace("########") // 8 digits for metro
                : Random.Replace("#######");  // 7 digits for non-metro
            return $"{entry.StdCode}-{localDigits}";
        }

        // ──────────────────────────────────────────────
        //  ADDRESSES
        // ──────────────────────────────────────────────

        /// <summary>
        /// Generates a random Indian state name.
        /// </summary>
        public string State() => Random.ArrayElement(IndianPlaces.States);

        /// <summary>
        /// Generates a random Indian union territory name.
        /// </summary>
        public string UnionTerritory() => Random.ArrayElement(IndianPlaces.UnionTerritories);

        /// <summary>
        /// Generates a random Indian state or union territory.
        /// </summary>
        public string StateOrUt() => Random.Bool(0.8f)
            ? State()
            : UnionTerritory();

        /// <summary>
        /// Generates a random major Indian city name.
        /// </summary>
        public string City() => Random.ArrayElement(IndianPlaces.MajorCities);

        /// <summary>
        /// Returns the capital of a random Indian state.
        /// </summary>
        public string StateCapital()
        {
            var entry = Random.ArrayElement(IndianPlaces.StateCapitals);
            return entry.Capital;
        }

        /// <summary>
        /// Generates a random 6-digit Indian PIN code.
        /// First digit corresponds to the postal zone (1-8).
        /// </summary>
        public string PinCode()
        {
            var firstDigit = Random.ArrayElement(IndianPlaces.PinCodeFirstDigits);
            var rest = Random.Replace("#####");
            return $"{firstDigit}{rest}";
        }

        /// <summary>
        /// Generates a PIN code for a specific state (using correct postal zone).
        /// Falls back to a random PIN code if the state is not found.
        /// </summary>
        public string PinCodeForState(string stateName)
        {
            foreach (var zone in IndianPlaces.StatePinZones)
            {
                if (string.Equals(zone.State, stateName, StringComparison.OrdinalIgnoreCase))
                {
                    var rest = Random.Replace("#####");
                    return $"{zone.FirstDigit}{rest}";
                }
            }
            return PinCode();
        }

        /// <summary>
        /// Generates a random Indian locality/area name.
        /// </summary>
        public string Locality() => Random.ArrayElement(IndianPlaces.Localities);

        /// <summary>
        /// Generates a random Indian road/street name.
        /// </summary>
        public string RoadName() => Random.ArrayElement(IndianPlaces.RoadNames);

        /// <summary>
        /// Generates a full Indian street address line.
        /// Example: "42, Nehru Nagar, MG Road"
        /// </summary>
        public string StreetAddress()
        {
            var houseNo = Random.Number(1, 999);
            return $"{houseNo}, {Locality()}, {RoadName()}";
        }

        /// <summary>
        /// Generates a full Indian address with city, state, and PIN code.
        /// </summary>
        public string FullAddress()
        {
            var state = State();
            return $"{StreetAddress()}, {City()}, {state} - {PinCodeForState(state)}";
        }

        // ──────────────────────────────────────────────
        //  FINANCIAL
        // ──────────────────────────────────────────────

        /// <summary>
        /// Generates a random Indian bank name.
        /// </summary>
        public string BankName() => Random.ArrayElement(IndianFinancials.BankNames);

        /// <summary>
        /// Generates a random IFSC (Indian Financial System Code) in the format ABCD0NNNNNN.
        /// The 5th character is always '0' as per RBI specification.
        /// </summary>
        public string IfscCode()
        {
            var prefix = Random.ArrayElement(IndianFinancials.IfscPrefixes);
            var branchCode = Random.Replace("######");
            return $"{prefix.IfscPrefix}0{branchCode}";
        }

        /// <summary>
        /// Generates an IFSC code for a specific bank.
        /// Falls back to a random IFSC if the bank is not found.
        /// </summary>
        public string IfscCodeForBank(string bankName)
        {
            foreach (var prefix in IndianFinancials.IfscPrefixes)
            {
                if (string.Equals(prefix.BankName, bankName, StringComparison.OrdinalIgnoreCase))
                {
                    var branchCode = Random.Replace("######");
                    return $"{prefix.IfscPrefix}0{branchCode}";
                }
            }
            return IfscCode();
        }

        /// <summary>
        /// Generates a random UPI ID based on an Indian name.
        /// Example: "rajesh.sharma@upi"
        /// </summary>
        public string UpiId()
        {
            var first = FirstName().ToLowerInvariant();
            var last = LastName().ToLowerInvariant();
            var handle = Random.ArrayElement(IndianFinancials.UpiHandles);
            var separator = Random.ArrayElement(new[] { ".", "_", "" });

            return Random.Number(1, 3) switch
            {
                1 => $"{first}{separator}{last}{handle}",
                2 => $"{first}{Random.Number(1, 999)}{handle}",
                _ => $"{first}{separator}{last}{Random.Number(1, 99)}{handle}"
            };
        }

        /// <summary>
        /// Generates a random 10-16 digit Indian bank account number.
        /// </summary>
        public string BankAccountNumber()
        {
            var length = Random.Number(10, 16);
            var digits = "";
            for (int i = 0; i < length; i++)
            {
                digits += Random.Number(0, 9).ToString();
            }
            return digits;
        }

        /// <summary>
        /// Generates a random GSTIN (Goods and Services Tax Identification Number).
        /// Format: 22AAAAA1234A1Z5 (State code + PAN + Entity number + Z + Checksum).
        /// </summary>
        public string Gstin()
        {
            var stateCode = Random.Number(1, 37).ToString("D2");
            var pan = Pan();
            var entityNum = Random.Number(1, 9).ToString();
            return $"{stateCode}{pan}{entityNum}Z{Random.Number(0, 9)}";
        }

        // ──────────────────────────────────────────────
        //  VEHICLE
        // ──────────────────────────────────────────────

        /// <summary>
        /// Generates a random Indian vehicle registration number.
        /// Format: SS NN XX NNNN (State-RTO-Series-Number).
        /// Example: "MH 02 AB 1234"
        /// </summary>
        public string VehicleRegistration()
        {
            var state = Random.ArrayElement(IndianFinancials.VehicleStateCodes);
            var rto = Random.Number(1, 99).ToString("D2");
            var series = Random.Replace("??").ToUpperInvariant();
            var number = Random.Number(1, 9999).ToString("D4");
            return $"{state} {rto} {series} {number}";
        }
    }
}
