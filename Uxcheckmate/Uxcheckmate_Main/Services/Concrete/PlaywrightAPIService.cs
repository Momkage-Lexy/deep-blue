using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Uxcheckmate_Main.Models;

namespace Uxcheckmate_Main.Services
{
    public class PlaywrightApiService : IPlaywrightApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _playwrightServiceUrl;

        public PlaywrightApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            // Add this to appsettings.json → "PlaywrightServiceUrl": "http://localhost:5000"
            _playwrightServiceUrl = configuration["PlaywrightServiceUrl"];
        }

        // Sends a POST request to the Playwright service to analyze a website
        public async Task<PlaywrightAnalysisResult?> AnalyzeWebsiteAsync(string url, bool fullPage = false)
        {
            // Construct the request body with the target URL and optional fullPage flag
            var requestBody = new
            {
                url = url,
                fullPage = fullPage
            };

            // Serialize the request body to JSON
            var json = JsonSerializer.Serialize(requestBody);

            // Create the HTTP request content using UTF-8 encoding and JSON MIME type
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send a POST request to the /analyze endpoint of the Playwright service
            var response = await _httpClient.PostAsync($"{_playwrightServiceUrl}/analyze", content);

            // If the request failed, return null
            if (!response.IsSuccessStatusCode)
                return null;

            // Read the JSON response content as a string
            var responseContent = await response.Content.ReadAsStringAsync();

            // Deserialize the JSON response to a strongly typed result model
            var result = JsonSerializer.Deserialize<PlaywrightAnalysisResult>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Allow flexible casing in JSON keys
            });

            // Return the deserialized analysis result
            return result;
        }
    }

    public class PlaywrightAnalysisResult
    {
        public string? Url { get; set; }
        public string? ScreenshotBase64 { get; set; }
        public string Html { get; set; }
        public int Headings { get; set; }
        public int Paragraphs { get; set; }
        public string? TextContent { get; set; }
        public List<string> Fonts { get; set; } = new();
        public AxeCoreResults? AxeResults { get; set; }
        public bool HasFavicon { get; set; }
        public string? FaviconUrl { get; set; }
        public List<string> ExternalCssContents { get; set; } = new();
        public List<string> ExternalJsContents { get; set; } = new();
        public List<string> InlineCssList { get; set; } = new();
        public List<string> InlineJsList { get; set; } = new();
        public List<string> ExternalCssLinks { get; set; } = new();
        public List<string> ExternalJsLinks { get; set; } = new();
        public List<string> Links { get; set; } = new();
        public int ScrollHeight { get; set; }
        public int ScrollWidth { get; set; }
        public int ViewportHeight { get; set; }
        public int ViewportWidth { get; set; }
        public string? ViewportLabel { get; set; }
        public List<HtmlElement> LayoutElements { get; set; } = new();

    }
}
