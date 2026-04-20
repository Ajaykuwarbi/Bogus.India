using Bogus.India;
using Xunit;

namespace Bogus.India.Tests
{
    public class IndiaDataSetTests
    {
        private readonly Faker _faker;

        public IndiaDataSetTests()
        {
            _faker = new Faker();
        }

        // ──────────────────────────────────────────────
        //  NAMES
        // ──────────────────────────────────────────────

        [Fact]
        public void MaleFirstName_ReturnsNonEmpty()
        {
            var name = _faker.India().MaleFirstName();
            Assert.False(string.IsNullOrWhiteSpace(name));
        }

        [Fact]
        public void FemaleFirstName_ReturnsNonEmpty()
        {
            var name = _faker.India().FemaleFirstName();
            Assert.False(string.IsNullOrWhiteSpace(name));
        }

        [Fact]
        public void LastName_ReturnsNonEmpty()
        {
            var name = _faker.India().LastName();
            Assert.False(string.IsNullOrWhiteSpace(name));
        }

        [Fact]
        public void FullName_ContainsSpace()
        {
            var name = _faker.India().FullName();
            Assert.Contains(" ", name);
        }

        [Fact]
        public void NameWithPrefix_ContainsPrefix()
        {
            var name = _faker.India().NameWithPrefix();
            Assert.True(name.Contains(".") || name.Contains("Shri") || name.Contains("Smt"));
        }

        // ──────────────────────────────────────────────
        //  IDENTITY DOCUMENTS
        // ──────────────────────────────────────────────

        [Fact]
        public void Aadhaar_ReturnsCorrectFormat()
        {
            var aadhaar = _faker.India().Aadhaar();
            // Format: XXXX XXXX XXXX (14 chars with spaces)
            Assert.Equal(14, aadhaar.Length);
            Assert.Equal(' ', aadhaar[4]);
            Assert.Equal(' ', aadhaar[9]);
        }

        [Fact]
        public void Aadhaar_FirstDigitIsNot0Or1()
        {
            for (int i = 0; i < 100; i++)
            {
                var aadhaar = new Faker().India().Aadhaar();
                var firstDigit = aadhaar[0] - '0';
                Assert.InRange(firstDigit, 2, 9);
            }
        }

        [Fact]
        public void AadhaarRaw_Returns12Digits()
        {
            var aadhaar = _faker.India().AadhaarRaw();
            Assert.Equal(12, aadhaar.Length);
            Assert.True(long.TryParse(aadhaar, out _));
        }

        [Fact]
        public void Pan_ReturnsCorrectFormat()
        {
            var pan = _faker.India().Pan();
            // Format: ABCDE1234F (10 chars)
            Assert.Equal(10, pan.Length);
            // First 3 chars are uppercase letters
            Assert.True(char.IsUpper(pan[0]));
            Assert.True(char.IsUpper(pan[1]));
            Assert.True(char.IsUpper(pan[2]));
            // 4th char is entity type (P by default)
            Assert.Equal('P', pan[3]);
            // 5th char is uppercase letter
            Assert.True(char.IsUpper(pan[4]));
            // 6-9 are digits
            Assert.True(char.IsDigit(pan[5]));
            Assert.True(char.IsDigit(pan[6]));
            Assert.True(char.IsDigit(pan[7]));
            Assert.True(char.IsDigit(pan[8]));
            // 10th is uppercase letter
            Assert.True(char.IsUpper(pan[9]));
        }

        [Fact]
        public void Pan_WithEntityType_UsesSpecifiedType()
        {
            var pan = _faker.India().Pan('C');
            Assert.Equal('C', pan[3]);
        }

        [Fact]
        public void VoterId_ReturnsCorrectFormat()
        {
            var voterId = _faker.India().VoterId();
            Assert.Equal(10, voterId.Length);
            Assert.True(char.IsUpper(voterId[0]));
            Assert.True(char.IsUpper(voterId[1]));
            Assert.True(char.IsUpper(voterId[2]));
        }

        [Fact]
        public void Passport_ReturnsCorrectFormat()
        {
            var passport = _faker.India().Passport();
            Assert.Equal(8, passport.Length);
            Assert.True(char.IsUpper(passport[0]));
            for (int i = 1; i < 8; i++)
                Assert.True(char.IsDigit(passport[i]));
        }

        // ──────────────────────────────────────────────
        //  PHONE NUMBERS
        // ──────────────────────────────────────────────

        [Fact]
        public void MobileNumber_StartsWithPlus91()
        {
            var phone = _faker.India().MobileNumber();
            Assert.StartsWith("+91 ", phone);
        }

        [Fact]
        public void MobileNumber_FirstDigitIs6to9()
        {
            for (int i = 0; i < 100; i++)
            {
                var phone = new Faker().India().MobileNumber();
                var firstMobileDigit = phone[4] - '0'; // after "+91 "
                Assert.InRange(firstMobileDigit, 6, 9);
            }
        }

        [Fact]
        public void MobileNumberRaw_Returns10Digits()
        {
            var phone = _faker.India().MobileNumberRaw();
            Assert.Equal(10, phone.Length);
            Assert.True(long.TryParse(phone, out _));
        }

        [Fact]
        public void LandlineNumber_ContainsStdCode()
        {
            var phone = _faker.India().LandlineNumber();
            Assert.Contains("-", phone);
            Assert.StartsWith("0", phone);
        }

