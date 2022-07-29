using System.Net.Http.Json;

namespace ClubMateNotifier;

public class Pushbullet
{
    private const string PushbulletApi = "https://api.pushbullet.com/v2";
    private readonly string _pushbulletToken;
    private HttpClient _httpClient;

    public Pushbullet(HttpClient httpClient, string token)
    {
        _httpClient = httpClient;
        _pushbulletToken = token;
        
        _httpClient.DefaultRequestHeaders.Add("Access-Token", token);
    }
    
    public async Task NotifyUser(string message)
    {
        var notificationResponse = await _httpClient.PostAsJsonAsync($"{PushbulletApi}/pushes", new
        {
            Type = "note",
            Title = "ClubMateNotifier",
            Body = message
        });

        if (!notificationResponse.IsSuccessStatusCode)
        {
            throw new ApplicationException("Failed to send notification.");
        }
    }
    
    
    
    
}