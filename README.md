# keypay-dotnet
.NET client for the KeyPay API


### Get Started
The KeyPay Client can be installed using the Nuget package manager.

```
Install-Package KeyPay
```

### Example
```csharp
	var apiKey = "{your KeyPay API Key goes here}";
	
	// Create a client instance
	var client = new KeyPayApiV2Client("https://api.yourpayroll.com.au/api/v2", apiKey)));
	
	// Retrieve a list of the businesses associated with the API Key
	var business = client.Business.List();
```

### More Help?
There is a Sample Application that demonstrates a few core concepts of working with the KeyPay Client. 
Please check out our [online documentation](http://api.keypay.com.au/) as a reference, or contact our [Support](https://keypay.com.au/contact)
## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.