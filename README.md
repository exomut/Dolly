# Dolly: Dall-E Client

Built with ASP.net Blazor WebAssembly to reduce the amount of remote connections to my server.

Dolly does not include an API key allowing you to sign up for an OpenAI account and use your own API Key without having to program your own app.

[OpenAI Pricing and Sign Up](https://openai.com/api/pricing/)

## Features

- Bulk Image Generation: A max of 10 images can be generated for any given prompt at a time.
- Size Selection: Choose between 256, 512, or 1024 pixel squares.
- Use your own API Key.
- WebAssembly: Limits server calls and can be installed as an app.

## Git Hub Pages

[Live Project]("https://exomut.github.io/Dolly")

## Warning

OpenAI has a strict [Content Policy](https://labs.openai.com/policies/content-policy).

If your image is not being processed, it is probably due to a Content Policy issue or an API Key issue. Double check your key and make sure your promt does not include policy breaking topics.

### Roadmap

- Better error handling.
  - Show user a warning with what need to be fixed when an error occurs.
- Clean up the design.
  - Create a logo.
  - Fix layout issues.
- Add other Dall-E features.
  - Similar image creation.
  - Image masking creation.
