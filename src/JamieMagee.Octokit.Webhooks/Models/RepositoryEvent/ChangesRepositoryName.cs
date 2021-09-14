﻿namespace JamieMagee.Octokit.Webhooks.Models.RepositoryEvent
{
    using System.Text.Json.Serialization;

    public class ChangesRepositoryName
    {
        [JsonPropertyName("from")]
        public string From { get; init; } = null!;
    }
}
