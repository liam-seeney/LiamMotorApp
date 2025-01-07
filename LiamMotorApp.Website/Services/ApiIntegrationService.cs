﻿using LiamMotorApp.Website.Services.Interfaces;
using System.Text.Json;

namespace LiamMotorApp.Website.Services;

public class ApiIntegrationService(HttpClient http) : IApiIntegrationService
{
  private readonly HttpClient _http = http;

  private readonly JsonSerializerOptions _jsonSerializerOptions = new()
  {
    PropertyNameCaseInsensitive = true
  };

  public async Task<T?> GetAsync<T>(string url)
  {
    HttpResponseMessage response = await _http.GetAsync(url);
    string responseBody = await response.Content.ReadAsStringAsync();
    T? result = JsonSerializer.Deserialize<T>(responseBody, _jsonSerializerOptions);
    return result;
  }

  public async Task PostAsync<T>(string url, T data)
  {
    await _http.PostAsJsonAsync(url, data);
  }
}