        // ──────────────────────────────────────────────
        //  ADDRESSES
        // ──────────────────────────────────────────────

        [Fact]
        public void State_ReturnsValidState()
        {
            var state = _faker.India().State();
            Assert.False(string.IsNullOrWhiteSpace(state));
        }

        [Fact]
        public void City_ReturnsNonEmpty()
        {
            var city = _faker.India().City();
            Assert.False(string.IsNullOrWhiteSpace(city));
        }

        [Fact]
        public void PinCode_Returns6Digits()
        {
            var pin = _faker.India().PinCode();
            Assert.Equal(6, pin.Length);
            Assert.True(int.TryParse(pin, out var val));
            Assert.InRange(val, 100000, 899999);
        }

        [Fact]
        public void PinCodeForState_ReturnsCorrectZone()
        {
            var pin = _faker.India().PinCodeForState("Maharashtra");
            Assert.StartsWith("4", pin); // Maharashtra is zone 4
        }

        [Fact]
        public void FullAddress_ContainsCommas()
        {
            var address = _faker.India().FullAddress();
            Assert.True(address.Split(',').Length >= 3);
            Assert.Contains("-", address); // PIN code separator
        }

        // ──────────────────────────────────────────────
        //  FINANCIAL
        // ──────────────────────────────────────────────

        [Fact]
        public void BankName_ReturnsNonEmpty()
        {
            var bank = _faker.India().BankName();
            Assert.False(string.IsNullOrWhiteSpace(bank));
        }

        [Fact]
        public void IfscCode_ReturnsCorrectFormat()
        {
            var ifsc = _faker.India().IfscCode();
            Assert.Equal(11, ifsc.Length);
            Assert.Equal('0', ifsc[4]); // 5th char is always 0
            // First 4 chars are alphabetic
            for (int i = 0; i < 4; i++)
                Assert.True(char.IsLetter(ifsc[i]));
        }

        [Fact]
        public void IfscCodeForBank_ReturnsCorrectPrefix()
        {
            var ifsc = _faker.India().IfscCodeForBank("HDFC Bank");
            Assert.StartsWith("HDFC", ifsc);
        }

        [Fact]
        public void UpiId_ContainsAtSymbol()
        {
            var upi = _faker.India().UpiId();
            Assert.Contains("@", upi);
        }

        [Fact]
        public void BankAccountNumber_ReturnsValidLength()
        {
            var account = _faker.India().BankAccountNumber();
            Assert.InRange(account.Length, 10, 16);
            Assert.True(long.TryParse(account, out _));
        }

        [Fact]
        public void Gstin_ReturnsCorrectLength()
        {
            var gstin = _faker.India().Gstin();
            Assert.Equal(15, gstin.Length);
            // First 2 chars are digits (state code)
            Assert.True(char.IsDigit(gstin[0]));
            Assert.True(char.IsDigit(gstin[1]));
        }

        // ──────────────────────────────────────────────
        //  VEHICLE
        // ──────────────────────────────────────────────

        [Fact]
        public void VehicleRegistration_ReturnsCorrectFormat()
        {
            var reg = _faker.India().VehicleRegistration();
            // Format: "MH 02 AB 1234"
            var parts = reg.Split(' ');
            Assert.Equal(4, parts.Length);
            Assert.Equal(2, parts[0].Length); // State code
            Assert.Equal(2, parts[1].Length); // RTO code
            Assert.Equal(2, parts[2].Length); // Series
            Assert.Equal(4, parts[3].Length); // Number
        }

        // ──────────────────────────────────────────────
        //  INTEGRATION: Faker<T> usage
        // ──────────────────────────────────────────────

        [Fact]
        public void FakerT_Integration_GeneratesValidPerson()
        {
            var personFaker = new Faker<TestPerson>()
                .RuleFor(p => p.Name, f => f.India().FullName())
                .RuleFor(p => p.Aadhaar, f => f.India().Aadhaar())
                .RuleFor(p => p.Pan, f => f.India().Pan())
                .RuleFor(p => p.Phone, f => f.India().MobileNumber())
                .RuleFor(p => p.Address, f => f.India().FullAddress())
                .RuleFor(p => p.UpiId, f => f.India().UpiId())
                .RuleFor(p => p.BankAccount, f => f.India().BankAccountNumber());

            var person = personFaker.Generate();

            Assert.False(string.IsNullOrWhiteSpace(person.Name));
            Assert.Equal(14, person.Aadhaar.Length);
            Assert.Equal(10, person.Pan.Length);
            Assert.StartsWith("+91", person.Phone);
            Assert.Contains("@", person.UpiId);
        }

        [Fact]
        public void FakerT_Integration_GeneratesMultiple()
        {
            var faker = new Faker<TestPerson>()
                .RuleFor(p => p.Name, f => f.India().FullName())
                .RuleFor(p => p.Phone, f => f.India().MobileNumber());

            var people = faker.Generate(50);

            Assert.Equal(50, people.Count);
            Assert.All(people, p =>
            {
                Assert.False(string.IsNullOrWhiteSpace(p.Name));
                Assert.StartsWith("+91", p.Phone);
            });
        }

        private class TestPerson
        {
            public string Name { get; set; } = "";
            public string Aadhaar { get; set; } = "";
            public string Pan { get; set; } = "";
            public string Phone { get; set; } = "";
            public string Address { get; set; } = "";
            public string UpiId { get; set; } = "";
            public string BankAccount { get; set; } = "";
        }
    }
}
