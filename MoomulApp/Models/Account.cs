using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MoomulApp.Models;

public class Account
{
    public Ulid Id { get; set; }
    [JsonProperty("id")]
    public string StringId => Id.ToString();
    [JsonProperty("pk")]
    public string PartitionKey => Id.ToString();
    public string Name { get; set; }
    public string Provider { get; set; }
    public long Points { get; set; }
    public DateTimeOffset? DropoutAt { get; set; }
    public List<Ulid> BlockedIds { get; set; }
    public List<Ulid> ReportedIds { get; set; }
    public List<Box> Boxes { get; set; }
}