using System.Text.Json;
using System.Text.Json.Serialization;

namespace Novolis.Install.Registry;

public sealed class RegistryIndex
{
    [JsonPropertyName("packages")]
    public List<RegistryPackageRef> Packages { get; init; } = [];

    public static async Task<RegistryIndex> LoadAsync(Uri indexUri, CancellationToken cancellationToken = default)
    {
        using var client = new HttpClient();
        await using var stream = await client.GetStreamAsync(indexUri, cancellationToken);
        return await JsonSerializer.DeserializeAsync<RegistryIndex>(stream, JsonSourceGenerationContext.Default.RegistryIndex, cancellationToken)
            ?? new RegistryIndex();
    }
}

public sealed class RegistryPackageRef
{
    [JsonPropertyName("id")]
    public string Id { get; init; } = "";

    [JsonPropertyName("manifest")]
    public string Manifest { get; init; } = "";
}

[JsonSerializable(typeof(RegistryIndex))]
internal partial class JsonSourceGenerationContext : JsonSerializerContext;
