# 🇮🇳 Bogus.India

[![NuGet](https://img.shields.io/nuget/v/BogusData.India.svg)](https://www.nuget.org/packages/BogusData.India)
[![NuGet Downloads](https://img.shields.io/nuget/dt/BogusData.India.svg)](https://www.nuget.org/packages/BogusData.India)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-Standard%202.0+-purple.svg)](https://dotnet.microsoft.com/)

**India-specific fake data generator extension for [Bogus](https://github.com/bchavez/Bogus).** Generate realistic Indian names, Aadhaar numbers, PAN cards, UPI IDs, IFSC codes, phone numbers, addresses, and more — all in a single NuGet package.

---

## 📦 Installation

```bash
dotnet add package BogusData.India
```

Or via the NuGet Package Manager:

```
Install-Package BogusData.India
```

## 🚀 Quick Start

```csharp
using Bogus;
using Bogus.India;

// Simple usage
var faker = new Faker();
Console.WriteLine(faker.India().FullName());        // "Arjun Sharma"
Console.WriteLine(faker.India().Aadhaar());         // "4832 7591 6204"
Console.WriteLine(faker.India().Pan());             // "BQKPS4271R"
Console.WriteLine(faker.India().MobileNumber());    // "+91 98765 43210"
Console.WriteLine(faker.India().UpiId());           // "arjun.sharma@upi"
Console.WriteLine(faker.India().IfscCode());        // "HDFC0012345"
Console.WriteLine(faker.India().FullAddress());     // "42, Nehru Nagar, MG Road, Pune, Maharashtra - 411001"

// Use with Faker<T> for typed object generation
var personFaker = new Faker<Student>()
    .RuleFor(s => s.Name, f => f.India().FullName())
    .RuleFor(s => s.Aadhaar, f => f.India().Aadhaar())
    .RuleFor(s => s.Pan, f => f.India().Pan())
    .RuleFor(s => s.Phone, f => f.India().MobileNumber())
    .RuleFor(s => s.Address, f => f.India().FullAddress())
    .RuleFor(s => s.Upi, f => f.India().UpiId())
    .RuleFor(s => s.Bank, f => f.India().BankName())
    .RuleFor(s => s.Ifsc, f => f.India().IfscCode());

var students = personFaker.Generate(100);
```

## 📋 Available Generators

### 👤 Names
| Method | Example Output |
|:---|:---|
| `MaleFirstName()` | `"Arjun"` |
| `FemaleFirstName()` | `"Priya"` |
| `FirstName()` | `"Karan"` (random gender) |
| `LastName()` | `"Sharma"` |
| `FullName()` | `"Arjun Sharma"` |
| `MaleFullName()` | `"Rohit Patel"` |
| `FemaleFullName()` | `"Ananya Reddy"` |
| `NameWithPrefix()` | `"Shri Rajesh Gupta"` |

### 🪪 Identity Documents
| Method | Example Output | Notes |
|:---|:---|:---|
| `Aadhaar()` | `"4832 7591 6204"` | 12-digit with spaces |
| `AadhaarRaw()` | `"483275916204"` | 12-digit without spaces |
| `Pan()` | `"BQKPS4271R"` | Default: Person type |
| `Pan('C')` | `"BQKCS4271R"` | Company type |
| `PanRandom()` | `"BQKTS4271R"` | Random entity type |
| `VoterId()` | `"ABC1234567"` | EPIC format |
| `DrivingLicense()` | `"MH-0220151234567"` | State-RTO-Year-Serial |
| `Passport()` | `"A1234567"` | Letter + 7 digits |

### 📱 Phone Numbers
| Method | Example Output |
|:---|:---|
| `MobileNumber()` | `"+91 98765 43210"` |
| `MobileNumberRaw()` | `"9876543210"` |
| `LandlineNumber()` | `"022-25678901"` |

### 📍 Addresses
| Method | Example Output |
|:---|:---|
| `State()` | `"Maharashtra"` |
| `UnionTerritory()` | `"Delhi"` |
| `StateOrUt()` | `"Karnataka"` |
| `City()` | `"Pune"` |
| `StateCapital()` | `"Bengaluru"` |
| `PinCode()` | `"411001"` |
| `PinCodeForState("Maharashtra")` | `"4XXXXX"` (zone-accurate) |
| `Locality()` | `"Koregaon Park"` |
| `RoadName()` | `"MG Road"` |
| `StreetAddress()` | `"42, Nehru Nagar, MG Road"` |
| `FullAddress()` | `"42, Nehru Nagar, MG Road, Pune, Maharashtra - 411042"` |

### 🏦 Financial
| Method | Example Output |
|:---|:---|
| `BankName()` | `"HDFC Bank"` |
| `IfscCode()` | `"SBIN0012345"` |
| `IfscCodeForBank("HDFC Bank")` | `"HDFC0012345"` |
| `UpiId()` | `"arjun.sharma@upi"` |
| `BankAccountNumber()` | `"12345678901234"` |
| `Gstin()` | `"27BQKPS4271R1Z5"` |

### 🚗 Vehicle
| Method | Example Output |
|:---|:---|
| `VehicleRegistration()` | `"MH 02 AB 1234"` |

## 🎯 Supported Frameworks

- .NET Standard 2.0+ (works with .NET Core 2.0+, .NET 5/6/7/8/9/10, and .NET Framework 4.6.1+)

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request. Some ideas:
- Add more regional names (specific language/community datasets)
- Add Indian company names
- Add educational institution names
- Improve PIN code accuracy with real postal data
- Add MICR codes

## 📄 License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgements

- [Bogus](https://github.com/bchavez/Bogus) by Brian Chavez — the amazing fake data generator this package extends.
- The Indian developer community for inspiration and feedback.
