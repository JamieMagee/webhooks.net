﻿namespace JamieMagee.Octokit.Webhooks.Models.RepositoryEvent
{
    using System.Text.Json.Serialization;

    public record ChangesOwnerFrom
    {
        [JsonPropertyName("user")]
        public User? User { get; init; }
    };
}
