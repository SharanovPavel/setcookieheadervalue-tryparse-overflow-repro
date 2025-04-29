using Microsoft.Net.Http.Headers;

// throws an exception
var maxAgeOverflowedValue = 922337203686;
SetCookieHeaderValue.TryParse($"sessionId=abc123; Path=/; HttpOnly; Secure; SameSite=Strict; Max-Age={maxAgeOverflowedValue}; Expires=Thu, 01 May 2025 12:00:00 GMT", out var _);

// doesn't throw an exception
var validMaxAgeValue = 922337203685;
SetCookieHeaderValue.TryParse($"sessionId=abc123; Path=/; HttpOnly; Secure; SameSite=Strict; Max-Age={validMaxAgeValue}; Expires=Thu, 01 May 2025 12:00:00 GMT", out var _);

