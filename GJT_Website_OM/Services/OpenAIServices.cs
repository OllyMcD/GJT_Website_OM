using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class OpenAIService
{
    private readonly HttpClient _httpClient;
    private const string ApiUrl = "https://api.openai.com/v1/chat/completions"; // Adjust endpoint if needed
    private readonly string _apiKey;

    public OpenAIService(HttpClient httpClient, string apiKey)
    {
        _httpClient = httpClient;
        _apiKey = apiKey;
    }

    public async Task<string> GetResponseAsync(string prompt)
    {
        var requestData = new
        {
            model = "gpt-4", // Adjust model if needed
            messages = new[] { new { role = "user", content = prompt } },
            max_tokens = 1000,
            temperature = 0.7
        };

        var requestContent = new StringContent(
            JsonSerializer.Serialize(requestData),
            Encoding.UTF8,
            "application/json"
        );

        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", _apiKey);

        var response = await _httpClient.PostAsync(ApiUrl, requestContent);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        var jsonResponse = JsonSerializer.Deserialize<JsonElement>(responseContent);

        return jsonResponse.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
    }
}
