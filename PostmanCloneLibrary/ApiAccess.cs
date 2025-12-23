using System.Text;
using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();
    //overload for CallApiAsync in order not to handle code which is not ment to be
    //handled by the UI(converting the content to HTTPContent)
    public async Task<string> CallApiAsync(
       string url,
       string content,
       HttpAction action = HttpAction.GET,
       bool formatOutput = true
       )
    {
        //StringContent is a child from HTTP content
        StringContent stringContent = new(content, Encoding.UTF8, "application/json");
        return await CallApiAsync(url, stringContent, action, formatOutput);
    }

    public async Task<string> CallApiAsync(
        string url,
        HttpContent? content = null,
        HttpAction action = HttpAction.GET,
        bool formatOutput = true
        )

    {
        HttpResponseMessage? response;
        switch (action)
        {
            case HttpAction.GET:
                response = await client.GetAsync(url);
                break;
            case HttpAction.POST:
                response = await client.PostAsync(url, content);
                break;
            case HttpAction.PUT:
                response = await client.PutAsync(url, content);
                break;
            case HttpAction.PATCH:
                response = await client.PatchAsync(url, content);
                break;
            case HttpAction.DELETE:
                response = await client.DeleteAsync(url);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, null);
        }

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            //return raw/prety JASON
            if (formatOutput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement,
                    new JsonSerializerOptions { WriteIndented = true });

            }
            return json;
        }
        else
        {
            return $"Error:" + response.StatusCode;
        }
    }

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }
        //is valid URI and HTTPS (if URI is valid, means URL is valid too, bcs its part of the URI) 
        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri outputUri) &&

            (outputUri.Scheme == Uri.UriSchemeHttps);
        return output;
    }
}
