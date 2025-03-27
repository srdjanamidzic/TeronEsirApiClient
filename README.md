# TeronEsirApiClient
Simple facade for .NET HttpClient covering all\* requests described in the [Teron ESIR API docs](https://api.teron.rs/#d23695c8-a874-44b4-b89b-7a867056d3c5) (also applicable to [OFS P5 EFU ESIR](https://api.ofs.ba/), since they are nearly identical).

Bug-reports and pull requests are welcome.

\* *E-Faktura requests are currently not supported.*

## Installation
Install the package [with NuGet]("https://link.to.nuget"):
```
Install-Package TeronEsirApiClient
```

Or using the .NET CLI:
```
dotnet add package TeronEsirApiClient
```

## Usage
A new instance of `TeronEsirApiClient` is created by passing it an instance of `HttpClient` via the constructor: 
```csharp
TeronEsirApiClient client = new TeronEsirApiClient(myHttpClient);
```

It us up to you to construct the `HttpClient` beforehand. Reading up on [Microsoft's best practices](https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines) for using the `HttpClient` is recommended.

All of the methods return the result of type `TeronEsirResult`, or `TeronEsirResult<T>` if there is data that needs to be returned from the API. This type contains the following properties:
```csharp
 // Whether the operation was successful or not
 public bool IsSuccessful { get; } 
 
 // Message from the API
 public string Message { get; }
 
 // Raw response content from the API
 public string RawResponse { get; }
 
 // The value returned (if applicable)
 public T Value { get; }
```

### Fiscalization request example
Following is a fiscalization request example inside a ASP.NET 9 WebAPI controller:
```csharp
[HttpPut("fiscalize")]
public async Task<IActionResult> Fiscalize([FromServices] IHttpClientFactory httpClientFactory)
{
    var httpClient = httpClientFactory.CreateClient();
    var teronEsirClient = new TeronEsirApiClient(httpClient);

    TeronEsirApiParameters apiParams = new("http://192.168.1.100:3566", "Bearer myBearerToken32432523523");

    // Check if available
    bool isAvaliable = await teronEsirClient.IsAvailableAsync(apiParams);
    if (!isAvaliable) return BadRequest("ESIR unavaliable");

    // Check if secure element is inserted
    var statusResult = await teronEsirClient.GetStatusAsync(apiParams);
    if (!statusResult.IsSuccessful)
    {
        return BadRequest(statusResult.Message);
    }

    if (statusResult.Value!.Gsc.Contains(TeronEsirClient.Enums.LpfrStatus.SmartCardNotPresent))
    {
        return BadRequest("Secure element not inserted");
    }

    if (statusResult.Value!.Gsc.Contains(TeronEsirClient.Enums.LpfrStatus.SmartCardNotPresent))
    {
        return BadRequest("Secure element not inserted");
    }

    // Check if pin is required and enter it
    if (statusResult.Value!.Gsc.Contains(TeronEsirClient.Enums.LpfrStatus.PinCodeRequired))
    {
        var unlockResult = await teronEsirClient.UnlockSecureElementAsync(apiParams, "1234");
        if (!unlockResult.IsSuccessful)
        {
            return BadRequest(unlockResult.Message);
        }
    }


    TeronEsirInvoice teronEsirInvoice = new()
    {
        InvoiceRequest = new TeronEsirInvoiceRequest
        {
            InvoiceType = TeronEsirClient.Enums.InvoiceType.Normal,
            TransactionType = TeronEsirClient.Enums.TransactionType.Sale,
            Payment = [
                    new TeronEsirPayment {
                        PaymentType = TeronEsirClient.Enums.PaymentType.Cash,
                        Amount = 50,
                    },
                    new TeronEsirPayment {
                        PaymentType = TeronEsirClient.Enums.PaymentType.Card,
                        Amount = 50,
                    }
                ],
            Cashier = "John Smith",
            BuyerId = "JOHN1234",
            BuyerCostCenterId = "COSTCENTER1234",
            Items = [
                    new TeronEsirInvoiceItem {
                        Name = "Item 1",
                        Gtin = "12345678",
                        Labels = ["A"],
                        UnitPrice = 25,
                        Quantity = 2,
                        TotalAmount = 50,
                        Discount = 0,
                        DiscountAmount = 0,
                    },
                    new TeronEsirInvoiceItem {
                        Name = "Item 2",
                        Gtin = "22345678",
                        Labels = ["A"],
                        UnitPrice = 50,
                        Quantity = 1,
                        TotalAmount = 50,
                        Discount = 0,
                        DiscountAmount = 0,
                    }
                ],
        },
        Print = true,
        Email = "johnsmith@somecompany.com",
        RenderReceiptImage = true,
        ReceiptImageFormat = TeronEsirClient.Enums.ReceiptImageFormat.Png,
        ReceiptLayout = TeronEsirClient.Enums.ReceiptLayout.Slip,
        ReceiptFooterTextLines = ["Line 1", "Line 2"],
    };

    var fiscalizationResult = await teronEsirClient.IssueInvoiceAsync(apiParams, teronEsirInvoice);
    if (!fiscalizationResult.IsSuccessful)
    {
        return BadRequest(fiscalizationResult.Message);
    }


    return Ok($"Fiscalized invoice: {fiscalizationResult.Value.InvoiceNumber} and sent to email.");
}
```
