# KeyPay Client and Sample Usage

This is the .NET client V2 for the KeyPay API.

## Get Started

The KeyPayV2 Client can be installed using the Nuget package manager.

```
Install-Package KeyPayV2
```

## Example

```
	var apiKey = "{your KeyPay API Key goes here}";
	
	// Create a client instance
	var api = new UkApiClient("https://api.yourpayroll.com.uk/api/v2",
                              new ApiKeyAuthenticationDetails(apiKey));

	// Retrieve a list of the businesses associated with the API Key
	var businesses = api.Business.ListBusinesses();
```

## More Help?

There is a Sample Application that demonstrates a few core concepts of working with the KeyPay Client. Please check out our [online documentation](http://api.keypay.com.au/) as a reference, or contact our [Support](https://keypay.com.au/contact).

The sample application may be found in `test/SampleApplication`. Front-end dependencies are managed using Bower. With [Bower installed in your local environment](https://bower.io/#install-bower), run `bower install` within the `test/SampleApplication` directory to install front-end dependencies to the `test/SampleApplication/wwwroot/lib` directory.

# Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
