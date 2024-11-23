namespace ai_recipes_blazor.Data.DTOs;

public class ImageResponse
{
    public long created { get; set; }
    
    public List<Data> data { get; set; }
}

public class Data
{
    public string url { get; set; }
}